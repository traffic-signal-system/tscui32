﻿#pragma checksum "..\..\..\..\Pages\Schedules\ScheduleView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB81F43B9E6A7F2BD6ADF2063CD9F88E"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Apex.MVVM;
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
using tscui.Pages.Schedules;


namespace tscui.Pages.Schedules {
    
    
    /// <summary>
    /// ScheduleView
    /// </summary>
    public partial class ScheduleView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid scheduleDataGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ScheduleAdd;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ScheduleContext;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Id;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn cbxucCtrl;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn ucTimePatternId;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sldScheduleId;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbkScheduleId;
        
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
            System.Uri resourceLocater = new System.Uri("/tscui;component/pages/schedules/scheduleview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
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
            
            #line 8 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
            ((tscui.Pages.Schedules.ScheduleView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scheduleDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
            this.scheduleDataGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.scheduleDataGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ScheduleAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
            this.ScheduleAdd.Click += new System.Windows.RoutedEventHandler(this.Add_ScheduleId);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ScheduleContext = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
            this.ScheduleContext.Click += new System.Windows.RoutedEventHandler(this.Delete_ScheduleId);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Id = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.cbxucCtrl = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 7:
            this.ucTimePatternId = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 8:
            this.sldScheduleId = ((System.Windows.Controls.Slider)(target));
            
            #line 67 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
            this.sldScheduleId.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sldScheduleId_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbkScheduleId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 69 "..\..\..\..\Pages\Schedules\ScheduleView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
