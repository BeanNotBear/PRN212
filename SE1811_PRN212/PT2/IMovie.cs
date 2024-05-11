using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    internal interface IMovie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Director { get; set; }
        public string Subtitle { get; set; }
        public float AverageRate { get; set; }

        void Display();
    }
}
