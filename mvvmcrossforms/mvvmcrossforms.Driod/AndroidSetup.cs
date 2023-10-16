using Microsoft.Extensions.Logging;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using mvvmcrossforms.Core;
using mvvmcrossforms.Forms.UI;

namespace mvvmcrossforms.Droid
{
    public class AndroidSetup : MvxFormsAndroidSetup<CoreApp, App>
    {
        protected override IMvxApplication CreateApp(IMvxIoCProvider iocProvider)
        {
            return new CoreApp();
        }

        protected override ILoggerFactory CreateLogFactory() => default;

        protected override ILoggerProvider CreateLogProvider() => default;
    }
}