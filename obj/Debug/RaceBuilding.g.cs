﻿#pragma checksum "C:\Users\David\Documents\GitHub\SC2Unit\RaceBuilding.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4C4C66527920045BF1A201025405F998"
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
    
    
    public partial class RaceBuilding : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.LongListSelector TerranLLS;
        
        internal Microsoft.Phone.Controls.LongListSelector ProtossLLS;
        
        internal Microsoft.Phone.Controls.LongListSelector ZergLLS;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SC2Unit;component/RaceBuilding.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TerranLLS = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("TerranLLS")));
            this.ProtossLLS = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("ProtossLLS")));
            this.ZergLLS = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("ZergLLS")));
        }
    }
}

