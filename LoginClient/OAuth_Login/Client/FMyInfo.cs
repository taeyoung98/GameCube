using LoginClient;
using LoginClient.Client;
using LoginClient.OAuth;
using OAuth_Login.Login.OAuth.Naver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth_Login.Client
{
    public partial class FMyInfo : Form
    {
        Man man3 = new Man();

        public FMyInfo(Man man)
        {
            InitializeComponent();
            man3 = man;

            lbName.Text = "Name : " + man3.manInfo["name"];
            lbNick.Text = "Nick : " + man3.manInfo["nickname"];
            lbEmail.Text = "Email : " + man3.manInfo["email"];
            lbBirth.Text = "Birth : " + man3.manInfo["birthday"];
            lbAge.Text = "Age : " + man3.manInfo["age"];
            lbGender.Text = "Gender : " + man3.manInfo["gender"];
        }
    }
}
