using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    public class Menu
    {
        public void ChooseOption()
        {
            int op = 0;
            CustomList movies = new CustomList();
            while (true)
            {
                Console.WriteLine("1. Insert new Movie");
                Console.WriteLine("2. View list of movie");
                Console.WriteLine("3. Sort Movie by Average List");
                Console.WriteLine("4. Delete a movie");
                Console.WriteLine("5. Exit");
                op = int.Parse(Console.ReadLine());
                int id = 1;
                switch (op)
                {
                    case 1:
                        IMovie movie = new Movie();
                        movie.ID = id++;
                        Console.Write("Enter name: ");
                        movie.Name = Console.ReadLine();
                        Console.Write("Enter a day: ");
                        int day = int.Parse(Console.ReadLine());
                        Console.Write("Enter a month: ");
                        int month = int.Parse(Console.ReadLine());
                        Console.Write("Enter a year: ");
                        int year = int.Parse(Console.ReadLine());
                        movie.PublishDate = new DateTime(year, month, day, 00, 00, 00, 00);
                        Console.Write("Enter director: ");
                        movie.Director = Console.ReadLine();
                        Console.Write("Enter lenguage: ");
                        movie.Language = Console.ReadLine();
                        Console.Write("Enter subtitle: ");
                        movie.Subtitle = Console.ReadLine();
                        float[] arr = new float[3];
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Enter rate: ");
                            arr[i] = float.Parse(Console.ReadLine());
                        }
                        float rate = movie.CalculateAverageRate(arr);
                        movie.AverageRate = rate;
                        movies.Add(movie);
                        break;
                    case 2:
                        foreach (var item in movies)
                        {
                            item.Display();
                        }
                        break;
                    case 3:
                        CustomSort customSort = new CustomSort();
                        customSort.SortList(movies.MovieList);
                        break;
                    case 4:
                        Console.Write("Enter movie ID: ");
                        int id_delete = int.Parse(Console.ReadLine());
                        movies.Remove(id_delete);
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
