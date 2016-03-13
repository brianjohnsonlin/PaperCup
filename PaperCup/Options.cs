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

            ipDisplay.Text = "Room IP: " + videoplayer.getLocalIP();
            soundCheck.Checked = videoplayer.isSound;
        }

        private void cancelButton_Click (object sender, EventArgs e){
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e){
            videoplayer.localname = nameChange.Text;
            videoplayer.isSound = soundCheck.Checked;
            this.Close();
        }
    }
}
