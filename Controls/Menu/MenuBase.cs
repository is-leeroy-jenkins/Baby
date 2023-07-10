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
        public MetroSetToolStripMenuItem OtherOption { get; set; }

        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem DeveloperOption { get; set; }

        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem SourceOption { get; set; }

        /// <summary>
        /// Gets or sets the refresh option.
        /// </summary>
        /// <value>
        /// The refresh option.
        /// </value>
        public MetroSetToolStripMenuItem RefreshOption { get; set; }

        /// <summary>
        /// Gets or sets the Save As Pdf option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem SaveAsOption { get; set; }

        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public MetroSetToolStripMenuItem PrintOption { get; set; }
        
        /// <summary>
        /// Gets or sets the exit option.
        /// </summary>
        /// <value>
        /// The exit option.
        /// </value>
        public MetroSetToolStripMenuItem ExitOption { get; set; }

        /// <summary>
        /// Gets or sets the chrome option.
        /// </summary>
        /// <value>
        /// The chrome option.
        /// </value>
        public MetroSetToolStripMenuItem ChromeOption { get; set; }

        /// <summary>
        /// Gets or sets the edge option.
        /// </summary>
        /// <value>
        /// The edge option.
        /// </value>
        public MetroSetToolStripMenuItem EdgeOption { get; set; }

        /// <summary>
        /// Gets or sets the firefox option.
        /// </summary>
        /// <value>
        /// The firefox option.
        /// </value>
        public MetroSetToolStripMenuItem FirefoxOption { get; set; }

        /// <summary>
        /// Creates the close option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        protected MetroSetToolStripMenuItem CreateCloseOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Close.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.Close} Tab";
                _item.Tag = MenuItem.Close.ToString( );
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
        /// Creates the close option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        protected MetroSetToolStripMenuItem CreateOtherOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Other.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"Close {MenuItem.Other} Tabs";
                _item.Tag = MenuItem.Other.ToString( );
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
        /// Creates the close option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        protected MetroSetToolStripMenuItem CreateRefreshOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Refresh.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.Refresh} Tab";
                _item.Tag = MenuItem.Refresh.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the file option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        protected MetroSetToolStripMenuItem CreateSaveAsOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.SaveAs.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.SaveAs}".SplitPascal( ) + " PDF";
                _item.Tag = MenuItem.SaveAs.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the file browse option.
        /// </summary>
        /// <returns></returns>
        protected MetroSetToolStripMenuItem CreatePrintOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Print.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.Print}";
                _item.Tag = MenuItem.Print.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the developer toools option.
        /// </summary>
        /// <returns></returns>
        protected MetroSetToolStripMenuItem CreateDeveloperOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Developer.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.Developer} Tools";
                _item.Tag = MenuItem.Developer.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the close others option.
        /// </summary>
        /// <returns></returns>
        protected MetroSetToolStripMenuItem CreateSourceOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Source.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"View {MenuItem.Source}";
                _item.Tag = MenuItem.Source.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the exit option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        protected MetroSetToolStripMenuItem CreateExitOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Exit.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.Exit}";
                _item.Tag = MenuItem.Exit.ToString( );
                _item.MouseEnter += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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