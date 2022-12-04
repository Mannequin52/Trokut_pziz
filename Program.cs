using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PripremaIspit_Trokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

        start:
            Console.WriteLine("Upisi stranicu x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisi stranicu y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisi stranicu z: ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x == 0 || y == 0 || z == 0)
            {
                Console.WriteLine("Stranica nema vrijednost, pokusajte ponovo.");
                goto start;
            }
            else
            {
                if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2)) Console.WriteLine("Stranice su stranice pravokutnog trokuta.");
                else Console.WriteLine("Stranice nisu stranice pravokutnog trokuta.");
            }
            Console.ReadKey();

        }
    }
}