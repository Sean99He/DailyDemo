using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket serviceSocket;
        byte[] rByte = new byte[4096];
        private void Form1_Load(object sender, EventArgs e)
        {
            //int port = 6000;
            //string host = "127.0.0.1";
            //IPAddress ipAdress = IPAddress.Parse(host);
            //IPEndPoint ipEndPoint = new IPEndPoint(ipAdress, port);
            //Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //socket.Bind(ipEndPoint);
            //socket.Listen(0);
            //MessageBox.Show("监听已打开");


            //Socket serviceSocket = socket.Accept();
            //MessageBox.Show("连接建立");

            //string receiveStr = string.Empty;
            //byte[] rByte = new byte[4096];

            //int bytes = serviceSocket.Receive(rByte, rByte.Length, 0);
            //receiveStr += Encoding.ASCII.GetString(rByte, 0, bytes);
            //MessageBox.Show(receiveStr);

            //string send = "zhangsan";
            //byte[] byteSend = Encoding.ASCII.GetBytes(send);
            //serviceSocket.Send(byteSend, byteSend.Length, 0);
            //serviceSocket.Close();
            //socket.Close();


            int port = 6000;
            string host = "127.0.0.1";
            IPAddress ipAdress = IPAddress.Parse(host);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAdress, port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipEndPoint);
            socket.Listen(0);
            //MessageBox.Show("监听已打开");
            serviceSocket = socket.Accept();
            //MessageBox.Show("连接建立");


            int bytes = serviceSocket.Receive(rByte, rByte.Length, 0);
            txtContent.Text = txtContent.Text + System.Environment.NewLine + "zhangsan：" + Encoding.ASCII.GetString(rByte, 0, bytes);

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string send = txtMessage.Text;
            byte[] byteSend = Encoding.ASCII.GetBytes(send);
            serviceSocket.Send(byteSend, byteSend.Length, 0);
            txtContent.Text = txtContent.Text + System.Environment.NewLine + "lisi：" + txtMessage.Text;
            txtMessage.Text = "";
        }

        #region {客户端代码}
        //int port = 6000;
        //string host = "127.0.0.1";//服务器端ip地址

        //IPAddress ip = IPAddress.Parse(host);
        //IPEndPoint ipe = new IPEndPoint(ip, port);
        //Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //clientSocket.Connect(ipe);


        //    //send message
        //    string sendStr = "zhangsan nihao";
        //byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
        //clientSocket.Send(sendBytes);

        //    //receive message
        //    string recStr = "";
        //byte[] recBytes = new byte[4096];
        //int bytes = clientSocket.Receive(recBytes, recBytes.Length, 0);
        //recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
        //    Button1.Text = recStr;
        #endregion
    }
}
