namespace POE_FINAL
{
    partial class frmFindingAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindingAreas));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPointsGoal = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblGoalAttempts = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lvLeft = new System.Windows.Forms.ListView();
            this.lvRight = new System.Windows.Forms.ListView();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblPointsEarnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRanked = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnFinishReport = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.tAnimation = new System.Windows.Forms.Timer(this.components);
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.pnlHeader.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblPointsGoal);
            this.pnlHeader.Controls.Add(this.lblPoints);
            this.pnlHeader.Controls.Add(this.lblGoalAttempts);
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1456, 100);
            this.pnlHeader.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(1329, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 41);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPointsGoal
            // 
            this.lblPointsGoal.AutoSize = true;
            this.lblPointsGoal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPointsGoal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPointsGoal.Location = new System.Drawing.Point(753, 48);
            this.lblPointsGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointsGoal.Name = "lblPointsGoal";
            this.lblPointsGoal.Size = new System.Drawing.Size(125, 37);
            this.lblPointsGoal.TabIndex = 34;
            this.lblPointsGoal.Text = "100/100";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPoints.Location = new System.Drawing.Point(571, 48);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(170, 37);
            this.lblPoints.TabIndex = 33;
            this.lblPoints.Text = "Points Goal:";
            // 
            // lblGoalAttempts
            // 
            this.lblGoalAttempts.AutoSize = true;
            this.lblGoalAttempts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblGoalAttempts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGoalAttempts.Location = new System.Drawing.Point(793, 11);
            this.lblGoalAttempts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoalAttempts.Name = "lblGoalAttempts";
            this.lblGoalAttempts.Size = new System.Drawing.Size(93, 37);
            this.lblGoalAttempts.TabIndex = 32;
            this.lblGoalAttempts.Text = "10/10";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeading.Location = new System.Drawing.Point(571, 11);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(210, 37);
            this.lblHeading.TabIndex = 31;
            this.lblHeading.Text = "Attempts Goal:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(1408, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 41);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStart.Location = new System.Drawing.Point(359, 617);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(343, 79);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lvLeft
            // 
            this.lvLeft.AllowDrop = true;
            this.lvLeft.HideSelection = false;
            this.lvLeft.Location = new System.Drawing.Point(51, 229);
            this.lvLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvLeft.Name = "lvLeft";
            this.lvLeft.OwnerDraw = true;
            this.lvLeft.Size = new System.Drawing.Size(559, 276);
            this.lvLeft.TabIndex = 29;
            this.lvLeft.TileSize = new System.Drawing.Size(416, 54);
            this.lvLeft.UseCompatibleStateImageBehavior = false;
            this.lvLeft.View = System.Windows.Forms.View.Tile;
            this.lvLeft.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvLeft_DrawItem);
            // 
            // lvRight
            // 
            this.lvRight.AllowDrop = true;
            this.lvRight.HideSelection = false;
            this.lvRight.Location = new System.Drawing.Point(843, 130);
            this.lvRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvRight.Name = "lvRight";
            this.lvRight.OwnerDraw = true;
            this.lvRight.Size = new System.Drawing.Size(559, 474);
            this.lvRight.TabIndex = 30;
            this.lvRight.TileSize = new System.Drawing.Size(416, 54);
            this.lvRight.UseCompatibleStateImageBehavior = false;
            this.lvRight.View = System.Windows.Forms.View.Tile;
            this.lvRight.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvRight_DrawItem);
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.Color.Cyan;
            this.pnlResults.Controls.Add(this.lblAttempts);
            this.pnlResults.Controls.Add(this.lblTry);
            this.pnlResults.Controls.Add(this.lblPointsEarnt);
            this.pnlResults.Controls.Add(this.label1);
            this.pnlResults.Controls.Add(this.lblTimeTaken);
            this.pnlResults.Controls.Add(this.lblTime);
            this.pnlResults.Controls.Add(this.lblRanked);
            this.pnlResults.Controls.Add(this.lblGrade);
            this.pnlResults.Controls.Add(this.btnFinishReport);
            this.pnlResults.Location = new System.Drawing.Point(673, 104);
            this.pnlResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(1456, 640);
            this.pnlResults.TabIndex = 34;
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAttempts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAttempts.Location = new System.Drawing.Point(747, 306);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(179, 38);
            this.lblAttempts.TabIndex = 41;
            this.lblAttempts.Text = "10 Attempts";
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTry.Location = new System.Drawing.Point(532, 306);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(147, 38);
            this.lblTry.TabIndex = 40;
            this.lblTry.Text = "Attempts:";
            // 
            // lblPointsEarnt
            // 
            this.lblPointsEarnt.AutoSize = true;
            this.lblPointsEarnt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblPointsEarnt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPointsEarnt.Location = new System.Drawing.Point(747, 345);
            this.lblPointsEarnt.Name = "lblPointsEarnt";
            this.lblPointsEarnt.Size = new System.Drawing.Size(138, 38);
            this.lblPointsEarnt.TabIndex = 39;
            this.lblPointsEarnt.Text = "65 Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(532, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 38);
            this.label1.TabIndex = 38;
            this.label1.Text = "Points Earnt:";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTimeTaken.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTimeTaken.Location = new System.Drawing.Point(747, 268);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(164, 38);
            this.lblTimeTaken.TabIndex = 37;
            this.lblTimeTaken.Text = "65 Seconds";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTime.Location = new System.Drawing.Point(532, 270);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(175, 38);
            this.lblTime.TabIndex = 36;
            this.lblTime.Text = "Time Taken:";
            // 
            // lblRanked
            // 
            this.lblRanked.AutoSize = true;
            this.lblRanked.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblRanked.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRanked.Location = new System.Drawing.Point(583, 144);
            this.lblRanked.Name = "lblRanked";
            this.lblRanked.Size = new System.Drawing.Size(92, 38);
            this.lblRanked.TabIndex = 35;
            this.lblRanked.Text = "Rank:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Cyan;
            this.lblGrade.Font = new System.Drawing.Font("Berlin Sans FB", 72F, System.Drawing.FontStyle.Bold);
            this.lblGrade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGrade.Location = new System.Drawing.Point(683, 121);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(185, 149);
            this.lblGrade.TabIndex = 31;
            this.lblGrade.Text = "S+";
            // 
            // btnFinishReport
            // 
            this.btnFinishReport.BackColor = System.Drawing.Color.Lime;
            this.btnFinishReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinishReport.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnFinishReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinishReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFinishReport.Location = new System.Drawing.Point(556, 463);
            this.btnFinishReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinishReport.Name = "btnFinishReport";
            this.btnFinishReport.Size = new System.Drawing.Size(343, 79);
            this.btnFinishReport.TabIndex = 32;
            this.btnFinishReport.Text = "Done!";
            this.btnFinishReport.UseVisualStyleBackColor = false;
            this.btnFinishReport.Click += new System.EventHandler(this.btnFinishReport_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Red;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Enabled = false;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDone.Location = new System.Drawing.Point(752, 617);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(343, 79);
            this.btnDone.TabIndex = 33;
            this.btnDone.Text = "Finished!";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tAnimation
            // 
            this.tAnimation.Interval = 10;
            this.tAnimation.Tick += new System.EventHandler(this.tAnimation_Tick);
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.Enabled = false;
            this.cb1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(635, 272);
            this.cb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(183, 43);
            this.cb1.TabIndex = 35;
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.Enabled = false;
            this.cb2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(635, 321);
            this.cb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(183, 43);
            this.cb2.TabIndex = 36;
            // 
            // cb3
            // 
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb3.Enabled = false;
            this.cb3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(635, 370);
            this.cb3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(183, 43);
            this.cb3.TabIndex = 37;
            // 
            // cb4
            // 
            this.cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb4.Enabled = false;
            this.cb4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb4.FormattingEnabled = true;
            this.cb4.Location = new System.Drawing.Point(635, 420);
            this.cb4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(183, 43);
            this.cb4.TabIndex = 38;
            // 
            // frmFindingAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 736);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lvRight);
            this.Controls.Add(this.lvLeft);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFindingAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finding Areas";
            this.Load += new System.EventHandler(this.frmFindingAreas_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPointsGoal;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblGoalAttempts;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView lvLeft;
        private System.Windows.Forms.ListView lvRight;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label lblPointsEarnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRanked;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnFinishReport;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Timer tAnimation;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb4;
    }
}