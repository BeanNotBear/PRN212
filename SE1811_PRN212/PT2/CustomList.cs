using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    public class CustomList : IEnumerable<IMovie>
    {
        public List<IMovie> MovieList { get; set; } = new List<IMovie>();

        public void Add(IMovie movie)
        {
            MovieList.Add(movie);
        }

        public void Remove(int id)
        {
            IMovie movie = this.MovieList.FirstOrDefault(m => m.ID == id);
            if (movie != null)
            {
                MovieList.Remove(movie);
            }
        }

        public void Sort(IComparer<IMovie> compare)
        {
            MovieList.Sort(compare);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator<IMovie> GetEnumerator()
        {
            return MovieList.GetEnumerator();
        }
    }
}
