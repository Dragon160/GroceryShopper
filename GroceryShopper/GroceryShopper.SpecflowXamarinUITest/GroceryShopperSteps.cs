using GroceryShopper.SpecflowXamarinUITest.Screens;
using TechTalk.SpecFlow;

namespace GroceryShopper.SpecflowXamarinUITest
{
    [Binding]
    public class GroceryShopperSteps
    {
        [Given(@"I am on the overview screen")]
        [Then(@"I am on the overview screen")]
        public void ThenIAmOnTheOverviewScreen()
        {
            new OverviewScreen().AssertIsOnScreen();            
        }

        [When(@"I click on the add item button")]
        public void GivenIClickOnTheAddItemButton()
        {
            new OverviewScreen().AddNewItem();
            new NewItemScreen().AssertIsOnScreen();
        }

        [When(@"I enter data like ""(.*)"" for amount and ""(.*)"" as type")]
        public void GivenIEnterDataLikeForAmountAndAsType(string p0, string p1)
        {
            new NewItemScreen().EnterNewItem(p0, string.Empty, p1);
        }

        [Then(@"I expect that the item with ""(.*)"" and ""(.*)"" has been added")]
        public void ThenIExpectThatTheItemWithAndHasBeenAdded(string p0, string p1)
        {
            var ov = new OverviewScreen();
            ov.AssertIsOnScreen();
            ov.AssertItemHasBeenAdded(p0, p1);
        }

        [When(@"I want to delete the ""(.*)"" item")]
        public void GivenIWantToDeleteThe(string p0)
        {
            new OverviewScreen().DeleteItem(p0);
        }

        [Then(@"I expect that the item with ""(.*)"" has been deleted")]
        public void ThenIExpectThatTheItemWithHasBeenDeleted(string p0)
        {
            new OverviewScreen().AssertItemIsDeleted(p0);
        }

        [When(@"I enter not valid data")]
        public void GivenIEnterNotValidData()
        {
            new NewItemScreen().EnterUnfinishedItem();
        }

        [Then(@"I expect to see an error message")]
        public void ThenIExpectToSeeAnErrorMessage()
        {
            new NewItemScreen().AssertSeeErrorMessage();
        }
    }
}
