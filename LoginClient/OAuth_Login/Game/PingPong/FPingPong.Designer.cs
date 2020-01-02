namespace OAuth_Login.Game.PingPong
{
    partial class FPingPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPingPong));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player1label = new System.Windows.Forms.Label();
            this.player2label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // player1label
            // 
            this.player1label.AutoSize = true;
            this.player1label.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.player1label.ForeColor = System.Drawing.Color.Lime;
            this.player1label.Location = new System.Drawing.Point(73, 6);
            this.player1label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(39, 30);
            this.player1label.TabIndex = 3;
            this.player1label.Text = "00";
            // 
            // player2label
            // 
            this.player2label.AutoSize = true;
            this.player2label.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.player2label.ForeColor = System.Drawing.Color.Red;
            this.player2label.Location = new System.Drawing.Point(514, 6);
            this.player2label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2label.Name = "player2label";
            this.player2label.Size = new System.Drawing.Size(39, 30);
            this.player2label.TabIndex = 4;
            this.player2label.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(580, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPU";
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::OAuth_Login.Properties.Resources.그림2;
            this.player1.Location = new System.Drawing.Point(0, 121);
            this.player1.Margin = new System.Windows.Forms.Padding(2);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(76, 132);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = global::OAuth_Login.Properties.Resources.그림1;
            this.player2.Location = new System.Drawing.Point(565, 132);
            this.player2.Margin = new System.Windows.Forms.Padding(2);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(69, 121);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player2.TabIndex = 2;
            this.player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::OAuth_Login.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(311, 186);
            this.ball.Margin = new System.Windows.Forms.Padding(2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(19, 17);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OAuth_Login.Properties.Resources.ping;
            this.pictureBox1.Location = new System.Drawing.Point(83, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player2label);
            this.Controls.Add(this.player1label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FPingPong";
            this.Text = "Badminton";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player1label;
        private System.Windows.Forms.Label player2label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}