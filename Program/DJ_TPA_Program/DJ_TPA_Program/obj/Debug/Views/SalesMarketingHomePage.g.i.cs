﻿#pragma checksum "..\..\..\Views\SalesMarketingHomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B40FDFD324A26B9A1C63A4EE0DF65772157FA7C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DJ_TPA_Program.Views;
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


namespace DJ_TPA_Program.Views {
    
    
    /// <summary>
    /// SalesMarketingHomePage
    /// </summary>
    public partial class SalesMarketingHomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\Views\SalesMarketingHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock userLabelText;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\SalesMarketingHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeCurrentRideButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\SalesMarketingHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button planaNewRideButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\SalesMarketingHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeaCurrentRideButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\SalesMarketingHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DJ_TPA_Program;component/views/salesmarketinghomepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SalesMarketingHomePage.xaml"
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
            this.userLabelText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.changeCurrentRideButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Views\SalesMarketingHomePage.xaml"
            this.changeCurrentRideButton.Click += new System.Windows.RoutedEventHandler(this.DoRequestItem);
            
            #line default
            #line hidden
            return;
            case 3:
            this.planaNewRideButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Views\SalesMarketingHomePage.xaml"
            this.planaNewRideButton.Click += new System.Windows.RoutedEventHandler(this.DoLeavingPermission);
            
            #line default
            #line hidden
            return;
            case 4:
            this.changeaCurrentRideButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Views\SalesMarketingHomePage.xaml"
            this.changeaCurrentRideButton.Click += new System.Windows.RoutedEventHandler(this.DoResignLetter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.logoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Views\SalesMarketingHomePage.xaml"
            this.logoutButton.Click += new System.Windows.RoutedEventHandler(this.DoLogout);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

