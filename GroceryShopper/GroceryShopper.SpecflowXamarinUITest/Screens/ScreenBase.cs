using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest.Screens
{
    public abstract class ScreenBase
    {
        protected readonly IApp App;

        protected ScreenBase(IApp app)
        {
            App = app;
        }

        public abstract ScreenBase AssertIsOnScreen();
    }
}
