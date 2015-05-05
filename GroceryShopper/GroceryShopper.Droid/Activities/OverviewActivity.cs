using Android.App;
using Android.OS;
using Chance.MvvmCross.Plugins.UserInteraction;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using GroceryShopper.Core.ViewModels;
using Java.Interop;

namespace GroceryShopper.Droid.Activities
{
    [Activity]
    [MvxViewFor(typeof(OverviewViewModel))]
    public class OverviewActivity : BaseActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Overview);
        }
        
        [Export]
        public string DemoFunctionForAppInvoke(string args)
        {
            Mvx.Resolve<IUserInteraction>().Alert("Yay.. I have been invoked from outside");
            return "Worked";
        }
    }
}