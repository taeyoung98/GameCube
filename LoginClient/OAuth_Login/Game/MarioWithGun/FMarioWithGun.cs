using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth_Login.Game.MarioWithGun
{
    public partial class FMarioWithGun : Form
    {
        FRecord_M form2 = new FRecord_M();
        FGameOver_M GO = new FGameOver_M();
        CRanking rank = new CRanking();
        bool goup, godown, goleft, goright;
        string facing = "up";
        double playerHealth = 100;
        int speed = 10;
        int bombSpeed = 3;
        int score = 0;
        bool gameOver = false;
        Random rnd = new Random();
        ContextMenuStrip popup = new ContextMenuStrip();

        public FMarioWithGun()
        {
            InitializeComponent();
            popup.Items.Add("종료(Esc)");
        }

        string currentName;

        public void ReturnCurrentName(string n)
        {
            currentName = n;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                facing = "left";
                player.Image = Properties.Resources.Mario_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = "right";
                player.Image = Properties.Resources.Mario_right;
            }

            if (e.KeyCode == Keys.Up)
            {
                facing = "up";
                goup = true;
                player.Image = Properties.Resources.Mario_up;
            }

            if (e.KeyCode == Keys.Down)
            {
                facing = "down";
                godown = true;
                player.Image = Properties.Resources.Mario_down;
            }

            if (e.KeyCode == Keys.Space)
            {
                shoot(facing);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                shoot(facing);
            }
        }

        private void FMarioWithGun_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popup.Show(e.Location);
                popup.ItemClicked += new ToolStripItemClickedEventHandler(ContextMenuStrip_ItemClicked);
            }
        }
        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "화면종료(Esc)")
            {
                this.Close();
            }
        }

        private void Dropstar()
        {
            PictureBox star = new PictureBox();
            star.Image = Properties.Resources.star;
            star.SizeMode = PictureBoxSizeMode.AutoSize;
            star.Left = rnd.Next(10, 890);
            star.Top = rnd.Next(50, 600);
            star.Tag = "star";
            this.Controls.Add(star);
            star.BringToFront();
            player.BringToFront();

        }

        private void shoot(string direct)
        {
            Bullet shoot = new Bullet();
            shoot.direction = direct;
            shoot.bulletLeft = player.Left + (player.Width / 2);
            shoot.bulletTop = player.Top + (player.Height / 2);
            shoot.MakeBullet(this);
        }

        private void makeBomb()
        {
            PictureBox bomb = new PictureBox();
            bomb.Tag = "bomb";
            bomb.Image = Properties.Resources.bomb_down;
            bomb.Left = rnd.Next(0, 900);
            bomb.Top = rnd.Next(0, 800);
            bomb.Size = new Size(71, 71);
            bomb.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(bomb);
            player.BringToFront();
        }


        private void gameEngine_Tick_1(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                progressBar1.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                player.Image = Properties.Resources.mHat;

                gameEngine.Stop();
                DropStar_timer.Stop();
                GO.ReturnName(currentName);
                GO.ReturnScore(score);
                gameOver = true;
                GO.ShowDialog();
            }
            label2.Text = "Kills : " + score;

            if (playerHealth < 20)
            {
                progressBar1.ForeColor = System.Drawing.Color.Red;
            }
            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goright && player.Left + player.Width < 930)
            {
                player.Left += speed;
            }
            if (goup && player.Top > 60)
            {
                player.Top -= speed;
            }
            if (godown && player.Top + player.Height < 700)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)(x.Tag) == "star")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));

                        ((PictureBox)x).Dispose();
                        playerHealth += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 903 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bomb")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (((PictureBox)x).Left > player.Left)
                    {
                        ((PictureBox)x).Left -= bombSpeed;
                        ((PictureBox)x).Image = Properties.Resources.bomb_left;
                    }
                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= bombSpeed;
                        ((PictureBox)x).Image = Properties.Resources.bomb_up;
                    }
                    if (((PictureBox)x).Left < player.Left)
                    {
                        ((PictureBox)x).Left += bombSpeed;
                        ((PictureBox)x).Image = Properties.Resources.bomb_right;
                    }
                    if (((PictureBox)x).Top < player.Top)
                    {
                        ((PictureBox)x).Top += bombSpeed;
                        ((PictureBox)x).Image = Properties.Resources.bomb_down;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && (string)j.Tag == "bullet") && (x is PictureBox && (string)x.Tag == "bomb"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            makeBomb();

                        }
                    }
                }
            }
        }

        

        private void DropStar_timer_Tick(object sender, EventArgs e)
        {
            DropStar_timer.Interval = rnd.Next(10000, 15000);
            if (playerHealth < 50)
            {
                Dropstar();
            }
        }

        
        
    }
}
