﻿#pragma checksum "..\..\..\View\PgSaisieResultats.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "033DBB31DB71B295C1326164C61E082C62175955E894BC05C4F5073A1EB61046"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WpfAppBaccarat.View;


namespace WpfAppBaccarat.View {
    
    
    /// <summary>
    /// PgSaisieResultats
    /// </summary>
    public partial class PgSaisieResultats : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\PgSaisieResultats.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumsTombes;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\PgSaisieResultats.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumsJoues;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\PgSaisieResultats.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtResultats;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppBaccarat;component/view/pgsaisieresultats.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\PgSaisieResultats.xaml"
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
            this.txtNumsTombes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNumsJoues = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtResultats = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 18 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AfficherResultat_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 19 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddPlayerToJoue_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 20 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBankerToJoue_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 21 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTieToJoue_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 22 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddPlayerToReel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 23 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBankerToReel_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 24 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTieToReel_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 25 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Initialisation_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 26 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddIgnoreToJoue_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 27 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddIgnoreToReel_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 28 "..\..\..\View\PgSaisieResultats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToPgMontantes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

