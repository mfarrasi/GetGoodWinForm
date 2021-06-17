using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gma.System.MouseKeyHook;
using Gma.System.MouseKeyHook.Implementation;

namespace GetGoodWinForm
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\GetGoodWinForm\GetGoodWinForm\UserDB.mdf;Integrated Security=True");
        public enum Mode { Insert }
        Mode mode;
        UserInfo newData;
        public int totalSeconds;
        public int total = 0;
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
            this.cmbMinute.SelectedIndex = 0;
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

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X + 120, Cursor.Position.Y);

            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = true;

            totalSeconds = 0;
            this.timer1.Enabled = false;
            this.lblTime.Text = "00:00";
            update();
            
        }

        public void update()
        {
            try
            {
                //newData = new UserInfo();
                //con.Open();
                //string query = "INSERT INTO Table (Points) VALUES ( '" + newData.total + "' )";
                //SqlCommand sc = new SqlCommand(query, con);
                //sc.ExecuteNonQuery();
                //con.Close();
                using (var db = new UserEDM())
                {
                    newData = new UserInfo
                    {
                        Point = total
                    };
                    db.UserInfo.Add(newData);
                    db.SaveChanges();
                    lblPoints.Text = "Points : " + total.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                total++;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                if (minutes < 10 && seconds < 10)
                    this.lblTime.Text = "0" + minutes.ToString() + ":0" + seconds.ToString();
                else if (minutes < 10 && seconds >= 10)
                    this.lblTime.Text = "0" + minutes.ToString() + ":" + seconds.ToString();
                else if (minutes >= 10 && seconds < 10)
                    this.lblTime.Text = minutes.ToString() + ":0" + seconds.ToString();
                else
                    this.lblTime.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("Time is over");
                btnStop.PerformClick();
                
            }
            
            lblPoints.Text = "Points: " + total;

            if (totalSeconds % 3 == 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (totalSeconds % 2 == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
                
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Position = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnStop_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnStop_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }
    }
}
