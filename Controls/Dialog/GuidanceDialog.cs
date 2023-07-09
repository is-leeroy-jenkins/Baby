// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="GuidanceDialog.cs" company="Terry D. Eppler">
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
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   GuidanceDialog.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
    [SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    public partial class GuidanceDialog : MetroForm
    {
        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedColumns { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields { get; set; }

        /// <summary>
        /// Gets or sets the selected path.
        /// </summary>
        /// <value>
        /// The selected path.
        /// </value>
        public string SelectedPath { get; set; }

        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>
        /// The selected item.
        /// </value>
        public string SelectedItem { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.GuidanceDialog" /> class.
        /// </summary>
        public GuidanceDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 503, 429 );
            MaximumSize = new Size( 503, 429 );
            MinimumSize = new Size( 503, 429 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // Label Properties
            HeaderLabel.Font = new Font( "Roboto", 10 );
            HeaderLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            HeaderLabel.FlatStyle = FlatStyle.Flat;

            // Picture Properties
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;

            // File Dialog Properties
            OpenFileDialog.Title = "Search for Document";
            OpenFileDialog.CheckPathExists = true;
            OpenFileDialog.CheckFileExists = true;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            SelectButton.Click += OnSelectButtonClicked;
            ClearButton.Click += OnClearButtonClicked;
            BrowseButton.Click += OnBrowseButtonClicked;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetBrowser.GuidanceDialog" /> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.
        /// </param>
        public GuidanceDialog( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
        }

        /// <summary>
        /// Called when [browse button clicked].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnBrowseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                OpenFileDialog.ShowDialog( );
                SelectedPath = OpenFileDialog.SafeFileName;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [clear button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnClearButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                var _notification = new Notification( _msg );
                _notification.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [select button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnSelectButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                var _notification = new Notification( _msg );
                _notification.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SelectedColumns = new List<string>( );
                CloseButton.HoverText = "Close Window";
                SelectButton.HoverText = "Open Selected Item";
                ClearButton.HoverText = "Clear Selected Item";
                BrowseButton.HoverText = "Search for File";
                PopulateListBox( );
                SetLabelText( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the label text.
        /// </summary>
        private void SetLabelText( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the ListBox.
        /// </summary>
        private void PopulateListBox( )
        {
            try
            {
                ListBox.Items.Clear( );
                var _names = new List<string>( );
                foreach( var _name in _names )
                {
                    ListBox.Items.Add( _name );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the second tab ListBox.
        /// </summary>
        private void PopulateSecondTabListBox( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the header text.
        /// </summary>
        private void UpdateHeaderText( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [ListView selected value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnListViewSelectedValueChanged( object sender )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
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