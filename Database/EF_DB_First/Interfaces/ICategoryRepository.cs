using EF_DB_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DB_First.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
    }
}
