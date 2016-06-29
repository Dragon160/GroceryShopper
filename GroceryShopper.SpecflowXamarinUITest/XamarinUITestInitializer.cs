using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest
{
    public abstract class XamarinUiTestInitializer
    {
        private const string PathToApk = "../../../GroceryShopper.Forms.Droid/bin/Release/GroceryShopper.Forms.Droid-Signed.apk";
        private const string PathToApp = "../../../GroceryShopper.Forms/GroceryShopper.Forms.Droid/bin/Release/GroceryShopperFormsiOS.app";

        public static IApp ConfigureAndStart(Platform platform, bool isTestCloud)
        {
            if (isTestCloud)
            {
                return platform == Platform.Android ? (IApp) ConfigureApp.Android.StartApp() : ConfigureApp.iOS.StartApp();
            }

            return platform == Platform.Android
                ? (IApp) ConfigureApp.Android.ApkFile(PathToApk).EnableLocalScreenshots().StartApp()
                : ConfigureApp.iOS.AppBundle(PathToApp).EnableLocalScreenshots().StartApp();
        }
    }
}
