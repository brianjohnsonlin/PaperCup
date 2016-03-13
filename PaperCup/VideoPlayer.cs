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
        private Options settings;

        Form mainmenu;

        OpenFileDialog file = new OpenFileDialog();

        private string localname, hostIP;

        //host videoplayer
        public VideoPlayer(string localNickName, Form mm)
        {
            InitializeComponent();
            localname = localNickName;
            mainmenu = mm;
        }

        //nonhost videoplayers
        public VideoPlayer(string localNickName, string host_IP, Form mm)
        {
            InitializeComponent();
            localname = localNickName;
            sendMessage.Select();

            //hostIP = host_IP;
            localIP = GetLocalIP();
            hostIP = host_IP;
            mainmenu = mm;
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //getting the users' I.P.s
            localIP = GetLocalIP();
            remoteIP = hostIP;
            sendMessage.Select();

        }

        private void VideoPlayer_FormClosing(object sender, EventArgs e)
        {
            //Application.Exit();
            mainmenu.Show();
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
            addToChat("local: " + localIP);
            addToChat("remote: " + remoteIP);
        }

        //----------- Check Media Player Events ----------
        //Senses and deciphers which mediaplayer button the user pressed
        //then sends that information to the other user
        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {
            /*
            int state_change = e.newState;
            switch (e.newState)
            {
                case 1:    // Stopped
                    state_change = 1;
                    break;

                case 2:    // Paused
                    state_change = 2;
                    break;

                case 3:    // Playing
                    state_change = 3;
                    break;

                case 4:    // ScanForward
                    state_change = 4;
                    break;

                case 5:    // ScanReverse
                    state_change = 5;
                    break;
                case 8:    // MediaEnded
                    state_change = 8;
                    break;

                case 9:    // Transitioning
                    state_change = 9;
                    break;

                case 12:   // Last
                    state_change = 12;
                    break;

                default:
                    break;
            }
            */
            if (e.newState != 0) {
                //if the state has actually been changed, then send that information to 
                //the other user, so then their state will also be changed
                //convert string to byte
                sendSocket("playStateChange" + e.newState);
            }
        }

        private void mediaPlayer_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e) {
            sendSocket("positionChange" + e.newPosition);
        }

        //------ Changes Media Player's State -------
        private void change_state(int new_state)
        {
            switch (new_state)
            {
                case 1: // Stopped
                    mediaPlayer.Ctlcontrols.stop();
                    break;
                case 2: // Paused
                    mediaPlayer.Ctlcontrols.pause();
                    break;
                case 3: // Playing
                    mediaPlayer.Ctlcontrols.play();
                    break;
                case 4: // ScanForward: fastforward
                    mediaPlayer.Ctlcontrols.fastForward();
                    break;
                case 5: // ScanReverse: rewind
                    mediaPlayer.Ctlcontrols.fastReverse();
                    break;
                case 6: // Buffering
                    mediaPlayer.Ctlcontrols.pause();
                    break;
                case 7: // Waiting: The player is waiting for the server to respond.
                    mediaPlayer.Ctlcontrols.pause();
                    break;
                case 8: // MediaEnded
                    mediaPlayer.Ctlcontrols.stop();
                    break;
                case 9: // Transitioning: The clip is being prepared.
                    mediaPlayer.Ctlcontrols.pause();
                    break;
                case 10: // Ready
                    mediaPlayer.Ctlcontrols.pause();
                    break;
                case 11: // Reconnecting
                    mediaPlayer.Ctlcontrols.pause();
                    break;
                case 12: // Last
                    break;
                default:
                    break;
            }
        }

        private void change_position(double new_position) {
            mediaPlayer.Ctlcontrols.currentPosition = new_position;
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

                sendSocket("?position");


                //mediaPlayer.Ctlcontrols.pause(); //doesn't work

                /*
                //convert string to byte
                ASCIIEncoding a = new ASCIIEncoding();

                byte[] send = new byte[1500];
                send = a.GetBytes("@fileaddress" + file.FileName);

                //sending the sent message
                sck.Send(send);
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                */
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
                
                /*
                if (message.Contains("@fileaddress")) {
                    //the message received is the media sent from the other user
                    //the received media is then played
                    message = message.Replace("@fileaddress", "");
                    mediaPlayer.URL = @message;
                }*/

                if (message.StartsWith("playStateChange")){
                    int new_state = Int32.Parse(message.Substring("playStateChange".Length));
                    change_state(new_state);
                } else if (message.StartsWith("positionChange")){
                    double new_position = Double.Parse(message.Substring("positionChange".Length));
                    if (Math.Abs(mediaPlayer.Ctlcontrols.currentPosition - new_position) > 0.2) change_position(new_position);
                } else if (message.StartsWith("chat")) {
                    //Adding the message into the text box (show complete conversation)
                    addToChat(message.Substring("chat".Length));
                }else if (message.StartsWith("?position")) {
                    sendSocket("positionChange" + mediaPlayer.Ctlcontrols.currentPosition);
                }

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            } catch( Exception e)
            {
                MessageBox.Show(e.ToString());
            }            
        }

        //------ Sending Chat Functions ------
        private void sendButton_Click(object sender, EventArgs e){
            if (sendMessage.Text.Length == 0) return;

            sendSocket("chat" + "localname" + ": " + sendMessage.Text);

            //add the sent message to the conversation
            addToChat(localname + ": " + sendMessage.Text);

            //reset text in sendMessage box
            sendMessage.Text = "";
        }

        private void addToChat(string message) {
            Chat.Items.Add(message);
            Chat.TopIndex = Chat.Items.Count - 1;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings = new Options();
            settings.ShowDialog();
        }

        private void sendMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') {
                sendButton_Click(sender, e); //enter
                e.Handled = true;
            }
        }

        private void sendSocket(string msg) {
            ASCIIEncoding a = new ASCIIEncoding();

            byte[] send = new byte[1500];
            send = a.GetBytes(msg);

            //sending the sent message
            try {
                sck.Send(send);
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }catch (System.Net.Sockets.SocketException) { }
        }
    }
}
