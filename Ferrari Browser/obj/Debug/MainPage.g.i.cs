﻿#pragma checksum "B:\Work\Software Development Year 2 GMIT\WindowsPhoneDev\Ferrari Browser(V3 ContextMenu) - Copy\Ferrari Browser\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29222360CD3941128397B5F27DE472A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace Ferrari_Browser {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid HistoryPanel;
        
        internal System.Windows.Controls.TextBlock txtFerrariHistory;
        
        internal System.Windows.Controls.Grid PastCarsContentPanel;
        
        internal System.Windows.Controls.ListBox pastCarList;
        
        internal System.Windows.Controls.Grid PresentCarsContentPanel;
        
        internal System.Windows.Controls.ListBox presentCarList;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Search;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem about;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Ferrari%20Browser;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.HistoryPanel = ((System.Windows.Controls.Grid)(this.FindName("HistoryPanel")));
            this.txtFerrariHistory = ((System.Windows.Controls.TextBlock)(this.FindName("txtFerrariHistory")));
            this.PastCarsContentPanel = ((System.Windows.Controls.Grid)(this.FindName("PastCarsContentPanel")));
            this.pastCarList = ((System.Windows.Controls.ListBox)(this.FindName("pastCarList")));
            this.PresentCarsContentPanel = ((System.Windows.Controls.Grid)(this.FindName("PresentCarsContentPanel")));
            this.presentCarList = ((System.Windows.Controls.ListBox)(this.FindName("presentCarList")));
            this.Search = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Search")));
            this.about = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("about")));
        }
    }
}

