using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class SplashForm : Form
    {
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BmiCalculator bmiCalculator = new BmiCalculator();
            bmiCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;//it is used to turn timer off

            
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
