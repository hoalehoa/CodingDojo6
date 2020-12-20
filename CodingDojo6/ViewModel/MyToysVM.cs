using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CodingDojo6.ViewModel
{
    public class MyToysVM : ViewModelBase
    {
        public ObservableCollection<ItemVM> Cart { get; set; }

        public MyToysVM()
        {
            MessengerInstance.Register<ItemVM>(this, ChosenItem_ItemAdded);
        }

        public void ChosenItem_ItemAdded(ItemVM e)
        {
            if (Cart == null)
            {
                Cart = new ObservableCollection<ItemVM>();
            }
            Cart.Add(e);
        }
    }
}
