using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CA200323
{
    class Program
    {
        static List<Ar> arak;
        static int min2;
        static void Main(string[] args)
        {
            Beolvas();
            F03();
            F04();
            //Matrix();
            F05();
            F06();
            Console.ReadKey();
        }

        private static void F06()
        {
            bool volt = arak.Any(a => a.SzokoEv && a.Datum.Month == 2 && a.Datum.Day == 24);
            Console.WriteLine(volt ? "volt" :  "nem volt");
        }

        private static void F05()
        {
            //SELECT COUNT(kul) FROM arak WHERE MIN(kul) == kul)
            var dbMin1 = arak.Count(a => a.Kulonbseg == min2);

            var dbMin2 = arak.Count(
                a => Math.Abs(a.Benzin - a.Gazolaj) ==
                arak.Min(b => Math.Abs(b.Benzin - b.Gazolaj)));

            Console.WriteLine(dbMin1);
            Console.WriteLine(dbMin2);
        }

        private static void Matrix()
        {
            int[,] m1 = new int[,] { { 12, 10, 2 }, { 3, 10, 2 }, { 1, 20, 23 } };
            int[][] m2 = { new int[] { 20, 50 }, new int[] { 32, 20, 10, }, new int[] { 2 } };

            //int min1 = m1.Min(x => x.Min());
            var min2 = m2.Min(x => x.Min());
            Console.WriteLine(min2);
        }

        private static void F04()
        {
            //int min = arak.Min(a => a.Kulonbseg);
            //Console.WriteLine($"lkk: {min}");

            min2 = arak.Min(a => (Math.Abs(a.Benzin - a.Gazolaj)));
            Console.WriteLine($"lkk: {min2}");

        }

        private static void F03()
        {
            //lista hossza
        }

        private static void Beolvas()
        {
            arak = new List<Ar>();
            var sr = new StreamReader(@"..\..\Res\uzemanyag.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                arak.Add(new Ar(sr.ReadLine()));
            }
            sr.Close();
            
        }
    }
}
