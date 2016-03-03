﻿using System;
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
        private HostIP join_host;
        private string nickname;
        
        public MainMenu()
        {
            InitializeComponent();
            List<String> fruit = new List<String> { "Banana", "Apple", "Strawberry", "Guava", "Peach", "Pineapple", "Grape", "Avocado" };
            List<String> bug = new List<String> { "Slug", "Butterfly", "Spider", "Ladybug", "Bee", "Roach", "Ant", "Mosquito" };
            Random rand = new Random();
            nicknameBox.Text = fruit[rand.Next(fruit.Count)] + bug[rand.Next(bug.Count)] + rand.Next(1000).ToString("D3");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            video = new VideoPlayer(nickname);
            this.Hide();
            video.Show();
        }

        private void nicknameBox_TextChanged(object sender, EventArgs e)
        {
            nickname = nicknameBox.Text;
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            join_host = new HostIP(nickname);
            join_host.Show();
            this.Hide();
        }
    }
}
