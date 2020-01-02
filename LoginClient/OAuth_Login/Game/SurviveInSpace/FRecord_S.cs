using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth_Login.Game.SurviveInSpace
{
    public partial class FRecord_S : Form
    {
        string linerscore;
        int countscore = 0;

        public FRecord_S()
        {
            InitializeComponent();

            listBox1.Items.Add("순위" + "\t" + "점수" + "\t" + "이름");
            listBox1.Items.Add("");

            using (StreamReader sr = new StreamReader("score.txt"))
            {
                while ((linerscore = sr.ReadLine()) != null)
                {
                    countscore++;
                    listBox1.Items.Add(linerscore);
                }
                sr.Close();
            }
        }
    }
}
