﻿#pragma checksum "..\..\..\ViewModels\AddNewSpeciesViewModel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F7B43EDFEF6AECF26481D33DFE2BC3129B7580D3EC46A25B7BD82E5DFEFC2BEE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Zoo.ViewModels;


namespace Zoo.ViewModels {
    
    
    /// <summary>
    /// AddNewSpeciesViewModel
    /// </summary>
    public partial class AddNewSpeciesViewModel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\ViewModels\AddNewSpeciesViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTb;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ViewModels\AddNewSpeciesViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewSpeciesBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ViewModels\AddNewSpeciesViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Zoo;component/viewmodels/addnewspeciesviewmodel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewModels\AddNewSpeciesViewModel.xaml"
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
            this.NameTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\ViewModels\AddNewSpeciesViewModel.xaml"
            this.NameTb.GotFocus += new System.Windows.RoutedEventHandler(this.NameTb_GotFocus);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\ViewModels\AddNewSpeciesViewModel.xaml"
            this.NameTb.LostFocus += new System.Windows.RoutedEventHandler(this.NameTb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NewSpeciesBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\ViewModels\AddNewSpeciesViewModel.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
