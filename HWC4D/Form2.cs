using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWC4D
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Guna.UI2.WinForms.Guna2Button> button;
        Random ra = new Random();
        int p1 = 0;
        int p2 = 0;
        private int player1;
        private int player2;

        void buttons()
        {
            button = new List<Guna.UI2.WinForms.Guna2Button>
            { guna2Button1,guna2Button5,guna2Button6,
            guna2Button7,guna2Button8,guna2Button9,guna2Button10,guna2Button11,guna2Button4};
        }
        void win(Guna.UI2.WinForms.Guna2Button b1, Guna.UI2.WinForms.Guna2Button b2,
            Guna.UI2.WinForms.Guna2Button b3)
        {
            b1.ForeColor = Color.Blue;
            b2.ForeColor = Color.Blue;
            b3.ForeColor = Color.Blue;
            if(b1.Text == "X")
            {
                player1++;
                label7.Text = player1.ToString();
            }
            else
            {
                player2++;
                label3.Text = player2.ToString();
            }
        }
        bool bl = false;
        private bool w;
        private object panelofButton;
        private bool wi;

        void get()
        {
            if (guna2Button1.Text != "" && guna2Button1.Text == guna2Button6.Text &&
                guna2Button1.Text == guna2Button5.Text) 
            {
                win (guna2Button1, guna2Button6, guna2Button5);
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
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new System.EventHandler(guna2Button_click);

                }
            }
            buttons();
        }
        public void guna2Button_click (object sender ,EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                btn.Text = "X";
                btn.ForeColor = Color.Pink;
                button.Remove(btn);
                get();
                move.Start();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void move_Tick(object sender, EventArgs e)
        {
            if (button.Count>0 && wi == false)
            {
                int index = ra.Next(button.Count);
                if(button[index].Text == "")
                {
                    button[index].ForeColor = Color.Azure;
                    button[index].Text = "0";
                    button.RemoveAt(index);
                    get();
                    move.Stop();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            buttons();
            wi= false;
            foreach (Control c in panel1.Controls)
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";
                }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
