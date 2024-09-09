// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="MessageDialog.cs" company="Terry D. Eppler">
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
//   MessageDialog.cs
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
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public partial class MessageDialog : MetroForm
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public MessageDialog( )
        {
            InitializeComponent( );
            Size = new Size( 700, 400 );
            MinimumSize = new Size( 700, 400 );
            MaximumSize = new Size( 700, 400 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            StartPosition = FormStartPosition.CenterScreen;
            CaptionBarHeight = 5;
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            Enabled = true;
            Visible = true;

            // Control Properties
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.Text = "Close";
            CloseButton.ForeColor = Color.FromArgb( 0, 120, 212 );
            CloseButton.BackColor = Color.FromArgb( 20, 20, 20 );
            TextBox.BackColor = Color.FromArgb( 40, 40, 40 );
            CloseButton.Focus( );

            //Event Wiring
            CloseButton.Click += OnCloseButtonClick;
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
        public MessageDialog( string text )
            : this( )
        {
            TextBox.Text = Environment.NewLine + text;
            CloseButton.Focus( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.MessageDialog" />
        /// class.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        /// <param name="caption">
        /// The caption.
        /// </param>
        public MessageDialog( string text, string caption )
            : this( text )
        {
            Header.Text = caption;
            CloseButton.Focus( );
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Header.ForeColor = Color.FromArgb( 0, 120, 212 );
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
        public void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
                && !string.IsNullOrEmpty( _button?.Name ) )
            {
                try
                {
                    DialogResult = DialogResult.Ignore;
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [select button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnSelectButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
                && !string.IsNullOrEmpty( _button?.Name ) )
            {
                try
                {
                    DialogResult = DialogResult.OK;
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [cancel button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnCancelButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
                && !string.IsNullOrEmpty( _button?.Name ) )
            {
                try
                {
                    DialogResult = DialogResult.Cancel;
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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