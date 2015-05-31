using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SC2Unit.Resources;

namespace SC2Unit
{
    public partial class RaceUnit : PhoneApplicationPage
    {
        // Constructeur
        public RaceUnit()
        {
            InitializeComponent();

            // Affecter l'exemple de données au contexte de données du contrôle ListBox
            DataContext = App.ViewModel;

            // Exemple de code pour la localisation d'ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Charger les données pour les éléments ViewModel
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
            NavigationService.Navigate(new Uri("/UnitDetail.xaml?selectedItem=" + (TerranLLS.SelectedItem as SC2Unit.ViewModels.Unit).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            TerranLLS.SelectedItem = null;
        }

        
        private void Protoss_LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProtossLLS.SelectedItem == null)
                return;
            LongListSelector selected = sender as LongListSelector;
            
            // Naviguer vers la nouvelle page
            NavigationService.Navigate(new Uri("/UnitDetail.xaml?selectedItem=" + (ProtossLLS.SelectedItem as SC2Unit.ViewModels.Unit).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            ProtossLLS.SelectedItem = null;
        }

        private void Zerg_LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ZergLLS.SelectedItem == null)
                return;
            LongListSelector selected = sender as LongListSelector;
            
            // Naviguer vers la nouvelle page
            NavigationService.Navigate(new Uri("/UnitDetail.xaml?selectedItem=" + (ZergLLS.SelectedItem as SC2Unit.ViewModels.Unit).Title, UriKind.Relative));

            // Réinitialiser l'élément sélectionné sur Null (pas de sélection)
            ZergLLS.SelectedItem = null;
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        
        // Exemple de code pour la conception d'une ApplicationBar localisée
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Définit l'ApplicationBar de la page sur une nouvelle instance d'ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crée un bouton et définit la valeur du texte sur la chaîne localisée issue d'AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crée un nouvel élément de menu avec la chaîne localisée d'AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}