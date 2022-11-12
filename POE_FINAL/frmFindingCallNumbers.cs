using POE_FINAL.Classes;
using POE_FINAL.Classes.Task_1_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_FINAL
{
    public partial class frmFindingCallNumbers : Form
    {
        private int iLen = 1300; //  this is for the animation of the results pannel
        private int iLvl1 = 600;
        private int iLvl2 = 600;
        private int iLvl3 = 600;
        private Messages ms = new Messages();
        private TreeNode<string> dewey = new TreeNode<string>("dewey");
        private List<TreeNode<string>> lvl1 = new List<TreeNode<string>>();
        private List<TreeNode<string>> lvl2 = new List<TreeNode<string>>();
        private List<TreeNode<string>> lvl3 = new List<TreeNode<string>>();
        public frmFindingCallNumbers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is for the final Results page animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tAnimation_Tick(object sender, EventArgs e)
        {
            //int len = starting point
            if (iLen != 0)
            {
                iLen -= 10;
                pnlResults.Location = new Point(iLen, 80);
                pnlResults.Update();
            }
            else
                tAnimation.Stop();
        }

        /// <summary>
        /// This is to show the first level page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tLevel1_Tick(object sender, EventArgs e)
        {
            //int len = starting point
            if (iLvl1 != 80)
            {
                iLvl1 -= 10;
                pnlLevel1.Location = new Point(0, iLvl1);
                pnlLevel1.Update();
            }
            else
                tLevel1.Stop();
        }

        /// <summary>
        /// As soon as the page loads everything resets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFindingCallNumbers_Load(object sender, EventArgs e)
        {
            pnlResults.Location = new Point(iLen, 80);
            pnlLevel1.Location = new Point(0, iLvl1);
            pnlLevel2.Location = new Point(0, iLvl2);
            pnlLevel3.Location = new Point(0, iLvl3);
            lblPointsGoal.Text = Program.acheivedPoints.ToString() + "/" + Program.goalPoints.ToString();
            lblGoalAttempts.Text = Program.acheivedAttempts.ToString() + "/" + Program.goalAttempts.ToString();

            //finding the file path
            // using info from: https://stackoverflow.com/questions/27181774/get-resources-folder-path-c-sharp
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string sPath = RunningPath.Substring(0, RunningPath.LastIndexOf("bin")) + "Resources\\DDC.txt";
            string sLine;
            int i = 0; // this is needed due to missing areas 

            try
            {
                StreamReader sr = new StreamReader(sPath);
                sLine = sr.ReadLine();

                while (sLine != null)
                {
                    if (sLine[0].Equals('!'))
                    {
                        lvl1.Add(dewey.AddChild(sLine.Substring(1,sLine.Length-1)));
                        //MessageBox.Show("Level 1 added "+sLine);
                    }
                    else if (sLine[0].Equals('@'))
                    {
                        int iNum = int.Parse(sLine.Substring(1,1));
                        //MessageBox.Show(iNum.ToString());
                        lvl2.Add(lvl1[iNum].AddChild(sLine.Substring(1, sLine.Length-1)));
                        i++;
                        //MessageBox.Show("Level 2 added " + sLine);
                    }
                    else
                    {
                        //int iNum = int.Parse(sLine.Substring(1,2));
                        //MessageBox.Show(iNum.ToString());
                        lvl3.Add(lvl2[i-1].AddChild(sLine.Substring(1, sLine.Length-1)));
                        //MessageBox.Show("Level 3 added " + sLine);
                    }
                    //MessageBox.Show(sLine);
                    sLine = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            foreach (TreeNode<string> node in dewey)
            {
                string indent = CreateIndent(node.Level);
                redOutput.Text += "\n"+indent + (node.Data ?? "null");
            }
        }

        private static String CreateIndent(int depth)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < depth; i++)
            {
                sb.Append(' ');
            }
            return sb.ToString();
        }

        /// <summary>
        /// this is the animation for the 3rd level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tLevel3_Tick(object sender, EventArgs e)
        {
            //int len = starting point
            if (iLvl3 != 80)
            {
                iLvl3 -= 10;
                pnlLevel3.Location = new Point(0, iLvl3);
                pnlLevel3.Update();
            }
            else
                tLevel3.Stop();
        }

        /// <summary>
        /// this is the animation for the 2nd level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tLevel2_Tick(object sender, EventArgs e)
        {
            //int len = starting point
            if (iLvl2 != 80)
            {
                iLvl2 -= 10;
                pnlLevel2.Location = new Point(0, iLvl2);
                pnlLevel2.Update();
            }
            else
                tLevel2.Stop();
        }

        /// <summary>
        /// this is the close button that closes the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            ms.ExitMessage();
        }

        /// <summary>
        /// this is the button to go back to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }

        /// <summary>
        /// this button starts the game and loads everything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            tLevel1.Start();
            
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            tLevel2.Start();
        }

        private void btnL2Option1_Click(object sender, EventArgs e)
        {
            tLevel3.Start();
        }

        private void btnL3Option1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
