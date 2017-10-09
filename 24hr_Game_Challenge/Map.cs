using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _24hr_Game_Challenge
{
    public partial class Map : Form
    {
       bool right, left;


        //bool jump;

        public Map()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // requires physX sdk, extremely complicated.
            if (player1.Right > block.Left && player1.Left < block.Right - player1.Width /2 && player1.Bottom > block.Top)
            {
                right = false;
            }

            if (player1.Left < block.Right && player1.Right > block.Left + player1.Width / 2 && player1.Bottom > block.Top)
            {
                left = false;
            }



            if (right == true) {player1.Left += 5; }
            if (left == true) { player1.Left -= 5; }
        }

      

        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { right = true; }
            if(e.KeyCode == Keys.Left || e.KeyCode == Keys.A) { left = true; }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
            foreach (string file in Directory.GetFiles("./maps", "*.xml"))
            {
                string contents = File.ReadAllText(file);
            }

            System.IO.Stream str = Properties.Resources.Ocean_Man_Voice_Crack;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Map_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { right = false; }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) { left = false; }
        }



    }
}
