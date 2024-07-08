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

namespace MyFirstWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Demo(object sender, EventArgs e)
    {
        demo.Text = "Hello everyone!";
    }

    private void Demo1(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
             "Welcome to my WPF"
             , "Welcome"
             , MessageBoxButton.YesNo
             , MessageBoxImage.Question);
        if (result == MessageBoxResult.Yes)
        {
            MessageBox.Show("Thanks!");
        }
        else
        {
            MessageBox.Show("Bye!");
        }
    }
}