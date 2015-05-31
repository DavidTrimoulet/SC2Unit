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
    public partial class RaceBuilding : PhoneApplicationPage
    {
        public RaceBuilding()
        {
            InitializeComponent();

            DataContext = App.ViewModel;
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }


        private void Terran_LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TerranLLS.SelectedItem == null)
                return;

            LongListSelector selected = sender as LongListSelector;


            // Naviguer vers la nouvelle page
            NavigationService.Navigate(new Uri("/BuildingDetail.xaml?selectedItem=" + (TerranLLS.SelectedItem as SC2Unit.ViewModels.Building).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            TerranLLS.SelectedItem = null;
        }


        private void Protoss_LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProtossLLS.SelectedItem == null)
                return;
            LongListSelector selected = sender as LongListSelector;

            // Naviguer vers la nouvelle page
            NavigationService.Navigate(new Uri("/BuildingDetail.xaml?selectedItem=" + (ProtossLLS.SelectedItem as SC2Unit.ViewModels.Building).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            ProtossLLS.SelectedItem = null;
        }

        private void Zerg_LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ZergLLS.SelectedItem == null)
                return;
            LongListSelector selected = sender as LongListSelector;

            // Naviguer vers la nouvelle page
            NavigationService.Navigate(new Uri("/BuildingDetail.xaml?selectedItem=" + (ZergLLS.SelectedItem as SC2Unit.ViewModels.Building).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            ZergLLS.SelectedItem = null;
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}