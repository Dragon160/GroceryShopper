using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest.Screens
{
    public class NewItemScreen : ScreenBase
    {
        public override ScreenBase AssertIsOnScreen()
        {
            App.WaitForElement(v => v.Id("btnSave"));
            App.WaitForElement(v => v.Text("Add a new Item:"));

            return this;
        }

        public NewItemScreen EnterNewItem(string amount, string note, string type)
        {
            App.EnterText(v => v.Id("editAmount"), amount);
            App.TapCoordinates(0, 0);

            App.Tap(v => v.Class("MvxSpinner"));
            App.WaitForElement(v => v.Text("Other"));
            App.Tap(v => v.Text(type));

            App.EnterText(v => v.Id("editNotes"), note);

            App.Tap(v => v.Text("Save"));

            return this;
        }

        public NewItemScreen EnterUnfinishedItem()
        {
            App.Tap(v => v.Class("MvxSpinner"));
            App.WaitForElement(v => v.Text("Other"));
            App.Tap(v => v.Text("Other"));

            App.EnterText(v => v.Id("editNotes"), "Example note");

            App.Tap(v => v.Text("Save"));

            return this;
        }

        public NewItemScreen AssertSeeErrorMessage()
        {
            App.WaitForElement(v => v.Text("Please check your input"));
            return this;
        }
    }
}