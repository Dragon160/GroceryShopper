using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest.Screens
{
    public class NewItemScreen : ScreenBase
    {
        public override ScreenBase AssertIsOnScreen()
        {
            App.WaitForElement(v => v.Marked("btnSave"));
            App.WaitForElement(v => v.Text("Add a new Item:"));

            return this;
        }

        public NewItemScreen EnterNewItem(string amount, string note, string type)
        {
            App.EnterText(v => v.Marked("editAmount"), amount);
            App.TapCoordinates(0, 0);

            App.Tap(v => v.Class("PickerRenderer"));            
            App.WaitForElement(v => v.Text("Sugar"));

            App.Tap(v => v.Text("OK"));

            App.EnterText(v => v.Marked("editNotes"), note);

            App.Tap(v => v.Text("Save"));

            return this;
        }

        public NewItemScreen EnterUnfinishedItem()
        {
            App.Tap(v => v.Class("PickerRenderer"));
            App.WaitForElement(v => v.Text("Sugar"));
            App.Tap(v => v.Text("Sugar"));
            App.Tap(v => v.Text("OK"));

            App.EnterText(v => v.Marked("editNotes"), "Example note");

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