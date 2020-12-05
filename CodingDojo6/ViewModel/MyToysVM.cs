using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CodingDojo6.ViewModel
{
    public class MyToysVM: ViewModelBase
    {
        public ObservableCollection<ItemVM> Cart { get; set; }
       
        
        public MyToysVM()
        {
           
        }

        public void ChosenItem_ItemAdded(object sender, ItemVM e)
        {
            if(Cart == null)
            {
                Cart = new ObservableCollection<ItemVM>();
            }
            Cart.Add(e);
        }
    }
}
