using System;
using System.Collections;
using System.Linq;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using GroceryShopper.Core.ViewModels;

namespace GroceryShopper.Core.Models
{
    public class Grocery : MvxNotifyPropertyChanged
    {
        private string _notes;
        private GroceryTypes _groceryType;
        private string _amount;

        public int Id { get; private set; }

        public string Notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
                RaisePropertyChanged(() => Notes);
            }
        }

        public GroceryTypes GroceryType
        {
            get { return _groceryType; }
            set
            {
                _groceryType = value;
                RaisePropertyChanged(()=> GroceryType);
            }
        }

        public string Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                RaisePropertyChanged(() => Amount);
            }
        }

        public Grocery()
        {
            Id = new Random(DateTime.Now.Millisecond).Next();
        }


        public ICommand DeleteItemCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    InMemoryStorage.Items.Remove(InMemoryStorage.Items.FirstOrDefault(v => v.Id == Id));
                });
            }
        }
    }
}