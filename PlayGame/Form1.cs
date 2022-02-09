using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayGameBackdrop_Click(object sender, EventArgs e)
        {

        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            PlayGameButton.Text = "3";
            Refresh();
            Thread.Sleep(1000);

            PlayGameButton.Text = "2";
            Refresh();
            Thread.Sleep(1000);

            PlayGameButton.Text = "1";
            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Gainsboro;

            PlayGameButton.Visible = false;
            PlayGameButton.ForeColor = Color.Gainsboro;

            GO.Visible = true;





        }

        private void GO_Click(object sender, EventArgs e)
        {

        }
    }
}
