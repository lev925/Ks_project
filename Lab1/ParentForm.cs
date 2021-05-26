using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dial = new Form2();
            dial.Owner = this;
            dial.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dial = new Form3();
            dial.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(this.Height, 0) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void FileMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    Form3 newChild = new Form3();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Title":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
