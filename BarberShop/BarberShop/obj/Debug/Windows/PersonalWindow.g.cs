#pragma checksum "..\..\..\Windows\PersonalWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5A76EEB7200CA54A9CBE86E93C7C2FF3FB7B8D2850A553E1913164A74A1AAA48"
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
    /// PersonalWindow
    /// </summary>
    public partial class PersonalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Windows\PersonalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Windows\PersonalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Windows\PersonalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Sort;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\PersonalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AllPersonal;
        
        #line default
        #line hidden
        
        
        #line 274 "..\..\..\Windows\PersonalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\..\Windows\PersonalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\..\Windows\PersonalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button change;
        
        #line default
        #line hidden
        
        
        #line 324 "..\..\..\Windows\PersonalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
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
            System.Uri resourceLocater = new System.Uri("/BarberShop;component/windows/personalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\PersonalWindow.xaml"
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
            
            #line 51 "..\..\..\Windows\PersonalWindow.xaml"
            this.Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\..\Windows\PersonalWindow.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Sort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 97 "..\..\..\Windows\PersonalWindow.xaml"
            this.Sort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Sort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AllPersonal = ((System.Windows.Controls.ListView)(target));
            
            #line 109 "..\..\..\Windows\PersonalWindow.xaml"
            this.AllPersonal.KeyUp += new System.Windows.Input.KeyEventHandler(this.AllPersonal_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 281 "..\..\..\Windows\PersonalWindow.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 297 "..\..\..\Windows\PersonalWindow.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.change = ((System.Windows.Controls.Button)(target));
            
            #line 314 "..\..\..\Windows\PersonalWindow.xaml"
            this.change.Click += new System.Windows.RoutedEventHandler(this.change_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 331 "..\..\..\Windows\PersonalWindow.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

