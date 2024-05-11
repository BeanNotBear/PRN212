using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {

        //cw + tab -> Console.WriteLine();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            // comment
            /*
                multiple-line comment
             */

            // declare variable
            // syntax: datatype name;
            int a = 10;
            double b = 1.2;
            char c = 'a';
            string s = "Hello C Sharp";
            bool isTrue = true;

            // input
            //Console.Write("Input a number: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"This is a number of int 32 : {a}");

            //Console.Write("Input a float: ");
            //b = float.Parse(Console.ReadLine());

            //Console.Write("Input a char: ");
            //c = char.Parse(Console.ReadLine());

            //// TryParse(input, out output)
            //Console.Write("Input a char: ");
            //char.TryParse(Console.ReadLine(), out c);


            // operator
            // number operator: + - * / ++a --b a++ b--
            // compare operator: > >= < <= == != (return true or false)
            // logical operator: & | ^(XOR)
            // example: 9 ^ 5
            // 1001
            // ^
            // 0101
            // 1100 = 12
            Console.WriteLine(9 ^ 5);

            // ~A = -(A+1)
            // ~9 = -(9+1) = -10
            Console.WriteLine(~9);
        }
    }
}
