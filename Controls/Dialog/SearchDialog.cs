// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 05-01-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-05-2024
// ******************************************************************************************
// <copyright file="teppler" company="Terry D. Eppler">
//    Baby is a small web browser used in a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//   SearchDialog.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using CefSharp.DevTools.IndexedDB;
    using MetroSet_UI.Enums;
    using Syncfusion.Windows.Forms;
    
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    public partial class SearchDialog : MetroForm
    {
        /// <summary>
        /// The domain
        /// </summary>
        private string _queryPrefix;
        
        /// <summary>
        /// The results
        /// </summary>
        private string _results;
        
        /// <summary>
        /// The input
        /// </summary>
        private string _keywordInput;
        
        /// <summary>
        /// The keyword prefix
        /// </summary>
        private string _keywordPrefix;
        
        /// <summary>
        /// The domain prefix
        /// </summary>
        private string _domainPrefix;

        /// <summary>
        /// Gets the selected domain.
        /// </summary>
        /// <value>
        /// The selected domain.
        /// </value>
        public string QueryPrefix
        {
            get
            {
                return _queryPrefix;
            }
            private set
            {
                _queryPrefix = value;
            }
        }

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        public string Results
        {
            get
            {
                return _results;
            }
            private set
            {
                _results = value;
            }
        }
        
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public SearchDialog( )
        {
            InitializeComponent( );
            RegisterCallbacks( );
            
            // Form Properterties
            Size = new Size( 581, 90 );
            MinimumSize = new Size( 581, 90 );
            MaximumSize = new Size( 581, 90 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            StartPosition = FormStartPosition.Manual;
            CaptionBarHeight = 5;
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            Enabled = true;
            Visible = true;
            _keywordInput = string.Empty;
            _results = string.Empty;
            _domainPrefix = "Domain:";
            _keywordPrefix = "Key Words:";
            
            //Event Wiring
            Load += OnLoad;
        }
        
        /// <summary>
        /// Registers the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                DialogCloseButton.Click += OnCloseButtonClick;
                DialogLookupButton.Click += OnLookupButtonClick;
                DialogRefreshButton.Click += OnClearButtonClick;
                DialogDomainComboBox.SelectedIndexChanged += OnSelectedDomainChanged;
                DialogKeyWordTextBox.TextChanged += OnInputTextChanged;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitializeTextBox( )
        {
            try
            {
                DialogKeyWordTextBox.Font = new Font( "Roboto", 12 );
                DialogKeyWordTextBox.ForeColor = Color.FromArgb( 106, 189, 252 );
                DialogKeyWordTextBox.BackColor = Color.FromArgb( 34, 34, 34 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                var _s = " ";
                DomainLabel.Text = _domainPrefix 
                    + _s 
                    + DialogDomainComboBox.SelectedText ?? "Google";

                KeyWordLabel.Text = _keywordPrefix ?? "0";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
                DialogCloseButton.FlatStyle = FlatStyle.Flat;
                DialogCloseButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                DialogCloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb( 50, 93, 129 );
                DialogCloseButton.BackColor = Color.FromArgb( 20, 20, 20 );
                DialogLookupButton.FlatStyle = FlatStyle.Flat;
                DialogLookupButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                DialogLookupButton.FlatAppearance.MouseOverBackColor = Color.FromArgb( 18, 79, 17 );
                DialogLookupButton.BackColor = Color.FromArgb( 20, 20, 20 );
                DialogCloseButton.FlatStyle = FlatStyle.Flat;
                DialogCloseButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                DialogCloseButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
                DialogCloseButton.BackColor = Color.FromArgb( 20, 20, 20 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the ComboBox.
        /// </summary>
        private void InitializeComboBox( )
        {
            try
            {
                DialogDomainComboBox.Style = Style.Custom;
                DialogDomainComboBox.BackColor = Color.FromArgb( 34, 34, 34 );
                DialogDomainComboBox.BorderColor = Color.FromArgb( 34, 34, 34 );
                DialogDomainComboBox.ForeColor = Color.FromArgb( 106, 189, 252 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary> Called when [load]. </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                _queryPrefix = ConfigurationManager.AppSettings[ "Google" ];
                InitializeTextBox( );
                InitializeButtons( );
                InitializeComboBox( );
                InitializeLabels( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnCloseButtonClick( object sender, EventArgs e )
        {
            try
            {
                _results = string.Empty;
                _queryPrefix = string.Empty;
                _domainPrefix = string.Empty;
                DialogResult = DialogResult.Cancel;
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [okay button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public virtual void OnLookupButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( DialogKeyWordTextBox.Text ) )
                {
                    _results = _queryPrefix + DialogKeyWordTextBox.Text;
                    DialogResult = DialogResult.OK;
                    Close( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [clear button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public virtual void OnClearButtonClick( object sender, EventArgs e )
        {
            try
            {
                DialogKeyWordTextBox.Text = string.Empty;
                _results = string.Empty;
                DialogResult = DialogResult.Continue;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [input text changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnInputTextChanged( object sender, EventArgs e )
        {
            try
            {
                var _s = " ";
                var _input = DialogKeyWordTextBox.Text;
                if( _input.Contains( " " ) )
                {
                    var _split = _input.Split( " " );
                    KeyWordLabel.Text = _keywordPrefix + _s + _split.Length;
                }
                else
                {
                    KeyWordLabel.Text = _keywordPrefix + _s + 0;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [search engine selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSelectedDomainChanged( object sender, EventArgs e )
        {
            try
            {
                var _s = " ";
                var _index = DialogDomainComboBox.SelectedIndex;
                _queryPrefix = _index switch
                {
                    0 => ConfigurationManager.AppSettings[ "Google" ],
                    1 => ConfigurationManager.AppSettings[ "EPA" ],
                    2 => ConfigurationManager.AppSettings[ "DATA" ],
                    3 => ConfigurationManager.AppSettings[ "GPO" ],
                    4 => ConfigurationManager.AppSettings[ "USGI" ],
                    5 => ConfigurationManager.AppSettings[ "CRS" ],
                    6 => ConfigurationManager.AppSettings[ "LOC" ],
                    7 => ConfigurationManager.AppSettings[ "OMB" ],
                    8 => ConfigurationManager.AppSettings[ "UST" ],
                    9 => ConfigurationManager.AppSettings[ "NASA" ],
                    10 => ConfigurationManager.AppSettings[ "NOAA" ],
                    11 => ConfigurationManager.AppSettings[ "DOI" ],
                    12 => ConfigurationManager.AppSettings[ "NPS" ],
                    13 => ConfigurationManager.AppSettings[ "GSA" ],
                    14 => ConfigurationManager.AppSettings[ "NARA" ],
                    15 => ConfigurationManager.AppSettings[ "DOC" ],
                    16 => ConfigurationManager.AppSettings[ "HHS" ],
                    17 => ConfigurationManager.AppSettings[ "NRC" ],
                    18 => ConfigurationManager.AppSettings[ "DOE" ],
                    19 => ConfigurationManager.AppSettings[ "NSF" ],
                    20 => ConfigurationManager.AppSettings[ "USDA" ],
                    21 => ConfigurationManager.AppSettings[ "CSB" ],
                    22 => ConfigurationManager.AppSettings[ "IRS" ],
                    23 => ConfigurationManager.AppSettings[ "FDA" ],
                    24 => ConfigurationManager.AppSettings[ "CDC" ],
                    25 => ConfigurationManager.AppSettings[ "ACE" ],
                    26 => ConfigurationManager.AppSettings[ "DHS" ],
                    27 => ConfigurationManager.AppSettings[ "DOD" ],
                    28 => ConfigurationManager.AppSettings[ "USNO" ],
                    29 => ConfigurationManager.AppSettings[ "NWS" ],
                    _ => ConfigurationManager.AppSettings[ "Google" ]
                };
                
                DomainLabel.Text = _domainPrefix + _s + DialogDomainComboBox.SelectedText;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}