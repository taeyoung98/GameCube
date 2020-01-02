using LoginClient.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth_Login.Client
{
    public partial class FMakeRoom : Form
    {
        public string roomName;
        public int personnel;
        public string gameName;
        public bool close = false;
        
        public FMakeRoom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("방제를 입력해주세요");
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("정원을 입력해주세요");
                }
                else
                {
                    if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("게임을 선택해주세요");
                    }
                    else
                    {
                        roomName = textBox1.Text;
                        personnel = int.Parse(textBox2.Text);
                        gameName = comboBox1.SelectedItem.ToString();
                        //MessageBox.Show("방제: " + roomName + "\n정원:" + personnel + "\n게임:" + gameName);
                        close = true;
                        Close();
                        
                    }
                }
            }
        }
    }
}
