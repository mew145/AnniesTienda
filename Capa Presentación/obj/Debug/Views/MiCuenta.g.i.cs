﻿#pragma checksum "..\..\..\Views\MiCuenta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "760D44542CCF13AB59CF8AC831D3DCE4F889B60AAB0525B76F7B5CE147C058D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Annies_Store.Views;
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


namespace Annies_Store.Views {
    
    
    /// <summary>
    /// MiCuenta
    /// </summary>
    public partial class MiCuenta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\Views\MiCuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image fondo;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\MiCuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblnombre;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\MiCuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblApellidos;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\MiCuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblCorreo;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\MiCuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblPrivilegio;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\MiCuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagen;
        
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
            System.Uri resourceLocater = new System.Uri("/Annies Store;component/views/micuenta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MiCuenta.xaml"
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
            
            #line 14 "..\..\..\Views\MiCuenta.xaml"
            ((Annies_Store.Views.MiCuenta)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cerrar);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fondo = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.lblnombre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.lblApellidos = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.lblCorreo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.lblPrivilegio = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.imagen = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

