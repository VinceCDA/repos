
namespace Bibliotheque.WinUI
{
    partial class AjoutAdherent
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
            System.Windows.Forms.Label adherentIDLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.adherentComboBox = new System.Windows.Forms.ComboBox();
            this.adherentIDTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            adherentIDLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.AllowNew = true;
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adherentComboBox
            // 
            this.adherentComboBox.DataSource = this.adherentBindingSource;
            this.adherentComboBox.DisplayMember = "Nom";
            this.adherentComboBox.FormattingEnabled = true;
            this.adherentComboBox.Location = new System.Drawing.Point(393, 38);
            this.adherentComboBox.Name = "adherentComboBox";
            this.adherentComboBox.Size = new System.Drawing.Size(300, 21);
            this.adherentComboBox.TabIndex = 7;
            this.adherentComboBox.ValueMember = "AdherentID";
            // 
            // adherentIDLabel
            // 
            adherentIDLabel.AutoSize = true;
            adherentIDLabel.Location = new System.Drawing.Point(233, 109);
            adherentIDLabel.Name = "adherentIDLabel";
            adherentIDLabel.Size = new System.Drawing.Size(67, 13);
            adherentIDLabel.TabIndex = 7;
            adherentIDLabel.Text = "Adherent ID:";
            // 
            // adherentIDTextBox
            // 
            this.adherentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "AdherentID", true));
            this.adherentIDTextBox.Location = new System.Drawing.Point(306, 106);
            this.adherentIDTextBox.Name = "adherentIDTextBox";
            this.adherentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.adherentIDTextBox.TabIndex = 8;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(246, 150);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 8;
            nomLabel.Text = "Nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(284, 147);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 9;
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(252, 197);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 9;
            prenomLabel.Text = "Prenom:";
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(304, 194);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 10;
            // 
            // AjoutAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(adherentIDLabel);
            this.Controls.Add(this.adherentIDTextBox);
            this.Controls.Add(this.adherentComboBox);
            this.Controls.Add(this.button1);
            this.Name = "AjoutAdherent";
            this.Text = "AjoutAdherent";
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox adherentComboBox;
        private System.Windows.Forms.TextBox adherentIDTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
    }
}