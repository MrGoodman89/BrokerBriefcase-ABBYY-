﻿#pragma checksum "..\..\Registr.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F71CAA68C3E15393292035656D3F70FB1B0348A645B823225EA45266E9A570D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace PortfelBroker {
    
    
    /// <summary>
    /// Registr
    /// </summary>
    public partial class Registr : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PortfelBroker.Registr window1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtlog;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtpas;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Vhod;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reg;
        
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
            System.Uri resourceLocater = new System.Uri("/PortfelBroker;component/registr.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Registr.xaml"
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
            this.window1 = ((PortfelBroker.Registr)(target));
            
            #line 5 "..\..\Registr.xaml"
            this.window1.Closed += new System.EventHandler(this.window1_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtlog = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtpas = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Vhod = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Registr.xaml"
            this.Vhod.Click += new System.Windows.RoutedEventHandler(this.Vhod_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Reg = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Registr.xaml"
            this.Reg.Click += new System.Windows.RoutedEventHandler(this.Reg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
