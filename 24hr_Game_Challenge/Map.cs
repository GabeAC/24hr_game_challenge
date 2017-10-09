using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; 

namespace _24hr_Game_Challenge
{
    public partial class Map : Form
    {
        WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();

//Glorious Variables----------------------------------------------------------------------------------------------------------------------------------
        bool right, left;
        bool jump;
        int G = 40;
        int force;
        Point temp;

//----------------------------------------------------------------------------------------------------------------------------------------------------

        public Map()
        {
            InitializeComponent();
            musicPlayer.URL = "Behelit.m4a";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musicPlayer.controls.play();
        }



        //Player movements-------------------------------------------------------------------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Keep grenade on player
           // grenade.Location;



            //Move Right
            if (right == true) {player1.Left += 5; }

            //Move Left
            if (left == true) { player1.Left -= 5; }

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
            }
            else
            {
                player1.Top += 20;
            }

            //****************Character Actions************************


            //*********************************************************


        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------



        //KeyDown Events---------------------------------------------------------------------------------------------------------------------------------------
        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Escape) { this.Close(); }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W)
                {
                    jump = true;
                    force = G; 
                }
            }  
        }
        
        private void player1_Move(object sender, EventArgs e)
        {

        }
        
        //-----------------------------------------------------------------------------------------------------------------------------------------------------





        //Keyup Events-----------------------------------------------------------------------------------------------------------------------------------------
        private void Map_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) { left = false; }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------------------








    }
}


