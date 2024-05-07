// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-28-2023
// ******************************************************************************************
// <copyright file="BrowserTabStrip.cs" company="Terry D. Eppler">
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
//   BrowserTabStrip.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BaseStyledPanel" />
    /// <seealso cref="T:System.ComponentModel.ISupportInitialize" />
    /// <seealso cref="T:System.IDisposable" />
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ DefaultEvent( "TabStripItemSelectionChanged" ) ]
    [ DefaultProperty( "Items" ) ]
    [ ToolboxItem( true ) ]
    [ SuppressMessage( "ReSharper", "LocalVariableHidesMember" ) ]
    [ SuppressMessage( "ReSharper", "IntroduceOptionalParameters.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToNullCoalescingExpression" ) ]
    [ SuppressMessage( "ReSharper", "RedundantAssignment" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MergeIntoPattern" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    public class BrowserTabStrip : BaseStyledPanel, ISupportInitialize 

    {
        /// <summary>
        /// The text left margin
        /// </summary>
        private const int _TEXT_LEFT_MARGIN = 15;

        /// <summary>
        /// The text right margin
        /// </summary>
        private const int _TEXT_RIGHT_MARGIN = 10;

        /// <summary>
        /// The definition header height
        /// </summary>
        private const int _DEF_HEADER_HEIGHT = 28;

        /// <summary>
        /// The definition button height
        /// </summary>
        private const int _DEF_BUTTON_HEIGHT = 28;

        /// <summary>
        /// The definition glyph width
        /// </summary>
        private const int _DEF_GLYPH_WIDTH = 40;

        /// <summary>
        /// The close button
        /// </summary>
        private BrowserTabStripCloseButton _closeButton;

        /// <summary>
        /// The definition start position
        /// </summary>
        private int _startPosition = 10;

        /// <summary>
        /// The format
        /// </summary>
        private StringFormat _formatString;

        /// <summary>
        /// The is initializing
        /// </summary>
        private bool _initializing;

        /// <summary>
        /// The menu
        /// </summary>
        private readonly ContextMenuStrip _menu;

        /// <summary>
        /// The is open
        /// </summary>
        private bool _open;

        /// <summary>
        /// The selected item
        /// </summary>
        private BrowserTabStripItem _selectedItem;

        /// <summary>
        /// The strip button rect
        /// </summary>
        private Rectangle _rectangle = Rectangle.Empty;

        /// <summary>
        /// The add button width
        /// </summary>
        public int AddButtonWidth = 40;

        /// <summary>
        /// The maximum tab size
        /// </summary>
        public int MaxTabSize = 200;

        /// <summary>
        /// The font
        /// </summary>
        private static Font _font = new Font( "Roboto", 8, FontStyle.Regular );

        /// <summary>
        /// The dark background
        /// </summary>
        private Color _dark = Color.FromArgb( 20, 20, 20 );

        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>
        /// The selected item.
        /// </value>
        [ RefreshProperties( RefreshProperties.All ) ]
        [ DefaultValue( null ) ]
        public BrowserTabStripItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if( _selectedItem == value )
                {
                    return;
                }

                if( ( value == null )
                   && ( Items.Count > 0 ) )
                {
                    var _fATabStripItem = Items[ 0 ];
                    if( _fATabStripItem.Visible )
                    {
                        _selectedItem = _fATabStripItem;
                        _selectedItem.Selected = true;
                        _selectedItem.Dock = DockStyle.Fill;
                    }
                }
                else
                {
                    _selectedItem = value;
                }

                foreach( BrowserTabStripItem _item in Items )
                {
                    if( _item == _selectedItem )
                    {
                        SelectItem( _item );
                        _item.Dock = DockStyle.Fill;
                        _item.Show( );
                    }
                    else
                    {
                        UnSelectItem( _item );
                        _item.Hide( );
                    }
                }

                SelectItem( _selectedItem );
                Invalidate( );
                if( !_selectedItem.Drawn )
                {
                    Items.MoveTo( 0, _selectedItem );
                    Invalidate( );
                }

                OnTabStripItemChanged( new TabItemChangedEventArgs( _selectedItem,
                    ChangeType.SelectionChanged ) );
            }
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [ DesignerSerializationVisibility( DesignerSerializationVisibility.Content ) ]
        public BrowserTabStripItemCollection Items { get; }

        /// <summary>
        /// Gets or sets the height and width of the control.
        /// </summary>
        [ DefaultValue( typeof( Size ), "350,200" ) ]
        public new Size Size
        {
            get { return base.Size; }
            set
            {
                if( !( base.Size == value ) )
                {
                    base.Size = value;
                    UpdateLayout( );
                }
            }
        }

        /// <summary>
        /// Gets the collection of controls contained within the control.
        /// </summary>
        [ DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden ) ]
        public new ControlCollection Controls
        {
            get { return base.Controls; }
        }

        /// <summary>
        /// Occurs when [tab strip item closing].
        /// </summary>
        public event TabItemClosing TabStripItemClosing;

        /// <summary>
        /// Occurs when [tab strip item selection changed].
        /// </summary>
        public event TabItemChange TabStripItemSelectionChanged;

        /// <summary>
        /// Occurs when [menu items loading].
        /// </summary>
        public event HandledEventHandler MenuItemsLoading;

        /// <summary>
        /// Occurs when [menu items loaded].
        /// </summary>
        public event EventHandler MenuItemsLoaded;

        /// <summary>
        /// Occurs when [tab strip item closed].
        /// </summary>
        public event EventHandler TabStripItemClosed;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BrowserTabStrip" /> class.
        /// </summary>
        public BrowserTabStrip( )
        {
            BeginInit( );
            SetStyle( ControlStyles.ContainerControl, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.Selectable, true );
            Items = new BrowserTabStripItemCollection( );
            Items.CollectionChanged += OnCollectionChanged;
            BackColor = _dark;
            base.Size = new Size( 350, 200 );
            _menu = new ContextMenuStrip( );
            _menu.Renderer = base.ToolStripRenderer;
            _menu.ItemClicked += OnMenuItemClicked;
            _menu.VisibleChanged += OnMenuVisibleChanged;
            _closeButton = new BrowserTabStripCloseButton( base.ToolStripRenderer );
            Font = _font;
            _formatString = new StringFormat( );
            EndInit( );
            UpdateLayout( );
        }

        /// <summary>
        /// Hits the test.
        /// </summary>
        /// <param name="point">The pt.</param>
        /// <returns></returns>
        public HitResult HitTest( Point point )
        {
            if( _closeButton.IsVisible
               && _closeButton.ButtonRectangle.Contains( point ) )
            {
                return HitResult.CloseButton;
            }

            return GetTabItemByPoint( point ) != null
                ? HitResult.TabItem
                : HitResult.None;
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        public void AddTab( BrowserTabStripItem tabItem )
        {
            AddTab( tabItem, false );
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        /// <param name="autoSelect">if set to <c>true</c> [automatic select].</param>
        public void AddTab( BrowserTabStripItem tabItem, bool autoSelect )
        {
            tabItem.Dock = DockStyle.Fill;
            Items.Add( tabItem );
            if( ( autoSelect && tabItem.Visible )
               || ( tabItem.Visible && ( Items.DrawnCount < 1 ) ) )
            {
                SelectedItem = tabItem;
                SelectItem( tabItem );
            }
        }

        /// <summary>
        /// Removes the tab.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        public void RemoveTab( BrowserTabStripItem tabItem )
        {
            var _num = Items.IndexOf( tabItem );
            if( _num >= 0 )
            {
                UnSelectItem( tabItem );
                Items.Remove( tabItem );
            }

            if( Items.Count > 0 )
            {
                if( Items[ _num - 1 ] != null )
                {
                    SelectedItem = Items[ _num - 1 ];
                }
                else
                {
                    SelectedItem = Items.FirstVisible;
                }
            }
        }

        /// <summary>
        /// Gets the tab item by point.
        /// </summary>
        /// <param name="pt">The pt.</param>
        /// <returns></returns>
        public BrowserTabStripItem GetTabItemByPoint( Point pt )
        {
            BrowserTabStripItem _result = null;
            var _flag = false;
            for( var _i = 0; _i < Items.Count; _i++ )
            {
                var _fATabStripItem = Items[ _i ];
                if( _fATabStripItem.StripRectangle.Contains( pt )
                   && _fATabStripItem.Visible
                   && _fATabStripItem.Drawn )
                {
                    _result = _fATabStripItem;
                    _flag = true;
                }

                if( _flag )
                {
                    break;
                }
            }

            return _result;
        }

        /// <summary>
        /// Should serialize font.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeFont( )
        {
            return ( Font != null ) 
                && !Font.Equals( _font );
        }

        /// <summary>
        /// Should serialize selected item.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeSelectedItem( )
        {
            return true;
        }

        /// <summary>
        /// Should serialize items.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeItems( )
        {
            return Items.Count > 0;
        }

        /// <summary>
        /// Measures the width of the tab.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="currentItem">The current item.</param>
        /// <param name="currentFont">The current font.</param>
        /// <returns></returns>
        private SizeF MeasureTabWidth( Graphics g, BrowserTabStripItem currentItem,
            Font currentFont )
        {
            var _result = g.MeasureString( currentItem.Title, currentFont, new SizeF( 200f, 28f ),
                _formatString );

            _result.Width += 25f;
            return _result;
        }

        /// <summary>
        /// Resets the
        /// <see cref="P:System.Windows.Forms.Control.Font" />
        /// property to its default value.
        /// </summary>
        public new void ResetFont( )
        {
            Font = _font;
        }

        /// <inheritdoc />
        /// <summary>
        /// Signals the object that initialization is starting.
        /// </summary>
        public void BeginInit( )
        {
            _initializing = true;
        }

        /// <inheritdoc />
        /// <summary>
        /// Signals the object that initialization is complete.
        /// </summary>
        public void EndInit( )
        {
            _initializing = false;
        }

        /// <summary>
        /// Updates the layout.
        /// </summary>
        private void UpdateLayout( )
        {
            if( _formatString != null )
            {
                _formatString.Trimming = StringTrimming.EllipsisCharacter;
                _formatString.FormatFlags |= StringFormatFlags.NoWrap;
                _formatString.FormatFlags &= StringFormatFlags.DirectionRightToLeft;
            }

            _rectangle = new Rectangle( 0, 0, ClientSize.Width - 40 - 2, 10 );
            DockPadding.Top = 29;
            DockPadding.Bottom = 1;
            DockPadding.Right = 1;
            DockPadding.Left = 1;
        }

        /// <summary>
        /// Uns the draw all.
        /// </summary>
        public void UnDrawAll( )
        {
            for( var _i = 0; _i < Items.Count; _i++ )
            {
                Items[ _i ].Drawn = false;
            }
        }

        /// <summary>
        /// Selects the item.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        public void SelectItem( BrowserTabStripItem tabItem )
        {
            tabItem.Dock = DockStyle.Fill;
            tabItem.Visible = true;
            tabItem.Selected = true;
        }

        /// <summary>
        /// Uns the select item.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        public void UnSelectItem( BrowserTabStripItem tabItem )
        {
            tabItem.Selected = false;
        }

        /// <summary>
        /// Sets the default selected.
        /// </summary>
        private void SetDefaultSelection( )
        {
            if( ( _selectedItem == null )
               && ( Items.Count > 0 ) )
            {
                _selectedItem = Items[ 0 ];
            }

            for( var _i = 0; _i < Items.Count; _i++ )
            {
                var _fATabStripItem = Items[ _i ];
                _fATabStripItem.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:TabStripItemClosing" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabClosingEventArgs"/> instance containing the event data.</param>
        protected virtual void OnTabStripItemClosing( TabClosingEventArgs e )
        {
            TabStripItemClosing?.Invoke( e );
        }

        /// <summary>
        /// Raises the <see cref="E:TabStripItemClosed" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnTabStripItemClosed( EventArgs e )
        {
            _selectedItem = null;
            TabStripItemClosed?.Invoke( this, e );
        }

        /// <summary>
        /// Raises the <see cref="E:MenuItemsLoading" /> event.
        /// </summary>
        /// <param name="e">The <see cref="HandledEventArgs"/> instance containing the event data.</param>
        protected virtual void OnMenuItemsLoading( HandledEventArgs e )
        {
            MenuItemsLoading?.Invoke( this, e );
        }

        /// <summary>
        /// Raises the <see cref="E:MenuItemsLoaded" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnMenuItemsLoaded( EventArgs e )
        {
            MenuItemsLoaded?.Invoke( this, e );
        }

        /// <summary>
        /// Raises the <see cref="E:TabStripItemChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabItemChangedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnTabStripItemChanged( TabItemChangedEventArgs e )
        {
            TabStripItemSelectionChanged?.Invoke( e );
        }

        /// <summary>
        /// Raises the <see cref="E:MenuItemsLoad" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        protected virtual void OnMenuItemsLoad( EventArgs e )
        {
            _menu.RightToLeft = RightToLeft;
            _menu.Items.Clear( );
            for( var _i = 0; _i < Items.Count; _i++ )
            {
                var _fATabStripItem = Items[ _i ];
                if( _fATabStripItem.Visible )
                {
                    var _toolStripMenuItem = new ToolStripMenuItem( _fATabStripItem.Title );
                    _toolStripMenuItem.Tag = _fATabStripItem;
                    _toolStripMenuItem.Image = _fATabStripItem.Image;
                    _menu.Items.Add( _toolStripMenuItem );
                }
            }

            OnMenuItemsLoaded( EventArgs.Empty );
        }

        /// <inheritdoc />
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.RightToLeftChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnRightToLeftChanged( EventArgs e )
        {
            base.OnRightToLeftChanged( e );
            UpdateLayout( );
            Invalidate( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Raises the
        /// <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A
        /// <see cref="T:System.Windows.Forms.PaintEventArgs" />
        /// that contains the event data.
        /// </param>
        protected override void OnPaint( PaintEventArgs e )
        {
            SetDefaultSelection( );
            var _brush = new SolidBrush( _dark );
            var _pen = new Pen( _brush );
            var _client = ClientRectangle;
            _client.Width--;
            _client.Height--;
            _startPosition = 10;
            if( e.Graphics != null )
            {
                e.Graphics.DrawRectangle( _pen, _client );
                e.Graphics.FillRectangle( _brush, _client );
                e.Graphics.FillRectangle( _brush,
                    new Rectangle( _client.X, _client.Y, _client.Width, 28 ) );

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                for( var _i = 0; _i < Items.Count; _i++ )
                {
                    var _fATabStripItem = Items[ _i ];
                    if( _fATabStripItem.Visible || DesignMode )
                    {
                        OnCalculateTabPage( e.Graphics, _fATabStripItem );
                        _fATabStripItem.Drawn = false;
                        OnDrawTabButton( e.Graphics, _fATabStripItem );
                    }
                }

                if( _selectedItem != null )
                {
                    OnDrawTabButton( e.Graphics, _selectedItem );
                }

                if( ( Items.DrawnCount == 0 )
                   || ( Items.VisibleCount == 0 ) )
                {
                    e.Graphics.DrawLine( _pen, new Point( 0, 28 ),
                        new Point( ClientRectangle.Width, 28 ) );
                }
                else if( ( SelectedItem != null )
                        && SelectedItem.Drawn )
                {
                    var _num = (int)( SelectedItem.StripRectangle.Height / 4f );
                    var _point = new Point( (int)SelectedItem.StripRectangle.Left - _num, 28 );
                    e.Graphics.DrawLine( _pen, new Point( 0, 28 ), _point );
                    _point.X += (int)SelectedItem.StripRectangle.Width + _num * 2;
                    e.Graphics.DrawLine( _pen, _point, new Point( ClientRectangle.Width, 28 ) );
                }

                if( ( SelectedItem != null )
                   && SelectedItem.CanClose )
                {
                    _closeButton.IsVisible = true;
                    _closeButton.CalculateBounds( _selectedItem );
                    _closeButton.Draw( e.Graphics );
                }
                else
                {
                    _closeButton.IsVisible = false;
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A
        /// <see cref="T:System.Windows.Forms.MouseEventArgs" />
        /// that contains the event data.</param>
        protected override void OnMouseDown( MouseEventArgs e )
        {
            base.OnMouseDown( e );
            var _hitTestResult = HitTest( e.Location );
            if( _hitTestResult == HitResult.TabItem )
            {
                var _tabItemByPoint = GetTabItemByPoint( e.Location );
                if( _tabItemByPoint != null )
                {
                    SelectedItem = _tabItemByPoint;
                    Invalidate( );
                }
            }
            else
            {
                if( ( e.Button != MouseButtons.Left )
                   || ( _hitTestResult != 0 ) )
                {
                    return;
                }

                if( SelectedItem != null )
                {
                    var _tabStripItemClosingEventArgs =
                        new TabClosingEventArgs( SelectedItem );

                    OnTabStripItemClosing( _tabStripItemClosingEventArgs );
                    if( !_tabStripItemClosingEventArgs.Cancel
                       && SelectedItem.CanClose )
                    {
                        RemoveTab( SelectedItem );
                        OnTabStripItemClosed( EventArgs.Empty );
                    }
                }

                Invalidate( );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A
        /// <see cref="T:System.Windows.Forms.MouseEventArgs" />
        /// that contains the event data.</param>
        protected override void OnMouseMove( MouseEventArgs e )
        {
            base.OnMouseMove( e );
            if( _closeButton.IsVisible )
            {
                if( _closeButton.ButtonRectangle.Contains( e.Location ) )
                {
                    _closeButton.IsMouseOver = true;
                    Invalidate( _closeButton.RedrawRectangle );
                }
                else if( _closeButton.IsMouseOver )
                {
                    _closeButton.IsMouseOver = false;
                    Invalidate( _closeButton.RedrawRectangle );
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseLeave( EventArgs e )
        {
            base.OnMouseLeave( e );
            _closeButton.IsMouseOver = false;
            if( _closeButton.IsVisible )
            {
                Invalidate( _closeButton.RedrawRectangle );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnSizeChanged( EventArgs e )
        {
            base.OnSizeChanged( e );
            if( !_initializing )
            {
                UpdateLayout( );
            }
        }

        /// <summary>
        /// Called when [menu item clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="ToolStripItemClickedEventArgs"/>
        /// instance containing the event data.</param>
        private void OnMenuItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {
            var _fATabStripItem2 = SelectedItem = (BrowserTabStripItem)e.ClickedItem.Tag;
        }

        /// <summary>
        /// Called when [menu visible changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnMenuVisibleChanged( object sender, EventArgs e )
        {
            if( !_menu.Visible )
            {
                _open = false;
            }
        }

        /// <summary>
        /// Called when [calculate tab page].
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="currentItem">The current item.</param>
        private void OnCalculateTabPage( Graphics g, BrowserTabStripItem currentItem )
        {
            _ = Font;
            var _num = 0;
            if( currentItem.Title == "+" )
            {
                _num = AddButtonWidth;
            }
            else
            {
                _num = ( Width - ( AddButtonWidth + 20 ) ) / ( Items.Count - 1 );
                if( _num > MaxTabSize )
                {
                    _num = MaxTabSize;
                }
            }

            var _rectangleF2 =
                currentItem.StripRectangle = new RectangleF( _startPosition, 3f, _num, 28f );

            _startPosition += _num;
        }

        /// <summary>
        /// Called when [draw tab button].
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="currentItem">The current item.</param>
        private void OnDrawTabButton( Graphics g, BrowserTabStripItem currentItem )
        {
            Items.IndexOf( currentItem );
            var _font = Font;
            var _backColor = new SolidBrush( _dark );
            var _tab = currentItem.StripRectangle;
            var _graphics = new GraphicsPath( );
            var _left = _tab.Left;
            var _right = _tab.Right;
            var _num = 3f;
            var _num2 = _tab.Bottom - 1f;
            var _num3 = _tab.Width;
            var _num4 = _tab.Height;
            var _num5 = _num4 / 4f;
            _graphics?.AddLine( _left - _num5, _num2, _left + _num5, _num );
            _graphics?.AddLine( _right - _num5, _num, _right + _num5, _num2 );
            _graphics?.CloseFigure( );
            var _brush = new SolidBrush( currentItem == SelectedItem
                ? _backColor.Color
                : Color.SteelBlue );

            g.FillPath( _brush, _graphics );
            g.DrawPath( SystemPens.ControlDark, _graphics );
            if( currentItem == SelectedItem )
            {
                g.DrawLine( new Pen( _brush ), _left - 9f, _num4 + 2f, _left + _num3 - 1f,
                    _num4 + 2f );
            }

            var _location = new PointF( _left + 15f, 5f );
            var _layout = _tab;
            _layout.Location = _location;
            _layout.Width = _num3 - ( _layout.Left - _left ) - 4f;
            if( currentItem == _selectedItem )
            {
                _layout.Width -= 15f;
            }

            _layout.Height = 23f;
            if( currentItem == SelectedItem )
            {
                g.DrawString( currentItem.Title, _font, new SolidBrush( ForeColor ),
                    _layout, _formatString );
            }
            else
            {
                g.DrawString( currentItem.Title, _font, new SolidBrush( ForeColor ),
                    _layout, _formatString );
            }

            currentItem.Drawn = true;
        }

        /// <summary>
        /// Called when [collection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="CollectionChangeEventArgs"/>
        /// instance containing the event data.</param>
        private void OnCollectionChanged( object sender, CollectionChangeEventArgs e )
        {
            var _tab = (BrowserTabStripItem)e.Element;
            if( e.Action == CollectionChangeAction.Add )
            {
                Controls.Add( _tab );
                OnTabStripItemChanged( new TabItemChangedEventArgs( _tab, ChangeType.Added ) );
            }
            else if( e.Action == CollectionChangeAction.Remove )
            {
                Controls.Remove( _tab );
                OnTabStripItemChanged( new TabItemChangedEventArgs( _tab, ChangeType.Removed ) );
            }
            else
            {
                OnTabStripItemChanged( new TabItemChangedEventArgs( _tab, ChangeType.Changed ) );
            }

            UpdateLayout( );
            Invalidate( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Releases the unmanaged resources
        /// used by the <see cref="T:System.Windows.Forms.Control" />
        /// and its child controls and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing"><see langword="true" /> to release
        /// both managed and unmanaged resources; <see langword="false" />
        /// to release only unmanaged resources.
        /// </param>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                Items.CollectionChanged -= OnCollectionChanged;
                _menu.ItemClicked -= OnMenuItemClicked;
                _menu.VisibleChanged -= OnMenuVisibleChanged;
                for( var _i = 0; _i < Items.Count; _i++ )
                {
                    var _item = Items[ _i ];
                    if( ( _item != null )
                       && !_item.IsDisposed )
                    {
                        _item.Dispose( );
                    }
                }
                
                if( ( _menu != null )
                   && !_menu.IsDisposed )
                {
                    _menu.Dispose( );
                }

                _formatString?.Dispose( );
            }

            base.Dispose( disposing );
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