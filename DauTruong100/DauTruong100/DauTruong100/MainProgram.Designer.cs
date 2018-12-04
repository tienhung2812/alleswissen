namespace DauTruong100
{
    partial class MainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lb2Answer = new System.Windows.Forms.Label();
            this.lbKhangia = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.tbNumOfPlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(28, 56);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(779, 74);
            this.textBoxQuestion.TabIndex = 4;
            this.textBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(877, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 257);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(877, 320);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(205, 55);
            this.btnEasy.TabIndex = 6;
            this.btnEasy.Text = "Dễ";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnHard
            // 
            this.btnHard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHard.FlatAppearance.BorderSize = 5;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHard.Location = new System.Drawing.Point(1131, 319);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(205, 55);
            this.btnHard.TabIndex = 7;
            this.btnHard.Text = "Khó";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(877, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quyền trợ giúp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbA
            // 
            this.lbA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(28, 163);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(188, 59);
            this.lbA.TabIndex = 12;
            this.lbA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbA.Click += new System.EventHandler(this.lbA_Click);
            // 
            // lbB
            // 
            this.lbB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(334, 163);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(188, 59);
            this.lbB.TabIndex = 13;
            this.lbB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbB.Click += new System.EventHandler(this.lbB_Click);
            // 
            // lbC
            // 
            this.lbC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(619, 163);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(188, 59);
            this.lbC.TabIndex = 14;
            this.lbC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbC.Click += new System.EventHandler(this.lbC_Click);
            // 
            // lb2Answer
            // 
            this.lb2Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb2Answer.Image = ((System.Drawing.Image)(resources.GetObject("lb2Answer.Image")));
            this.lb2Answer.Location = new System.Drawing.Point(881, 567);
            this.lb2Answer.Name = "lb2Answer";
            this.lb2Answer.Size = new System.Drawing.Size(122, 62);
            this.lb2Answer.TabIndex = 15;
            this.lb2Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb2Answer.Click += new System.EventHandler(this.lb2Answer_Click);
            // 
            // lbKhangia
            // 
            this.lbKhangia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbKhangia.Image = ((System.Drawing.Image)(resources.GetObject("lbKhangia.Image")));
            this.lbKhangia.Location = new System.Drawing.Point(1221, 567);
            this.lbKhangia.Name = "lbKhangia";
            this.lbKhangia.Size = new System.Drawing.Size(122, 62);
            this.lbKhangia.TabIndex = 16;
            this.lbKhangia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbKhangia.Click += new System.EventHandler(this.lbKhangia_Click);
            // 
            // lbChange
            // 
            this.lbChange.BackColor = System.Drawing.Color.White;
            this.lbChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChange.Image = ((System.Drawing.Image)(resources.GetObject("lbChange.Image")));
            this.lbChange.Location = new System.Drawing.Point(1054, 567);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(122, 62);
            this.lbChange.TabIndex = 16;
            this.lbChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbChange.Click += new System.EventHandler(this.lbChange_Click);
            // 
            // tbNumOfPlayer
            // 
            this.tbNumOfPlayer.Location = new System.Drawing.Point(928, 854);
            this.tbNumOfPlayer.Name = "tbNumOfPlayer";
            this.tbNumOfPlayer.Size = new System.Drawing.Size(40, 20);
            this.tbNumOfPlayer.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(943, 827);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số người chơi còn lại";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(962, 886);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 32);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainProgram
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumOfPlayer);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.lbKhangia);
            this.Controls.Add(this.lb2Answer);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxQuestion);
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lb2Answer;
        private System.Windows.Forms.Label lbKhangia;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.TextBox tbNumOfPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
    }
}