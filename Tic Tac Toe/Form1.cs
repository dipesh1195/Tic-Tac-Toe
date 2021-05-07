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
        public string plr1 = "";
        public string plr2 = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plr1 = textBox1.Text;
            plr2 = textBox2.Text;

            if (plr1 == "" || plr2 == "")
            {
                MessageBox.Show("Enter players Name");
            }
            else
            {
                try
                {
                    this.Hide();
                    Form2 f2 = new Form2(plr1,plr2);
                    f2.Show();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            
        }
       
    }
}
