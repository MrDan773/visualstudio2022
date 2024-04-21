using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            orangeButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Red;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Orange;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Yellow;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Lime;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Blue;
        }

        private void styleButton1_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Dutch801 XBd BT", 90, FontStyle.Regular);
        }

        private void styleButton2_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Harlow Solid Italic", 90, FontStyle.Regular);
        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Impact", 90, FontStyle.Regular);
        }
    }
}
