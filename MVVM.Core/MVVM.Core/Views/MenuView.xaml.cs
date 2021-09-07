using MVVM.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace MVVM.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : MvxContentPage<MenuViewModel>
    {
        public MenuView()
        {
            InitializeComponent();
        }
    }
}