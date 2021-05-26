using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Data.P != 0) label1.Text = Data.P.ToString();
            else label4.Visible = false;
            if(Data.S != 0)label2.Text = Data.S.ToString();
            else label3.Visible = false;
        }
    }
}
