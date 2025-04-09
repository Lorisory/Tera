using Core.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Core
{
    class CoreModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public CoreModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("MainContentRegion", typeof(HomeView));
            _regionManager.RegisterViewWithRegion("MainTabbarRegion", typeof(HomeNavigationButtonView));
            _regionManager.RegisterViewWithRegion("MainTabbarRegion", typeof(SettingsNavigationButtonView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomeView>();
            containerRegistry.RegisterForNavigation<HomeNavigationButtonView>();
        }



    }
}
