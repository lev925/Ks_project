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
    public partial class WinQuestioncs : Form
    {
        public WinQuestioncs()
        {
            InitializeComponent();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что вы так думаете!");
        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            btnno.Top -= e.Y;
            btnno.Left += e.X;
            if (btnno.Top < -10 || btnno.Top > 90)
                btnno.Top = 60;
            if (btnno.Left < 80 || btnno.Left > 200)
                btnno.Left = 120;
        }
    }
}
