using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingDojo6.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVM;

        public ViewModelBase CurrentVM
        {
            get { return currentVM; }
            set { currentVM = value; RaisePropertyChanged(); }
        }

        public RelayCommand OverviewBtn { get; set; }
        public RelayCommand MyToysBtn { get; set; }

        public MainViewModel()
        {

            OverviewBtn = new RelayCommand(() =>
            {
                CurrentVM = SimpleIoc.Default.GetInstance<OverviewVM>(); 
                RaisePropertyChanged();
            });
            MyToysBtn = new RelayCommand(() => { CurrentVM = SimpleIoc.Default.GetInstance<MyToysVM>(); });

        }

    }
}
