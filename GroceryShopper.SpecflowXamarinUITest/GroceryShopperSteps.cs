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
            new OverviewScreen().AssertIsOnScreen().DoScreenshot("I am on the overview screen");            
        }

        [When(@"I click on the add item button")]
        public void GivenIClickOnTheAddItemButton()
        {
            new OverviewScreen().AddNewItem();
            new NewItemScreen().AssertIsOnScreen().DoScreenshot("I click on the add button icon");
        }

        [When(@"I enter data like ""(.*)"" for amount and ""(.*)"" as type")]
        public void GivenIEnterDataLikeForAmountAndAsType(string p0, string p1)
        {
            new NewItemScreen().EnterNewItem(p0, string.Empty, p1).DoScreenshot(string.Format("I enter data like '{0}' for amount and '{1}' as type", p0, p1));
        }

        [Then(@"I expect that the item with ""(.*)"" and ""(.*)"" has been added")]
        public void ThenIExpectThatTheItemWithAndHasBeenAdded(string p0, string p1)
        {
            var ov = new OverviewScreen();
            ov.AssertIsOnScreen();
            ov.AssertItemHasBeenAdded(p0, p1).DoScreenshot(string.Format("I expect that the item with '{0}' and '{1}' has been added", p0, p1));
        }

        [When(@"I want to delete the ""(.*)"" item")]
        public void GivenIWantToDeleteThe(string p0)
        {
            new OverviewScreen().DeleteItem(p0).DoScreenshot(string.Format("I want to delete the '{0}' item", p0));
        }

        [Then(@"I expect that the item with ""(.*)"" has been deleted")]
        public void ThenIExpectThatTheItemWithHasBeenDeleted(string p0)
        {
            new OverviewScreen().AssertItemIsDeleted(p0).DoScreenshot(string.Format("I expect that the item with '{0}' has been deleted ", p0));
        }

        [When(@"I enter not valid data")]
        public void GivenIEnterNotValidData()
        {
            new NewItemScreen().EnterUnfinishedItem().DoScreenshot("I enter not valid data");
        }

        [Then(@"I expect to see an error message")]
        public void ThenIExpectToSeeAnErrorMessage()
        {
            new NewItemScreen().AssertSeeErrorMessage().DoScreenshot("I epxect to see an error message");
        }
    }
}
