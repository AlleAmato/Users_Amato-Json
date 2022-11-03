﻿using System;
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
using System.Windows.Shapes;
using UsersWpf.ViewModels;

namespace UsersWpf
{
    /// <summary>
    /// Interaction logic for UsersView.xaml
    /// </summary>
    public partial class UsersView : Window
    {
        private UsersViewModel vm;
        public UsersView()
        {
            InitializeComponent();
            vm = new UsersViewModel();
            DataContext = vm;
        }
    }
}
