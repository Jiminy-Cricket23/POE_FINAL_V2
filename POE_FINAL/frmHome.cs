using POE_FINAL.Classes.Task_1_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_FINAL
{
    public partial class frmHome : Form
    {
        public static int goalAttempts = 0;
        public static int goalPoints = 0;
        public static int acheivedAttempts = 0;
        public static int acheivedPoints = 0;
        public frmHome()
        {
            InitializeComponent();
        }

        private Messages ms = new Messages();

        private void btnSortingGame_Click(object sender, EventArgs e)
        {
            frmSortingGame frm = new frmSortingGame();
            frm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ms.ExitMessage();
        }

        private void btnFindArea_Click(object sender, EventArgs e)
        {
            Messages ms = new Messages();
            ms.ErrorMessage("Game Coming Soon");
        }

        private void btnCallNums_Click(object sender, EventArgs e)
        {
            Messages ms = new Messages();
            ms.ErrorMessage("Game Coming Soon");
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblGoalAttempts.Text = acheivedAttempts.ToString() + "/"+ goalAttempts.ToString();
            lblPointsGoal.Text = acheivedPoints.ToString() + "/"+ goalPoints.ToString();
            Messages ms = new Messages();
            if (goalPoints <= acheivedPoints && goalAttempts > acheivedAttempts && goalAttempts != 0 && goalPoints != 0)
            {
                
                ms.Success("You have successfully completed your Goal!");
            }
            if (goalAttempts < acheivedAttempts && goalAttempts != 0)
            {
                ms.ErrorMessage("You have failed to complete your Goal!");
                acheivedAttempts = 0;
                acheivedPoints = 0;
                goalAttempts = 0;
                goalPoints = 0;

                btnSortingGame.Enabled = false;
                btnFindArea.Enabled = false;
                btnCallNums.Enabled = false;
            }
            if (goalAttempts > 0 && goalPoints > 0)
            {
                btnSortingGame.Enabled = true;
                btnFindArea.Enabled = true;
                btnCallNums.Enabled = true;
            }
                
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                goalAttempts = int.Parse(tbAttemptsGoal.Text);
                goalPoints = int.Parse(tbPointsGoal.Text);

                lblGoalAttempts.Text = acheivedAttempts.ToString() + "/" + goalAttempts.ToString();
                lblPointsGoal.Text = acheivedPoints.ToString() + "/" + goalPoints.ToString();
            }
            catch 
            {
                Messages ms = new Messages();
                ms.ErrorMessage("Please Enter a valid Number");
            }

            btnSortingGame.Enabled = true;
            btnFindArea.Enabled = true;
            btnCallNums.Enabled = true;
        }
    }
}
