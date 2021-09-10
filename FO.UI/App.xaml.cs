using FO.UI.Data;
using System.Windows;

namespace FO.UI
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindows = new MainWindow(
                new ViewModel.MainViewModel(
                    new FriendDataService()));
            mainWindows.Show();

        }
    }
}
