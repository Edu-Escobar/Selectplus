﻿#pragma checksum "..\..\..\..\Ciencias\Matematicas\Tema1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "039F0BCCC0852B0638878E5D871FF357439305ACE7038C662BE9E0ECB7C618E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoFinal.Ciencias.Matematicas;
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


namespace ProyectoFinal.Ciencias.Matematicas {
    
    
    /// <summary>
    /// Tema1
    /// </summary>
    public partial class Tema1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Ciencias\Matematicas\Tema1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button letras;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Ciencias\Matematicas\Tema1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button letras_Copy1;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Ciencias\Matematicas\Tema1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button letras_Copy2;
        
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
            System.Uri resourceLocater = new System.Uri("/ProyectoFinal;component/ciencias/matematicas/tema1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ciencias\Matematicas\Tema1.xaml"
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
            this.letras = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Ciencias\Matematicas\Tema1.xaml"
            this.letras.Click += new System.Windows.RoutedEventHandler(this.teoria_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.letras_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Ciencias\Matematicas\Tema1.xaml"
            this.letras_Copy1.Click += new System.Windows.RoutedEventHandler(this.ejercicios_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.letras_Copy2 = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Ciencias\Matematicas\Tema1.xaml"
            this.letras_Copy2.Click += new System.Windows.RoutedEventHandler(this.puntuacion_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

