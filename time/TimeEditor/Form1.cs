using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TimeEditor
{
    public partial class TimeEditorForm : Form
    {
        //global stuffs

        string[] settings = new string[9];

        public TimeEditorForm()
        {
            InitializeComponent();
        }

        private void TimeEditorForm_Load(object sender, EventArgs e)
        {

            StreamReader myFile = null;
            while (myFile == null)
            {
                try
                {
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

                    lblX.Text = settings[0];
                    lblY.Text = settings[1];


                    if (settings[2] != "")
                    {
                        string[] splitbgcolor = settings[2].Split(',');
                        lblBGColor.BackColor = Color.FromArgb(Convert.ToInt32(splitbgcolor[0]), Convert.ToInt32(splitbgcolor[1]), Convert.ToInt32(splitbgcolor[2]));
                    }
                    //grab rbg from options and split and set as lb, colors
                    

                    //transparency
                    if (settings[3] == "false")
                    {
                        chkTrans.Checked = false;
                    }
                    else if (settings[3] == "true")
                    {
                        chkTrans.Checked = true;
                    }
                    lblTransparent.Text = chkTrans.Checked.ToString().ToLower();

                    if (settings[4] != "")
                    {
                        //text color
                        string[] splittxtcolor = settings[4].Split(',');
                        lblTxtColor.BackColor = Color.FromArgb(Convert.ToInt32(splittxtcolor[0]), Convert.ToInt32(splittxtcolor[1]), Convert.ToInt32(splittxtcolor[2]));
                    }
                    //font name thats in use and size and what it looks like
                    lblFontName.Text = settings[5];
                    Font f = new Font(settings[5], 8.25f);
                    lblFontName.Font = f;
                    //example of what the font looks like
                    cbxFontName.Text = settings[5];
                    lblFontExample.Font = new Font(cbxFontName.Text, 8.25f);

                    //font size
                    lblFontSize.Text = settings[6];


                    //list of fonts
                    foreach (FontFamily fonts in FontFamily.Families)
                    {
                        cbxFontName.Items.Add(fonts.Name);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    if (myFile == null)
                    {
                        StreamWriter myFileSW = new StreamWriter("Options.txt");
                        myFileSW.WriteLine("0");//x
                        myFileSW.WriteLine("0");//y
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

        private void cmdResetBG_Click(object sender, EventArgs e)
        {
            if (settings[3] == "false")
            {
                chkTrans.Checked = false;
            }
            else if (settings[3] == "true")
            {
                chkTrans.Checked = true;
            }
            lblBGColors.BackColor = SystemColors.Control;
        }
        private void cmdResetXY_Click(object sender, EventArgs e)
        {
            txtY.Text = "";
            txtX.Text = "";
        }
        private void cmdResetTxt_Click(object sender, EventArgs e)
        {
            lblTxtColors.BackColor = SystemColors.Control;
            txtFontSize.Text = "";
            cbxFontName.Text = settings[5];
            lblFontExample.Font = new Font(settings[5], 8.25f);
        }
        private void cbxFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFontExample.Font = new Font(cbxFontName.Text, 8.25f);
        }
        private void cmdBGColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblBGColors.BackColor = colorDialog1.Color;
            }
        }
        private void cmdtxtcolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblTxtColors.BackColor = colorDialog1.Color;
            }
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            StreamWriter myFileSW = new StreamWriter("Options.txt");
            if (txtX.Text != "")
            {
                myFileSW.WriteLine(txtX.Text);
            }
            else
            {
                myFileSW.WriteLine(settings[0]);
            }
            if (txtY.Text != "")
            {
                myFileSW.WriteLine(txtY.Text);
            }
            else
            {
                myFileSW.WriteLine(settings[1]);
            }


            ////////////////





            

            //bgcolor
            if (lblBGColors.BackColor != SystemColors.Control)
            {
                myFileSW.WriteLine(lblBGColors.BackColor.R + "," + lblBGColors.BackColor.G + "," + lblBGColors.BackColor.B);
            }
            else
            {
                myFileSW.WriteLine(settings[2]);
            }

            myFileSW.WriteLine(chkTrans.Checked.ToString().ToLower());


            if (lblTxtColors.BackColor != SystemColors.Control)
            {
                myFileSW.WriteLine(lblTxtColors.BackColor.R + "," + lblTxtColors.BackColor.G + "," + lblTxtColors.BackColor.B);
            }
            else
            {
                myFileSW.WriteLine(settings[4]);
            }


            myFileSW.WriteLine(cbxFontName.Text);

            if (txtFontSize.Text != "")
            {
                myFileSW.WriteLine(txtFontSize.Text);
            }
            else
            {
                myFileSW.WriteLine(settings[6]);
            }

            myFileSW.Close();
            Close();
        }


    }
}
