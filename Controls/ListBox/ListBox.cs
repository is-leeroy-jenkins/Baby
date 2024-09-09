// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="ListBox.cs" company="Terry D. Eppler">
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
//   ListBox.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetListBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class ListBox : MetroSetListBox
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBox"/> class.
        /// </summary>
        public ListBox( )
        {
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Baby";
            Size = new Size( 200, 100 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 1 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 8 );
            ForeColor = Color.LightGray;
            Enabled = true;
            Visible = true;

            // BackColor SeriesConfiguration
            BackColor = Color.FromArgb( 40, 40, 40 );
            ShowBorder = false;
            BorderColor = Color.FromArgb( 55, 55, 55 );

            // Disabled Color Configuration
            DisabledBackColor = Color.FromArgb( 20, 20, 20 );
            DisabledForeColor = Color.FromArgb( 20, 20, 20 );

            // Item Configuration
            ItemHeight = 28;
            MultiSelect = true;
            HoveredItemColor = Color.White;
            HoveredItemBackColor = Color.FromArgb( 17, 53, 84 );
            SelectedItemColor = Color.White;
            SelectedItemBackColor = Color.FromArgb( 0, 120, 212 );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBox"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public ListBox( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBox"/> class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public ListBox( Point location, Control parent = null )
            : this( )
        {
            Location = location;
            if( parent != null )
            {
                Parent = parent;
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBox"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public ListBox( Size size, Control parent = null )
            : this( )
        {
            Size = size;
            if( parent != null )
            {
                Parent = parent;
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBox"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public ListBox( Size size, Point location, Control parent )
            : this( )
        {
            Size = size;
            Location = location;
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBox"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public ListBox( string title )
            : this( )
        {
            Text = title;
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    BorderColor = color;
                }
                catch( Exception _ex )
                {
                    ListBox.Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [visible].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnVisible( object sender, EventArgs e )
        {
            try
            {
                ItemHeight = 30;
            }
            catch( Exception _ex )
            {
                ListBox.Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the items.
        /// </summary>
        /// <param name="items">The items.</param>
        public void AddItems( IEnumerable<object> items )
        {
            if( items?.Count( ) > -1 )
            {
                try
                {
                    foreach( var _item in items )
                    {
                        Items.Add( _item );
                    }
                }
                catch( Exception _ex )
                {
                    ListBox.Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItem( object item )
        {
            if( !string.IsNullOrEmpty( item?.ToString( ) ) )
            {
                try
                {
                    Items.Add( item );
                }
                catch( Exception _ex )
                {
                    ListBox.Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            if( !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    var _ = new ToolTip( this, text );
                }
                catch( Exception _ex )
                {
                    ListBox.Fail( _ex );
                }
            }
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
                    ListBox.Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}