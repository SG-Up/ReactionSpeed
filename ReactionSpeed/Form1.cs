using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace ReactionSpeed
{
    public partial class Form1 : Form
    {

        Random timer = new Random();
        Random location = new Random();
        Stopwatch stopwatch = new Stopwatch();
        double[] storeTimes = new double[10];

        int counter = 0;
        int i = 0;

        

        public Form1()
        {
            InitializeComponent();
        }


        // ### ON REACTION CLICK ###
        private void bttnReaction_Click(object sender, EventArgs e)
        {
            bttnReaction.Visible = false;

            stopwatch.Reset();
            int rndtimer = timer.Next(100, 3000);
            timer1.Interval = rndtimer;
            Task.Delay(timer1.Interval).Wait();

            locationRND();
           
            bttnClick.Visible = true;
            stopwatch.Start();

        }

        // ### RANDOM LOCATION ###
        private Point locationRND()
        {
            Random x = new Random();
            Point rndLocation = new Point(
            int.Parse(x.Next(this.Size.Width - bttnClick.Width).ToString()),
            int.Parse(x.Next(this.Size.Height - bttnClick.Height - 80).ToString()));
            bttnClick.Location = rndLocation;
            return bttnClick.Location;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        // ### ON CLICK ME ###
        private void bttnClick_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            bttnClick.Visible = false;
            counter++;
            int triesLeft = 10 - counter;

            double time = (Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 10);
            this.Text = "Speed:" + time.ToString() + "  Tries left:" + triesLeft;

            storeTimes[i] = time;
            i++;
            
            if (counter < 10)
            {
                stopwatch.Reset();
                int rndtimer = timer.Next(100, 3000);
                timer1.Interval = rndtimer;
                Task.Delay(timer1.Interval).Wait();

                locationRND();

              bttnClick.Visible = true;
                stopwatch.Start();
            }
            if (counter == 10)
            {
                bttnClick.Visible = false;
                double meanTimes = storeTimes.Sum() / storeTimes.Length;
                this.Text = ("Mean Speed:" + Convert.ToString(meanTimes));
                bttnSave.Visible = true;
                bttnRestart.Visible = true;
              
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // ## Restart Button ##
        private void bttnRestart_Click(object sender, EventArgs e)
        {
            Array.Clear(storeTimes,0, storeTimes.Length);
            counter = 0;
            i = 0;
            bttnRestart.Visible = false;
            bttnSave.Visible = false;
            bttnReaction.Visible = true;
        }

        // ## Open Form2 ##
        private void bttnSave_Click(object sender, EventArgs e)
        {
            double meanTimes = storeTimes.Sum() / storeTimes.Length;
            Form2 frm2 = new Form2(Convert.ToString(meanTimes));
            frm2.ShowDialog();
            
        }
    }
}
