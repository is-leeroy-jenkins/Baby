// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-02-2023
// ******************************************************************************************
// <copyright file="ToolStripTextBox.cs" company="Terry D. Eppler">
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
//   ToolStripTextBox.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.ToolStripTextBox" />
    public class ToolStripTextBox : System.Windows.Forms.ToolStripTextBox
    {
        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStripTextBox"/> class.
        /// </summary>
        public ToolStripTextBox( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            Size = new Size( 200, 32 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 141, 139, 138 );
            Font = new Font( "Roboto", 9 );
            Visible = true;
            Enabled = true;
            Tag = Name;
            ToolTipText = Tag.ToString( );
            HoverText = string.Empty;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStripTextBox"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public ToolStripTextBox( string text )
            : this( )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStripTextBox"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="hoverText">The hover text.</param>
        public ToolStripTextBox( string text, string hoverText = "" )
            : this( text )
        {
            HoverText = hoverText;
        }

        /// <summary>
        /// Resets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void ResetText( string text )
        {
            try
            {
                Text = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="item">The item.</param>
        public void SetHoverText( ToolStripItem item )
        {
            var _text = item?.Tag?.ToString( );

            if( !string.IsNullOrEmpty( _text ) )
            {
                try
                {
                    var _ = new ToolTip( item, _text );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as ToolStripTextBox;

                if( ( _button != null )
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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