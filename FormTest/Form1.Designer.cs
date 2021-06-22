
namespace FormTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.copy = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(781, 33);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(77, 30);
            this.copy.TabIndex = 0;
            this.copy.Text = "Recopier";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(781, 92);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 30);
            this.delete.TabIndex = 1;
            this.delete.Text = "Effacer";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(781, 150);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(77, 30);
            this.quit.TabIndex = 2;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(221, 39);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(223, 23);
            this.txtSource.TabIndex = 3;
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(44, 39);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(55, 15);
            this.labelOrigin.TabIndex = 4;
            this.labelOrigin.Text = "Original :";
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.Location = new System.Drawing.Point(52, 100);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(47, 15);
            this.labelCopy.TabIndex = 5;
            this.labelCopy.Text = "Copie : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(905, 210);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.copy);
            this.Name = "Form1";
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelCopy;
    }
}

