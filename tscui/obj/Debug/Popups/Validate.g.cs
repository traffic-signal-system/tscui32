﻿#pragma checksum "..\..\..\Popups\Validate.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "78527C3D2783AC0C5B742F8AABB35046"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Apex.Behaviours;
using Apex.Controls;
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
using System.Windows.Interactivity;
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


namespace tscui.Views {
    
    
    /// <summary>
    /// Validate
    /// </summary>
    public partial class Validate : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Popups\Validate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Cancel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Popups\Validate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Ok;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Popups\Validate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TbxValidPasswd;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Popups\Validate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblValidateResult;
        
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
            System.Uri resourceLocater = new System.Uri("/tscui;component/popups/validate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Popups\Validate.xaml"
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
            this.button_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Popups\Validate.xaml"
            this.button_Cancel.Click += new System.Windows.RoutedEventHandler(this.Btn_CancelClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_Ok = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Popups\Validate.xaml"
            this.button_Ok.Click += new System.Windows.RoutedEventHandler(this.button_OK_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbxValidPasswd = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.LblValidateResult = ((System.Windows.Controls.Label)(target));
            
            #line 48 "..\..\..\Popups\Validate.xaml"
            this.LblValidateResult.GotFocus += new System.Windows.RoutedEventHandler(this.LblValidateResult_GotFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
