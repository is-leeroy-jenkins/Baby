// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ContextMenu.cs" company="Terry D. Eppler">
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
//   ContextMenu.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Child;
    using MetroSet_UI.Enums;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Baby.MenuBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class ContextMenu : MenuBase
    {
        /// <summary>
        /// Gets or sets the close option.
        /// </summary>
        /// <value>
        /// The close option.
        /// </value>
        public MetroSetToolStripMenuItem CloseItem
        {
            get
            {
                return _close;
            }
            private set
            {
                _close = value;
            }
        }

        /// <summary>
        /// Gets or sets the exit option.
        /// </summary>
        /// <value>
        /// The exit option.
        /// </value>
        public MetroSetToolStripMenuItem Other
        {
            get
            {
                return _other;
            }
            private set
            {
                _other = value;
            }
        }

        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem Developer
        {
            get
            {
                return _developer;
            }
            private set
            {
                _developer = value;
            }
        }

        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem Source
        {
            get
            {
                return _source;
            }
            private set
            {
                _source = value;
            }
        }

        /// <summary>
        /// Gets or sets the refresh option.
        /// </summary>
        /// <value>
        /// The refresh option.
        /// </value>
        public MetroSetToolStripMenuItem RefreshItem
        {
            get
            {
                return _refresh;
            }
            private set
            {
                _refresh = value;
            }
        }

        /// <summary>
        /// Gets or sets the Save As Pdf option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem SaveAs
        {
            get
            {
                return _saveAs;
            }
            private set
            {
                _saveAs = value;
            }
        }

        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem Print
        {
            get
            {
                return _print;
            }
            private set
            {
                _print = value;
            }
        }

        /// <summary>
        /// Gets or sets the exit option.
        /// </summary>
        /// <value>
        /// The exit option.
        /// </value>
        public MetroSetToolStripMenuItem Exit
        {
            get
            {
                return _exit;
            }
            private set
            {
                _exit = value;
            }
        }

        /// <summary>
        /// Gets or sets the chrome option.
        /// </summary>
        /// <value>
        /// The chrome option.
        /// </value>
        public MetroSetToolStripMenuItem Chrome
        {
            get
            {
                return _chrome;
            }
            private set
            {
                _chrome = value;
            }
        }

        /// <summary>
        /// Gets or sets the edge option.
        /// </summary>
        /// <value>
        /// The edge option.
        /// </value>
        public MetroSetToolStripMenuItem Edge
        {
            get
            {
                return _edge;
            }
            private set
            {
                _edge = value;
            }
        }

        /// <summary>
        /// Gets or sets the firefox option.
        /// </summary>
        /// <value>
        /// The firefox option.
        /// </value>
        public MetroSetToolStripMenuItem Firefox
        {
            get
            {
                return _firefox;
            }
            private set
            {
                _firefox = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ContextMenu"/> class.
        /// </summary>
        public ContextMenu( )
        {
            BackColor = Color.FromArgb( 30, 30, 30 );
            BackgroundColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            ArrowColor = Color.FromArgb( 0, 120, 212 );
            SeparatorColor = Color.FromArgb( 0, 120, 212 );
            AutoSize = false;
            Size = new Size( 160, 360 );
            IsDerivedStyle = true;
            RenderMode = ToolStripRenderMode.System;
            Style = Style.Custom;
            ShowCheckMargin = false;
            ShowImageMargin = true;
            SelectedItemBackColor = Color.FromArgb( 50, 93, 129 );
            SelectedItemColor = Color.White;
            ThemeAuthor = "Terry Eppler";
            ThemeName = "Baby";

            // Menu Items
            CloseItem = CreateCloseOption( );
            Other = CreateOtherOption( );
            RefreshItem = CreateRefreshOption( );
            SaveAs = CreateSaveAsOption( );
            Print = CreatePrintOption( );
            Developer = CreateDeveloperOption( );
            Source = CreateSourceOption( );
            Chrome = CreateChromeOption( );
            Edge = CreateEdgeOption( );
            Firefox = CreateFirefoxOption( );
            Exit = CreateExitOption( );
        }

        /// <summary>
        /// Creates the chrome option.
        /// </summary>
        /// <returns></returns>
        protected MetroSetToolStripMenuItem CreateChromeOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Chrome.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuItem.Chrome}";
                _item.Tag = MenuItem.Chrome.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += null;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary>
        /// Creates the edge option.
        /// </summary>
        /// <returns></returns>
        protected MetroSetToolStripMenuItem CreateEdgeOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Edge.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuItem.Edge}";
                _item.Tag = MenuItem.Edge.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += null;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary>
        /// Creates the firefox option.
        /// </summary>
        /// <returns></returns>
        protected MetroSetToolStripMenuItem CreateFirefoxOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Firefox.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuItem.Firefox}";
                _item.Tag = MenuItem.Firefox.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += null;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MetroSetToolStripMenuItem );
            }
        }
    }
}