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

        public HostIP(string localNickName)
        {
            InitializeComponent();
            localname = localNickName;            
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {
            hostIP = IP.Text;            
        }
        //joining a room
        private void button1_Click(object sender, EventArgs e)
        {
            video = new VideoPlayer(localname, hostIP);
            this.Hide();
            video.Show();
        }
    }
}
