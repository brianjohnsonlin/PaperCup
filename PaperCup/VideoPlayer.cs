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
        public int localPort = 49153;
        public int remotePort = 49153;
        public double lagBuffer = 0.2; // don't set to 0!

        private Socket sck;
        private EndPoint epLocal, epRemote;
        private string localIP;
        private string remoteIP = "";
        private byte[] buffer = new byte[1500];

        //user settings
        public string localname;
        public bool isSound = true;

        private System.Media.SoundPlayer msgSoundPlayer = new System.Media.SoundPlayer(@"msg.wav");
        private OpenFileDialog file = new OpenFileDialog();

        public VideoPlayer() {
            InitializeComponent();

            //set nickname
            List<String> fruit = new List<String> {"Banana", "Apple", "Strawberry", "Guava", "Peach", "Pineapple", "Grape", "Avocado",
                                                   "Pear", "Mango", "Blueberry", "Raspberry", "Orange", "Lemon", "Lime", "Watermelon",
                                                   "Cherry", "Lychee", "Kiwi", "Grapefruit"};
            List<String> bug = new List<String> {"Slug", "Butterfly", "Spider", "Ladybug", "Bee", "Roach", "Ant", "Mosquito", "Grasshopper",
                                                 "Firefly", "Fly", "Caterpiller", "Worm", "Snail", "Scarab", "Beetle", "Mantis", "Millipede",
                                                 "Centipede", "Moth", "Wasp"};
            Random rand = new Random();
            localname = fruit[rand.Next(fruit.Count)] + bug[rand.Next(bug.Count)] + rand.Next(1000).ToString("D3");
        }

        private void VideoPlayer_Load(object sender, EventArgs e){
            localIP = FindLocalIP();
            BindSocket(localIP, localPort);
            addToChat(">>> Welcome to PaperCup!");
            addToChat(">>> Your current nickname is " + localname + ".");
            addToChat(">>> Go to the settings if you wish to change this.");
            addToChat("");
        }

        //what if we unexpectedly close???
        private void VideoPlayer_FormClosing(object sender, EventArgs e){
            //sendSocket("disconnecting"); //doesn't work
        }

        //---------- Networking ----------//
        private string FindLocalIP() {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            return "0";
        }

        private void BindSocket(string ip, int port) {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //binding socket
            epLocal = new IPEndPoint(IPAddress.Parse(ip), port);
            sck.Bind(epLocal);
        }

        private void ConnectSocket(string ip, int port) {
            addToChat(">>> Attempting to connect to " + ip + ":" + port + "...");
            //connect to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(ip), port);
            try {
                sck.Connect(epRemote);
                sendSocket("ping");
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            } catch (System.Net.Sockets.SocketException) {
                addToChat(">>> Failed to Connect! Make sure the IP Address is valid.");
            }
        }

        //disconnecting and checking to see if connect, and unexpected close.
        private void MessageCallBack(IAsyncResult result) {
            try {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])result.AsyncState;

                //converting byte[] to string
                ASCIIEncoding a = new ASCIIEncoding();
                string message = a.GetString(receivedData);

                /*if (message.Equals("ping")) {
                    sendSocket("pong");
                    addToChat(">>> Connection Success!"); //temp
                }else if (message.Equals("pong")) {
                    addToChat(">>> Connection Success!");
                }else //doesnt work */
                if (message.StartsWith("playStateChange")) {
                    int new_state = Int32.Parse(message.Substring("playStateChange".Length));
                    change_state(new_state);
                }else if (message.StartsWith("positionChange")) {
                    double new_position = Double.Parse(message.Substring("positionChange".Length));
                    if (Math.Abs(mediaPlayer.Ctlcontrols.currentPosition - new_position) > lagBuffer) change_position(new_position);
                }else if (message.StartsWith("chat")) {
                    addToChat(message.Substring("chat".Length));
                    if (isSound) msgSoundPlayer.Play();
                }
                else if (message.Equals("?position")) {
                    sendSocket("positionChange" + mediaPlayer.Ctlcontrols.currentPosition);
                }
                /*else if (message.Equals("disconnecting")) {
                    addToChat(">>> Remote has disconnected."); //doesn't work
                }*/

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }

        private void sendSocket(string msg) {
            ASCIIEncoding a = new ASCIIEncoding();

            byte[] send = new byte[1500];
            send = a.GetBytes(msg);

            //sending the sent message
            try {
                sck.Send(send);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (System.Net.Sockets.SocketException) { }

        }

        private void friendIP_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r') { //enter
                connect_Click(sender, e); 
                e.Handled = true;
            }
        }
        
        private void connect_Click(object sender, EventArgs e){
            if(friendIP.Text.Equals(localIP) && localPort == remotePort) {
                MessageBox.Show("You're trying to connect with yourself!");
                return; //catch connecting with self
            }
            try {
                IPAddress.Parse(friendIP.Text);
                remoteIP = friendIP.Text;
                ConnectSocket(remoteIP, remotePort);
            }catch (System.FormatException) {
                MessageBox.Show("\"" + friendIP.Text + "\" is not a valid IP Address!");
            }
        }
        
        private void clearButton_Click(object sender, EventArgs e) {
            friendIP.Text = "";
        }

        //---------- Media Player ----------//
        private void chooseMedia_Click(object sender, EventArgs e) {
            if (file.ShowDialog() == DialogResult.OK) {
                mediaPlayer.URL = @file.FileName;

                sendSocket("?position");
            }
        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {  
            if (e.newState != 0) sendSocket("playStateChange" + e.newState);
        }

        private void mediaPlayer_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e) {
            sendSocket("positionChange" + e.newPosition);
        }

        private void change_state(int new_state){
            switch (new_state){
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

        //---------- Chat ----------//
        private void sendMessage_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r') { //enter
                sendButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void sendButton_Click(object sender, EventArgs e){
            if (sendMessage.Text.Length == 0) return;
            sendSocket("chat" + localname + ": " + sendMessage.Text);
            addToChat(localname + ": " + sendMessage.Text);
            sendMessage.Text = "";
        }

        private void addToChat(string message) {
            Chat.Items.Add(message);
            Chat.TopIndex = Chat.Items.Count - 1;
        }

        private void settingsButton_Click(object sender, EventArgs e){
            (new Options(this)).ShowDialog();
        }

        /* doesn't work
        private List<string> WrapText(string text, int pixels) {
            string[] originalLines = text.Split(new string[] { " " }, StringSplitOptions.None);

            List<string> wrappedLines = new List<string>();

            StringBuilder actualLine = new StringBuilder();
            double actualWidth = 0;

            foreach (var item in originalLines) {
                int itemLength = TextRenderer.MeasureText(item, new Font("Microsoft San Serif", 8, FontStyle.Regular, GraphicsUnit.Point)).Width;
                actualLine.Append(item + " ");
                actualWidth += itemLength;

                if (actualWidth + itemLength < pixels) {
                    actualLine.Append(item + " ");
                    actualWidth += itemLength;
                }else {
                    wrappedLines.Add(actualLine.ToString());
                    actualLine.Clear();
                    actualWidth = 0;
                }
            }

            if (actualLine.Length > 0)
                wrappedLines.Add(actualLine.ToString());

            return wrappedLines;
        }
        */

        //---------- Access Functions ----------//
        public string getLocalIP() {
            return localIP;
        }

        public string getRemoteIP() {
            return remoteIP;
        }

        public void BindSocket() {
            BindSocket(localIP, localPort);
        }

        public void ConnectSocket() {
            ConnectSocket(remoteIP, remotePort);
        }
    }
}
