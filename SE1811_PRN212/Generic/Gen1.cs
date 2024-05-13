using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Gen1
    {
        public int Data { get; set; }

        public override string ToString()
        {
            return $"{this.Data}";
        }
    }
}
