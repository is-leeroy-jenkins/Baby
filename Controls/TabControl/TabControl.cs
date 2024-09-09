// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="TabControl.cs" company="Terry D. Eppler">
//     Baby is a light-weight, full-featured, web-browser built with .NET 6 and is written
//     in C#.  The baby browser is designed for budget execution and data analysis.
//     A tool for EPA analysts and a component that can be used for general browsing.
// 
//     Copyright ©  2020 Terry D. Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   TabControl.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using Syncfusion.Windows.Forms.Tools;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Tools.TabControlAdv" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class TabControl : TabControlAdv
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.TabControl" /> class.
        /// </summary>
        /// <example>
        /// The following example creates a TabControlAdv with one TabPageAdv object.
        /// The constructor instantiates tabControl1.
        /// Use the Syncfusion.Windows.Forms.Tools namespace for this example.
        /// <code lang="C#">
        /// public Form1()
        /// {
        /// this.tabPage1 = new TabPageAdv();
        /// // Invokes the TabControlAdv() constructor to create the tabControl1 object.
        /// this.tabControl1 = new TabControlAdv();
        /// this.tabControl1.Controls.Add(tabPage1);
        /// this.Controls.Add(tabControl1);
        /// }
        /// </code><code lang="VB">
        /// Public Sub New()
        /// Me.tabPage1 = New TabPageAdv()
        /// ' Invokes the TabControlAdv() constructor to create the tabControl1 object.
        /// Me.tabControl1 = New TabControlAdv()
        /// Me.tabControl1.Controls.Add(tabPage1)
        /// Me.Controls.Add(tabControl1)
        /// End Sub 'New
        /// </code></example>
        public TabControl( )
        {
            TabStyle = typeof( TabRendererMetro );
            BackColor = Color.FromArgb( 20, 20, 20 );
            Size = new Size( 350, 500 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            BorderStyle = BorderStyle.None;
            CloseButtonBackColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonForeColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonHoverForeColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonPressedForeColor = Color.FromArgb( 20, 20, 20 );
            SeparatorColor = Color.FromArgb( 20, 20, 20 );
            ShowSeparator = false;
            ItemSize = new Size( 100, 30 );
            TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            CanOverrideStyle = true;
            CanApplyTheme = true;
            ActiveTabColor = Color.FromArgb( 20, 20, 20 );
            ActiveTabFont = new Font( "Roboto", 8 );
            ActiveTabForeColor = Color.DarkGray;
            InActiveTabForeColor = Color.FromArgb( 20, 20, 20 );
            InactiveCloseButtonForeColor = Color.FromArgb( 20, 20, 20 );
            InactiveTabColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderFillColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveFont = new Font( "Roboto", 8 );
            ThemeStyle.TabStyle.ActiveForeColor = Color.DarkGray;
            ThemeStyle.TabStyle.SeparatorColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveBackColor = Color.FromArgb( 20, 20, 20 );
        }
    }
}