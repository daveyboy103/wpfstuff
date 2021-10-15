using SampleWPF.Data;
using SampleWPF.ViewModels;
using System.Threading.Tasks;
using System.Windows;
using WpfModels.Models;

namespace SampleWPF
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var service = new SampleDataService();
            var item = service.Get(1);
            DataContext = new MainWindowViewModel(item);
        }
    }
}
