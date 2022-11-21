using POE_FINAL.Classes.Task_1_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POE_FINAL.frmSortingGame;

namespace POE_FINAL
{
    public partial class frmFindingAreas : Form
    {
        public frmFindingAreas()
        {
            InitializeComponent();
        }

        //Global Variables----------------------------------------------------------------------------------------------
        private Messages ms = new Messages();
        /* DO NOT NEED 2 DICTIONARIES
        private Dictionary<string, string> dicCategories = new Dictionary<string,string>(){
            {"000", "General Knowledge"},
            {"100", "Philosophy and Psychology"},
            {"200", "Religion"},
            {"300", "Social Sciences"},
            {"400", "Languages"},
            {"500", "Science"},
            {"600", "Technology"},
            {"700", "Arts and Recreation"},
            {"800", "Literature"},
            {"900", "History and Geography"}
        };
        private Dictionary<string, string> dicDescriptions = new Dictionary<string,string>(){
            {"General Knowledge1", "Things that everyone should know."},
            {"General Knowledge2", "Information that is gathered through different mediums."},
            {"General Knowledge3", "Knowledge that is not about a specific topic."},
            {"Philosophy and Psychology1", "Understanding how the human mind works."},
            {"Philosophy and Psychology2", "The study of how humans think."},
            {"Philosophy and Psychology3", "The study of the conscious and unconscious phenomena."},
            {"Religion1", "The study on a supernatural controlling power."},
            {"Religion2", "The study of Gods."},
            {"Religion3", "Books about theology."},
            {"Social Sciences1", "Books about human behaviour in its social and cultural aspects."},
            {"Social Sciences2", "The study of sciences that are social."},
            {"Social Sciences3", "Books about any science that is cultural."},
            {"Languages1", "Books about how people converse."},
            {"Languages2", "The study of phonic communication."},
            {"Languages3", "Books surrounding different languages."},
            {"Science1", "Books about the way the world works."},
            {"Science2", "The study of the observable world."},
            {"Science3", "Books about equations that describe the world."},
            {"Technology1", "The study of manmade creations."},
            {"Technology2", "Books about machinery."},
            {"Technology3", "Books about engineering and applied sciences."},
            {"Arts and Recreation1", "Books about sports."},
            {"Arts and Recreation2", "Books about music."},
            {"Arts and Recreation3", "Books about painting"},
            {"Literature1", "Books about how books were written"},
            {"Literature2", "Books about writers."},
            {"Literature3", "The study of writers communicating their work."},
            {"History and Geography1", "Books about what has happened in the world."},
            {"History and Geography2", "Books about navigating the world."},
            {"History and Geography3", "The study of what and where important events happened."}
        }; */
        // this dictionary stores the call numbers with an added digit to randomly get  1 of 3 descriptions
        private Dictionary<string, string> dicDescriptions = new Dictionary<string, string>(){
            {"0001", "Things that everyone should know."},
            {"0002", "Information that is gathered through different mediums."},
            {"0003", "Knowledge that is not about a specific topic."},
            {"1001", "Understanding how the human mind works."},
            {"1002", "The study of how humans think."},
            {"1003", "The study of the conscious and unconscious phenomena."},
            {"2001", "The study on a supernatural controlling power."},
            {"2002", "The study of Gods."},
            {"2003", "Books about theology."},
            {"3001", "Books about human behaviour in its social and cultural aspects."},
            {"3002", "The study of sciences that are social."},
            {"3003", "Books about any science that is cultural."},
            {"4001", "Books about how people converse."},
            {"4002", "The study of phonic communication."},
            {"4003", "Books surrounding different languages."},
            {"5001", "Books about the way the world works."},
            {"5002", "The study of the observable world."},
            {"5003", "Books about equations that describe the world."},
            {"6001", "The study of manmade creations."},
            {"6002", "Books about machinery."},
            {"6003", "Books about engineering and applied sciences."},
            {"7001", "Books about sports."},
            {"7002", "Books about music."},
            {"7003", "Books about painting"},
            {"8001", "Books about how books were written"},
            {"8002", "Books about writers."},
            {"8003", "The study of writers communicating their work."},
            {"9001", "Books about what has happened in the world."},
            {"9002", "Books about navigating the world."},
            {"9003", "The study of what and where important events happened."}
        };

