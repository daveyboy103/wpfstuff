using SampleWPF.ViewModels;
using System.Windows;

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
            DataContext = new MainWindowViewModel
            {
                Description = "This is bound"
            };
        }
    }
}
