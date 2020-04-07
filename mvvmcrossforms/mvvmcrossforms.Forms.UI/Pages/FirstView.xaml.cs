using MvvmCross.Forms.Views;
using mvvmcrossforms.Core.ViewModels;

namespace mvvmcrossforms.Forms.UI.Pages
{
    public partial class FirstView : MvxContentPage<FirstViewModel>
    {
        public FirstView()
        {
            InitializeComponent();

            Title = "FirstView";
        }
    }
}