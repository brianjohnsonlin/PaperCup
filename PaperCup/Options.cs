using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperCup{
    public partial class Options : Form{
        private VideoPlayer videoplayer;

        public Options(VideoPlayer v){
            videoplayer = v;
            InitializeComponent();
            nameChange.Text = v.localname;

            ipDisplay.Text = videoplayer.getLocalIP();
            if (videoplayer.getRemoteIP().Length > 0) ripDisplay.Text = videoplayer.getRemoteIP();
            else ripDisplay.Text = "N/A";
            soundCheck.Checked = videoplayer.isSound;

            int l = videoplayer.localPort;
            int r = videoplayer.remotePort;
            localPortTextBox.Text = l.ToString();
            remotePortTextBox.Text = r.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e) {
            videoplayer.localname = nameChange.Text;
            videoplayer.isSound = soundCheck.Checked;

            if (videoplayer.localPort != Int32.Parse(localPortTextBox.Text)) {
                videoplayer.localPort = Int32.Parse(localPortTextBox.Text);
                videoplayer.BindSocket();
            }
            
            videoplayer.remotePort = Int32.Parse(remotePortTextBox.Text);

            this.Close();
        }

        private void cancelButton_Click (object sender, EventArgs e){
            this.Close();
        }

        private void ipDisplay_Click(object sender, EventArgs e) {
            Clipboard.SetText(videoplayer.getLocalIP());
            MessageBox.Show("Copied to Clipboard!");
        }

        private void ripDisplay_Click(object sender, EventArgs e) {
            if (videoplayer.getRemoteIP().Equals("")) {
                Clipboard.SetText(videoplayer.getRemoteIP());
                MessageBox.Show("Copied to Clipboard!");
            }
        }
    }
}
