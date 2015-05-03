using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest
{
    public abstract class XamarinUiTestInitializer
    {
        private const string PathToApk = "../../../GroceryShopper.Droid/bin/Release/GroceryShopper.Droid.apk";

        public static IApp ConfigureAndStart()
        {
            return ConfigureApp.Android.ApkFile(PathToApk).EnableLocalScreenshots().StartApp();
        }
    }
}
