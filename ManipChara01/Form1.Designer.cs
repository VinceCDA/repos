
namespace ManipChara01
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtChain1 = new System.Windows.Forms.TextBox();
            this.txtChain2 = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.choiceBox = new System.Windows.Forms.GroupBox();
            this.swapLastChain1byChain2 = new System.Windows.Forms.RadioButton();
            this.swap1StChain1ByChain2 = new System.Windows.Forms.RadioButton();
            this.swapChain1byChain2 = new System.Windows.Forms.RadioButton();
            this.addChain1 = new System.Windows.Forms.RadioButton();
            this.finalButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.choiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chaine n°1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chaine n°2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Résultat :";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(270, 72);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(165, 23);
            this.txtSource.TabIndex = 4;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // txtChain1
            // 
            this.txtChain1.Location = new System.Drawing.Point(270, 101);
            this.txtChain1.Name = "txtChain1";
            this.txtChain1.Size = new System.Drawing.Size(165, 23);
            this.txtChain1.TabIndex = 5;
            this.txtChain1.TextChanged += new System.EventHandler(this.txtChain1_TextChanged);
            // 
            // txtChain2
            // 
            this.txtChain2.Location = new System.Drawing.Point(270, 130);
            this.txtChain2.Name = "txtChain2";
            this.txtChain2.Size = new System.Drawing.Size(165, 23);
            this.txtChain2.TabIndex = 6;
            this.txtChain2.TextChanged += new System.EventHandler(this.txtChain2_TextChanged);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(270, 159);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(165, 23);
            this.txtOut.TabIndex = 7;
            // 
            // choiceBox
            // 
            this.choiceBox.Controls.Add(this.swapLastChain1byChain2);
            this.choiceBox.Controls.Add(this.swap1StChain1ByChain2);
            this.choiceBox.Controls.Add(this.swapChain1byChain2);
            this.choiceBox.Controls.Add(this.addChain1);
            this.choiceBox.Location = new System.Drawing.Point(150, 207);
            this.choiceBox.Name = "choiceBox";
            this.choiceBox.Size = new System.Drawing.Size(285, 141);
            this.choiceBox.TabIndex = 8;
            this.choiceBox.TabStop = false;
            this.choiceBox.Text = "Choix";
            // 
            // swapLastChain1byChain2
            // 
            this.swapLastChain1byChain2.AutoSize = true;
            this.swapLastChain1byChain2.Location = new System.Drawing.Point(7, 101);
            this.swapLastChain1byChain2.Name = "swapLastChain1byChain2";
            this.swapLastChain1byChain2.Size = new System.Drawing.Size(217, 19);
            this.swapLastChain1byChain2.TabIndex = 3;
            this.swapLastChain1byChain2.TabStop = true;
            this.swapLastChain1byChain2.Text = "Remplacer la dernière de n°1 par n°2";
            this.swapLastChain1byChain2.UseVisualStyleBackColor = true;
            // 
            // swap1StChain1ByChain2
            // 
            this.swap1StChain1ByChain2.AutoSize = true;
            this.swap1StChain1ByChain2.Location = new System.Drawing.Point(7, 75);
            this.swap1StChain1ByChain2.Name = "swap1StChain1ByChain2";
            this.swap1StChain1ByChain2.Size = new System.Drawing.Size(254, 19);
            this.swap1StChain1ByChain2.TabIndex = 2;
            this.swap1StChain1ByChain2.TabStop = true;
            this.swap1StChain1ByChain2.Text = "Remplacer la 1ère occurence de n°1 par n°2";
            this.swap1StChain1ByChain2.UseVisualStyleBackColor = true;
            // 
            // swapChain1byChain2
            // 
            this.swapChain1byChain2.AutoSize = true;
            this.swapChain1byChain2.Location = new System.Drawing.Point(7, 49);
            this.swapChain1byChain2.Name = "swapChain1byChain2";
            this.swapChain1byChain2.Size = new System.Drawing.Size(275, 19);
            this.swapChain1byChain2.TabIndex = 1;
            this.swapChain1byChain2.TabStop = true;
            this.swapChain1byChain2.Text = "Remplacer toutes les occurences de n°1 par n°2";
            this.swapChain1byChain2.UseVisualStyleBackColor = true;
            // 
            // addChain1
            // 
            this.addChain1.AutoSize = true;
            this.addChain1.Location = new System.Drawing.Point(7, 23);
            this.addChain1.Name = "addChain1";
            this.addChain1.Size = new System.Drawing.Size(169, 19);
            this.addChain1.TabIndex = 0;
            this.addChain1.TabStop = true;
            this.addChain1.Text = "Nombre occurences de n°1";
            this.addChain1.UseVisualStyleBackColor = true;
            // 
            // finalButton
            // 
            this.finalButton.Enabled = false;
            this.finalButton.Location = new System.Drawing.Point(270, 371);
            this.finalButton.Name = "finalButton";
            this.finalButton.Size = new System.Drawing.Size(75, 23);
            this.finalButton.TabIndex = 9;
            this.finalButton.Text = "Jouer";
            this.finalButton.UseVisualStyleBackColor = true;
            this.finalButton.Click += new System.EventHandler(this.finalButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 563);
            this.Controls.Add(this.finalButton);
            this.Controls.Add(this.choiceBox);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtChain2);
            this.Controls.Add(this.txtChain1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.choiceBox.ResumeLayout(false);
            this.choiceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtChain1;
        private System.Windows.Forms.TextBox txtChain2;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.GroupBox choiceBox;
        private System.Windows.Forms.RadioButton swapLastChain1byChain2;
        private System.Windows.Forms.RadioButton swap1StChain1ByChain2;
        private System.Windows.Forms.RadioButton swapChain1byChain2;
        private System.Windows.Forms.RadioButton addChain1;
        private System.Windows.Forms.Button finalButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

