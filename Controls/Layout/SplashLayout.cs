
namespace Baby
{
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetPanel" />
    [SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class SplashLayout : MetroSetPanel
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
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>
        /// The children.
        /// </value>
        public IEnumerable<Control> Children { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplashLayout"/> class.
        /// </summary>
        public SplashLayout( )
        {
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Baby";
            Size = new Size( 700, 428 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Enabled = true;
            Visible = true;
            Font = new Font( "Roboto", 8 );

            // Back color SeriesConfiguration
            BackColor = Color.FromArgb( 0, 73, 112 );
            BackgroundColor = Color.FromArgb( 0, 73, 112 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            BorderColor = Color.FromArgb( 0, 73, 112 );
            BorderStyle = BorderStyle.FixedSingle;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.SplashLayout" /> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public SplashLayout( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.SplashLayout" /> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public SplashLayout( Size size, Point location, Control parent )
            : this( size, location )
        {
            Size = new Size( size.Width, size.Height );
            Location = location;
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplashLayout"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public SplashLayout( Control parent )
        {
            Parent = parent;
            Parent.Controls.Add( this );
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
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBackColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    BackColor = color;
                    BackgroundColor = color;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Adds the child.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public IEnumerable<Control> AddChild( Control item )
        {
            if( item != null )
            {
                try
                {
                    var _list = new List<Control>
                    {
                        item
                    };
                    
                    return _list?.Any( ) == true
                        ? _list
                        : default( List<Control> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return default( IEnumerable<Control> );
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Control> GetChildren( )
        {
            try
            {
                return Children?.Any( ) == true
                    ? Children
                    : default( IEnumerable<Control> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<Control> );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                BackColor = Color.FromArgb( 0, 73, 112 );
                BackgroundColor = Color.FromArgb( 0, 73, 112 );
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
