using System;
using System.Threading.Tasks;
using GroceryShopper.Forms.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GroceryShopper.Test
{
    [TestClass]
    public class FakedServiceTest
    {
        private FakedService _fakedService;

        [TestInitialize]
        public void Setup()
        {
            _fakedService = new FakedService();
        }

        [TestMethod]
        public async Task GetNextFakedServiceNumber_ShouldBeValidInteger()
        {
            var number = await _fakedService.DoSomeMagicStuffAsync(5);
            Assert.IsTrue(number > 0);
        }
    }
}
