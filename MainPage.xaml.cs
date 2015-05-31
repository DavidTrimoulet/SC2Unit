using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SC2Unit
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Unit_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RaceUnit.xaml", UriKind.Relative));
        }


        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            App.Current.Terminate();
        }

        private void Building_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RaceBuilding.xaml", UriKind.Relative));
        }

        private void BuildOrder_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BuildOrderUI.xaml", UriKind.Relative));
        }
    }
}