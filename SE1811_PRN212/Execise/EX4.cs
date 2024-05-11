using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise
{
    internal class EX4
    {
        static void SplitNumnber(int n)
        {
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                int remider = n % 10;
                n /= 10;
                stack.Push(remider);
            }
            while (stack.Count > 0)
            {
                
                if (stack.Count == 1) {
                    Console.Write($"{stack.Pop()};");
                }
                else
                {
                    Console.Write($"{stack.Pop()}, ");
                }
            }
            


        }

        static void Main(string[] args)
        {
            SplitNumnber(407);
        }
    }
}
