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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grenade = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.grenade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.grenade.Controls.Add(this.pictureBox1);
            this.grenade.Controls.Add(this.player1);
            this.grenade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grenade.Location = new System.Drawing.Point(0, 0);
            this.grenade.Name = "grenade";
            this.grenade.Size = new System.Drawing.Size(1266, 705);
            this.grenade.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(259, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Black;
            this.player1.Location = new System.Drawing.Point(219, 343);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(69, 69);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            this.player1.Move += new System.EventHandler(this.player1_Move);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1266, 705);
            this.Controls.Add(this.grenade);
            this.Controls.Add(this.player);
            this.Name = "Map";
            this.Text = "Map";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Map_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Map_KeyUp);
            this.grenade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Panel grenade;
    }
}

