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
    public partial class Form2 : Form
    {
        string plr1, plr2;
        public Form2(string plr1,string plr2)
        {
            InitializeComponent();
            label1.Text = plr1 +" Vs " +plr2;
            this.plr1 = plr1;
            this.plr2 = plr2;
           

        }
        Boolean turn = false;

        private void newgame_click(object sender, EventArgs e)
        {
            turn = false;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Text = "";
                    b.Enabled = true;
                }
                //new Form2(plr1,plr2).Show();
            }
        }
        private void Exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void About_click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Dipesh Kushwaha");

        }

        private void button_click(object sender, EventArgs e)
        {
            
           Button btn = (Button)sender;
            if (turn)
            {
                btn.Text = "0";
            }
            else
            {
                btn.Text = "X";
            }
            turn = !turn;
            btn.Enabled = false;
            winnercheck();
        }

        private void winnercheck()
        {
            Boolean winner = false;
            if(button1.Text == button7.Text && button7.Text == button3.Text && !(button1.Enabled))
            {
                winner = true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && !(button4.Enabled))
            {
                winner = true;
            }
            else if (button8.Text == button9.Text && button9.Text == button10.Text && !(button8.Enabled))
            {
                winner = true;
            }
            else if (button1.Text == button5.Text && button5.Text == button10.Text && !(button1.Enabled))
            {
                winner = true;
            }
            else if (button3.Text == button5.Text && button5.Text == button8.Text && !(button3.Enabled))
            {
                winner = true;
            }
            else if (button1.Text == button7.Text && button7.Text == button3.Text && !(button1.Enabled))
            {
                winner = true;
            }
            else if (button1.Text == button4.Text && button4.Text == button8.Text && !(button1.Enabled))
            {
                winner = true;
            }
            else if (button7.Text == button5.Text && button5.Text == button9.Text && !(button7.Enabled))
            {
                winner = true;
            }
            else if (button3.Text == button6.Text && button6.Text == button10.Text && !(button3.Enabled))
            {
                winner = true;
            }
            if (winner)
            {
                DisableButton();
                MessageBox.Show(turn ? plr1 + " Wins" : plr2 + " Wins");
               
            }
        
        }

        private void DisableButton()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button)) { 
                Button b = (Button)c;
                b.Enabled = false;
            }
        }
        }
    }
}
