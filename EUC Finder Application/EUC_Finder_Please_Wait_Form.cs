using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EUC_Finder_Application
{
    public partial class EUC_Finder_Please_Wait_Form : Form
    {
        public EUC_Finder_Please_Wait_Form()
        {
            InitializeComponent();
        }

        private void EUC_Finder_Please_Wait_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Please_Wait_Please_Wait_Label_Click(object sender, EventArgs e)
        {
            
        }

        private void Please_Wait_Please_Wait_Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
