using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuWinForms
{
    public partial class FrmHighScore : Form
    {
        HighScore highScore = new HighScore();
        List<HighScore> listScores = new List<HighScore>();
        public FrmHighScore()
        {
            InitializeComponent();
            //listView1.Columns.Add("Pseudo");
            //listView1.Columns.Add("Score");
            highScore.LoadScore(listScores);
            foreach (var item in listScores)
            {
                listView1.Items.Add(new ListViewItem(new string[] { item.UserName, item.Score.ToString() }));
            }
        }
    }
}
