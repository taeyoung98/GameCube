namespace OAuth_Login.Game.SurviveInSpace
{
    partial class FSurviveSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSurviveSpace));
            this.start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새게임ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.난이도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.하ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.순위보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.bestScore = new System.Windows.Forms.Label();
            this.currentScore = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Press Start 2P", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(169, 177);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(185, 54);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.Location = new System.Drawing.Point(169, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(185, 18);
            this.progressBar1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새게임ToolStripMenuItem,
            this.난이도ToolStripMenuItem,
            this.순위보기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // 새게임ToolStripMenuItem
            // 
            this.새게임ToolStripMenuItem.Name = "새게임ToolStripMenuItem";
            this.새게임ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.새게임ToolStripMenuItem.Text = "새게임";
            this.새게임ToolStripMenuItem.Click += new System.EventHandler(this.새게임ToolStripMenuItem_Click);
            // 
            // 난이도ToolStripMenuItem
            // 
            this.난이도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상ToolStripMenuItem,
            this.중ToolStripMenuItem,
            this.하ToolStripMenuItem});
            this.난이도ToolStripMenuItem.Name = "난이도ToolStripMenuItem";
            this.난이도ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.난이도ToolStripMenuItem.Text = "난이도";
            // 
            // 상ToolStripMenuItem
            // 
            this.상ToolStripMenuItem.Name = "상ToolStripMenuItem";
            this.상ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.상ToolStripMenuItem.Text = "상(공 9개)";
            this.상ToolStripMenuItem.Click += new System.EventHandler(this.상ToolStripMenuItem_Click);
            // 
            // 중ToolStripMenuItem
            // 
            this.중ToolStripMenuItem.Name = "중ToolStripMenuItem";
            this.중ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.중ToolStripMenuItem.Text = "중(공 7개)";
            this.중ToolStripMenuItem.Click += new System.EventHandler(this.중ToolStripMenuItem_Click);
            // 
            // 하ToolStripMenuItem
            // 
            this.하ToolStripMenuItem.Name = "하ToolStripMenuItem";
            this.하ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.하ToolStripMenuItem.Text = "하(공 5개)";
            this.하ToolStripMenuItem.Click += new System.EventHandler(this.하ToolStripMenuItem_Click);
            // 
            // 순위보기ToolStripMenuItem
            // 
            this.순위보기ToolStripMenuItem.Name = "순위보기ToolStripMenuItem";
            this.순위보기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.순위보기ToolStripMenuItem.Text = "순위보기";
            this.순위보기ToolStripMenuItem.Click += new System.EventHandler(this.순위보기ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.도움말ToolStripMenuItem.Text = "도움말";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitContainer1.Panel1.BackgroundImage = global::OAuth_Login.Properties.Resources.우주배경1;
            this.splitContainer1.Panel1.Controls.Add(this.start);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.bestScore);
            this.splitContainer1.Panel2.Controls.Add(this.currentScore);
            this.splitContainer1.Panel2.Controls.Add(this.score_label);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(765, 422);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Press Start 2P", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // bestScore
            // 
            this.bestScore.AutoSize = true;
            this.bestScore.Font = new System.Drawing.Font("Press Start 2P", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScore.ForeColor = System.Drawing.Color.White;
            this.bestScore.Location = new System.Drawing.Point(20, 40);
            this.bestScore.Name = "bestScore";
            this.bestScore.Size = new System.Drawing.Size(92, 27);
            this.bestScore.TabIndex = 3;
            this.bestScore.Text = "최고점수";
            // 
            // currentScore
            // 
            this.currentScore.AutoSize = true;
            this.currentScore.Font = new System.Drawing.Font("Press Start 2P", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScore.ForeColor = System.Drawing.Color.White;
            this.currentScore.Location = new System.Drawing.Point(23, 186);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(40, 27);
            this.currentScore.TabIndex = 2;
            this.currentScore.Text = "0";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Press Start 2P", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.Color.White;
            this.score_label.Location = new System.Drawing.Point(20, 148);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(92, 27);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "현재점수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // scoreTimer
            // 
            this.scoreTimer.Interval = 500;
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimer_Tick);
            // 
            // FSurviveSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(765, 422);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FSurviveSpace";
            this.Text = "우주에서 살아남기 대작전";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FSurviveSpace_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FSurviveSpace_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새게임ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 순위보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 난이도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 하ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bestScore;
    }
}