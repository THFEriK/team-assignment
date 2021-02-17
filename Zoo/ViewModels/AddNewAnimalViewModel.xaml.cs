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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zoo.ViewModels
{
    /// <summary>
    /// Interaction logic for AddNewAnimalViewModel.xaml
    /// </summary>
    public partial class AddNewAnimalViewModel : UserControl
    {
        public AddNewAnimalViewModel()
        {
            InitializeComponent();
        }

        private void NameTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == "Állat neve")
            {
                NameTb.Text = "";
                NameTb.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void NameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == "")
            {
                NameTb.Text = "Állat neve";
                NameTb.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var MainView = new MainWindowViewModel();
            this.Content = MainView;
        }

        private void AddNewSpeciesBtn_Click(object sender, RoutedEventArgs e)
        {
            var SubWindow = new AddNewSpeciesViewModel();
            this.Content = SubWindow;
        }
    }
}
