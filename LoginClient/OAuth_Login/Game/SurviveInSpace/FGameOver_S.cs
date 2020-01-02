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
    public partial class FGameOver_S : Form
    {
        FSurviveSpace form1 = new FSurviveSpace();
        List<int> score = new List<int>();
        List<String> name = new List<string>();
        int sunwi = 0;
        int tmp;
        int CurrentScore;
        string tmp2;
        List<int> line = new List<int>();
        List<String> lineName = new List<string>();

        public FGameOver_S()
        {
            InitializeComponent();
        }
        
        public void setScore(int currentScore)
        {
            scoreLabel.Text = "점수 : " + currentScore;
            CurrentScore = currentScore;
        }

        public void FileWrite()
        {
            score.Add(CurrentScore);
            //name.Add(textBox1.Text);

            using (StreamWriter writer = File.AppendText("abc.txt"))
            {
                for (int i = 0; i < score.Count; i++)
                {
                    writer.Write(score[i] + "\r\n");
                }
                writer.Close();
            }

            using (StreamWriter writeName = File.AppendText("names.txt"))
            {
                for (int j = 0; j < name.Count; j++)
                {
                    writeName.Write(name[j] + "\r\n");
                }
                writeName.Close();
            }
        }

        public void Reader()
        {
            string liner;
            int count = 0;
            string linerName;
            int countName = 0;

            using (StreamReader sr = new StreamReader("abc.txt"))
            {
                while ((liner = sr.ReadLine()) != null)
                {
                    count++;
                    line.Add(int.Parse(liner));
                }
                sr.Close();
            }


            using (StreamReader srName = new StreamReader("names.txt"))
            {
                while ((linerName = srName.ReadLine()) != null)
                {
                    countName++;
                    lineName.Add(linerName);
                }
                srName.Close();
            }
        }
        
        public void SetTable()
        {
            for (int i = 0; i < line.Count; i++)
            {
                for (int j = 0; j < line.Count; j++)
                {
                    if (line[j] < line[i])
                    {
                        tmp = line[j];
                        line[j] = line[i];
                        line[i] = tmp;

                        tmp2 = lineName[j];
                        lineName[j] = lineName[i];
                        lineName[i] = tmp2;
                    }
                }
            }            

            using (StreamWriter writer = new StreamWriter("score.txt"))
            {
                for (int count = 0; count < line.Count; count++)
                {
                    sunwi++;
                    writer.Write(sunwi + "\t" + line[count] + "\t" + lineName[count] + "\r\n");

                }
                writer.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (textBox1.Text.Equals(""))
            {
               // MessageBox.Show("이름을 입력하세요!");
            }
            //else
            {
                FileWrite();
                Reader();
                SetTable();

                FRecord_S form3 = new FRecord_S();
                form3.ShowDialog();

                this.Close();
            }
        }
    }
}