        private string[] arrChosen = new string[4];
        //List<string> lsChosen = new List<string>();
        private Stopwatch sw = new Stopwatch(); // measures how long it takes
        private int iLen = 1300; //  this is for the animation of the results pannel
        private Dictionary<string, string> dicRight = new Dictionary<string, string>();
        private int iAttempts = 1; // how many times they attempted they tested their answer

        //Animation Methods---------------------------------------------------------------------------------------------
        /// <summary>
        /// This is to animate in the results pannel
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

        //Form Methods--------------------------------------------------------------------------------------------------
        /// <summary>
        /// The red close button on the top right of the form to close it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            ms.ExitMessage();
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

        /// <summary>
        /// This starts the game and populates the list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            Random rnd = new Random();

            if (rnd.Next(2) == 0)
                CallNumbersToDescriptions(rnd);
            else
                DescriptionsToCallNumbers(rnd);
            //THESE ARE NO LONGER NEEDED AS IT IS BETTER TO DO IT IN THE DESIGNER
            // Left Tiles
            //lvLeft.View = View.Tile;
            //lvLeft.Alignment = ListViewAlignment.Top;
            //lvLeft.TileSize = new System.Drawing.Size(400, 50);

            // Right Tiles
            //lvRight.View = View.Tile;
            //lvRight.Alignment = ListViewAlignment.Top;
            //lvRight.TileSize = new System.Drawing.Size(400, 50);

            string sLetters = "ABCDEFG";
            for (int i = 0; i < sLetters.Length; i++)
            {
                cb1.Items.Add(sLetters[i]);
                cb2.Items.Add(sLetters[i]);
                cb3.Items.Add(sLetters[i]);
                cb4.Items.Add(sLetters[i]);
            }

            cb1.SelectedIndex = 0;
            cb2.SelectedIndex = 1;
            cb3.SelectedIndex = 2;
            cb4.SelectedIndex = 3;

            cb1.Enabled = true;
            cb2.Enabled = true;
            cb3.Enabled = true;
            cb4.Enabled = true;
            btnDone.Enabled = true;

            sw.Start();
        }

        /// <summary>
        /// Loads the points when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFindingAreas_Load(object sender, EventArgs e)
        {
            pnlResults.Location = new Point(iLen, 80);
            lblPointsGoal.Text = Program.acheivedPoints.ToString() + "/" + Program.goalPoints.ToString();
            lblGoalAttempts.Text = Program.acheivedAttempts.ToString() + "/" + Program.goalAttempts.ToString();
        }

        /// <summary>
        /// This button is clicked after the game is done
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
        /// Once the user is done it stops the time watch and calls the generate report method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDone_Click(object sender, EventArgs e)
        {

            // This array gets all the values of the selected values
            string[] arrSelected = new string[4];
            arrSelected[0] = cb1.Text.Trim();
            arrSelected[1] = cb2.Text.Trim();
            arrSelected[2] = cb3.Text.Trim();
            arrSelected[3] = cb4.Text.Trim();

            bool bFlag = true;
            for (int i = 0; i < 4; i++)
            {
                if (!arrChosen[i].Equals(dicRight[arrSelected[i]]))
                {
                    ms.ErrorMessage("Selection " + (i + 1).ToString() + " is wrong!");
                    bFlag = false;
                    if (i == 3)
                        iAttempts++;
                    continue; // saves a small amount of processing time
                }

                if (bFlag && i == 3)
                {
                    sw.Stop();
                    ms.SuccessMessage("Your selection is correct!");
                    lvLeft.Items.Clear();
                    lvRight.Items.Clear();
                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    GenerateReport(sw.ElapsedMilliseconds);
                    btnDone.Enabled = false;
                    btnStart.Enabled = true;
                    tAnimation.Start();
                }
            }
        }

