﻿#pragma checksum "..\..\..\ViewModels\AddNewAnimalViewModel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A79852C74068FAC9E7861AC3C25FC722BEA1DA549053B225F3F9188935E86EA8"
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
    /// AddNewAnimalViewModel
    /// </summary>
    public partial class AddNewAnimalViewModel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AnimalsLb;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTb;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SpeciesCb;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ContinentCb;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox VulnerableRateTb;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewAnimalBtn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewSpeciesBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Zoo;component/viewmodels/addnewanimalviewmodel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
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
            this.AnimalsLb = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.NameTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
            this.NameTb.GotFocus += new System.Windows.RoutedEventHandler(this.NameTb_GotFocus);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
            this.NameTb.LostFocus += new System.Windows.RoutedEventHandler(this.NameTb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SpeciesCb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ContinentCb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.VulnerableRateTb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.NewAnimalBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.AddNewSpeciesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
            this.AddNewSpeciesBtn.Click += new System.Windows.RoutedEventHandler(this.AddNewSpeciesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\ViewModels\AddNewAnimalViewModel.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

