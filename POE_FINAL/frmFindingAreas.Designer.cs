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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPointsGoal = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblGoalAttempts = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1068, 100);
            this.pnlHeader.TabIndex = 27;
            // 
            // lblPointsGoal
            // 
            this.lblPointsGoal.AutoSize = true;
            this.lblPointsGoal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPointsGoal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPointsGoal.Location = new System.Drawing.Point(559, 48);
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
            this.lblPoints.Location = new System.Drawing.Point(376, 48);
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
            this.lblGoalAttempts.Location = new System.Drawing.Point(599, 11);
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
            this.lblHeading.Location = new System.Drawing.Point(376, 11);
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
            this.btnClose.Location = new System.Drawing.Point(1024, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 41);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(945, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 41);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStart.Location = new System.Drawing.Point(81, 615);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(343, 79);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmFindingAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 736);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindingAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finding Areas";
            this.Load += new System.EventHandler(this.frmFindingAreas_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
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
    }
}