using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int left = 0;
            int top = 0;
            for(int a=0; a<3; a++)
            {
                for(int b=0; b<3; b++)
                {
                    var btn = new Button();
                    btn.Width = 100;
                    btn.Height = 100;
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.Black;
                    btn.Left = left;
                    btn.Top = top;
                    btn.Click += new System.EventHandler(this.clickedBtn);
                    Controls.Add(btn);
                    left += 100;
                }
                left = 0;
                top += 100;
            }
        }
        string sira = "X";
        private void clickedBtn(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.Text = sira;
            btn.Click -= new System.EventHandler(this.clickedBtn);
            if (sira == "X")
            {
                sira = "O";
            }
            else
            {
                sira = "X";
            }
        }

    }
}
