
namespace GestionSalaraies
{
    partial class GestionMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionUtilistateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUtilistateurToolStripMenuItem,
            this.gestionSalariésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionUtilistateurToolStripMenuItem
            // 
            this.gestionUtilistateurToolStripMenuItem.Name = "gestionUtilistateurToolStripMenuItem";
            this.gestionUtilistateurToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.gestionUtilistateurToolStripMenuItem.Text = "Gestion Utilistateur";
            this.gestionUtilistateurToolStripMenuItem.Click += new System.EventHandler(this.gestionUtilistateurToolStripMenuItem_Click);
            // 
            // gestionSalariésToolStripMenuItem
            // 
            this.gestionSalariésToolStripMenuItem.Name = "gestionSalariésToolStripMenuItem";
            this.gestionSalariésToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.gestionSalariésToolStripMenuItem.Text = "Gestion Salariés";
            this.gestionSalariésToolStripMenuItem.Click += new System.EventHandler(this.gestionSalariésToolStripMenuItem_Click);
            // 
            // GestionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionUtilistateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSalariésToolStripMenuItem;
    }
}