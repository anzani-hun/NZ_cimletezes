using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_cimletezes
{
    internal class Program
    {
        static void Main()
        {
            // Címletezés - Kérjen be egy összeget és írja ki milyen fizetőeszközökkel teljesíthető.

            int osszeg;
            Console.Write("Kérek egy egész összeget: ");
            osszeg = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nEz az összeg a legkevesebb bankjegy felhasználásával így bontható fel: ");
            //cimletezo függvény meghívása:
            Cimletezo(osszeg);


            Console.ReadKey();

        }

        //cimletezo függvény
        static void Cimletezo(int osszeg)
        {
            int[] cimletek = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };

            foreach (int cimlet in cimletek)
            { 
                if ( osszeg >= cimlet )
                {
                    int darab = osszeg / cimlet;
                    Console.WriteLine($"[{darab}] darab {cimlet} forintos kell");
                    osszeg %= cimlet;
                }
            }
        }

    }
}
