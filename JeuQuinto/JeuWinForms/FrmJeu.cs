﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuintoDLL;

namespace JeuWinForms
{
    public partial class FrmJeu : Form
    {
        Quinto gameSession = new Quinto();
        

        public FrmJeu()
        {
            
            gameSession.NbRoundMax = Properties.Settings.Default.NombreManches;
            gameSession.NbErrorMax = Properties.Settings.Default.NombreErreurs;
            gameSession.NbPointByError = Properties.Settings.Default.NombrePointsErreur;
            gameSession.NbPointByTick = Properties.Settings.Default.NombrePointsParSeconde;
            InitializeComponent();
            CreateKeyboard();
            WelcomeBox();
            labelRound.Text = $"{gameSession.NbRound}/{gameSession.NbRoundMax}";
            
            //string ta = CharsToString(gameSession.WordToFind.Mot.ToCharArray());
            maskedTextBox.Text = gameSession.WordToFind.Mot;
            //textBox1.Text = CharsToString(HideChar(gameSession.WordToFindHidden));
            
            txtWordHidden.Text = CharsToString(gameSession.WordToFindHidden);
        }
        #region Method
        private void CreateKeyboard()
        {
            int x = 10;
            int y = 20;
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Button button = new Button();
                button.Text = letter.ToString();
                button.Size = new System.Drawing.Size(40, 40);
                button.Text = $"{letter}";
                button.Top = y;
                button.Left = x;
                x += 40;
                gbClavier.Controls.Add(button);
                button.Click += new System.EventHandler(this.clavier_Click);
                button.TabStop = false;
                if (x > gbClavier.Width)
                {
                    x = 10;
                    y += 40;
                }

            }
            Button trait = new Button();
            trait.Text = "-";
            trait.Size = new System.Drawing.Size(40, 40);
            trait.Text = $"-";
            trait.Top = y;
            trait.Left = x;
            gbClavier.Controls.Add(trait);
            trait.Click += new System.EventHandler(this.clavier_Click);
            trait.TabStop = false;
        }
        private string CharsToString(char[] t)
        {
            string s = "";
            foreach (char item in t)
            {
                s += item;
            }
            return s;
            
        }
        


        private void WelcomeBox()
        {
            var welcome = MessageBox.Show("Etes-vous pret à commencer?","Bienvenue",MessageBoxButtons.YesNo);
            if (welcome == DialogResult.Yes)
            {
                timer1.Start();
            }
        }
        private void Continue()
        {

            //
            var welcome = MessageBox.Show("Voulez-vous continuer?", WinOrLose(), MessageBoxButtons.YesNo);
            if (welcome == DialogResult.Yes)
            {
                gameSession.Score += gameSession.CalculScore();
                gameSession.NbRound += 1;
                labelRound.Text = $"{gameSession.NbRound}/{gameSession.NbRoundMax}";
                gameSession.NbError = 0;
                gameSession.Timer = 0;
                gameSession.NewWord();
                maskedTextBox.Text = gameSession.WordToFind.Mot;
                txtWordHidden.Text = CharsToString(gameSession.WordToFindHidden);

                foreach (Control item in gbClavier.Controls)
                {
                    item.Enabled = true;
                }
                timer1.Start();
            }
            if (welcome == DialogResult.No)
            {
                this.Close();
            }
        }
        private string WinOrLose()
        {
            if (gameSession.CheckWinCondtion(gameSession.WordToFindHidden))
            {
                return "Gagné";
            }
            else
            {
                return "Perdu";
            }
        }
        #endregion
        #region Event
        private void timer1_Tick(object sender, EventArgs e)
        {

            gameSession.Timer += 1;
            labelTimer.Text = $"{gameSession.Timer}s";
        }


        private void btnPause_Click(object sender, EventArgs e)
        {

        }
        private void clavier_Click(object sender, EventArgs e)
        {
            if (!gameSession.WordToFindArray.Contains((sender as Button).Text.ToCharArray()[0]))
            {
                gameSession.NbError += 1;
            }
            else
            {
                txtWordHidden.Text = CharsToString(gameSession.CheckChar(gameSession.WordToFindHidden, gameSession.WordToFindArray, (sender as Button).Text.ToCharArray()[0]));
            }
            labelError.Text = $"{gameSession.NbError.ToString()}/{gameSession.NbErrorMax}";
            (sender as Button).Enabled = false;

            if (gameSession.CheckWinCondtion(gameSession.WordToFindHidden) || gameSession.NbError == gameSession.NbErrorMax)
            {
                txtWordHidden.Text = CharsToString(gameSession.WordToFindArray);
                richTextBox1.Text = gameSession.WordToFind.Definition;
                if (gameSession.NbRound == gameSession.NbRoundMax)
                {
                    var scoreBox = MessageBox.Show($"Partie terminée score total :{gameSession.Score}", "bienvenu", MessageBoxButtons.OK);
                    this.Close();
                    
                }
                else
                {
                    timer1.Stop();
                   
                    Continue();
                }
                

            }
            


        }
        #endregion
    }
}
