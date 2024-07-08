using EF_DB_First.Interfaces;
using EF_DB_First.Models;
using EF_DB_First.Repositories;

namespace EF_DB_First
{
    public class Program
    {
        static void Main(string[] args)
        {
            IProductRepository productRepository = new ProductRepository();
            List<Product> products = productRepository.GetAll();
            products.ForEach(p =>
            {
                Console.WriteLine(p.ToString());
            });
            Console.WriteLine("----------------------------------");
            ICategoryRepository categoryRepository = new CategoryRepository();
            var categories = categoryRepository.GetAll();
            foreach (var item in categories)
            {
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine($"Category Name: {item.CategoryName}");
                Console.WriteLine($"Number of product: {item.Products.Count}");
                foreach (var i in item.Products)
                {
                    Console.WriteLine($"Product Name: {i.ProductName}");
                }
            }
        }
    }
}