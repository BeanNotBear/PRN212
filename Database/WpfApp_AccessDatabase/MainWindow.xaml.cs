using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_AccessDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        CategoryManagement categoryManagement = new CategoryManagement();

        private void LoadCategories(Object sender, RoutedEventArgs e)
        {
            lvCategory.ItemsSource = categoryManagement.GetAll();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
       
            string name = txtCategoryName.Text;
            Category category = new Category();

            if (name != null && !name.Trim().Equals(""))
            {
                category.CategoryName = name;
                categoryManagement.Insert(category);
                MessageBox.Show("Insert successfully!");
            }
            else
            {
                MessageBox.Show("Name cannot be empty!");
            }
            lvCategory.ItemsSource = categoryManagement.GetAll();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string id = txtCategoryId.Text;
            string name = txtCategoryName.Text;
            Category category = new Category();
            try
            {
                int id32 = Int32.Parse(id);
                category.CategoryId = id32;
                if (name == null || name.Trim().Equals(""))
                {
                    throw new Exception();
                }
                category.CategoryName = name;
                if (categoryManagement.CheckCategoryExisted(category.CategoryName))
                {
                    MessageBox.Show("Name has been existed!");
                }
                else
                {
                    categoryManagement.Update(category);
                    MessageBox.Show("Update successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Name cannot be empty!");
                Console.WriteLine(ex.ToString());
            }
            lvCategory.ItemsSource = categoryManagement.GetAll();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string id = txtCategoryId.Text;
            var confirm = MessageBox.Show(
                "Are you sure?", "Delete category",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            try
            {
                if (confirm == MessageBoxResult.Yes)
                {
                    int id32 = Int32.Parse(id);
                    categoryManagement.Delete(id32);
                    MessageBox.Show("Delete successfuly!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            lvCategory.ItemsSource = categoryManagement.GetAll();
        }
    }
}