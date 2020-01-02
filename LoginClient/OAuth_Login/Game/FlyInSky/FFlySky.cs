using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth_Login.Game.FlyInSky
{
    public partial class FFlySky : Form
    {
        int color = 0;
        int count = 4;//countdown
        int playerSpeed = 5;//내 차 속도
        int backSpeed = 5;//도로 속도
        //int playerSpeed = 5;
        bool pLeft;//내 차를 오,왼으로 움직일 수 있는지
        bool pRight;
        int aiSpeed = 5;//주변차?ai 속도
        int Score = 0;
        Random rnd = new Random();
        ContextMenuStrip popup = new ContextMenuStrip();

        public FFlySky()
        {
            InitializeComponent();
            popup.Items.Add("종료(Esc)");
        }

        private void Reset()//restart를 눌렀을때
        {
            trophy.Visible = false;
            gamelogo.Visible = false;
            button1.Enabled = false;
            explosion.Visible = false;
            aiSpeed = 5;
            playerSpeed = 5;
            backSpeed = 5;
            Score = 0;

            //move ai            
            player.Left = 161;//이게 player를 보여주는 부분 아님??
            player.Top = 286;
            pLeft = false;//왼쪽으로 못가게?
            pRight = false;
            AI1.Left = 66;
            AI1.Top = -120;
            AI2.Left = 294;
            AI2.Top = -185;
            background2.Left = -3;
            background2.Top = -222;
            background1.Left = -2;
            background1.Top = -638;

            timer1.Start();
        }
   
        private void timer1_Tick(object sender, EventArgs e)//본 게임판 흘러가는거
        {
            menuStrip1.Enabled = false;
            Score++;
            height.Text = "" + Score;
            background1.Top += backSpeed;
            background2.Top += backSpeed;

            if (color == 1)
            {
                player.Image = Properties.Resources.GC;
            }
            else if (color == 2)
            {
                player.Image = Properties.Resources.MC;
            }
            else if (color == 3)
            {
                player.Image = Properties.Resources.PC;
            }
            else if (color == 4)
            {
                player.Image = Properties.Resources.RC;
            }
            else
            {
                player.Image = Properties.Resources.MC;
            }

            player.Visible = true;

            if (background1.Top > 630)//맨위로가면 다시맨아래로 반복
            {
                background1.Top = -630;
            }
            if (background2.Top > 630)
            {
                background2.Top = -630;
            }
            if (pLeft)
            {
                player.Left -= playerSpeed;
            }
            if (pRight)
            {
                player.Left += playerSpeed;
            }
            if (player.Left < 1)//이부분 이해하기
            {
                pLeft = false;
            }
            else if (player.Left + player.Width > 380)
            {
                pRight = false;
            }
            AI1.Top += aiSpeed;
            AI2.Top += aiSpeed;

            if (AI1.Top > panel1.Height)
            {
                changeAI1();
                AI1.Left = rnd.Next(2, 160);
                AI1.Top = rnd.Next(100, 200) * -1;
            }
            if (AI2.Top > panel1.Height)
            {
                changeAI2();
                AI2.Left = rnd.Next(185, 327);
                AI2.Top = rnd.Next(100, 200) * -1;
            }
            //check bounds
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }
            if (Score > 100 && Score < 500)
            {
                aiSpeed = 8;
                backSpeed = 7;
            }
            else if (Score > 500 && Score < 1000)
            {
                aiSpeed = 10;
                backSpeed = 8;
            }
            else if (Score > 1500)
            {
                aiSpeed = 12;
                backSpeed = 11;
            }
        }

        private void moveCar(object sender, KeyEventArgs e)//자동차 움직일때 키보드
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                pLeft = true;
            }
            if (e.KeyCode == Keys.Right && player.Left + player.Width < panel1.Width)
            {
                pRight = true;
            }

            if (e.KeyCode ==  Keys.Escape)
            {
                this.Close();
            }
        }

        private void stopCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                pRight = false;
            }
        }

        private void changeAI1()
        {
            if (AI1.Top < 630)
            {
                int num = rnd.Next(1, 8);
                switch (num)
                {
                    case 1:
                        AI1.Image = Properties.Resources.boo;
                        break;
                    case 2:
                        AI1.Image = Properties.Resources.roket;
                        break;
                    case 3:
                        AI1.Image = Properties.Resources.chain;
                        break;
                    case 4:
                        AI1.Image = Properties.Resources.flower;
                        break;
                    case 5:
                        AI1.Image = Properties.Resources.bird;
                        break;
                    default:
                        break;
                }
            }
        }

        private void changeAI2()
        {
            if (AI2.Top < 630)
            {
                int num = rnd.Next(1, 8);
                switch (num)
                {
                    case 1:
                        AI2.Image = Properties.Resources.boo;
                        break;
                    case 2:
                        AI2.Image = Properties.Resources.roket;
                        break;
                    case 3:
                        AI2.Image = Properties.Resources.chain;
                        break;
                    case 4:
                        AI2.Image = Properties.Resources.flower;
                        break;
                    case 5:
                        AI2.Image = Properties.Resources.bird;
                        break;
                    default:
                        break;
                }
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            button1.Text = "ReStart";
            button1.Enabled = true;
            menuStrip1.Enabled = true;
            trophy.Visible = true;

            if (Score < 800)
            {
                trophy.Image = Properties.Resources.bronze;
            }
            if (Score > 1500)
            {
                trophy.Image = Properties.Resources.silver;
            }
            if (Score > 2200)
            {
                trophy.Image = Properties.Resources.gold;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countdown.Enabled = true;
        }

        private void 노란색ToolStripMenuItem_Click(object sender, EventArgs e) //쿠파
        {
            color = 2;
            player.Image = Properties.Resources.MC;
        }

        private void 빨간색ToolStripMenuItem_Click(object sender, EventArgs e)//피치
        {
            color = 3;
            player.Image = Properties.Resources.PC;
        }

        private void 초록색ToolStripMenuItem_Click(object sender, EventArgs e)//루이지
        {
            color = 1;
            player.Image = Properties.Resources.GC;
        }

        private void 회색ToolStripMenuItem_Click(object sender, EventArgs e)//마리오
        {
            color = 4;
            player.Image = Properties.Resources.RC;
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            gamelogo.Visible = false;
            down.Visible = true;
            count--;
            down.Text = count + "";
            if (count == 0)
            {
                countdown.Stop();
                Reset();
                down.Visible = false;
                count = 4;
            }
        }

        private void FFlySky_MouseClick(object sender, MouseEventArgs e)
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
    }
}
