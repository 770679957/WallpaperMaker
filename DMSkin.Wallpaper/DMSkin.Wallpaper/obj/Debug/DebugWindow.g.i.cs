﻿#pragma checksum "..\..\DebugWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0AD73315F0BADEE40DFE1F7CB4E754A899A6207A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DMSkin.Wallpaper;
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


namespace DMSkin.Wallpaper {
    
    
    /// <summary>
    /// DebugWindow
    /// </summary>
    public partial class DebugWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\DebugWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbUrl;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\DebugWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOpen;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DebugWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton PlayerMINI;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DebugWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton PlayerXL;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\DebugWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox PlayerRun;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\DebugWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderVolume;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\DebugWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPlay;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\DebugWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/DMSkin.Wallpaper;component/debugwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DebugWindow.xaml"
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
            
            #line 9 "..\..\DebugWindow.xaml"
            ((DMSkin.Wallpaper.DebugWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TbUrl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnOpen = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\DebugWindow.xaml"
            this.BtnOpen.Click += new System.Windows.RoutedEventHandler(this.BtnOpen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PlayerMINI = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.PlayerXL = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.PlayerRun = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.SliderVolume = ((System.Windows.Controls.Slider)(target));
            
            #line 54 "..\..\DebugWindow.xaml"
            this.SliderVolume.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderVolume_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnPlay = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\DebugWindow.xaml"
            this.BtnPlay.Click += new System.Windows.RoutedEventHandler(this.BtnPlay_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\DebugWindow.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
