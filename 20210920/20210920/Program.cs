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
            Console.Write("Kérek egy számot!");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if(szam % 2 ==0)
            {
                Console.WriteLine("A {0} szám páros", szam);
            }
            else
            {
                Console.WriteLine("A {0} szám páratlan", szam);
            }



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
