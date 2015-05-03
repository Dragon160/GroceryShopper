using System.Collections.ObjectModel;
using GroceryShopper.Core.Models;

namespace GroceryShopper.Core
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
}