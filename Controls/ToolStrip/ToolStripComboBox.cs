// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-02-2023
// ******************************************************************************************
// <copyright file="ToolStripComboBox.cs" company="Terry D. Eppler">
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
//   ToolStripComboBox.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetBrowser.ToolStripDropDown" />
    public class ToolStripComboBox : ToolStripDropDown
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStripComboBox"/> class.
        /// </summary>
        public ToolStripComboBox( )
        {
        }

        /// <summary> Called when [mouse over]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _comboBox = sender as ToolStripComboBox;

                if( !string.IsNullOrEmpty( _comboBox?.HoverText ) )
                {
                    var _text = _comboBox?.HoverText;
                    var _ = new ToolTip( _comboBox, _text );
                }
                else
                {
                    if( !string.IsNullOrEmpty( _comboBox?.Tag?.ToString( ) ) )
                    {
                        var _text = _comboBox?.Tag?.ToString( )?.SplitPascal( );
                        var _ = new ToolTip( _comboBox, _text );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnItemSelected( object sender, EventArgs e )
        {
            if( ( sender != null )
               && ( e != null ) )
            {
                try
                {
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Gets the selected item. </summary>
        /// <returns> </returns>
        public object GetSelectedItem( )
        {
            if( Selected && ( SelectedIndex > -1 ) )
            {
                try
                {
                    return ComboBox.Items[ SelectedIndex ];
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return null;
                }
            }

            return null;
        }

        /// <summary> Gets the selected item. </summary>
        /// <returns> </returns>
        public void AddItem( object item )
        {
            if( item != null )
            {
                try
                {
                    ComboBox.Items.Add( item );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Called when [mouse leave]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
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
    }
}