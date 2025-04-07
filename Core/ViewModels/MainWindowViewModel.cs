using Common;
using Prism.Mvvm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Windows;

namespace Core.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string titleOfApp = "Tera";
        public string TitleOfApp
        {
            get { return titleOfApp; }
            set { SetProperty(ref titleOfApp, value); }
        }

        public MainWindowViewModel()
        {
           

        }
    }
}
