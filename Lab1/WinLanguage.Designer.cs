﻿
namespace Lab1
{
    partial class WinLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLanguage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandOneToolStripMenuItem,
            this.commandTwoToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // commandOneToolStripMenuItem
            // 
            resources.ApplyResources(this.commandOneToolStripMenuItem, "commandOneToolStripMenuItem");
            this.commandOneToolStripMenuItem.Name = "commandOneToolStripMenuItem";
            // 
            // commandTwoToolStripMenuItem
            // 
            resources.ApplyResources(this.commandTwoToolStripMenuItem, "commandTwoToolStripMenuItem");
            this.commandTwoToolStripMenuItem.Name = "commandTwoToolStripMenuItem";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WinLanguage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinLanguage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandTwoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}