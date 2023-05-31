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

            Console.WriteLine("3. feladat: Kifejetések maradékos osztással: " + kifejezesek2.Count(x => x.Muvelet == "mod"));

            //4.

            Console.Write("4. feladat: ");
            Console.WriteLine(kifejezesek2.Any(x => x.OperandusBal % 10 == 0 && x.OperandusJobb % 10 == 0) ? "Van ilyen kifejezés" : "Nincs ilyen kifejezés");

            //5.

            Console.WriteLine("5. feladat: Statisztika");
            kifejezesek.Where(x => ValosOperator(x.Muvelet))
                .GroupBy(x => x.Muvelet)
                .ToList()
                .ForEach(x => Console.WriteLine($"\t{x.Key} -> {x.Count()} db"));

            //6.

            // eredmeny() metódus Kifejezes.cs-ben.

            //7. 

            string inputTxt = "";
            do
            {
                Console.Write($"7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                inputTxt = Console.ReadLine();
                if ( inputTxt.ToLower() != "vége")
                {
                    Console.WriteLine($"\t{new Kifejezes(inputTxt).Eredmeny()}");
                }
            } while (inputTxt.ToLower() != "vége");

            //8.

            Console.WriteLine("8. feladat: eredmenyek.txt");
            File.WriteAllLines("eredmenyek.txt", kifejezesek.Select(x => x.Eredmeny()));

            //kifejezesek.ForEach(x => Console.WriteLine(x.Eredmeny()));
            
        }
        static string[] LetezoMuveletek = { "+", "-", "*", "/", "mod", "div", "%" };
        private static bool ValosOperator(String muvelet)
        {
            foreach (var item in LetezoMuveletek)
            {
                if (item == muvelet)
                {
                    return true;
                }
            }
            return false;
        }
    }
}