using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons(9, 9, 75, 25, 6);
        }

        private void GenerateButtons(int x, int y, int width, int height, int margin)
        {
            Button[,] buttons = new Button[x, y];
            int top = 0;
            int left = 0;
            //int margin = 5;
            int btnNumber = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = width;
                    buttons[i, j].Height = height;
                    //buttons[i, j].Left = left;
                    //buttons[i, j].Top = top;
                    left += width + margin;
                    btnNumber++;
                    buttons[i, j].Text = "Buton " + btnNumber;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                        buttons[i, j].ForeColor = Color.White;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;

                    }
                    //flowLayoutPanel1.Controls.Add(buttons[i, j]);
                    this.Controls.Add(buttons[i, j]);
                }
                top += height + margin;
                left = 0;
            }
        }
    }
}
