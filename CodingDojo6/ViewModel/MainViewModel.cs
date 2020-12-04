using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingDojo6.ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        private ViewModelBase currentVM;

        public ViewModelBase CurrentVM
        {
            get { return currentVM; }
            set { currentVM = value; RaisePropertyChanged(); }
        }

        public RelayCommand OverviewBtn;
        public RelayCommand MyToysBtn;
        
        public MainViewModel()
        {
          
        }

    }
}
