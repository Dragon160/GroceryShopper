using System.Linq;
using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest.Screens
{
    public class OverviewScreen : ScreenBase
    {
        public override ScreenBase AssertIsOnScreen()
        {
            App.WaitForElement(v => v.Id("btnAddItem"));
            App.WaitForElement(v => v.Id("imgBackground"));

            return this;
        }

        public OverviewScreen(IApp app) : base(app)
        {
        }

        public void AddNewItem()
        {
            App.Tap(v => v.Id("btnAddItem"));
        }

        public void DeleteItem(string type)
        {
            App.WaitForElement(v => v.Text(type));           
            App.Tap(v => v.Text("A nice Roastbeef").Parent(0).Child("Button"));
            App.WaitForElement(v => v.Text("Do you really want to delete this item?"));
            App.Tap(v => v.Text("OK"));           
        }

        public void AssertItemHasBeenAdded(string amount, string type)
        {
            App.WaitForElement(v => v.Text(type));
            App.WaitForElement(v => v.Text(amount));
        }

        public void AssertItemIsDeleted(string type)
        {
            App.WaitForNoElement(v => v.Text(type));
        }

    }
}