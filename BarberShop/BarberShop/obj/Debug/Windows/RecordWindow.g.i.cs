﻿#pragma checksum "..\..\..\Windows\RecordWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9D273E31667807847270D0FB0D938DFC3901B2683AD7A85375BD0648E28DDCAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BarberShop.Windows;
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


namespace BarberShop.Windows {
    
    
    /// <summary>
    /// RecordWindow
    /// </summary>
    public partial class RecordWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\Windows\RecordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Windows\RecordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Client;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Windows\RecordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Personel;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Windows\RecordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Service;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\Windows\RecordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\Windows\RecordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/BarberShop;component/windows/recordwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\RecordWindow.xaml"
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
            this.Close = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Windows\RecordWindow.xaml"
            this.Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Client = ((System.Windows.Controls.ComboBox)(target));
            
            #line 114 "..\..\..\Windows\RecordWindow.xaml"
            this.Client.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Client_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Personel = ((System.Windows.Controls.ComboBox)(target));
            
            #line 129 "..\..\..\Windows\RecordWindow.xaml"
            this.Personel.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Personel_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Service = ((System.Windows.Controls.ComboBox)(target));
            
            #line 144 "..\..\..\Windows\RecordWindow.xaml"
            this.Service.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Service_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\..\Windows\RecordWindow.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 178 "..\..\..\Windows\RecordWindow.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

