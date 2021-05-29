
namespace Lab1
{
    partial class WinAsynchMethod
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
            this.components = new System.ComponentModel.Container();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbB = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Help = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.helpProvider1.SetHelpString(this.btnRun, "Sum");
            this.btnRun.Location = new System.Drawing.Point(12, 52);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.helpProvider1.SetShowHelp(this.btnRun, true);
            this.btnRun.Size = new System.Drawing.Size(56, 19);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Сумма";
            this.toolTip1.SetToolTip(this.btnRun, "Sum");
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWork
            // 
            this.helpProvider1.SetHelpString(this.btnWork, "Start Work");
            this.btnWork.Location = new System.Drawing.Point(90, 104);
            this.btnWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWork.Name = "btnWork";
            this.helpProvider1.SetShowHelp(this.btnWork, true);
            this.btnWork.Size = new System.Drawing.Size(56, 19);
            this.btnWork.TabIndex = 1;
            this.btnWork.Text = "Работа";
            this.toolTip1.SetToolTip(this.btnWork, "Start Work");
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(6, 20);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Значение A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(154, 22);
            this.lblB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(65, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Значение B";
            // 
            // txtbA
            // 
            this.helpProvider1.SetHelpString(this.txtbA, "for input integer A");
            this.txtbA.Location = new System.Drawing.Point(75, 20);
            this.txtbA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbA.Name = "txtbA";
            this.helpProvider1.SetShowHelp(this.txtbA, true);
            this.txtbA.Size = new System.Drawing.Size(76, 20);
            this.txtbA.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtbA, "for input integer A");
            // 
            // txtbB
            // 
            this.helpProvider1.SetHelpString(this.txtbB, "for input integer B");
            this.txtbB.Location = new System.Drawing.Point(222, 20);
            this.txtbB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbB.Name = "txtbB";
            this.helpProvider1.SetShowHelp(this.txtbB, true);
            this.txtbB.Size = new System.Drawing.Size(76, 20);
            this.txtbB.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtbB, "for input integer B");
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\user\\source\\repos\\Prog_Inj\\Lab1\\help.txt";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(239, 51);
            this.Help.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(56, 19);
            this.Help.TabIndex = 6;
            this.Help.Text = "Help";
            this.toolTip1.SetToolTip(this.Help, "Start Work");
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // WinAsynchMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 124);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.helpProvider1.SetHelpString(this, "for input integer B");
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinAsynchMethod";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "WynAsynchMethod";
            this.Load += new System.EventHandler(this.WynAsynchMethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbB;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}