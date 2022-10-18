using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace szamlalo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            sikeressegSzamitas();
        }

        private static void sikeressegSzamitas()
        {
            do
            {
                //képernyő letisztítása
                Console.Clear();

                //deklarálás
                string bevitel = "";
                int i = 1;
                char aktEr = 'd';

                //10-szer ismételd, számold
                for (; i <= 10; i++)
                {
                    Console.Write(i + ". megoldás: \n\t");

                    //beütött karakter beolvasása
                    aktEr = Console.ReadKey().KeyChar;

                    //sortörés
                    Console.WriteLine("\n");
                    //beírt karakter hozzáadása az eddig beírtakhoz
                    bevitel += aktEr;
                }

                //kiszámolt eredmény kiírása
                Console.WriteLine("Sikeres megoldások száma:\t" + bevitel.Count(x => x == '+'));

            }
            //amíg le nem nyomjuk a ciklus végén a kívánt betűt ismétlődik
            while (Console.ReadKey().KeyChar != 's');

        }
    }
}
