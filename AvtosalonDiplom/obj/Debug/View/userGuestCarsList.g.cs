﻿#pragma checksum "..\..\..\View\userGuestCarsList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6373F8D271DADFFEADB59BBF8CEF651A1F1E56FD8C211C7C4DC96655ED596DBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AvtosalonDiplom.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace AvtosalonDiplom.View {
    
    
    /// <summary>
    /// userGuestCarsList
    /// </summary>
    public partial class userGuestCarsList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\View\userGuestCarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition LVColumn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\userGuestCarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\userGuestCarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBBrands;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\userGuestCarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBOrderCost;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\userGuestCarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CarsListView;
        
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
            System.Uri resourceLocater = new System.Uri("/AvtosalonDiplom;component/view/userguestcarslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\userGuestCarsList.xaml"
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
            this.LVColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 2:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\View\userGuestCarsList.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PoiskAvto);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CBBrands = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\View\userGuestCarsList.xaml"
            this.CBBrands.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FiltSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CBOrderCost = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\View\userGuestCarsList.xaml"
            this.CBOrderCost.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CarsListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
