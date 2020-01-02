namespace LoginClient
{
    partial class FMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.webAuth = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtAuthenticationResult = new System.Windows.Forms.TextBox();
            this.txtRequestURL = new System.Windows.Forms.TextBox();
            this.labTitleAuthenticationResult = new System.Windows.Forms.Label();
            this.labTitleRequestURL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // webAuth
            // 
            this.webAuth.ContextMenuStrip = this.contextMenuStrip1;
            this.webAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webAuth.Location = new System.Drawing.Point(0, 0);
            this.webAuth.MinimumSize = new System.Drawing.Size(20, 20);
            this.webAuth.Name = "webAuth";
            this.webAuth.ScrollBarsEnabled = false;
            this.webAuth.Size = new System.Drawing.Size(1366, 745);
            this.webAuth.TabIndex = 5;
            this.webAuth.Visible = false;
            this.webAuth.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webAuth_PreviewKeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(30, 529);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(148, 36);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Visible = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(30, 498);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(66, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "멤버 조회";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtAuthenticationResult
            // 
            this.txtAuthenticationResult.Location = new System.Drawing.Point(133, 51);
            this.txtAuthenticationResult.Multiline = true;
            this.txtAuthenticationResult.Name = "txtAuthenticationResult";
            this.txtAuthenticationResult.ReadOnly = true;
            this.txtAuthenticationResult.Size = new System.Drawing.Size(1044, 63);
            this.txtAuthenticationResult.TabIndex = 2;
            this.txtAuthenticationResult.Visible = false;
            // 
            // txtRequestURL
            // 
            this.txtRequestURL.Location = new System.Drawing.Point(133, 24);
            this.txtRequestURL.Name = "txtRequestURL";
            this.txtRequestURL.ReadOnly = true;
            this.txtRequestURL.Size = new System.Drawing.Size(1044, 21);
            this.txtRequestURL.TabIndex = 2;
            this.txtRequestURL.Visible = false;
            // 
            // labTitleAuthenticationResult
            // 
            this.labTitleAuthenticationResult.ForeColor = System.Drawing.Color.White;
            this.labTitleAuthenticationResult.Location = new System.Drawing.Point(7, 58);
            this.labTitleAuthenticationResult.Name = "labTitleAuthenticationResult";
            this.labTitleAuthenticationResult.Size = new System.Drawing.Size(120, 25);
            this.labTitleAuthenticationResult.TabIndex = 0;
            this.labTitleAuthenticationResult.Text = "Authentication Result";
            this.labTitleAuthenticationResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitleAuthenticationResult.Visible = false;
            // 
            // labTitleRequestURL
            // 
            this.labTitleRequestURL.ForeColor = System.Drawing.Color.White;
            this.labTitleRequestURL.Location = new System.Drawing.Point(7, 21);
            this.labTitleRequestURL.Name = "labTitleRequestURL";
            this.labTitleRequestURL.Size = new System.Drawing.Size(120, 25);
            this.labTitleRequestURL.TabIndex = 0;
            this.labTitleRequestURL.Text = "Request URL";
            this.labTitleRequestURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitleRequestURL.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAuthenticationResult);
            this.groupBox1.Controls.Add(this.txtRequestURL);
            this.groupBox1.Controls.Add(this.labTitleAuthenticationResult);
            this.groupBox1.Controls.Add(this.labTitleRequestURL);
            this.groupBox1.Location = new System.Drawing.Point(51, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 123);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(631, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "입장해주세요";
            this.label4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox3.Image = global::OAuth_Login.Properties.Resources.GAMECUBE;
            this.pictureBox3.Location = new System.Drawing.Point(324, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(717, 403);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Press Start 2P", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(362, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 67);
            this.label2.TabIndex = 12;
            this.label2.Text = "GAME CUBE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Press Start 2P", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome to";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 745);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Press Start 2P", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(511, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "PRESS START";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Image = global::OAuth_Login.Properties.Resources.naver_login;
            this.btnLogin.Location = new System.Drawing.Point(528, 671);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(309, 65);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogin.TabIndex = 21;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.webAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FMain";
            this.Text = "GAME CUBE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webAuth;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtAuthenticationResult;
        private System.Windows.Forms.TextBox txtRequestURL;
        private System.Windows.Forms.Label labTitleAuthenticationResult;
        private System.Windows.Forms.Label labTitleRequestURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnLogin;
    }
}

