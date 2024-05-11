using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise
{
    internal class EX5
    {
        static double CalculateAverage(double[] score)
        {
            double avg = score[0] * 0.25 + score[1] * 0.25 + score[2] * 0.5;
            return avg;
        }

        static void Main(string[] args)
        {
            double[] score = new double[3];
            Console.Write("Điểm thi lần 1: ");
            score[0] = Double.Parse(Console.ReadLine());
            Console.Write("Điểm thi online: ");
            score[1] = Double.Parse(Console.ReadLine());
            Console.Write("Điểm thi cuối kỳ: ");
            score[2] = Double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateAverage(score));
        }
    }
}
