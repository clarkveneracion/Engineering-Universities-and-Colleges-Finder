using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EUC_Finder_Application
{
    class EUC_Finder_Extra_Class_Program
    {
        public void programStartFile()
        {
            StreamWriter toFile = new StreamWriter("UC LatLng.txt");
            toFile.WriteLine("14.598919300000000000|120.992230300000070000|Centro Escolar University|Mendiola, San Miguel");
            toFile.WriteLine("14.582175800000000000|120.986047500000040000|Emilio Aguinaldo College|San Marcelino Street, Ermita");
            toFile.WriteLine("14.602000000000000000|120.989500000000000000|University of the East|CM Recto Avenue, Sampaloc");
            toFile.WriteLine("14.603123300000000000|120.985699500000010000|Informatics International College|CM Recto Avenue, Quiapo");
            toFile.WriteLine("14.593392700000000000|120.976010900000000000|Colegio de San Juan de Letran|Muralla Street, Intramuros");
            toFile.WriteLine("14.586902000000000000|120.985705999999940000|Adamson University|San Marcelino Street, Ermita");
            toFile.WriteLine("14.591193700000000000|120.977907700000060000|Lyceum Universiy of the Philippines|Real Street, Intramuros");
            toFile.WriteLine("14.575531000000000000|120.988947999999940000|Philippine Christian University|Taft Ave, Malate");
            toFile.WriteLine("14.597533000000000000|120.982131000000000000|FEATI University|Chica Street, Sta. Cruz");
            toFile.WriteLine("14.598769000000000000|120.986646300000070000|Manuel L. Quezon University|F R Hidalgo Street, Quiapo");
            toFile.WriteLine("14.587617800000000000|120.984703200000010000|Technological University of the Philippines|Ayala Blvd., Ermita");
            toFile.WriteLine("14.599319000000000000|121.011363999999960000|Polytechnic University of the Philippines|Anonas Street, Santa Mesa");
            toFile.WriteLine("14.590244200000000000|120.978623599999990000|Mapua Institute of Technology|Muralla Street, Intramuros");
            toFile.WriteLine("14.564921300000000000|120.993946699999920000|De La Salle University|Taft Avenue, Malate");
            toFile.WriteLine("14.604142100000000000|120.987267000000030000|FEU - East Asia College|N. Reyes Street, Sampaloc");
            toFile.WriteLine("14.603014700000000000|120.990607700000060000|University of Manila|de los Santos Street, Sampaloc");
            toFile.WriteLine("14.599109000000000000|121.001433200000060000|Eulogio Amang Rodriguez Institute|Nagtahan Street, Sampaloc");
            toFile.WriteLine("14.591898200000000000|120.981479700000020000|Universidad de Manila|Munoz-Palma St, Ermita");
            toFile.WriteLine("14.587309800000000000|120.975772000000000000|Pamantasan ng Lungsod ng Maynila|Gen. Luna Street, Intramuros");
            toFile.WriteLine("14.595315000000000000|120.987977000000000000|Technological Institute of the Philippines|P. Casal, Quiapo");
            toFile.WriteLine("14.604206000000000000|120.994634000000020000|National University|F.Jhocson, Sampaloc");
            toFile.WriteLine("14.609913000000000000|120.989352000000050000|University of Santo Tomas|España Blvd, Sampaloc");
            toFile.Close();
        }
    }
}
