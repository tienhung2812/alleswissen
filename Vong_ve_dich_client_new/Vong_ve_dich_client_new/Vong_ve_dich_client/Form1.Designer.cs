namespace Vong_ve_dich_client
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
            this.Bell = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.Pack = new System.Windows.Forms.Label();
            this.Countdown = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Bell
            // 
            this.Bell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bell.Location = new System.Drawing.Point(22, 135);
            this.Bell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bell.Name = "Bell";
            this.Bell.Size = new System.Drawing.Size(61, 42);
            this.Bell.TabIndex = 0;
            this.Bell.Text = "Bell";
            this.Bell.UseVisualStyleBackColor = true;
            this.Bell.Click += new System.EventHandler(this.Bell_Click);
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Question.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(22, 24);
            this.Question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(595, 93);
            this.Question.TabIndex = 1;
            this.Question.Text = "aa";
            // 
            // Pack
            // 
            this.Pack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pack.Location = new System.Drawing.Point(401, 119);
            this.Pack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pack.Name = "Pack";
            this.Pack.Size = new System.Drawing.Size(68, 73);
            this.Pack.TabIndex = 2;
            this.Pack.Text = "Pack:";
            this.Pack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Countdown
            // 
            //this.Countdown.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Countdown.AnimationSpeed = 500;
            this.Countdown.BackColor = System.Drawing.Color.Transparent;
            this.Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Countdown.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Countdown.InnerMargin = 2;
            this.Countdown.InnerWidth = -1;
            this.Countdown.Location = new System.Drawing.Point(632, 24);
            this.Countdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Countdown.MarqueeAnimationSpeed = 2000;
            this.Countdown.Maximum = 1500;
            this.Countdown.Name = "Countdown";
            this.Countdown.OuterColor = System.Drawing.Color.Gray;
            this.Countdown.OuterMargin = -25;
            this.Countdown.OuterWidth = 26;
            this.Countdown.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Countdown.ProgressWidth = 10;
            this.Countdown.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Countdown.Size = new System.Drawing.Size(73, 73);
            this.Countdown.StartAngle = 270;
            this.Countdown.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Countdown.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Countdown.SubscriptText = "";
            this.Countdown.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Countdown.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Countdown.SuperscriptText = "";
            this.Countdown.TabIndex = 3;
            this.Countdown.Text = "15";
            this.Countdown.TextMargin = new System.Windows.Forms.Padding(8, 8, 16, 8);
            this.Countdown.Value = 1500;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 206);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.Pack);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Bell);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Vòng về đích";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bell;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label Pack;
        private CircularProgressBar.CircularProgressBar Countdown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

    }
}

