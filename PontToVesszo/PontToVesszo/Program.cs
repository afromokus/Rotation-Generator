using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PontToVesszo
{
    class Program
    {
        static void Main(string[] args)
        {
            string tartalom = File.ReadAllText("E:\\Letöltések\\csTimerExport_20211226_150448.csv");
            string javitottSzoveg = "";

            foreach(char c in tartalom) 
            {
                if(c == '.') 
                {
                    javitottSzoveg += ',';
                }
                else 
                {
                    javitottSzoveg += c;
                }
            }

            Console.WriteLine(javitottSzoveg);

            File.WriteAllText("E:\\Letöltések\\csTimerExportJavitott.csv", javitottSzoveg);


            Console.ReadKey();
        }
    }
}
