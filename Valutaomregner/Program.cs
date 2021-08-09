using System;

namespace Valutaomregner
{
    class Program
    {
        static void Main(string[] args)
        {

            // Valuta Lommeregner

            // DKK to USD
            Console.WriteLine("DKK to USD");
            Console.WriteLine("Write a number: ");
           double a = double.Parse(Console.ReadLine());

           double b = a * 0.16;

           Console.WriteLine(b);

            // DKK to GBP

            Console.WriteLine("DKK to GBP");
            Console.WriteLine("Write a number: ");
            double c  = double.Parse(Console.ReadLine());

            double d = c * 0.11;

            Console.WriteLine(d);

            // DKK to Euro

            Console.WriteLine("DKK to Euro");
            Console.WriteLine("Write a number: ");
            double e = double.Parse(Console.ReadLine());

            double f = e * 0.13;

            Console.WriteLine(f);

            // DKK to Sek

            Console.WriteLine("DKK to Sek");
            Console.WriteLine("Write a number: ");
            double g = double.Parse(Console.ReadLine());

            double h = g * 1.37;

            Console.WriteLine(h);

            // Prevents the program from shutting down.

            Console.ReadKey();
        }
    }
}
