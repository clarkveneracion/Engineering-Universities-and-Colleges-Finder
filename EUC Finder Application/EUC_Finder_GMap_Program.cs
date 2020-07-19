using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EUC_Finder_Application
{
    static class EUC_Finder_GMap_Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EUC_Finder_Extra_Class_Program eClass = new EUC_Finder_Extra_Class_Program();
            eClass.programStartFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EUC_Finder_Main_Menu_Form());
        }
    }
}
