namespace Deneric_Delegate
{
    internal class Program
    {
        static long Multiplication(int a, int b)
        {
            return a * b;
        }

        static void ShowUpper(String msg)
        {
            Console.WriteLine(msg.ToUpper());
        }

        static void Main(string[] args)
        {
            //Func<> : Áp dụng cho phương thức có kiểu trả về khác void
            Func<int, int, long> fc = Multiplication;
            Console.WriteLine(fc(10, 20));
            //Action<>: Áp dụng cho phương thức có kiểu trả về là void
            Action<string> ac = ShowUpper;
            ac("Hello world!");
        }
    }
}
