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
    public partial class Form1 : Form
    {
        public System.Timers.Timer myTime;
        DateTime theTime;
        MethodInvoker deleg;
        ElapsedEventHandler timer;
        bool close = false;
        MyLabel lblthetime = new MyLabel();
        

        public Form1()
        {
            InitializeComponent();

            lblthetime.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            
            

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

            
            deleg = new MethodInvoker(invoke);
            timer = new ElapsedEventHandler(testy);

            StreamReader myFile = null;
            while (myFile == null)
            {
                try
                {
                    string[] settings = new string[9];
                    myFile = new StreamReader("Options.txt");
                    string option;
                    int i = 0;
                    //grab all the data from the txt file
                    while ((option = myFile.ReadLine()) != null)
                    {
                        settings[i] = option;
                        i++;
                    }
                    myFile.Close();

                    this.Left = Convert.ToInt32(settings[0]);
                    this.Top = Convert.ToInt32(settings[1]);
                    
                    
                    if (settings[2] == "true")
                    {
                        try
                        {
                            this.BackgroundImage = Image.FromFile(settings[3]);
                        }
                        catch
                        {
                            MessageBox.Show("The file as the background image can't be located");
                            close = true;
                        }
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        //background color
                        string[] splitbgcolor = settings[4].Split(',');
                        this.BackColor = Color.FromArgb(Convert.ToInt32(splitbgcolor[0]), Convert.ToInt32(splitbgcolor[1]), Convert.ToInt32(splitbgcolor[2]));

                        if (settings[5] == "true")
                        {
                            //transparent
                            this.BackColor = Color.White;
                            this.TransparencyKey = Color.Transparent;
                        }
                    }


                    string[] splittxtcolor = settings[6].Split(',');

                    lblthetime.ForeColor = Color.FromArgb(Convert.ToInt32(splittxtcolor[0]), Convert.ToInt32(splittxtcolor[1]), Convert.ToInt32(splittxtcolor[2]));

                    lblthetime.Font = new Font(settings[7], Convert.ToInt32(settings[8]), FontStyle.Bold);
                    lblthetime.Left = 5;
                    lblthetime.Top = 5;
                    lblthetime.AutoSize = true;
                    this.Controls.Add(lblthetime);

                    //set height to height of label
                    this.Height = lblthetime.Height + 5;
                    myFile.Dispose();

                    myTime = new System.Timers.Timer(1000);
                    myTime.Enabled = true;
                    myTime.Elapsed += timer;
                }
                catch (FileNotFoundException ex)
                {
                    if (myFile == null)
                    {
                        StreamWriter myFileSW = new StreamWriter("Options.txt");
                        myFileSW.WriteLine("0");//x
                        myFileSW.WriteLine("0");//y
                        myFileSW.WriteLine("false");//imagecheck
                        myFileSW.WriteLine("");//filepath
                        myFileSW.WriteLine("255,255,0");//bgcolor
                        myFileSW.WriteLine("true");//transparent
                        myFileSW.WriteLine("0,255,255");//txtcolor
                        myFileSW.WriteLine("Arial");//fontname
                        myFileSW.WriteLine("30");//fontsize
                        myFileSW.Close();
                    }
                }
            }

        }



        public void testy(object sender, ElapsedEventArgs e)
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
            GC.Collect();//this works
            this.Width = lblthetime.Width + 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (close == true)
            {
                Application.Exit();
            }
        }
        public class MyLabel : Label
        {
            private System.Drawing.Text.TextRenderingHint _textRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

            public System.Drawing.Text.TextRenderingHint TextRenderingHint
            {
                get { return _textRenderingHint; }
                set { _textRenderingHint = value; }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.TextRenderingHint = _textRenderingHint;
                base.OnPaint(e);
            }
        } 
    }   
}
