using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class Form1 : Form
    {
        string heroName;

        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            heroName = nameBox.Text;

            outputMessageLabel.Text = "Welcome " + heroName + "!" + "\nAfraid are you? Decided to take the easy path?";

        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            heroName = nameBox.Text;

            outputMessageLabel.Text = "Welcome " + heroName + "!" + "\nYou are average at best. Enjoy your medium path";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            heroName = nameBox.Text;

            outputMessageLabel.Text = "Welcome " + heroName + "!" + "\nA true brave hero! Go forth and conquer the hard path.";
        }
    }
}
