// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-02-2023
// ******************************************************************************************
// <copyright file="ToolStrip.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ToolStrip.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using Syncfusion.Windows.Forms.Tools;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Baby.ToolStripBase" />
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class ToolStrip : ToolStripBase
    {
        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        public IDictionary<string, ToolStripButton> Buttons { get; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.ToolStrip" /> class.
        /// </summary>
        public ToolStrip( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            BackColor = Color.Transparent;
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 9 );
            Height = 24;
            ShowCaption = true;
            CaptionFont = new Font( "Roboto", 8 );
            CaptionStyle = CaptionStyle.Top;
            CaptionAlignment = CaptionAlignment.Near;
            CaptionTextStyle = CaptionTextStyle.Plain;
            Text = "";
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.Bottom;
            BorderStyle = ToolStripBorderStyle.StaticEdge;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            ImageScalingSize = new Size( 18, 18 );
            Office12Mode = true;
            LauncherStyle = LauncherStyle.Office12;
            ShowLauncher = true;
            GripStyle = ToolStripGripStyle.Hidden;
            VisualStyle = ToolStripExStyle.Office2016DarkGray;
            OfficeColorScheme = ColorScheme.Blue;
            ThemeStyle.BackColor = Color.Transparent;
            ThemeStyle.ArrowColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.BottomToolStripBackColor = Color.Transparent;
            ThemeStyle.CaptionBackColor = Color.FromArgb( 28, 28, 28 );
            ThemeStyle.CaptionForeColor = Color.Black;
            ThemeStyle.ComboBoxStyle.BorderColor = Color.FromArgb( 65, 65, 65 );
            ThemeStyle.DropDownStyle.BorderColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.ComboBoxStyle.HoverBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverItemBackColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverItemForeColor = Color.White;
            Buttons = GetButtons( );
        }

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, ToolStripButton> GetButtons( )
        {
            var _buttons = new SortedList<string, ToolStripButton>( );
            if( Items?.Count > 0 )
            {
                foreach( var _control in Items )
                {
                    if( _control is ToolStripButton _item )
                    {
                        if( !string.IsNullOrEmpty( _item?.Name ) )
                        {
                            _buttons.Add( _item?.Name, _item );
                        }
                    }
                }

                return _buttons?.Count > 0
                    ? _buttons
                    : default( SortedList<string, ToolStripButton> );
            }

            return default( IDictionary<string, ToolStripButton> );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
        public virtual void OnVisible( object sender, EventArgs e )
        {
            if( sender is ToolStrip _toolStrip )
            {
                foreach( var _button in _toolStrip.Buttons.Values )
                {
                }
            }
        }
    }
}