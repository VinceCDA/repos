
namespace TestChara01
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.ansButton = new System.Windows.Forms.Button();
            this.posiChara = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.posiChara)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            // 
            // txtSource
            // 
            this.txtSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSource.Location = new System.Drawing.Point(157, 9);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(245, 23);
            this.txtSource.TabIndex = 1;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position du caractère :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Résultat :";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(157, 136);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(245, 23);
            this.txtOut.TabIndex = 5;
            // 
            // ansButton
            // 
            this.ansButton.Location = new System.Drawing.Point(157, 217);
            this.ansButton.Name = "ansButton";
            this.ansButton.Size = new System.Drawing.Size(165, 37);
            this.ansButton.TabIndex = 6;
            this.ansButton.Text = "Catégorie du caractère";
            this.ansButton.UseVisualStyleBackColor = true;
            this.ansButton.Click += new System.EventHandler(this.ansButton_Click);
            // 
            // posiChara
            // 
            this.posiChara.Location = new System.Drawing.Point(157, 67);
            this.posiChara.Name = "posiChara";
            this.posiChara.Size = new System.Drawing.Size(100, 23);
            this.posiChara.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 305);
            this.Controls.Add(this.posiChara);
            this.Controls.Add(this.ansButton);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.posiChara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button ansButton;
        private System.Windows.Forms.NumericUpDown posiChara;
    }
}

