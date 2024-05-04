// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 05-01-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-04-2024
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
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
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
    public partial class SearchDialog : MetroForm
    {
        /// <summary>
        /// The results
        /// </summary>
        private string _results;
        
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
            Size = new Size( 678, 100 );
            MinimumSize = new Size( 678, 100 );
            MaximumSize = new Size( 678, 100 );
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
            
            //Event Wiring
            Load += OnLoad;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.MessageDialog" />
        /// class.
        /// </summary>
        /// <param name="text">
        /// The text displayed by the control.
        /// </param>
        public SearchDialog( string text )
            : this( )
        {
            KeyWordTextBox.Text = text;
        }
        
        /// <summary>
        /// Registers the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                CloseButton.Click += OnCloseButtonClick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the text box.
        /// </summary>
        private void InitializeTextBox( )
        {
            try
            {
                KeyWordTextBox.BackColor = Color.FromArgb( 30, 30, 30 );
                KeyWordTextBox.BorderColor = Color.FromArgb( 90, 90, 90 );
                KeyWordTextBox.HoverColor = Color.FromArgb( 0, 120, 212 );
                KeyWordTextBox.Size = new Size( 637, 31 );
                KeyWordTextBox.Font = new Font( "Roboto", 10 );
                KeyWordTextBox.ForeColor = Color.FromArgb( 106, 189, 252 );
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
                CloseButton.Size = new Size( 44, 33 );
                CloseButton.FlatStyle = FlatStyle.Flat;
                CloseButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb( 50, 93, 129 );
                CloseButton.BackColor = Color.FromArgb( 20, 20, 20 );
                LookupButton.Size = new Size( 44, 33 );
                LookupButton.FlatStyle = FlatStyle.Flat;
                LookupButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                LookupButton.FlatAppearance.MouseOverBackColor = Color.FromArgb( 50, 93, 129 );
                LookupButton.BackColor = Color.FromArgb( 20, 20, 20 );
                CloseButton.Size = new Size( 44, 33 );
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
                ComboBox.BackColor = Color.FromArgb( 45, 45, 45 );
                ComboBox.BorderColor = Color.FromArgb( 45, 45, 45 );
                ComboBox.ForeColor = Color.FromArgb( 106, 189, 252 );
                var _domains = Enum.GetNames( typeof( Domain ) );
                foreach( var _item in _domains )
                {
                    ComboBox.Items.Add( _item );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the domain ComboBox.
        /// </summary>
        private void PopulateDomainComboBox( )
        {
            try
            {
                var _domains = Enum.GetNames( typeof( Domain ) );
                foreach( var _item in _domains )
                {
                    ComboBox.Items?.Add( _item );
                }
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
                InitializeTextBox( );
                InitializeButtons( );
                InitializeComboBox( );
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
                if( !string.IsNullOrEmpty( KeyWordTextBox.Text ) )
                {
                    _results = KeyWordTextBox.Text;
                }
                
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
        public virtual void OnOkayButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( KeyWordTextBox.Text ) )
                {
                    _results = KeyWordTextBox.Text;
                }
                
                Close( );
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnClearButtonClick( object sender, EventArgs e )
        {
            try
            {
                KeyWordTextBox.Text = string.Empty;
                _results = string.Empty;
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