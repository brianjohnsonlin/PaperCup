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
        public MainMenu()
        {
            InitializeComponent();
            List<String> fruit = new List<String> { "Banana", "Apple", "Strawberry", "Guava", "Peach", "Pineapple", "Grape", "Avocado" };
            List<String> bug = new List<String> { "Slug", "Butterfly", "Spider", "Ladybug", "Bee", "Roach", "Ant", "Mosquito" };
            Random rand = new Random();
            nicknameBox.Text = fruit[rand.Next(fruit.Count)] + bug[rand.Next(bug.Count)] + rand.Next(1000).ToString("D3");
        }
    }
}
