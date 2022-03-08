using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practik_4
{
    public partial class Form1 : Form
    {
        public int IsRegistered = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startbutton1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Startbutton1_Click_1(object sender, EventArgs e)
        {
            Form2 mainWin = new Form2();
            Form1 StartWin = new Form1();
            mainWin.player1.Text = this.textBox1.Text + " За крестик";
            mainWin.player2.Text = this.textBox2.Text + " За нолик";
            StartWin.Hide();
            mainWin.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                Startbutton1.Enabled = true;
            }
            else Startbutton1.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                Startbutton1.Enabled = true;
            }
            else Startbutton1.Enabled = false;

        }
    }
}
