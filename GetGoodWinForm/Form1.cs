using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetGoodWinForm
{
    public partial class Form1 : Form
    {
        public enum Mode { Insert }
        Mode mode;
        Point point;
        private int totalSeconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 46; i++)
                this.cmbMinute.Items.Add(i.ToString());
            for (int i = 0; i < 61; i++)
                this.cmbSecond.Items.Add(i.ToString());
            this.cmbMinute.SelectedIndex = 45;
            this.cmbSecond.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;

            int minutes = int.Parse(this.cmbMinute.SelectedItem.ToString());
            int seconds = int.Parse(this.cmbSecond.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + seconds;

            this.timer1.Enabled = true;

            if (timer1.Equals(0))
            {
                using (var db = new UserInfo())
                {
                    newPoint = new Point()
                    {
                        total
                    }
                }

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;
            this.btnStart.Enabled = true;

            totalSeconds = 0;
            this.timer1.Enabled = false;
            this.lblTime.Text = "00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                this.lblTime.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("Time is over");
            }
        }
    }
}
