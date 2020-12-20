using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingDojo6.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator() 
        { 
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<OverviewVM>();
            SimpleIoc.Default.Register<MyToysVM>();
            //Overview.ItemAdded += MyToys.ChosenItem_ItemAdded;
        }
        public MainViewModel Main => SimpleIoc.Default.GetInstance<MainViewModel>();
        public OverviewVM Overview => SimpleIoc.Default.GetInstance<OverviewVM>();
        public MyToysVM MyToys => SimpleIoc.Default.GetInstance<MyToysVM>();
    }
}
