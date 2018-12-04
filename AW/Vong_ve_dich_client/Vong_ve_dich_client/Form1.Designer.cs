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
            this.Bell = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Score_vong_ve_dich = new System.Windows.Forms.Label();
            this.Count_down_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bell
            // 
            this.Bell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bell.Location = new System.Drawing.Point(30, 163);
            this.Bell.Name = "Bell";
            this.Bell.Size = new System.Drawing.Size(65, 65);
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
            this.Question.Location = new System.Drawing.Point(30, 30);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(793, 114);
            this.Question.TabIndex = 1;
            this.Question.Text = "aa";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score_vong_ve_dich
            // 
            this.Score_vong_ve_dich.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_vong_ve_dich.Location = new System.Drawing.Point(657, 146);
            this.Score_vong_ve_dich.Name = "Score_vong_ve_dich";
            this.Score_vong_ve_dich.Size = new System.Drawing.Size(90, 90);
            this.Score_vong_ve_dich.TabIndex = 2;
            this.Score_vong_ve_dich.Text = "Score";
            this.Score_vong_ve_dich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Count_down_1
            // 
            this.Count_down_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_down_1.Location = new System.Drawing.Point(829, 54);
            this.Count_down_1.Name = "Count_down_1";
            this.Count_down_1.Size = new System.Drawing.Size(65, 65);
            this.Count_down_1.TabIndex = 2;
            this.Count_down_1.Text = "15";
            this.Count_down_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 253);
            this.Controls.Add(this.Score_vong_ve_dich);
            this.Controls.Add(this.Count_down_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Bell);
            this.Name = "Form1";
            this.Text = "Vòng về đích";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bell;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score_vong_ve_dich;
        private System.Windows.Forms.Label Count_down_1;

    }
}

