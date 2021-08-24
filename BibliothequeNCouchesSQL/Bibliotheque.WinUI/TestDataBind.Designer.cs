
namespace Bibliotheque.WinUI
{
    partial class TestDataBind
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adherentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pretDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adherentComboBox = new System.Windows.Forms.ComboBox();
            this.adherentListBox = new System.Windows.Forms.ListBox();
            this.adherentIDTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            adherentIDLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // adherentIDLabel
            // 
            adherentIDLabel.AutoSize = true;
            adherentIDLabel.Location = new System.Drawing.Point(263, 384);
            adherentIDLabel.Name = "adherentIDLabel";
            adherentIDLabel.Size = new System.Drawing.Size(67, 13);
            adherentIDLabel.TabIndex = 6;
            adherentIDLabel.Text = "Adherent ID:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(274, 432);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 8;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(278, 482);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 10;
            prenomLabel.Text = "Prenom:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adherentIDDataGridViewTextBoxColumn,
            this.Nom,
            this.Prenom});
            this.dataGridView1.DataSource = this.adherentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // adherentIDDataGridViewTextBoxColumn
            // 
            this.adherentIDDataGridViewTextBoxColumn.DataPropertyName = "AdherentID";
            this.adherentIDDataGridViewTextBoxColumn.HeaderText = "AdherentID";
            this.adherentIDDataGridViewTextBoxColumn.Name = "adherentIDDataGridViewTextBoxColumn";
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            this.adherentBindingSource.CurrentChanged += new System.EventHandler(this.adherentBindingSource_CurrentItemChanged);
            // 
            // pretBindingSource
            // 
            this.pretBindingSource.DataSource = typeof(Bibliotheque.BOL.Pret);
            // 
            // pretDataGridView
            // 
            this.pretDataGridView.AutoGenerateColumns = false;
            this.pretDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pretDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pretDataGridView.DataSource = this.pretBindingSource;
            this.pretDataGridView.Location = new System.Drawing.Point(429, 22);
            this.pretDataGridView.Name = "pretDataGridView";
            this.pretDataGridView.Size = new System.Drawing.Size(483, 220);
            this.pretDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AdherentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AdherentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdExemplaire";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdExemplaire";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateEmprunt";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateEmprunt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateRetour";
            this.dataGridViewTextBoxColumn6.HeaderText = "DateRetour";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // adherentComboBox
            // 
            this.adherentComboBox.DataSource = this.adherentBindingSource;
            this.adherentComboBox.DisplayMember = "Nom";
            this.adherentComboBox.FormattingEnabled = true;
            this.adherentComboBox.Location = new System.Drawing.Point(631, 292);
            this.adherentComboBox.Name = "adherentComboBox";
            this.adherentComboBox.Size = new System.Drawing.Size(300, 21);
            this.adherentComboBox.TabIndex = 4;
            this.adherentComboBox.ValueMember = "Prenom";
            // 
            // adherentListBox
            // 
            this.adherentListBox.DataSource = this.adherentBindingSource;
            this.adherentListBox.DisplayMember = "Nom";
            this.adherentListBox.FormattingEnabled = true;
            this.adherentListBox.Location = new System.Drawing.Point(632, 347);
            this.adherentListBox.Name = "adherentListBox";
            this.adherentListBox.Size = new System.Drawing.Size(300, 212);
            this.adherentListBox.TabIndex = 5;
            this.adherentListBox.ValueMember = "AdherentID";
            // 
            // adherentIDTextBox
            // 
            this.adherentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "AdherentID", true));
            this.adherentIDTextBox.Location = new System.Drawing.Point(336, 381);
            this.adherentIDTextBox.Name = "adherentIDTextBox";
            this.adherentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.adherentIDTextBox.TabIndex = 7;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(312, 429);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 9;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(330, 479);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.adherentBindingSource;
            // 
            // TestDataBind
            // 
            this.ClientSize = new System.Drawing.Size(1044, 579);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(adherentIDLabel);
            this.Controls.Add(this.adherentIDTextBox);
            this.Controls.Add(this.adherentListBox);
            this.Controls.Add(this.adherentComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pretDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TestDataBind";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adherentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.BindingSource pretBindingSource;
        private System.Windows.Forms.DataGridView pretDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox adherentComboBox;
        private System.Windows.Forms.ListBox adherentListBox;
        private System.Windows.Forms.TextBox adherentIDTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}