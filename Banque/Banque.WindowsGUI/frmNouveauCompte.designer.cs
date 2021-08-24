namespace Banque.WindowsGUI
{
    partial class FrmNouveauCompte
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
            System.Windows.Forms.Label cleRIBLabel;
            System.Windows.Forms.Label codeGuichetLabel;
            System.Windows.Forms.Label libelleCompteLabel;
            System.Windows.Forms.Label numeroCompteLabel;
            System.Windows.Forms.Label codeBanqueLabel;
            this.erpCompte = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnAbandonner = new System.Windows.Forms.Button();
            this.gbCompteExterne = new System.Windows.Forms.GroupBox();
            this.codeBanqueTextBox = new System.Windows.Forms.TextBox();
            this.codeGuichetTextBox = new System.Windows.Forms.TextBox();
            this.numeroCompteTextBox = new System.Windows.Forms.TextBox();
            this.cleRIBTextBox = new System.Windows.Forms.TextBox();
            this.libelleCompteTextBox = new System.Windows.Forms.TextBox();
            this.compteExterneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cleRIBLabel = new System.Windows.Forms.Label();
            codeGuichetLabel = new System.Windows.Forms.Label();
            libelleCompteLabel = new System.Windows.Forms.Label();
            numeroCompteLabel = new System.Windows.Forms.Label();
            codeBanqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erpCompte)).BeginInit();
            this.gbCompteExterne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compteExterneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cleRIBLabel
            // 
            cleRIBLabel.AutoSize = true;
            cleRIBLabel.Location = new System.Drawing.Point(20, 143);
            cleRIBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cleRIBLabel.Name = "cleRIBLabel";
            cleRIBLabel.Size = new System.Drawing.Size(58, 17);
            cleRIBLabel.TabIndex = 6;
            cleRIBLabel.Text = "Cle RIB:";
            // 
            // codeGuichetLabel
            // 
            codeGuichetLabel.AutoSize = true;
            codeGuichetLabel.Location = new System.Drawing.Point(20, 76);
            codeGuichetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codeGuichetLabel.Name = "codeGuichetLabel";
            codeGuichetLabel.Size = new System.Drawing.Size(98, 17);
            codeGuichetLabel.TabIndex = 2;
            codeGuichetLabel.Text = "Code Guichet:";
            // 
            // libelleCompteLabel
            // 
            libelleCompteLabel.AutoSize = true;
            libelleCompteLabel.Location = new System.Drawing.Point(20, 175);
            libelleCompteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            libelleCompteLabel.Name = "libelleCompteLabel";
            libelleCompteLabel.Size = new System.Drawing.Size(105, 17);
            libelleCompteLabel.TabIndex = 8;
            libelleCompteLabel.Text = "Libelle Compte:";
            // 
            // numeroCompteLabel
            // 
            numeroCompteLabel.AutoSize = true;
            numeroCompteLabel.Location = new System.Drawing.Point(20, 111);
            numeroCompteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroCompteLabel.Name = "numeroCompteLabel";
            numeroCompteLabel.Size = new System.Drawing.Size(114, 17);
            numeroCompteLabel.TabIndex = 4;
            numeroCompteLabel.Text = "Numero Compte:";
            // 
            // codeBanqueLabel
            // 
            codeBanqueLabel.AutoSize = true;
            codeBanqueLabel.Location = new System.Drawing.Point(20, 42);
            codeBanqueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codeBanqueLabel.Name = "codeBanqueLabel";
            codeBanqueLabel.Size = new System.Drawing.Size(98, 17);
            codeBanqueLabel.TabIndex = 0;
            codeBanqueLabel.Text = "Code Banque:";
            // 
            // erpCompte
            // 
            this.erpCompte.ContainerControl = this;
            this.erpCompte.DataSource = this.compteExterneBindingSource;
            // 
            // BtnValider
            // 
            this.BtnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnValider.Location = new System.Drawing.Point(16, 220);
            this.BtnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(125, 28);
            this.BtnValider.TabIndex = 10;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnAbandonner
            // 
            this.BtnAbandonner.CausesValidation = false;
            this.BtnAbandonner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAbandonner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAbandonner.Location = new System.Drawing.Point(175, 220);
            this.BtnAbandonner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAbandonner.Name = "BtnAbandonner";
            this.BtnAbandonner.Size = new System.Drawing.Size(121, 28);
            this.BtnAbandonner.TabIndex = 11;
            this.BtnAbandonner.Text = "Abandonner";
            this.BtnAbandonner.UseVisualStyleBackColor = true;
            // 
            // gbCompteExterne
            // 
            this.gbCompteExterne.Controls.Add(codeBanqueLabel);
            this.gbCompteExterne.Controls.Add(this.codeBanqueTextBox);
            this.gbCompteExterne.Controls.Add(this.BtnAbandonner);
            this.gbCompteExterne.Controls.Add(this.BtnValider);
            this.gbCompteExterne.Controls.Add(this.codeGuichetTextBox);
            this.gbCompteExterne.Controls.Add(codeGuichetLabel);
            this.gbCompteExterne.Controls.Add(this.numeroCompteTextBox);
            this.gbCompteExterne.Controls.Add(numeroCompteLabel);
            this.gbCompteExterne.Controls.Add(this.cleRIBTextBox);
            this.gbCompteExterne.Controls.Add(cleRIBLabel);
            this.gbCompteExterne.Controls.Add(this.libelleCompteTextBox);
            this.gbCompteExterne.Controls.Add(libelleCompteLabel);
            this.gbCompteExterne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCompteExterne.Location = new System.Drawing.Point(16, 59);
            this.gbCompteExterne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCompteExterne.Name = "gbCompteExterne";
            this.gbCompteExterne.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCompteExterne.Size = new System.Drawing.Size(524, 288);
            this.gbCompteExterne.TabIndex = 0;
            this.gbCompteExterne.TabStop = false;
            this.gbCompteExterne.Text = "Références du compte Externe à ajouter";
            // 
            // codeBanqueTextBox
            // 
            this.codeBanqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteExterneBindingSource, "CodeBanque", true));
            this.codeBanqueTextBox.Location = new System.Drawing.Point(143, 38);
            this.codeBanqueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeBanqueTextBox.Name = "codeBanqueTextBox";
            this.codeBanqueTextBox.Size = new System.Drawing.Size(132, 22);
            this.codeBanqueTextBox.TabIndex = 1;
            // 
            // codeGuichetTextBox
            // 
            this.codeGuichetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteExterneBindingSource, "CodeGuichet", true));
            this.codeGuichetTextBox.Location = new System.Drawing.Point(143, 73);
            this.codeGuichetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeGuichetTextBox.Name = "codeGuichetTextBox";
            this.codeGuichetTextBox.Size = new System.Drawing.Size(132, 22);
            this.codeGuichetTextBox.TabIndex = 3;
            // 
            // numeroCompteTextBox
            // 
            this.numeroCompteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteExterneBindingSource, "NumeroCompte", true));
            this.numeroCompteTextBox.Location = new System.Drawing.Point(143, 107);
            this.numeroCompteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroCompteTextBox.Name = "numeroCompteTextBox";
            this.numeroCompteTextBox.Size = new System.Drawing.Size(208, 22);
            this.numeroCompteTextBox.TabIndex = 5;
            // 
            // cleRIBTextBox
            // 
            this.cleRIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteExterneBindingSource, "CleRIB", true));
            this.cleRIBTextBox.Location = new System.Drawing.Point(143, 139);
            this.cleRIBTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cleRIBTextBox.Name = "cleRIBTextBox";
            this.cleRIBTextBox.Size = new System.Drawing.Size(132, 22);
            this.cleRIBTextBox.TabIndex = 7;
            // 
            // libelleCompteTextBox
            // 
            this.libelleCompteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteExterneBindingSource, "LibelleCompte", true));
            this.libelleCompteTextBox.Location = new System.Drawing.Point(143, 171);
            this.libelleCompteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.libelleCompteTextBox.Name = "libelleCompteTextBox";
            this.libelleCompteTextBox.Size = new System.Drawing.Size(283, 22);
            this.libelleCompteTextBox.TabIndex = 9;
            // 
            // compteExterneBindingSource
            // 
            this.compteExterneBindingSource.DataSource = typeof(Banque.BOL.CompteExterne);
            // 
            // FrmNouveauCompte
            // 
            this.AcceptButton = this.BtnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnAbandonner;
            this.ClientSize = new System.Drawing.Size(575, 427);
            this.ControlBox = false;
            this.Controls.Add(this.gbCompteExterne);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNouveauCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un nouveau compte de bénéficiaire ";
            ((System.ComponentModel.ISupportInitialize)(this.erpCompte)).EndInit();
            this.gbCompteExterne.ResumeLayout(false);
            this.gbCompteExterne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compteExterneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erpCompte;
       
        private System.Windows.Forms.GroupBox gbCompteExterne;
        private System.Windows.Forms.Button BtnAbandonner;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.TextBox codeBanqueTextBox;
        private System.Windows.Forms.BindingSource compteExterneBindingSource;
        private System.Windows.Forms.TextBox codeGuichetTextBox;
        private System.Windows.Forms.TextBox numeroCompteTextBox;
        private System.Windows.Forms.TextBox cleRIBTextBox;
        private System.Windows.Forms.TextBox libelleCompteTextBox;
    }
}