﻿#pragma checksum "C:\Users\Kirstin\Dropbox\pongMaster\gamePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C4E7F4E274D64FBCC45128D6F89B72D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace pongMaster {
    
    
    public partial class gamePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock timerTextBlock;
        
        internal System.Windows.Controls.TextBlock p1NameTextBlock;
        
        internal System.Windows.Controls.Button p1IncrementButton;
        
        internal System.Windows.Controls.TextBlock p1ScoreTextBlock;
        
        internal System.Windows.Controls.TextBlock p2NameTextBlock;
        
        internal System.Windows.Controls.Button p2IncrementButton;
        
        internal System.Windows.Controls.TextBlock p2ScoreTextBlock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/pongMaster;component/gamePage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.timerTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("timerTextBlock")));
            this.p1NameTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("p1NameTextBlock")));
            this.p1IncrementButton = ((System.Windows.Controls.Button)(this.FindName("p1IncrementButton")));
            this.p1ScoreTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("p1ScoreTextBlock")));
            this.p2NameTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("p2NameTextBlock")));
            this.p2IncrementButton = ((System.Windows.Controls.Button)(this.FindName("p2IncrementButton")));
            this.p2ScoreTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("p2ScoreTextBlock")));
        }
    }
}

