﻿#pragma checksum "C:\Users\GiaLuan\Desktop\DoAn1\MyMoney\MyMoney\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC2F52840FAE20EA451D1BB00DA96B68"
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtUserName;
        
        internal System.Windows.Controls.TextBox txtSoTien;
        
        internal System.Windows.Controls.Button newAccount;
        
        internal System.Windows.Controls.Image checkNameImg;
        
        internal System.Windows.Controls.Image checkMoneyImg;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MyMoney;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtUserName = ((System.Windows.Controls.TextBox)(this.FindName("txtUserName")));
            this.txtSoTien = ((System.Windows.Controls.TextBox)(this.FindName("txtSoTien")));
            this.newAccount = ((System.Windows.Controls.Button)(this.FindName("newAccount")));
            this.checkNameImg = ((System.Windows.Controls.Image)(this.FindName("checkNameImg")));
            this.checkMoneyImg = ((System.Windows.Controls.Image)(this.FindName("checkMoneyImg")));
        }
    }
}

