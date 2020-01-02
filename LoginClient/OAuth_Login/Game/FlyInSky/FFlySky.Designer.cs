namespace OAuth_Login.Game.FlyInSky
{
    partial class FFlySky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFlySky));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.마리오ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.루이지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.피치ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.쿠파ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.게임방법ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.순위보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.down = new System.Windows.Forms.Label();
            this.gamelogo = new System.Windows.Forms.PictureBox();
            this.trophy = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.height = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.background2 = new System.Windows.Forms.PictureBox();
            this.background1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamelogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(94, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterToolStripMenuItem,
            this.게임방법ToolStripMenuItem,
            this.순위보기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 402);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.마리오ToolStripMenuItem,
            this.루이지ToolStripMenuItem,
            this.피치ToolStripMenuItem,
            this.쿠파ToolStripMenuItem});
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.characterToolStripMenuItem.Text = "캐릭터 고르기";
            // 
            // 마리오ToolStripMenuItem
            // 
            this.마리오ToolStripMenuItem.Name = "마리오ToolStripMenuItem";
            this.마리오ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.마리오ToolStripMenuItem.Text = "마리오";
            this.마리오ToolStripMenuItem.Click += new System.EventHandler(this.회색ToolStripMenuItem_Click);
            // 
            // 루이지ToolStripMenuItem
            // 
            this.루이지ToolStripMenuItem.Name = "루이지ToolStripMenuItem";
            this.루이지ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.루이지ToolStripMenuItem.Text = "루이지";
            this.루이지ToolStripMenuItem.Click += new System.EventHandler(this.초록색ToolStripMenuItem_Click);
            // 
            // 피치ToolStripMenuItem
            // 
            this.피치ToolStripMenuItem.Name = "피치ToolStripMenuItem";
            this.피치ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.피치ToolStripMenuItem.Text = "피치";
            this.피치ToolStripMenuItem.Click += new System.EventHandler(this.빨간색ToolStripMenuItem_Click);
            // 
            // 쿠파ToolStripMenuItem
            // 
            this.쿠파ToolStripMenuItem.Name = "쿠파ToolStripMenuItem";
            this.쿠파ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.쿠파ToolStripMenuItem.Text = "쿠파";
            this.쿠파ToolStripMenuItem.Click += new System.EventHandler(this.노란색ToolStripMenuItem_Click);
            // 
            // 게임방법ToolStripMenuItem
            // 
            this.게임방법ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.게임방법ToolStripMenuItem.Name = "게임방법ToolStripMenuItem";
            this.게임방법ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.게임방법ToolStripMenuItem.Text = "게임방법";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(373, 22);
            this.ToolStripMenuItem.Text = "키보드 좌우를 이용하여 장애물들을 피하는 게임입니다.";
            // 
            // 순위보기ToolStripMenuItem
            // 
            this.순위보기ToolStripMenuItem.Name = "순위보기ToolStripMenuItem";
            this.순위보기ToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.순위보기ToolStripMenuItem.Text = "순위 보기";
            // 
            // countdown
            // 
            this.countdown.Interval = 800;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::OAuth_Login.Properties.Resources.RC;
            this.player.Location = new System.Drawing.Point(123, 275);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(35, 67);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 12;
            this.player.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImage = global::OAuth_Login.Properties.Resources.sk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.down);
            this.panel1.Controls.Add(this.gamelogo);
            this.panel1.Controls.Add(this.trophy);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.height);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.background2);
            this.panel1.Controls.Add(this.background1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 284);
            this.panel1.TabIndex = 4;
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.BackColor = System.Drawing.Color.Transparent;
            this.down.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.down.ForeColor = System.Drawing.Color.Black;
            this.down.Location = new System.Drawing.Point(128, 112);
            this.down.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(18, 20);
            this.down.TabIndex = 15;
            this.down.Text = "5";
            this.down.Visible = false;
            // 
            // gamelogo
            // 
            this.gamelogo.BackColor = System.Drawing.Color.Transparent;
            this.gamelogo.Image = global::OAuth_Login.Properties.Resources.flylogo1;
            this.gamelogo.Location = new System.Drawing.Point(33, 87);
            this.gamelogo.Margin = new System.Windows.Forms.Padding(2);
            this.gamelogo.Name = "gamelogo";
            this.gamelogo.Size = new System.Drawing.Size(211, 75);
            this.gamelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamelogo.TabIndex = 14;
            this.gamelogo.TabStop = false;
            // 
            // trophy
            // 
            this.trophy.Image = global::OAuth_Login.Properties.Resources.gold;
            this.trophy.Location = new System.Drawing.Point(73, 105);
            this.trophy.Margin = new System.Windows.Forms.Padding(2);
            this.trophy.Name = "trophy";
            this.trophy.Size = new System.Drawing.Size(132, 55);
            this.trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophy.TabIndex = 15;
            this.trophy.TabStop = false;
            this.trophy.Visible = false;
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::OAuth_Login.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(84, 239);
            this.explosion.Margin = new System.Windows.Forms.Padding(2);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(45, 43);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.explosion.TabIndex = 10;
            this.explosion.TabStop = false;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.BackColor = System.Drawing.Color.Transparent;
            this.height.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.height.ForeColor = System.Drawing.Color.DimGray;
            this.height.Location = new System.Drawing.Point(158, 7);
            this.height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(34, 25);
            this.height.TabIndex = 1;
            this.height.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(68, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height:";
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::OAuth_Login.Properties.Resources.chain;
            this.AI2.Location = new System.Drawing.Point(217, 174);
            this.AI2.Margin = new System.Windows.Forms.Padding(2);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(48, 57);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AI2.TabIndex = 8;
            this.AI2.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::OAuth_Login.Properties.Resources.boo;
            this.AI1.Location = new System.Drawing.Point(29, 33);
            this.AI1.Margin = new System.Windows.Forms.Padding(2);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(63, 59);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 7;
            this.AI1.TabStop = false;
            // 
            // background2
            // 
            this.background2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.background2.Image = global::OAuth_Login.Properties.Resources.sk;
            this.background2.Location = new System.Drawing.Point(-2, -148);
            this.background2.Margin = new System.Windows.Forms.Padding(2);
            this.background2.Name = "background2";
            this.background2.Size = new System.Drawing.Size(281, 472);
            this.background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background2.TabIndex = 6;
            this.background2.TabStop = false;
            // 
            // background1
            // 
            this.background1.Image = global::OAuth_Login.Properties.Resources.sk;
            this.background1.Location = new System.Drawing.Point(-1, -425);
            this.background1.Margin = new System.Windows.Forms.Padding(2);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(283, 421);
            this.background1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background1.TabIndex = 5;
            this.background1.TabStop = false;
            // 
            // FFlySky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(300, 426);
            this.Controls.Add(this.player);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FFlySky";
            this.Text = "theFlyGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FFlySky_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamelogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox background2;
        private System.Windows.Forms.PictureBox background1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 마리오ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 루이지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 피치ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 쿠파ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 게임방법ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 순위보기ToolStripMenuItem;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.PictureBox trophy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Label down;
        private System.Windows.Forms.PictureBox gamelogo;
    }
}