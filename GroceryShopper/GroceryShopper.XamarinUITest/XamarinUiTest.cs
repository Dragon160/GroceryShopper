using Xamarin.UITest;

namespace GroceryShopper.XamarinUITest
{
    public abstract class XamarinUiTest
    {
        private const string PathToApk = "../../../GroceryShopper.Droid/bin/Release/GroceryShopper.Droid.apk";

        public static IApp ConfigureAndStart()
        {
            return ConfigureApp.Android.ApkFile(PathToApk).EnableLocalScreenshots().StartApp();
        }
    }
}
