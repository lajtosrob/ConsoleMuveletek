using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleMuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a)
            List<Kifejezes> kifejezesek = new List<Kifejezes>();

            var sorok = File.ReadAllLines("kifejezesek.txt");

            foreach (var s in sorok)
            {
                var mezok = s.Split();
                kifejezesek.Add(new Kifejezes(int.Parse(mezok[0]), mezok[1], int.Parse(mezok[2])));
            }
            Console.WriteLine("Beolvasás készen van!");

            //b) LINQ
            List<Kifejezes> kifejezesek2 = File.ReadAllLines("kifejezesek.txt")
                .Select(sor => new Kifejezes(sor)).ToList(); ;

            //2.

            Console.WriteLine("2. feladat: Kifejezések száma: " + kifejezesek2.Count());

            //3.

            Console.WriteLine(kifejezesek2.Count(x => x.Muvelet(Contains("mod")));

            //4.


        }
    }
}