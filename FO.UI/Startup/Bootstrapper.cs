using Autofac;
using FO.UI.Data;
using FO.UI.ViewModel;

namespace FO.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Boostrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();

            return builder.Build();

        }
    }
}
