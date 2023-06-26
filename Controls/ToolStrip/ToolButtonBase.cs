// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-02-2023
// ******************************************************************************************
// <copyright file="ToolButtonBase.cs" company="Terry D. Eppler">
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
//   ToolButtonBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public abstract class ToolButtonBase : System.Windows.Forms.ToolStripButton
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

        /// <summary>
        /// Gets or sets the type of the tool.
        /// </summary>
        /// <value>
        /// The type of the tool.
        /// </value>
        public ToolType ToolType { get; set; }

        /// <summary>
        /// Gets the hover text.
        /// </summary>
        /// <param name="tool">The tool.</param>
        /// <returns></returns>
        public string GetHoverText( ToolType tool )
        {
            if( Enum.IsDefined( typeof( ToolType ), tool ) )
            {
                try
                {
                    return tool switch
                    {
                        ToolType.HomeButton => "Google Search",
                        ToolType.DownloadButton => "View Downloads",
                        ToolType.ExitButton => "Close Browser",
                        ToolType.NextButton => "Next Page",
                        ToolType.PreviousButton => "Previous Page",
                        ToolType.RefreshButton => "Refresh Page",
                        var _ => string.Empty
                    };
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            try
            {
                HoverText = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

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