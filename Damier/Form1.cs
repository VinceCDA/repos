using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i = 0;
            int j = 0;
            for (i = 0; i < groupBox1.Width  / 50; i++)
            {
                for (j = 0; j < groupBox1.Height / 50 - 1; j++)
                {
                    Button buttonY = new Button();
                    buttonY.Size = new System.Drawing.Size(50, 50);
                    buttonY.Top = j * 50;
                    buttonY.Left = i * 50;
                    if ((i+j)%2 == 0)
                    {
                        buttonY.BackColor = Color.White;
                    }
                    else
                    {
                        buttonY.BackColor = Color.Black;
                    }
                    this.groupBox1.Controls.Add(buttonY);
                }
                Button buttonX = new Button();
                buttonX.Size = new System.Drawing.Size(50, 50);
                buttonX.Top = j * 50;
                buttonX.Left = i*50;
                if ((i + j) % 2 == 0)
                {
                    buttonX.BackColor = Color.White;
                }
                else
                {
                    buttonX.BackColor = Color.Black;
                }
                this.groupBox1.Controls.Add(buttonX);
            }
            

        }

        private void groupBox1_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
