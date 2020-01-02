using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth_Login.Game.PingPong
{
    public partial class FPingPong : Form
    {
        bool goup, godown;
        int speed = 8;
        int ballx = 5;
        int bally = 5;
        int player1score = 0;
        int player2score = 0;

        public FPingPong()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            player1label.Text = "" + player1score;
            player2label.Text = "" + player2score;

            ball.Top -= bally;
            ball.Left -= ballx;

            player2.Top += speed;
            if (player1score < 5)
            {
                if (player2.Top < 0 || player2.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                player2.Top = ball.Top + 30;
            }

            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx -= 2;
                player2score++;
            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                player1score++;
            }
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                ballx = -ballx;
            }
            if (goup == true && player1.Top > 0)
            {
                player1.Top -= 8;
            }
            if (godown == true && player1.Top < 455)
            {
                player1.Top += 8;
            }
            if (player1score > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("player1 win");
            }
            if (player2score > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("player2 win");
            }
        }
    }
}
