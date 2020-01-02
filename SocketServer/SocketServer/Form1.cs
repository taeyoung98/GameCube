using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace SocketServer
{
    public partial class Form1 : Form
    {
        SocketManager Socket = new SocketManager(5000, 1111);
        SocketManager Socket2 = new SocketManager(5000, 2222);
        SocketManager Socket3 = new SocketManager(5000, 3333);
        public Form1()
        {
            InitializeComponent();
            // <1>번째 방
            Socket.HostLost += Socket_HostLost;
            Socket.HostRefused += Socket_HostRefused;
            Socket.ReceivedMessage += Socket_ReceivedMessage;

            Socket.Port = 1111; // Convert.ToInt32(txt_port.Text);
            Socket.Host();
            Socket.StartLisenClients();

            //<2>번째 방
            Socket2.HostLost += Socket2_HostLost;
            Socket2.HostRefused += Socket2_HostRefused;
            Socket2.ReceivedMessage += Socket2_ReceivedMessage;

            Socket2.Port = 2222; //Convert.ToInt32(txt_port2.Text);
            Socket2.Host();
            Socket2.StartLisenClients();

            //<3>번째 방
            Socket3.HostLost += Socket3_HostLost;
            Socket3.HostRefused += Socket3_HostRefused;
            Socket3.ReceivedMessage += Socket3_ReceivedMessage;

            Socket3.Port = 3333; // Convert.ToInt32(txt_port3.Text);
            Socket3.Host();
            Socket3.StartLisenClients();
        }

        // <1>번째 방
        void EnterLog(string ms)
        {
            richTextBox1.Text += ms + "\n";
        }

        private void Socket_ReceivedMessage(string Message, System.Net.Sockets.TcpClient FromClient)
        {
            EnterLog(Message);
        }

        private void Socket_HostRefused()
        {
            EnterLog("server have been refused you...");
        }

        private void Socket_HostLost()
        {
            EnterLog("Losed Host...");
        }


        // <2>번째 방
        void EnterLog2(string ms)
        {
            richTextBox2.Text += ms + "\n";
        }

        private void Socket2_ReceivedMessage(string Message, System.Net.Sockets.TcpClient FromClient)
        {
            EnterLog2(Message);
        }

        private void Socket2_HostRefused()
        {
            EnterLog2("server have been refused you...");
        }

        private void Socket2_HostLost()
        {
            EnterLog2("Losed Host...");
        }

        // <3>번째  방
        void EnterLog3(string ms)
        {
            richTextBox3.Text += ms + "\n";
        }

        private void Socket3_ReceivedMessage(string Message, System.Net.Sockets.TcpClient FromClient)
        {
            EnterLog3(Message);
        }

        private void Socket3_HostRefused()
        {
            EnterLog3("server have been refused you...");
        }

        private void Socket3_HostLost()
        {
            EnterLog3("Losed Host...");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Socket.Stop(); //Don't Forget to call Socket.Stop() before exit... if you don't the app doent close all. And server/client stays open
        }


    }
}
