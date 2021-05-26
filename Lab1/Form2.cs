using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private double P(double a,double b,double c) 
        {
            return a + b + c;
        }
        private double S(double a, double b, double c)
        {
            double p = (a+b+c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Data.P = 0;
                Data.S = 0;
                if (checkBox1.Checked)
                {
                    double A = Convert.ToDouble(textBox1.Text);
                    double B = Convert.ToDouble(textBox2.Text);
                    double C = Convert.ToDouble(textBox3.Text);

                    Data.P = P(A, B, C);
                }
                if (checkBox2.Checked)
                {
                    double A = Convert.ToDouble(textBox1.Text);
                    double B = Convert.ToDouble(textBox2.Text);
                    double C = Convert.ToDouble(textBox3.Text);
                    Data.S = S(A, B, C);
                }
                ParentForm main = this.Owner as ParentForm;
                if (main != null)
                {
                    main.calcToolStripMenuItem.Enabled = true;
                }
                
                Close();

            }
            else
            {
                Data.P = 0;
                Data.S = 0;
                ParentForm main = this.Owner as ParentForm;
                if (main != null)
                {
                    main.calcToolStripMenuItem.Enabled = false;
                }
            }
        }
    }
}
