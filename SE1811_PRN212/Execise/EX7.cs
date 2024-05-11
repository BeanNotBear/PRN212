using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise
{
    internal class EX7
    {
        static double CalculatePerimeter(double[] arr)
        {
            return arr[0] + arr[1] + arr[2];
        }

        static double CalculateArea(double[] arr)
        {
            double perimeter = CalculatePerimeter(arr)/2;
            return Math.Sqrt(perimeter * (perimeter - arr[0]) * (perimeter - arr[1]) * (perimeter - arr[2]));
        }

        static void Main(string[] args)
        {
            double[] arr = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter c{i}: ");
                arr[i] = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Perimeter: {CalculatePerimeter(arr)}");
            Console.WriteLine($"Area: {CalculateArea(arr)}");
        }
    }
}
