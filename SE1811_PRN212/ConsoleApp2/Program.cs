
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch case
            /*
            int month;
            Console.Write("Input a month: ");
            month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Quarter I");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Quarter II");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Quarter III");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Quarter IV");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            */

            // loop
            // while
            //float avg;
            //Console.Write("Input average mark: ");
            //avg = float.Parse(Console.ReadLine());

            //while (!(avg >= 0 && avg <= 10))
            //{
            //    Console.Write("Re-input avg mark: ");
            //    avg = float.Parse(Console.ReadLine());
            //}

            // do-while
            //do
            //{
            //    Console.Write("Input ave mark: ");
            //    avg = float.Parse(Console.ReadLine());
            //} while (!(avg >= 0 && avg <= 10));

            // for
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}   

            // 1D array
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            // 2D array
            //int[,] arr2 = new int[5, 5];

            //// Jagged (mang rang cua)
            //double[][] arr3 = new double[3][];

            //// Nullable
            //int? x = 1234;
            //x = null;

            //int y;
            //y = x ?? 0;
            //Console.WriteLine(y);

            //// var keyword:
            //var z = 1234;

            //// dynamic keyword:
            //dynamic ab = 1234;
            //ab = "xxx";

            // function
            //int x, y;
            //x = 0;
            //y = 0;
            //InputData(out x, out y);
            //Swap(ref x, ref y);
            //Console.WriteLine("Global");
            //Console.WriteLine("Swap");
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            // lambda
        }

        private static void InputData(out int x, out int y)
        {
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("In function:");
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private static long Sum(int a, int b) => a + b;
    }
}
