﻿#pragma checksum "..\..\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "34E00B869ABC837FB057D7E1C6B4A659"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WPFFacebookApp;


namespace WPFFacebookApp {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBInfos;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStatus;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProfilePicture;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChose;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btbPost;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btbFriend;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGroup;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtFeed;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtRightPanel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageDir;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border NewFeedBorder;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border RightPannelBorder;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFFacebookApp;component/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Home.xaml"
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
            this.TBInfos = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtStatus = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\Home.xaml"
            this.txtStatus.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtStatus_TextChanged);
            
            #line default
            #line hidden
            
            #line 29 "..\..\Home.xaml"
            this.txtStatus.GotFocus += new System.Windows.RoutedEventHandler(this.txtStatus_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ProfilePicture = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.btnChose = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Home.xaml"
            this.btnChose.Click += new System.Windows.RoutedEventHandler(this.btnChose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btbPost = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Home.xaml"
            this.btbPost.Click += new System.Windows.RoutedEventHandler(this.btnPost_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btbFriend = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Home.xaml"
            this.btbFriend.Click += new System.Windows.RoutedEventHandler(this.btbFriend_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnGroup = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Home.xaml"
            this.btnGroup.Click += new System.Windows.RoutedEventHandler(this.btnGroup_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtFeed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txtRightPanel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txtImageDir = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.NewFeedBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 12:
            this.RightPannelBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Home.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

