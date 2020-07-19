namespace EUC_Finder_Application
{
    partial class EUC_Finder_Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUC_Finder_Register_Form));
            this.Password_Register_TextBox = new System.Windows.Forms.TextBox();
            this.Username_Register_TextBox = new System.Windows.Forms.TextBox();
            this.Nickname_Register_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Register_Label = new System.Windows.Forms.Label();
            this.Username_Register_Label = new System.Windows.Forms.Label();
            this.Nickname_Register_Label = new System.Windows.Forms.Label();
            this.forPassword_Register_CheckBox = new System.Windows.Forms.CheckBox();
            this.Main_Menu_Register_Button = new System.Windows.Forms.Button();
            this.Register_Register_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_Register_TextBox
            // 
            this.Password_Register_TextBox.Location = new System.Drawing.Point(117, 104);
            this.Password_Register_TextBox.Name = "Password_Register_TextBox";
            this.Password_Register_TextBox.Size = new System.Drawing.Size(168, 23);
            this.Password_Register_TextBox.TabIndex = 13;
            this.Password_Register_TextBox.TextChanged += new System.EventHandler(this.Password_Register_TextBox_TextChanged);
            // 
            // Username_Register_TextBox
            // 
            this.Username_Register_TextBox.Location = new System.Drawing.Point(117, 67);
            this.Username_Register_TextBox.Name = "Username_Register_TextBox";
            this.Username_Register_TextBox.Size = new System.Drawing.Size(168, 23);
            this.Username_Register_TextBox.TabIndex = 12;
            this.Username_Register_TextBox.TextChanged += new System.EventHandler(this.Username_Register_TextBox_TextChanged);
            // 
            // Nickname_Register_TextBox
            // 
            this.Nickname_Register_TextBox.Location = new System.Drawing.Point(117, 31);
            this.Nickname_Register_TextBox.Name = "Nickname_Register_TextBox";
            this.Nickname_Register_TextBox.Size = new System.Drawing.Size(168, 23);
            this.Nickname_Register_TextBox.TabIndex = 11;
            this.Nickname_Register_TextBox.TextChanged += new System.EventHandler(this.Nickname_Register_TextBox_TextChanged);
            // 
            // Password_Register_Label
            // 
            this.Password_Register_Label.AutoSize = true;
            this.Password_Register_Label.Location = new System.Drawing.Point(37, 106);
            this.Password_Register_Label.Name = "Password_Register_Label";
            this.Password_Register_Label.Size = new System.Drawing.Size(69, 17);
            this.Password_Register_Label.TabIndex = 10;
            this.Password_Register_Label.Text = "Password";
            // 
            // Username_Register_Label
            // 
            this.Username_Register_Label.AutoSize = true;
            this.Username_Register_Label.Location = new System.Drawing.Point(37, 69);
            this.Username_Register_Label.Name = "Username_Register_Label";
            this.Username_Register_Label.Size = new System.Drawing.Size(73, 17);
            this.Username_Register_Label.TabIndex = 9;
            this.Username_Register_Label.Text = "Username";
            // 
            // Nickname_Register_Label
            // 
            this.Nickname_Register_Label.AutoSize = true;
            this.Nickname_Register_Label.Location = new System.Drawing.Point(37, 33);
            this.Nickname_Register_Label.Name = "Nickname_Register_Label";
            this.Nickname_Register_Label.Size = new System.Drawing.Size(70, 17);
            this.Nickname_Register_Label.TabIndex = 8;
            this.Nickname_Register_Label.Text = "Nickname";
            // 
            // forPassword_Register_CheckBox
            // 
            this.forPassword_Register_CheckBox.AutoSize = true;
            this.forPassword_Register_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.forPassword_Register_CheckBox.Location = new System.Drawing.Point(117, 130);
            this.forPassword_Register_CheckBox.Name = "forPassword_Register_CheckBox";
            this.forPassword_Register_CheckBox.Size = new System.Drawing.Size(102, 17);
            this.forPassword_Register_CheckBox.TabIndex = 17;
            this.forPassword_Register_CheckBox.Text = "Show Password";
            this.forPassword_Register_CheckBox.UseVisualStyleBackColor = true;
            this.forPassword_Register_CheckBox.CheckedChanged += new System.EventHandler(this.forPassword_Register_CheckBox_CheckedChanged);
            // 
            // Main_Menu_Register_Button
            // 
            this.Main_Menu_Register_Button.Location = new System.Drawing.Point(174, 163);
            this.Main_Menu_Register_Button.Name = "Main_Menu_Register_Button";
            this.Main_Menu_Register_Button.Size = new System.Drawing.Size(85, 31);
            this.Main_Menu_Register_Button.TabIndex = 21;
            this.Main_Menu_Register_Button.Text = "Main Menu";
            this.Main_Menu_Register_Button.UseVisualStyleBackColor = true;
            this.Main_Menu_Register_Button.Click += new System.EventHandler(this.Main_Menu_Register_Button_Click);
            // 
            // Register_Register_Button
            // 
            this.Register_Register_Button.Location = new System.Drawing.Point(64, 163);
            this.Register_Register_Button.Name = "Register_Register_Button";
            this.Register_Register_Button.Size = new System.Drawing.Size(75, 31);
            this.Register_Register_Button.TabIndex = 20;
            this.Register_Register_Button.Text = "Register";
            this.Register_Register_Button.UseVisualStyleBackColor = true;
            this.Register_Register_Button.Click += new System.EventHandler(this.Register_Register_Button_Click);
            // 
            // EUC_Finder_Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 209);
            this.Controls.Add(this.Main_Menu_Register_Button);
            this.Controls.Add(this.Register_Register_Button);
            this.Controls.Add(this.forPassword_Register_CheckBox);
            this.Controls.Add(this.Password_Register_TextBox);
            this.Controls.Add(this.Username_Register_TextBox);
            this.Controls.Add(this.Nickname_Register_TextBox);
            this.Controls.Add(this.Password_Register_Label);
            this.Controls.Add(this.Username_Register_Label);
            this.Controls.Add(this.Nickname_Register_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(338, 248);
            this.MinimumSize = new System.Drawing.Size(338, 248);
            this.Name = "EUC_Finder_Register_Form";
            this.Text = "EUC Finder";
            this.Load += new System.EventHandler(this.EUC_Finder_Register_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_Register_TextBox;
        private System.Windows.Forms.TextBox Username_Register_TextBox;
        private System.Windows.Forms.TextBox Nickname_Register_TextBox;
        private System.Windows.Forms.Label Password_Register_Label;
        private System.Windows.Forms.Label Username_Register_Label;
        private System.Windows.Forms.Label Nickname_Register_Label;
        private System.Windows.Forms.CheckBox forPassword_Register_CheckBox;
        private System.Windows.Forms.Button Main_Menu_Register_Button;
        private System.Windows.Forms.Button Register_Register_Button;
    }
}