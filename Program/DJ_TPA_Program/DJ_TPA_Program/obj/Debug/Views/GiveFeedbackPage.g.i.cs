﻿#pragma checksum "..\..\..\Views\GiveFeedbackPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6D85B2A68E49A3D9489F7355000E571C4E2B4642"
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
    /// GiveFeedbackPage
    /// </summary>
    public partial class GiveFeedbackPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\Views\GiveFeedbackPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid orderRequestTable;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\GiveFeedbackPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idText;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\GiveFeedbackPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantity;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\GiveFeedbackPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button doSendRequestButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DJ_TPA_Program;component/views/givefeedbackpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\GiveFeedbackPage.xaml"
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
            this.orderRequestTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.idText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.quantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.doSendRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Views\GiveFeedbackPage.xaml"
            this.doSendRequestButton.Click += new System.Windows.RoutedEventHandler(this.DoGiveFeedback);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

