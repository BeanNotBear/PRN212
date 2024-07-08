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

namespace ControlTemplate
{
    /// <summary>
    /// Interaction logic for Window_Canvas.xaml
    /// </summary>
    public partial class Window_Canvas : Window
    {
        public Window_Canvas()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            var info = $"Car Name: {txtName.Text}"
                          +$"\nColor: {txtColor.Text}"
                          +$"\nBrand: {txtBrand.Text}";
            MessageBox.Show(info, "Car Information");

        }
    }
}
