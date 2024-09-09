// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="SearchDialog.cs" company="Terry D. Eppler">
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
//   SearchDialog.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
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
        private string _keywordLabelPrefix;

        /// <summary>
        /// The domain prefix
        /// </summary>
        private string _domainLabelPrefix;

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
            private protected set
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
            _domainLabelPrefix = "Domain:";
            _keywordLabelPrefix = "Key Words:";
            _queryPrefix = ConfigurationManager.AppSettings[ "Google" ];

            // Control Properties
            ComboBox.BackColor = Color.FromArgb( 75, 75, 75 );
            ComboBox.ArrowColor = Color.FromArgb( 0, 120, 212 );
            ComboBox.BorderColor = Color.FromArgb( 0, 120, 212 );
            ComboBox.ForeColor = Color.White;
            DomainLabel.Text = _domainLabelPrefix + " " + "Google";
            KeyWordLabel.Text = _keywordLabelPrefix + " " + "0";

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
                CloseButton.Click += OnCloseButtonClick;
                LookupButton.Click += OnLookupButtonClick;
                RefreshButton.Click += OnClearButtonClick;
                ComboBox.SelectionChangeCommitted += OnSelectedDomainChanged;
                TextBox.TextChanged += OnInputTextChanged;
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
                TextBox.Font = new Font( "Roboto", 10 );
                TextBox.ForeColor = Color.FromArgb( 106, 189, 252 );
                TextBox.BackColor = Color.FromArgb( 75, 75, 75 );
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
                KeyWordLabel.ForeColor = Color.FromArgb( 106, 189, 252 );
                DomainLabel.ForeColor = Color.FromArgb( 106, 189, 252 );
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
                CloseButton.FlatStyle = FlatStyle.Flat;
                CloseButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb( 50, 93, 129 );
                CloseButton.BackColor = Color.FromArgb( 20, 20, 20 );
                LookupButton.FlatStyle = FlatStyle.Flat;
                LookupButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                LookupButton.FlatAppearance.MouseOverBackColor = Color.FromArgb( 18, 79, 17 );
                LookupButton.BackColor = Color.FromArgb( 20, 20, 20 );
                CloseButton.FlatStyle = FlatStyle.Flat;
                CloseButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                CloseButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
                CloseButton.BackColor = Color.FromArgb( 20, 20, 20 );
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
                ComboBox.Style = Style.Custom;
                ComboBox.BackColor = Color.FromArgb( 75, 75, 75 );
                ComboBox.ArrowColor = Color.FromArgb( 0, 120, 212 );
                ComboBox.BorderColor = Color.FromArgb( 0, 120, 212 );
                ComboBox.ForeColor = Color.White;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the in asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeInAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity < 1.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity += 0.05;
                }

                form.Opacity = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeOutAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity > 0.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity -= 0.05;
                }

                form.Opacity = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
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
                _domainLabelPrefix = string.Empty;
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
                if( !string.IsNullOrEmpty( _keywordInput )
                    && !string.IsNullOrEmpty( _queryPrefix ) )
                {
                    _results = _queryPrefix + _keywordInput;
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
                _keywordInput = string.Empty;
                _results = string.Empty;
                _queryPrefix = ConfigurationManager.AppSettings[ "Google" ];
                DomainLabel.Text = _domainLabelPrefix;
                KeyWordLabel.Text = _keywordLabelPrefix;
                DialogResult = DialogResult.Retry;
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
                _keywordInput = TextBox.Text;
                if( _keywordInput.Contains( " " ) )
                {
                    var _split = _keywordInput.Split( " " );
                    KeyWordLabel.Text = _keywordLabelPrefix + " " + _split.Length;
                    _results = _queryPrefix + _keywordInput;
                }
                else
                {
                    KeyWordLabel.Text = _keywordLabelPrefix + " " + 0;
                    _results = _queryPrefix + _keywordInput;
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
                if( sender is MetroSetComboBox _comboBox )
                {
                    var _index = _comboBox.SelectedIndex;
                    var _tag = _comboBox.SelectedItem;
                    _comboBox.Tag = _tag;
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

                    var _selection = _tag.ToString( );
                    if( !string.IsNullOrEmpty( _selection ) )
                    {
                        DomainLabel.Text = _domainLabelPrefix + " " + _selection;
                    }
                    else
                    {
                        DomainLabel.Text = _domainLabelPrefix + " " + "Google";
                    }
                }
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