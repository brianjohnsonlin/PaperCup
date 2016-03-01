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
using WMPLib;

namespace PaperCup
{
    public partial class VideoPlayer : Form
    {
        //receiving/sending messages
        Socket sck;
        EndPoint epLocal, epRemote;
        string localIP, remoteIP;
        byte[] buffer;
        private List<IPAddress> ips;

        OpenFileDialog file = new OpenFileDialog();

        private string localname, hostIP;
        //host videoplayer
        public VideoPlayer(string localNickName)
        {
            InitializeComponent();
            localname = localNickName;
        }
        //nonhost videoplayers
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
            localIP = GetLocalIP();
            remoteIP = GetLocalIP();

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
            return "0";
        }

        //our connect button
        private void connect_Click(object sender, EventArgs e)
        {
            //binding socket
            //IPEndPoint = network endpoints(Ip address, portnumber)
            epLocal = new IPEndPoint(IPAddress.Parse(localIP), Convert.ToInt32(localPort.Text));

            sck.Bind(epLocal);

            //connect to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(remoteIP), Convert.ToInt32(remotePort.Text));
            sck.Connect(epRemote);

            //Listening to the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        //------ Pick & Send Media ------
        //user chooses media file to play
        //the address of the file is sent to the other user(s)
        private void chooseMedia_Click(object sender, EventArgs e)
        {
            if(file.ShowDialog() == DialogResult.OK)
            {
                //get the filename = address of the file
                //then add it to the mediaPlayer
                mediaPlayer.URL = @file.FileName;

                //convert string to byte
                ASCIIEncoding a = new ASCIIEncoding();

                byte[] send = new byte[1500];
                send = a.GetBytes("@fileaddress" + file.FileName);

                //sending the sent message
                sck.Send(send);
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
        }
        //------ Receiving Chat Functions ------
        //result is whatever we're receiving from epRemote
        //the result is then parsed into ASCII then string as a message
        //then added to the chat box
        private void MessageCallBack(IAsyncResult result)
        {
            try {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])result.AsyncState;

                //converting byte[] to string
                ASCIIEncoding a = new ASCIIEncoding();
                string message = a.GetString(receivedData);

                if (message.Contains("@fileaddress")) {
                    message.Replace("@fileaddress", "");
                    mediaPlayer.URL = @message;
                }
                else
                {
                    //Adding the message into the text box (show complete conversation)
                    Chat.Items.Add(message);
                }

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            } catch( Exception e)
            {
                MessageBox.Show(e.ToString());
            }            
        }
        //------ Sending Chat Functions ------
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
    }
}
