using BasicPOE.Classes;
using POE_FINAL.Classes.Task_1_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POE_FINAL
{
    public partial class frmSortingGame : Form
    {
        public frmSortingGame()
        {
            InitializeComponent();
        }

        //Global Variables----------------------------------------------------------------------------------------------
        /// <summary>
        /// The structure that is used to store the different values
        /// </summary>
        public struct Book
        {
            public double ReferenceNumber;
            public string AuthorName;
            public double Unicode;
        }

        private List<Book> lBooks = new List<Book>();
        private Booked bookey = new Booked();
        //using code from https://www.techiedelight.com/measure-execution-time-csharp/
        private Stopwatch sw = new Stopwatch(); // measures how long it takes
        private Messages ms = new Messages();
        private int len = 1100; //  this is for the animation of the results pannel
        private int Attempts = 1; // this is used to keep track of attempts on a single one

        //Animation Methods---------------------------------------------------------------------------------------------
        /// <summary>
        /// This creates the animation of the pannel sliding accross the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tAnimation_Tick(object sender, EventArgs e)
        {
            //int len = starting point
            if (len != 0)
            {
                len -= 10;
                pnlResults.Location = new Point(len, 80);
                pnlResults.Update();
            }
            else
                tAnimation.Stop();
        }

        //Form Methods--------------------------------------------------------------------------------------------------
        /// <summary>
        /// This starts the game and sets everything into motion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Book book = bookey.GenBook(rnd); // only needs to use one random object https://csharpindepth.com/articles/Random
                lBooks.Add(book); // this generates a new book automatically
                lvBooks.Items.Add(bookey.StringValue(lBooks[i]));
            }

            // creates the tiles
            lvBooks.View = View.Tile;
            lvBooks.Alignment = ListViewAlignment.Top;
            lvBooks.TileSize = new System.Drawing.Size(220, 30);
            btnDone.Enabled = true;
            sw.Start();
        }

        /// <summary>
        /// This is the close button for the application on this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            ms.ExitMessage();
        }

        /// <summary>
        /// When the user wants to confirm if they have the right order they click this button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDone_Click(object sender, EventArgs e)
        {
            btnDone.Enabled = false;


            //MessageBox.Show(sw.ElapsedMilliseconds.ToString());

            // The list the user has, one of the structures the other of the unicode
            List<string> lUserBooks = new List<string>();
            //List<double> luniUser = new List<double>();
            SortByNumbers(0, lBooks.Count - 1);

            // adding the user's books to their list
            for (int i = 0; i < lvBooks.Items.Count; i++)
            {
                lUserBooks.Add(lvBooks.Items[i].Text);
            }

            /*
            //Conversion to a unicode List
            for (int i = 0; i < lUserBooks.Count; i++)
            {
                string refer = lUserBooks[i].Substring(lUserBooks[i].IndexOf(" ") + 1);
                string uni = bookey.unicodeConversion(refer).ToString();
                luniUser.Add(double.Parse(lUserBooks[i].Substring(0, lUserBooks[i].IndexOf(" ")) + uni));
            } */

            //Comparison
            // KEEP IN MIND: https://stackoverflow.com/questions/454916/performance-of-arrays-vs-lists
            bool bFlag = false;
            int iWrong = 0; // This is to solve the bug of only having one not sorted
            for (int i = 0; i < lBooks.Count; i++)
            {
                //if (luniUser[i] != lBooks[i].Unicode)
                if (!lUserBooks[i].Equals(bookey.StringValue(lBooks[i])))
                {
                    //MessageBox.Show(lUserBooks[i].ToString() + " is in the wrong place");
                    bFlag = true;
                    iWrong++;
                }
            }
            if (iWrong == 1 || !bFlag)
            {
                sw.Stop();
                ms.SuccessMessage("You have put them in right order");
                lvBooks.Clear();
                lBooks.Clear();
                btnStart.Enabled = true;
                btnUp.Enabled = false;
                btnDown.Enabled = false;
                pbArrow.Visible = false;
                lblSelected.Visible = false;
                GenerateReport(sw.ElapsedMilliseconds);
                tAnimation.Start();
            }
            else
            {
                btnDone.Enabled = true;
                ms.ErrorMessage("You have put them in wrong order, " + iWrong + " items are wrong");
                Attempts++;
            }


        }

        /// <summary>
        /// When the form loads a few things need to be set as a default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSortingGame_Load(object sender, EventArgs e)
        {
            pnlResults.Location = new Point(len, 80);
            lblPointsGoal.Text = Program.acheivedPoints.ToString() + "/" + Program.goalPoints.ToString();
            lblGoalAttempts.Text = Program.acheivedAttempts.ToString() + "/" + Program.goalAttempts.ToString();
        }

        /// <summary>
        /// This button is on the pannel after the results have been displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinishReport_Click(object sender, EventArgs e)
        {
            //Hiding the form
            frmHome frm = new frmHome();
            Program.acheivedAttempts++;
            frm.Show();
            this.Hide();
        }

        /// <summary>
        /// This button returns to the main home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.backBtnClicked = true;
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }

        //Add & Move Items Methods--------------------------------------------------------------------------------------
        /// <summary>
        /// This draws the blocks of the items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvBooks_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            try
            {
                e.Graphics.FillRectangle(Brushes.Lime, e.Bounds);
                e.Graphics.DrawRectangle(Pens.Black, e.Bounds);

                //Segoe UI, 21.75pt, style=BoldbtnStart.Font
                Font ftItem = new Font("Segoe UI", 15);
                TextRenderer.DrawText(e.Graphics, e.Item.Text, ftItem, e.Bounds, Color.Black, Color.Empty, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            catch (Exception ex)
            {
                ms.ErrorMessage(ex.ToString());
            }

        }

        /// <summary>
        /// Button click for moving the item up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItems(-1, 0);
            moveArrow();
        }

        /// <summary>
        /// Button click for moving the item down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItems(1, 9);
            moveArrow();
        }

        /// <summary>
        ///  This moves the item up in the list however many places it is given in iMove, iMax indicates the max range of movement
        /// </summary>
        /// <param name="iMove"></param>
        /// <param name="iMax"></param>
        private void MoveItems(int iMove, int iMax)
        {
            try
            {
                int iSelected = lvBooks.SelectedItems[0].Index;
                if (iSelected != iMax)
                {
                    string lviSelected = lvBooks.Items[iSelected].Text;
                    lvBooks.Items.RemoveAt(iSelected);
                    lvBooks.Items.Insert(iSelected + iMove, lviSelected);
                    // this fixes the bug from: https://stackoverflow.com/questions/5591269/net-inserting-with-index-in-a-listview-in-largeicon-mode-dont-display-inserte
                    lvBooks.Alignment = ListViewAlignment.Default;
                    lvBooks.Alignment = ListViewAlignment.Top;
                }
                // Reseting what item is selected https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.listviewitem.selected?view=windowsdesktop-6.0
                lvBooks.Items[iSelected + iMove].Selected = true;
            }
            catch (Exception ex)
            {
                ms.ErrorMessage(ex.ToString());
                // do nothing
            }// end of catch
        }

        /// <summary>
        /// When the lvBooks is clicked make the arrow and label visible and then moves it
        /// it is done here because it is happens when it is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvBooks_Click(object sender, EventArgs e)
        {
            pbArrow.Visible = true;
            lblSelected.Visible = true;
            moveArrow();
        }

        /// <summary>
        /// Moves the arrow and the label to the selected index
        /// </summary>
        private void moveArrow()
        {
            int iSelected = lvBooks.SelectedItems[0].Index;
            int iPos = 125 + (iSelected * 30);
            pbArrow.Location = new Point(205, iPos);
            lblSelected.Location = new Point(105, iPos);

        }

        //Other Methods-------------------------------------------------------------------------------------------------
        /// <summary>
        /// This Method uses a quick sort to sort the books PURELY BY THEIR NUMBERS
        /// Using code from: https://code-maze.com/csharp-quicksort-algorithm/
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void SortByNumbers(int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = lBooks[left].ReferenceNumber;
            while (i <= j)
            {
                while (lBooks[i].ReferenceNumber < pivot)
                    i++;

                while (lBooks[j].ReferenceNumber > pivot)
                    j--;

                if (i <= j)
                {
                    var temp = lBooks[i];
                    lBooks[i] = lBooks[j];
                    lBooks[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                SortByNumbers(left, j);
            if (i < right)
                SortByNumbers(i, right);
        }

        /// <summary>
        /// This method generates the report of how long they took and then saves their points to their total
        /// </summary>
        /// <param name="elapsedMilliseconds"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void GenerateReport(double elapsedMilliseconds)
        {
            int seconds = (int)Math.Round(elapsedMilliseconds / 1000);
            int pointsEarnt = 65 - seconds - (Attempts * 2);
            //MessageBox.Show(seconds.ToString() + " seconds " + pointsEarnt.ToString() + "Points");
            string rank;
            
            switch(seconds)
            {
                case int i when i < 10:
                    rank = "S+";
                    break;
                case int i when i >= 10 && i < 15:
                    rank = "S";
                    break;
                case int i when i >= 15 && i < 20:
                    rank = "A+";
                    break;
                case int i when i >= 20 && i < 25:
                    rank = "A";
                    break;
                case int i when i >= 25 && i < 30: //25
                    rank = "B+";
                    break;
                case int i when i >= 30 && i < 35: //30
                    rank = "B";
                    break;
                case int i when i >= 35 && i < 40: //35
                    rank = "C+";
                    break;
                case int i when i >= 40 && i < 45: //40
                    rank = "C";
                    break;
                case int i when i >= 45 && i < 50: //45
                    rank = "D+";
                    break;
                case int i when i >= 50 && i < 55: //50
                    rank = "D";
                    break;
                case int i when i >= 55 && i < 60: //55
                    rank = "E+";
                    break;
                case int i when i >= 60 && i < 65:// 60
                    rank = "E";
                    break;
                default:
                    rank = "F";
                    break;
            }
            if (rank == "F")
                pointsEarnt = 0;
            // Displaying on the labels
            lblGrade.Text = rank;
            lblTimeTaken.Text = seconds.ToString()+" Seconds";
            lblAttempts.Text = Attempts.ToString()+" Attempts";
            lblPointsEarnt.Text = pointsEarnt.ToString()+" Points";

            Program.acheivedPoints += pointsEarnt;
            //SetLabels(); this looks tacky here
        }

        //END OF PROGRAM------------------------------------------------------------------------------------------------
    }
}