        //Drawing Methods-----------------------------------------------------------------------------------------------
        /// <summary>
        /// Draws the boxes on the left listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvLeft_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            try
            {
                e.Graphics.FillRectangle(Brushes.Lime, e.Bounds);
                e.Graphics.DrawRectangle(Pens.Black, e.Bounds);

                //Segoe UI, 21.75pt, style=BoldbtnStart.Font
                Font ftItem = new Font("Segoe UI", 10);
                TextRenderer.DrawText(e.Graphics, e.Item.Text, ftItem, e.Bounds, Color.Black, Color.Empty, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            catch (Exception ex)
            {
                ms.ErrorMessage(ex.ToString());
            }
        }

        /// <summary>
        /// Draws the boxes on the left listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvRight_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            try
            {
                e.Graphics.FillRectangle(Brushes.Lime, e.Bounds);
                e.Graphics.DrawRectangle(Pens.Black, e.Bounds);

                //Segoe UI, 21.75pt, style=BoldbtnStart.Font
                Font ftItem = new Font("Segoe UI", 10);
                TextRenderer.DrawText(e.Graphics, e.Item.Text, ftItem, e.Bounds, Color.Black, Color.Empty, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            catch (Exception ex)
            {
                ms.ErrorMessage(ex.ToString());
            }
        }

        //Other Methods-------------------------------------------------------------------------------------------------

        /// <summary>
        /// This allows the call numbers to go to descriptions
        /// </summary>
        /// <param name="rnd"></param>
        private void CallNumbersToDescriptions(Random rnd)
        {
            string[] arrDiscriptions = new string[7]; //this contains the descriptions of the different call numbers
            string[] arrRight = new string[7]; // this contains the categories that are selected
            string sLetters = "ABCDEFG"; // this is for all the letters to match the rows
            // Generates the 4 Random on the left
            for (int i = 0; i < 4; i++)
            {
                //This while loop ensures that one of each gets assigned
                bool bFlag1 = true;
                while (bFlag1)
                {
                    string sGen = rnd.Next(10).ToString() + "00";
                    // using logic from https://www.tutorialspoint.com/how-to-check-in-chash-whether-the-string-array-contains-a-particular-work-in-a-string-array#:~:text=Contains()%20is%20a%20string,returns%20True%2C%20otherwise%20returns%20False.
                    if (arrChosen.Contains(sGen))
                        continue;
                    else
                    {
                        arrChosen[i] = sGen;
                        lvLeft.Items.Add((i + 1).ToString() + ". " + sGen);
                        bFlag1 = false;
                    }

                }

                //this while loop puts the now generated value into a random place in the right side array
                // Note that these are all unique already
                bool bFlag2 = true;
                while (bFlag2)
                {
                    int selected = rnd.Next(7);
                    if (arrDiscriptions[selected] == null) // checks to see if it contains A VALUE
                    {
                        arrRight[selected] = arrChosen[i]; // this is to compare that only one description from each category is selected
                        arrDiscriptions[selected] = dicDescriptions[arrChosen[i] + rnd.Next(1, 4).ToString()];
                        bFlag2 = false;
                    }
                    else
                        continue;
                }
            }

            
            //Generates the 3 more for the right
            for (int i = 0; i < 7; i++)
            {
                // if it contains a value at this index display it
                if (arrDiscriptions[i] != null)
                {
                    lvRight.Items.Add(sLetters[i] + ". " + arrDiscriptions[i]);
                    dicRight.Add(sLetters[i].ToString(), arrRight[i]);
                    continue;
                }

                //This while loop ensures that it's a unique category being selected for a description
                bool bFlag1 = true;
                while (bFlag1)
                {
                    string sGen = rnd.Next(10).ToString() + "00";
                    // using logic from https://www.tutorialspoint.com/how-to-check-in-chash-whether-the-string-array-contains-a-particular-work-in-a-string-array#:~:text=Contains()%20is%20a%20string,returns%20True%2C%20otherwise%20returns%20False.
                    if (arrRight.Contains(sGen))
                        continue;
                    else
                    {
                        arrRight[i] = sGen;
                        bFlag1 = false;
                    }
                }

                //Randomising the 1 of 3 descriptions from the previously selected category
                arrDiscriptions[i] = dicDescriptions[arrRight[i] + rnd.Next(1, 4).ToString()];
                lvRight.Items.Add(sLetters[i] + ". " + arrDiscriptions[i]);
                dicRight.Add(sLetters[i].ToString(), arrRight[i]); // this can be here because the above version continues
            }
        }

        /// <summary>
        /// This is for matching the descriptions to call numbers version of this game
        /// </summary>
        /// <param name="rnd"></param>
        private void DescriptionsToCallNumbers(Random rnd)
        { 
            string[] arrCallNumbers = new string[7]; //this contains the call numbers which are then chosen from to get the 
            string sLetters = "ABCDEFG"; // this is for all the letters to match the rows

            // Generates the 7 Random on the right
            for (int i = 0; i < 7; i++)
            {
                //This while loop ensures that one of each gets assigned
                bool bFlag = true;
                while (bFlag)
                {
                    string sGen = rnd.Next(10).ToString() + "00";
                    // using logic from https://www.tutorialspoint.com/how-to-check-in-chash-whether-the-string-array-contains-a-particular-work-in-a-string-array#:~:text=Contains()%20is%20a%20string,returns%20True%2C%20otherwise%20returns%20False.
                    if (arrCallNumbers.Contains(sGen))
                        continue;
                    else
                    {
                        arrCallNumbers[i] = sGen;
                        dicRight.Add(sLetters[i].ToString(), sGen);
                        lvRight.Items.Add(sLetters[i].ToString() + ". " + sGen);
                        bFlag = false;
                    }

                }
            }
            
            for (int i = 0; i < 4; i++)
            {
                bool bFlag1 = true;
                while (bFlag1)
                {
                    int selected = rnd.Next(7);
                    if (arrChosen.Contains(arrCallNumbers[selected]))
                        continue;
                    else
                    {
                        arrChosen[i] = arrCallNumbers[selected];

                        //Generate a random description
                        lvLeft.Items.Add((i + 1).ToString()+". " + dicDescriptions[arrCallNumbers[selected] + rnd.Next(1, 4).ToString()]);
                        bFlag1 = false;
                    }
                }
            }            
        }
        
        /// <summary>
        /// This method generates the report of how long they took and then saves their points to their total, this game is harder and thus has more points
        /// </summary>
        /// <param name="elapsedMilliseconds"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void GenerateReport(double elapsedMilliseconds)
        {
            int seconds = (int)Math.Round(elapsedMilliseconds / 1000);
            int pointsEarnt = 80 - seconds - (iAttempts * 2);
            //MessageBox.Show(seconds.ToString() + " seconds " + pointsEarnt.ToString() + "Points");
            string rank;

            switch (seconds)
            {
                case int i when i < 30:
                    rank = "S+";
                    break;
                case int i when i >= 30 && i < 35:
                    rank = "S";
                    break;
                case int i when i >= 35 && i < 40:
                    rank = "A+";
                    break;
                case int i when i >= 40 && i < 45:
                    rank = "A";
                    break;
                case int i when i >= 45 && i < 50: 
                    rank = "B+";
                    break;
                case int i when i >= 50 && i < 55: 
                    rank = "B";
                    break;
                case int i when i >= 55 && i < 60: 
                    rank = "C+";
                    break;
                case int i when i >= 60 && i < 65: 
                    rank = "C";
                    break;
                case int i when i >= 65 && i < 70: 
                    rank = "D+";
                    break;
                case int i when i >= 70 && i < 75: 
                    rank = "D";
                    break;
                case int i when i >= 75 && i < 80: 
                    rank = "E+";
                    break;
                case int i when i >= 80 && i < 85: 
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
            lblTimeTaken.Text = seconds.ToString() + " Seconds";
            lblAttempts.Text = iAttempts.ToString() + " Attempts";
            lblPointsEarnt.Text = pointsEarnt.ToString() + " Points";

            Program.acheivedPoints += pointsEarnt;
            //SetLabels(); this looks tacky here
        }
        
        //END OF PROGRAM------------------------------------------------------------------------------------------------
    }
}
