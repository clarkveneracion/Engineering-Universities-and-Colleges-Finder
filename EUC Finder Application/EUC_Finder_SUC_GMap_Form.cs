using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GMap;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace EUC_Finder_Application
{
    public partial class EUC_Finder_SUC_GMap_Form : Form
    {
        public EUC_Finder_SUC_GMap_Form()
        {
            InitializeComponent();
            string[] stringSeparator = new string[] { "|" };
            string[] fileElement;
            StreamReader fromFile = new StreamReader("UC LatLng.txt");
            string lineFromFile;
            lineFromFile = fromFile.ReadLine();
            while (lineFromFile != null)
            {
                fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                UC_SUC_ComboBox.Items.Add(fileElement[2]);
                lineFromFile = fromFile.ReadLine();
            }
            fromFile.Close();
            GMap_SUC_GMap_GMapConrtol.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            GMap_SUC_GMap_GMapConrtol.Position = new GMap.NET.PointLatLng(14.589771, 120.981456);
            GMap_SUC_GMap_GMapConrtol.Zoom = 18;
            GMap_SUC_GMap_GMapConrtol.DragButton = MouseButtons.Left;
            GMapOverlay markersOverlay = new GMapOverlay(GMap_SUC_GMap_GMapConrtol, "marker");
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markCityHall = new GMapMarkerGoogleRed(new PointLatLng(14.589771, 120.981456));
            markersOverlay.Markers.Add(markCityHall);
            GMap_SUC_GMap_GMapConrtol.Overlays.Add(markersOverlay);
        }

        private void EUC_Finder_CUC_Form_Load(object sender, EventArgs e)
        {

        }

        private void UC_SUC_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Locate_SUC_GMap_Button_Click(object sender, EventArgs e)
        {
            GMap_SUC_GMap_GMapConrtol.Zoom = 18;
            GMap_SUC_GMap_GMapConrtol.Overlays.Clear();
            GMapOverlay markersOverlay = new GMapOverlay(GMap_SUC_GMap_GMapConrtol, "marker");
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markCityHall = new GMapMarkerGoogleRed(new PointLatLng(14.589771, 120.981456));
            markersOverlay.Markers.Add(markCityHall);
            GMap_SUC_GMap_GMapConrtol.Overlays.Add(markersOverlay);
            string[] stringSeparator = new string[] { "|" };
            string[] fileElement;
            StreamReader fromFile = new StreamReader("UC LatLng.txt");
            string lineFromFile;
            lineFromFile = fromFile.ReadLine();
            fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
            string slct = (string)UC_SUC_ComboBox.SelectedItem;
            if (slct == "Centro Escolar University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Emilio Aguinaldo College")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "University of the East")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Informatics International College")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Colegio de San Juan de Letran")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Adamson University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Lyceum Universiy of the Philippines")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Philippine Christian University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "FEATI University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Manuel L. Quezon University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Technological University of the Philippines")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Polytechnic University of the Philippines")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Mapua Institute of Technology")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "De La Salle University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "FEU - East Asia College")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "University of Manila")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Eulogio Amang Rodriguez Institute")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Universidad de Manila")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Pamantasan ng Lungsod ng Maynila")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Technological Institute of the Philippines")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "National University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "University of Santo Tomas")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else
            {
                MessageBox.Show("Please Select a University/ College", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                EUC_Finder_SUC_GMap_Form GMap = new EUC_Finder_SUC_GMap_Form();
                GMap.ShowDialog();
                this.Close();
            }
            addressUC_SUC_GMap_Label.Text = fileElement[3] + ", Manila";
            Latitude_SUC_GMap_Label.Text = "Latitude: " + fileElement[0];
            Longitude_SUC_GMap_Label.Text = "Longitude: " + fileElement[1];
            fromFile.Close();
            GMap_SUC_GMap_GMapConrtol.Position = new GMap.NET.PointLatLng(float.Parse(fileElement[0]), float.Parse(fileElement[1]));
            GMapOverlay markOlay = new GMapOverlay(GMap_SUC_GMap_GMapConrtol, "markers");
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markUC = new GMapMarkerGoogleGreen(new PointLatLng(float.Parse(fileElement[0]), float.Parse(fileElement[1])));
            markOlay.Markers.Add(markUC);
            GMap_SUC_GMap_GMapConrtol.Overlays.Add(markOlay);
        }

        private void Route_SUC_GMap_Button_Click(object sender, EventArgs e)
        {
            GMap_SUC_GMap_GMapConrtol.Zoom = 14;
            GMap_SUC_GMap_GMapConrtol.Overlays.Clear();
            GMapOverlay markersOverlay = new GMapOverlay(GMap_SUC_GMap_GMapConrtol, "marker");
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markCityHall = new GMapMarkerGoogleRed(new PointLatLng(14.589771, 120.981456));
            markersOverlay.Markers.Add(markCityHall);
            GMap_SUC_GMap_GMapConrtol.Overlays.Add(markersOverlay);
            string[] stringSeparator = new string[] { "|" };
            string[] fileElement;
            StreamReader fromFile = new StreamReader("UC LatLng.txt");
            string lineFromFile;
            lineFromFile = fromFile.ReadLine();
            fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
            string slct = (string)UC_SUC_ComboBox.SelectedItem;
            if (slct == "Centro Escolar University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Emilio Aguinaldo College")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "University of the East")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Informatics International College")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Colegio de San Juan de Letran")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Adamson University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Lyceum Universiy of the Philippines")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Philippine Christian University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "FEATI University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Manuel L. Quezon University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Technological University of the Philippines")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Polytechnic University of the Philippines")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Mapua Institute of Technology")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "De La Salle University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Far Eastern University - East Asia College")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "University of Manila")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Eulogio Amang Rodriguez Institute")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Universidad de Manila")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Pamantasan ng Lungsod ng Maynila")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "Technological Institute of the Philippines")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "National University")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else if (slct == "University of Santo Tomas")
            {
                while (fileElement[2] != slct)
                {
                    lineFromFile = fromFile.ReadLine();
                    fileElement = lineFromFile.Split(stringSeparator, StringSplitOptions.None);
                }
                UC_SUC_GMap_Label.Text = slct;
            }
            else
            {
                MessageBox.Show("Please Select a University/ College", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                EUC_Finder_SUC_GMap_Form GMap = new EUC_Finder_SUC_GMap_Form();
                GMap.ShowDialog();
                this.Close();
            }
            addressUC_SUC_GMap_Label.Text = fileElement[3] + ", Manila";
            Latitude_SUC_GMap_Label.Text = "Latitude: " + fileElement[0];
            Longitude_SUC_GMap_Label.Text = "Longitude: " + fileElement[1];
            fromFile.Close();
            GMap_SUC_GMap_GMapConrtol.Position = new GMap.NET.PointLatLng(double.Parse(fileElement[0]), double.Parse(fileElement[1]));
            GMapOverlay markOlay = new GMapOverlay(GMap_SUC_GMap_GMapConrtol, "Markers");
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markUC = new GMapMarkerGoogleGreen(new PointLatLng(double.Parse(fileElement[0]), double.Parse(fileElement[1])));
            markOlay.Markers.Add(markUC);
            GMap_SUC_GMap_GMapConrtol.Overlays.Add(markOlay);
            double rtDistance;
            PointLatLng rtStart = new PointLatLng(14.589771, 120.981456);
            PointLatLng rtEnd = new PointLatLng(double.Parse(fileElement[0]), double.Parse(fileElement[1]));
            MapRoute route = GMapProviders.GoogleMap.GetRouteBetweenPoints(rtStart, rtEnd, false, false, 12);
            rtDistance = route.Distance;
            GMapRoute rout = new GMapRoute(route.Points, "Route");
            GMapOverlay rtOlay = new GMapOverlay(GMap_SUC_GMap_GMapConrtol, "Routes");
            rtOlay.Routes.Add(rout);
            GMap_SUC_GMap_GMapConrtol.Overlays.Add(rtOlay);
            Distance_SUC_GMap_Label.Text = "Distance: " + rtDistance.ToString() + "Km";
        }

        private void Clear_SUC_GMap_Button_Click(object sender, EventArgs e)
        {
            addressUC_SUC_GMap_Label.Text = "";
            Latitude_SUC_GMap_Label.Text = "Latitude:";
            Longitude_SUC_GMap_Label.Text = "Longitude:";
            Distance_SUC_GMap_Label.Text = "Distance:";
            UC_SUC_GMap_Label.Text = "University/ College";
            UC_SUC_ComboBox.SelectedIndex = 0;
            GMap_SUC_GMap_GMapConrtol.Overlays.Clear();
            GMapOverlay markersOverlay = new GMapOverlay(GMap_SUC_GMap_GMapConrtol, "marker");
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markCityHall = new GMapMarkerGoogleRed(new PointLatLng(14.589771, 120.981456));
            markersOverlay.Markers.Add(markCityHall);
            GMap_SUC_GMap_GMapConrtol.Overlays.Add(markersOverlay);
        }

        private void About_SUC_GMap_Button_Click(object sender, EventArgs e)
        {

            string slct = (string)UC_SUC_ComboBox.SelectedItem;
            if (slct == "Centro Escolar University")
            {
                MessageBox.Show("Centro Escolar University \nPrivate University\nBachelor's P 35,000-40,000 per semester \n » BS in Computer Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Emilio Aguinaldo College")
            {
                MessageBox.Show("Emilio Aguinaldo College in Manila\nPrivate College\nBachelor's P 30,000-40,000 per semester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics and Communications Engineering\n» BS in Electrical Engineering \n» BS in Mechanical Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "University of the East")
            {
                MessageBox.Show("University of the East\nPrivate University\nBachelor's P 31,000-41,000 per semester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics and Communications Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» MS in Construction Management", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Informatics International College")
            {
                MessageBox.Show("Informatics International College Manila\nPrivate College\nBachelor's P 20,000-22,000 per trimester\n» BS in Computer Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Colegio de San Juan de Letran")
            {
                MessageBox.Show("Colegio de San Juan de Letran\nPrivate College\nBachelor's P 40,000 per semester\n» BS in Civil Engineering\n» BS in Electronics Engineering\n» BS in Electrical Engineering\n» BS in Industrial Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Adamson University")
            {
                MessageBox.Show("Adamson University\nPrivate University\nBachelor's P 40,000 per semester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics and Communications Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Industrial Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Lyceum Universiy of the Philippines")
            {
                MessageBox.Show("Lyceum of the Philippines University\nPrivate University\nBachelor's P 37,000-42,000 per semester\n» BS in Computer Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Philippine Christian University")
            {
                MessageBox.Show("Philippine Christian University\nPrivate University\nBachelor's P 28,000-30,000 per semester\n» BS in Computer Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "FEATI University")
            {
                MessageBox.Show("FEATI University\nPrivate University\nBachelor's P 42,000-50,000 per semester\n» BS in Civil Engineering\n» BS in Electronics and Communications Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Marine Engineering\n» BS in Geodetic Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Manuel L. Quezon University")
            {
                MessageBox.Show("Manuel L. Quezon University\nPrivate University\nBachelor's P 24,000-25,000 per semester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics and Communications Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Industrial Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Technological University of the Philippines")
            {
                MessageBox.Show("Technological University of the Philippines\nPublic University\nBachelor's P 10,000 per semester\n» BS in Civil Engineering\n» BS in Electronics and Communications Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» Master of Engineering Program\n» MS in Civil Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Polytechnic University of the Philippines")
            {
                MessageBox.Show("Polytechnic University of the Philippines\nPublic University\nBachelor's P 1,300-2,000 per semester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics and Communications Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Industrial Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Mapua Institute of Technology")
            {
                MessageBox.Show("Mapua Institute of Technology\nPrivate University\nBachelor's P 31,000-37,000 per quarter\n» BS in Computer Engineering\n» BS in Chemical Engineering\n» BS in Civil Engineering\n» BS in Electronics Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Industrial Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "De La Salle University")
            {
                MessageBox.Show("De La Salle University Manila\nPrivate University\nBachelor's P 70,000-75,000 per trimester\n» BS in Computer Engineering\n» BS in Civil Engineering\nmajor in:\n        - Construction Technology and Management\n        - Structural Engineering\n        - Transportation Engineering» BS in Electronics Engineering\n» BS in Mechanical Engineering\n» BS in Industrial Engineering\n» BS in Chemical Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Far Eastern University - East Asia College")
            {
                MessageBox.Show("Far Eastern University – East Asia College\nPrivate College\nBachelor's P 38,000-40,000 per trimester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics Engineering\n» BS in Electrical Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "University of Manila")
            {
                MessageBox.Show("University of Manila\nPrivate University\nBachelor's P 14,000-20,000 per semester\n» BS in Civil Engineering\n» BS in Industrial Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Eulogio Amang Rodriguez Institute")
            {
                MessageBox.Show("Eulogio Amang Rodriguez Institute of Science and Technology\nPublic College\nBachelor's P 6,000-7,000 per semester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics and Communications Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Chemical Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Universidad de Manila")
            {
                MessageBox.Show("Universidad de Manila\nPublic University\nNo tuition fees, but this school accepts Manila residents only\n» BS in Computer Engineering\n» BS in Electronics and Communications Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Pamantasan ng Lungsod ng Maynila")
            {
                MessageBox.Show("Pamantasan ng Lungsod ng Maynila\nPublic University\nBachelor's P 300-8,000 per semester\nAlmost free for Manila residents\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Chemical Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "Technological Institute of the Philippines")
            {
                MessageBox.Show("Technological Institute of the Philippines\nPrivate College\nBachelor's P 34,000-35,000 per semester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Industrial Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "National University")
            {
                MessageBox.Show("National University\nPrivate University\nBachelor's P 28,000 per semester\n» BS in Computer Engineering\n» BS in Civil Engineering\n» BS in Electronics Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Environmental and Sanitary Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (slct == "University of Santo Tomas")
            {
                MessageBox.Show("University of Santo Tomas\nPrivate University\nBachelor's P 40,000-60,000 per semester\n» BS in Civil Engineering\n» BS in Electronics Engineering\n» BS in Electrical Engineering\n» BS in Mechanical Engineering\n» BS in Industrial Engineering\n» BS in Chemical Engineering", slct, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Select a University/ College", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                EUC_Finder_SUC_GMap_Form GMap = new EUC_Finder_SUC_GMap_Form();
                GMap.ShowDialog();
                this.Close();
            }
        }

        private void Main_Menu_SUC_GMap_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EUC_Finder_Main_Menu_Form MM = new EUC_Finder_Main_Menu_Form();
            MM.ShowDialog();
            this.Close();
        }

        private void Exit_SUC_GMap_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using EUC Finder", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void GMap_SUC_GMap_GMapConrtol_Load(object sender, EventArgs e)
        {

        }
    }
}