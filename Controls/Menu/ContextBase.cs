// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="ContextBase.cs" company="Terry D. Eppler">
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
//   ContextBase.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using MetroSet_UI.Child;
    using Properties;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public abstract class ContextBase : MenuBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ContextBase"/> class.
        /// </summary>
        public ContextBase( )
            : base( )
        {
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
                _item.Image = Resources.ChromeItem;
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
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"View {MenuItem.Source}";
                _item.Tag = MenuItem.Source.ToString( );
                _item.Image = Resources.OneDriveItem;
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
        /// Creates the calculator option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected MetroSetToolStripMenuItem CreateCalculatorItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuItem.Calculator.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuItem.Calculator}";
                _item.Tag = MenuItem.Calculator.ToString( );
                _item.Image = Resources.CalculatorItem;
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
        /// Creates the task manager item.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateTaskManagerItem( )
        {
            try
            {
                var _name = MenuItem.TaskManager.ToString( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _name.SplitPascal( );
                _item.Tag = MenuItem.TaskManager.ToString( );
                _item.Image = Resources.TaskManagerItem;
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
        /// Creates the control panel item.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateControlPanelItem( )
        {
            try
            {
                var _name = MenuItem.ControlPanel.ToString( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _name.SplitPascal( );
                _item.Tag = MenuItem.ControlPanel.ToString( );
                _item.Image = Resources.ControlPanelItem;
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
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuItem.Exit}";
                _item.Tag = MenuItem.Exit.ToString( );
                _item.Image = Resources.ExitItem;
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
                _item.Image = Resources.EdgeItem;
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
                _item.Image = Resources.FirefoxItem;
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
    }
}