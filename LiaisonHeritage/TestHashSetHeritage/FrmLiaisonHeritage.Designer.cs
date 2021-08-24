namespace TestHashSetHeritage
{
    partial class FrmLiaisonHeritage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label salaireLabel;
            System.Windows.Forms.Label nomLabel1;
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personneComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.LblTypeSalarie = new System.Windows.Forms.Label();
            this.beneficiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salarieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaireTextBox = new System.Windows.Forms.TextBox();
            this.gbPersonne = new System.Windows.Forms.GroupBox();
            this.gbSalarie = new System.Windows.Forms.GroupBox();
            this.gbBeneficiaire = new System.Windows.Forms.GroupBox();
            this.nomTextBox1 = new System.Windows.Forms.TextBox();
            codeLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            salaireLabel = new System.Windows.Forms.Label();
            nomLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiaireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).BeginInit();
            this.gbPersonne.SuspendLayout();
            this.gbSalarie.SuspendLayout();
            this.gbBeneficiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(16, 26);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 2;
            codeLabel.Text = "Code:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(16, 52);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 4;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(16, 78);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 6;
            prenomLabel.Text = "Prenom:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(21, 31);
            dateNaissanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(86, 13);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // salaireLabel
            // 
            salaireLabel.AutoSize = true;
            salaireLabel.Location = new System.Drawing.Point(23, 25);
            salaireLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            salaireLabel.Name = "salaireLabel";
            salaireLabel.Size = new System.Drawing.Size(42, 13);
            salaireLabel.TabIndex = 11;
            salaireLabel.Text = "Salaire:";
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataSource = typeof(TestHashSetHeritage.Personne);
            this.personneBindingSource.CurrentChanged += new System.EventHandler(this.personneBindingSource_CurrentChanged);
            // 
            // personneComboBox
            // 
            this.personneComboBox.DataSource = this.personneBindingSource;
            this.personneComboBox.DisplayMember = "Nom";
            this.personneComboBox.FormattingEnabled = true;
            this.personneComboBox.Location = new System.Drawing.Point(26, 90);
            this.personneComboBox.Name = "personneComboBox";
            this.personneComboBox.Size = new System.Drawing.Size(300, 21);
            this.personneComboBox.TabIndex = 1;
            this.personneComboBox.ValueMember = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des personnes";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personneBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(68, 23);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 3;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personneBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(68, 49);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 5;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personneBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(68, 75);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 7;
            // 
            // LblTypeSalarie
            // 
            this.LblTypeSalarie.AutoSize = true;
            this.LblTypeSalarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeSalarie.ForeColor = System.Drawing.Color.Red;
            this.LblTypeSalarie.Location = new System.Drawing.Point(15, 102);
            this.LblTypeSalarie.Name = "LblTypeSalarie";
            this.LblTypeSalarie.Size = new System.Drawing.Size(51, 20);
            this.LblTypeSalarie.TabIndex = 8;
            this.LblTypeSalarie.Text = "label2";
            // 
            // beneficiaireBindingSource
            // 
            this.beneficiaireBindingSource.DataSource = typeof(TestHashSetHeritage.Beneficiaire);
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.beneficiaireBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(109, 28);
            this.dateNaissanceDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.dateNaissanceDateTimePicker.TabIndex = 10;
            // 
            // salarieBindingSource
            // 
            this.salarieBindingSource.DataSource = typeof(TestHashSetHeritage.Salarie);
            // 
            // salaireTextBox
            // 
            this.salaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Salaire", true));
            this.salaireTextBox.Location = new System.Drawing.Point(68, 23);
            this.salaireTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salaireTextBox.Name = "salaireTextBox";
            this.salaireTextBox.Size = new System.Drawing.Size(68, 20);
            this.salaireTextBox.TabIndex = 12;
            // 
            // gbPersonne
            // 
            this.gbPersonne.Controls.Add(this.nomTextBox);
            this.gbPersonne.Controls.Add(this.prenomTextBox);
            this.gbPersonne.Controls.Add(prenomLabel);
            this.gbPersonne.Controls.Add(nomLabel);
            this.gbPersonne.Controls.Add(this.codeTextBox);
            this.gbPersonne.Controls.Add(this.LblTypeSalarie);
            this.gbPersonne.Controls.Add(codeLabel);
            this.gbPersonne.Location = new System.Drawing.Point(269, 130);
            this.gbPersonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPersonne.Name = "gbPersonne";
            this.gbPersonne.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPersonne.Size = new System.Drawing.Size(269, 148);
            this.gbPersonne.TabIndex = 13;
            this.gbPersonne.TabStop = false;
            this.gbPersonne.Text = "Propriétés Communes";
            // 
            // gbSalarie
            // 
            this.gbSalarie.Controls.Add(this.salaireTextBox);
            this.gbSalarie.Controls.Add(salaireLabel);
            this.gbSalarie.Location = new System.Drawing.Point(269, 292);
            this.gbSalarie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSalarie.Name = "gbSalarie";
            this.gbSalarie.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSalarie.Size = new System.Drawing.Size(269, 65);
            this.gbSalarie.TabIndex = 14;
            this.gbSalarie.TabStop = false;
            this.gbSalarie.Text = "Propriétés Salarié";
            // 
            // gbBeneficiaire
            // 
            this.gbBeneficiaire.Controls.Add(this.dateNaissanceDateTimePicker);
            this.gbBeneficiaire.Controls.Add(dateNaissanceLabel);
            this.gbBeneficiaire.Location = new System.Drawing.Point(269, 298);
            this.gbBeneficiaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBeneficiaire.Name = "gbBeneficiaire";
            this.gbBeneficiaire.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBeneficiaire.Size = new System.Drawing.Size(269, 65);
            this.gbBeneficiaire.TabIndex = 15;
            this.gbBeneficiaire.TabStop = false;
            this.gbBeneficiaire.Text = "Propriétés Bénéficiaire";
            // 
            // nomLabel1
            // 
            nomLabel1.AutoSize = true;
            nomLabel1.Location = new System.Drawing.Point(334, 402);
            nomLabel1.Name = "nomLabel1";
            nomLabel1.Size = new System.Drawing.Size(32, 13);
            nomLabel1.TabIndex = 16;
            nomLabel1.Text = "Nom:";
            // 
            // nomTextBox1
            // 
            this.nomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personneBindingSource, "Nom", true));
            this.nomTextBox1.Location = new System.Drawing.Point(372, 399);
            this.nomTextBox1.Name = "nomTextBox1";
            this.nomTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox1.TabIndex = 17;
            // 
            // FrmLiaisonHeritage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 456);
            this.Controls.Add(nomLabel1);
            this.Controls.Add(this.nomTextBox1);
            this.Controls.Add(this.gbBeneficiaire);
            this.Controls.Add(this.gbSalarie);
            this.Controls.Add(this.gbPersonne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personneComboBox);
            this.Name = "FrmLiaisonHeritage";
            this.Text = "Liaison avec types & héritage";
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiaireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).EndInit();
            this.gbPersonne.ResumeLayout(false);
            this.gbPersonne.PerformLayout();
            this.gbSalarie.ResumeLayout(false);
            this.gbSalarie.PerformLayout();
            this.gbBeneficiaire.ResumeLayout(false);
            this.gbBeneficiaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox personneComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.Label LblTypeSalarie;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private System.Windows.Forms.BindingSource beneficiaireBindingSource;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.BindingSource salarieBindingSource;
        private System.Windows.Forms.TextBox salaireTextBox;
        private System.Windows.Forms.GroupBox gbPersonne;
        private System.Windows.Forms.GroupBox gbSalarie;
        private System.Windows.Forms.GroupBox gbBeneficiaire;
        private System.Windows.Forms.TextBox nomTextBox1;
    }
}

