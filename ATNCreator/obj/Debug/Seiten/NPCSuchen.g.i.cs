﻿#pragma checksum "..\..\..\Seiten\NPCSuchen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D6EE4D2D84C8BD372B716E2C2436A8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using ATNCreator.Seiten;
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


namespace ATNCreator.Seiten {
    
    
    /// <summary>
    /// NPCSuchen
    /// </summary>
    public partial class NPCSuchen : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Seiten\NPCSuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbxSuchen;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Seiten\NPCSuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chkbxEntryIDSuchen;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Seiten\NPCSuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chkbxNamenSuchen;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Seiten\NPCSuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNPCsuchen;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Seiten\NPCSuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstBxLastUsedNPCs;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Seiten\NPCSuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNPCBearbeiten;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Seiten\NPCSuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstBxErgebnisse;
        
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
            System.Uri resourceLocater = new System.Uri("/ATNCreator;component/seiten/npcsuchen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Seiten\NPCSuchen.xaml"
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
            this.txtbxSuchen = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Seiten\NPCSuchen.xaml"
            this.txtbxSuchen.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtbxSuchen_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chkbxEntryIDSuchen = ((System.Windows.Controls.RadioButton)(target));
            
            #line 45 "..\..\..\Seiten\NPCSuchen.xaml"
            this.chkbxEntryIDSuchen.Checked += new System.Windows.RoutedEventHandler(this.chkbxEntryIDSuchen_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chkbxNamenSuchen = ((System.Windows.Controls.RadioButton)(target));
            
            #line 46 "..\..\..\Seiten\NPCSuchen.xaml"
            this.chkbxNamenSuchen.Checked += new System.Windows.RoutedEventHandler(this.chkbxNamenSuchen_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNPCsuchen = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Seiten\NPCSuchen.xaml"
            this.btnNPCsuchen.Click += new System.Windows.RoutedEventHandler(this.btnNPCsuchen_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lstBxLastUsedNPCs = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.btnNPCBearbeiten = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Seiten\NPCSuchen.xaml"
            this.btnNPCBearbeiten.Click += new System.Windows.RoutedEventHandler(this.btnNPCBearbeiten_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lstBxErgebnisse = ((System.Windows.Controls.ListBox)(target));
            
            #line 68 "..\..\..\Seiten\NPCSuchen.xaml"
            this.lstBxErgebnisse.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lstBxErgebnisse_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 68 "..\..\..\Seiten\NPCSuchen.xaml"
            this.lstBxErgebnisse.KeyDown += new System.Windows.Input.KeyEventHandler(this.lstBxErgebnisse_KeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
