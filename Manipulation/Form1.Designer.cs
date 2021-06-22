
namespace Manipulation
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.choix = new System.Windows.Forms.GroupBox();
            this.casseBox = new System.Windows.Forms.CheckBox();
            this.couleurCaracBox = new System.Windows.Forms.CheckBox();
            this.couleurFondBox = new System.Windows.Forms.CheckBox();
            this.choixFond = new System.Windows.Forms.GroupBox();
            this.fondBleuBouton = new System.Windows.Forms.RadioButton();
            this.fondVertBouton = new System.Windows.Forms.RadioButton();
            this.fondRougeBouton = new System.Windows.Forms.RadioButton();
            this.choixCarac = new System.Windows.Forms.GroupBox();
            this.caracNoirBouton = new System.Windows.Forms.RadioButton();
            this.caracBlancBouton = new System.Windows.Forms.RadioButton();
            this.caracRougeBouton = new System.Windows.Forms.RadioButton();
            this.choixCasse = new System.Windows.Forms.GroupBox();
            this.majBouton = new System.Windows.Forms.RadioButton();
            this.miniBouton = new System.Windows.Forms.RadioButton();
            this.txtOut = new System.Windows.Forms.Label();
            this.choix.SuspendLayout();
            this.choixFond.SuspendLayout();
            this.choixCarac.SuspendLayout();
            this.choixCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(12, 53);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(226, 23);
            this.txtSource.TabIndex = 0;
            this.txtSource.TextChanged += new System.EventHandler(this.choix_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tapez votre texte :";
            // 
            // choix
            // 
            this.choix.Controls.Add(this.casseBox);
            this.choix.Controls.Add(this.couleurCaracBox);
            this.choix.Controls.Add(this.couleurFondBox);
            this.choix.Enabled = false;
            this.choix.Location = new System.Drawing.Point(561, 84);
            this.choix.Name = "choix";
            this.choix.Size = new System.Drawing.Size(200, 100);
            this.choix.TabIndex = 2;
            this.choix.TabStop = false;
            this.choix.Text = "Choix";
            this.choix.Enter += new System.EventHandler(this.choix_Enter);
            // 
            // casseBox
            // 
            this.casseBox.AutoSize = true;
            this.casseBox.Location = new System.Drawing.Point(7, 75);
            this.casseBox.Name = "casseBox";
            this.casseBox.Size = new System.Drawing.Size(56, 19);
            this.casseBox.TabIndex = 2;
            this.casseBox.Text = "Casse";
            this.casseBox.UseVisualStyleBackColor = true;
            this.casseBox.CheckedChanged += new System.EventHandler(this.casseBox_CheckedChanged);
            // 
            // couleurCaracBox
            // 
            this.couleurCaracBox.AutoSize = true;
            this.couleurCaracBox.Location = new System.Drawing.Point(7, 49);
            this.couleurCaracBox.Name = "couleurCaracBox";
            this.couleurCaracBox.Size = new System.Drawing.Size(145, 19);
            this.couleurCaracBox.TabIndex = 1;
            this.couleurCaracBox.Text = "Couleur des caractères";
            this.couleurCaracBox.UseVisualStyleBackColor = true;
            this.couleurCaracBox.CheckedChanged += new System.EventHandler(this.couleurCaracBox_CheckedChanged);
            // 
            // couleurFondBox
            // 
            this.couleurFondBox.AutoSize = true;
            this.couleurFondBox.Location = new System.Drawing.Point(7, 23);
            this.couleurFondBox.Name = "couleurFondBox";
            this.couleurFondBox.Size = new System.Drawing.Size(113, 19);
            this.couleurFondBox.TabIndex = 0;
            this.couleurFondBox.Text = "Couleur du fond";
            this.couleurFondBox.UseVisualStyleBackColor = true;
            this.couleurFondBox.CheckedChanged += new System.EventHandler(this.couleurFondBox_CheckedChanged);
            // 
            // choixFond
            // 
            this.choixFond.Controls.Add(this.fondBleuBouton);
            this.choixFond.Controls.Add(this.fondVertBouton);
            this.choixFond.Controls.Add(this.fondRougeBouton);
            this.choixFond.Location = new System.Drawing.Point(138, 306);
            this.choixFond.Name = "choixFond";
            this.choixFond.Size = new System.Drawing.Size(200, 100);
            this.choixFond.TabIndex = 3;
            this.choixFond.TabStop = false;
            this.choixFond.Text = "Fond";
            this.choixFond.Visible = false;
            // 
            // fondBleuBouton
            // 
            this.fondBleuBouton.AutoSize = true;
            this.fondBleuBouton.Location = new System.Drawing.Point(7, 75);
            this.fondBleuBouton.Name = "fondBleuBouton";
            this.fondBleuBouton.Size = new System.Drawing.Size(48, 19);
            this.fondBleuBouton.TabIndex = 2;
            this.fondBleuBouton.TabStop = true;
            this.fondBleuBouton.Text = "Bleu";
            this.fondBleuBouton.UseVisualStyleBackColor = true;
            this.fondBleuBouton.CheckedChanged += new System.EventHandler(this.fondBleuBouton_CheckedChanged);
            // 
            // fondVertBouton
            // 
            this.fondVertBouton.AutoSize = true;
            this.fondVertBouton.Location = new System.Drawing.Point(7, 49);
            this.fondVertBouton.Name = "fondVertBouton";
            this.fondVertBouton.Size = new System.Drawing.Size(45, 19);
            this.fondVertBouton.TabIndex = 1;
            this.fondVertBouton.TabStop = true;
            this.fondVertBouton.Text = "Vert";
            this.fondVertBouton.UseVisualStyleBackColor = true;
            this.fondVertBouton.CheckedChanged += new System.EventHandler(this.fondVertBouton_CheckedChanged);
            // 
            // fondRougeBouton
            // 
            this.fondRougeBouton.AutoSize = true;
            this.fondRougeBouton.Location = new System.Drawing.Point(7, 23);
            this.fondRougeBouton.Name = "fondRougeBouton";
            this.fondRougeBouton.Size = new System.Drawing.Size(59, 19);
            this.fondRougeBouton.TabIndex = 0;
            this.fondRougeBouton.TabStop = true;
            this.fondRougeBouton.Text = "Rouge";
            this.fondRougeBouton.UseVisualStyleBackColor = true;
            this.fondRougeBouton.CheckedChanged += new System.EventHandler(this.fondRougeBouton_CheckedChanged);
            // 
            // choixCarac
            // 
            this.choixCarac.Controls.Add(this.caracNoirBouton);
            this.choixCarac.Controls.Add(this.caracBlancBouton);
            this.choixCarac.Controls.Add(this.caracRougeBouton);
            this.choixCarac.Location = new System.Drawing.Point(359, 306);
            this.choixCarac.Name = "choixCarac";
            this.choixCarac.Size = new System.Drawing.Size(200, 100);
            this.choixCarac.TabIndex = 4;
            this.choixCarac.TabStop = false;
            this.choixCarac.Text = "Caractères";
            this.choixCarac.Visible = false;
            // 
            // caracNoirBouton
            // 
            this.caracNoirBouton.AutoSize = true;
            this.caracNoirBouton.Location = new System.Drawing.Point(7, 74);
            this.caracNoirBouton.Name = "caracNoirBouton";
            this.caracNoirBouton.Size = new System.Drawing.Size(48, 19);
            this.caracNoirBouton.TabIndex = 2;
            this.caracNoirBouton.TabStop = true;
            this.caracNoirBouton.Text = "Noir";
            this.caracNoirBouton.UseVisualStyleBackColor = true;
            this.caracNoirBouton.CheckedChanged += new System.EventHandler(this.caracNoirBouton_CheckedChanged);
            // 
            // caracBlancBouton
            // 
            this.caracBlancBouton.AutoSize = true;
            this.caracBlancBouton.Location = new System.Drawing.Point(7, 48);
            this.caracBlancBouton.Name = "caracBlancBouton";
            this.caracBlancBouton.Size = new System.Drawing.Size(54, 19);
            this.caracBlancBouton.TabIndex = 1;
            this.caracBlancBouton.TabStop = true;
            this.caracBlancBouton.Text = "Blanc";
            this.caracBlancBouton.UseVisualStyleBackColor = true;
            this.caracBlancBouton.CheckedChanged += new System.EventHandler(this.caracBlancBouton_CheckedChanged);
            // 
            // caracRougeBouton
            // 
            this.caracRougeBouton.AutoSize = true;
            this.caracRougeBouton.Location = new System.Drawing.Point(7, 23);
            this.caracRougeBouton.Name = "caracRougeBouton";
            this.caracRougeBouton.Size = new System.Drawing.Size(59, 19);
            this.caracRougeBouton.TabIndex = 0;
            this.caracRougeBouton.TabStop = true;
            this.caracRougeBouton.Text = "Rouge";
            this.caracRougeBouton.UseVisualStyleBackColor = true;
            this.caracRougeBouton.CheckedChanged += new System.EventHandler(this.caracRougeBouton_CheckedChanged);
            // 
            // choixCasse
            // 
            this.choixCasse.Controls.Add(this.majBouton);
            this.choixCasse.Controls.Add(this.miniBouton);
            this.choixCasse.Location = new System.Drawing.Point(568, 306);
            this.choixCasse.Name = "choixCasse";
            this.choixCasse.Size = new System.Drawing.Size(200, 100);
            this.choixCasse.TabIndex = 5;
            this.choixCasse.TabStop = false;
            this.choixCasse.Text = "Casse";
            this.choixCasse.Visible = false;
            this.choixCasse.Enter += new System.EventHandler(this.choixCasse_Enter);
            // 
            // majBouton
            // 
            this.majBouton.AutoSize = true;
            this.majBouton.Location = new System.Drawing.Point(7, 48);
            this.majBouton.Name = "majBouton";
            this.majBouton.Size = new System.Drawing.Size(84, 19);
            this.majBouton.TabIndex = 1;
            this.majBouton.TabStop = true;
            this.majBouton.Text = "Majuscules";
            this.majBouton.UseVisualStyleBackColor = true;
            this.majBouton.CheckedChanged += new System.EventHandler(this.majBouton_CheckedChanged);
            // 
            // miniBouton
            // 
            this.miniBouton.AutoSize = true;
            this.miniBouton.Location = new System.Drawing.Point(7, 22);
            this.miniBouton.Name = "miniBouton";
            this.miniBouton.Size = new System.Drawing.Size(85, 19);
            this.miniBouton.TabIndex = 0;
            this.miniBouton.TabStop = true;
            this.miniBouton.Text = "Minuscules";
            this.miniBouton.UseVisualStyleBackColor = true;
            this.miniBouton.CheckedChanged += new System.EventHandler(this.miniBouton_CheckedChanged);
            // 
            // txtOut
            // 
            this.txtOut.AutoSize = true;
            this.txtOut.Location = new System.Drawing.Point(12, 159);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(0, 15);
            this.txtOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.choixCasse);
            this.Controls.Add(this.choixCarac);
            this.Controls.Add(this.choixFond);
            this.Controls.Add(this.choix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.choix.ResumeLayout(false);
            this.choix.PerformLayout();
            this.choixFond.ResumeLayout(false);
            this.choixFond.PerformLayout();
            this.choixCarac.ResumeLayout(false);
            this.choixCarac.PerformLayout();
            this.choixCasse.ResumeLayout(false);
            this.choixCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox choix;
        private System.Windows.Forms.CheckBox casseBox;
        private System.Windows.Forms.CheckBox couleurCaracBox;
        private System.Windows.Forms.CheckBox couleurFondBox;
        private System.Windows.Forms.GroupBox choixFond;
        private System.Windows.Forms.GroupBox choixCarac;
        private System.Windows.Forms.GroupBox choixCasse;
        private System.Windows.Forms.RadioButton fondBleuBouton;
        private System.Windows.Forms.RadioButton fondVertBouton;
        private System.Windows.Forms.RadioButton fondRougeBouton;
        private System.Windows.Forms.RadioButton caracNoirBouton;
        private System.Windows.Forms.RadioButton caracBlancBouton;
        private System.Windows.Forms.RadioButton caracRougeBouton;
        private System.Windows.Forms.RadioButton majBouton;
        private System.Windows.Forms.RadioButton miniBouton;
        private System.Windows.Forms.Label txtOut;
    }
}

