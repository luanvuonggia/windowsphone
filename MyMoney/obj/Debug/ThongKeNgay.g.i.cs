﻿#pragma checksum "D:\Hoc\DoAnCuoiKy\MyMoney\MyMoney\ThongKeNgay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "452C03B4F8720AC27336B58EDD3EAD62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AmCharts.Windows.QuickCharts;
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
    
    
    public partial class ThongKeHomNay : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock txtTongThu;
        
        internal System.Windows.Controls.TextBlock txtTongChi;
        
        internal AmCharts.Windows.QuickCharts.PieChart Pie;
        
        internal AmCharts.Windows.QuickCharts.PieChart Pie2;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MyMoney;component/ThongKeNgay.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtTongThu = ((System.Windows.Controls.TextBlock)(this.FindName("txtTongThu")));
            this.txtTongChi = ((System.Windows.Controls.TextBlock)(this.FindName("txtTongChi")));
            this.Pie = ((AmCharts.Windows.QuickCharts.PieChart)(this.FindName("Pie")));
            this.Pie2 = ((AmCharts.Windows.QuickCharts.PieChart)(this.FindName("Pie2")));
        }
    }
}

