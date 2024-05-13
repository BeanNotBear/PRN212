namespace Interface_Generic
{
    interface IGen1<T> where T : struct
    {
        T Demo();
    }

    class Gen3 : IGen1<int>
    {
        public int Demo()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
