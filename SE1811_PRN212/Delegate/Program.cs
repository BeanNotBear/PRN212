namespace Delegate
{
    public delegate long Dele1(int a, int b);

    internal class Program
    {
        static long Add(int a, int b)
        {
            return a + b;
        }

        static long Sub(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            // Delegate: <=> function pointer
            // Allow point to one or many function
            // Can allow point to one function many time
            // Must same with function about signature:
            // number of parameter, datatype, return datatype
            Dele1 dele1 = new Dele1(Add);
            Console.WriteLine(dele1.Invoke(10, 20));
        }
    }
}
