﻿#pragma checksum "C:\Users\GiaLuan\Desktop\MyMoney\MyMoney\SoChiTIeu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3E99CC898C0712725F3FB53922A4C2EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace MyMoney {
    
    
    public partial class SoChiTIeu : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid lstSoChiTieu;
        
        internal Microsoft.Phone.Controls.LongListSelector listGiaoDich;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MyMoney;component/SoChiTIeu.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.lstSoChiTieu = ((System.Windows.Controls.Grid)(this.FindName("lstSoChiTieu")));
            this.listGiaoDich = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("listGiaoDich")));
        }
    }
}

