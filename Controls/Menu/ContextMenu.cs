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

namespace BudgetBrowser
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using MetroSet_UI.Child;
    using MetroSet_UI.Enums;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MenuBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class ContextMenu : MenuBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ContextMenu"/> class.
        /// </summary>
        public ContextMenu( )
        {
            BackColor = Color.FromArgb( 30, 30, 30 );
            BackgroundColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.White;
            ArrowColor = Color.FromArgb( 50, 93, 129 );
            SeparatorColor = Color.FromArgb( 65, 65, 65 );
            AutoSize = false;
            Size = new Size( 156, 264 );
            IsDerivedStyle = false;
            RenderMode = ToolStripRenderMode.System;
            Style = Style.Custom;
            ShowCheckMargin = false;
            ShowImageMargin = true;
            SelectedItemBackColor = Color.FromArgb( 50, 93, 129 );
            SelectedItemColor = Color.White;
            ThemeAuthor = "Terry Eppler";
            ThemeName = "Budget Browser";

            // Menu Items
            SearchOption = CreateSearchOption( );
            CloseOption = CreateCloseOption( );
            ExitOption = CreateExitOption( );
        }

        /// <summary>
        /// Creates the file option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        private MetroSetToolStripMenuItem CreateSearchOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.Search}";
                _item.Tag = MenuItem.Search.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
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
        private MetroSetToolStripMenuItem CreateCloseOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuItem.Close.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.Close}";
                _item.Tag = MenuItem.Close.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
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
        private MetroSetToolStripMenuItem CreateExitOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuItem.Exit.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuItem.Exit}";
                _item.Tag = MenuItem.Exit.ToString( );
                _item.MouseEnter += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
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
        /// Called when [item clicked].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnItemClicked( object sender, MouseEventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem _item
               && ( e?.Button == MouseButtons.Left ) )
            {
                try
                {
                    var _name = _item.Tag.ToString( );
                    if( !string.IsNullOrEmpty( _name ) )
                    {
                        var _option = Enum.Parse( typeof( MenuItem ), _name );
                        switch( _option )
                        {
                            case MenuItem.Close:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuItem.Exit:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            default:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                        }

                        Close( );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
    }
}