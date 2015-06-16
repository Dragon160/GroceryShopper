using System.Collections.ObjectModel;
using GroceryShopper.Forms.Models;

namespace GroceryShopper.Forms
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