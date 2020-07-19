namespace EUC_Finder_Application
{
    partial class EUC_Finder_Log_In_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUC_Finder_Log_In_Form));
            this.Password_Log_In_TextBox = new System.Windows.Forms.TextBox();
            this.Username_Log_In_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Log_In_Label = new System.Windows.Forms.Label();
            this.Username_Log_In_Label = new System.Windows.Forms.Label();
            this.forPassword_Log_In_CheckBox = new System.Windows.Forms.CheckBox();
            this.Main_Menu_Log_In_Button = new System.Windows.Forms.Button();
            this.Log_In_Log_In_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_Log_In_TextBox
            // 
            this.Password_Log_In_TextBox.Location = new System.Drawing.Point(118, 78);
            this.Password_Log_In_TextBox.Name = "Password_Log_In_TextBox";
            this.Password_Log_In_TextBox.Size = new System.Drawing.Size(168, 23);
            this.Password_Log_In_TextBox.TabIndex = 9;
            this.Password_Log_In_TextBox.TextChanged += new System.EventHandler(this.Password_Log_In_TextBox_TextChanged);
            // 
            // Username_Log_In_TextBox
            // 
            this.Username_Log_In_TextBox.Location = new System.Drawing.Point(118, 41);
            this.Username_Log_In_TextBox.Name = "Username_Log_In_TextBox";
            this.Username_Log_In_TextBox.Size = new System.Drawing.Size(168, 23);
            this.Username_Log_In_TextBox.TabIndex = 8;
            this.Username_Log_In_TextBox.TextChanged += new System.EventHandler(this.Username_Log_In_TextBox_TextChanged);
            // 
            // Password_Log_In_Label
            // 
            this.Password_Log_In_Label.AutoSize = true;
            this.Password_Log_In_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Password_Log_In_Label.Location = new System.Drawing.Point(36, 81);
            this.Password_Log_In_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_Log_In_Label.Name = "Password_Log_In_Label";
            this.Password_Log_In_Label.Size = new System.Drawing.Size(69, 17);
            this.Password_Log_In_Label.TabIndex = 7;
            this.Password_Log_In_Label.Text = "Password";
            // 
            // Username_Log_In_Label
            // 
            this.Username_Log_In_Label.AutoSize = true;
            this.Username_Log_In_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Username_Log_In_Label.Location = new System.Drawing.Point(36, 44);
            this.Username_Log_In_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_Log_In_Label.Name = "Username_Log_In_Label";
            this.Username_Log_In_Label.Size = new System.Drawing.Size(73, 17);
            this.Username_Log_In_Label.TabIndex = 6;
            this.Username_Log_In_Label.Text = "Username";
            // 
            // forPassword_Log_In_CheckBox
            // 
            this.forPassword_Log_In_CheckBox.AutoSize = true;
            this.forPassword_Log_In_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.forPassword_Log_In_CheckBox.Location = new System.Drawing.Point(118, 107);
            this.forPassword_Log_In_CheckBox.Name = "forPassword_Log_In_CheckBox";
            this.forPassword_Log_In_CheckBox.Size = new System.Drawing.Size(102, 17);
            this.forPassword_Log_In_CheckBox.TabIndex = 13;
            this.forPassword_Log_In_CheckBox.Text = "Show Password";
            this.forPassword_Log_In_CheckBox.UseVisualStyleBackColor = true;
            this.forPassword_Log_In_CheckBox.CheckedChanged += new System.EventHandler(this.forPassword_Log_In_CheckBox_CheckedChanged);
            // 
            // Main_Menu_Log_In_Button
            // 
            this.Main_Menu_Log_In_Button.Location = new System.Drawing.Point(175, 146);
            this.Main_Menu_Log_In_Button.Name = "Main_Menu_Log_In_Button";
            this.Main_Menu_Log_In_Button.Size = new System.Drawing.Size(92, 31);
            this.Main_Menu_Log_In_Button.TabIndex = 15;
            this.Main_Menu_Log_In_Button.Text = "Main Menu";
            this.Main_Menu_Log_In_Button.UseVisualStyleBackColor = true;
            this.Main_Menu_Log_In_Button.Click += new System.EventHandler(this.Main_Menu_Log_In_Button_Click);
            // 
            // Log_In_Log_In_Button
            // 
            this.Log_In_Log_In_Button.Location = new System.Drawing.Point(61, 146);
            this.Log_In_Log_In_Button.Name = "Log_In_Log_In_Button";
            this.Log_In_Log_In_Button.Size = new System.Drawing.Size(75, 31);
            this.Log_In_Log_In_Button.TabIndex = 14;
            this.Log_In_Log_In_Button.Text = "Log In";
            this.Log_In_Log_In_Button.UseVisualStyleBackColor = true;
            this.Log_In_Log_In_Button.Click += new System.EventHandler(this.Log_In_Log_In_Button_Click);
            // 
            // EUC_Finder_Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 209);
            this.Controls.Add(this.Main_Menu_Log_In_Button);
            this.Controls.Add(this.Log_In_Log_In_Button);
            this.Controls.Add(this.forPassword_Log_In_CheckBox);
            this.Controls.Add(this.Password_Log_In_TextBox);
            this.Controls.Add(this.Username_Log_In_TextBox);
            this.Controls.Add(this.Password_Log_In_Label);
            this.Controls.Add(this.Username_Log_In_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(338, 248);
            this.MinimumSize = new System.Drawing.Size(338, 248);
            this.Name = "EUC_Finder_Log_In_Form";
            this.Text = "EUC Finder";
            this.Load += new System.EventHandler(this.EUC_Finder_Log_In_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_Log_In_TextBox;
        private System.Windows.Forms.TextBox Username_Log_In_TextBox;
        private System.Windows.Forms.Label Password_Log_In_Label;
        private System.Windows.Forms.Label Username_Log_In_Label;
        private System.Windows.Forms.CheckBox forPassword_Log_In_CheckBox;
        private System.Windows.Forms.Button Main_Menu_Log_In_Button;
        private System.Windows.Forms.Button Log_In_Log_In_Button;
    }
}