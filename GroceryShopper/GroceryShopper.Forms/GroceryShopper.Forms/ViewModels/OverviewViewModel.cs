using System.Collections.ObjectModel;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using GroceryShopper.Core;
using GroceryShopper.Forms.Models;

namespace GroceryShopper.Forms.ViewModels
{
    public class OverviewViewModel : MvxViewModel
    {
        private ICommand _addItemCommand;

        public ICommand AddItemCommand
        {
            get { return _addItemCommand ?? (_addItemCommand = new MvxCommand(()=> ShowViewModel<NewItemViewModel>())); }
        }

        public ObservableCollection<Grocery> GroceryItems
        {
            get { return InMemoryStorage.Items; }
        }

        public override void Start()
        {
            base.Start();

            // default groceries
            GroceryItems.Add(new Grocery { Amount = "100g", GroceryType = GroceryTypes.Sugar, Notes = string.Empty});
            GroceryItems.Add(new Grocery { Amount = "2kg", GroceryType = GroceryTypes.Meat, Notes = "A nice Roastbeef" });
            GroceryItems.Add(new Grocery { Amount = "1L", GroceryType = GroceryTypes.Milk, Notes = string.Empty });

            RaiseAllPropertiesChanged();
        }

    }
}
