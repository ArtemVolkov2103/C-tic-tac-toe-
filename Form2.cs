using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practik_4
{
    public partial class Form2 : Form
    {
        private int player = 1;
        bool Game=true;//для смены игроков между собой
        private Button[,] buttons = new Button[3, 3];
        public Form2()
        {
            InitializeComponent();
            button10.Enabled = false;
            player1.Font = new Font(player1.Font, FontStyle.Bold);
            player2.Font = new Font(player2.Font, FontStyle.Regular);
            
            for (int i=0; i<buttons.Length/3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(102,102);
                }
            }
            resetButtons();
        }

        private void resetButtons()
        {
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j].Location = new Point(250 + 100 * j, 50 + 100 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Segoe UI Light"), 30);
                    this.Controls.Add(buttons[i, j]);
                }
                
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    player1.Font = new Font(player1.Font, FontStyle.Regular);
                    player2.Font = new Font(player2.Font, FontStyle.Bold);
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    break;

                case 0:
                    player1.Font = new Font(player1.Font, FontStyle.Bold);
                    player2.Font = new Font(player2.Font, FontStyle.Regular);
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    break;
            }
            
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            chekWin();
        }

        private void ShowWinner()
        {
            if(player == 0)
            MessageBox.Show("Победил " + this.player1.Text );
            else MessageBox.Show("Победил " + this.player2.Text);
        }

        private void chekWin()//сделать вариант ничья
        {
            if(buttons[0,0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 0].Text != "") ShowWinner(); button10.Enabled = true;
            }

            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "") ShowWinner(); button10.Enabled = true;
            }

            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "") ShowWinner(); button10.Enabled = true;
            }

            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "") ShowWinner(); button10.Enabled = true;
            }

            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "") ShowWinner(); button10.Enabled = true;
            }

            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "") ShowWinner(); button10.Enabled = true;
            }

            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "") ShowWinner(); button10.Enabled = true;
            }

            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "") ShowWinner(); button10.Enabled = true;
            }

            else if(buttons[0, 0].Text != "" && buttons[0, 1].Text != "" && buttons[0, 2].Text != "" && buttons[1, 0].Text != "" && buttons[1, 1].Text != "" && buttons[1, 2].Text != "" && buttons[2, 0].Text != "" && buttons[2, 1].Text != "" && buttons[2, 2].Text != "")
            {
                MessageBox.Show("Ничья");
                button10.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void player1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j=0; j< 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
            Game = !Game;
        }
    }
}
