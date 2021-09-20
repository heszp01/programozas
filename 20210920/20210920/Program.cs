using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210920
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            feladat5();




        Console.WriteLine();
            Console.ReadLine();
        }

        static void feladat1()
        {
            Console.Write("Kérek egy számot!");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (szam % 2 == 0)
            {
                Console.WriteLine("A {0} szám páros", szam);
            }
            else
            {
                Console.WriteLine("A {0} szám páratlan", szam);
            }
        }
        static void feladat2()
        {
           
            Console.Write("Kérek egy számot!");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (szam  >= 0)
            {
                Console.WriteLine("A {0} szám páros", szam);
            }
            else
            {
                Console.WriteLine("A {0} szám negatív", szam);
            }
        }
        static void feladat3()
        {
            Console.Write("Kérek egy hömérsékletet!");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (szam >= 0)
            {
                Console.WriteLine("A {0} kint nem fagy ", szam);
            }
            else
            {
                Console.WriteLine("A {0} kint fagy", szam);
            }
        }
        static void feladat4()
        {
            Console.Write("Kérek egy számot!");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (szam> -30&& szam <40)
            {
                Console.WriteLine("A {0}szám -30 és 40 között van ", szam);
            }
            else
            {
                Console.WriteLine("A {0} szám nincs a -30 40 között van", szam);
            }
        }
        static void feladat5()
        {
            
        }

    }
}
