
namespace Bibliotheque.WinUI
{
    partial class TestEnfants
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
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adherentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pretDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            this.adherentBindingSource.CurrentChanged += new System.EventHandler(this.adherentBindingSource_CurrentChanged);
            // 
            // adherentDataGridView
            // 
            this.adherentDataGridView.AutoGenerateColumns = false;
            this.adherentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adherentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.adherentDataGridView.DataSource = this.adherentBindingSource;
            this.adherentDataGridView.Location = new System.Drawing.Point(38, 61);
            this.adherentDataGridView.Name = "adherentDataGridView";
            this.adherentDataGridView.Size = new System.Drawing.Size(300, 220);
            this.adherentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AdherentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AdherentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prets";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prets";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.pretDataGridView.DataSource = this.pretBindingSource;
            this.pretDataGridView.Location = new System.Drawing.Point(398, 64);
            this.pretDataGridView.Name = "pretDataGridView";
            this.pretDataGridView.Size = new System.Drawing.Size(332, 217);
            this.pretDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdExemplaire";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdExemplaire";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateEmprunt";
            this.dataGridViewTextBoxColumn9.HeaderText = "DateEmprunt";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DateRetour";
            this.dataGridViewTextBoxColumn10.HeaderText = "DateRetour";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // TestEnfants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pretDataGridView);
            this.Controls.Add(this.adherentDataGridView);
            this.Name = "TestEnfants";
            this.Text = "TestEnfants";
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.DataGridView adherentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource pretBindingSource;
        private System.Windows.Forms.DataGridView pretDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}