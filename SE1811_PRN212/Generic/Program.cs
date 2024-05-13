using System.Runtime.InteropServices;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic: Do not care boxing and unboxing
            Gen1 g1 = new Gen1() { Data = 1234}; // This is not a generic class
            Console.WriteLine(g1.ToString());

            // Generic class
            //Gen2<string> gen2 = new Gen2<string>() { Data = "Nguyen Van Nghi" };
            //Console.WriteLine(gen2.ToString());

            Gen2<int> gen3 = new Gen2<int>() { Data = 2003 };
            Console.WriteLine(gen3.ToString());

            // constraint parameter
            // using 'where' to set up
            // struct: same with (value-datatype)
            // class: same with (reference-datatype)
            // new(): same with (reference-datatype) *Note: - Have No arg constructor
                                                         // - Public
            


        }
    }
}
