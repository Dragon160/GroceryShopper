using Cheesebaron.MvxPlugins.FormsPresenters.Core;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;
using GroceryShopper.Core;
using UIKit;

namespace GroceryShopper.Forms.iOS
{
    class Setup : MvxTouchSetup
    {

        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxTouchViewPresenter CreatePresenter()
        {
            Xamarin.Forms.Forms.Init();
            var xamarinFormsApp = new MvxFormsApp();

            return new Cheesebaron.MvxPlugins.FormsPresenters.Touch.MvxFormsTouchPagePresenter(Window, xamarinFormsApp);
        }
    }
}