using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth_Login.Game.SurviveInSpace
{
    public partial class FSurviveSpace : Form
    {
        //private Bitmap Rocket;
        //private Bitmap gong;
        private PictureBox Rocket;
        private PictureBox gong;

        private int level = 5, addScore = 3; //난이도 . 공의 갯수 결정
        private int Rocket_x = 200, Rocket_y = 200;   //로켓 시작 위치
        private int Rocket_size_x = 40, Rocket_size_y = 40; //로켓 크기
        private int field_size_x = 550, field_size_y = 500; // 필드 크기
        private int gong_size = 20;
        private int size = 0; //공크기
        ContextMenuStrip popup = new ContextMenuStrip();

        private int i;

        //공 위치
        private int[] gong_x = new int[9];
        private int[] gong_y = new int[9];
        //공 움직이는 기울기
        private int[] j = new int[9];
        private int[] k = new int[9];

        static int score;
        FRecord_S form3 = new FRecord_S();

        public FSurviveSpace()
        {
            InitializeComponent();
            //gong = new Bitmap(this.GetType(), "Red.gif");
            //Rocket = new Bitmap(this.GetType(), "rocket.gif");
            gong = new PictureBox();
            Rocket = new PictureBox();
            gong.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Red.gif");
            Rocket.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\rocket.gif");            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0) { }
            else
            {
                this.timer1.Enabled = true;
            }
            size++;
            this.timer1.Interval = 10;
            Refresh();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            Graphics g = e.Graphics;

            if (i == 0) { }
            else if (i == 1)
            {
                //랜덤 배열
                Random rand = new Random();

                int[] rnd_x = new int[9];
                int[] rnd_y = new int[9];

                for (int count11 = 0; count11 < level; count11++)
                {
                    rnd_x[count11] = rand.Next(2, 5);
                    rnd_y[count11] = rand.Next(2, 5);
                }
                //랜덤 배열 끝

                gong_size = 20;
                gong_size = gong_size + (size / 100);

                g.DrawImage(Rocket.Image, Rocket_x, Rocket_y, Rocket_size_x, Rocket_size_y);
                //마우스 좌표에 따라 움직이는 케릭터의 위치와 크기

                //공 그리기
                for (int draw = 0; draw < level; draw++)
                {
                    g.DrawImage(gong.Image, gong_x[draw], gong_y[draw], gong_size, gong_size);
                }

                //공의 좌표와 크기
                if (Rocket_x + Rocket_size_x > field_size_x || Rocket_x == 0)
                {
                    i = 2;
                }
                if (Rocket_y + Rocket_size_y > field_size_y || Rocket_y == 0)
                {
                    i = 2;
                }
                //충돌체크 끝

                //공이 벽에 부딪쳤을때 방향 바뀜
                for (int count = 0; count < level; count++)
                {
                    if (gong_x[count] < 0)  //왼쪽벽에 부딪혔을때
                    {
                        k[count] = rnd_x[count]; //x축 방향 봔대로
                    }
                    if (gong_x[count] > field_size_x - gong_size) //오른쪽벽에 부딪혔을때
                    {
                        k[count] = -rnd_y[count]; //x축 방향 반대로
                    }
                    if (gong_y[count] < 0) // 위쪽 벽에 부딪혔을 때
                    {
                        j[count] = rnd_y[count]; //Y축 방향 반대로
                    }
                    if (gong_y[count] > field_size_y - gong_size) //아래쪽 벽에 부딪혔을때
                    {
                        j[count] = -rnd_y[count]; //Y축 방향 반대로
                    }

                    //주인공과 공의 충돌체크
                    if ((gong_x[count] <= Rocket_x && gong_x[count] + (gong_size - 8) >= Rocket_x) || (gong_x[count] <= Rocket_x + (Rocket_size_x - 8) && gong_x[count] >= Rocket_x))
                    {
                        if ((gong_y[count] <= Rocket_y && gong_y[count] + (gong_size - 9) >= Rocket_y) || (gong_y[count] <= Rocket_y + (Rocket_size_y - 7) && gong_y[count] >= Rocket_y))
                        {
                            i = 2; //게임 끝!!
                        }
                    }
                    gong_x[count] = gong_x[count] + k[count];
                    gong_y[count] = gong_y[count] + j[count];
                }
                //주인공, 벽, 공 충돌 배열 끝 


                //공끼리 충돌체크 - 부딪히면 반대각으로 움직인다.
                //공1이 외쪽 공2가 오른쪽에서 부딪힐 때
                for (int count1 = 0; count1 < level; count1++)
                {
                    for (int count2 = count1 + 1; count2 < level; count2++)
                    {
                        //x축 충돌
                        //공2가 오른쪽 공1이 왼쪽에서 부딪힐때.
                        if (gong_x[count1] <= gong_x[count2] && gong_x[count1] + gong_size + 2 >= gong_x[count2])
                        {
                            //x축 좌표만 비교하면 실질적인 충돌을 알수 없기 때문에 y축 좌표도 비교
                            if (gong_y[count1] <= gong_y[count2] && gong_y[count1] + gong_size >= gong_y[count2] || gong_y[count2] <= gong_y[count1] && gong_y[count2] + gong_size >= gong_y[count1])
                            {
                                //부딪혔다면 x축 진행방향만 이전과 반대로 바꾼다.
                                k[count1] = rnd_x[count1];
                                k[count2] = -rnd_x[count2];
                            }
                        }
                        //x축 충돌 끝

                        //y축 충돌
                        //공 1이 위쪽 공 2가 아래쪽에서 부딪힐때
                        if (gong_y[count1] >= gong_y[count2] && gong_y[count1] <= gong_y[count2] + gong_size - 2)
                        {
                            //y축만 비교하면 실질적인 충돌을 알수 없기 때문에 x축 좌표도 비교해야함.
                            if (gong_x[count1] <= gong_x[count2] && gong_x[count1] + gong_size >= gong_x[count2] || gong_x[count2] <= gong_x[count1] && gong_x[count2] + gong_size >= gong_x[count1])
                            {
                                //부딪혔다면 Y축 진행방향만 이전과 반대로 바꾼다.
                                j[count1] = rnd_y[count1];
                                j[count2] = -rnd_y[count2];
                            }
                        }
                    }
                }
                //공끼리 충돌 배열 끝
            }
            else
            {
                Cursor.Show();
                timer1.Enabled = false;
                init();
            }
        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Rocket_x = e.X;
            Rocket_y = e.Y;
        }

        private void 새게임ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            init();
            score = 0;
            currentScore.Text = "" + score;
            this.start.Visible = true;

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            score += addScore;
            currentScore.Text = "" + score;

            if (i == 2 || i == 0)
            {
                scoreTimer.Enabled = false;
                FGameOver_S form2 = new FGameOver_S();

                form2.setScore(score);
                form2.ShowDialog();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum) progressBar1.Value++; //프로그래스바의 값으 ㅣ최대값에 도달하지 않았다면 시간에 따라 계속 증가

            else
            {
                timer2.Enabled = false; //타이머 2 정지
                progressBar1.Visible = false;

                i = 1;
                timer1.Enabled = true; //게임 시작을 위해 타이머1 시작
                timer1_Tick(sender, e);
                scoreTimer.Enabled = true;
            }
        }

        //스타트 버튼 누르면 커서 사라지면서 게임 시작
        private void start_Click(object sender, EventArgs e)
        {
            init(); //게임 시작전 기본 변수들 초기화
            this.start.Visible = false;//스타트 버튼 숨김

            Cursor.Current = Cursors.Default;
            Cursor.Hide(); // 커서 숨김

            loading(sender, e); // 로딩 페이지로
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("****게임방법****\n\n" +
                "1.메뉴창의 Game -> 새게임 을 눌러 게임을 시작한다. \n" +
                "2.로켓을 움직여 날아다니는 공들을 피한다.\n" +
                "3.공에 부딪히거나 벽에 부딪히면 Game Over\n" +
                "\n\n" +
                "상 += 7점     중 += 5점     하 +=3점", "도움말");
        }

        private void 상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 9;
            addScore = 7;
            상ToolStripMenuItem.Checked = true;
            중ToolStripMenuItem.Checked = false;
            하ToolStripMenuItem.Checked = false;
        }

        private void 중ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 7;
            addScore = 5;
            상ToolStripMenuItem.Checked = false;
            중ToolStripMenuItem.Checked = true;
            하ToolStripMenuItem.Checked = false;
        }
        
        private void 순위보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void 하ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 5;
            addScore = 3;
            상ToolStripMenuItem.Checked = false;
            중ToolStripMenuItem.Checked = false;
            하ToolStripMenuItem.Checked = true;
        }

        private void loading(object sender, EventArgs e)
        {
            this.progressBar1.Visible = true; //프로그래스바 생성
            progressBar1.Value = 0; //프로그래스바의 값 초기화
            timer2.Enabled = true; //로딩용 타이머2 시작
        }

        private void FSurviveSpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void init() //초기 값들 초기화
        {
            //공의 위치 초기화
            for (int count_loc = 0; count_loc < level; count_loc++)
            {
                gong_x[count_loc] = count_loc * 30;
                gong_y[count_loc] = 0;
                k[count_loc] = -1;
                j[count_loc] = -2;

                timer1.Enabled = false;  //공의 이동 타이머
                timer2.Enabled = false; //로딩 타이머
                i = 0;

                gong_size = 20; //공의 크기 초기화
                size = 1;   //공의 사이즈 초기화
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(100, 100);  //시작폼의 위치 지정
            this.ClientSize = new System.Drawing.Size(800, 500); //시작폼의 크기 지정
            init();

            상ToolStripMenuItem.Checked = false;
            중ToolStripMenuItem.Checked = false;
            하ToolStripMenuItem.Checked = true;   //기본 난이도는 하 이다.

            //새게임을 누르기 전까지 시작버튼과 진행바를 감춘다.
            this.start.Visible = false;
            this.progressBar1.Visible = false;

            popup.Items.Add("종료(Esc)");
        }
        private void FSurviveSpace_MouseClick(object sender, MouseEventArgs e)
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
