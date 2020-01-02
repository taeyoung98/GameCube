using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth_Login.Game
{
    class CRanking : IComparable
    {
        public string Name { get; set; }
        public int CurrentScore { get; set; }

        //int currentScore;

        List<int> Score = new List<int>();
        List<string> name = new List<string>();
        List<int> readScore = new List<int>();
        List<string> readname = new List<string>();

        public void FileWrite(int currentScore, string fileName)
        {
            Score.Add(currentScore);

            using (StreamWriter writer = File.AppendText(fileName))
            {
                for (int i = 0; i < Score.Count; i++)
                {
                    writer.Write(Score[i] + "\r\n");
                }
                writer.Close();
            }
        }
        public void nameFileWriter(string currentName, string fileName)
        {
            name.Add(currentName);

            using (StreamWriter writer2 = File.AppendText(fileName))
            {
                for (int i = 0; i < name.Count; i++)
                {
                    writer2.Write(name[i] + "\r\n");
                }
                writer2.Close();
            }
        }

        string line;
        int count = 0;
        public void FileReader(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                    readScore.Add(int.Parse(line));
                }
                reader.Close();
            }
        }

        string line2;
        int count2 = 0;
        public void nameFileReader(string fileName)
        {
            using (StreamReader reader2 = new StreamReader(fileName))
            {
                while ((line2 = reader2.ReadLine()) != null)
                {
                    count2++;
                    readname.Add(line2);

                }
                reader2.Close();
            }
        }

        public override string ToString()
        {
            return Name + " \t\t " + CurrentScore + "점";
        }

        public int CompareTo(object obj)
        {
            return CurrentScore.CompareTo((obj as CRanking).CurrentScore);
        }

        List<CRanking> list = new List<CRanking>();

        public void Launch()
        {
            for (int i = 0; i < readScore.Count; i++)
            {
                list.Add(new CRanking() { Name = readname[i], CurrentScore = readScore[i] });
            }
            list.Sort();
        }

        public void setScore(string fileName)
        {
            Launch();

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.Write(list[i] + "\r\n");
                }
            }
        }
    }
}
