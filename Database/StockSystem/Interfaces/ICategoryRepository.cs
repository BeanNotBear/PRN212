using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int id);
        Task<Category> Insert(Category category);
        Task<Category> Update(Category category, int id);
        Task<Category> Delete(int id);
        Task<Category> GetByName(string name);
    }
}
