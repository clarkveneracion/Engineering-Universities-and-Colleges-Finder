namespace EUC_Finder_Application
{
    partial class EUC_Finder_Main_Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUC_Finder_Main_Menu_Form));
            this.About_Main_Menu_Button = new System.Windows.Forms.Button();
            this.Register_Main_Menu_Button = new System.Windows.Forms.Button();
            this.Log_In_Main_Menu_Button = new System.Windows.Forms.Button();
            this.Welcom_Address = new System.Windows.Forms.Label();
            this.EUC_Finder_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EUC_Finder_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // About_Main_Menu_Button
            // 
            this.About_Main_Menu_Button.Location = new System.Drawing.Point(210, 179);
            this.About_Main_Menu_Button.Name = "About_Main_Menu_Button";
            this.About_Main_Menu_Button.Size = new System.Drawing.Size(75, 31);
            this.About_Main_Menu_Button.TabIndex = 9;
            this.About_Main_Menu_Button.Text = "About";
            this.About_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.About_Main_Menu_Button.Click += new System.EventHandler(this.About_Main_Menu_Button_Click);
            // 
            // Register_Main_Menu_Button
            // 
            this.Register_Main_Menu_Button.Location = new System.Drawing.Point(124, 179);
            this.Register_Main_Menu_Button.Name = "Register_Main_Menu_Button";
            this.Register_Main_Menu_Button.Size = new System.Drawing.Size(75, 31);
            this.Register_Main_Menu_Button.TabIndex = 8;
            this.Register_Main_Menu_Button.Text = "Register";
            this.Register_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.Register_Main_Menu_Button.Click += new System.EventHandler(this.Register_Main_Menu_Button_Click);
            // 
            // Log_In_Main_Menu_Button
            // 
            this.Log_In_Main_Menu_Button.Location = new System.Drawing.Point(38, 179);
            this.Log_In_Main_Menu_Button.Name = "Log_In_Main_Menu_Button";
            this.Log_In_Main_Menu_Button.Size = new System.Drawing.Size(75, 31);
            this.Log_In_Main_Menu_Button.TabIndex = 7;
            this.Log_In_Main_Menu_Button.Text = "Log In";
            this.Log_In_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.Log_In_Main_Menu_Button.Click += new System.EventHandler(this.Log_In_Main_Menu_Button_Click);
            // 
            // Welcom_Address
            // 
            this.Welcom_Address.AutoSize = true;
            this.Welcom_Address.Font = new System.Drawing.Font("Rockwell", 14F);
            this.Welcom_Address.Location = new System.Drawing.Point(47, 25);
            this.Welcom_Address.Name = "Welcom_Address";
            this.Welcom_Address.Size = new System.Drawing.Size(229, 21);
            this.Welcom_Address.TabIndex = 6;
            this.Welcom_Address.Text = "Welcome to EUC Finder!";
            // 
            // EUC_Finder_Logo
            // 
            this.EUC_Finder_Logo.Image = global::EUC_Finder_Application.Properties.Resources.EUC_Finder_Logo;
            this.EUC_Finder_Logo.Location = new System.Drawing.Point(97, 49);
            this.EUC_Finder_Logo.Name = "EUC_Finder_Logo";
            this.EUC_Finder_Logo.Size = new System.Drawing.Size(119, 124);
            this.EUC_Finder_Logo.TabIndex = 5;
            this.EUC_Finder_Logo.TabStop = false;
            // 
            // EUC_Finder_Main_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 235);
            this.Controls.Add(this.About_Main_Menu_Button);
            this.Controls.Add(this.Register_Main_Menu_Button);
            this.Controls.Add(this.Log_In_Main_Menu_Button);
            this.Controls.Add(this.Welcom_Address);
            this.Controls.Add(this.EUC_Finder_Logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(338, 274);
            this.MinimumSize = new System.Drawing.Size(338, 274);
            this.Name = "EUC_Finder_Main_Menu_Form";
            this.Text = "EUC Finder";
            this.Load += new System.EventHandler(this.EUC_Finder_Main_Menu_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EUC_Finder_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button About_Main_Menu_Button;
        private System.Windows.Forms.Button Register_Main_Menu_Button;
        private System.Windows.Forms.Button Log_In_Main_Menu_Button;
        private System.Windows.Forms.Label Welcom_Address;
        private System.Windows.Forms.PictureBox EUC_Finder_Logo;

    }
}

