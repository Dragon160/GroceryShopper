using System;
using System.Collections.Generic;
using System.Windows.Input;
using Chance.MvvmCross.Plugins.UserInteraction;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using GroceryShopper.Forms.Models;

namespace GroceryShopper.Forms.ViewModels
{
    public class NewItemViewModel : MvxViewModel
    {
        private ICommand _saveCommand;
        private List<string> _availableGroceryTypes = new List<string>();

        public string GroceryType { get; set; }

        public int GroceryTypeIndex
        {
            get { return _availableGroceryTypes.IndexOf(GroceryType); }
            set { GroceryType = _availableGroceryTypes[value]; }
        }

        public List<string> AvailableGroceryTypes
        {
            get { return _availableGroceryTypes; }
            set { _availableGroceryTypes = value; }
        }

        public string Amount { get; set; }

        public string Notes { get; set; }

        public override void Start()
        {
            var values = Enum.GetValues(typeof(GroceryTypes));
            foreach (var item in values)
            {
                AvailableGroceryTypes.Add(((GroceryTypes)item).ToString());
            }

            RaiseAllPropertiesChanged();
        }


        public ICommand SaveCommand
        {
            get { return _saveCommand ?? (_saveCommand = new MvxCommand(Save)); }
        }

        private void Save()
        {
            if (ValidateForFalse())
            {
                Mvx.Resolve<IUserInteraction>().Alert("Please check your input");
                return;
            }

            var newItem = new Grocery
            {
                Amount = Amount,
                GroceryType = (GroceryTypes)Enum.Parse(typeof(GroceryTypes), GroceryType),
                Notes = Notes
            };

            InMemoryStorage.Items.Add(newItem);
            Close(this);

        }

        private bool ValidateForFalse()
        {
            return string.IsNullOrEmpty(Amount) || string.IsNullOrEmpty(GroceryType);
        }
    }
}