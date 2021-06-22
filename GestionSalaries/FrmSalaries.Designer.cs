
namespace GestionSalaraies
{
    partial class FrmSalaries
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrénom = new System.Windows.Forms.TextBox();
            this.txtSalaireBrut = new System.Windows.Forms.TextBox();
            this.txtTauxCs = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cbSalaries = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nouveauSalarie = new System.Windows.Forms.Button();
            this.supprimerSalarie = new System.Windows.Forms.Button();
            this.modifierSalarie = new System.Windows.Forms.Button();
            this.valdierSalarie = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.chkCommercial = new System.Windows.Forms.CheckBox();
            this.gpCommercial = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtChiffre = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSalarie = new System.Windows.Forms.GroupBox();
            this.gpCommercial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbSalarie.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salaire Brut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Taux CS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Naissance";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Location = new System.Drawing.Point(108, 23);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(100, 20);
            this.txtMatricule.TabIndex = 6;
            this.txtMatricule.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatricule_Validating);
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(108, 50);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrénom
            // 
            this.txtPrénom.Enabled = false;
            this.txtPrénom.Location = new System.Drawing.Point(108, 77);
            this.txtPrénom.Name = "txtPrénom";
            this.txtPrénom.Size = new System.Drawing.Size(100, 20);
            this.txtPrénom.TabIndex = 8;
            // 
            // txtSalaireBrut
            // 
            this.txtSalaireBrut.Enabled = false;
            this.txtSalaireBrut.Location = new System.Drawing.Point(108, 104);
            this.txtSalaireBrut.Name = "txtSalaireBrut";
            this.txtSalaireBrut.Size = new System.Drawing.Size(100, 20);
            this.txtSalaireBrut.TabIndex = 9;
            // 
            // txtTauxCs
            // 
            this.txtTauxCs.Enabled = false;
            this.txtTauxCs.Location = new System.Drawing.Point(108, 131);
            this.txtTauxCs.Name = "txtTauxCs";
            this.txtTauxCs.Size = new System.Drawing.Size(100, 20);
            this.txtTauxCs.TabIndex = 10;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(108, 158);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 11;
            // 
            // cbSalaries
            // 
            this.cbSalaries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalaries.FormattingEnabled = true;
            this.cbSalaries.Location = new System.Drawing.Point(224, 28);
            this.cbSalaries.Name = "cbSalaries";
            this.cbSalaries.Size = new System.Drawing.Size(121, 21);
            this.cbSalaries.TabIndex = 12;
            this.cbSalaries.SelectedIndexChanged += new System.EventHandler(this.cbSalaries_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // nouveauSalarie
            // 
            this.nouveauSalarie.Location = new System.Drawing.Point(373, 25);
            this.nouveauSalarie.Name = "nouveauSalarie";
            this.nouveauSalarie.Size = new System.Drawing.Size(75, 23);
            this.nouveauSalarie.TabIndex = 14;
            this.nouveauSalarie.Text = "Nouveau";
            this.nouveauSalarie.UseVisualStyleBackColor = true;
            // 
            // supprimerSalarie
            // 
            this.supprimerSalarie.Location = new System.Drawing.Point(455, 24);
            this.supprimerSalarie.Name = "supprimerSalarie";
            this.supprimerSalarie.Size = new System.Drawing.Size(75, 23);
            this.supprimerSalarie.TabIndex = 15;
            this.supprimerSalarie.Text = "Supprimer";
            this.supprimerSalarie.UseVisualStyleBackColor = true;
            this.supprimerSalarie.Click += new System.EventHandler(this.supprimerSalarie_Click);
            // 
            // modifierSalarie
            // 
            this.modifierSalarie.Location = new System.Drawing.Point(145, 385);
            this.modifierSalarie.Name = "modifierSalarie";
            this.modifierSalarie.Size = new System.Drawing.Size(75, 23);
            this.modifierSalarie.TabIndex = 16;
            this.modifierSalarie.Text = "Modifier";
            this.modifierSalarie.UseVisualStyleBackColor = true;
            // 
            // valdierSalarie
            // 
            this.valdierSalarie.Location = new System.Drawing.Point(270, 385);
            this.valdierSalarie.Name = "valdierSalarie";
            this.valdierSalarie.Size = new System.Drawing.Size(75, 23);
            this.valdierSalarie.TabIndex = 17;
            this.valdierSalarie.Text = "Valider";
            this.valdierSalarie.UseVisualStyleBackColor = true;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(409, 308);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 18;
            // 
            // chkCommercial
            // 
            this.chkCommercial.AutoSize = true;
            this.chkCommercial.Enabled = false;
            this.chkCommercial.Location = new System.Drawing.Point(409, 243);
            this.chkCommercial.Name = "chkCommercial";
            this.chkCommercial.Size = new System.Drawing.Size(80, 17);
            this.chkCommercial.TabIndex = 20;
            this.chkCommercial.Text = "Commercial";
            this.chkCommercial.UseVisualStyleBackColor = true;
            // 
            // gpCommercial
            // 
            this.gpCommercial.Controls.Add(this.label8);
            this.gpCommercial.Controls.Add(this.label7);
            this.gpCommercial.Controls.Add(this.txtCommission);
            this.gpCommercial.Controls.Add(this.txtChiffre);
            this.gpCommercial.Location = new System.Drawing.Point(145, 260);
            this.gpCommercial.Name = "gpCommercial";
            this.gpCommercial.Size = new System.Drawing.Size(217, 100);
            this.gpCommercial.TabIndex = 21;
            this.gpCommercial.TabStop = false;
            this.gpCommercial.Text = "Commercial";
            this.gpCommercial.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Commission";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Chiffre d\'affaire";
            // 
            // txtCommission
            // 
            this.txtCommission.Enabled = false;
            this.txtCommission.Location = new System.Drawing.Point(108, 68);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(100, 20);
            this.txtCommission.TabIndex = 1;
            // 
            // txtChiffre
            // 
            this.txtChiffre.Enabled = false;
            this.txtChiffre.Location = new System.Drawing.Point(108, 22);
            this.txtChiffre.Name = "txtChiffre";
            this.txtChiffre.Size = new System.Drawing.Size(100, 20);
            this.txtChiffre.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbSalarie
            // 
            this.gbSalarie.Controls.Add(this.label1);
            this.gbSalarie.Controls.Add(this.label2);
            this.gbSalarie.Controls.Add(this.label3);
            this.gbSalarie.Controls.Add(this.label4);
            this.gbSalarie.Controls.Add(this.label5);
            this.gbSalarie.Controls.Add(this.label6);
            this.gbSalarie.Controls.Add(this.txtMatricule);
            this.gbSalarie.Controls.Add(this.txtNom);
            this.gbSalarie.Controls.Add(this.txtPrénom);
            this.gbSalarie.Controls.Add(this.txtSalaireBrut);
            this.gbSalarie.Controls.Add(this.txtDate);
            this.gbSalarie.Controls.Add(this.txtTauxCs);
            this.gbSalarie.Location = new System.Drawing.Point(145, 62);
            this.gbSalarie.Name = "gbSalarie";
            this.gbSalarie.Size = new System.Drawing.Size(217, 192);
            this.gbSalarie.TabIndex = 22;
            this.gbSalarie.TabStop = false;
            this.gbSalarie.Text = "Salarié";
            // 
            // FrmSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSalarie);
            this.Controls.Add(this.gpCommercial);
            this.Controls.Add(this.chkCommercial);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.valdierSalarie);
            this.Controls.Add(this.modifierSalarie);
            this.Controls.Add(this.supprimerSalarie);
            this.Controls.Add(this.nouveauSalarie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbSalaries);
            this.Name = "FrmSalaries";
            this.Text = "Gestion Salaries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSalaries_FormClosing);
            this.Load += new System.EventHandler(this.FrmSalaries_Load);
            this.gpCommercial.ResumeLayout(false);
            this.gpCommercial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbSalarie.ResumeLayout(false);
            this.gbSalarie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrénom;
        private System.Windows.Forms.TextBox txtSalaireBrut;
        private System.Windows.Forms.TextBox txtTauxCs;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cbSalaries;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nouveauSalarie;
        private System.Windows.Forms.Button supprimerSalarie;
        private System.Windows.Forms.Button modifierSalarie;
        private System.Windows.Forms.Button valdierSalarie;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.CheckBox chkCommercial;
        private System.Windows.Forms.GroupBox gpCommercial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtChiffre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbSalarie;
    }
}