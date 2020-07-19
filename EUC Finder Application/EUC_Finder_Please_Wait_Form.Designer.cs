namespace EUC_Finder_Application
{
    partial class EUC_Finder_Please_Wait_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUC_Finder_Please_Wait_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Please_Wait_Please_Wait_Label = new System.Windows.Forms.Label();
            this.Please_Wait_Please_Wait_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EUC_Finder_Application.Properties.Resources.EUC_Finder_Logo_Smaller;
            this.pictureBox1.Location = new System.Drawing.Point(72, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Please_Wait_Please_Wait_Label
            // 
            this.Please_Wait_Please_Wait_Label.AutoSize = true;
            this.Please_Wait_Please_Wait_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Please_Wait_Please_Wait_Label.Location = new System.Drawing.Point(48, 94);
            this.Please_Wait_Please_Wait_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Please_Wait_Please_Wait_Label.Name = "Please_Wait_Please_Wait_Label";
            this.Please_Wait_Please_Wait_Label.Size = new System.Drawing.Size(105, 20);
            this.Please_Wait_Please_Wait_Label.TabIndex = 1;
            this.Please_Wait_Please_Wait_Label.Text = "Please Wait...";
            this.Please_Wait_Please_Wait_Label.Click += new System.EventHandler(this.Please_Wait_Please_Wait_Label_Click);
            // 
            // Please_Wait_Please_Wait_Timer
            // 
            this.Please_Wait_Please_Wait_Timer.Enabled = true;
            this.Please_Wait_Please_Wait_Timer.Interval = 3000;
            this.Please_Wait_Please_Wait_Timer.Tick += new System.EventHandler(this.Please_Wait_Please_Wait_Timer_Tick);
            // 
            // EUC_Finder_Please_Wait_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(205, 149);
            this.Controls.Add(this.Please_Wait_Please_Wait_Label);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(221, 188);
            this.MinimumSize = new System.Drawing.Size(221, 188);
            this.Name = "EUC_Finder_Please_Wait_Form";
            this.Text = "EUC Finder";
            this.Load += new System.EventHandler(this.EUC_Finder_Please_Wait_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Please_Wait_Please_Wait_Label;
        private System.Windows.Forms.Timer Please_Wait_Please_Wait_Timer;
    }
}