﻿using FO.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FO.UI
{
   
    public partial class MainWindow : Window
    {
        private MainViewModel _vm;

        public MainWindow(MainViewModel vm)
        {
            
            InitializeComponent();
            _vm = vm;
            DataContext = _vm;
            //DataContext = vm;
            //vm.Load(); don't do this.
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _vm.Load();
        }
    }
}
