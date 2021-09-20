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
            //feladat4(); (nem müködik)
        




        Console.WriteLine();
            Console.ReadLine();
        }

       private static void feladat1(string[] args)
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
       private void feladat2(string[] args)
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
       private static void feladat3(string[] args)
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
       private static void feladat4(string[] args)
        {
            Console.Write("Kérek egy számot!");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (szam -30== 40)
            {
                Console.WriteLine("A {0}szám -30 és 40 között van ", szam);
            }
            else
            {
                Console.WriteLine("A {0} szám nincs a -30 40 között van", szam);
            }
        }

    }
}
