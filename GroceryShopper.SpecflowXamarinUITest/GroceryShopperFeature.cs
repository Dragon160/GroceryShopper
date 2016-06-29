using NUnit.Framework;
using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public partial class GroceryShopperFeature
    {
        /// <summary>
        /// Provides access to the app to perform actions on it
        /// </summary>
        public static IApp App { get; private set; }

        private readonly Platform _platform;

        public GroceryShopperFeature(Platform platform)
        {
            _platform = platform;
        }

        [SetUp]
        public void InitApplication()
        {
            App = XamarinUiTestInitializer.ConfigureAndStart(_platform, TestEnvironment.IsTestCloud);
        }        
    }
}