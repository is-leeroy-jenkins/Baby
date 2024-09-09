// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="Label.cs" company="Terry D. Eppler">
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
//   Label.cs
// </summary>
// ******************************************************************************************

namespace Baby
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
    /// <seealso cref="MetroSet_UI.Controls.MetroSetLabel" />
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class Label : MetroSetLabel
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
        /// Initializes a new instance of
        /// the <see cref="Label"/> class.
        /// </summary>
        public Label( )
        {
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Baby";
            Size = new Size( 165, 23 );
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 8 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Enabled = true;
            Visible = true;
            BorderStyle = BorderStyle.None;
            FlatStyle = FlatStyle.Flat;
            TextAlign = ContentAlignment.MiddleLeft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="System.Windows.Forms.Label"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public Label( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Windows.Forms.Label" /> class.
        /// </summary>
        /// <param name="label">The label.</param>
        public Label( MetroSetLabel label )
            : this( label.Size, label.Location )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Windows.Forms.Label" /> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public Label( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Windows.Forms.Label" /> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The text.</param>
        public Label( Size size, Point location, Control parent,
            string text )
            : this( size, location, parent )
        {
            Text = text;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText( string text )
        {
            if( !string.IsNullOrEmpty( text ) )
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
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnMouseOver( object sender, EventArgs e )
        {
            var _budgetLabel = sender as Label;
            try
            {
                if( _budgetLabel != null
                    && !string.IsNullOrEmpty( HoverText ) )
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        var _hoverText = _budgetLabel?.HoverText;
                        var _ = new ToolTip( _budgetLabel, _hoverText );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            var _text = Tag?.ToString( )?.SplitPascal( );
                            var _ = new ToolTip( _budgetLabel, _text );
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
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( sender is Label _budgetLabel )
                {
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