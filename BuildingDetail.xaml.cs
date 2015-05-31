using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SC2Unit.ViewModels;

namespace SC2Unit
{
    public partial class BuildingDetail : PhoneApplicationPage
    {
        public BuildingDetail()
        {
            InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            if (DataContext == null)
            {
                string selectedItem = "";
                NavigationContext.QueryString.TryGetValue("selectedItem", out selectedItem);

                            DataContext = App.ViewModel.FindBuilding(selectedItem);
                     
                    
            }
        }

        private void Require_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          NavigationService.Navigate(new Uri("/BuildingDetail.xaml?selectedItem=" + (Require.SelectedItem as SC2Unit.ViewModels.Building).Title , UriKind.Relative));
        }

        private void GrantAccessTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BuildingDetail.xaml?selectedItem=" + (GrantAccessTo.SelectedItem as SC2Unit.ViewModels.Building).Title, UriKind.Relative));
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RaceBuilding.xaml", UriKind.Relative));
        }

        private void CanProduce_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UnitDetail.xaml?selectedItem=" + (CanProduce.SelectedItem as SC2Unit.ViewModels.Unit).Title, UriKind.Relative));
        }
      
    }
}