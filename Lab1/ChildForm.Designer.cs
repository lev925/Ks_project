
namespace Lab1
{
    partial class ChildForm
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
            this.ChildTextBox = new System.Windows.Forms.RichTextBox();
            this.hildWindowMenu = new System.Windows.Forms.MenuStrip();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hildWindowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildTextBox
            // 
            this.ChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildTextBox.Location = new System.Drawing.Point(0, 24);
            this.ChildTextBox.Name = "ChildTextBox";
            this.ChildTextBox.Size = new System.Drawing.Size(800, 426);
            this.ChildTextBox.TabIndex = 0;
            this.ChildTextBox.Text = "";
            // 
            // hildWindowMenu
            // 
            this.hildWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatMenuItem});
            this.hildWindowMenu.Location = new System.Drawing.Point(0, 0);
            this.hildWindowMenu.Name = "hildWindowMenu";
            this.hildWindowMenu.Size = new System.Drawing.Size(800, 24);
            this.hildWindowMenu.TabIndex = 1;
            this.hildWindowMenu.Text = "menuStrip1";
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleMenuItem});
            this.formatMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatMenuItem.Text = "F&ormat";
            // 
            // toggleMenuItem
            // 
            this.toggleMenuItem.Name = "toggleMenuItem";
            this.toggleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toggleMenuItem.Text = "Toggle Foreground";
            this.toggleMenuItem.Click += new System.EventHandler(this.toggleMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildTextBox);
            this.Controls.Add(this.hildWindowMenu);
            this.MainMenuStrip = this.hildWindowMenu;
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.hildWindowMenu.ResumeLayout(false);
            this.hildWindowMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChildTextBox;
        private System.Windows.Forms.MenuStrip hildWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleMenuItem;
    }
}