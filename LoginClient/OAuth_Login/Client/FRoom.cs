using OAuth_Login.Game.FlyInSky;
using OAuth_Login.Game.MarioWithGun;
using OAuth_Login.Game.PingPong;
using OAuth_Login.Game.SurviveInSpace;
using SocketClient;
using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace LoginClient.Client
{
    public partial class FRoom : Form
    {
        SocketManager Socket = new SocketManager(2048, 0000);
        FClient EnterRoom;
        FMarioWithGun FMWG;
        FFlySky FFS;
        FSurviveSpace FSS;
        FPingPong FPP;

        public FRoom()
        {
            InitializeComponent();

            contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip1.Items.Add("화면종료(Esc)");

            Socket.ClientDissconnected += Socket_ClientDissconnected;
            Socket.ConnectedServer += Socket_ConnectedServer;
            Socket.HostLost += Socket_HostLost;
            Socket.HostRefused += Socket_HostRefused;
            Socket.ReceivedMessage += Socket_ReceivedMessage;
            
        }
        public void RoomInfo(string roomName, int personnel, string gameName)
        {
            //lbRoomName.Text = "방제 : " + roomName;
            //lbPersonnel.Text = "정원 : " + personnel + "명";
            //lbGame.Text = "게임 : " + gameName;
        }

        public void ClientName(string name)
        {
            lbName.Text =  name;
        }
        public void EnterLog(string ms)
        {
            rtbChatting.Text += ms + "\n";
        }
        private void Socket_ReceivedMessage(string Message, TcpClient FromClient)
        {
            EnterLog(Message);
        }
        private void Socket_HostRefused()
        {
            EnterLog("server have been refused you...");
        }
        private void Socket_HostLost()
        {
            EnterLog("Losed Host...");
        }
        private void Socket_ConnectedServer()
        {
            EnterLog("You are connected to server");
        }
        private void Socket_ClientDissconnected(System.Net.Sockets.TcpClient Client)
        {
            EnterLog("A client disssconnected");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Socket.Stop(); //Don't Forget to call Socket.Stop() before exit... if you don't the app doent close all. And server/client stays open
        }


        private void btn_dissconnect_Click(object sender, EventArgs e)
        {
            bool hostCheck = false;
            Socket.SendMessageToHost(lbName.Text + "로그아웃");
            if (hostCheck == true)
            {
                EnterLog(lbName.Text + "로그아웃");
            }
            Socket.Dissconnect();
            this.Close();
        }

        public void ConnectManager(string name, string ip, int roomNumber)
        {
            if (roomNumber == 1)
            {
                Socket.Port = 1111; //Convert.ToInt32(EnterRoom. txt_port.Text);
            }
            if (roomNumber == 2)
            {
                Socket.Port = 2222; //Convert.ToInt32(EnterRoom. txt_port.Text);
            }
            if (roomNumber == 3)
            {
                Socket.Port = 3333; //Convert.ToInt32(EnterRoom. txt_port.Text);
            }
            if (roomNumber==4)
            {
                Socket.Port = 4444;
            }
            if (roomNumber == 5)
            {
                Socket.Port = 5555;
            }
            if (roomNumber == 6)
            {
                Socket.Port = 6666;
            }
            if (roomNumber == 7)
            {
                Socket.Port = 77777;
            }
            if (roomNumber == 8)
            {
                Socket.Port = 8888;
            }
            if (roomNumber == 9)
            {
                Socket.Port = 9999;
            }
            Socket.Connect(ip);
            bool hostCheck = false;
            Socket.SendMessageToHost(name + "입장");
            if (hostCheck == true)
            {
                EnterLog(name + "입장");
            }
        }

        public void GameDeliver(FMarioWithGun form)
        {
            FMWG = form;
        }
        public void GameDeliver(FFlySky form)
        {
            FFS = form;
        }
        public void GameDeliver(FSurviveSpace form)
        {
            FSS = form;
        }

        private void btn_send_Click_1(object sender, EventArgs e)
        {
            if (Socket._isHost)
            {
                Socket.SendMessageToAllClients(rtbChatInput + ": " + rtbChatInput.Text);
                //if you are host, you have to send messa   ge to all clients when you are sending.
            }
            else
            {
                if (cbHost.Checked)
                {
                    Socket.SendMessageToHost(lbName.Text + ": " + rtbChatInput.Text);
                }
                else
                {
                    Socket.SendMessageToHostAndAllClients(lbName.Text + ": " + rtbChatInput.Text);
                }
                //But if you are Client, you have 2 option: Send message to host or Send message to host and other clients...
            }
            EnterLog(lbName.Text + ": " + rtbChatInput.Text);
            rtbChatInput.Text = "";
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            FMWG.BringToFront();

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            FMWG.BringToFront();

            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(e.Location);
                contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(PopupMenu3_ItemClicked);
            }
        }
        private void PopupMenu3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "화면종료(Esc)")
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            bool hostCheck = false;
            Socket.SendMessageToHost(lbName.Text + "퇴장");
            if (hostCheck == true)
            {
                EnterLog(lbName.Text + "퇴장");
            }
            this.Close();
        }

        private void rtbChatInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (Socket._isHost)
                {
                    Socket.SendMessageToAllClients(rtbChatInput + ":" + rtbChatInput.Text);
                    //if you are host, you have to send messa   ge to all clients when you are sending.
                }
                else
                {
                    if (cbHost.Checked)
                    {
                        Socket.SendMessageToHost(lbName.Text + ": " + rtbChatInput.Text);
                    }
                    else
                    {
                        Socket.SendMessageToHostAndAllClients(lbName.Text + ": " + rtbChatInput.Text);
                    }
                    //But if you are Client, you have 2 option: Send message to host or Send message to host and other clients...
                }
                EnterLog(lbName.Text + ":" + rtbChatInput.Text);
                rtbChatInput.Text = "";
            }
        }

        private void splitContainer1_Click(object sender, EventArgs e)
        {
            FMWG.BringToFront();
            FFS.BringToFront();
        }

        private void splitContainer1_KeyDown(object sender, KeyEventArgs e)
        {
            FMWG.BringToFront();
            FFS.BringToFront();
        }
    }
}
