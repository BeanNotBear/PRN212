using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    internal class Movie : IMovie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Director { get; set; }
        public string Subtitle { get; set; }
        public float AverageRate { get; set; }
        public string Language { get; set; }
        public float[] RateList { get; set; } = new float[3];

        public void Display()
        {
            Console.WriteLine($"{this.Name}, {PublishDate}, {Director}, {Language}, {AverageRate}");
        }

        public double this[int index]
        {
            get { return RateList[index]; }
            set { RateList[index] = (float)value; }
        }

        public float CalculateAverageRate(float[] avg)
        {
            float rate = 0;
            for (int i = 0; i < avg.Length; i++)
            {
                rate += avg[i];
            }
            return rate/avg.Length;
        }

    }

}
