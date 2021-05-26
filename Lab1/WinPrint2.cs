﻿using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class WinPrint2 : Form
    {
        public WinPrint2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Rows = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Columns = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Zoom = (double)numericUpDown1.Value / 100;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            printPreviewControl1.UseAntiAlias = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
