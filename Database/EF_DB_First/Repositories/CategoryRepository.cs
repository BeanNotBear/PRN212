using EF_DB_First.Interfaces;
using EF_DB_First.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DB_First.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MyStoreContext _myStoreContext = new MyStoreContext();
        public IEnumerable<Category> GetAll()
        {
            var categories = _myStoreContext.Categories.Include(
                c => (c.Products.Where(p => p.UnitsInStock > 50)
                .OrderByDescending(p => p.UnitsInStock)));
            return categories;
        }
    }
}
