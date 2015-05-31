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
    public partial class UnitDetail : PhoneApplicationPage
    {
        public UnitDetail()
        {
            InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            if (DataContext == null)
            {
                string selectedItem = "";
                NavigationContext.QueryString.TryGetValue("selectedItem", out selectedItem);
                
               
                            DataContext = App.ViewModel.FindUnit(selectedItem);
                                  
                    
            }
        }

        private void WeakAgainst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          NavigationService.Navigate(new Uri("/UnitDetail.xaml?selectedItem=" + (WeakAgainst.SelectedItem as SC2Unit.ViewModels.Unit).Title , UriKind.Relative));
        }

        private void StrongAgainst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UnitDetail.xaml?selectedItem=" + (StrongAgainst.SelectedItem as SC2Unit.ViewModels.Unit).Title, UriKind.Relative));
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RaceUnit.xaml", UriKind.Relative));
        }

        private void Upgrades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AbilityOrUpgradeDetail.xaml?selectedItem=" + (Upgrades.SelectedItem as SC2Unit.ViewModels.Upgrade).Title +"&selectedType="+ Upgrades.Name , UriKind.Relative));
        }

        private void Abilities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AbilityOrUpgradeDetail.xaml?selectedItem=" + (Abilities.SelectedItem as SC2Unit.ViewModels.Ability).Title + "&selectedType=" + Abilities.Name, UriKind.Relative));
        }


      
    }
}