using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MVVM.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public MenuViewModel(IMvxNavigationService navigationService) : 
            base(navigationService)
        {
        }

        public IMvxCommand NavigateToStartViewCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    this.navigationService.Navigate<StartViewModel>();
                });
            }
        }
    }
}
