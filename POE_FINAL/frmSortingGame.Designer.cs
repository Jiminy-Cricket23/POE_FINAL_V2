namespace POE_FINAL
{
    partial class frmSortingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSortingGame));
            this.btnStart = new System.Windows.Forms.Button();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPointsGoal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGoalAttempts = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblPointsEarnt = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRanked = new System.Windows.Forms.Label();
            this.btnFinishReport = new System.Windows.Forms.Button();
            this.tAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lvBooks
            // 
            this.lvBooks.AllowDrop = true;
            this.lvBooks.HideSelection = false;
            resources.ApplyResources(this.lvBooks, "lvBooks");
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.OwnerDraw = true;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvBooks_DrawItem);
            this.lvBooks.Click += new System.EventHandler(this.lvBooks_Click);
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
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlHeader.Controls.Add(this.lblPointsGoal);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.lblGoalAttempts);
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.btnClose);
            resources.ApplyResources(this.pnlHeader, "pnlHeader");
            this.pnlHeader.Name = "pnlHeader";
            // 
            // lblPointsGoal
            // 
            resources.ApplyResources(this.lblPointsGoal, "lblPointsGoal");
            this.lblPointsGoal.Name = "lblPointsGoal";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Red;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDone, "btnDone");
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDone.Name = "btnDone";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.Info;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnUp, "btnUp");
            this.btnUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUp.Name = "btnUp";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.Info;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDown, "btnDown");
            this.btnDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDown.Name = "btnDown";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // pbArrow
            // 
            this.pbArrow.Image = global::POE_FINAL.Properties.Resources.red_right_arrow;
            resources.ApplyResources(this.pbArrow, "pbArrow");
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.TabStop = false;
            // 
            // lblSelected
            // 
            resources.ApplyResources(this.lblSelected, "lblSelected");
            this.lblSelected.Name = "lblSelected";
            // 
            // lblGrade
            // 
            resources.ApplyResources(this.lblGrade, "lblGrade");
            this.lblGrade.BackColor = System.Drawing.Color.Cyan;
            this.lblGrade.Name = "lblGrade";
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.Color.Cyan;
            this.pnlResults.Controls.Add(this.lblAttempts);
            this.pnlResults.Controls.Add(this.lblTry);
            this.pnlResults.Controls.Add(this.lblPointsEarnt);
            this.pnlResults.Controls.Add(this.lblPoints);
            this.pnlResults.Controls.Add(this.lblTimeTaken);
            this.pnlResults.Controls.Add(this.lblTime);
            this.pnlResults.Controls.Add(this.lblRanked);
            this.pnlResults.Controls.Add(this.lblGrade);
            this.pnlResults.Controls.Add(this.btnFinishReport);
            resources.ApplyResources(this.pnlResults, "pnlResults");
            this.pnlResults.Name = "pnlResults";
            // 
            // lblAttempts
            // 
            resources.ApplyResources(this.lblAttempts, "lblAttempts");
            this.lblAttempts.Name = "lblAttempts";
            // 
            // lblTry
            // 
            resources.ApplyResources(this.lblTry, "lblTry");
            this.lblTry.Name = "lblTry";
            // 
            // lblPointsEarnt
            // 
            resources.ApplyResources(this.lblPointsEarnt, "lblPointsEarnt");
            this.lblPointsEarnt.Name = "lblPointsEarnt";
            // 
            // lblPoints
            // 
            resources.ApplyResources(this.lblPoints, "lblPoints");
            this.lblPoints.Name = "lblPoints";
            // 
            // lblTimeTaken
            // 
            resources.ApplyResources(this.lblTimeTaken, "lblTimeTaken");
            this.lblTimeTaken.Name = "lblTimeTaken";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // lblRanked
            // 
            resources.ApplyResources(this.lblRanked, "lblRanked");
            this.lblRanked.Name = "lblRanked";
            // 
            // btnFinishReport
            // 
            this.btnFinishReport.BackColor = System.Drawing.Color.Lime;
            this.btnFinishReport.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnFinishReport, "btnFinishReport");
            this.btnFinishReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinishReport.Name = "btnFinishReport";
            this.btnFinishReport.UseVisualStyleBackColor = false;
            this.btnFinishReport.Click += new System.EventHandler(this.btnFinishReport_Click);
            // 
            // tAnimation
            // 
            this.tAnimation.Interval = 10;
            this.tAnimation.Tick += new System.EventHandler(this.tAnimation_Tick);
            // 
            // frmSortingGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.pbArrow);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lvBooks);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSortingGame";
            this.Load += new System.EventHandler(this.frmSortingGame_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Timer tAnimation;
        private System.Windows.Forms.Button btnFinishReport;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRanked;
        private System.Windows.Forms.Label lblPointsEarnt;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGoalAttempts;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblPointsGoal;
        private System.Windows.Forms.Label label2;
    }
}