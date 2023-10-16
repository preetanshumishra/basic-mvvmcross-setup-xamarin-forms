using Microsoft.Extensions.Logging;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using mvvmcrossforms.Core;
using mvvmcrossforms.Forms.UI;

namespace mvvmcrossforms.iOS
{
    public class IosSetup : MvxFormsIosSetup<CoreApp, App>
    {
        protected override IMvxApplication CreateApp(IMvxIoCProvider iocProvider)
        {
            return new CoreApp();
        }

        protected override ILoggerFactory CreateLogFactory() => default;

        protected override ILoggerProvider CreateLogProvider() => default;
    }
}