using FO.UI.ViewModel;
using System.Windows;

namespace FO.UI
{

    public partial class MainWindow : Window
    {
        private MainViewModel _vm;

        public MainWindow(MainViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            DataContext = _vm;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _vm.Load();
        }
    }
}
