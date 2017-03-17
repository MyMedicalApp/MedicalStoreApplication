﻿#pragma checksum "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2170C0A5E5B265205BBC6AEB89B0E7C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MedicalApp.UserControls;
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


namespace MedicalApp.Views {
    
    
    /// <summary>
    /// SalesBill
    /// </summary>
    public partial class SalesBill : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBillSeries;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBillNo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBillDate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbRate;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCutomerName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCutomerAddress;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDoctorName;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDoctorAddress;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SalesBillGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/TextileApp;component/presentationlayer/views/salesbill.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
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
            this.txtBillSeries = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtBillNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtBillDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cmbRate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.txtCutomerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtCutomerAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtDoctorName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtDoctorAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.SalesBillGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 39 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
            this.SalesBillGrid.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SalesBillGrid_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\..\..\PresentationLayer\Views\SalesBill.xaml"
            this.SalesBillGrid.RowEditEnding += new System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>(this.SalesBillGrid_RowEditEnding);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

