namespace AllesWissen
{
    partial class Vong_Khoi_Dong
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
            this.lbQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnAuto_Save = new System.Windows.Forms.Button();
            this.btnNext_Team = new System.Windows.Forms.Button();
            this.lbScoreTeam1 = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.lbScoreTeam2 = new System.Windows.Forms.Label();
            this.lbScoreTeam3 = new System.Windows.Forms.Label();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(12, 71);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(999, 83);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 212);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbTimer
            // 
            this.pbTimer.Location = new System.Drawing.Point(12, 171);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(999, 23);
            this.pbTimer.TabIndex = 2;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(224, 212);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(91, 39);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnAuto_Save
            // 
            this.btnAuto_Save.Location = new System.Drawing.Point(665, 212);
            this.btnAuto_Save.Name = "btnAuto_Save";
            this.btnAuto_Save.Size = new System.Drawing.Size(91, 39);
            this.btnAuto_Save.TabIndex = 5;
            this.btnAuto_Save.Text = "Auto Save";
            this.btnAuto_Save.UseVisualStyleBackColor = true;
            // 
            // btnNext_Team
            // 
            this.btnNext_Team.Location = new System.Drawing.Point(920, 212);
            this.btnNext_Team.Name = "btnNext_Team";
            this.btnNext_Team.Size = new System.Drawing.Size(91, 39);
            this.btnNext_Team.TabIndex = 6;
            this.btnNext_Team.Text = "Next Team";
            this.btnNext_Team.UseVisualStyleBackColor = true;
            this.btnNext_Team.Click += new System.EventHandler(this.btnNext_Team_Click);
            // 
            // lbScoreTeam1
            // 
            this.lbScoreTeam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbScoreTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreTeam1.ForeColor = System.Drawing.Color.Red;
            this.lbScoreTeam1.Location = new System.Drawing.Point(1052, 71);
            this.lbScoreTeam1.Name = "lbScoreTeam1";
            this.lbScoreTeam1.Size = new System.Drawing.Size(298, 83);
            this.lbScoreTeam1.TabIndex = 7;
            this.lbScoreTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(172, 307);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(161, 64);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.Location = new System.Drawing.Point(473, 307);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(161, 64);
            this.btnWrong.TabIndex = 9;
            this.btnWrong.Text = "Wrong";
            this.btnWrong.UseVisualStyleBackColor = true;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // lbScoreTeam2
            // 
            this.lbScoreTeam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbScoreTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreTeam2.ForeColor = System.Drawing.Color.Red;
            this.lbScoreTeam2.Location = new System.Drawing.Point(1052, 234);
            this.lbScoreTeam2.Name = "lbScoreTeam2";
            this.lbScoreTeam2.Size = new System.Drawing.Size(298, 83);
            this.lbScoreTeam2.TabIndex = 10;
            this.lbScoreTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScoreTeam3
            // 
            this.lbScoreTeam3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbScoreTeam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreTeam3.ForeColor = System.Drawing.Color.Red;
            this.lbScoreTeam3.Location = new System.Drawing.Point(1052, 395);
            this.lbScoreTeam3.Name = "lbScoreTeam3";
            this.lbScoreTeam3.Size = new System.Drawing.Size(298, 83);
            this.lbScoreTeam3.TabIndex = 11;
            this.lbScoreTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextRound
            // 
            this.btnNextRound.Location = new System.Drawing.Point(403, 449);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(136, 42);
            this.btnNextRound.TabIndex = 12;
            this.btnNextRound.Text = "Next Round";
            this.btnNextRound.UseVisualStyleBackColor = true;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(763, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 64);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1174, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Score Team1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1174, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Score Team2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1174, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Score Team3";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(458, 212);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(91, 39);
            this.btnContinue.TabIndex = 17;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // Vong_Khoi_Dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 632);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.lbScoreTeam3);
            this.Controls.Add(this.lbScoreTeam2);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbScoreTeam1);
            this.Controls.Add(this.btnNext_Team);
            this.Controls.Add(this.btnAuto_Save);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbQuestion);
            this.Name = "Vong_Khoi_Dong";
            this.Text = "Vong_Khhoi_Dong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vong_Khoi_Dong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnAuto_Save;
        private System.Windows.Forms.Button btnNext_Team;
        private System.Windows.Forms.Label lbScoreTeam1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.Label lbScoreTeam2;
        private System.Windows.Forms.Label lbScoreTeam3;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnContinue;
    }
}