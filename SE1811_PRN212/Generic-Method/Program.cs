namespace Generic_Method
{
    class Gen2
    {
        public void ShowData<T, U>(T id, U value)
        {
            Console.WriteLine($"id = {id}, value = {value}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Gen2 gen1 = new Gen2();
            gen1.ShowData(1.2, "Nguyen Van Nghi");
        }
    }
}
