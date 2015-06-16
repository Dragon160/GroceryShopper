using System;
using System.Linq;
using System.Windows.Input;
using Chance.MvvmCross.Plugins.UserInteraction;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using GroceryShopper.Core;

namespace GroceryShopper.Forms.Models
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
                    Mvx.Resolve<IUserInteraction>().Confirm("Do you really want to delete this item?", (v =>
                    {
                        if (v)
                        {
                            InMemoryStorage.Items.Remove(InMemoryStorage.Items.FirstOrDefault(a => a.Id == Id));
                        }
                    }));
                });
            }
        }
    }
}