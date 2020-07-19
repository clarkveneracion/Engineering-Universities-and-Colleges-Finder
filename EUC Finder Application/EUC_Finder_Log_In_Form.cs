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
using System.Threading;

namespace EUC_Finder_Application
{
    public partial class EUC_Finder_Log_In_Form : Form
    {
        private static string Username_LogIn_BLogic;
        private static string Password_LogIn_BLogic;
        public EUC_Finder_Log_In_Form()
        {
            InitializeComponent();
            Password_Log_In_TextBox.Text = "";
            Password_Log_In_TextBox.PasswordChar = '*';
            Password_Log_In_TextBox.MaxLength = 20;
        }

        private void EUC_Finder_Log_In_Form_Load(object sender, EventArgs e)
        {

        }

        private void Username_Log_In_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Log_In_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void forPassword_Log_In_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Password_Log_In_TextBox.PasswordChar = forPassword_Log_In_CheckBox.Checked ? '\0' : '*';
        }

        private void Log_In_Log_In_Button_Click(object sender, EventArgs e)
        {
            int checkLogIn_LogIn;
            Username_LogIn_BLogic = Username_Log_In_TextBox.ToString();
            Password_LogIn_BLogic = Password_Log_In_TextBox.ToString();
            EUC_Finder_Please_Wait_Form pw = new EUC_Finder_Please_Wait_Form();
            if (Username_Log_In_TextBox.Text == null || Password_Log_In_TextBox.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                EUC_Finder_Log_In_Form log = new EUC_Finder_Log_In_Form();
                log.ShowDialog();
            }
            checkLogIn_LogIn = EUC_Finder_BusinessLogic.EUC_Finder_BusinessLogic_Class.logUser(Username_Log_In_TextBox.Text, Password_Log_In_TextBox.Text);
            if (checkLogIn_LogIn == 1)
            {
                pw.ShowDialog();
                MessageBox.Show("Log In Succesful!", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                EUC_Finder_SUC_GMap_Form suc = new EUC_Finder_SUC_GMap_Form();
                suc.ShowDialog();
                this.Close();
            }
            else
            {
                pw.ShowDialog();
                if (checkLogIn_LogIn == 2)
                {
                    MessageBox.Show("You are not Registered", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                    EUC_Finder_Log_In_Form log = new EUC_Finder_Log_In_Form();
                    log.ShowDialog();
                    this.Close();
                }
                else if (checkLogIn_LogIn == 3)
                {
                    MessageBox.Show("Please Register an Account", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                    EUC_Finder_Main_Menu_Form MM = new EUC_Finder_Main_Menu_Form();
                    MM.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Main_Menu_Log_In_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EUC_Finder_Main_Menu_Form MM = new EUC_Finder_Main_Menu_Form();
            MM.ShowDialog();
            this.Close();
        }
    }
}
