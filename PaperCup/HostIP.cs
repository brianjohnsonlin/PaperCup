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
        private Form parent;

        public HostIP(string localNickName, Form p){
            InitializeComponent();
            localname = localNickName;
            parent = p;
        }

        //joining a room
        private void joinButton_Click(object sender, EventArgs e){
            video = new VideoPlayer(localname, IP.Text, parent);
            video.Show();
            this.parent.Hide();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
