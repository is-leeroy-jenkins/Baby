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
    using System.Windows.Forms;
    using MetroSet_UI.Enums;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Components.StyleManager" />
    [SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class StyleManager : MetroSet_UI.Components.StyleManager
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StyleManager"/> class.
        /// </summary>
        public StyleManager( )
        {
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StyleManager" /> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public StyleManager( Form form ) 
            : this( )
        {
            MetroForm = form;
        }

        /// <summary>
        /// Get Error Dialog for exceptions.
        /// </summary>
        /// <param name="ex">
        /// The exception.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}