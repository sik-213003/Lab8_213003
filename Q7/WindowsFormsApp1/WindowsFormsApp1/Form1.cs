using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UpdateTime();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateTime()
        {
            DateTime todayWithoutTime = DateTime.Today;
            label1.Text = todayWithoutTime.ToString("dddd, MMMM dd, yyyy");

            DateTime currentDateTime = DateTime.Now;
            TimeSpan timePart = currentDateTime.TimeOfDay;
            label2.Text = timePart.ToString(@"hh\:mm\:ss");
        }
    }
}
