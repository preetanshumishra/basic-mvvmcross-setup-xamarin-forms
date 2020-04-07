using System.Threading.Tasks;
using MvvmCross.ViewModels;
using mvvmcrossforms.Core.Services.Contracts;
using mvvmcrossforms.Core.ViewModels;

namespace mvvmcrossforms.Core
{
    public class AppStart : MvxAppStart
    {
        private readonly INavigationService _navigationService;

        public AppStart(IMvxApplication application, INavigationService navigationService) : base(application, navigationService)
        {
            _navigationService = navigationService;
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return _navigationService.Navigate<FirstViewModel>();
        }
    }
}