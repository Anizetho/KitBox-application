﻿#pragma checksum "c:\users\anizetho\documents\visual studio 2015\Projects\Application KitBox\Application KitBox\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE3F22289348C536039711F52B40A042"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application_KitBox
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button1_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock).SelectionChanged += this.textBlock_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 30 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock1).SelectionChanged += this.textBlock1_SelectionChanged;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

