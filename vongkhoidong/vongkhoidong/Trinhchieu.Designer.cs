namespace vongkhoidong
{
    partial class Trinhchieu
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
            this.cauhoi = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.doi1 = new System.Windows.Forms.TextBox();
            this.doi2 = new System.Windows.Forms.TextBox();
            this.doi3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cauhoi
            // 
            this.cauhoi.Location = new System.Drawing.Point(12, 158);
            this.cauhoi.Multiline = true;
            this.cauhoi.Name = "cauhoi";
            this.cauhoi.Size = new System.Drawing.Size(610, 121);
            this.cauhoi.TabIndex = 0;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(683, 33);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(110, 60);
            this.next.TabIndex = 2;
            this.next.Text = "Start";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 106);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // doi1
            // 
            this.doi1.Location = new System.Drawing.Point(27, 18);
            this.doi1.Multiline = true;
            this.doi1.Name = "doi1";
            this.doi1.Size = new System.Drawing.Size(126, 61);
            this.doi1.TabIndex = 4;
            // 
            // doi2
            // 
            this.doi2.Location = new System.Drawing.Point(185, 18);
            this.doi2.Multiline = true;
            this.doi2.Name = "doi2";
            this.doi2.Size = new System.Drawing.Size(126, 61);
            this.doi2.TabIndex = 5;
            // 
            // doi3
            // 
            this.doi3.Location = new System.Drawing.Point(348, 18);
            this.doi3.Multiline = true;
            this.doi3.Name = "doi3";
            this.doi3.Size = new System.Drawing.Size(126, 61);
            this.doi3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 78);
            this.button1.TabIndex = 7;
            this.button1.Text = "next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doi3);
            this.Controls.Add(this.doi2);
            this.Controls.Add(this.doi1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.cauhoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cauhoi;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox doi1;
        private System.Windows.Forms.TextBox doi2;
        private System.Windows.Forms.TextBox doi3;
        private System.Windows.Forms.Button button1;
    }
}

