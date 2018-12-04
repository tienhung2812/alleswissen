namespace Vuot_chuong_ngai_vat_client
{
    partial class Vong_vuot_chuong_ngai_vat_client
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
            this.Bell = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Submit = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.Cdown = new CircularProgressBar.CircularProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Bell
            // 
            this.Bell.Location = new System.Drawing.Point(12, 459);
            this.Bell.Name = "Bell";
            this.Bell.Size = new System.Drawing.Size(95, 53);
            this.Bell.TabIndex = 0;
            this.Bell.Text = "Bell";
            this.Bell.UseVisualStyleBackColor = true;
            this.Bell.Click += new System.EventHandler(this.Bell_click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(679, 459);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(85, 53);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(302, 459);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 53);
            this.label.TabIndex = 4;
            this.label.Text = "Score";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(410, 459);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(86, 53);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Question
            // 
            this.Question.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(57, 140);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(583, 82);
            this.Question.TabIndex = 5;
            this.Question.Text = "aaa";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(57, 313);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(583, 86);
            this.Answer.TabIndex = 6;
            this.Answer.Text = "";
            // 
            // Cdown
            // 
            this.Cdown.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Cdown.AnimationSpeed = 500;
            this.Cdown.BackColor = System.Drawing.Color.Transparent;
            this.Cdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cdown.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cdown.InnerMargin = 2;
            this.Cdown.InnerWidth = -1;
            this.Cdown.Location = new System.Drawing.Point(662, 124);
            this.Cdown.MarqueeAnimationSpeed = 2000;
            this.Cdown.Name = "Cdown";
            this.Cdown.OuterColor = System.Drawing.Color.Gray;
            this.Cdown.OuterMargin = -25;
            this.Cdown.OuterWidth = 26;
            this.Cdown.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cdown.ProgressWidth = 10;
            this.Cdown.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cdown.Size = new System.Drawing.Size(102, 98);
            this.Cdown.StartAngle = 270;
            this.Cdown.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cdown.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Cdown.SubscriptText = "";
            this.Cdown.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cdown.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Cdown.SuperscriptText = "";
            this.Cdown.TabIndex = 7;
            this.Cdown.Text = "15";
            this.Cdown.TextMargin = new System.Windows.Forms.Padding(8, 8, 16, 8);
            this.Cdown.Value = 100;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Vong_vuot_chuong_ngai_vat_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 525);
            this.Controls.Add(this.Cdown);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Bell);
            this.Name = "Vong_vuot_chuong_ngai_vat_client";
            this.Text = "Vòng vượt chướng ngại vật";
            this.Load += new System.EventHandler(this.t_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bell;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Answer;
        private CircularProgressBar.CircularProgressBar Cdown;
        private System.Windows.Forms.Timer timer2;
    }
}

