using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211108
{
    class palya
    {
        public string csapat, telepules, csarnok;
        public int befogadokepesseg;
        public palya(string egysor)
        {
            string[] darabok = egysor.Split(';');
            csapat = darabok[0];
            telepules = darabok[1];
            csarnok = darabok[2];
            befogadokepesseg =int.Parse( darabok[3]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("palyak.txt", Encoding.UTF8);
            List<palya> palyak = new List<palya>();
            for (int i = 0; i < beolvas.Length; i++)
            {
                palyak.Add(new palya(beolvas[i]));
            }
            //tömbbel:
            palya[] palyak1 = new palya[beolvas.Length];
            for (int i = 0; i < palyak1.Length; i++)
            {
                palyak1[i] = new palya(beolvas[i]);
            }

            Console.WriteLine("2. feladat: Magyarországnak{0} kosárlabda csarnoka van.", palyak1.Length);
            Console.WriteLine("2. feladat: Magyarországnak{0} kosárlabda csarnoka van.", beolvas.Length);
            Console.WriteLine("enter");
            Console.ReadLine();

        }
    }
}
