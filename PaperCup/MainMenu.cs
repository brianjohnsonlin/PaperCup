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
    public partial class MainMenu : Form
    {
        //makes new videoplayer form so that the create a room button opens up the videoplayer screen
        private VideoPlayer video;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            video = new VideoPlayer();
            this.Hide();
            video.Show();
        }
    }
}
