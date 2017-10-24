using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _24hr_Game_Challenge
{
    public partial class Map : Form
    {

        bool right, left;
        bool jump;
        int G = 40;
        int force;

        public Map()
        {
            InitializeComponent();

            string input = "";
            DialogResult = ShowInputDialog(ref input);
            if (DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Sorry boi, that name is lame. We'll call him tristen instead.", "Sorry", MessageBoxButtons.OK);
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        { 

        }


        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(400, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.ClientSize = size;
            inputBox.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            inputBox.Text = "Please choose character name:";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;

            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Keep grenade on player
            // grenade.Location;


            //Move Right
            if (right == true)
            {
                player1.Left += 5;
                player1.Image = Properties.Resources.walking_2_0;
            }

            //Move Left
            if (left == true)
            {
                player1.Left -= 5;
                player1.Image = Properties.Resources.walking_2_0;
            }

            //Jump
            if (jump == true)
            {

                player1.Top -= force;
                force -= 1;
            }
            if (player1.Top + player1.Height >= grenade.Height)
            {
                player1.Top = grenade.Height - player1.Height;
                jump = false;
                player1.Image = Properties.Resources.the_smallest_of_the_boios;
            }
            else
            {

                player1.Top += 20;
            }

        }

        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                player1.Image = Properties.Resources.walking_2_0;
                right = true;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                player1.Image = Properties.Resources.walking_2_0;
                left = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Oemtilde)
            {
                Console.Visible = true;
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W)
                {
                    player1.Image = Properties.Resources.jumping_2_0;
                    jump = true;
                    force = G;
                }
            }
        }

        private void Map_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                right = false;
              //  player1.Image = Properties.Resources.the_smallest_of_the_boios;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                left = false;
                //player1.Image = Properties.Resources.the_smallest_of_the_boios;
            }
            if (e.KeyCode == Keys.Oemtilde)
            {
                Console.Visible = false;
            }
        }


    }
}