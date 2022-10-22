namespace POE_FINAL
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnSortingGame = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPointsGoal = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblGoalAttempts = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSorting = new System.Windows.Forms.PictureBox();
            this.btnFindArea = new System.Windows.Forms.Button();
            this.btnCallNums = new System.Windows.Forms.Button();
            this.tbPointsGoal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAttemptsGoal = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tBumpLabels = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSorting)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSortingGame
            // 
            this.btnSortingGame.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSortingGame.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSortingGame, "btnSortingGame");
            this.btnSortingGame.Name = "btnSortingGame";
            this.btnSortingGame.UseVisualStyleBackColor = false;
            this.btnSortingGame.Click += new System.EventHandler(this.btnSortingGame_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlHeader.Controls.Add(this.lblPointsGoal);
            this.pnlHeader.Controls.Add(this.lblPoints);
            this.pnlHeader.Controls.Add(this.lblGoalAttempts);
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Controls.Add(this.btnClose);
            resources.ApplyResources(this.pnlHeader, "pnlHeader");
            this.pnlHeader.Name = "pnlHeader";
            // 
            // lblPointsGoal
            // 
            resources.ApplyResources(this.lblPointsGoal, "lblPointsGoal");
            this.lblPointsGoal.Name = "lblPointsGoal";
            // 
            // lblPoints
            // 
            resources.ApplyResources(this.lblPoints, "lblPoints");
            this.lblPoints.Name = "lblPoints";
            // 
            // lblGoalAttempts
            // 
            resources.ApplyResources(this.lblGoalAttempts, "lblGoalAttempts");
            this.lblGoalAttempts.Name = "lblGoalAttempts";
            // 
            // lblHeading
            // 
            resources.ApplyResources(this.lblHeading, "lblHeading");
            this.lblHeading.Name = "lblHeading";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POE_FINAL.Properties.Resources.Quiz_Logo;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POE_FINAL.Properties.Resources.Identifying_Areas;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pbSorting
            // 
            this.pbSorting.Image = global::POE_FINAL.Properties.Resources.Rearranging_Books;
            resources.ApplyResources(this.pbSorting, "pbSorting");
            this.pbSorting.Name = "pbSorting";
            this.pbSorting.TabStop = false;
            // 
            // btnFindArea
            // 
            this.btnFindArea.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFindArea.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnFindArea, "btnFindArea");
            this.btnFindArea.Name = "btnFindArea";
            this.btnFindArea.UseVisualStyleBackColor = false;
            this.btnFindArea.Click += new System.EventHandler(this.btnFindArea_Click);
            // 
            // btnCallNums
            // 
            this.btnCallNums.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCallNums.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCallNums, "btnCallNums");
            this.btnCallNums.Name = "btnCallNums";
            this.btnCallNums.UseVisualStyleBackColor = false;
            this.btnCallNums.Click += new System.EventHandler(this.btnCallNums_Click);
            // 
            // tbPointsGoal
            // 
            resources.ApplyResources(this.tbPointsGoal, "tbPointsGoal");
            this.tbPointsGoal.Name = "tbPointsGoal";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbAttemptsGoal
            // 
            resources.ApplyResources(this.tbAttemptsGoal, "tbAttemptsGoal");
            this.tbAttemptsGoal.Name = "tbAttemptsGoal";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tBumpLabels
            // 
            this.tBumpLabels.Interval = 10;
            this.tBumpLabels.Tick += new System.EventHandler(this.tBumpLabels_Tick);
            // 
            // frmHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAttemptsGoal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPointsGoal);
            this.Controls.Add(this.btnCallNums);
            this.Controls.Add(this.btnFindArea);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbSorting);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnSortingGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSorting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortingGame;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbSorting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFindArea;
        private System.Windows.Forms.Button btnCallNums;
        private System.Windows.Forms.TextBox tbPointsGoal;
        private System.Windows.Forms.Label lblPointsGoal;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblGoalAttempts;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAttemptsGoal;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer tBumpLabels;
    }
}