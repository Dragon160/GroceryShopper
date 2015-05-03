using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest.Screens
{
    public class NewItemScreen : ScreenBase
    {
        public NewItemScreen(IApp app) : base(app)
        {
        }

        public override ScreenBase AssertIsOnScreen()
        {
            App.WaitForElement(v => v.Id("btnSave"));
            App.WaitForElement(v => v.Text("Add a new Item:"));

            return this;
        }

        public void EnterNewItem(string amount, string note, string type)
        {
            App.EnterText(v => v.Id("editAmount"), amount);
            App.TapCoordinates(0, 0);

            App.Tap(v => v.Class("MvxSpinner"));
            App.WaitForElement(v => v.Text("Other"));
            App.Tap(v => v.Text(type));

            App.EnterText(v => v.Id("editNotes"), note);

            App.Tap(v => v.Text("Save"));
        }

        public NewItemScreen EnterUnfinishedItem(string amount, string note, string type)
        {
            App.Tap(v => v.Class("MvxSpinner"));
            App.WaitForElement(v => v.Text("Other"));
            App.Tap(v => v.Text(type));

            App.EnterText(v => v.Id("editNotes"), note);

            App.Tap(v => v.Text("Save"));

            return this;
        }

        public void AssertSeeErrorMessage()
        {
            App.WaitForElement(v => v.Text("Please check your input"));
        }
    }
}