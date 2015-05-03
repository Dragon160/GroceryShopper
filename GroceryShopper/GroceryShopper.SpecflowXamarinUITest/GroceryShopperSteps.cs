using GroceryShopper.SpecflowXamarinUITest.Screens;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest
{
    [Binding]
    public class GroceryShopperSteps
    {
        private IApp _app;

        [Given(@"I started the app")]
        public void GivenIStartedTheApp()
        {
            _app = XamarinUiTestInitializer.ConfigureAndStart();
        }

        [Given(@"I am on the overview screen")]
        [Then(@"I am on the overview screen")]
        public void ThenIAmOnTheOverviewScreen()
        {
            new OverviewScreen(_app).AssertIsOnScreen();
        }

        [When(@"I click on the add item button")]
        public void GivenIClickOnTheAddItemButton()
        {
            new OverviewScreen(_app).AddNewItem();
            new NewItemScreen(_app).AssertIsOnScreen();
        }

        [When(@"I enter data like ""(.*)"" for amount and ""(.*)"" as type")]
        public void GivenIEnterDataLikeForAmountAndAsType(string p0, string p1)
        {
            new NewItemScreen(_app).EnterNewItem(p0, string.Empty, p1);
        }

        [Then(@"I expect that the item with ""(.*)"" and ""(.*)"" has been added")]
        public void ThenIExpectThatTheItemWithAndHasBeenAdded(string p0, string p1)
        {
            var ov = new OverviewScreen(_app);
            ov.AssertIsOnScreen();
            ov.AssertItemHasBeenAdded(p0, p1);
        }

        [When(@"I want to delete the ""(.*)"" item")]
        public void GivenIWantToDeleteThe(string p0)
        {
            new OverviewScreen(_app).DeleteItem(p0);
        }

        [Then(@"I expect that the item with ""(.*)"" has been deleted")]
        public void ThenIExpectThatTheItemWithHasBeenDeleted(string p0)
        {
            new OverviewScreen(_app).AssertItemIsDeleted(p0);
        }

        [When(@"I enter not valid data")]
        public void GivenIEnterNotValidData()
        {
            new NewItemScreen(_app).EnterUnfinishedItem();
        }

        [Then(@"I expect to see an error message")]
        public void ThenIExpectToSeeAnErrorMessage()
        {
            new NewItemScreen(_app).AssertSeeErrorMessage();
        }


    }
}
