using LoginClient.OAuth;
using OAuth_Login.Client;
using OAuth_Login.Game.FlyInSky;
using OAuth_Login.Game.MarioWithGun;
using OAuth_Login.Game.PingPong;
using OAuth_Login.Game.SurviveInSpace;
using OAuth_Login.Login.OAuth.Naver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginClient.Client
{
    public partial class FClient : Form
    {
        private int roomNumber;
        FRoom froom;
        Man man2 = new Man();
        FMakeRoom FMR;
        int second = 0;
        int tmpPersonnel1, tmpPersonnel2, tmpPersonnel3, tmpPersonnel4, tmpPersonnel5, tmpPersonnel6, tmpPersonnel7, tmpPersonnel8, tmpPersonnel9;
        string tmpGameName1, tmpGameName2, tmpGameName3, tmpGameName4, tmpGameName5, tmpGameName6, tmpGameName7, tmpGameName8, tmpGameName9;
        string tmpIp;
        FMarioWithGun FMWG;
        FFlySky FFS;
        FSurviveSpace FSS;
        FPingPong FPP;
        
        public int RoomNumber { get { return roomNumber; } set { roomNumber = value; } }

        public FClient()
        {
            InitializeComponent();
        }
        public FClient(Man man)
        {
            InitializeComponent();
            man2 = man;
        }

        #region groupBox BorderColor 속성 추가
        /*
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            e.Graphics.Clear(SystemColors.Control);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
            //DrawGroupBox(box, e.Graphics, Color.Black, Color.Black);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            
        }
        */
        #endregion

        private void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            lbNick.Text = man2.manInfo["nickname"];
            contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip1.Items.Add("화면종료(Esc)");
        }

        #region FClient 폼화면 닫기
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(e.Location);
                contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(ContextMenuStrip_ItemClicked);
            }
        }
        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "화면종료(Esc)")
            {
                this.Close();
            }
        }
        #endregion

        #region ? Box
        private void pbQuestion_MouseHover(object sender, EventArgs e)
        {
            //pbQuestion.Location= new Point(161, 537);
            pbQuestion.Size = new Size(117, 106);
            pbQuestion.Top += 5;
            pbPlayAlone.Visible = true;
            lbPlayAlone.Visible = true;
            pbRanking.Visible = true;
            lbRanking.Visible = true;
            pbSettings.Visible = true;
            lbSettings.Visible = true;
        }

        private void pbQuestion_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second > 2)
            {
                //pbQuestion.Location = new Point(158, 537);
                pbQuestion.Size = new Size(124, 126);
                pbPlayAlone.Visible = false;
                lbPlayAlone.Visible = false;
                pbRanking.Visible = false;
                lbRanking.Visible = false;
                pbSettings.Visible = false;
                lbSettings.Visible = false;
                timer1.Stop();
                second = 0;
            }
        }
        #endregion

        #region 방 만들기
        private void tbMake_Click(object sender, EventArgs e)
        {
            if (tbRoomNum.Text == "")
            {
                MessageBox.Show("방 번호를 입력해주세요", "예외 발생");
            }
            else
            {
                int result;
                bool isNumber = Int32.TryParse(tbRoomNum.Text, out result);
                if (isNumber == false)
                {
                    MessageBox.Show("방 번호를 다시 입력해주세요", "예외 발생");
                    tbRoomNum.Text = "";
                }
                else
                {
                    int tmp_roomNum = Int32.Parse(tbRoomNum.Text);
                    if (tmp_roomNum<1 || tmp_roomNum>9)
                    {
                        MessageBox.Show("방 번호를 다시 입력해주세요", "예외 발생");
                        tbRoomNum.Text = "";
                    }
                    else
                    {
                        if (tbIp.Text == "")
                        {
                            MessageBox.Show("IP 주소를 입력해주세요", "예외 발생");
                        }
                        else
                        {
                            FMR = new FMakeRoom();
                            FMR.ShowDialog();
                            if (FMR.close == true)
                            {
                                //MessageBox.Show("클라이언트폼\n방제: " + FMR.roomName + "\n정원:" + FMR.personnel + "\n게임:" + FMR.gameName);
                                if (tmp_roomNum == 1)
                                {
                                    lbRoomName1.Text = FMR.roomName;
                                    lbPersonnel1.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail1.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail1.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail1.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail1.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel1 = FMR.personnel;
                                    tmpGameName1 = FMR.gameName;
                                    gbRoom1.Enabled = true;
                                }
                                else if (tmp_roomNum == 2)
                                {
                                    lbRoomName2.Text = FMR.roomName;
                                    lbPersonnel2.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail2.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail2.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail2.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail2.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel2 = FMR.personnel;
                                    tmpGameName2 = FMR.gameName;
                                    gbRoom2.Enabled = true;
                                }
                                else if (tmp_roomNum == 3)
                                {
                                    lbRoomName3.Text = FMR.roomName;
                                    lbPersonnel3.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail3.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail3.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail3.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail3.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel3 = FMR.personnel;
                                    tmpGameName3 = FMR.gameName;
                                    gbRoom3.Enabled = true;
                                }
                                else if (tmp_roomNum == 4)
                                {
                                    lbRoomName4.Text = FMR.roomName;
                                    lbPersonnel4.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail4.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail4.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail4.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail4.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel4 = FMR.personnel;
                                    tmpGameName4 = FMR.gameName;
                                    gbRoom4.Enabled = true;
                                }
                                else if (tmp_roomNum == 5)
                                {
                                    lbRoomName5.Text = FMR.roomName;
                                    lbPersonnel5.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail5.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail5.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail5.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail5.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel5 = FMR.personnel;
                                    tmpGameName5 = FMR.gameName;
                                    gbRoom5.Enabled = true;
                                }
                                else if (tmp_roomNum == 6)
                                {
                                    lbRoomName6.Text = FMR.roomName;
                                    lbPersonnel6.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail6.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail6.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail6.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail6.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel6 = FMR.personnel;
                                    tmpGameName6 = FMR.gameName;
                                    gbRoom6.Enabled = true;
                                }
                                else if (tmp_roomNum == 7)
                                {
                                    lbRoomName7.Text = FMR.roomName;
                                    lbPersonnel7.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail7.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail7.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail7.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail7.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel7 = FMR.personnel;
                                    tmpGameName7 = FMR.gameName;
                                    gbRoom7.Enabled = true;
                                }
                                else if (tmp_roomNum == 8)
                                {
                                    lbRoomName8.Text = FMR.roomName;
                                    lbPersonnel8.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail8.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail8.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail8.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail8.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel8 = FMR.personnel;
                                    tmpGameName8 = FMR.gameName;
                                    gbRoom8.Enabled = true;
                                }
                                else if (tmp_roomNum == 9)
                                {
                                    lbRoomName9.Text = FMR.roomName;
                                    lbPersonnel9.Text = "0/" + FMR.personnel;
                                    if (FMR.gameName == "총을 든 마리오와 친구들")
                                    {
                                        pbThumbNail9.Load("https://www.ssbwiki.com/images/2/24/Mario_AAA_Combo_SSBM.gif");
                                        pbThumbNail9.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else if (FMR.gameName == "우주에서 살아남기")
                                    {
                                        pbThumbNail9.Load("https://jamesdavidstone.files.wordpress.com/2016/10/game.gif");
                                        pbThumbNail9.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    tmpPersonnel9 = FMR.personnel;
                                    tmpGameName9 = FMR.gameName;
                                    gbRoom9.Enabled = true;
                                }
                                tmpIp = tbIp.Text;
                                tbRoomNum.Text = null;
                                tbIp.Text = null;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region 방 입장하기
        private void tbEnter_Click(object sender, EventArgs e)
        {
            /*
            int tmp_roomNum = int.Parse(tbRoomNum.Text);
            if (tmp_roomNum >= 1 && tmp_roomNum <= 9)
            {
                this.Hide();

                RoomNumber = tmp_roomNum;
                switch (RoomNumber)
                {
                    case 1:
                        if (lbPersonnel1.Text == "2/2" || lbPersonnel1.Text == "3/3")
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName1.Text, tmpPersonnel1, tmpGameName1);
                        }
                        break;
                    case 2:
                        if (lbPersonnel2.Text == "2/2" || lbPersonnel2.Text == "3/3")
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName2.Text, tmpPersonnel2, tmpGameName2);
                        }
                        break;
                    case 3:
                        if (lbPersonnel3.Text == "2/2" || lbPersonnel3.Text == "3/3") // 방 제한인원 꽉 찼으면
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName3.Text, tmpPersonnel3, tmpGameName3);
                        }
                        break;
                    case 4:
                        if (lbPersonnel4.Text == "2/2" || lbPersonnel4.Text == "3/3") // 방 제한인원 꽉 찼으면
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName4.Text, tmpPersonnel4, tmpGameName4);
                        }
                        break;
                    case 5:
                        if (lbPersonnel5.Text == "2/2" || lbPersonnel5.Text == "3/3") // 방 제한인원 꽉 찼으면
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName5.Text, tmpPersonnel5, tmpGameName5);
                        }
                        break;
                    case 6:
                        if (lbPersonnel6.Text == "2/2" || lbPersonnel6.Text == "3/3") // 방 제한인원 꽉 찼으면
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName6.Text, tmpPersonnel6, tmpGameName6);
                        }
                        break;
                    case 7:
                        if (lbPersonnel7.Text == "2/2" || lbPersonnel7.Text == "3/3") // 방 제한인원 꽉 찼으면
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName7.Text, tmpPersonnel7, tmpGameName7);
                        }
                        break;
                    case 8:
                        if (lbPersonnel8.Text == "2/2" || lbPersonnel8.Text == "3/3") // 방 제한인원 꽉 찼으면
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName8.Text, tmpPersonnel8, tmpGameName8);
                        }
                        break;
                    case 9:
                        if (lbPersonnel9.Text == "2/2" || lbPersonnel9.Text == "3/3") // 방 제한인원 꽉 찼으면
                        {
                            MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
                        }
                        else
                        {
                            froom = new FRoom();
                            froom.RoomInfo(lbRoomName9.Text, tmpPersonnel9, tmpGameName9);
                        }
                        break;
                    default:
                        break;
                }
                this.Hide();
                
                
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tbIp.Text, RoomNumber);
                froom.Show();

                tbRoomNum.Text = null;
                tbIp.Text = null;
            }
            else if (tbRoomNum.Text == null)
            {
                MessageBox.Show("방 번호를 입력해주세요", "예외 발생");
            }
            else if (tbIp.Text == null)
            {
                MessageBox.Show("IP 주소를 입력해주세요", "예외 발생");
            }
            else
            {
                MessageBox.Show("방 번호를 다시 입력해주세요", "예외 발생");
                tbRoomNum.Text = null;
            }
            */
        }
        

        private void btnEnter1_Click(object sender, EventArgs e)
        {
            //if (lbPersonnel1.Text == "2/2" || lbPersonnel1.Text == "3/3") // 방 제한인원 꽉 찼으면
            //{
            //    MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            //}
            //else // 아니면 정상적 입장
            {
                //this.Hide();

                RoomNumber = 5;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tbIp.Text, RoomNumber);
                FMWG = new FMarioWithGun();
                froom.GameDeliver(FMWG);
                FMWG.ReturnCurrentName(man2.manInfo["nickname"]);
                //froom.RoomInfo(lbRoomName1.Text, tmpPersonnel1, tmpGameName1);
                //froom.Show();
                FMWG.ShowDialog();
            }
        }

        private void btnEnter2_Click(object sender, EventArgs e)
        {
            //if (lbPersonnel2.Text == "2/2" || lbPersonnel2.Text == "3/3") // 방 제한인원 꽉 찼으면
            //{
            //    MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            //}
            //else // 아니면 정상적 입장
            {
                this.Hide();

                RoomNumber = 2;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tmpIp, RoomNumber);
                //froom.RoomInfo(lbRoomName2.Text, tmpPersonnel2, tmpGameName2);
                FFS = new FFlySky();
                froom.GameDeliver(FFS);
                //froom.Show();
                FFS.ShowDialog();
            }
        }

        private void btnEnter3_Click(object sender, EventArgs e)
        {
            //if (lbPersonnel3.Text == "2/2" || lbPersonnel3.Text == "3/3") // 방 제한인원 꽉 찼으면
            //{
            //    MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            //}
            //else // 아니면 정상적 입장
            {
                this.Hide();

                RoomNumber = 3;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tmpIp, RoomNumber);
                //froom.RoomInfo(lbRoomName3.Text, tmpPersonnel3, tmpGameName3);
                FSS = new FSurviveSpace();
                froom.GameDeliver(FSS);
                //froom.Show();
                FSS.ShowDialog();
            }
        }

        private void btnEnter4_Click(object sender, EventArgs e)
        {
            //if (lbPersonnel4.Text == "2/2" || lbPersonnel4.Text == "3/3") // 방 제한인원 꽉 찼으면
            //{
            //    MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            //}
            //else // 아니면 정상적 입장
            {
                this.Hide();

                RoomNumber = 4;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tmpIp, RoomNumber);
                //froom.RoomInfo(lbRoomName4.Text, tmpPersonnel4, tmpGameName4);
                FPP = new FPingPong();
                //froom.Show();
                FPP.ShowDialog();
            }
        }

        private void btnEnter5_Click(object sender, EventArgs e)
        {
            //if (lbPersonnel5.Text == "2/2" || lbPersonnel5.Text == "3/3") // 방 제한인원 꽉 찼으면
            //{
            //    MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            //}
            //else // 아니면 정상적 입장
            {
                this.Hide();

                RoomNumber = 1;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tbIp.Text, RoomNumber);
                //froom.RoomInfo(lbRoomName5.Text, tmpPersonnel5, tmpGameName5);
                froom.ShowDialog();
            }
        }

        

        private void btnEnter6_Click(object sender, EventArgs e)
        {
            if (lbPersonnel6.Text == "2/2" || lbPersonnel6.Text == "3/3") // 방 제한인원 꽉 찼으면
            {
                MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            }
            else // 아니면 정상적 입장
            {
                this.Hide();

                RoomNumber = 6;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tmpIp, RoomNumber);
                froom.RoomInfo(lbRoomName6.Text, tmpPersonnel6, tmpGameName6);
                froom.Show();
            }
        }

        private void btnEnter7_Click(object sender, EventArgs e)
        {
            if (lbPersonnel7.Text == "2/2" || lbPersonnel7.Text == "3/3") // 방 제한인원 꽉 찼으면
            {
                MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            }
            else // 아니면 정상적 입장
            {
                this.Hide();

                RoomNumber = 7;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tmpIp, RoomNumber);
                froom.RoomInfo(lbRoomName7.Text, tmpPersonnel7, tmpGameName7);
                froom.Show();
            }
        }

        private void btnEnter8_Click(object sender, EventArgs e)
        {
            if (lbPersonnel8.Text == "2/2" || lbPersonnel8.Text == "3/3") // 방 제한인원 꽉 찼으면
            {
                MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            }
            else // 아니면 정상적 입장
            {
                this.Hide();

                RoomNumber = 8;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tmpIp, RoomNumber);
                froom.RoomInfo(lbRoomName8.Text, tmpPersonnel8, tmpGameName8);
                froom.Show();
            }
        }

        private void btnEnter9_Click(object sender, EventArgs e)
        {
            if (lbPersonnel9.Text == "2/2" || lbPersonnel9.Text == "3/3") // 방 제한인원 꽉 찼으면
            {
                MessageBox.Show("방이 꽉 찼습니다", "정원 초과");
            }
            else // 아니면 정상적 입장
            {
                this.Hide();

                RoomNumber = 9;
                froom = new FRoom();
                froom.ClientName(man2.manInfo["nickname"]);
                froom.ConnectManager(man2.manInfo["nickname"], tmpIp, RoomNumber);
                froom.RoomInfo(lbRoomName9.Text, tmpPersonnel9, tmpGameName9);
                froom.Show();
            }
        }
        #endregion

        //클릭하면 기존Text 사라짐
        private void tbIp_Click(object sender, EventArgs e)
        {
            tbIp.Text = null;
        }
        private void tbRoomNum_Click(object sender, EventArgs e)
        {
            tbRoomNum.Text = null;
        }

        // 회원정보 더보기
        private void btnMore_Click(object sender, EventArgs e)
        {
            FMyInfo fmyinfo = new FMyInfo(man2);
            fmyinfo.Show();
        }

        private void pbPlayAlone_MouseHover(object sender, EventArgs e)
        {
            //pbQuestion.Location = new Point(161, 537);
            pbQuestion.Size = new Size(117, 106);
            pbPlayAlone.Visible = true;
            lbPlayAlone.Visible = true;
            pbRanking.Visible = true;
            lbRanking.Visible = true;
            pbSettings.Visible = true;
            lbSettings.Visible = true;
        }

    }
}
