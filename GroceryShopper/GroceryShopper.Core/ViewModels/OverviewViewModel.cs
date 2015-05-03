using System.Collections.ObjectModel;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using GroceryShopper.Core.Models;

namespace GroceryShopper.Core.ViewModels
{
    public static class InMemoryStorage
    {
        private static ObservableCollection<Grocery> _items = new ObservableCollection<Grocery>();

        public static ObservableCollection<Grocery> Items
        {
            get { return _items; }
            set { _items = value; }
        }
    }



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

            // testing
            GroceryItems.Add(new Grocery { Amount = "100g", GroceryType = GroceryTypes.Sugar, Notes = string.Empty});
            GroceryItems.Add(new Grocery { Amount = "2kg", GroceryType = GroceryTypes.Meat, Notes = string.Empty });
            GroceryItems.Add(new Grocery { Amount = "1L", GroceryType = GroceryTypes.Milk, Notes = string.Empty });

            RaiseAllPropertiesChanged();
        }
    }

    public class NewItemViewModel : MvxViewModel
    {
        
    }
}
