using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.Diagnostics;


namespace time
{
    public partial class MyDigitalClock : Form
    {
        public System.Timers.Timer myTime;
        DateTime theTime;
        MethodInvoker deleg;
        ElapsedEventHandler timer;
        bool close = false;
        int finalLine;
        File myCurrentFile = new File();




        public MyDigitalClock()
        {
            InitializeComponent();
            deleg = new MethodInvoker(invoke);
            timer = new ElapsedEventHandler(lblTimeInvoke);
            Process[] MyProc = Process.GetProcessesByName("time");
            if (MyProc.Length == 1 || MyProc.Length == 0)
            {
                close = false;
            }
            else if (MyProc.Length == 2)
            {
                MessageBox.Show("Can't run as the program is already running");
                close = true;
            }
            ReadFile();
            SetOptions();
            myTime = new System.Timers.Timer(1000);
            myTime.Enabled = true;
            myTime.Elapsed += timer;
        }


        public void ReadFile()
        {
            try
            {
                var myFile = new StreamReader("Options.txt");
                List<string> settings = new List<string>();
                string option;
                //grab all the data from the txt file
                while ((option = myFile.ReadLine()) != null)
                {
                    settings.Add(option);
                }
                myFile.Close();
                myCurrentFile.XLocation = Convert.ToInt32(settings[0]);
                myCurrentFile.YLocation = Convert.ToInt32(settings[1]);
                myCurrentFile.RGBBackGroundColor = settings[2];
                myCurrentFile.Transparent = Convert.ToBoolean(settings[3]);
                myCurrentFile.RGBTextColor = settings[4];
                myCurrentFile.FontType = settings[5];
                myCurrentFile.FontSize = Convert.ToInt32(settings[6]);
            }
            catch (FileNotFoundException ex)
            {
                myCurrentFile.XLocation = 0;
                myCurrentFile.YLocation = 0;
                myCurrentFile.RGBBackGroundColor = "";
                myCurrentFile.Transparent = true;
                myCurrentFile.RGBTextColor = "0,255,255";
                myCurrentFile.FontType = "Arial";
                myCurrentFile.FontSize = 20;
                StreamWriter myFileSW = new StreamWriter("Options.txt");
                myFileSW.WriteLine(myCurrentFile.XLocation);//x
                myFileSW.WriteLine(myCurrentFile.YLocation);//y
                myFileSW.WriteLine(myCurrentFile.RGBBackGroundColor);//bgcolor
                myFileSW.WriteLine(myCurrentFile.Transparent);//transparent
                myFileSW.WriteLine(myCurrentFile.RGBTextColor);//txtcolor
                myFileSW.WriteLine(myCurrentFile.FontType);//fontname
                myFileSW.WriteLine(myCurrentFile.FontSize);//fontsize
                myFileSW.Close();
            }
        }



        public void SetOptions()
        {
            this.Left = myCurrentFile.XLocation;
            this.Top = myCurrentFile.YLocation;
            if (myCurrentFile.RGBBackGroundColor != "")
            {
                string[] splitbgcolor = myCurrentFile.RGBBackGroundColor.Split(',');
                this.BackColor = Color.FromArgb(Convert.ToInt32(splitbgcolor[0]), Convert.ToInt32(splitbgcolor[1]), Convert.ToInt32(splitbgcolor[2]));
            }
            if (myCurrentFile.Transparent == true)
            {
                this.BackColor = Color.Black;
                this.lblthetime.BackColor = Color.Black;
                this.TransparencyKey = Color.Black;
            }
            string[] splittxtcolor = myCurrentFile.RGBTextColor.Split(',');
            lblthetime.ForeColor = Color.FromArgb(Convert.ToInt32(splittxtcolor[0]), Convert.ToInt32(splittxtcolor[1]), Convert.ToInt32(splittxtcolor[2]));
            lblthetime.Font = new Font(myCurrentFile.FontType, myCurrentFile.FontSize, FontStyle.Bold);
            Height = lblthetime.Height + 15;
        }



        public void lblTimeInvoke(object sender, ElapsedEventArgs e)
        {
            try
            {
                lblthetime.Invoke(deleg);
            }
            catch
            {

            }
        }

        public DateTime test()
        {
            theTime = DateTime.Now;
            return theTime;
        }

        private void invoke()
        {
            lblthetime.Text = test().ToString();
            GC.Collect();
            this.Width = lblthetime.Width + 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (close == true)
            {
                Application.Exit();
            }
        }
    }
}
