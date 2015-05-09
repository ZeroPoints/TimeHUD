namespace TimeEditor
{
    partial class TimeEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFontExample = new System.Windows.Forms.Label();
            this.lblBGColor = new System.Windows.Forms.Label();
            this.cbxFontName = new System.Windows.Forms.ComboBox();
            this.lblTxtColors = new System.Windows.Forms.Label();
            this.cmdBGColor = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdtxtcolor = new System.Windows.Forms.Button();
            this.BGColor = new System.Windows.Forms.Label();
            this.cmdResetXY = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBGColors = new System.Windows.Forms.Label();
            this.cmdResetBG = new System.Windows.Forms.Button();
            this.chkTrans = new System.Windows.Forms.CheckBox();
            this.Transparent = new System.Windows.Forms.Label();
            this.lblTransparent = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdResetTxt = new System.Windows.Forms.Button();
            this.TxtColor = new System.Windows.Forms.Label();
            this.FontName = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.Label();
            this.lblTxtColor = new System.Windows.Forms.Label();
            this.lblFontName = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Changes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFontExample
            // 
            this.lblFontExample.AutoSize = true;
            this.lblFontExample.Location = new System.Drawing.Point(360, 40);
            this.lblFontExample.Name = "lblFontExample";
            this.lblFontExample.Size = new System.Drawing.Size(47, 13);
            this.lblFontExample.TabIndex = 34;
            this.lblFontExample.Text = "Example";
            // 
            // lblBGColor
            // 
            this.lblBGColor.AutoSize = true;
            this.lblBGColor.Location = new System.Drawing.Point(110, 14);
            this.lblBGColor.Name = "lblBGColor";
            this.lblBGColor.Size = new System.Drawing.Size(56, 13);
            this.lblBGColor.TabIndex = 15;
            this.lblBGColor.Text = "lblBGColor";
            // 
            // cbxFontName
            // 
            this.cbxFontName.FormattingEnabled = true;
            this.cbxFontName.Location = new System.Drawing.Point(230, 40);
            this.cbxFontName.Name = "cbxFontName";
            this.cbxFontName.Size = new System.Drawing.Size(100, 21);
            this.cbxFontName.TabIndex = 56;
            this.cbxFontName.SelectedIndexChanged += new System.EventHandler(this.cbxFontName_SelectedIndexChanged);
            // 
            // lblTxtColors
            // 
            this.lblTxtColors.AutoSize = true;
            this.lblTxtColors.Location = new System.Drawing.Point(230, 10);
            this.lblTxtColors.Name = "lblTxtColors";
            this.lblTxtColors.Size = new System.Drawing.Size(24, 13);
            this.lblTxtColors.TabIndex = 28;
            this.lblTxtColors.Text = "text";
            // 
            // cmdBGColor
            // 
            this.cmdBGColor.Location = new System.Drawing.Point(360, 14);
            this.cmdBGColor.Name = "cmdBGColor";
            this.cmdBGColor.Size = new System.Drawing.Size(75, 23);
            this.cmdBGColor.TabIndex = 25;
            this.cmdBGColor.Text = "Background Color";
            this.cmdBGColor.UseVisualStyleBackColor = true;
            this.cmdBGColor.Click += new System.EventHandler(this.cmdBGColor_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(252, 324);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 67;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdtxtcolor
            // 
            this.cmdtxtcolor.Location = new System.Drawing.Point(360, 10);
            this.cmdtxtcolor.Name = "cmdtxtcolor";
            this.cmdtxtcolor.Size = new System.Drawing.Size(75, 23);
            this.cmdtxtcolor.TabIndex = 27;
            this.cmdtxtcolor.Text = "Text Color";
            this.cmdtxtcolor.UseVisualStyleBackColor = true;
            this.cmdtxtcolor.Click += new System.EventHandler(this.cmdtxtcolor_Click);
            // 
            // BGColor
            // 
            this.BGColor.AutoSize = true;
            this.BGColor.Location = new System.Drawing.Point(20, 14);
            this.BGColor.Name = "BGColor";
            this.BGColor.Size = new System.Drawing.Size(46, 13);
            this.BGColor.TabIndex = 7;
            this.BGColor.Text = "BGColor";
            // 
            // cmdResetXY
            // 
            this.cmdResetXY.Location = new System.Drawing.Point(460, 10);
            this.cmdResetXY.Name = "cmdResetXY";
            this.cmdResetXY.Size = new System.Drawing.Size(75, 23);
            this.cmdResetXY.TabIndex = 38;
            this.cmdResetXY.Text = "Reset";
            this.cmdResetXY.UseVisualStyleBackColor = true;
            this.cmdResetXY.Click += new System.EventHandler(this.cmdResetXY_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BGColor);
            this.panel3.Controls.Add(this.lblBGColor);
            this.panel3.Controls.Add(this.cmdBGColor);
            this.panel3.Controls.Add(this.lblBGColors);
            this.panel3.Controls.Add(this.cmdResetBG);
            this.panel3.Controls.Add(this.chkTrans);
            this.panel3.Controls.Add(this.Transparent);
            this.panel3.Controls.Add(this.lblTransparent);
            this.panel3.Location = new System.Drawing.Point(22, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 77);
            this.panel3.TabIndex = 68;
            // 
            // lblBGColors
            // 
            this.lblBGColors.AutoSize = true;
            this.lblBGColors.Location = new System.Drawing.Point(230, 14);
            this.lblBGColors.Name = "lblBGColors";
            this.lblBGColors.Size = new System.Drawing.Size(24, 13);
            this.lblBGColors.TabIndex = 26;
            this.lblBGColors.Text = "text";
            // 
            // cmdResetBG
            // 
            this.cmdResetBG.Location = new System.Drawing.Point(460, 10);
            this.cmdResetBG.Name = "cmdResetBG";
            this.cmdResetBG.Size = new System.Drawing.Size(75, 23);
            this.cmdResetBG.TabIndex = 48;
            this.cmdResetBG.Text = "Reset";
            this.cmdResetBG.UseVisualStyleBackColor = true;
            this.cmdResetBG.Click += new System.EventHandler(this.cmdResetBG_Click);
            // 
            // chkTrans
            // 
            this.chkTrans.AutoSize = true;
            this.chkTrans.Location = new System.Drawing.Point(230, 44);
            this.chkTrans.Name = "chkTrans";
            this.chkTrans.Size = new System.Drawing.Size(83, 17);
            this.chkTrans.TabIndex = 30;
            this.chkTrans.Text = "Transparent";
            this.chkTrans.UseVisualStyleBackColor = true;
            // 
            // Transparent
            // 
            this.Transparent.AutoSize = true;
            this.Transparent.Location = new System.Drawing.Point(20, 44);
            this.Transparent.Name = "Transparent";
            this.Transparent.Size = new System.Drawing.Size(64, 13);
            this.Transparent.TabIndex = 31;
            this.Transparent.Text = "Transparent";
            // 
            // lblTransparent
            // 
            this.lblTransparent.AutoSize = true;
            this.lblTransparent.Location = new System.Drawing.Point(110, 44);
            this.lblTransparent.Name = "lblTransparent";
            this.lblTransparent.Size = new System.Drawing.Size(74, 13);
            this.lblTransparent.TabIndex = 32;
            this.lblTransparent.Text = "lblTransparent";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmdResetTxt);
            this.panel4.Controls.Add(this.TxtColor);
            this.panel4.Controls.Add(this.cbxFontName);
            this.panel4.Controls.Add(this.FontName);
            this.panel4.Controls.Add(this.lblFontExample);
            this.panel4.Controls.Add(this.FontSize);
            this.panel4.Controls.Add(this.lblTxtColor);
            this.panel4.Controls.Add(this.lblTxtColors);
            this.panel4.Controls.Add(this.lblFontName);
            this.panel4.Controls.Add(this.cmdtxtcolor);
            this.panel4.Controls.Add(this.lblFontSize);
            this.panel4.Controls.Add(this.txtFontSize);
            this.panel4.Location = new System.Drawing.Point(22, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 100);
            this.panel4.TabIndex = 69;
            // 
            // cmdResetTxt
            // 
            this.cmdResetTxt.Location = new System.Drawing.Point(460, 10);
            this.cmdResetTxt.Name = "cmdResetTxt";
            this.cmdResetTxt.Size = new System.Drawing.Size(75, 23);
            this.cmdResetTxt.TabIndex = 53;
            this.cmdResetTxt.Text = "Reset";
            this.cmdResetTxt.UseVisualStyleBackColor = true;
            this.cmdResetTxt.Click += new System.EventHandler(this.cmdResetTxt_Click);
            // 
            // TxtColor
            // 
            this.TxtColor.AutoSize = true;
            this.TxtColor.Location = new System.Drawing.Point(20, 10);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(46, 13);
            this.TxtColor.TabIndex = 8;
            this.TxtColor.Text = "TxtColor";
            // 
            // FontName
            // 
            this.FontName.AutoSize = true;
            this.FontName.Location = new System.Drawing.Point(20, 40);
            this.FontName.Name = "FontName";
            this.FontName.Size = new System.Drawing.Size(56, 13);
            this.FontName.TabIndex = 9;
            this.FontName.Text = "FontName";
            // 
            // FontSize
            // 
            this.FontSize.AutoSize = true;
            this.FontSize.Location = new System.Drawing.Point(20, 70);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(48, 13);
            this.FontSize.TabIndex = 10;
            this.FontSize.Text = "FontSize";
            // 
            // lblTxtColor
            // 
            this.lblTxtColor.AutoSize = true;
            this.lblTxtColor.Location = new System.Drawing.Point(110, 10);
            this.lblTxtColor.Name = "lblTxtColor";
            this.lblTxtColor.Size = new System.Drawing.Size(56, 13);
            this.lblTxtColor.TabIndex = 16;
            this.lblTxtColor.Text = "lblTxtColor";
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(110, 40);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(66, 13);
            this.lblFontName.TabIndex = 17;
            this.lblFontName.Text = "lblFontName";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(110, 70);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(58, 13);
            this.lblFontSize.TabIndex = 18;
            this.lblFontSize.Text = "lblFontSize";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(230, 70);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(100, 20);
            this.txtFontSize.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmdResetXY);
            this.panel5.Controls.Add(this.X);
            this.panel5.Controls.Add(this.Y);
            this.panel5.Controls.Add(this.txtY);
            this.panel5.Controls.Add(this.lblX);
            this.panel5.Controls.Add(this.txtX);
            this.panel5.Controls.Add(this.lblY);
            this.panel5.Location = new System.Drawing.Point(22, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 70);
            this.panel5.TabIndex = 70;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(20, 10);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 13);
            this.X.TabIndex = 3;
            this.X.Text = "X";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(20, 40);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(14, 13);
            this.Y.TabIndex = 4;
            this.Y.Text = "Y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(230, 40);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 21;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(110, 10);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 13);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "lblx";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(230, 10);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(110, 40);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(22, 13);
            this.lblY.TabIndex = 12;
            this.lblY.Text = "lbly";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Current Settings";
            // 
            // Changes
            // 
            this.Changes.AutoSize = true;
            this.Changes.Location = new System.Drawing.Point(252, 26);
            this.Changes.Name = "Changes";
            this.Changes.Size = new System.Drawing.Size(49, 13);
            this.Changes.TabIndex = 66;
            this.Changes.Text = "Changes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Settings";
            // 
            // TimeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 358);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Changes);
            this.Controls.Add(this.label2);
            this.Name = "TimeEditorForm";
            this.Text = "Time Editor";
            this.Load += new System.EventHandler(this.TimeEditorForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFontExample;
        private System.Windows.Forms.Label lblBGColor;
        private System.Windows.Forms.ComboBox cbxFontName;
        private System.Windows.Forms.Label lblTxtColors;
        private System.Windows.Forms.Button cmdBGColor;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdtxtcolor;
        private System.Windows.Forms.Label BGColor;
        private System.Windows.Forms.Button cmdResetXY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBGColors;
        private System.Windows.Forms.Button cmdResetBG;
        private System.Windows.Forms.CheckBox chkTrans;
        private System.Windows.Forms.Label Transparent;
        private System.Windows.Forms.Label lblTransparent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cmdResetTxt;
        private System.Windows.Forms.Label TxtColor;
        private System.Windows.Forms.Label FontName;
        private System.Windows.Forms.Label FontSize;
        private System.Windows.Forms.Label lblTxtColor;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Changes;
        private System.Windows.Forms.Label label2;
    }
}

