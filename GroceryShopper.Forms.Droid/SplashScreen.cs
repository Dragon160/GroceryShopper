using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;
using Xamarin.Forms;

namespace GroceryShopper.Forms.Droid
{

    [Activity(
        Label = "Grocery Shopper"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen
        : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        public override void InitializationComplete()
        {
            StartActivity(typeof(MainActivity));
        }

        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            Xamarin.Forms.Forms.Init(this, bundle);
            // Leverage controls' StyleId attrib. to Xamarin.UITest
            Xamarin.Forms.Forms.ViewInitialized += (object sender, ViewInitializedEventArgs e) =>
            {
                if (!string.IsNullOrWhiteSpace(e.View.StyleId))
                {
                    e.NativeView.ContentDescription = e.View.StyleId;
                }
            };

            base.OnCreate(bundle);
        }
    }

}