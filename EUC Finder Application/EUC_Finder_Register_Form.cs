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
    public partial class EUC_Finder_Register_Form : Form
    {
        private static string Nickname_Register_BLogic;
        private static string Username_Register_BLogic;
        private static string Password_Register_BLogic;
        public EUC_Finder_Register_Form()
        {
            InitializeComponent();
            Password_Register_TextBox.Text = "";
            Password_Register_TextBox.PasswordChar = '*';
            Password_Register_TextBox.MaxLength = 20;
        }

        private void EUC_Finder_Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void Nickname_Register_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Username_Register_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Register_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void forPassword_Register_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Password_Register_TextBox.PasswordChar = forPassword_Register_CheckBox.Checked ? '\0' : '*';
        }

        private void Register_Register_Button_Click(object sender, EventArgs e)
        {
            int checkRegister_Register;
            Nickname_Register_BLogic = Nickname_Register_TextBox.Text.ToString();
            Username_Register_BLogic = Username_Register_TextBox.Text.ToString();
            Password_Register_BLogic = Password_Register_TextBox.Text.ToString();
            EUC_Finder_Please_Wait_Form pw = new EUC_Finder_Please_Wait_Form();
            if (Username_Register_TextBox.Text == string.Empty || Password_Register_TextBox.Text == string.Empty || Nickname_Register_TextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill up all fields", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                EUC_Finder_Register_Form reg = new EUC_Finder_Register_Form();
                reg.ShowDialog();
                this.Close();
            }
            checkRegister_Register = EUC_Finder_BusinessLogic.EUC_Finder_BusinessLogic_Class.regUser(Nickname_Register_BLogic, Username_Register_BLogic, Password_Register_BLogic);
            if (checkRegister_Register == 1)
            {
                pw.ShowDialog();
                MessageBox.Show("You are Successfully Registered!", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                EUC_Finder_Main_Menu_Form MM = new EUC_Finder_Main_Menu_Form();
                MM.ShowDialog();
                this.Close();
            }
            else
            {
                pw.ShowDialog();
                if (checkRegister_Register == 2)
                {
                    MessageBox.Show("Account already registered.", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                    EUC_Finder_Register_Form reg = new EUC_Finder_Register_Form();
                    reg.ShowDialog();
                    this.Close();
                }
                else if (checkRegister_Register == 3)
                {
                    MessageBox.Show("You are Successfully Registered!", "EUC Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    EUC_Finder_Main_Menu_Form MM = new EUC_Finder_Main_Menu_Form();
                    MM.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Main_Menu_Register_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EUC_Finder_Main_Menu_Form MM = new EUC_Finder_Main_Menu_Form();
            MM.ShowDialog();
            this.Close();
        }
    }
}
