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
    public partial class BuildOrderUI : PhoneApplicationPage
    {
        public BuildOrderUI()
        {

            InitializeComponent();
            DataContext = App.ViewModel;

        }

        private void Zerg_LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ZergLLS.SelectedItem == null)
                return;
            LongListSelector selected = sender as LongListSelector;

            // Naviguer vers la nouvelle page
            NavigationService.Navigate(new Uri("/BuildOrderDetail.xaml?selectedItem=" + (ZergLLS.SelectedItem as SC2Unit.ViewModels.BuildOrder).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            ZergLLS.SelectedItem = null;
        }

        private void Protoss_LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProtossLLS.SelectedItem == null)
                return;
            LongListSelector selected = sender as LongListSelector;

            // Naviguer vers la nouvelle page
            NavigationService.Navigate(new Uri("/BuildOrderDetail.xaml?selectedItem=" + (ProtossLLS.SelectedItem as SC2Unit.ViewModels.BuildOrder).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            ProtossLLS.SelectedItem = null;
        }

        private void Terran_LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TerranLLS.SelectedItem == null)
                return;
            LongListSelector selected = sender as LongListSelector;

            // Naviguer vers la nouvelle page
            NavigationService.Navigate(new Uri("/BuildOrderDetail.xaml?selectedItem=" + (TerranLLS.SelectedItem as SC2Unit.ViewModels.BuildOrder).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            TerranLLS.SelectedItem = null;
        }


    }
}