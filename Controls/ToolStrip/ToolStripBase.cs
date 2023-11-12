// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-04-2023
// ******************************************************************************************
// <copyright file="ToolStripBase.cs" company="Terry D. Eppler">
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
//   ToolStripBase.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using Syncfusion.Windows.Forms.Tools;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.ToolStripEx" />
    public abstract class ToolStripBase : ToolStripEx
    {
        /// <summary>
        /// Gets or sets the separators.
        /// </summary>
        /// <value>
        /// The separators.
        /// </value>
        public IEnumerable<ToolSeparator> Separators { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public ToolStripLabel NavigationLabel { get; set; }

        /// <summary>
        /// Gets or sets the search engine label.
        /// </summary>
        /// <value>
        /// The search engine label.
        /// </value>
        public ToolStripLabel SearchEngineLabel { get; set; }

        /// <summary>
        /// Gets or sets the search criteria label.
        /// </summary>
        /// <value>
        /// The search criteria label.
        /// </value>
        public ToolStripLabel WebsiteLabel { get; set; }

        /// <summary>
        /// Gets or sets the drop down.
        /// </summary>
        /// <value>
        /// The drop down.
        /// </value>
        public ToolStripComboBox WebsiteComboBox { get; set; }

        /// <summary>
        /// Gets or sets the drop down.
        /// </summary>
        /// <value>
        /// The drop down.
        /// </value>
        public ToolStripComboBox SearchEngineComboBox { get; set; }

        /// <summary>
        /// Gets or sets the text box.
        /// </summary>
        /// <value>
        /// The text box.
        /// </value>
        public ToolStripTextBox ToolBarTextBox { get; set; }

        /// <summary>
        /// Gets or sets the first button.
        /// </summary>
        /// <value>
        /// The first button.
        /// </value>
        public ToolStripButton FirstButton { get; set; }

        /// <summary>
        /// Gets or sets the previous button.
        /// </summary>
        /// <value>
        /// The previous button.
        /// </value>
        public ToolStripButton PreviousButton { get; set; }

        /// <summary>
        /// Gets or sets the next button.
        /// </summary>
        /// <value>
        /// The next button.
        /// </value>
        public ToolStripButton NextButton { get; set; }

        /// <summary>
        /// Gets or sets the refresh button.
        /// </summary>
        /// <value>
        /// The refresh button.
        /// </value>
        public ToolStripButton RefreshButton { get; set; }

        /// <summary>
        /// Gets or sets the home button.
        /// </summary>
        /// <value>
        /// 
        /// The home button.
        /// </value>
        public ToolStripButton HomeButton { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripBase"/> class.
        /// </summary>
        protected ToolStripBase( )
        {
        }

        /// <summary>
        /// Adds the text box.
        /// </summary>
        public void AddTextBox( )
        {
            try
            {
                var _textBox = new System.Windows.Forms.ToolStripTextBox( );
                Items?.Add( _textBox );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the ComboBox.
        /// </summary>
        public void AddComboBox( )
        {
            try
            {
                var _comboBox = new ToolStripComboBoxEx( );
                Items?.Add( _comboBox );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the drop down item.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public void AddDropDownItem( object item )
        {
            if( item != null )
            {
                try
                {
                    SearchEngineComboBox?.ComboBox?.Items.Add( item );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Resets the drop down list.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        public void ResetDropDownList( IEnumerable<object> items )
        {
            try
            {
                SearchEngineComboBox?.ComboBox.Items?.Clear( );
                if( items?.Count( ) > 0 )
                {
                    foreach( var _item in items )
                    {
                        SearchEngineComboBox?.ComboBox?.Items?.Add( _item );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the separator.
        /// </summary>
        public void AddSeparator( )
        {
            try
            {
                var _separator = new ToolSeparator( );
                Items?.Add( _separator );
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
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}