using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20210927
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feladat12();
            Feladat13();


            Console.WriteLine();
            Console.ReadLine();
        }

        static void Feladat12()
        {
            Console.WriteLine("Mondj egy hónapot!");
            string honap = Console.ReadLine();
            switch (honap)
            {
                case "1":
                    Console.WriteLine("január");
                    break;

                case "2":
                    Console.WriteLine("február");
                    break;

                case "3":
                    Console.WriteLine("március");
                    break;

                case "4":
                    Console.WriteLine("április");
                    break;

                case "5":
                    Console.WriteLine("május");
                    break;

                case "6":
                    Console.WriteLine("junius");
                    break;

                case "7":
                    Console.WriteLine("julius");
                    break;

                case "8":
                    Console.WriteLine("augusztus");
                    break;

                case "9":
                    Console.WriteLine("szeptember");
                    break;

                case "10":
                    Console.WriteLine("oktober");
                    break;

                case "11":
                    Console.WriteLine("november");
                    break;

                case "12":
                    Console.WriteLine("december");
                    break;

                default:
                    Console.WriteLine("nincs ilyen honap");
                    break;
            }
        }
        static void Feladat13()
        {
            Console.WriteLine("Mondj egy hónapot!");
            string honap = Console.ReadLine();
            switch (honap)
            {
                case "január":
                    Console.WriteLine("tél");
                    break;

                case "február":
                    Console.WriteLine("tél");
                    break;

                case "március":
                    Console.WriteLine("tavasz");
                    break;

                case "április":
                    Console.WriteLine("tavasz");
                    break;

                case "május":
                    Console.WriteLine("tavasz");
                    break;

                case "június":
                    Console.WriteLine("nyár");
                    break;

                case "július":
                    Console.WriteLine("nyár");
                    break;

                case "augusztus":
                    Console.WriteLine("nyár");
                    break;

                case "szeptember":
                    Console.WriteLine("ősz");
                    break;

                case "oktober":
                    Console.WriteLine("ősz");
                    break;

                case "november":
                    Console.WriteLine("ősz");
                    break;

                case "december":
                    Console.WriteLine("tél");
                    break;

                default:
                    Console.WriteLine("nincs ilyen honap");
                    break;



            }
        }
    }
}
