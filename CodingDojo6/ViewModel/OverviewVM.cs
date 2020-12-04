using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media.Imaging;

namespace CodingDojo6.ViewModel
{
    public class OverviewVM: ViewModelBase
    {
        private ItemVM currentItem;

        public ItemVM CurrentItem
        {
            get { return currentItem; }
            set { currentItem = value; RaisePropertyChanged(); }
        }
        
        public ObservableCollection<ItemVM> Items { get; set; }
        private RelayCommand<ItemVM> buyBtn;
        public RelayCommand<ItemVM> BuyBtn
        {
            get { return buyBtn; }
            set { buyBtn = value; RaisePropertyChanged(nameof(BuyBtn)); }
        }
        public event EventHandler<ItemVM> ItemAdded;
        

        public OverviewVM()
        {
            Items = new ObservableCollection<ItemVM>();
            GenerateDemoData();
            BuyBtn = new RelayCommand<ItemVM>((p) => { ItemAdded?.Invoke(this, p); }, (p) => { return true; });
        }

        private void GenerateDemoData()
        {
            Items.Add(new ItemVM("MY Lego", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "-"));
            Items.Add(new ItemVM("MY Playmobil", new BitmapImage(new Uri("Images/playmobil1.jpg", UriKind.Relative)), "-"));

            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));


            Items[0].AddItem(
                new ItemVM("Lego 1", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "5+"));
            Items[0].AddItem(
                new ItemVM("Lego 2", new BitmapImage(new Uri("Images/lego2.jpg", UriKind.Relative)), "10+"));
        }
    }
}
