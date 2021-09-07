using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Exceptions;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MVVM.Core
{
    public class CoreAppStart<TViewModel> : MvxAppStart<TViewModel>
    where TViewModel : IMvxViewModel
    {
        public CoreAppStart(IMvxApplication application, IMvxNavigationService navigationService) 
            : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            try
            {
                return NavigationService.Navigate<TViewModel>();
            }
            catch (Exception ex)
            {
                throw ex.MvxWrap("Error on {0}",typeof(TViewModel).Name);
            }
        }
    }
}
