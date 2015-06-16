using Cirrious.CrossCore.IoC;
using GroceryShopper.Forms.ViewModels;

namespace GroceryShopper.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<OverviewViewModel>();
        }
    }
}