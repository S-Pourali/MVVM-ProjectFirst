using System;
using System.Collections.Generic;
using System.Text;
using MVVM.Core.ViewModels;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MVVM.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            RegisterCustomAppStart<CoreAppStart<StartViewModel>>();

            base.Initialize();
        }
    }
}
