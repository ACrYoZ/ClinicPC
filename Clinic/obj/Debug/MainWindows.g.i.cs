﻿#pragma checksum "..\..\MainWindows.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21C9A3926888ED06EAA6006C402D3FD824C11AA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Clinic;
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


namespace Clinic {
    
    
    /// <summary>
    /// MainWindows
    /// </summary>
    public partial class MainWindows : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_Mail;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Tb_Password;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Mail;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Password;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Enter;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_RegistryName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_RegistrySurname;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_RegistryPatronymic;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_RegistryPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_RegistryPassportNumber;
        
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
            System.Uri resourceLocater = new System.Uri("/Clinic;component/mainwindows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindows.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Tb_Mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Tb_Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.label_Mail = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.label_Password = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Btn_Enter = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MainWindows.xaml"
            this.Btn_Enter.Click += new System.Windows.RoutedEventHandler(this.Btn_Enter_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Tb_RegistryName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Tb_RegistrySurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Tb_RegistryPatronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Tb_RegistryPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.Tb_RegistryPassportNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

