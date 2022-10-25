using POE_FINAL.Classes.Task_1_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_FINAL
{
    public partial class frmHome : Form
    {
        
        private Messages ms = new Messages(); // message object for this form

        public frmHome()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Shows the sorting game form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortingGame_Click(object sender, EventArgs e)
        {
            frmSortingGame frm = new frmSortingGame();
            frm.Show();
            this.Hide();
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
        /// Goes to the find area game (Still under development)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindArea_Click(object sender, EventArgs e)
        {
            //ms.ErrorMessage("Game Coming Soon");
            frmFindingAreas frm = new frmFindingAreas();
            frm.Show();
            this.Hide();
        }

        /// <summary>
        /// Goes to the call numbers game (Still under development)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCallNums_Click(object sender, EventArgs e)
        {
            ms.ErrorMessage("Game Coming Soon");
        }

        /// <summary>
        /// There are a few things that need to be initialised when the form gets loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHome_Load(object sender, EventArgs e)
        {
            // displays the acheived attempts
            lblGoalAttempts.Text = Program.acheivedAttempts.ToString() + "/"+ Program.goalAttempts.ToString();
            lblPointsGoal.Text = Program.acheivedPoints.ToString() + "/"+ Program.goalPoints.ToString();

            // success
            if (Program.goalPoints <= Program.acheivedPoints && Program.goalAttempts > Program.acheivedAttempts && Program.goalAttempts != 0 && Program.goalPoints != 0)
            {
                ms.SuccessMessage("You have successfully completed your Goal!");
                Program.goalAttempts = 0;
                Program.goalPoints = 0;
                Program.acheivedAttempts = 0;
                Program.acheivedPoints = 0;
            }

            // have not met goal and resets until the button has been clicked and new values have been entered
            if (Program.goalAttempts < Program.acheivedAttempts && Program.goalAttempts != 0)
            {
                
                ms.ErrorMessage("You have failed to complete your Goal!"); 
                Program.acheivedAttempts = 0;
                Program.acheivedPoints = 0;
                Program.goalAttempts = 0;
                Program.goalPoints = 0;

                btnSortingGame.Enabled = false;
                btnFindArea.Enabled = false;
                btnCallNums.Enabled = false;
            }

            // if the goal and attempts have not been set yet they can't get to the games
            if (Program.goalAttempts > 0 && Program.goalPoints > 0)
            {
                btnSortingGame.Enabled = true;
                btnFindArea.Enabled = true;
                btnCallNums.Enabled = true;
            }
                
        }

        /// <summary>
        /// When they submit their goal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // stand try catch for number parsing 
            try
            {
                Program.goalAttempts = int.Parse(tbAttemptsGoal.Text);
                Program.goalPoints = int.Parse(tbPointsGoal.Text);
                SetLabels();
                ms.SuccessMessage("Goals set successfully");
            }
            catch 
            {
                ms.ErrorMessage("Please Enter a valid Number");
            }
            // buttons are enabled once a goal has been set
            btnSortingGame.Enabled = true;
            btnFindArea.Enabled = true;
            btnCallNums.Enabled = true;
        }

        /// <summary>
        /// this sets all the labels to the goals and what was acheived in this form
        /// </summary>
        private void SetLabels()
        {
            lblGoalAttempts.Text = Program.acheivedAttempts.ToString() + "/" + Program.goalAttempts.ToString();
            lblPointsGoal.Text = Program.acheivedPoints.ToString() + "/" + Program.goalPoints.ToString();
            tBumpLabels.Start();// this adds the animation every time the labels need to be set
        }

        // if the text reaches it's max it must go back down
        private static bool bBump = true;
        /// <summary>
        /// Every time this ticks move the text slightly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBumpLabels_Tick(object sender, EventArgs e)
        {
            float fSize = lblGoalAttempts.Font.Size;

            if (bBump)
                fSize += 0.25F;
            else
                fSize -= 0.25F;

            if (fSize == 18F)
                bBump = false;

            if (fSize == 15.75)
            {
                bBump = true;
                tBumpLabels.Stop();
            }
               
            
            Font fChanger = new Font("Segoe UI", fSize, FontStyle.Bold);
            lblGoalAttempts.Font = fChanger;
            lblHeading.Font = fChanger;
            lblPoints.Font = fChanger;
            lblPointsGoal.Font = fChanger;
        }
    }
}
