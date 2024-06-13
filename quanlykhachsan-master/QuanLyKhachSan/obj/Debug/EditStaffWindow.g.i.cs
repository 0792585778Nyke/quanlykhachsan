﻿#pragma checksum "..\..\EditStaffWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7208BAE88F7CD8EF60425F6757A98A2285D2AD336EF5280308F9A1615D030147"
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
    /// EditStaffWindow
    /// </summary>
    public partial class EditStaffWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\EditStaffWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QuanLyKhachSan.EditStaffWindow editStaffWindow;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\EditStaffWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staffName;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\EditStaffWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staffIdentity;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\EditStaffWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\EditStaffWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker birthday;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\EditStaffWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnMale;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\EditStaffWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnFemale;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\EditStaffWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox address;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyKhachSan;component/editstaffwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditStaffWindow.xaml"
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
            this.editStaffWindow = ((QuanLyKhachSan.EditStaffWindow)(target));
            return;
            case 2:
            this.staffName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.staffIdentity = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\EditStaffWindow.xaml"
            this.staffIdentity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputt);
            
            #line default
            #line hidden
            return;
            case 4:
            this.phone = ((System.Windows.Controls.TextBox)(target));
            
            #line 92 "..\..\EditStaffWindow.xaml"
            this.phone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputt);
            
            #line default
            #line hidden
            return;
            case 5:
            this.birthday = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.btnMale = ((System.Windows.Controls.RadioButton)(target));
            
            #line 128 "..\..\EditStaffWindow.xaml"
            this.btnMale.Click += new System.Windows.RoutedEventHandler(this.btnMale_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnFemale = ((System.Windows.Controls.RadioButton)(target));
            
            #line 133 "..\..\EditStaffWindow.xaml"
            this.btnFemale.Click += new System.Windows.RoutedEventHandler(this.btnFeMale_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 177 "..\..\EditStaffWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

