using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    // where T : struct -> int, float, double, ... (not string)
    // where T : class - > Cat, Dog, Animal, IAnimal, ...
    // where T : new() -> must have no arg constructor, public
    // where T : U // if T is int then U is int
    // where T : U where U : class 
    // where T : U where U : struct --ERROR--
    public class Gen2<T, U> where T : U where U : class// T is used to receive datatype
    {
        public T Data { get; set; }

        public override string ToString()
        {
            return $"{this.Data}";
        }
    }
}
