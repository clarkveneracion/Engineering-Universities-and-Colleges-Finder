using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EUC_Finder_DataAccess
{
    public static class EUC_Finder_DataAccess_Class
    {
        private static string Nickname_Register_fromBLogic;
        private static string Username_Register_fromBLogic;
        private static string Password_Register_fromBLogic;
        private static string Username_LogIn_BLogic;
        private static string Password_LogIn_BLogic;
        static void Main(string[] args)
        {

        }
        public static int saveToFile(string nName_dAccess, string uName_dAccess, string pWord_dAccess)
        {
            Nickname_Register_fromBLogic = nName_dAccess;
            Username_Register_fromBLogic = uName_dAccess;
            Password_Register_fromBLogic = pWord_dAccess;
            FileInfo fileRecord = new FileInfo(@"Users.csv");
            if (!fileRecord.Exists)
            {
                FileStream forFileRecord = fileRecord.Create();
                forFileRecord.Close();
                using (StreamWriter toFile = fileRecord.CreateText())
                {
                    toFile.WriteLine("Username, Password, Nickname");
                    toFile.WriteLine(Username_Register_fromBLogic + "," + Password_Register_fromBLogic + "," + Nickname_Register_fromBLogic);
                    toFile.Close();
                    return 1;
                }
            }
            else
            {
                bool checkReg = false;
                using (StreamReader fromFile = fileRecord.OpenText())
                {
                    while (!fromFile.EndOfStream)
                    {
                        string lineFromFile = fromFile.ReadLine();
                        string[] data = lineFromFile.Split(',');
                        if ((Username_Register_fromBLogic == data[0]) && (Password_Register_fromBLogic == data[1]))
                        {
                            checkReg = true;
                        }
                    }
                    fromFile.Close();
                }
                if (checkReg == true)
                {
                    return 2;
                }
                else
                {
                    using (StreamWriter toFile = fileRecord.AppendText())
                    {
                        toFile.WriteLine(Username_Register_fromBLogic + "," + Password_Register_fromBLogic + "," + Nickname_Register_fromBLogic);
                        toFile.Close();
                    }
                    return 3;
                }
            }
        }
        public static int readFromFile(string uName_dAccess, string pWord_dAccess)
        {
            Username_LogIn_BLogic = uName_dAccess;
            Password_LogIn_BLogic = pWord_dAccess;
            FileInfo fileRecord = new FileInfo(@"Users.csv");
            if (fileRecord.Exists)
            {
                bool checkLog = false;
                using (StreamReader fromFile = fileRecord.OpenText())
                {
                    while (!fromFile.EndOfStream)
                    {
                        string lineFromFile = fromFile.ReadLine();
                        string[] data = lineFromFile.Split(',');
                        if ((Username_LogIn_BLogic == data[0]) && (Password_LogIn_BLogic == data[1]))
                        {
                            checkLog = true;
                        }
                    }
                    fromFile.Close();
                }
                if (checkLog == true)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }
    }
}
