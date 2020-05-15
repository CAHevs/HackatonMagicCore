using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HackatonMagic
{
    public partial class Form1 : Form
    {

        int pvJ1 = 20;
        int pvJ2 = 20;
        int minute = 0;
        int hour = 0;
        int second = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinusJ1_Click(object sender, EventArgs e)
        {
            pvJ1--;
            lblPVJ1.Text = pvJ1.ToString();
            if (pvJ1 <= 0)
            {
                gameEnded();
            }
        }

        private void btnPlusJ1_Click(object sender, EventArgs e)
        {
            pvJ1++;
            lblPVJ1.Text = pvJ1.ToString();
        }

        private void btnMinusJ2_Click(object sender, EventArgs e)
        {
            pvJ2--;
            lblPVJ2.Text = pvJ2.ToString();
            if (pvJ2 <= 0)
            {
                gameEnded();
            }
        }

        private void btnPlusJ2_Click(object sender, EventArgs e)
        {
            pvJ2++;
            lblPVJ2.Text = pvJ2.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            gameTime.Tick += new EventHandler(gameTime_Tick);
            gameTime.Start();
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 60)
            {
                minute++;
                second = 0;
            }
            if (minute == 60)
            {
                hour++;
                minute = 0;
            }
            lblTime.Text = hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();
        }

        private void gameEnded()
        {
            gameTime.Stop();
            btnStart.Enabled = true;
            lblTime.Text = "-";
            pvJ1 = 20;
            pvJ2 = 20;
        }

        private void btnRoll6_Click(object sender, EventArgs e)
        {

        }
    }
}
