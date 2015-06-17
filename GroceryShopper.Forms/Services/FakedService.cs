using System;
using System.Threading.Tasks;
using GroceryShopper.Forms.Interfaces;

namespace GroceryShopper.Forms.Services
{
    public class FakedService : IFakedService
    {
        public async Task<int> DoSomeMagicStuffAsync(int seed)
        {
            var rand = new Random(seed).Next();
            await Task.Delay(100);
            return rand;

        }
    }
}
