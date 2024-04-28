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

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    public class Palette : ColorCache
    {
        /// <summary>
        /// Gets the dark green.
        /// </summary>
        /// <value>
        /// The dark green.
        /// </value>
        public Color DarkGreen
        {
            get
            {
                return _darkGreen;
            }
            private protected set
            {
                _darkGreen = value;
            }
        }

        /// <summary>
        /// Gets the chart colors.
        /// </summary>
        /// <value>
        /// The chart colors.
        /// </value>
        public Color[ ] ChartColors
        {
            get
            {
                return _palette;
            }

            private protected set
            {
                _palette = value;
            }
        }

        /// <summary>
        /// Gets the light green.
        /// </summary>
        /// <value>
        /// The light green.
        /// </value>
        public Color LightGreen
        {
            get
            {
                return _lightGreen;
            }
            private protected set
            {
                _lightGreen = value;
            }
        }

        /// <summary>
        /// Gets the blue.
        /// </summary>
        /// <value>
        /// The blue.
        /// </value>
        public Color Blue
        {
            get
            {
                return _blue;
            }
            private protected set
            {
                _blue = value;
            }
        }

        /// <summary>
        /// Gets the red.
        /// </summary>
        /// <value>
        /// The red.
        /// </value>
        public Color Red
        {
            get
            {
                return _red;
            }
            private protected set
            {
                _red = value;
            }
        }

        /// <summary>
        /// Gets or sets the gray.
        /// </summary>
        /// <value>
        /// The gray.
        /// </value>
        public Color Gray
        {
            get
            {
                return _gray;
            }
            private protected set
            {
                _gray = value;
            }
        }

        /// <summary>
        /// Gets or sets the white.
        /// </summary>
        /// <value>
        /// The white.
        /// </value>
        public Color White
        {
            get
            {
                return _white;
            }
            private protected set
            {
                _white = value;
            }
        }

        /// <summary>
        /// Gets or sets the black.
        /// </summary>
        /// <value>
        /// The black.
        /// </value>
        public Color Black
        {
            get
            {
                return _black;
            }
            private protected set
            {
                _black = value;
            }
        }

        /// <summary>
        /// Gets or sets the transparent.
        /// </summary>
        /// <value>
        /// The transparent.
        /// </value>
        public Color Transparent
        {
            get
            {
                return _transparent;
            }
            private protected set
            {
                _transparent = value;
            }
        }

        /// <summary>
        /// Gets or sets the hover gray.
        /// </summary>
        /// <value>
        /// The hover gray.
        /// </value>
        public Color HoverGray
        {
            get
            {
                return _hoverGray;
            }
            private protected set
            {
                _hoverGray = value;
            }
        }

        /// <summary>
        /// Gets or sets the hover blue.
        /// </summary>
        /// <value>
        /// The hover blue.
        /// </value>
        public Color HoverBlue
        {
            get
            {
                return _hoverBlue;
            }
            private protected set
            {
                _hoverBlue = value;
            }
        }

        /// <summary>
        /// Gets or sets the steel blue.
        /// </summary>
        /// <value>
        /// The steel blue.
        /// </value>
        public Color SteelBlue
        {
            get
            {
                return _steelBlue;
            }
            private protected set
            {
                _steelBlue = value;
            }
        }

        /// <summary>
        /// Gets or sets the maroon.
        /// </summary>
        /// <value>
        /// The maroon.
        /// </value>
        public Color Maroon
        {
            get
            {
                return _maroon;
            }
            private protected set
            {
                _maroon = value;
            }
        }

        /// <summary>
        /// Gets or sets the light blue.
        /// </summary>
        /// <value>
        /// The light blue.
        /// </value>
        public Color LightBlue
        {
            get
            {
                return _lightBlue;
            }
            private protected set
            {
                _lightBlue = value;
            }
        }

        /// <summary>
        /// Gets or sets the dark interior.
        /// </summary>
        /// <value>
        /// The dark interior.
        /// </value>
        public Color DarkInterior
        {
            get
            {
                return _darkInterior;
            }
            private protected set
            {
                _darkInterior = value;
            }
        }

        /// <summary>
        /// Gets or sets the dark border.
        /// </summary>
        /// <value>
        /// The dark border.
        /// </value>
        public Color DarkBorder
        {
            get
            {
                return _darkBorder;
            }
            private protected set
            {
                _darkBorder = value;
            }
        }

        /// <summary>
        /// Gets or sets the dark background.
        /// </summary>
        /// <value>
        /// The dark background.
        /// </value>
        public Color DarkBackground
        {
            get
            {
                return _darkBackground;
            }
            private protected set
            {
                _darkBackground = value;
            }
        }

        /// <summary>
        /// Gets or sets the hover dark blue.
        /// </summary>
        /// <value>
        /// The hover dark blue.
        /// </value>
        public Color HoverDarkBlue
        {
            get
            {
                return _hoverDarkBlue;
            }
            private protected set
            {
                _hoverDarkBlue = value;
            }
        }

        /// <summary>
        /// Gets or sets the dodger blue.
        /// </summary>
        /// <value>
        /// The dodger blue.
        /// </value>
        public Color DodgerBlue
        {
            get
            {
                return _dodgerBlue;
            }
            private protected set
            {
                _dodgerBlue = value;
            }
        }

        /// <summary>
        /// Gets or sets the metro blue.
        /// </summary>
        /// <value>
        /// The metro blue.
        /// </value>
        public Color MetroBlue
        {
            get
            {
                return _metroBlue;
            }
            private protected set
            {
                _metroBlue = value;
            }
        }

        /// <summary>
        /// Gets or sets the blue highlight.
        /// </summary>
        /// <value>
        /// The blue highlight.
        /// </value>
        public Color BlueHighlight
        {
            get
            {
                return _blueForeColor;
            }
            private protected set
            {
                _blueForeColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the notification.
        /// </summary>
        /// <value>
        /// The color of the notification.
        /// </value>
        public Color NotificationColor
        {
            get
            {
                return _notificationBackColor;
            }
            private protected set
            {
                _notificationBackColor = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Palette"/> class.
        /// </summary>
        public Palette( ) 
            : base( )
        {
            _blue = Color.FromArgb( 0, 120, 212 );
            _blueForeColor = Color.FromArgb( 106, 189, 252 );
            _hoverBlue = Color.FromArgb( 50, 93, 129 );
            _metroBlue = Color.FromArgb( 65, 177, 225 );
            _hoverDarkBlue = Color.FromArgb( 24, 47, 66 );
            _transparent = Color.Transparent;
            _hoverGray = Color.FromArgb( 70, 70, 70 );
            _darkInterior = Color.FromArgb( 70, 70, 70 );
            _black = Color.Black;
            _white = Color.White;
            _red = Color.FromArgb( 192, 0, 0 );
            _darkBorder = Color.FromArgb( 65, 65, 65 );
            _darkBackground = Color.FromArgb( 20, 20, 20 );
            _gray = Color.DarkGray;
            _steelBlue = Color.SteelBlue;
            _dodgerBlue = Color.DodgerBlue;
            _maroon = Color.Maroon;
            _lightBlue = Color.LightSteelBlue;
            _notificationBackColor = Color.FromArgb( 1, 35, 54 );
            _darkGreen = Color.ForestGreen;
            _lightGreen = Color.LimeGreen;
        }
    }
}