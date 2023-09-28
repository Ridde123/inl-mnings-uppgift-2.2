using System;

namespace uppgift_2_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin? Svara i meter.");
            double elinsHöjd = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma? Svara i meter.");
            double almasHöjd = double.Parse(Console.ReadLine());

            double skillnad = elinsHöjd - almasHöjd;
            Console.WriteLine($"Elin hoppade {skillnad} meter längre än Alma.");
            Console.ReadKey();
        }
    }
}