using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using MvvmCross.Forms.Platforms.Android.Views;
using mvvmcrossforms.Core;
using mvvmcrossforms.Forms.UI;

namespace mvvmcrossforms.Droid
{
    [Activity(Label = "MvvmCrossForms", Icon = "@mipmap/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, LaunchMode = LaunchMode.SingleTask)]
    public class MainActivity : MvxFormsAppCompatActivity<AndroidSetup, CoreApp, App>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}