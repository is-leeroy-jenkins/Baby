// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-02-2023
// ******************************************************************************************
// <copyright file="Button.cs" company="Terry D. Eppler">
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
//   Button.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetButton" />
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class Button : MetroSetButton
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
        /// Initializes a new instance of the <see cref="Button"/> class.
        /// </summary>
        public Button( )
            : base( )
        {
            // Basic SeriesConfiguration
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Browser";
            Font = new Font( "Roboto", 8 );
            ForeColor = Color.FromArgb( 0, 120, 212 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 90, 30 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Visible = true;
            Enabled = true;

            // Normal Color Configuration
            NormalColor = Color.Transparent;
            NormalBorderColor = Color.Transparent;
            NormalTextColor = Color.FromArgb( 50, 93, 129 );

            // Hover Color Configuration
            HoverBorderColor = Color.FromArgb( 50, 93, 129 );
            HoverColor = Color.FromArgb( 17, 53, 84 );
            HoverTextColor = Color.White;

            // Disabled Color Configuration
            DisabledBorderColor = Color.Transparent;
            DisabledBackColor = Color.Transparent;
            DisabledForeColor = Color.Transparent;

            // Pressed Color Configuration
            PressColor = Color.FromArgb( 0, 120, 212 );
            PressBorderColor = Color.FromArgb( 0, 120, 212 );
            PressTextColor = Color.White;
        }

        /// <summary>
        /// Sets the color of the fore. Required Attributes: ForeColor
        /// </summary>
        /// <param name="foreColor"></param>
        public void SetForeColor( Color foreColor )
        {
            if( foreColor != Color.Empty )
            {
                try
                {
                    ForeColor = foreColor;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseOver( object sender, EventArgs e )
        {
            var _button = sender as Button;

            try
            {
                if( ( _button != null )
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        var _hoverText = _button?.HoverText;
                        var _ = new ToolTip( _button, _hoverText );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            var _text = Tag?.ToString( )?.SplitPascal( );
                            var _ = new ToolTip( _button, _text );
                        }
                    }
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public virtual void OnClick( object sender, EventArgs e )
        {
        }

        /// <summary>
        /// Res the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void ReSize( int width, int height )
        {
            try
            {
                Size = new Size( width, height );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public virtual void SetText( string text )
        {
            try
            {
                Text = text;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Res the locate.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void ReLocate( int x, int y )
        {
            if( ( x > 0 )
               && ( y > 0 ) )
            {
                try
                {
                    Location = new Point( x, y );
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( sender is Button _button
                   && ( _button != null )
                   && ( ToolTip?.Active == true ) )
                {
                    ToolTip.RemoveAll( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="normal">The normal.</param>
        public void SetBackColor( Color normal )
        {
            if( normal != Color.Empty )
            {
                try
                {
                    BackColor = normal;
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
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}