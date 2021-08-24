namespace Banque.WindowsGUI
{
    partial class FrmVirement
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
            System.Windows.Forms.Label codeClientLabel;
            System.Windows.Forms.Label nomClientLabel;
            System.Windows.Forms.Label prénomClientLabel;
            System.Windows.Forms.Label dateDerniereConnexionLabel;
            System.Windows.Forms.Label soldeLabel;
            System.Windows.Forms.Label coutVirementLabel;
            System.Windows.Forms.Label datePrelevementLabel;
            System.Windows.Forms.Label motifVirementLabel;
            System.Windows.Forms.Label nomBeneficiaireLabel;
            System.Windows.Forms.Label libelleCompteLabel2;
            System.Windows.Forms.Label libelleCompteLabel;
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.gbAdressePostale = new System.Windows.Forms.GroupBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.adresse2TextBox = new System.Windows.Forms.TextBox();
            this.adresse1TextBox = new System.Windows.Forms.TextBox();
            this.dateDerniereConnexionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.prénomClientTextBox = new System.Windows.Forms.TextBox();
            this.nomClientTextBox = new System.Windows.Forms.TextBox();
            this.codeClientTextBox = new System.Windows.Forms.TextBox();
            this.gbNouveauVirement = new System.Windows.Forms.GroupBox();
            this.soldeTextBox = new System.Windows.Forms.TextBox();
            this.comptesEmetteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comptesExternesComboBox = new System.Windows.Forms.ComboBox();
            this.comptesDestinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comptesComboBox = new System.Windows.Forms.ComboBox();
            this.BtnCreerCompte = new System.Windows.Forms.Button();
            this.gbCaracteristiques = new System.Windows.Forms.GroupBox();
            this.coutVirementTextBox = new System.Windows.Forms.TextBox();
            this.lblDateInterval = new System.Windows.Forms.Label();
            this.libelleCompteLabel1 = new System.Windows.Forms.Label();
            this.libelleCompteLabel3 = new System.Windows.Forms.Label();
            this.nomBeneficiaireTextBox = new System.Windows.Forms.TextBox();
            this.virementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motifVirementTextBox = new System.Windows.Forms.TextBox();
            this.datePrelevementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAnnulerVirement = new System.Windows.Forms.Button();
            this.btnValiderVirement = new System.Windows.Forms.Button();
            this.comptesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            codeClientLabel = new System.Windows.Forms.Label();
            nomClientLabel = new System.Windows.Forms.Label();
            prénomClientLabel = new System.Windows.Forms.Label();
            dateDerniereConnexionLabel = new System.Windows.Forms.Label();
            soldeLabel = new System.Windows.Forms.Label();
            coutVirementLabel = new System.Windows.Forms.Label();
            datePrelevementLabel = new System.Windows.Forms.Label();
            motifVirementLabel = new System.Windows.Forms.Label();
            nomBeneficiaireLabel = new System.Windows.Forms.Label();
            libelleCompteLabel2 = new System.Windows.Forms.Label();
            libelleCompteLabel = new System.Windows.Forms.Label();
            this.gbClient.SuspendLayout();
            this.gbAdressePostale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.gbNouveauVirement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comptesEmetteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesDestinationBindingSource)).BeginInit();
            this.gbCaracteristiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.virementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeClientLabel
            // 
            codeClientLabel.AutoSize = true;
            codeClientLabel.Location = new System.Drawing.Point(24, 28);
            codeClientLabel.Name = "codeClientLabel";
            codeClientLabel.Size = new System.Drawing.Size(64, 13);
            codeClientLabel.TabIndex = 0;
            codeClientLabel.Text = "Code Client:";
            // 
            // nomClientLabel
            // 
            nomClientLabel.AutoSize = true;
            nomClientLabel.Location = new System.Drawing.Point(24, 54);
            nomClientLabel.Name = "nomClientLabel";
            nomClientLabel.Size = new System.Drawing.Size(61, 13);
            nomClientLabel.TabIndex = 2;
            nomClientLabel.Text = "Nom Client:";
            // 
            // prénomClientLabel
            // 
            prénomClientLabel.AutoSize = true;
            prénomClientLabel.Location = new System.Drawing.Point(24, 80);
            prénomClientLabel.Name = "prénomClientLabel";
            prénomClientLabel.Size = new System.Drawing.Size(75, 13);
            prénomClientLabel.TabIndex = 4;
            prénomClientLabel.Text = "Prénom Client:";
            // 
            // dateDerniereConnexionLabel
            // 
            dateDerniereConnexionLabel.AutoSize = true;
            dateDerniereConnexionLabel.Location = new System.Drawing.Point(25, 109);
            dateDerniereConnexionLabel.Name = "dateDerniereConnexionLabel";
            dateDerniereConnexionLabel.Size = new System.Drawing.Size(103, 13);
            dateDerniereConnexionLabel.TabIndex = 6;
            dateDerniereConnexionLabel.Text = "Dernière Connexion:";
            // 
            // soldeLabel
            // 
            soldeLabel.AutoSize = true;
            soldeLabel.Location = new System.Drawing.Point(367, 36);
            soldeLabel.Name = "soldeLabel";
            soldeLabel.Size = new System.Drawing.Size(48, 17);
            soldeLabel.TabIndex = 11;
            soldeLabel.Text = "Solde:";
            // 
            // coutVirementLabel
            // 
            coutVirementLabel.AutoSize = true;
            coutVirementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coutVirementLabel.Location = new System.Drawing.Point(26, 112);
            coutVirementLabel.Name = "coutVirementLabel";
            coutVirementLabel.Size = new System.Drawing.Size(90, 13);
            coutVirementLabel.TabIndex = 16;
            coutVirementLabel.Text = "Cout Virement:";
            // 
            // datePrelevementLabel
            // 
            datePrelevementLabel.AutoSize = true;
            datePrelevementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datePrelevementLabel.Location = new System.Drawing.Point(26, 153);
            datePrelevementLabel.Name = "datePrelevementLabel";
            datePrelevementLabel.Size = new System.Drawing.Size(112, 13);
            datePrelevementLabel.TabIndex = 17;
            datePrelevementLabel.Text = "Date Prelevement:";
            // 
            // motifVirementLabel
            // 
            motifVirementLabel.AutoSize = true;
            motifVirementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            motifVirementLabel.Location = new System.Drawing.Point(26, 186);
            motifVirementLabel.Name = "motifVirementLabel";
            motifVirementLabel.Size = new System.Drawing.Size(92, 13);
            motifVirementLabel.TabIndex = 18;
            motifVirementLabel.Text = "Motif Virement:";
            // 
            // nomBeneficiaireLabel
            // 
            nomBeneficiaireLabel.AutoSize = true;
            nomBeneficiaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomBeneficiaireLabel.Location = new System.Drawing.Point(26, 225);
            nomBeneficiaireLabel.Name = "nomBeneficiaireLabel";
            nomBeneficiaireLabel.Size = new System.Drawing.Size(107, 13);
            nomBeneficiaireLabel.TabIndex = 19;
            nomBeneficiaireLabel.Text = "Nom Beneficiaire:";
            // 
            // libelleCompteLabel2
            // 
            libelleCompteLabel2.AutoSize = true;
            libelleCompteLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            libelleCompteLabel2.Location = new System.Drawing.Point(26, 37);
            libelleCompteLabel2.Name = "libelleCompteLabel2";
            libelleCompteLabel2.Size = new System.Drawing.Size(65, 13);
            libelleCompteLabel2.TabIndex = 20;
            libelleCompteLabel2.Text = "Emetteur :";
            // 
            // libelleCompteLabel
            // 
            libelleCompteLabel.AutoSize = true;
            libelleCompteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            libelleCompteLabel.Location = new System.Drawing.Point(26, 72);
            libelleCompteLabel.Name = "libelleCompteLabel";
            libelleCompteLabel.Size = new System.Drawing.Size(83, 13);
            libelleCompteLabel.TabIndex = 21;
            libelleCompteLabel.Text = "Destinataire :";
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.gbAdressePostale);
            this.gbClient.Controls.Add(dateDerniereConnexionLabel);
            this.gbClient.Controls.Add(this.dateDerniereConnexionDateTimePicker);
            this.gbClient.Controls.Add(prénomClientLabel);
            this.gbClient.Controls.Add(this.prénomClientTextBox);
            this.gbClient.Controls.Add(nomClientLabel);
            this.gbClient.Controls.Add(this.nomClientTextBox);
            this.gbClient.Controls.Add(codeClientLabel);
            this.gbClient.Controls.Add(this.codeClientTextBox);
            this.gbClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbClient.Location = new System.Drawing.Point(12, 12);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(669, 155);
            this.gbClient.TabIndex = 0;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Vos Coordonnées";
            // 
            // gbAdressePostale
            // 
            this.gbAdressePostale.Controls.Add(this.villeTextBox);
            this.gbAdressePostale.Controls.Add(this.codePostalTextBox);
            this.gbAdressePostale.Controls.Add(this.adresse2TextBox);
            this.gbAdressePostale.Controls.Add(this.adresse1TextBox);
            this.gbAdressePostale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdressePostale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbAdressePostale.Location = new System.Drawing.Point(354, 11);
            this.gbAdressePostale.Name = "gbAdressePostale";
            this.gbAdressePostale.Size = new System.Drawing.Size(289, 130);
            this.gbAdressePostale.TabIndex = 8;
            this.gbAdressePostale.TabStop = false;
            this.gbAdressePostale.Text = "Votre adresse";
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(83, 87);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.ReadOnly = true;
            this.villeTextBox.Size = new System.Drawing.Size(180, 21);
            this.villeTextBox.TabIndex = 6;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(6, 87);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.ReadOnly = true;
            this.codePostalTextBox.Size = new System.Drawing.Size(68, 21);
            this.codePostalTextBox.TabIndex = 5;
            // 
            // adresse2TextBox
            // 
            this.adresse2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Adresse2", true));
            this.adresse2TextBox.Location = new System.Drawing.Point(6, 59);
            this.adresse2TextBox.Name = "adresse2TextBox";
            this.adresse2TextBox.ReadOnly = true;
            this.adresse2TextBox.Size = new System.Drawing.Size(257, 21);
            this.adresse2TextBox.TabIndex = 3;
            // 
            // adresse1TextBox
            // 
            this.adresse1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Adresse1", true));
            this.adresse1TextBox.Location = new System.Drawing.Point(6, 32);
            this.adresse1TextBox.Name = "adresse1TextBox";
            this.adresse1TextBox.ReadOnly = true;
            this.adresse1TextBox.Size = new System.Drawing.Size(257, 21);
            this.adresse1TextBox.TabIndex = 1;
            // 
            // dateDerniereConnexionDateTimePicker
            // 
            this.dateDerniereConnexionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "DateDerniereConnexion", true));
            this.dateDerniereConnexionDateTimePicker.Enabled = false;
            this.dateDerniereConnexionDateTimePicker.Location = new System.Drawing.Point(134, 103);
            this.dateDerniereConnexionDateTimePicker.Name = "dateDerniereConnexionDateTimePicker";
            this.dateDerniereConnexionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDerniereConnexionDateTimePicker.TabIndex = 7;
            // 
            // prénomClientTextBox
            // 
            this.prénomClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PrénomClient", true));
            this.prénomClientTextBox.Location = new System.Drawing.Point(134, 77);
            this.prénomClientTextBox.Name = "prénomClientTextBox";
            this.prénomClientTextBox.ReadOnly = true;
            this.prénomClientTextBox.Size = new System.Drawing.Size(151, 20);
            this.prénomClientTextBox.TabIndex = 5;
            // 
            // nomClientTextBox
            // 
            this.nomClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NomClient", true));
            this.nomClientTextBox.Location = new System.Drawing.Point(134, 51);
            this.nomClientTextBox.Name = "nomClientTextBox";
            this.nomClientTextBox.ReadOnly = true;
            this.nomClientTextBox.Size = new System.Drawing.Size(151, 20);
            this.nomClientTextBox.TabIndex = 3;
            // 
            // codeClientTextBox
            // 
            this.codeClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CodeClient", true));
            this.codeClientTextBox.Location = new System.Drawing.Point(134, 25);
            this.codeClientTextBox.Name = "codeClientTextBox";
            this.codeClientTextBox.ReadOnly = true;
            this.codeClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeClientTextBox.TabIndex = 1;
            // 
            // gbNouveauVirement
            // 
            this.gbNouveauVirement.Controls.Add(this.label2);
            this.gbNouveauVirement.Controls.Add(this.label1);
            this.gbNouveauVirement.Controls.Add(soldeLabel);
            this.gbNouveauVirement.Controls.Add(this.soldeTextBox);
            this.gbNouveauVirement.Controls.Add(this.comptesExternesComboBox);
            this.gbNouveauVirement.Controls.Add(this.comptesComboBox);
            this.gbNouveauVirement.Controls.Add(this.BtnCreerCompte);
            this.gbNouveauVirement.Controls.Add(this.gbCaracteristiques);
            this.gbNouveauVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNouveauVirement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbNouveauVirement.Location = new System.Drawing.Point(12, 183);
            this.gbNouveauVirement.Name = "gbNouveauVirement";
            this.gbNouveauVirement.Size = new System.Drawing.Size(778, 449);
            this.gbNouveauVirement.TabIndex = 1;
            this.gbNouveauVirement.TabStop = false;
            this.gbNouveauVirement.Text = "Pour effectuer un nouveau virement";
            // 
            // soldeTextBox
            // 
            this.soldeTextBox.BackColor = System.Drawing.Color.OrangeRed;
            this.soldeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comptesEmetteurBindingSource, "Solde", true));
            this.soldeTextBox.Enabled = false;
            this.soldeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldeTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.soldeTextBox.Location = new System.Drawing.Point(421, 33);
            this.soldeTextBox.Name = "soldeTextBox";
            this.soldeTextBox.Size = new System.Drawing.Size(100, 23);
            this.soldeTextBox.TabIndex = 12;
            // 
            // comptesEmetteurBindingSource
            // 
            this.comptesEmetteurBindingSource.DataSource = typeof(Banque.BOL.Compte);
            // 
            // comptesExternesComboBox
            // 
            this.comptesExternesComboBox.DataSource = this.comptesDestinationBindingSource;
            this.comptesExternesComboBox.DisplayMember = "LibelleCompte";
            this.comptesExternesComboBox.FormattingEnabled = true;
            this.comptesExternesComboBox.Location = new System.Drawing.Point(18, 98);
            this.comptesExternesComboBox.Name = "comptesExternesComboBox";
            this.comptesExternesComboBox.Size = new System.Drawing.Size(300, 24);
            this.comptesExternesComboBox.TabIndex = 11;
            this.comptesExternesComboBox.ValueMember = "CleRIB";
            // 
            // comptesDestinationBindingSource
            // 
            this.comptesDestinationBindingSource.DataSource = typeof(Banque.BOL.CompteBase);
            // 
            // comptesComboBox
            // 
            this.comptesComboBox.DataSource = this.comptesEmetteurBindingSource;
            this.comptesComboBox.DisplayMember = "LibelleCompte";
            this.comptesComboBox.FormattingEnabled = true;
            this.comptesComboBox.Location = new System.Drawing.Point(18, 39);
            this.comptesComboBox.Name = "comptesComboBox";
            this.comptesComboBox.Size = new System.Drawing.Size(300, 24);
            this.comptesComboBox.TabIndex = 11;
            this.comptesComboBox.ValueMember = "CleRIB";
            // 
            // BtnCreerCompte
            // 
            this.BtnCreerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreerCompte.Location = new System.Drawing.Point(354, 84);
            this.BtnCreerCompte.Name = "BtnCreerCompte";
            this.BtnCreerCompte.Size = new System.Drawing.Size(182, 23);
            this.BtnCreerCompte.TabIndex = 11;
            this.BtnCreerCompte.Text = "Nouveau compte Externe";
            this.BtnCreerCompte.UseVisualStyleBackColor = true;
            this.BtnCreerCompte.Click += new System.EventHandler(this.BtnCreerCompte_Click);
            // 
            // gbCaracteristiques
            // 
            this.gbCaracteristiques.Controls.Add(this.coutVirementTextBox);
            this.gbCaracteristiques.Controls.Add(this.lblDateInterval);
            this.gbCaracteristiques.Controls.Add(libelleCompteLabel);
            this.gbCaracteristiques.Controls.Add(this.libelleCompteLabel1);
            this.gbCaracteristiques.Controls.Add(libelleCompteLabel2);
            this.gbCaracteristiques.Controls.Add(this.libelleCompteLabel3);
            this.gbCaracteristiques.Controls.Add(nomBeneficiaireLabel);
            this.gbCaracteristiques.Controls.Add(this.nomBeneficiaireTextBox);
            this.gbCaracteristiques.Controls.Add(motifVirementLabel);
            this.gbCaracteristiques.Controls.Add(this.motifVirementTextBox);
            this.gbCaracteristiques.Controls.Add(datePrelevementLabel);
            this.gbCaracteristiques.Controls.Add(this.datePrelevementDateTimePicker);
            this.gbCaracteristiques.Controls.Add(coutVirementLabel);
            this.gbCaracteristiques.Controls.Add(this.btnAnnulerVirement);
            this.gbCaracteristiques.Controls.Add(this.btnValiderVirement);
            this.gbCaracteristiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCaracteristiques.Location = new System.Drawing.Point(6, 128);
            this.gbCaracteristiques.Name = "gbCaracteristiques";
            this.gbCaracteristiques.Size = new System.Drawing.Size(772, 318);
            this.gbCaracteristiques.TabIndex = 5;
            this.gbCaracteristiques.TabStop = false;
            this.gbCaracteristiques.Text = "Caractéristiques du virement";
            // 
            // coutVirementTextBox
            // 
            this.coutVirementTextBox.Location = new System.Drawing.Point(142, 109);
            this.coutVirementTextBox.Name = "coutVirementTextBox";
            this.coutVirementTextBox.Size = new System.Drawing.Size(100, 20);
            this.coutVirementTextBox.TabIndex = 24;
            // 
            // lblDateInterval
            // 
            this.lblDateInterval.AutoSize = true;
            this.lblDateInterval.Location = new System.Drawing.Point(363, 153);
            this.lblDateInterval.Name = "lblDateInterval";
            this.lblDateInterval.Size = new System.Drawing.Size(35, 13);
            this.lblDateInterval.TabIndex = 23;
            this.lblDateInterval.Text = "label1";
            // 
            // libelleCompteLabel1
            // 
            this.libelleCompteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comptesDestinationBindingSource, "LibelleCompte", true));
            this.libelleCompteLabel1.Location = new System.Drawing.Point(139, 72);
            this.libelleCompteLabel1.Name = "libelleCompteLabel1";
            this.libelleCompteLabel1.Size = new System.Drawing.Size(203, 23);
            this.libelleCompteLabel1.TabIndex = 22;
            this.libelleCompteLabel1.Text = "label1";
            // 
            // libelleCompteLabel3
            // 
            this.libelleCompteLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comptesEmetteurBindingSource, "LibelleCompte", true));
            this.libelleCompteLabel3.Location = new System.Drawing.Point(139, 37);
            this.libelleCompteLabel3.Name = "libelleCompteLabel3";
            this.libelleCompteLabel3.Size = new System.Drawing.Size(203, 23);
            this.libelleCompteLabel3.TabIndex = 21;
            this.libelleCompteLabel3.Text = "label1";
            // 
            // nomBeneficiaireTextBox
            // 
            this.nomBeneficiaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "NomBeneficiaire", true));
            this.nomBeneficiaireTextBox.Location = new System.Drawing.Point(142, 222);
            this.nomBeneficiaireTextBox.Name = "nomBeneficiaireTextBox";
            this.nomBeneficiaireTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomBeneficiaireTextBox.TabIndex = 20;
            // 
            // virementBindingSource
            // 
            this.virementBindingSource.DataSource = typeof(Banque.BOL.Virement);
            // 
            // motifVirementTextBox
            // 
            this.motifVirementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "MotifVirement", true));
            this.motifVirementTextBox.Location = new System.Drawing.Point(142, 186);
            this.motifVirementTextBox.Name = "motifVirementTextBox";
            this.motifVirementTextBox.Size = new System.Drawing.Size(100, 20);
            this.motifVirementTextBox.TabIndex = 19;
            // 
            // datePrelevementDateTimePicker
            // 
            this.datePrelevementDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.virementBindingSource, "DatePrelevement", true));
            this.datePrelevementDateTimePicker.Location = new System.Drawing.Point(142, 149);
            this.datePrelevementDateTimePicker.Name = "datePrelevementDateTimePicker";
            this.datePrelevementDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datePrelevementDateTimePicker.TabIndex = 18;
            // 
            // btnAnnulerVirement
            // 
            this.btnAnnulerVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerVirement.Location = new System.Drawing.Point(156, 275);
            this.btnAnnulerVirement.Name = "btnAnnulerVirement";
            this.btnAnnulerVirement.Size = new System.Drawing.Size(86, 23);
            this.btnAnnulerVirement.TabIndex = 14;
            this.btnAnnulerVirement.Text = "Annuler";
            this.btnAnnulerVirement.UseVisualStyleBackColor = true;
            this.btnAnnulerVirement.Click += new System.EventHandler(this.btnValiderVirement_Click);
            // 
            // btnValiderVirement
            // 
            this.btnValiderVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderVirement.Location = new System.Drawing.Point(65, 275);
            this.btnValiderVirement.Name = "btnValiderVirement";
            this.btnValiderVirement.Size = new System.Drawing.Size(85, 23);
            this.btnValiderVirement.TabIndex = 14;
            this.btnValiderVirement.Text = "Valider";
            this.btnValiderVirement.UseVisualStyleBackColor = true;
            this.btnValiderVirement.Click += new System.EventHandler(this.btnValiderVirement_Click);
            // 
            // comptesBindingSource
            // 
            this.comptesBindingSource.DataSource = typeof(Banque.BOL.Compte);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sélectionnez un compte émetteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sélectionnez ou créer un compte destinataire";
            // 
            // FrmVirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(823, 698);
            this.Controls.Add(this.gbNouveauVirement);
            this.Controls.Add(this.gbClient);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmVirement";
            this.Text = "Effectuez vos virements";
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbAdressePostale.ResumeLayout(false);
            this.gbAdressePostale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.gbNouveauVirement.ResumeLayout(false);
            this.gbNouveauVirement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comptesEmetteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesDestinationBindingSource)).EndInit();
            this.gbCaracteristiques.ResumeLayout(false);
            this.gbCaracteristiques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.virementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClient;
     
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.GroupBox gbAdressePostale;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox adresse2TextBox;
        private System.Windows.Forms.TextBox adresse1TextBox;
        private System.Windows.Forms.DateTimePicker dateDerniereConnexionDateTimePicker;
        private System.Windows.Forms.TextBox prénomClientTextBox;
        private System.Windows.Forms.TextBox nomClientTextBox;
        private System.Windows.Forms.TextBox codeClientTextBox;
        private System.Windows.Forms.GroupBox gbNouveauVirement;
        private System.Windows.Forms.GroupBox gbCaracteristiques;
        private System.Windows.Forms.Button btnValiderVirement;
        private System.Windows.Forms.Button BtnCreerCompte;
        private System.Windows.Forms.Button btnAnnulerVirement;
        private System.Windows.Forms.ComboBox comptesComboBox;
        private System.Windows.Forms.BindingSource comptesEmetteurBindingSource;
        private System.Windows.Forms.BindingSource comptesBindingSource;
        private System.Windows.Forms.ComboBox comptesExternesComboBox;
        private System.Windows.Forms.BindingSource comptesDestinationBindingSource;
        private System.Windows.Forms.TextBox soldeTextBox;
        private System.Windows.Forms.BindingSource virementBindingSource;
        private System.Windows.Forms.TextBox nomBeneficiaireTextBox;
        private System.Windows.Forms.TextBox motifVirementTextBox;
        private System.Windows.Forms.DateTimePicker datePrelevementDateTimePicker;
        private System.Windows.Forms.Label libelleCompteLabel3;
        private System.Windows.Forms.Label libelleCompteLabel1;
        private System.Windows.Forms.Label lblDateInterval;
        private System.Windows.Forms.TextBox coutVirementTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}