using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using mvvmcrossforms.Core.Services.Contracts;

namespace mvvmcrossforms.Core.Services.Implementations
{
    public class NavigationService : MvxNavigationService, INavigationService
    {
        public NavigationService(IMvxNavigationCache navigationCache, IMvxViewModelLoader viewModelLoader) : base(navigationCache, viewModelLoader)
        {

        }
    }
}