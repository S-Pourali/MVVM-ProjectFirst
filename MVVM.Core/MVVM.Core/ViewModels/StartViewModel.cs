using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MVVM.Core.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        public StartViewModel(IMvxNavigationService navigationService) : 
            base(navigationService)
        {
        }
         
        public IMvxCommand NavigateToMenuViewCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    this.navigationService.Navigate<MenuViewModel>();
                });
            }
        }


    }

}
