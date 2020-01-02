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

namespace OAuth_Login.Game.MarioWithGun
{
    public partial class FRecord_M : Form
    {
        string scoreLine;
        int r = 0;

        public FRecord_M()
        {
            InitializeComponent();
        }

        public void SetTable(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((scoreLine = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(scoreLine);
                    r++;
                }
                sr.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
