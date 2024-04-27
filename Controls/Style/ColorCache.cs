// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        04-27-2024
// ******************************************************************************************
// <copyright file="WebBrowser.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   WebBrowser.cs
// </summary>
// ******************************************************************************************


namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class ColorCache
    {
        /// <summary>
        /// The dark green
        /// </summary>
        private protected Color _darkGreen;

        /// <summary>
        /// The light green
        /// </summary>
        private protected Color _lightGreen;

        /// <summary>
        /// The blue
        /// </summary>
        private protected Color _blue;

        /// <summary>
        /// The red
        /// </summary>
        private protected Color _red;

        /// <summary>
        /// The gray
        /// </summary>
        private protected Color _gray;

        /// <summary>
        /// The white
        /// </summary>
        private protected Color _white;

        /// <summary>
        /// The black
        /// </summary>
        private protected Color _black;

        /// <summary>
        /// The transparent
        /// </summary>
        private protected Color _transparent;

        /// <summary>
        /// The hover gray
        /// </summary>
        private protected Color _hoverGray;

        /// <summary>
        /// The hover blue
        /// </summary>
        private protected Color _hoverBlue;

        /// <summary>
        /// The steel blue
        /// </summary>
        private protected Color _steelBlue;

        /// <summary>
        /// The maroon
        /// </summary>
        private protected Color _maroon;

        /// <summary>
        /// The light blue
        /// </summary>
        private protected Color _lightBlue;

        /// <summary>
        /// The dark interior
        /// </summary>
        private protected Color _darkInterior;

        /// <summary>
        /// The dark border
        /// </summary>
        private protected Color _darkBorder;

        /// <summary>
        /// The dark background
        /// </summary>
        private protected Color _darkBackground;

        /// <summary>
        /// The hover dark blue
        /// </summary>
        private protected Color _hoverDarkBlue;

        /// <summary>
        /// The dodger blue
        /// </summary>
        private protected Color _dodgerBlue;

        /// <summary>
        /// The metro blue
        /// </summary>
        private protected Color _metroBlue;

        /// <summary>
        /// The blue highlight
        /// </summary>
        private protected Color _blueForeColor;

        /// <summary>
        /// The notification color
        /// </summary>
        private protected Color _notificationBackColor;

        /// <summary>
        /// The palette
        /// </summary>
        private protected Color[ ] _palette;

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}