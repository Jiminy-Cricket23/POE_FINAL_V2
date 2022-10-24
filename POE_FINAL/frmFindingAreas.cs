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
        private Messages ms = new Messages();
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
        };
        private string[] arrChosen = new string[4];
        private Stopwatch sw = new Stopwatch(); // measures how long it takes
        private int len = 1300; //  this is for the animation of the results pannel

        public frmFindingAreas()
        {
            InitializeComponent();
        }

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

            if (rnd.Next(1) == 0)
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
            pnlResults.Location = new Point(len, 80);
            lblPointsGoal.Text = Program.acheivedPoints.ToString() + "/" + Program.goalPoints.ToString();
            lblGoalAttempts.Text = Program.acheivedAttempts.ToString() + "/" + Program.goalAttempts.ToString();
        }

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

        private void btnDone_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This allows the call numbers to go to descriptions
        /// </summary>
        /// <param name="rnd"></param>
        private void CallNumbersToDescriptions(Random rnd)
        {

            string[] arrDiscriptions = new string[7]; //this contains the descriptions of the different call numbers
            string[] arrRight = new string[7]; // this contains the categories that are selected

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
                        lvLeft.Items.Add((i + 1).ToString() + ". " + arrChosen[i]);
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
                        bool bFlag3 = true;
                        while(bFlag3) // Makes sure that that value is not a duplicate
                        {
                            string sGen = dicDescriptions[dicCategories[arrChosen[i]] + rnd.Next(1, 4).ToString()];
                            if (arrDiscriptions.Contains(sGen))
                                continue;
                            else
                            {
                                arrRight[selected] = dicCategories[arrChosen[i]]; // this is to compare that only one description from each category is selected
                                arrDiscriptions[selected] = sGen;
                                bFlag3 = false;
                            }
                        }
                        bFlag2 = false;
                    }
                    else
                        continue;
                }
            }

            string sLetters = "ABCDEFG";
            //Generates the 3 more for the right
            for (int i = 0; i < 7; i++)
            {
                // if it contains a value at this index display it
                if (arrDiscriptions[i] != null)
                {
                    lvRight.Items.Add(sLetters[i] + ". " + arrDiscriptions[i]);
                    continue;
                }

                //This while loop ensures that it's a unique category being selected for a description
                bool bFlag1 = true;
                while (bFlag1)
                {
                    string sGen = dicCategories[rnd.Next(10).ToString() + "00"];
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
                bool bFlag2 = true;
                while (bFlag2)
                {
                    string sGen = dicDescriptions[arrRight[i] + rnd.Next(1, 4).ToString()];
                    
                    if (arrDiscriptions.Contains(sGen))
                        continue;
                    else
                    {
                        arrDiscriptions[i] = sGen;
                        lvRight.Items.Add(sLetters[i] + ". " + arrDiscriptions[i]);
                        bFlag2 = false;
                    }
                }
            }
        }

        private void DescriptionsToCallNumbers(Random rnd)
        {

        }
    }
}
