using EF_DB_First.Interfaces;
using EF_DB_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DB_First.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyStoreContext _storeContext = new MyStoreContext();
        public List<Product> GetAll()
        {
            var products = from p in _storeContext.Products
                           select p;
            return products.ToList();
        }
    }
}
