using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Xamarin.UITest;

namespace GroceryShopper.XamarinUITest
{
    [TestFixture]
    public class UITests
    {
        private IApp _app;

        [SetUp]
        public void TestSetup()
        {
            _app = XamarinUiTest.ConfigureAndStart();
        }

        [Test]
        public void AssertOverviewScreen()
        {
            _app.WaitForElement(v => v.Button("btnAddGrocery"));
            _app.WaitForElement(v => v.Id("imgBackground"));
        }

        [Test]
        public void CheckForDefaultMeatItem()
        {
            _app.WaitForElement(v => v.Text("2kg"));
            _app.WaitForElement(v => v.Text("Meat"));
            _app.WaitForElement(v => v.Text("A nice Roastbeef"));
        }

        [Test]
        public void DeleteSugar()
        {
            _app.WaitForElement(v => v.Text("Sugar"));
            _app.Tap(v => v.Id("btnDeleteItem"));
            _app.WaitForNoElement(v => v.Text("Sugar"));

        }
        
    }
}