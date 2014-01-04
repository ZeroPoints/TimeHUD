using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace time_editor
{
    public partial class Form1 : Form
    {
        //global stuffs
        
        string[] settings = new string[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                    

                    if (settings[2] == "false")
                    {
                        chkImage.Checked = false;
                        txtFilePath.Enabled = false;
                        chkTrans.Enabled = true;
                        lblBGColors.Enabled = true;
                        cmdBGColor.Enabled = true;
                        cmdBrowse.Enabled = false;
                    }
                    else if (settings[2] == "true")
                    {
                        chkImage.Checked = true;
                        txtFilePath.Enabled = true;
                        chkTrans.Enabled = false;
                        lblBGColors.Enabled = false;
                        cmdBGColor.Enabled = false;
                        cmdBrowse.Enabled = true;
                    }
                    lblFilePath.Text = settings[3];
                    lblImage.Text = chkImage.Checked.ToString().ToLower();

                    //grab rbg from options and split and set as lb, colors
                    string[] splitbgcolor = settings[4].Split(',');
                    lblBGColor.BackColor = Color.FromArgb(Convert.ToInt32(splitbgcolor[0]), Convert.ToInt32(splitbgcolor[1]), Convert.ToInt32(splitbgcolor[2]));
                    
                    
                    //transparency
                    if (settings[5] == "false")
                    {
                        chkTrans.Checked = false;
                    }
                    else if (settings[5] == "true")
                    {
                        chkTrans.Checked = true;
                    }
                    lblTransparent.Text = chkTrans.Checked.ToString().ToLower();
                    
                    //text color
                    string[] splittxtcolor = settings[6].Split(',');
                    lblTxtColor.BackColor = Color.FromArgb(Convert.ToInt32(splittxtcolor[0]), Convert.ToInt32(splittxtcolor[1]), Convert.ToInt32(splittxtcolor[2]));

                    //font name thats in use and size and what it looks like
                    lblFontName.Text = settings[7];
                    Font f = new Font(settings[7], 8.25f);                    
                    lblFontName.Font = f;
                    //example of what the font looks like
                    cbxFontName.Text = settings[7];
                    lblFontExample.Font = new Font(cbxFontName.Text, 8.25f);

                    //font size
                    lblFontSize.Text = settings[8];


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
        private void chkImage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImage.Checked == true)
            {
                txtFilePath.Enabled = true;
                chkTrans.Enabled = false;
                lblBGColors.Enabled = false;
                cmdBGColor.Enabled = false;
                cmdBrowse.Enabled = true;
            }
            else if (chkImage.Checked == false)
            {
                txtFilePath.Enabled = false;
                chkTrans.Enabled = true;
                lblBGColors.Enabled = true;
                cmdBGColor.Enabled = true;
                cmdBrowse.Enabled = false;
            }
        }        
        private void cmdResetImage_Click(object sender, EventArgs e)
        {
            if (settings[2] == "false")
            {
                chkImage.Checked = false;
            }
            else if (settings[2] == "true")
            {
                chkImage.Checked = true;
            }
            txtFilePath.Text = "";
            if (settings[5] == "false")
            {
                chkTrans.Checked = false;
            }
            else if (settings[5] == "true")
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
            cbxFontName.Text = settings[7];
            lblFontExample.Font = new Font(settings[7], 8.25f);            
        }
        private void cbxFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFontExample.Font = new Font(cbxFontName.Text, 8.25f);
        }
        private void cmdBGColor_Click(object sender, EventArgs e)
        {
            //shows color dialog box
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
	        {
		        // Set form background to the selected color.
                lblBGColors.BackColor = colorDialog1.Color;
	        }            
        }
        private void cmdtxtcolor_Click(object sender, EventArgs e)
        {
            //shows color dialog box
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                lblTxtColors.BackColor = colorDialog1.Color;
            }
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {

            //save stuff to file
            StreamWriter myFileSW = new StreamWriter("Options.txt");
            //because i load chkboxs into it i dont need to compare to old...just store


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
            

            myFileSW.WriteLine(chkImage.Checked.ToString().ToLower());



            //url
            if (txtFilePath.Text != "")
            {
                myFileSW.WriteLine(txtFilePath.Text);
            }
            else
            {
                myFileSW.WriteLine(settings[3]);
            }


            //bgcolor
            if (lblBGColors.BackColor != SystemColors.Control)
            {                
                myFileSW.WriteLine(lblBGColors.BackColor.R + "," + lblBGColors.BackColor.G + "," + lblBGColors.BackColor.B);
            }
            else
            {
                myFileSW.WriteLine(settings[4]);
            }

            myFileSW.WriteLine(chkTrans.Checked.ToString().ToLower());


            if (lblTxtColors.BackColor != SystemColors.Control)
            {
                myFileSW.WriteLine(lblTxtColors.BackColor.R + "," + lblTxtColors.BackColor.G + "," + lblTxtColors.BackColor.B);
            }
            else
            {
                myFileSW.WriteLine(settings[6]);
            }


            myFileSW.WriteLine(cbxFontName.Text);

            if (txtFontSize.Text != "")
            {
                myFileSW.WriteLine(txtFontSize.Text);
            }
            else
            {
                myFileSW.WriteLine(settings[8]);
            }

            myFileSW.Close();
            Close();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtFilePath.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
    }
}
