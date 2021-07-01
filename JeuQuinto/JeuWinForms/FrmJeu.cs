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
        Quinto gameSession = new Quinto(Properties.Settings.Default.RepertoireDictionnaires + "\\FR-fr.xml");
        HighScore highScore = new HighScore();
        List<HighScore> listScores = new List<HighScore>();
        
        public FrmJeu()
        {

           
            InitializeComponent();
            InitSession();
            CreateKeyboard();
            WelcomeBox();
            //label6.Text =  InputUserName();
            //string ta = CharsToString(gameSession.WordToFind.Mot.ToCharArray());
            maskedTextBox.Text = gameSession.WordToFind.Mot;
            //textBox1.Text = CharsToString(HideChar(gameSession.WordToFindHidden));
            
            txtWordHidden.Text = CharsToString(gameSession.WordToFindHidden);
        }
        #region Method
        /// <summary>
        /// Initialisation de la session de départ
        /// </summary>
        private void InitSession()
        {
            //gameSession.WordList = new DictionnaireDLL.Dictionnaire(Properties.Settings.Default.RepertoireDictionnaires + "\\FR-fr.xml");
            gameSession.NbRoundMax = Properties.Settings.Default.NombreManches;
            gameSession.NbErrorMax = Properties.Settings.Default.NombreErreurs;
            gameSession.NbPointByError = Properties.Settings.Default.NombrePointsErreur;
            gameSession.NbPointByTick = Properties.Settings.Default.NombrePointsParSeconde;
            labelRound.Text = $"{gameSession.NbRound}/{gameSession.NbRoundMax}";
            
        }
        /// <summary>
        /// Génération du clavier.
        /// </summary>
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
        /// <summary>
        /// Array en String
        /// </summary>
        /// <param array="t"></param>
        /// <returns>"string"</returns>
        private string CharsToString(char[] t)
        {
            return new string(t);
            //string s = "";
            //foreach (char item in t)
            //{
            //    s += item;
            //}
            //return s;
            
        }
        /// <summary>
        /// Box pour début Timer
        /// </summary>
        private void WelcomeBox()
        {
            var welcome = MessageBox.Show("Etes-vous pret à commencer?","Bienvenue",MessageBoxButtons.YesNo);
            if (welcome == DialogResult.Yes)
            {
                timer1.Start();
            }
        }
        /// <summary>
        /// Dialog fin de partie
        /// </summary>
        private void Continue()
        {
            var welcome = MessageBox.Show("Voulez-vous continuer?", "Gagné!", MessageBoxButtons.YesNo);
            if (welcome == DialogResult.Yes)
            {
                gameSession.Score += gameSession.CalculScore();
                gameSession.NbRound += 1;
                labelRound.Text = $"{gameSession.NbRound}/{gameSession.NbRoundMax}";
                gameSession.NbError = 0;
                gameSession.Timer = 0;
                //gameSession.NewWord();
                maskedTextBox.Text = gameSession.WordToFind.Mot;
                txtWordHidden.Text = CharsToString(gameSession.WordToFindHidden);
                richTxtDef.Text = "";

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
        /// <summary>
        /// Precision Message Box Continue
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Verif du High Score
        /// </summary>
        private void CheckHighScore()
        {

            highScore.LoadScore(listScores);
            for (int i = 0; i <= 9; i++)
            {

                if (gameSession.Score < listScores[i].Score)
                {
                    var welcome = MessageBox.Show("C'est un nouveau record !\r\nVoulez-vous l'enregistrer ?", "Bravo !", MessageBoxButtons.YesNo);
                    if (welcome == DialogResult.Yes)
                    {
                        var temp = new HighScore();
                        temp.Score = gameSession.Score;
                        temp.UserName = InputUserName();
                        listScores.Insert(i, temp);
                        listScores.RemoveAt(listScores.Count - 1);
                        highScore.SaveScore(listScores);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
        /// <summary>
        /// Creation fenetre input username
        /// </summary>
        /// <returns></returns>
        private string InputUserName()
        {
            var userNameInput = new FrmUserName();
            userNameInput.ShowDialog();
            return userNameInput.UserName;

        }
        /// <summary>
        /// Verif de la touche presse
        /// </summary>
        /// <param name="sender"></param>
        private void KeyPressCheck(object sender)
        {
            if (!gameSession.WordToFindArray.Contains((sender as Button).Text.ToCharArray()[0]))
            {
                gameSession.NbError += 1;
            }
            else
            {
                txtWordHidden.Text = CharsToString(gameSession.CheckChar(gameSession.WordToFindHidden, gameSession.WordToFindArray, (sender as Button).Text.ToCharArray()[0]));
            }
            labelError.Text = $"{gameSession.NbError}/{gameSession.NbErrorMax}";
            (sender as Button).Enabled = false;
        }
        /// <summary>
        /// Verif si Round termine
        /// </summary>
        private void RoundEndChack()
        {
            if (gameSession.NbError == gameSession.NbErrorMax)
            {
                var loseBox = MessageBox.Show($"Vous avez perdu.", "bienvenu", MessageBoxButtons.OK);
                this.Close();
               
            }
            else
            {
                if (!gameSession.CheckWinCond(gameSession.WordToFindHidden))
                {
                    timer1.Stop();
                    txtWordHidden.Text = CharsToString(gameSession.WordToFindArray);
                    richTxtDef.Text = gameSession.WordToFind.Definition;
                    if (gameSession.NbRound == gameSession.NbRoundMax)
                    {
                        var scoreBox = MessageBox.Show($"Partie terminée score total :{gameSession.Score}", "bienvenu", MessageBoxButtons.OK);
                        CheckHighScore();
                        this.Close();

                    }
                    else
                    {
                        timer1.Stop();

                        Continue();
                    }

                    
                }
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
            KeyPressCheck(sender);
            RoundEndChack();
            


        }
        #endregion
    }
}
