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
        string localIP;
        byte[] buffer;

        private List<IPAddress> remote_ips = new List<IPAddress>();

        private Options settings;
        public bool isSound = true, isHost;
        System.Media.SoundPlayer msgSoundPlayer = new System.Media.SoundPlayer(@"msg.wav");

        Form mainmenu;

        OpenFileDialog file = new OpenFileDialog();

        public string localname;

        //host videoplayer
        public VideoPlayer(string localNickName, Form mm)
        {
            InitializeComponent();
            localname = localNickName;
            mainmenu = mm;
            isHost = true;
            //remote_ips starts empty
        }

        //nonhost videoplayers
        public VideoPlayer(string localNickName, string host_IP, Form mm)
        {
            InitializeComponent();
            localname = localNickName;
            mainmenu = mm;
            isHost = false;

            remote_ips.Add(IPAddress.Parse(host_IP)); //remote_ips will have 1 and only 1 ip!
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //getting the users' I.P.s
            localIP = GetLocalIP();
            sendMessage.Select();

            //binding socket
            epLocal = new IPEndPoint(IPAddress.Parse(localIP), (isHost) ? 49153 : 49154);
            sck.Bind(epLocal);

            if (!isHost){
                //connect to remote IP
                epRemote = new IPEndPoint(remote_ips[0], 49153);
                sck.Connect(epRemote);

                //Listening to the specific port
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
        }

        private void VideoPlayer_FormClosing(object sender, EventArgs e)
        {
            mainmenu.Show();
            //sendSocket("leaving");
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
            IPAddress friend = IPAddress.Parse(friendIP.Text);
            remote_ips.Add(friend);

            //connect to remote IP
            epRemote = new IPEndPoint(friend, 49154);
            sck.Connect(epRemote);

            //Listening to the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        //----------- Check Media Player Events ----------
        //Senses and deciphers which mediaplayer button the user pressed
        //then sends that information to the other user
        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {  
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

        //------ Pick & Send Media ------
        //user chooses media file to play
        //the address of the file is sent to the other user(s)
        private void chooseMedia_Click(object sender, EventArgs e){
            if(file.ShowDialog() == DialogResult.OK)
            {
                //get the filename = address of the file
                //then add it to the mediaPlayer
                mediaPlayer.URL = @file.FileName;

                sendSocket("?position");
            }
        }

        //------ Receiving Chat Functions ------
        //result is whatever we're receiving from epRemote
        //the result is then parsed into ASCII then string as a message
        //then added to the chat box
        private void MessageCallBack(IAsyncResult result){
            try {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])result.AsyncState;

                //converting byte[] to string
                ASCIIEncoding a = new ASCIIEncoding();
                string message = a.GetString(receivedData);

                if (message.StartsWith("playStateChange")){

                    int new_state = Int32.Parse(message.Substring("playStateChange".Length));
                    change_state(new_state);

                } else if (message.StartsWith("positionChange")){

                    double new_position = Double.Parse(message.Substring("positionChange".Length));
                    if (Math.Abs(mediaPlayer.Ctlcontrols.currentPosition - new_position) > 0.2) change_position(new_position);

                } else if (message.StartsWith("chat")) {

                    //Adding the message into the text box (show complete conversation)
                    addToChat(message.Substring("chat".Length));

                    if (isSound == true)
                    {
                        msgSoundPlayer.Play();
                    }
                }
                else if (message.StartsWith("?position")) {

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

            sendSocket("chat" + localname + ": " + sendMessage.Text);

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
            settings = new Options(this);
            settings.ShowDialog();
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
            }catch (System.Net.Sockets.SocketException) { }
   
        }

        public string getLocalIP()
        {
            return localIP;
        }
    }
}
