using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise
{
    internal class EX6
    {
        static double CalculatePerimeter(double n, double m)
        {
            double p = Math.Sqrt(n * n + m * m);
            return n + m + p;
        }

        static double CalculateArea(double n, double m)
        {
            return (n * m) / 2;
        }

        static void Main(string[] args)
        {
            double m, n;
            Console.Write("Enter n: ");
            n = Double.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            m = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Perimeter: {CalculatePerimeter(n, m)}");
            Console.WriteLine($"Area: {CalculateArea(n, m)}");
        }
    }
}
