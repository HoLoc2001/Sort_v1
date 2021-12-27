﻿#pragma checksum "..\..\Sort.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C2D1C0A4D9FBF80344D64B6C230F18CBD5AF14D910DF542D4F50B44AC2FC1D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Algorithms;
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


namespace Algorithms {
    
    
    /// <summary>
    /// Sort
    /// </summary>
    public partial class Sort : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderNumber;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ArrayTime;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LinkedListTime;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSortArray;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSortLinkedList;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRandom;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReset;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbAlgorithms;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas1;
        
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
            System.Uri resourceLocater = new System.Uri("/Algorithms;component/sort.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sort.xaml"
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
            
            #line 8 "..\..\Sort.xaml"
            ((Algorithms.Sort)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Sort.xaml"
            ((Algorithms.Sort)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.sliderNumber = ((System.Windows.Controls.Slider)(target));
            
            #line 11 "..\..\Sort.xaml"
            this.sliderNumber.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderNumber_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ArrayTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.LinkedListTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.NumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\Sort.xaml"
            this.NumberTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 14 "..\..\Sort.xaml"
            this.NumberTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NumberTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSortArray = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Sort.xaml"
            this.btnSortArray.Click += new System.Windows.RoutedEventHandler(this.btnSortArray_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSortLinkedList = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Sort.xaml"
            this.btnSortLinkedList.Click += new System.Windows.RoutedEventHandler(this.btnSortLinkedList_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnRandom = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Sort.xaml"
            this.btnRandom.Click += new System.Windows.RoutedEventHandler(this.btnRandom_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnReset = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Sort.xaml"
            this.BtnReset.Click += new System.Windows.RoutedEventHandler(this.BtnReset_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txbAlgorithms = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.canvas1 = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

