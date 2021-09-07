using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MVVM.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public readonly IMvxNavigationService navigationService;
        public BaseViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
    }
}
