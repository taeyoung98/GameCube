using LoginClient.Client;
using LoginClient.OAuth;
using OAuth_Login;
using OAuth_Login.Login.OAuth.Naver;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginClient
{
    public partial class FMain : Form
    {
        private COAuth_Naver m_Naver;
        FClient form2;
        private static Man man1;
        public static Man Man1
        {
            get { return man1; }
            set { man1 = value; }
        }
        int second = 0;
        ConnectDB connectDB;

        // esc키/우클릭 -> 폼 꺼짐
        // 네이버로그인버튼 -> 로그인 -> 로딩창 뜨면 스페이스바 -> PRESS START 누르면 폼 꺼짐
        public FMain()
        {
            InitializeComponent();
            webAuth.Visible = false; // 웹뷰 안보이게
            this.FormBorderStyle = FormBorderStyle.None; // 테두리 삭제
            this.WindowState = FormWindowState.Maximized; // 전체화면
            contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip1.Items.Add("화면종료(Esc)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.m_Naver = new COAuth_Naver(this.webAuth);
            this.m_Naver.OnOAuth_RequestURL_Create += OAuth_OnOAuth_RequestURL_Create;
            this.m_Naver.OnOAuth_Authentication_Result += OAuth_OnOAuth_Authentication_Result;
            this.m_Naver.OndgOAuth_Output += OAuth_OndgOAuth_Output;
        }
        private void OAuth_OnOAuth_RequestURL_Create(string sRequestURL)
        {
            this.txtRequestURL.Text = sRequestURL;
        }
        private void OAuth_OnOAuth_Authentication_Result(string sResultString)
        {
            this.txtAuthenticationResult.Text = sResultString;
        }
        private void OAuth_OndgOAuth_Output(string sOutputString)
        {
            this.label4.Text = sOutputString + "님이 입장하였습니다";
        }

        private void btnLogin_Click(object sender, EventArgs e) // 네이버로그인 버튼
        {
            this.m_Naver.StartAuth();
            webAuth.BringToFront();
            webAuth.Visible = true; // 웹뷰 보이게
        }

        private void btnTest_Click(object sender, EventArgs e) // 멤버조회 버튼
        {
            this.m_Naver.ReponseGet();
        }

        private void webAuth_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                webAuth.Visible = false; // 웹뷰 안보이게
                btnLogin.Visible = false; // 네이버로그인 안보이게
                label5.Visible = true; // 프레스스타트 보이게
                label4.Visible = true;
                timer1.Start();
                this.m_Naver.ReponseGet();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e) // PRESS START
        {
            timer1.Stop();
            this.Hide();
            
            Man1 = new Man(m_Naver.re1, m_Naver.re2, m_Naver.re3, m_Naver.re4, m_Naver.re5, m_Naver.re6);
            form2 = new FClient(Man1);
            form2.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second%2==0)
            {
                label5.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label5.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            }
        }
        
    }
}
