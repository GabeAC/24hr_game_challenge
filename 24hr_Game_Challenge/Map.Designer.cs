namespace _24hr_Game_Challenge
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grenade = new System.Windows.Forms.Panel();
            this.Console = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.grenade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grenade
            // 
            this.grenade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grenade.BackgroundImage")));
            this.grenade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grenade.Controls.Add(this.Console);
            this.grenade.Controls.Add(this.player1);
            this.grenade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grenade.Location = new System.Drawing.Point(0, 0);
            this.grenade.Name = "grenade";
            this.grenade.Size = new System.Drawing.Size(1266, 705);
            this.grenade.TabIndex = 0;
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Console.Dock = System.Windows.Forms.DockStyle.Top;
            this.Console.ForeColor = System.Drawing.Color.Lime;
            this.Console.Location = new System.Drawing.Point(0, 0);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(1266, 97);
            this.Console.TabIndex = 3;
            this.Console.Text = "24 Hour Game Challenge | Console | v0.01";
            this.Console.Visible = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1.Image = global::_24hr_Game_Challenge.Properties.Resources.the_smallest_of_the_boios;
            this.player1.Location = new System.Drawing.Point(355, 75);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(319, 380);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(325, 357);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(69, 69);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 705);
            this.Controls.Add(this.grenade);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Map_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Map_KeyUp);
            this.grenade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox player1;
        protected System.Windows.Forms.Panel grenade;
        private System.Windows.Forms.Label Console;
    }
}

