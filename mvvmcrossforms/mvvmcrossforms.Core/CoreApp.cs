using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using mvvmcrossforms.Core.Services.Contracts;
using mvvmcrossforms.Core.Services.Implementations;

namespace mvvmcrossforms.Core
{
    public class CoreApp : MvxApplication
    {
        public CoreApp()
        {
            RegisterServices();
        }

        public override void Initialize()
        {
            // Register Custom AppStart
            RegisterCustomAppStart<AppStart>();
        }

        private void RegisterServices()
        {
            // Register all your services here.
            Mvx.IoCProvider.RegisterSingleton<INavigationService>(() => new NavigationService(Mvx.IoCProvider.Resolve<IMvxViewModelLoader>(), Mvx.IoCProvider.Resolve<IMvxViewDispatcher>(), Mvx.IoCProvider));
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ISampleService, SampleService>();
        }
    }
}