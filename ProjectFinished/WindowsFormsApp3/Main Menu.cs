using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            player.URL = "Main.wav";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game gameWindow = new Game();

            gameWindow.Show();

            player.controls.stop();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

          