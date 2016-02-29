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

        public VideoPlayer()
        {
            InitializeComponent();
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //getting the user's I.P.
            localIP.Text = GetLocalIP();

            remoteIP.Text = GetLocalIP();

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Nothing";
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

        private void MessageCallBack(IAsyncResult result)
        {
            try {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])result.AsyncState;

                //converting byte[] to string
                ASCIIEncoding a = new ASCIIEncoding();
                string message = a.GetString(receivedData);

                //Adding the message into the text box (show complete conversation)
                Chat.Items.Add("Friend: " + message);

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
            send = a.GetBytes(sendMessage.Text);

            //sending the sent message
            sck.Send(send);

            //add the sent message to the conversation
            Chat.Items.Add("Me: " + sendMessage.Text);

            //reset text in sendMessage box
            sendMessage.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
