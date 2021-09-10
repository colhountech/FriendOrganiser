using Autofac;
using FO.UI.Data;
using FO.UI.Startup;
using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace FO.UI
{
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Boostrap();

            //var mainWindows = new MainWindow(new ViewModel.MainViewModel(new FriendDataService()));
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
