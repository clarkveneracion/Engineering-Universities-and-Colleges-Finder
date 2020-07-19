namespace EUC_Finder_Application
{
    partial class EUC_Finder_SUC_GMap_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUC_Finder_SUC_GMap_Form));
            this.GMap_SUC_GMap_GMapConrtol = new GMap.NET.WindowsForms.GMapControl();
            this.UC_SUC_Label = new System.Windows.Forms.Label();
            this.UC_SUC_ComboBox = new System.Windows.Forms.ComboBox();
            this.Locate_SUC_GMap_Button = new System.Windows.Forms.Button();
            this.Route_SUC_GMap_Button = new System.Windows.Forms.Button();
            this.Clear_SUC_GMap_Button = new System.Windows.Forms.Button();
            this.About_SUC_GMap_Button = new System.Windows.Forms.Button();
            this.Main_Menu_SUC_GMap_Button = new System.Windows.Forms.Button();
            this.markCityHall_SUC_GMap_PictureBox = new System.Windows.Forms.PictureBox();
            this.CityHall_SUC_GMap_Label = new System.Windows.Forms.Label();
            this.markUC_SUC_GMap_PictreBox = new System.Windows.Forms.PictureBox();
            this.UC_SUC_GMap_Label = new System.Windows.Forms.Label();
            this.Address_SUC_GMap_Label = new System.Windows.Forms.Label();
            this.addressUC_SUC_GMap_Label = new System.Windows.Forms.Label();
            this.Latitude_SUC_GMap_Label = new System.Windows.Forms.Label();
            this.Longitude_SUC_GMap_Label = new System.Windows.Forms.Label();
            this.Distance_SUC_GMap_Label = new System.Windows.Forms.Label();
            this.Exit_SUC_GMap_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.markCityHall_SUC_GMap_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markUC_SUC_GMap_PictreBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GMap_SUC_GMap_GMapConrtol
            // 
            this.GMap_SUC_GMap_GMapConrtol.Bearing = 0F;
            this.GMap_SUC_GMap_GMapConrtol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GMap_SUC_GMap_GMapConrtol.CanDragMap = true;
            this.GMap_SUC_GMap_GMapConrtol.GrayScaleMode = false;
            this.GMap_SUC_GMap_GMapConrtol.LevelsKeepInMemmory = 5;
            this.GMap_SUC_GMap_GMapConrtol.Location = new System.Drawing.Point(336, 4);
            this.GMap_SUC_GMap_GMapConrtol.MarkersEnabled = true;
            this.GMap_SUC_GMap_GMapConrtol.MaxZoom = 20;
            this.GMap_SUC_GMap_GMapConrtol.MinZoom = 5;
            this.GMap_SUC_GMap_GMapConrtol.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMap_SUC_GMap_GMapConrtol.Name = "GMap_SUC_GMap_GMapConrtol";
            this.GMap_SUC_GMap_GMapConrtol.NegativeMode = false;
            this.GMap_SUC_GMap_GMapConrtol.PolygonsEnabled = true;
            this.GMap_SUC_GMap_GMapConrtol.RetryLoadTile = 0;
            this.GMap_SUC_GMap_GMapConrtol.RoutesEnabled = true;
            this.GMap_SUC_GMap_GMapConrtol.ShowTileGridLines = false;
            this.GMap_SUC_GMap_GMapConrtol.Size = new System.Drawing.Size(438, 455);
            this.GMap_SUC_GMap_GMapConrtol.TabIndex = 58;
            this.GMap_SUC_GMap_GMapConrtol.Zoom = 15D;
            this.GMap_SUC_GMap_GMapConrtol.Load += new System.EventHandler(this.GMap_SUC_GMap_GMapConrtol_Load);
            // 
            // UC_SUC_Label
            // 
            this.UC_SUC_Label.AutoSize = true;
            this.UC_SUC_Label.Location = new System.Drawing.Point(110, 28);
            this.UC_SUC_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UC_SUC_Label.Name = "UC_SUC_Label";
            this.UC_SUC_Label.Size = new System.Drawing.Size(125, 17);
            this.UC_SUC_Label.TabIndex = 59;
            this.UC_SUC_Label.Text = "University/ College";
            // 
            // UC_SUC_ComboBox
            // 
            this.UC_SUC_ComboBox.FormattingEnabled = true;
            this.UC_SUC_ComboBox.Items.AddRange(new object[] {
            "Select a University/ College"});
            this.UC_SUC_ComboBox.Location = new System.Drawing.Point(39, 57);
            this.UC_SUC_ComboBox.Name = "UC_SUC_ComboBox";
            this.UC_SUC_ComboBox.Size = new System.Drawing.Size(267, 24);
            this.UC_SUC_ComboBox.TabIndex = 60;
            this.UC_SUC_ComboBox.Text = "Select a University/ College";
            this.UC_SUC_ComboBox.SelectedIndexChanged += new System.EventHandler(this.UC_SUC_ComboBox_SelectedIndexChanged);
            // 
            // Locate_SUC_GMap_Button
            // 
            this.Locate_SUC_GMap_Button.Location = new System.Drawing.Point(39, 124);
            this.Locate_SUC_GMap_Button.Name = "Locate_SUC_GMap_Button";
            this.Locate_SUC_GMap_Button.Size = new System.Drawing.Size(75, 31);
            this.Locate_SUC_GMap_Button.TabIndex = 61;
            this.Locate_SUC_GMap_Button.Text = "Locate";
            this.Locate_SUC_GMap_Button.UseVisualStyleBackColor = true;
            this.Locate_SUC_GMap_Button.Click += new System.EventHandler(this.Locate_SUC_GMap_Button_Click);
            // 
            // Route_SUC_GMap_Button
            // 
            this.Route_SUC_GMap_Button.Location = new System.Drawing.Point(135, 124);
            this.Route_SUC_GMap_Button.Name = "Route_SUC_GMap_Button";
            this.Route_SUC_GMap_Button.Size = new System.Drawing.Size(75, 31);
            this.Route_SUC_GMap_Button.TabIndex = 62;
            this.Route_SUC_GMap_Button.Text = "Route";
            this.Route_SUC_GMap_Button.UseVisualStyleBackColor = true;
            this.Route_SUC_GMap_Button.Click += new System.EventHandler(this.Route_SUC_GMap_Button_Click);
            // 
            // Clear_SUC_GMap_Button
            // 
            this.Clear_SUC_GMap_Button.Location = new System.Drawing.Point(231, 124);
            this.Clear_SUC_GMap_Button.Name = "Clear_SUC_GMap_Button";
            this.Clear_SUC_GMap_Button.Size = new System.Drawing.Size(75, 31);
            this.Clear_SUC_GMap_Button.TabIndex = 63;
            this.Clear_SUC_GMap_Button.Text = "Clear";
            this.Clear_SUC_GMap_Button.UseVisualStyleBackColor = true;
            this.Clear_SUC_GMap_Button.Click += new System.EventHandler(this.Clear_SUC_GMap_Button_Click);
            // 
            // About_SUC_GMap_Button
            // 
            this.About_SUC_GMap_Button.Location = new System.Drawing.Point(65, 179);
            this.About_SUC_GMap_Button.Name = "About_SUC_GMap_Button";
            this.About_SUC_GMap_Button.Size = new System.Drawing.Size(75, 31);
            this.About_SUC_GMap_Button.TabIndex = 64;
            this.About_SUC_GMap_Button.Text = "View Info";
            this.About_SUC_GMap_Button.UseVisualStyleBackColor = true;
            this.About_SUC_GMap_Button.Click += new System.EventHandler(this.About_SUC_GMap_Button_Click);
            // 
            // Main_Menu_SUC_GMap_Button
            // 
            this.Main_Menu_SUC_GMap_Button.Location = new System.Drawing.Point(165, 179);
            this.Main_Menu_SUC_GMap_Button.Name = "Main_Menu_SUC_GMap_Button";
            this.Main_Menu_SUC_GMap_Button.Size = new System.Drawing.Size(101, 31);
            this.Main_Menu_SUC_GMap_Button.TabIndex = 65;
            this.Main_Menu_SUC_GMap_Button.Text = "Main Menu";
            this.Main_Menu_SUC_GMap_Button.UseVisualStyleBackColor = true;
            this.Main_Menu_SUC_GMap_Button.Click += new System.EventHandler(this.Main_Menu_SUC_GMap_Button_Click);
            // 
            // markCityHall_SUC_GMap_PictureBox
            // 
            this.markCityHall_SUC_GMap_PictureBox.Image = global::EUC_Finder_Application.Properties.Resources.City_Hall_Marker;
            this.markCityHall_SUC_GMap_PictureBox.Location = new System.Drawing.Point(39, 231);
            this.markCityHall_SUC_GMap_PictureBox.Name = "markCityHall_SUC_GMap_PictureBox";
            this.markCityHall_SUC_GMap_PictureBox.Size = new System.Drawing.Size(19, 27);
            this.markCityHall_SUC_GMap_PictureBox.TabIndex = 66;
            this.markCityHall_SUC_GMap_PictureBox.TabStop = false;
            // 
            // CityHall_SUC_GMap_Label
            // 
            this.CityHall_SUC_GMap_Label.AutoSize = true;
            this.CityHall_SUC_GMap_Label.Location = new System.Drawing.Point(60, 237);
            this.CityHall_SUC_GMap_Label.Name = "CityHall_SUC_GMap_Label";
            this.CityHall_SUC_GMap_Label.Size = new System.Drawing.Size(104, 17);
            this.CityHall_SUC_GMap_Label.TabIndex = 67;
            this.CityHall_SUC_GMap_Label.Text = "Manila City Hall";
            // 
            // markUC_SUC_GMap_PictreBox
            // 
            this.markUC_SUC_GMap_PictreBox.Image = global::EUC_Finder_Application.Properties.Resources.UC_Marker;
            this.markUC_SUC_GMap_PictreBox.Location = new System.Drawing.Point(39, 264);
            this.markUC_SUC_GMap_PictreBox.Name = "markUC_SUC_GMap_PictreBox";
            this.markUC_SUC_GMap_PictreBox.Size = new System.Drawing.Size(19, 26);
            this.markUC_SUC_GMap_PictreBox.TabIndex = 68;
            this.markUC_SUC_GMap_PictreBox.TabStop = false;
            // 
            // UC_SUC_GMap_Label
            // 
            this.UC_SUC_GMap_Label.AutoSize = true;
            this.UC_SUC_GMap_Label.Location = new System.Drawing.Point(60, 269);
            this.UC_SUC_GMap_Label.Name = "UC_SUC_GMap_Label";
            this.UC_SUC_GMap_Label.Size = new System.Drawing.Size(125, 17);
            this.UC_SUC_GMap_Label.TabIndex = 69;
            this.UC_SUC_GMap_Label.Text = "University/ College";
            // 
            // Address_SUC_GMap_Label
            // 
            this.Address_SUC_GMap_Label.AutoSize = true;
            this.Address_SUC_GMap_Label.Location = new System.Drawing.Point(39, 302);
            this.Address_SUC_GMap_Label.Name = "Address_SUC_GMap_Label";
            this.Address_SUC_GMap_Label.Size = new System.Drawing.Size(64, 17);
            this.Address_SUC_GMap_Label.TabIndex = 70;
            this.Address_SUC_GMap_Label.Text = "Address:";
            // 
            // addressUC_SUC_GMap_Label
            // 
            this.addressUC_SUC_GMap_Label.AutoSize = true;
            this.addressUC_SUC_GMap_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.addressUC_SUC_GMap_Label.Location = new System.Drawing.Point(100, 302);
            this.addressUC_SUC_GMap_Label.Name = "addressUC_SUC_GMap_Label";
            this.addressUC_SUC_GMap_Label.Size = new System.Drawing.Size(0, 17);
            this.addressUC_SUC_GMap_Label.TabIndex = 71;
            // 
            // Latitude_SUC_GMap_Label
            // 
            this.Latitude_SUC_GMap_Label.AutoSize = true;
            this.Latitude_SUC_GMap_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Latitude_SUC_GMap_Label.Location = new System.Drawing.Point(39, 332);
            this.Latitude_SUC_GMap_Label.Name = "Latitude_SUC_GMap_Label";
            this.Latitude_SUC_GMap_Label.Size = new System.Drawing.Size(63, 17);
            this.Latitude_SUC_GMap_Label.TabIndex = 72;
            this.Latitude_SUC_GMap_Label.Text = "Latitude:";
            // 
            // Longitude_SUC_GMap_Label
            // 
            this.Longitude_SUC_GMap_Label.AutoSize = true;
            this.Longitude_SUC_GMap_Label.Location = new System.Drawing.Point(39, 360);
            this.Longitude_SUC_GMap_Label.Name = "Longitude_SUC_GMap_Label";
            this.Longitude_SUC_GMap_Label.Size = new System.Drawing.Size(75, 17);
            this.Longitude_SUC_GMap_Label.TabIndex = 73;
            this.Longitude_SUC_GMap_Label.Text = "Longitude:";
            // 
            // Distance_SUC_GMap_Label
            // 
            this.Distance_SUC_GMap_Label.AutoSize = true;
            this.Distance_SUC_GMap_Label.Location = new System.Drawing.Point(39, 391);
            this.Distance_SUC_GMap_Label.Name = "Distance_SUC_GMap_Label";
            this.Distance_SUC_GMap_Label.Size = new System.Drawing.Size(67, 17);
            this.Distance_SUC_GMap_Label.TabIndex = 74;
            this.Distance_SUC_GMap_Label.Text = "Distance:";
            // 
            // Exit_SUC_GMap_Button
            // 
            this.Exit_SUC_GMap_Button.Location = new System.Drawing.Point(231, 409);
            this.Exit_SUC_GMap_Button.Name = "Exit_SUC_GMap_Button";
            this.Exit_SUC_GMap_Button.Size = new System.Drawing.Size(75, 31);
            this.Exit_SUC_GMap_Button.TabIndex = 75;
            this.Exit_SUC_GMap_Button.Text = "Exit";
            this.Exit_SUC_GMap_Button.UseVisualStyleBackColor = true;
            this.Exit_SUC_GMap_Button.Click += new System.EventHandler(this.Exit_SUC_GMap_Button_Click);
            // 
            // EUC_Finder_SUC_GMap_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 463);
            this.Controls.Add(this.Exit_SUC_GMap_Button);
            this.Controls.Add(this.Distance_SUC_GMap_Label);
            this.Controls.Add(this.Longitude_SUC_GMap_Label);
            this.Controls.Add(this.Latitude_SUC_GMap_Label);
            this.Controls.Add(this.addressUC_SUC_GMap_Label);
            this.Controls.Add(this.Address_SUC_GMap_Label);
            this.Controls.Add(this.UC_SUC_GMap_Label);
            this.Controls.Add(this.markUC_SUC_GMap_PictreBox);
            this.Controls.Add(this.CityHall_SUC_GMap_Label);
            this.Controls.Add(this.markCityHall_SUC_GMap_PictureBox);
            this.Controls.Add(this.Main_Menu_SUC_GMap_Button);
            this.Controls.Add(this.About_SUC_GMap_Button);
            this.Controls.Add(this.Clear_SUC_GMap_Button);
            this.Controls.Add(this.Route_SUC_GMap_Button);
            this.Controls.Add(this.Locate_SUC_GMap_Button);
            this.Controls.Add(this.UC_SUC_ComboBox);
            this.Controls.Add(this.UC_SUC_Label);
            this.Controls.Add(this.GMap_SUC_GMap_GMapConrtol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(795, 502);
            this.MinimumSize = new System.Drawing.Size(795, 502);
            this.Name = "EUC_Finder_SUC_GMap_Form";
            this.Text = "EUC Finder";
            this.Load += new System.EventHandler(this.EUC_Finder_CUC_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markCityHall_SUC_GMap_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markUC_SUC_GMap_PictreBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GMap_SUC_GMap_GMapConrtol;
        private System.Windows.Forms.Label UC_SUC_Label;
        private System.Windows.Forms.ComboBox UC_SUC_ComboBox;
        private System.Windows.Forms.Button Locate_SUC_GMap_Button;
        private System.Windows.Forms.Button Route_SUC_GMap_Button;
        private System.Windows.Forms.Button Clear_SUC_GMap_Button;
        private System.Windows.Forms.Button About_SUC_GMap_Button;
        private System.Windows.Forms.Button Main_Menu_SUC_GMap_Button;
        private System.Windows.Forms.PictureBox markCityHall_SUC_GMap_PictureBox;
        private System.Windows.Forms.Label CityHall_SUC_GMap_Label;
        private System.Windows.Forms.PictureBox markUC_SUC_GMap_PictreBox;
        private System.Windows.Forms.Label UC_SUC_GMap_Label;
        private System.Windows.Forms.Label Address_SUC_GMap_Label;
        private System.Windows.Forms.Label addressUC_SUC_GMap_Label;
        private System.Windows.Forms.Label Latitude_SUC_GMap_Label;
        private System.Windows.Forms.Label Longitude_SUC_GMap_Label;
        private System.Windows.Forms.Label Distance_SUC_GMap_Label;
        private System.Windows.Forms.Button Exit_SUC_GMap_Button;




    }
}