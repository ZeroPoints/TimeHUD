namespace time
{
    partial class MyDigitalClock
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
            this.lblthetime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblthetime
            // 
            this.lblthetime.AutoSize = true;
            this.lblthetime.BackColor = System.Drawing.Color.Transparent;
            this.lblthetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblthetime.ForeColor = System.Drawing.Color.Yellow;
            this.lblthetime.Location = new System.Drawing.Point(12, 9);
            this.lblthetime.Name = "lblthetime";
            this.lblthetime.Size = new System.Drawing.Size(61, 31);
            this.lblthetime.TabIndex = 1;
            this.lblthetime.Text = "ace";
            // 
            // MyDigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 62);
            this.Controls.Add(this.lblthetime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(2561, 0);
            this.Name = "MyDigitalClock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblthetime;
    }
}

