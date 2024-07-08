using EF_Code_First.Data;
using EF_Code_First.Models;
using EF_Code_First.Services;
using System.Windows;

namespace EF_Code_First
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

        private async void Reload()
        {
            IDataService<Category> categoryService = new GenericDataService<Category>(new ApplicationDbContextFactory());
            List<Category> categories = (List<Category>)await categoryService.GetAll();
            lvCategories.ItemsSource = categories;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Reload();
        }

        private async void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            IDataService<Category> categoryService = new GenericDataService<Category>(new ApplicationDbContextFactory());
            var categoryName = Name.Text;
            await categoryService.Create(new Category()
            {
                Name = categoryName
            });
            MessageBox.Show("Insert successfully!");
            Reload();
        }
    }
}