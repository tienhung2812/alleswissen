namespace vuot_chuong_ngai_vat_client_new
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.Count_down = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Submit = new System.Windows.Forms.Button();
            this.Bell = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(26, 262);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(864, 96);
            this.Answer.TabIndex = 1;
            this.Answer.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Answer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(20, 76);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(870, 98);
            this.Question.TabIndex = 0;
            // 
            // Count_down
            // 
            //this.Count_down.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Count_down.AnimationSpeed = 500;
            this.Count_down.BackColor = System.Drawing.Color.Transparent;
            this.Count_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_down.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Count_down.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Count_down.InnerMargin = 2;
            this.Count_down.InnerWidth = -1;
            this.Count_down.Location = new System.Drawing.Point(969, 76);
            this.Count_down.MarqueeAnimationSpeed = 2000;
            this.Count_down.Name = "Count_down";
            this.Count_down.OuterColor = System.Drawing.Color.RoyalBlue;
            this.Count_down.OuterMargin = -25;
            this.Count_down.OuterWidth = 26;
            this.Count_down.ProgressColor = System.Drawing.Color.Lime;
            this.Count_down.ProgressWidth = 10;
            this.Count_down.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Count_down.Size = new System.Drawing.Size(104, 98);
            this.Count_down.StartAngle = 270;
            this.Count_down.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Count_down.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Count_down.SubscriptText = "";
            this.Count_down.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Count_down.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Count_down.SuperscriptText = "";
            this.Count_down.TabIndex = 3;
            this.Count_down.Text = "15";
            this.Count_down.TextMargin = new System.Windows.Forms.Padding(8, 8, 16, 8);
            this.Count_down.Value = 100;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Score:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 33);
            this.label4.TabIndex = 0;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(951, 378);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(122, 56);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "SUBMIT";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_click);
            // 
            // Bell
            // 
            this.Bell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bell.Location = new System.Drawing.Point(26, 378);
            this.Bell.Name = "Bell";
            this.Bell.Size = new System.Drawing.Size(104, 56);
            this.Bell.TabIndex = 4;
            this.Bell.Text = "BELL";
            this.Bell.UseVisualStyleBackColor = true;
            this.Bell.Click += new System.EventHandler(this.Bell_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 454);
            this.Controls.Add(this.Bell);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Count_down);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Question;
        private CircularProgressBar.CircularProgressBar Count_down;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Bell;
        private System.Windows.Forms.Timer timer2;
    }
}

