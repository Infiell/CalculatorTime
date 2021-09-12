using System;
using System.Windows.Forms;

namespace CalculatorTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Hour, Minutes, Sec_First, Sec_Second, Sec, Result;
            Hour = 0;
            Minutes = 0;
            Sec_First = ((Convert.ToDouble(numericUpDown1.Value) * 60) + Convert.ToDouble(numericUpDown2.Value)) * 60 + Convert.ToDouble(numericUpDown3.Value);
            Sec_Second = ((Convert.ToDouble(numericUpDown4.Value) * 60) + Convert.ToDouble(numericUpDown5.Value)) * 60 + Convert.ToDouble(numericUpDown6.Value);
            Result = Sec_Second - Sec_First;
            if (Result >= 60)
            {
                Minutes = Math.Truncate(Result / 60);
                Sec = Result - (Minutes * 60);
                if (Minutes >= 60)
                {
                    Hour = Math.Truncate(Minutes / 60);
                    Minutes = Minutes - (Hour * 60);
                }
            }
            else
            {
                Sec = Result;
            }
            label1.Text = Convert.ToString(Hour) + ':' + Convert.ToString(Minutes) + ':' + Convert.ToString(Sec);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
        }
    }
}
