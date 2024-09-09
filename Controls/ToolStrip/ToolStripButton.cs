// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="ToolStripButton.cs" company="Terry D. Eppler">
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
//   ToolStripButton.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using static System.Configuration.ConfigurationManager;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Baby.ToolButtonBase" />
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ToolStripButton : ToolButtonBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripButton"/> class.
        /// </summary>
        public ToolStripButton( )
        {
            // Basic Properties
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackColor = Color.Transparent;
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            AutoToolTip = false;
            Text = string.Empty;
            Size = new Size( 32, 20 );

            // Event Wiring
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            Click += OnClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.ToolStripButton" /> class.
        /// </summary>
        /// <param name="toolType">
        /// Type of the tool.
        /// </param>
        public ToolStripButton( ToolType toolType )
            : this( )
        {
            ToolType = toolType;
            Name = toolType.ToString( );
            HoverText = GetHoverText( toolType );
            Tag = HoverText;
            Image = GetImage( toolType );
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <returns></returns>
        public Image GetImage( ToolType toolType )
        {
            if( Enum.IsDefined( typeof( ToolType ), toolType ) )
            {
                try
                {
                    var _path = AppSettings[ "ToolStrip" ] + $"{toolType}.png";
                    if( File.Exists( _path ) )
                    {
                        using var _stream = File.Open( _path, FileMode.Open );
                        using var _image = Image.FromStream( _stream );
                        return _image;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Image );
                }
            }

            return default( Image );
        }

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as System.Windows.Forms.ToolStripButton;
                if( _button != null
                    && !string.IsNullOrEmpty( HoverText ) )
                {
                    _button.Tag = HoverText;
                    var _tip = new ToolTip( _button );
                    ToolTip = _tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                    {
                        var _tool = new ToolTip( _button );
                        ToolTip = _tool;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                    ToolTip = null;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnClick( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    switch( _button?.ToolType )
                    {
                        case ToolType.FirstButton:
                        {
                            break;
                        }
                        case ToolType.PreviousButton:
                        {
                            break;
                        }
                        case ToolType.NextButton:
                        {
                            break;
                        }
                        case ToolType.LastButton:
                        {
                            break;
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        public void SetImage( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    var _path = AppSettings[ "ToolStrip" ] + $"{ToolType}.png";
                    using var _stream = File.Open( _path, FileMode.Open );
                    if( _stream != null )
                    {
                        var _image = Image.FromStream( _stream );
                        Image = _image;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
    }
}