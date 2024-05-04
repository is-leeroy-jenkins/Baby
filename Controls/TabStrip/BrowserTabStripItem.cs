// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-03-2023
// ******************************************************************************************
// <copyright file="BrowserTabStripItem.cs" company="Terry D. Eppler">
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
//   BrowserTabStripItem.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.Panel" />
    [ ToolboxItem( true ) ]
    [ DefaultProperty( "Title" ) ]
    [ DefaultEvent( "Changed" ) ]
    [ SuppressMessage( "ReSharper", "RedundantCheckBeforeAssignment" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BrowserTabStripItem : Layout
    {
        /// <summary>
        /// The is drawn
        /// </summary>
        private bool _drawn;

        /// <summary>
        /// The is selected
        /// </summary>
        private bool _selected;

        /// <summary>
        /// The title
        /// </summary>
        private string _title = string.Empty;

        /// <summary>
        /// The is visible
        /// </summary>
        private bool _visible = true;

        /// <summary>
        /// Gets or sets the strip rect.
        /// </summary>
        /// <value>
        /// The strip rect.
        /// </value>
        public RectangleF StripRectangle { get; set; } = Rectangle.Empty;

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        [ DefaultValue( null ) ]
        public Image Image { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance can close.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance can close; otherwise, <c>false</c>.
        /// </value>
        [ DefaultValue( true ) ]
        public bool CanClose { get; set; } = true;

        /// <summary>
        /// Gets or sets the height and width of the control.
        /// </summary>
        [ Browsable( false ) ]
        [ EditorBrowsable( EditorBrowsableState.Never ) ]
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                base.Size = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the control
        /// and all its child controls are displayed.
        /// </summary>
        [ DefaultValue( true ) ]
        public new bool Visible
        {
            get
            {
                return _visible;
            }
            set
            {
                if( _visible != value )
                {
                    _visible = value;
                    OnChanged( );
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is drawn.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is drawn; otherwise, <c>false</c>.
        /// </value>
        [ DefaultValue( false ) ]
        [ EditorBrowsable( EditorBrowsableState.Never ) ]
        [ Browsable( false ) ]
        public bool Drawn
        {
            get
            {
                return _drawn;
            }
            set
            {
                if( _drawn != value )
                {
                    _drawn = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [ DefaultValue( "Name" ) ]
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if( _title != value )
                {
                    _title = value;
                    OnChanged( );
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is selected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is selected; otherwise, <c>false</c>.
        /// </value>
        [ DefaultValue( false ) ]
        [ Browsable( false ) ]
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if( _selected != value )
                {
                    _selected = value;
                }
            }
        }

        /// <summary>
        /// Gets the caption.
        /// </summary>
        /// <value>
        /// The caption.
        /// </value>
        [ Browsable( false ) ]
        public string Caption
        {
            get
            {
                return Title;
            }
        }

        /// <summary>
        /// Occurs when [changed].
        /// </summary>
        public event EventHandler Changed;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.BrowserTabStripItem" /> class.
        /// </summary>
        public BrowserTabStripItem( )
            : this( string.Empty, null )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.BrowserTabStripItem" /> class.
        /// </summary>
        /// <param name="displayControl">The display control.</param>
        public BrowserTabStripItem( Control displayControl )
            : this( string.Empty, displayControl )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.BrowserTabStripItem" /> class.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="displayControl">The display control.</param>
        public BrowserTabStripItem( string caption, Control displayControl )
        {
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.ContainerControl, true );
            _selected = false;
            Visible = true;
            UpdateText( caption, displayControl );
            if( displayControl != null )
            {
                Controls.Add( displayControl );
            }
        }

        /// <summary>
        /// Should serialize is drawn.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeIsDrawn( )
        {
            return false;
        }

        /// <summary>
        /// Should serialize dock.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeDock( )
        {
            return false;
        }

        /// <summary>
        /// Should the serialize controls.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeControls( )
        {
            if( Controls != null )
            {
                return Controls.Count > 0;
            }

            return false;
        }

        /// <summary>
        /// Should the serialize visible.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeVisible( )
        {
            return true;
        }

        /// <summary>
        /// Assigns the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Assign( BrowserTabStripItem item )
        {
            Visible = item.Visible;
            Text = item.Text;
            CanClose = item.CanClose;
            Tag = item.Tag;
        }

        /// <inheritdoc />
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            return Caption;
        }

        /// <summary>
        /// Updates the text.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="displayControl">
        /// The display control.
        /// </param>
        private void UpdateText( string caption, Control displayControl )
        {
            if( ( caption.Length <= 0 )
               && ( displayControl != null ) )
            {
                Title = displayControl.Text;
            }
            else if( caption != null )
            {
                Title = caption;
            }
        }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        public virtual void OnChanged( )
        {
            Changed?.Invoke( this, EventArgs.Empty );
        }

        /// <inheritdoc />
        /// <summary>
        /// Releases the unmanaged resources used by the
        /// <see cref="T:System.Windows.Forms.Control" />
        /// and its child controls and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing"><see langword="true" />
        /// to release both managed and unmanaged resources;
        /// <see langword="false" /> to release only unmanaged resources.</param>
        protected override void Dispose( bool disposing )
        {
            base.Dispose( disposing );
            if( disposing && ( Image != null ) )
            {
                Image.Dispose( );
            }
        }
    }
}