using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WpfApp_AccessDatabase
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }

    public class CategoryManagement
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string connectionString = "Data Source=localhost,1433;Initial Catalog=MyStore;User ID=sa;Password=123;TrustServerCertificate=True";

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();
            connection = new SqlConnection(connectionString);
            var query = "SELECT * FROM Categories";
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.CategoryId = reader.GetInt32("CategoryID");
                    category.CategoryName = reader.GetString("CategoryName");
                    categories.Add(category);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { connection.Close(); }
            return categories;
        }

        public void Insert(Category category)
        {
            connection = new SqlConnection(connectionString);
            var query = "INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES (@CategoryName);";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { connection.Close(); }
        }

        public void Update(Category category)
        {
            connection = new SqlConnection(connectionString);
            var query = "UPDATE [dbo].[Categories] SET [CategoryName] = @CategoryName WHERE CategoryID = @CategoryID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryId);
            try
            {
                connection.Open();
                command.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { connection.Close(); }
        }

        public void Delete(int id)
        {
            connection = new SqlConnection(connectionString);
            var query = "DELETE [dbo].[Categories] WHERE CategoryID = @CategoryID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", id);
            try
            {
                connection.Open();
                command.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { connection.Close(); }
        }

        public bool CheckCategoryExisted(string name)
        {
            connection = new SqlConnection(connectionString);
            var query = "SELECT * FROM Categories WHERE CategoryName = @CategoyName";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoyName", name);
            bool isExisted = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isExisted = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { connection.Close(); }
            return isExisted;
        }
    }
}
