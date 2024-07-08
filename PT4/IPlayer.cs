using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    public interface IPlayer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Samina { get; set; }
        public int Speed { get; set; }
        public int Power { get; set; }

        void GetInfor();
    }
}
