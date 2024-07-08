using Microsoft.EntityFrameworkCore;
using StockSystem.Data;
using StockSystem.Interfaces;
using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StockDbContext stockDbContext;

        public CategoryRepository(StockDbContext stockDbContext)
        {
            this.stockDbContext = stockDbContext;
        }

        public async Task<Category> Delete(int id)
        {
            var category = await stockDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
            if (category != null)
            {
                stockDbContext.Categories.Remove(category);
                await stockDbContext.SaveChangesAsync();
            }
            return category;
        }

        public async Task<List<Category>> GetAll()
        {
            var categories = await stockDbContext.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetById(int id)
        {
            var category = await stockDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
            return category;
        }

        public async Task<Category> GetByName(string name)
        {
            var category = await stockDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryName.Equals(name));
            return category;
        }

        public async Task<Category> Insert(Category category)
        {
            try
            {
                if (category.CategoryName.Trim().Length == 0)
                {
                    throw new Exception("Category Name cannot be empty!");
                }
                if (await GetByName(category.CategoryName) != null)
                {
                    throw new Exception("Category must be unique!");
                }
                await stockDbContext.Categories.AddAsync(category);
                await stockDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
            return category;
        }

        public async Task<Category> Update(Category category, int id) 
        {
            var updatedCategory = await stockDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
            try
            {
                if (await GetByName(category.CategoryName) != null)
                {
                    throw new Exception("Category must be unique");
                }
                if (updatedCategory != null)
                {
                    updatedCategory.CategoryName = category.CategoryName;
                }
                await stockDbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                return null;
            }
            return updatedCategory;
        }
    }
}
