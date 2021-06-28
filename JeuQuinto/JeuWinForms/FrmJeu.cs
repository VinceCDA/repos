using System;
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
            
            //string ta = CharsToString(gameSession.WordToFind.Mot.ToCharArray());
            maskedTextBox.Text = gameSession.WordToFind.Mot;
            //textBox1.Text = CharsToString(HideChar(gameSession.WordToFindHidden));
            richTextBox1.Text = gameSession.WordToFind.Definition;
            gameSession.WordToFindHidden = HideChar(gameSession.WordToFindArray);
            textBox1.Text = CharsToString(gameSession.WordToFindHidden);
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
                //y += 30;
                gbClavier.Controls.Add(button);
                button.Click += new System.EventHandler(this.clavier_Click);
                if (x > gbClavier.Width)
                {
                    x = 10;
                    y += 40;
                }

            }
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
        private char[] HideChar(char[] vs ) 
        {
            char[] output = new char[vs.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                output[i] = '_';
            }
            return output;
        }
        private char[] CheckChar(char[] hidden, char[] result, char check)
        {
            for (int i = 0; i < hidden.Length; i++)
            {
                if (result[i] == check)
                {
                    hidden[i] = check;
                }
                
            }
            return hidden;
        }
        #endregion
        #region Event
        private void timer1_Tick(object sender, EventArgs e)
        {

            gameSession.Score += 1;
            label6.Text = gameSession.Score.ToString();
        }


        private void btnPause_Click(object sender, EventArgs e)
        {

        }
        private void clavier_Click(object sender, EventArgs e)
        {
            //CheckChar(gameSession.WordToFindHidden,gameSession.WordToFindArray, (sender as Button).Text.ToCharArray()[0]);
            //textBox1.Text = CharsToString(HideCharA(gameSession.WordToFindArray, (sender as Button).Text.ToCharArray()[0]));
            textBox1.Text = CharsToString(CheckChar(gameSession.WordToFindHidden, gameSession.WordToFindArray, (sender as Button).Text.ToCharArray()[0]));
        }
        #endregion
    }
}
