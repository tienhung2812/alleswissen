using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DauTruong100
{
   
    public partial class Option : Form 
    {
        public static string qt;
        public Option()
        {
            InitializeComponent();
           
        }
        public int num_question { get; set; }
        public string question_type()
        {
            return qt;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
           
            var MainProgram = new MainProgram();
            qt = "Easy";
            question_type();
            this.Close();


        }
       
        private void btnHard_Click(object sender, EventArgs e)
        {
            this.Close();
            var MainProgram = new MainProgram();
            qt = "Hard";
            question_type();
        }
    }
}
