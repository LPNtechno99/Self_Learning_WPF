﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C19EB89BFA8500134DA81C8117476EB33F6B1C6D"
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
using WPF_CheckBox_Control;


namespace WPF_CheckBox_Control {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAllFeature;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFeatureAbc;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFeatureXyz;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFeatureWww;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_CheckBox_Control;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.cbAllFeature = ((System.Windows.Controls.CheckBox)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.cbAllFeature.Checked += new System.Windows.RoutedEventHandler(this.CbAllFeature_Checked);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.cbAllFeature.Unchecked += new System.Windows.RoutedEventHandler(this.CbAllFeature_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbFeatureAbc = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.cbFeatureAbc.Checked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.cbFeatureAbc.Unchecked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbFeatureXyz = ((System.Windows.Controls.CheckBox)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.cbFeatureXyz.Checked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MainWindow.xaml"
            this.cbFeatureXyz.Unchecked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbFeatureWww = ((System.Windows.Controls.CheckBox)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.cbFeatureWww.Checked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.cbFeatureWww.Unchecked += new System.Windows.RoutedEventHandler(this.cbFeature_CheckedChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
