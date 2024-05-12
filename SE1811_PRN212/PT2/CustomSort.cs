using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    public class CustomSort : IComparer<IMovie>
    {
        public int Compare(IMovie? x, IMovie? y)
        {
            return x.AverageRate.CompareTo(y.AverageRate);
        }

        public void SortList(List<IMovie> movies)
        {
            CustomSort sort = new CustomSort();
            movies.Sort(sort);
        }
    }
}
