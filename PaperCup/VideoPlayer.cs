using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace PaperCup
{
    public partial class VideoPlayer : Form
    {
        //receiving/sending messages
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        private string localname, hostIP;
        private System.IO.StreamWriter writer;

        public VideoPlayer(string localNickName)
        {
            InitializeComponent();
            localname = localNickName;
            writer = new System.IO.StreamWriter("output.txt"); //open the file for writing.
            writer.Write(DateTime.Now.ToString()); //write the current date to the file. change this with your date or something
            writer.Write(hostIP);
        }

        public VideoPlayer(string localNickName, string host_IP)
        {
            InitializeComponent();
            localname = localNickName;
            hostIP = host_IP;
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //getting the users' I.P.s
            localIP.Text = GetLocalIP();
            remoteIP.Text = GetLocalIP();

            if (hostIP != null) { Console.WriteLine("Connecting..."); connect(); }
        }

        private string GetLocalIP()
        {
            if(hostIP != null)
            {
                return hostIP;
            }
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                { 
                    return ip.ToString();
                }
            }
            return "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void localPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void remoteIP_TextChanged(object sender, EventArgs e)
        {

        }

        //our connect button
        private void button1_Click(object sender, EventArgs e)
        {
            //binding socket
            //IPEndPoint = network endpoints(Ip address, portnumber)
            epLocal = new IPEndPoint(IPAddress.Parse(localIP.Text), Convert.ToInt32(localPort.Text));

            sck.Bind(epLocal);

            //connect to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(remoteIP.Text), Convert.ToInt32(remotePort.Text));
            sck.Connect(epRemote);

            //Listening to the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void connect()
        {
            Random port = new Random();
            int port_num = port.Next(1, 100);
            //binding socket
            //IPEndPoint = network endpoints(Ip address, portnumber)
            epLocal = new IPEndPoint(IPAddress.Parse(localIP.Text), Convert.ToInt32(port_num));

            sck.Bind(epLocal);

            port_num = port.Next(1, 100);
            //connect to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(remoteIP.Text), Convert.ToInt32(port_num));
            sck.Connect(epRemote);

            //Listening to the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult result)
        {
            try {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])result.AsyncState;

                //converting byte[] to string
                ASCIIEncoding a = new ASCIIEncoding();
                string message = a.GetString(receivedData);

                //Adding the message into the text box (show complete conversation)
                Chat.Items.Add(message);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            } catch( Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //convert string to byte
            ASCIIEncoding a = new ASCIIEncoding();

            byte[] send = new byte[1500];
            send = a.GetBytes(localname + ": " + sendMessage.Text);

            //sending the sent message
            sck.Send(send);

            //add the sent message to the conversation
            Chat.Items.Add(localname + ": " + sendMessage.Text);

            //reset text in sendMessage box
            sendMessage.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            if(writer != null)
            {
                writer.Close(); //remember to close the file again.
                writer.Dispose(); //remember to dispose it from the memory.
            }
        }
    }
}
