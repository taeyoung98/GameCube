namespace LoginClient.Client
{
    partial class FRoom
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRoom));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbHost = new System.Windows.Forms.CheckBox();
            this.rtbChatting = new System.Windows.Forms.RichTextBox();
            this.rtbChatInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(233, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 25);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "나가기";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Black;
            this.lbName.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(118, 84);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(109, 12);
            this.lbName.TabIndex = 55;
            this.lbName.Text = "NickName";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.BackColor = System.Drawing.Color.Black;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.ForeColor = System.Drawing.Color.Red;
            this.btnDisconnect.Location = new System.Drawing.Point(154, 14);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(73, 25);
            this.btnDisconnect.TabIndex = 54;
            this.btnDisconnect.Text = "접속 종료";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btn_dissconnect_Click);
            // 
            // cbHost
            // 
            this.cbHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHost.AutoSize = true;
            this.cbHost.BackColor = System.Drawing.Color.Black;
            this.cbHost.ForeColor = System.Drawing.Color.White;
            this.cbHost.Location = new System.Drawing.Point(35, 650);
            this.cbHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHost.Name = "cbHost";
            this.cbHost.Size = new System.Drawing.Size(79, 16);
            this.cbHost.TabIndex = 53;
            this.cbHost.Text = "Only Host";
            this.cbHost.UseVisualStyleBackColor = false;
            // 
            // rtbChatting
            // 
            this.rtbChatting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChatting.BackColor = System.Drawing.Color.Black;
            this.rtbChatting.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbChatting.ForeColor = System.Drawing.Color.Chartreuse;
            this.rtbChatting.Location = new System.Drawing.Point(35, 327);
            this.rtbChatting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbChatting.Name = "rtbChatting";
            this.rtbChatting.ReadOnly = true;
            this.rtbChatting.Size = new System.Drawing.Size(271, 282);
            this.rtbChatting.TabIndex = 52;
            this.rtbChatting.Text = "";
            // 
            // rtbChatInput
            // 
            this.rtbChatInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChatInput.BackColor = System.Drawing.Color.Black;
            this.rtbChatInput.ForeColor = System.Drawing.Color.White;
            this.rtbChatInput.Location = new System.Drawing.Point(35, 607);
            this.rtbChatInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbChatInput.Name = "rtbChatInput";
            this.rtbChatInput.Size = new System.Drawing.Size(271, 21);
            this.rtbChatInput.TabIndex = 51;
            this.rtbChatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbChatInput_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(120, 643);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(186, 28);
            this.btnSend.TabIndex = 50;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btn_send_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::OAuth_Login.Properties.Resources.giphy__28_;
            this.pictureBox2.Location = new System.Drawing.Point(35, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OAuth_Login.Properties.Resources.giphy__10_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 685);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 685);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.cbHost);
            this.Controls.Add(this.rtbChatting);
            this.Controls.Add(this.rtbChatInput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRoom";
            this.Text = "채팅방";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.CheckBox cbHost;
        public System.Windows.Forms.RichTextBox rtbChatting;
        private System.Windows.Forms.TextBox rtbChatInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}