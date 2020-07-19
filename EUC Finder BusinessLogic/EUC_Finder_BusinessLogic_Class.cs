using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EUC_Finder_DataAccess;

namespace EUC_Finder_BusinessLogic
{
    public class EUC_Finder_BusinessLogic_Class
    {
        private static string Nickname_Register_BLogic;
        private static string Username_Register_BLogic;
        private static string Password_Register_BLogic;
        private static string Username_LogIn_BLogic;
        private static string Password_LogIn_BLogic;
        static void Main(string[] args)
        {

        }
        public static int regUser(string nName_BLogic, string uName_BLogic, string pWord_BLogic)
        {
            Nickname_Register_BLogic = nName_BLogic;
            Username_Register_BLogic = uName_BLogic;
            Password_Register_BLogic = pWord_BLogic;
            return EUC_Finder_DataAccess.EUC_Finder_DataAccess_Class.saveToFile(Nickname_Register_BLogic, Username_Register_BLogic, Password_Register_BLogic);
        }
        public static int logUser(string uName_BLogic, string pWord_BLogic)
        {
            Username_LogIn_BLogic = uName_BLogic;
            Password_LogIn_BLogic = pWord_BLogic;
            return EUC_Finder_DataAccess.EUC_Finder_DataAccess_Class.readFromFile(Username_LogIn_BLogic, Password_LogIn_BLogic);
        }
    }
}
