using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace HWC4D
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        List<Button> button;
        Random rand = new Random();
        int xo = 0;
        int pl1 = 0;
        int pl2 = 0;
        bool wn = false;
        private int player1;
        private int player2;
        private bool w;

        void get()
        {
            if (guna2Button1.Text != "" && guna2Button1.Text == guna2Button6.Text &&
                guna2Button1.Text == guna2Button5.Text)
            {
                win(guna2Button1, guna2Button6, guna2Button5);
                w = true;
            }
            else if (guna2Button4.Text != "" && guna2Button4.Text == guna2Button7.Text &&
                guna2Button4.Text == guna2Button8.Text)
            {
                win(guna2Button4, guna2Button7, guna2Button8);
                w = true;
            }
            else if (guna2Button9.Text != "" && guna2Button9.Text == guna2Button10.Text &&
                guna2Button9.Text == guna2Button11.Text)
            {
                win(guna2Button9, guna2Button10, guna2Button11);
                w = true;
            }
            else if (guna2Button1.Text != "" && guna2Button1.Text == guna2Button4.Text &&
             guna2Button1.Text == guna2Button9.Text)
            {
                win(guna2Button1, guna2Button4, guna2Button9);
                w = true;
            }
            else if (guna2Button6.Text != "" && guna2Button6.Text == guna2Button7.Text &&
             guna2Button6.Text == guna2Button10.Text)
            {
                win(guna2Button6, guna2Button7, guna2Button10);
                w = true;
            }
            else if (guna2Button5.Text != "" && guna2Button5.Text == guna2Button8.Text &&
             guna2Button5.Text == guna2Button11.Text)
            {
                win(guna2Button5, guna2Button8, guna2Button11);
                w = true;
            }
            else if (guna2Button1.Text != "" && guna2Button1.Text == guna2Button7.Text &&
             guna2Button1.Text == guna2Button11.Text)
            {
                win(guna2Button1, guna2Button7, guna2Button11);
                w = true;
            }
            else if (guna2Button5.Text != "" && guna2Button5.Text == guna2Button7.Text &&
             guna2Button5.Text == guna2Button9.Text)
            {
                win(guna2Button5, guna2Button7, guna2Button9);
                w = true;
            }
        }

        private void win(Guna2Button guna2Button5 , Guna2Button guna2Button7,
            Guna2Button guna2Button9)
        {
            guna2Button5.ForeColor = Color.FromArgb(115, 196, 232);
            guna2Button7.ForeColor = Color.FromArgb(115, 196, 232);
            guna2Button9.ForeColor = Color.FromArgb(115, 196, 232);
            if (guna2Button5.Text == "O")
            {
                player1++;
                lbl1.Text = player1.ToString();
            }
            else
            {
                player2++;
                label3.Text = player2.ToString();
            }
        }

        void win(Button b1, Button b2, Button b3)
        {  

            b1.ForeColor = Color.FromArgb(115, 196, 232);
            b2.ForeColor = Color.FromArgb(115, 196, 232);
            b3.ForeColor = Color.FromArgb(115, 196, 232);
            if (b1.Text == "X")
            {
                player1++;
                lbl1.Text = player1.ToString();
            }
            else
            {
                player2++;
                label7.Text = player2.ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new System.EventHandler(guna2Button_click);

                }
            }
        }

        private void guna2Button_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                if (xo % 2 == 0)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Pink;
                    get();
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Black;
                    get();
                }
                xo++;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            xo = 0;
            wn = false;
            foreach (Control c in panel1.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";

                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
