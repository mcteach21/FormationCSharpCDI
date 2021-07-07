using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsFormation
{
    public partial class Horloge : Form
    {
        public Horloge()
        {
            InitializeComponent();

            pgbHeure.Minimum = 0;
            pgbHeure.Maximum = 23;
            pgbHeure.Style = ProgressBarStyle.Continuous;

            pgbMinute.Minimum = 0;
            pgbMinute.Maximum = 59;
            pgbMinute.Style = ProgressBarStyle.Continuous;

            pgbSeconde.Minimum = 0;
            pgbSeconde.Maximum = 59;
            pgbSeconde.Style = ProgressBarStyle.Continuous;

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgbHeure.Value = DateTime.Now.Hour;
            pgbMinute.Value = DateTime.Now.Minute;
            pgbSeconde.Value = DateTime.Now.Second;
        }

        private void Horloge_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuous_Click(object sender, EventArgs e)
        {
            pgbHeure.Style = ProgressBarStyle.Continuous;
            pgbMinute.Style = ProgressBarStyle.Continuous;
            pgbSeconde.Style = ProgressBarStyle.Continuous;
        }

        private void btnBlocks_Click(object sender, EventArgs e)
        {
            pgbHeure.Style = ProgressBarStyle.Blocks;
            pgbMinute.Style = ProgressBarStyle.Blocks;
            pgbSeconde.Style = ProgressBarStyle.Blocks;
        }

        private void btnMarquee_Click(object sender, EventArgs e)
        {
            pgbHeure.Style = ProgressBarStyle.Marquee;
            pgbMinute.Style = ProgressBarStyle.Marquee;
            pgbSeconde.Style = ProgressBarStyle.Marquee;
        }

    }   
}
