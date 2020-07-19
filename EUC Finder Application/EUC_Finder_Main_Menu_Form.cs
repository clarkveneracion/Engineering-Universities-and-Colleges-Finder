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

namespace EUC_Finder_Application
{
    public partial class EUC_Finder_Main_Menu_Form : Form
    {
        public EUC_Finder_Main_Menu_Form()
        {
            InitializeComponent();
           
        }

        private void EUC_Finder_Main_Menu_Form_Load(object sender, EventArgs e)
        {

        }

        private void Log_In_Main_Menu_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EUC_Finder_Log_In_Form log = new EUC_Finder_Log_In_Form();
            log.ShowDialog();
            this.Close();
        }

        private void Register_Main_Menu_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EUC_Finder_Register_Form reg = new EUC_Finder_Register_Form();
            reg.ShowDialog();
            this.Close();
        }

        private void About_Main_Menu_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Engineering Universities and Colleges (EUC) is an application that locates, direct and show some information about the certain university. This application is a project in \"Advanced Programming\" subject by the application developers.", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
