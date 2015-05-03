using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using GroceryShopper.Core.ViewModels;

namespace GroceryShopper.Droid.Activities
{
    [Activity]
    [MvxViewFor(typeof(OverviewViewModel))]
    public class OverviewActivity : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Overview);
        }
    }
}