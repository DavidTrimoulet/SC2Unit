﻿#pragma checksum "C:\Users\David\Documents\GitHub\SC2Unit\UnitDetail.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2DF3252CA8BBD1B0A4F9C7DE7448D745"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SC2Unit {
    
    
    public partial class UnitDetail : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentRoot;
        
        internal System.Windows.Controls.Grid TitleGrid;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid WeakStrong;
        
        internal Microsoft.Phone.Controls.LongListSelector StrongAgainst;
        
        internal Microsoft.Phone.Controls.LongListSelector WeakAgainst;
        
        internal System.Windows.Controls.Grid AbilitiesAndUpgrades;
        
        internal Microsoft.Phone.Controls.LongListSelector Abilities;
        
        internal Microsoft.Phone.Controls.LongListSelector Upgrades;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SC2Unit;component/UnitDetail.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentRoot = ((System.Windows.Controls.Grid)(this.FindName("ContentRoot")));
            this.TitleGrid = ((System.Windows.Controls.Grid)(this.FindName("TitleGrid")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.WeakStrong = ((System.Windows.Controls.Grid)(this.FindName("WeakStrong")));
            this.StrongAgainst = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("StrongAgainst")));
            this.WeakAgainst = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("WeakAgainst")));
            this.AbilitiesAndUpgrades = ((System.Windows.Controls.Grid)(this.FindName("AbilitiesAndUpgrades")));
            this.Abilities = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("Abilities")));
            this.Upgrades = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("Upgrades")));
        }
    }
}
