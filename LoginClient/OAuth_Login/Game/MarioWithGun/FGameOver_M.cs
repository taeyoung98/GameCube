using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OAuth_Login.Game.MarioWithGun
{
    public partial class FGameOver_M : Form
    {
        FRecord_M FMG = new FRecord_M();
        CRanking rank = new CRanking();
        int CurrentScore;

        public FGameOver_M()
        {
            InitializeComponent();
        }

        public void ReturnScore(int s)
        {
            rank.FileWrite(s, "score.txt");
            rank.FileReader("score.txt");
            rank.setScore("readscore.txt");
            label2.Text = Convert.ToString(s);

        }

        public void ReturnName(string n)
        {
            rank.nameFileWriter(n, "name.txt");
            rank.nameFileReader("name.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMG.SetTable("readscore.txt");
            this.Close();
            FMG.ShowDialog();
        }
    }
}
