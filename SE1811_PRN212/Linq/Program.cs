using System.Net.NetworkInformation;

namespace Linq
{
    internal class Program
    {
        static string[] Names = { "Binh", "Anh", "Mai", "Thu", "Duong" };

        static void Demo1()
        {
            // OrderByDescending: descending
            // OrderBy: ascending
            foreach (var name in Names.OrderByDescending(s => s))
            {
                Console.WriteLine(name);
            }
        }

        static void QueryLINQ()
        {
            // get data from Names
            var result = from name in Names
                         where name.Contains("n") || name.Contains("h")
                         orderby name descending
                         select name;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            // LINQ: Language integrated query
            // Some standard query: Sum, Count, Order By, Contain, ...
            // Build query: from, where, select, group, ascending, orderby, ...
            QueryLINQ();

        }
    }
}
