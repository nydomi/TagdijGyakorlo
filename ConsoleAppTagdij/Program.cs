using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTagdij
{
    internal class Program
    {
        static Database database = new Database();
        static List<Ugyfel> ugyfel = new List<Ugyfel>(); 
        static void Main(string[] args)
        {
            ugyfel = database.getUgyfel();
            feladat01();
            feladat02();
            feladat03();

            Console.ReadKey();
        }
        public static void feladat01()
        {
            Console.WriteLine("Első feladat!\n\tjelenítsd meg az ügyfelek számát");
            Console.WriteLine(ugyfel.Count);
        }
        public static void feladat02()
        {
            Console.WriteLine("\nMásodik feladat!\n\tlistázd ki a magyarországi ügyfeleket");
            for (int i = 0;i<ugyfel.Count;i++)
            {
                if (ugyfel[i].orsz=="H")
                {
                    Console.WriteLine(ugyfel[i].nev);
                }
            }
        }
        public static void feladat03()
        {
            Console.WriteLine("\nHarmadik feladat!\n\tjelenítsd meg a legfiatalabb ugyfelet");
            string legFiatalabb = "";
            int min = 0;
            for (int i = 0; i < ugyfel.Count; i++)
            {
                if (ugyfel[i].szulev>min)
                {
                    min = ugyfel[i].szulev;
                    legFiatalabb = ugyfel[i].nev;
                }
            }
            Console.WriteLine(legFiatalabb);
        }
    }
}
