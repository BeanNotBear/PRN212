using StockSystem.Data;
using StockSystem.Interfaces;
using StockSystem.Models;
using StockSystem.Repositories;
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

namespace StockSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly StockDbContext stockDbContext;
        private readonly ICategoryRepository categoryRepository;

        public MainWindow()
        {
            stockDbContext = new StockDbContext();
            categoryRepository = new CategoryRepository(stockDbContext);
            InitializeComponent();
        }

        private async Task ReloadWindow()
        {
            lvCategories.ItemsSource = await categoryRepository.GetAll();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lvCategories.ItemsSource = await categoryRepository.GetAll();
        }

        private async void btnInsertCategory_Click(object sender, RoutedEventArgs e)
        {
            var categoryName = CategoryName.Text;
            var category = new Category() { CategoryName = categoryName };
            var InsertedCategory = await categoryRepository.Insert(category);
            if (InsertedCategory != null)
            {
                MessageBox.Show("Insert successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
            else
            {
                MessageBox.Show("Insert Fail!", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }

            await ReloadWindow();
        }

        private async void btnUpdatedCategory_Click(object sender, RoutedEventArgs e)
        {
            var categoryName = CategoryName.Text;
            var categoryId = CategoryId.Text;
            var categoryId32 = Int32.Parse(categoryId);
            var category = new Category() { CategoryId = categoryId32, CategoryName = categoryName };
            var updatedCategory = await categoryRepository.Update(category, categoryId32);
            if (updatedCategory != null)
            {
                MessageBox.Show("Update successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
            else
            {
                MessageBox.Show("Update Fail!", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            await ReloadWindow();
        }

        private async void btnDeleteCategory_Click(object sender, RoutedEventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure to detele this?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (dialogResult == MessageBoxResult.Yes)
            {
                var categoryId = CategoryId.Text;
                var categoryId32 = Int32.Parse(categoryId);
                await categoryRepository.Delete(categoryId32);
                MessageBox.Show("Delete successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            await ReloadWindow();
        }
    }
}