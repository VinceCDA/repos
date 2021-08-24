
namespace Bibliotheque.WinUI
{
    partial class FormPret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPret));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchAdherent = new System.Windows.Forms.Button();
            this.txtAdherentPrenom = new System.Windows.Forms.TextBox();
            this.txtAdherentNom = new System.Windows.Forms.TextBox();
            this.txtAdherentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listExemplaire = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchLivre = new System.Windows.Forms.Button();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.searchAdherent);
            this.groupBox1.Controls.Add(this.txtAdherentPrenom);
            this.groupBox1.Controls.Add(this.txtAdherentNom);
            this.groupBox1.Controls.Add(this.txtAdherentId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // searchAdherent
            // 
            resources.ApplyResources(this.searchAdherent, "searchAdherent");
            this.searchAdherent.Name = "searchAdherent";
            this.searchAdherent.UseVisualStyleBackColor = true;
            this.searchAdherent.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdherentPrenom
            // 
            resources.ApplyResources(this.txtAdherentPrenom, "txtAdherentPrenom");
            this.txtAdherentPrenom.Name = "txtAdherentPrenom";
            // 
            // txtAdherentNom
            // 
            resources.ApplyResources(this.txtAdherentNom, "txtAdherentNom");
            this.txtAdherentNom.Name = "txtAdherentNom";
            // 
            // txtAdherentId
            // 
            resources.ApplyResources(this.txtAdherentId, "txtAdherentId");
            this.txtAdherentId.Name = "txtAdherentId";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.listExemplaire);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.searchLivre);
            this.groupBox2.Controls.Add(this.txtTitre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIsbn);
            this.groupBox2.Controls.Add(this.labelISBN);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // listExemplaire
            // 
            resources.ApplyResources(this.listExemplaire, "listExemplaire");
            this.listExemplaire.FormattingEnabled = true;
            this.listExemplaire.Name = "listExemplaire";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // searchLivre
            // 
            resources.ApplyResources(this.searchLivre, "searchLivre");
            this.searchLivre.Name = "searchLivre";
            this.searchLivre.UseVisualStyleBackColor = true;
            this.searchLivre.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTitre
            // 
            resources.ApplyResources(this.txtTitre, "txtTitre");
            this.txtTitre.Name = "txtTitre";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtIsbn
            // 
            resources.ApplyResources(this.txtIsbn, "txtIsbn");
            this.txtIsbn.Name = "txtIsbn";
            // 
            // labelISBN
            // 
            resources.ApplyResources(this.labelISBN, "labelISBN");
            this.labelISBN.Name = "labelISBN";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormPret
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPret";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdherentPrenom;
        private System.Windows.Forms.TextBox txtAdherentNom;
        private System.Windows.Forms.TextBox txtAdherentId;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Button searchAdherent;
        private System.Windows.Forms.Button searchLivre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listExemplaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}