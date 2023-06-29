// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="MenuBase.cs" company="Terry D. Eppler">
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
//   MenuBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using MetroSet_UI.Child;
    using MetroSet_UI.Controls;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetContextMenuStrip" />
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class MenuBase : MetroSetContextMenuStrip
    {
        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem SearchOption { get; set; }
        
        /// <summary>
        /// Gets or sets the close option.
        /// </summary>
        /// <value>
        /// The close option.
        /// </value>
        public MetroSetToolStripMenuItem CloseOption { get; set; }

        /// <summary>
        /// Gets or sets the exit option.
        /// </summary>
        /// <value>
        /// The exit option.
        /// </value>
        public MetroSetToolStripMenuItem ExitOption { get; set; }

        /// <summary>
        /// Called when [mouse enter].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        protected void OnMouseEnter( object sender, EventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem _item )
            {
                try
                {
                    _item.BackColor = Color.FromArgb( 50, 93, 129 );
                    _item.ForeColor = Color.White;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
        protected void OnMouseLeave( object sender, EventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem _item )
            {
                try
                {
                    _item.BackColor = Color.FromArgb( 30, 30, 30 );
                    _item.ForeColor = Color.White;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}