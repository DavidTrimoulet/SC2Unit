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
    public partial class AbilityOrUpgradeDetail : PhoneApplicationPage
    {
        public AbilityOrUpgradeDetail()
        {
            InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            if (DataContext == null)
            {
                string selectedItem = "";
                NavigationContext.QueryString.TryGetValue("selectedItem", out selectedItem);

                string selectedType = "";
                NavigationContext.QueryString.TryGetValue("selectedType", out selectedType);

                if(selectedType == "Upgrades")
                {
                       
                    DataContext = App.ViewModel.FindUpgrade(selectedItem);

                }
                else if(selectedType == "Abilities")
                {
                       DataContext = App.ViewModel.FindAbility(selectedItem);
             
                }
            }
            }
        }
    }