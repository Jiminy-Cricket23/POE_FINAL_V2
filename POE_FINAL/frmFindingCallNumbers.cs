using POE_FINAL.Classes;
using POE_FINAL.Classes.Task_1_Classes;
using System;
using System.CodeDom.Compiler;
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
        // This is for the animation of the results pannel
        private int iLen = 1300; 
        private int iLvl1 = 600;
        private int iLvl2 = 600;
        private int iLvl3 = 600;
        // Objects that are used
        private Messages ms = new Messages();
        private Random rnd = new Random();
        // Tree Variables
        private TreeNode<string> dewey = new TreeNode<string>("dewey");
        private List<TreeNode<string>> lvl1 = new List<TreeNode<string>>();
        private List<TreeNode<string>> lvl2 = new List<TreeNode<string>>();
        private List<TreeNode<string>> lvl3 = new List<TreeNode<string>>();
        // Array for the unassigned numbers
        private int[] arrUnassigned = {7, 8, 9, 13, 29,
            40, 41, 42, 43, 44, 45, 46, 47, 48,
            49, 104, 112, 125, 132, 134, 136, 151, 157,
            159, 163, 164, 216, 217, 219, 237, 244, 245,
            256, 257, 258, 288, 291, 298, 308, 309, 311,
            312, 313, 329, 376, 377, 396, 397, 416, 424,
            426, 434, 436, 444, 446, 454, 456, 464, 466,
            474, 476, 484, 486, 504, 517, 524, 544, 545,
            574, 589, 619, 626, 654, 655, 656, 689, 699,
            744, 756, 762, 768, 777, 789, 804, 819, 921,
            922, 923, 924, 925, 926, 927, 928, 991, 992};
        //Variables for the game
        private string sGen;
        private int[] arrSelectedlvl1 = new int[4];

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
                        //MessageBox.Show("Level 2 added " + sLine);
                    }
                    else
                    {
                        //int iNum = int.Parse(sLine.Substring(1,2));
                        //MessageBox.Show(iNum.ToString());
                        lvl3.Add(lvl2[lvl2.Count- 1].AddChild(sLine.Substring(1, sLine.Length-1)));
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
            /* This shows the tree on the redOutput richedit
            foreach (TreeNode<string> node in dewey)
            {
                string indent = CreateIndent(node.Level);
                redOutput.Text += "\n"+indent + (node.Data ?? "null");
            } */
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
            //tLevel1.Start();
            
                int iGen = 0;
                bool bFlag = true;

                while (bFlag)
                {
                    iGen = rnd.Next(1000);
                    if (arrUnassigned.Contains(iGen))
                        continue;
                    bFlag = false;
                }

            sGen = GenerateCallNumber(iGen);
            MessageBox.Show(sGen);

            AssignLevel1Buttons();
            //AssignLevel2Buttons();
            //AssignLevel3Buttons();

            tLevel1.Start();

        }

        /// <summary>
        /// This method returns a properly formatted call number
        /// </summary>
        /// <param name="iGen"></param>
        /// <returns></returns>
        private string GenerateCallNumber(int iGen)
        {
            if (iGen < 10)
                return "00" + iGen;
            else if (iGen < 100)
                return "0" + iGen;
            else
                return iGen.ToString();
        }

        private void AssignLevel3Buttons()
        {
            throw new NotImplementedException();
        }

        private void AssignLevel2Buttons()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This assigns the first level buttons
        /// </summary>
        private void AssignLevel1Buttons()
        {
            arrSelectedlvl1[0] = int.Parse(sGen[0].ToString())*100;

            //Getting the 3 other random numbers
            for (int i = 1; i< 4; i++)
            {
                bool bFlag = true;
                int iGen = 0;
                while (bFlag)
                {
                    iGen = rnd.Next(10)*100;
                    if (arrSelectedlvl1.Contains(iGen))
                        continue;
                    arrSelectedlvl1[i] = iGen;
                    bFlag = false;
                }
            }

            //Sorting the array
            Sortlvl1(0, arrSelectedlvl1.Length - 1);

            //Finding the different lvl1 call numbers
            string[] arrSelected = new string[arrSelectedlvl1.Length];
            for (int i = 0; i< arrSelectedlvl1.Length; i++)
            {
                arrSelected[i] = dewey.FindTreeNode(node => node.Data != null && node.Data.Contains(arrSelectedlvl1[i].ToString())).ToString(); 
            }

            btnOption1.Text += ": " + arrSelected[0];
            btnOption2.Text += ": " + arrSelected[1];
            btnOption3.Text += ": " + arrSelected[2];
            btnOption4.Text += ": " + arrSelected[3];

            

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

        /// <summary>
        /// This Method uses a quick sort to sort the books PURELY BY THEIR NUMBERS
        /// Using code from: https://code-maze.com/csharp-quicksort-algorithm/
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void Sortlvl1(int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = arrSelectedlvl1[left];
            while (i <= j)
            {
                while (arrSelectedlvl1[i] < pivot)
                    i++;

                while (arrSelectedlvl1[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var temp = arrSelectedlvl1[i];
                    arrSelectedlvl1[i] = arrSelectedlvl1[j];
                    arrSelectedlvl1[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                Sortlvl1(left, j);
            if (i < right)
                Sortlvl1(i, right);
        }
    }
}
