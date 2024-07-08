using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyFirstWPF
{
    /// <summary>
    /// Interaction logic for Window_Page.xaml
    /// </summary>
    public partial class Window_Page : Window
    {
        public Window_Page()
        {
            InitializeComponent();
        }

        private void btnToPage1_Click(object sender, RoutedEventArgs e)
        {
            firstPage.Content = new Page1();
        }

        private void btnToPage2_Click(object sender, RoutedEventArgs e)
        {
            firstPage.Content = new Page2();
        }
    }
}
