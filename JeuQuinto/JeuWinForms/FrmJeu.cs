using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuintoDLL;

namespace JeuWinForms
{
    public partial class FrmJeu : Form
    {
        
        public FrmJeu()
        {
            Quinto gameSession = new Quinto();
            InitializeComponent();
            CreateKeyboard();
            //maskedTextBox.Text = gameSession.WordToFind.Mot;
            DictionnaireDLL.Dictionnaire dictionnaire = new DictionnaireDLL.Dictionnaire("C:\\Users\\CDA\\source\\repos\\JeuQuinto");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void CreateKeyboard()
        {
            int x = 10;
            int y = 20;
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Button button  = new Button();
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

        private void btnPause_Click(object sender, EventArgs e)
        {

        }
        private void clavier_Click(object sender, EventArgs e)
        {
            btnPause.Text = (sender as Button).Text;
        }
    }
}
