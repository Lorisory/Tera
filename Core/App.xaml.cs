using Prism.Ioc;
using Core.Views;
using System.Windows;
using Prism.Modularity;

namespace Core
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            // Registrace modulu
            moduleCatalog.AddModule<CoreModule>();
        }



    }
}
