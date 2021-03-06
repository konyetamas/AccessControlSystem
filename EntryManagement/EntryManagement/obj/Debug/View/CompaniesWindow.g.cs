﻿#pragma checksum "..\..\..\View\CompaniesWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06B99B1CBFB99B7FB54D92EE0849303E9AC8BB53"
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
    /// CompaniesWindow
    /// </summary>
    public partial class CompaniesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\View\CompaniesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CompaniesListView;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\CompaniesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedCompanyNameLabel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\CompaniesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedCompanyNameAddress;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\CompaniesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedCompanyNamePhone;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\CompaniesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MembersOfCompanyListView;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\CompaniesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewCompanyButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\CompaniesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteCompanyButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EntryManagement;component/view/companieswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CompaniesWindow.xaml"
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
            this.CompaniesListView = ((System.Windows.Controls.ListView)(target));
            
            #line 11 "..\..\..\View\CompaniesWindow.xaml"
            this.CompaniesListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CompaniesListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SelectedCompanyNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.SelectedCompanyNameAddress = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.SelectedCompanyNamePhone = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.MembersOfCompanyListView = ((System.Windows.Controls.ListView)(target));
            
            #line 28 "..\..\..\View\CompaniesWindow.xaml"
            this.MembersOfCompanyListView.Loaded += new System.Windows.RoutedEventHandler(this.MembersOfCompanyListView_Initialized);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddNewCompanyButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\View\CompaniesWindow.xaml"
            this.AddNewCompanyButton.Click += new System.Windows.RoutedEventHandler(this.AddNewCompanyButtonClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteCompanyButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\View\CompaniesWindow.xaml"
            this.DeleteCompanyButton.Click += new System.Windows.RoutedEventHandler(this.DeleteSelectedCompanyButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

