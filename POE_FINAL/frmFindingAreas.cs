﻿using POE_FINAL.Classes.Task_1_Classes;
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
            {"Arts and Recreation2", ""},
            {"Arts and Recreation3", ""},
            {"Literature1", ""},
            {"Literature2", ""},
            {"Literature3", ""},
            {"History and Geography1", ""},
            {"History and Geography2", ""},
            {"History and Geography3", ""}
        };
        private string[] arrChosen = new string[4];
        private Stopwatch sw = new Stopwatch(); // measures how long it takes
        private int len = 1100; //  this is for the animation of the results pannel

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

            // Left Tiles
            lvLeft.View = View.Tile;
            lvLeft.Alignment = ListViewAlignment.Top;
            lvLeft.TileSize = new System.Drawing.Size(280, 30);

            // Right Tiles
            lvRight.View = View.Tile;
            lvRight.Alignment = ListViewAlignment.Top;
            lvRight.TileSize = new System.Drawing.Size(280, 30);

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
                Font ftItem = new Font("Segoe UI", 15);
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
                Font ftItem = new Font("Segoe UI", 15);
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

            string[] arrRight = new string[7];

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
                        lvLeft.Items.Add(i.ToString() + ". " + arrChosen[i]);
                        bFlag1 = false;
                    }

                }

                //this while loop puts the now generated value into a random place in the right side array
                bool bFlag2 = true;
                while (bFlag2)
                {
                    int selected = rnd.Next(7);
                    if (arrRight[selected] == null)
                    {
                        arrRight[selected] = dicCategories[arrChosen[i]];
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
                if (arrRight[i] != null)
                {
                    lvRight.Items.Add(sLetters[i] + ". " + arrRight[i]);
                    continue;
                }

                //This while loop ensures that one of each gets assigned
                bool bFlag = true;
                while (bFlag)
                {
                    string sGen = dicCategories[rnd.Next(10).ToString() + "00"];
                    // using logic from https://www.tutorialspoint.com/how-to-check-in-chash-whether-the-string-array-contains-a-particular-work-in-a-string-array#:~:text=Contains()%20is%20a%20string,returns%20True%2C%20otherwise%20returns%20False.
                    if (arrRight.Contains(sGen))
                        continue;
                    else
                    {
                        arrRight[i] = sGen;
                        lvRight.Items.Add(sLetters[i] + ". " + arrRight[i]);
                        bFlag = false;
                    }
                }
            }
        }

        private void DescriptionsToCallNumbers(Random rnd)
        {

        }
    }
}