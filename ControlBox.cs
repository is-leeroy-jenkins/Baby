// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 1-4-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-4-2024
// ******************************************************************************************
// <copyright file="ControlBox.cs" company="Terry D. Eppler">
//    Baby is tiny web browser used in a Federal Budget, Finance, and Accounting application
//    for the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//    Contact at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ControlBox.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;
    
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetControlBox" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    public class ControlBox : MetroSetControlBox
    {
        /// <summary>
        /// The maximum size
        /// </summary>
        private protected Size _maximumSize;

        /// <summary>
        /// The minimum size
        /// </summary>
        private protected Size _minimumSize;

        /// <summary>
        /// The normal size
        /// </summary>
        private protected Size _normalSize;

        /// <summary>
        /// The tool tip
        /// </summary>
        private ToolTip _toolTip;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ControlBox"/> class.
        /// </summary>
        public ControlBox( ) 
            : base( )
        {
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "DarkControls";
            Font = new Font( "Roboto", 9 );
            Size = new Size( 100, 25 );
            Margin = new Padding( 1 );
            Padding = new Padding( 1 );
            ForeColor = Color.FromArgb( 106, 189, 252 ); 
            DisabledForeColor = Color.FromArgb( 20, 20, 20 );
            CloseHoverBackColor = Color.Maroon;
            MinimizeHoverBackColor = Color.FromArgb( 50, 93, 129 );
            MaximizeHoverBackColor = Color.FromArgb( 50, 93, 129 );
            CloseHoverForeColor = Color.White;
            MinimizeHoverForeColor = Color.White;
            MaximizeHoverForeColor = Color.White;
            CloseNormalForeColor = Color.FromArgb( 45, 45, 45 );
            MinimizeNormalForeColor = Color.FromArgb( 45, 45, 45 );
            MaximizeNormalForeColor = Color.FromArgb( 45, 45, 45 );
            MaximizeBox = true;
            MinimizeBox = true;
        }

        /// <summary>
        /// Called when [maximize button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMaximizeButtonClick( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [maxmize button hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMaxmizeButtonHover( object sender, EventArgs e )
        {
            try
            {
                var _tip = new ToolTip( this, "Maximize" );
                _toolTip = _tip;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [close button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [close button hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseButtonHover( object sender, EventArgs e )
        {
            try
            {
                var _tip = new ToolTip( this, "Close" );
                _toolTip = _tip;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}