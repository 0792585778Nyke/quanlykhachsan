﻿#pragma checksum "..\..\EditBooking.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8A4A22A1C95DA3C86125D39CF6D9A07F2D0B7E9D991A691176EDA94EB031FBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QuanLyKhachSan;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace QuanLyKhachSan {
    
    
    /// <summary>
    /// EditBooking
    /// </summary>
    public partial class EditBooking : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QuanLyKhachSan.EditBooking EditBookingWindow;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox roomID;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cusID;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cusName;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cusCount;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeCustomer;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox serID;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker timearrival;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker timeleft;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\EditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker timeBook;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyKhachSan;component/editbooking.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditBooking.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EditBookingWindow = ((QuanLyKhachSan.EditBooking)(target));
            
            #line 18 "..\..\EditBooking.xaml"
            this.EditBookingWindow.Loaded += new System.Windows.RoutedEventHandler(this.EditBookingWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.roomID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cusID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cusName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cusCount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.typeCustomer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.serID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.timearrival = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.timeleft = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.timeBook = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            
            #line 231 "..\..\EditBooking.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 243 "..\..\EditBooking.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

