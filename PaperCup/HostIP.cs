using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperCup
{
    public partial class HostIP : Form
    {
        private string localname;
        private VideoPlayer video;
        private string hostIP;
        private Form parent;

        public HostIP(string localNickName, Form p)
        {
            InitializeComponent();
            localname = localNickName;
            parent = p;
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {
            hostIP = IP.Text;            
        }

        //joining a room
        private void joinButton_Click(object sender, EventArgs e)
        {
            video = new VideoPlayer(localname, hostIP);
            video.Show();
            this.parent.Hide();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') joinButton_Click(sender, e); //enter
            if (e.KeyChar == 27) this.Close(); //escape
        }
    }
}
