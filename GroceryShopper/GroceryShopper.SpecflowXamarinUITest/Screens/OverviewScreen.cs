using System.Linq;
using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest.Screens
{
    public class OverviewScreen : ScreenBase
    {
        public override ScreenBase AssertIsOnScreen()
        {
            App.WaitForElement(v => v.Marked("btnAddItem"));
            App.WaitForElement(v => v.Marked("imgBackground"));

            return this;
        }

        public OverviewScreen AddNewItem()
        {
            App.Tap(v => v.Marked("btnAddItem"));
            return this;
        }

        public OverviewScreen DeleteItem(string type)
        {
            App.WaitForElement(v => v.Text(type));           
            App.Tap(v => v.Text("A nice Roastbeef").Parent(0).Child("Button"));
            App.WaitForElement(v => v.Text("Do you really want to delete this item?"));
            App.Tap(v => v.Text("OK"));

            return this;
        }

        public OverviewScreen AssertItemHasBeenAdded(string amount, string type)
        {
            App.WaitForElement(v => v.Text(type));
            App.WaitForElement(v => v.Text(amount));

            return this;
        }

        public OverviewScreen AssertItemIsDeleted(string type)
        {
            App.WaitForNoElement(v => v.Text(type));
            return this;
        }

    }
}