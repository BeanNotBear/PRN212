using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise
{
    internal class EX3
    {
        static void DrawShape1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void DrawShape2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void DrawShape3(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void DrawShape4(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = n - 1; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void DrawShape5(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void DrawShape6(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 2 * n - 1; k >= 2 * i - 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        static void DrawShape7(int n)
        {
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 2 * n - 1; k >= 2 * i - 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void DrawShape8(int n, int m)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i == 1 || j == 1 || i == n || j == m)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }


                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            DrawShape1(6);
            Console.WriteLine("--------------------------------------");
            DrawShape2(6);
            Console.WriteLine("--------------------------------------");
            DrawShape3(6);
            Console.WriteLine("--------------------------------------");
            DrawShape4(6);
            Console.WriteLine("--------------------------------------");
            DrawShape5(6);
            Console.WriteLine("--------------------------------------");
            DrawShape6(6);
            Console.WriteLine("--------------------------------------");
            DrawShape7(6);
            Console.WriteLine("--------------------------------------");
            DrawShape8(6, 12);
        }
    }
}
