using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartView : MvxContentPage<StartViewModel>
    {
        public StartView()
        {
            InitializeComponent();
        }
    }
}