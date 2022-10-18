using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotation_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string alapKeveres = "";
            string utolsoForgatas = "";
            string hozzaadottForgatas = "";
            string keveres = "";
           
            Random rnd = new Random();

            List<string> keveresLista = new List<string>();

            //both pieces on the U face, white faces up
            keveresLista.Add("R U R' U' R U' R' U2");
            keveresLista.Add("R U R' U' R U2 R' U'");
            keveresLista.Add("R' D' R U2 R' D R2 U R'");
            keveresLista.Add("R U' R' U R U2 R'");
            keveresLista.Add("L' U' L U L' U L U2");
            keveresLista.Add("L' U' L U L' U2 L U");
            keveresLista.Add("R U R' F R U R' U' F'");
            keveresLista.Add("L' U L U' L' U2 L");

            for (int i = 0; i < 250; i++)
            {
                alapKeveres = keveresLista[rnd.Next(0, keveresLista.Count)];
                keveres = alapKeveres;
                utolsoForgatas = alapKeveres.Split(" ").Last();
                if (utolsoForgatas == "U'" || utolsoForgatas == "U2")
                {
                    keveres = alapKeveres.Substring(0, alapKeveres.Length - 2);
                }
                else if (utolsoForgatas == "U")
                {
                    keveres = alapKeveres.Substring(0, alapKeveres.Length - 1);
                }
                else 
                {
                    keveres += " ";
                }

                switch (rnd.Next(0, 4))
                {
                    case 0:
                        hozzaadottForgatas = "U";
                        break;
                    case 1:
                        hozzaadottForgatas = "U2";
                        break;
                    case 2:
                        hozzaadottForgatas = "U'";
                        break;
                    case 3:
                        hozzaadottForgatas = "";
                        break;
                }

                keveres += hozzaadottForgatas;

                if (keveres[keveres.Length - 1] != ' ')
                {
                    keveres += " ";
                }

                switch (rnd.Next(0, 4))
                {
                    case 0:
                        keveres += ("Y");
                        break;
                    case 1:
                        keveres += ("Y2");
                        break;
                    case 2:
                        keveres += ("Y'");
                        break;
                    case 3:
                        keveres += ("");
                        break;
                }

                Console.WriteLine(keveres);

                Console.Write("\n\nIf need to rotate:\t\t");

                switch (rnd.Next(0, 2))
                {
                    case 0:
                        Console.Write("Solve to the front");
                        break;
                    case 1:
                        Console.Write("Solve to the back");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
