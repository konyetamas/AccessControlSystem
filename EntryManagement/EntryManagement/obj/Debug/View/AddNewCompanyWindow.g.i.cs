﻿#pragma checksum "..\..\..\View\AddNewCompanyWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E60ACD951A4E62B0C8EB3841CCC85613446D1C86"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EntryManagement.View;
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


namespace EntryManagement.View {
    
    
    /// <summary>
    /// AddNewCompanyWindow
    /// </summary>
    public partial class AddNewCompanyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\View\AddNewCompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CompanyNametextBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\AddNewCompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CompanyAddresstextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\AddNewCompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CompanyNamelabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\AddNewCompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CompanyAddresslabel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\AddNewCompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CompanyPhonetextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\AddNewCompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CompanyAddresslabel_Copy;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\AddNewCompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewCompanyButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EntryManagement;component/view/addnewcompanywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AddNewCompanyWindow.xaml"
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
            this.CompanyNametextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CompanyAddresstextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CompanyNamelabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.CompanyAddresslabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.CompanyPhonetextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CompanyAddresslabel_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.AddNewCompanyButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\View\AddNewCompanyWindow.xaml"
            this.AddNewCompanyButton.Click += new System.Windows.RoutedEventHandler(this.AddNewCompanyButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
