using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;

namespace GroceryShopper.Droid
{
    [Activity(
		Label = "Grocery Shopper"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}