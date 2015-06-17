using System.Threading.Tasks;

namespace GroceryShopper.Forms.Interfaces
{
    public interface IFakedService
    {
        Task<int> DoSomeMagicStuffAsync(int seed);
    }
}