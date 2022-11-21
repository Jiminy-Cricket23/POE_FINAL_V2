namespace POE_FINAL
{
    partial class frmFindingCallNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindingCallNumbers));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPointsGoal = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblGoalAttempts = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.pnlLevel1 = new System.Windows.Forms.Panel();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.tAnimation = new System.Windows.Forms.Timer(this.components);
            this.tLevel1 = new System.Windows.Forms.Timer(this.components);
            this.tLevel2 = new System.Windows.Forms.Timer(this.components);
            this.tLevel3 = new System.Windows.Forms.Timer(this.components);
            this.pnlLevel2 = new System.Windows.Forms.Panel();
            this.btnL2Option4 = new System.Windows.Forms.Button();
            this.btnL2Option3 = new System.Windows.Forms.Button();
            this.btnL2Option2 = new System.Windows.Forms.Button();
            this.btnL2Option1 = new System.Windows.Forms.Button();
            this.pnlLevel3 = new System.Windows.Forms.Panel();
            this.btnL3Option4 = new System.Windows.Forms.Button();
            this.btnL3Option3 = new System.Windows.Forms.Button();
            this.btnL3Option2 = new System.Windows.Forms.Button();
            this.btnL3Option1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.redOutput = new System.Windows.Forms.RichTextBox();
            this.lblChosen = new System.Windows.Forms.Label();
            this.tFadeOut = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.pnlLevel1.SuspendLayout();
            this.pnlLevel2.SuspendLayout();
            this.pnlLevel3.SuspendLayout();
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
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1092, 81);
            this.pnlHeader.TabIndex = 28;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(997, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 33);
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
            this.lblPointsGoal.Location = new System.Drawing.Point(565, 39);
            this.lblPointsGoal.Name = "lblPointsGoal";
            this.lblPointsGoal.Size = new System.Drawing.Size(94, 30);
            this.lblPointsGoal.TabIndex = 34;
            this.lblPointsGoal.Text = "100/100";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPoints.Location = new System.Drawing.Point(428, 39);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(131, 30);
            this.lblPoints.TabIndex = 33;
            this.lblPoints.Text = "Points Goal:";
            // 
            // lblGoalAttempts
            // 
            this.lblGoalAttempts.AutoSize = true;
            this.lblGoalAttempts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblGoalAttempts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGoalAttempts.Location = new System.Drawing.Point(595, 9);
            this.lblGoalAttempts.Name = "lblGoalAttempts";
            this.lblGoalAttempts.Size = new System.Drawing.Size(70, 30);
            this.lblGoalAttempts.TabIndex = 32;
            this.lblGoalAttempts.Text = "10/10";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeading.Location = new System.Drawing.Point(428, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(161, 30);
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
            this.btnClose.Location = new System.Drawing.Point(1056, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.pnlResults.Location = new System.Drawing.Point(517, 86);
            this.pnlResults.Margin = new System.Windows.Forms.Padding(2);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(1092, 520);
            this.pnlResults.TabIndex = 35;
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAttempts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAttempts.Location = new System.Drawing.Point(560, 249);
            this.lblAttempts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(143, 30);
            this.lblAttempts.TabIndex = 41;
            this.lblAttempts.Text = "10 Attempts";
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTry.Location = new System.Drawing.Point(399, 249);
            this.lblTry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(117, 30);
            this.lblTry.TabIndex = 40;
            this.lblTry.Text = "Attempts:";
            // 
            // lblPointsEarnt
            // 
            this.lblPointsEarnt.AutoSize = true;
            this.lblPointsEarnt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblPointsEarnt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPointsEarnt.Location = new System.Drawing.Point(560, 280);
            this.lblPointsEarnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointsEarnt.Name = "lblPointsEarnt";
            this.lblPointsEarnt.Size = new System.Drawing.Size(109, 30);
            this.lblPointsEarnt.TabIndex = 39;
            this.lblPointsEarnt.Text = "65 Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(399, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Points Earnt:";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTimeTaken.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTimeTaken.Location = new System.Drawing.Point(560, 218);
            this.lblTimeTaken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(130, 30);
            this.lblTimeTaken.TabIndex = 37;
            this.lblTimeTaken.Text = "65 Seconds";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTime.Location = new System.Drawing.Point(399, 219);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 30);
            this.lblTime.TabIndex = 36;
            this.lblTime.Text = "Time Taken:";
            // 
            // lblRanked
            // 
            this.lblRanked.AutoSize = true;
            this.lblRanked.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblRanked.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRanked.Location = new System.Drawing.Point(437, 117);
            this.lblRanked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRanked.Name = "lblRanked";
            this.lblRanked.Size = new System.Drawing.Size(71, 30);
            this.lblRanked.TabIndex = 35;
            this.lblRanked.Text = "Rank:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Cyan;
            this.lblGrade.Font = new System.Drawing.Font("Berlin Sans FB", 72F, System.Drawing.FontStyle.Bold);
            this.lblGrade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGrade.Location = new System.Drawing.Point(512, 98);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(148, 119);
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
            this.btnFinishReport.Location = new System.Drawing.Point(417, 376);
            this.btnFinishReport.Name = "btnFinishReport";
            this.btnFinishReport.Size = new System.Drawing.Size(257, 64);
            this.btnFinishReport.TabIndex = 32;
            this.btnFinishReport.Text = "Done!";
            this.btnFinishReport.UseVisualStyleBackColor = false;
            this.btnFinishReport.Click += new System.EventHandler(this.btnFinishReport_Click);
            // 
            // pnlLevel1
            // 
            this.pnlLevel1.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlLevel1.Controls.Add(this.btnOption4);
            this.pnlLevel1.Controls.Add(this.btnOption3);
            this.pnlLevel1.Controls.Add(this.btnOption2);
            this.pnlLevel1.Controls.Add(this.btnOption1);
            this.pnlLevel1.Location = new System.Drawing.Point(3, 236);
            this.pnlLevel1.Name = "pnlLevel1";
            this.pnlLevel1.Size = new System.Drawing.Size(1092, 518);
            this.pnlLevel1.TabIndex = 36;
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.Cyan;
            this.btnOption4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOption4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOption4.Location = new System.Drawing.Point(654, 318);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(257, 64);
            this.btnOption4.TabIndex = 32;
            this.btnOption4.Text = "Option 4";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.Cyan;
            this.btnOption3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOption3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOption3.Location = new System.Drawing.Point(182, 318);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(257, 64);
            this.btnOption3.TabIndex = 31;
            this.btnOption3.Text = "Option 3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.Cyan;
            this.btnOption2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOption2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOption2.Location = new System.Drawing.Point(654, 136);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(257, 64);
            this.btnOption2.TabIndex = 30;
            this.btnOption2.Text = "Option 2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.Cyan;
            this.btnOption1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOption1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOption1.Location = new System.Drawing.Point(182, 136);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(257, 64);
            this.btnOption1.TabIndex = 29;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // tAnimation
            // 
            this.tAnimation.Interval = 10;
            this.tAnimation.Tick += new System.EventHandler(this.tAnimation_Tick);
            // 
            // tLevel1
            // 
            this.tLevel1.Interval = 10;
            this.tLevel1.Tick += new System.EventHandler(this.tLevel1_Tick);
            // 
            // tLevel2
            // 
            this.tLevel2.Interval = 10;
            this.tLevel2.Tick += new System.EventHandler(this.tLevel2_Tick);
            // 
            // tLevel3
            // 
            this.tLevel3.Interval = 10;
            this.tLevel3.Tick += new System.EventHandler(this.tLevel3_Tick);
            // 
            // pnlLevel2
            // 
            this.pnlLevel2.BackColor = System.Drawing.Color.Yellow;
            this.pnlLevel2.Controls.Add(this.btnL2Option4);
            this.pnlLevel2.Controls.Add(this.btnL2Option3);
            this.pnlLevel2.Controls.Add(this.btnL2Option2);
            this.pnlLevel2.Controls.Add(this.btnL2Option1);
            this.pnlLevel2.Location = new System.Drawing.Point(0, 336);
            this.pnlLevel2.Name = "pnlLevel2";
            this.pnlLevel2.Size = new System.Drawing.Size(1092, 518);
            this.pnlLevel2.TabIndex = 37;
            // 
            // btnL2Option4
            // 
            this.btnL2Option4.BackColor = System.Drawing.Color.Orange;
            this.btnL2Option4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL2Option4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2Option4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL2Option4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnL2Option4.Location = new System.Drawing.Point(654, 318);
            this.btnL2Option4.Name = "btnL2Option4";
            this.btnL2Option4.Size = new System.Drawing.Size(257, 64);
            this.btnL2Option4.TabIndex = 32;
            this.btnL2Option4.Text = "Option 4";
            this.btnL2Option4.UseVisualStyleBackColor = false;
            this.btnL2Option4.Click += new System.EventHandler(this.btnL2Option4_Click);
            // 
            // btnL2Option3
            // 
            this.btnL2Option3.BackColor = System.Drawing.Color.Orange;
            this.btnL2Option3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL2Option3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2Option3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL2Option3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnL2Option3.Location = new System.Drawing.Point(182, 318);
            this.btnL2Option3.Name = "btnL2Option3";
            this.btnL2Option3.Size = new System.Drawing.Size(257, 64);
            this.btnL2Option3.TabIndex = 31;
            this.btnL2Option3.Text = "Option 3";
            this.btnL2Option3.UseVisualStyleBackColor = false;
            this.btnL2Option3.Click += new System.EventHandler(this.btnL2Option3_Click);
            // 
            // btnL2Option2
            // 
            this.btnL2Option2.BackColor = System.Drawing.Color.Orange;
            this.btnL2Option2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL2Option2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2Option2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL2Option2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnL2Option2.Location = new System.Drawing.Point(654, 136);
            this.btnL2Option2.Name = "btnL2Option2";
            this.btnL2Option2.Size = new System.Drawing.Size(257, 64);
            this.btnL2Option2.TabIndex = 30;
            this.btnL2Option2.Text = "Option 2";
            this.btnL2Option2.UseVisualStyleBackColor = false;
            this.btnL2Option2.Click += new System.EventHandler(this.btnL2Option2_Click);
            // 
            // btnL2Option1
            // 
            this.btnL2Option1.BackColor = System.Drawing.Color.Orange;
            this.btnL2Option1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL2Option1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2Option1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL2Option1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnL2Option1.Location = new System.Drawing.Point(182, 136);
            this.btnL2Option1.Name = "btnL2Option1";
            this.btnL2Option1.Size = new System.Drawing.Size(257, 64);
            this.btnL2Option1.TabIndex = 29;
            this.btnL2Option1.Text = "Option 1";
            this.btnL2Option1.UseVisualStyleBackColor = false;
            this.btnL2Option1.Click += new System.EventHandler(this.btnL2Option1_Click);
            // 
            // pnlLevel3
            // 
            this.pnlLevel3.BackColor = System.Drawing.Color.Red;
            this.pnlLevel3.Controls.Add(this.btnL3Option4);
            this.pnlLevel3.Controls.Add(this.btnL3Option3);
            this.pnlLevel3.Controls.Add(this.btnL3Option2);
            this.pnlLevel3.Controls.Add(this.btnL3Option1);
            this.pnlLevel3.Location = new System.Drawing.Point(143, 121);
            this.pnlLevel3.Name = "pnlLevel3";
            this.pnlLevel3.Size = new System.Drawing.Size(1092, 518);
            this.pnlLevel3.TabIndex = 38;
            // 
            // btnL3Option4
            // 
            this.btnL3Option4.BackColor = System.Drawing.Color.Magenta;
            this.btnL3Option4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL3Option4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL3Option4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL3Option4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnL3Option4.Location = new System.Drawing.Point(654, 318);
            this.btnL3Option4.Name = "btnL3Option4";
            this.btnL3Option4.Size = new System.Drawing.Size(257, 64);
            this.btnL3Option4.TabIndex = 32;
            this.btnL3Option4.Text = "Option 4";
            this.btnL3Option4.UseVisualStyleBackColor = false;
            this.btnL3Option4.Click += new System.EventHandler(this.btnL3Option4_Click);
            // 
            // btnL3Option3
            // 
            this.btnL3Option3.BackColor = System.Drawing.Color.Magenta;
            this.btnL3Option3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL3Option3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL3Option3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL3Option3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnL3Option3.Location = new System.Drawing.Point(182, 318);
            this.btnL3Option3.Name = "btnL3Option3";
            this.btnL3Option3.Size = new System.Drawing.Size(257, 64);
            this.btnL3Option3.TabIndex = 31;
            this.btnL3Option3.Text = "Option 3";
            this.btnL3Option3.UseVisualStyleBackColor = false;
            this.btnL3Option3.Click += new System.EventHandler(this.btnL3Option3_Click);
            // 
            // btnL3Option2
            // 
            this.btnL3Option2.BackColor = System.Drawing.Color.Magenta;
            this.btnL3Option2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL3Option2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL3Option2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL3Option2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnL3Option2.Location = new System.Drawing.Point(654, 136);
            this.btnL3Option2.Name = "btnL3Option2";
            this.btnL3Option2.Size = new System.Drawing.Size(257, 64);
            this.btnL3Option2.TabIndex = 30;
            this.btnL3Option2.Text = "Option 2";
            this.btnL3Option2.UseVisualStyleBackColor = false;
            this.btnL3Option2.Click += new System.EventHandler(this.btnL3Option2_Click);
            // 
            // btnL3Option1
            // 
            this.btnL3Option1.BackColor = System.Drawing.Color.Magenta;
            this.btnL3Option1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL3Option1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnL3Option1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL3Option1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnL3Option1.Location = new System.Drawing.Point(182, 136);
            this.btnL3Option1.Name = "btnL3Option1";
            this.btnL3Option1.Size = new System.Drawing.Size(257, 64);
            this.btnL3Option1.TabIndex = 29;
            this.btnL3Option1.Text = "Option 1";
            this.btnL3Option1.UseVisualStyleBackColor = false;
            this.btnL3Option1.Click += new System.EventHandler(this.btnL3Option1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStart.Location = new System.Drawing.Point(417, 266);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(257, 64);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // redOutput
            // 
            this.redOutput.Location = new System.Drawing.Point(9, 86);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(439, 465);
            this.redOutput.TabIndex = 39;
            this.redOutput.Text = "";
            this.redOutput.Visible = false;
            // 
            // lblChosen
            // 
            this.lblChosen.AutoSize = true;
            this.lblChosen.BackColor = System.Drawing.Color.White;
            this.lblChosen.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChosen.Location = new System.Drawing.Point(11, 86);
            this.lblChosen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChosen.Name = "lblChosen";
            this.lblChosen.Size = new System.Drawing.Size(98, 45);
            this.lblChosen.TabIndex = 42;
            this.lblChosen.Text = "Rank";
            // 
            // tFadeOut
            // 
            this.tFadeOut.Interval = 10;
            this.tFadeOut.Tick += new System.EventHandler(this.tFadeOut_Tick);
            // 
            // frmFindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 597);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlLevel3);
            this.Controls.Add(this.lblChosen);
            this.Controls.Add(this.pnlLevel2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLevel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.redOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFindingCallNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finding Call Numbers";
            this.Load += new System.EventHandler(this.frmFindingCallNumbers_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.pnlLevel1.ResumeLayout(false);
            this.pnlLevel2.ResumeLayout(false);
            this.pnlLevel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPointsGoal;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblGoalAttempts;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.Panel pnlLevel1;
        private System.Windows.Forms.Timer tAnimation;
        private System.Windows.Forms.Timer tLevel1;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Timer tLevel2;
        private System.Windows.Forms.Timer tLevel3;
        private System.Windows.Forms.Panel pnlLevel2;
        private System.Windows.Forms.Button btnL2Option4;
        private System.Windows.Forms.Button btnL2Option3;
        private System.Windows.Forms.Button btnL2Option2;
        private System.Windows.Forms.Button btnL2Option1;
        private System.Windows.Forms.Panel pnlLevel3;
        private System.Windows.Forms.Button btnL3Option4;
        private System.Windows.Forms.Button btnL3Option3;
        private System.Windows.Forms.Button btnL3Option2;
        private System.Windows.Forms.Button btnL3Option1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox redOutput;
        private System.Windows.Forms.Label lblChosen;
        private System.Windows.Forms.Timer tFadeOut;
    }
}