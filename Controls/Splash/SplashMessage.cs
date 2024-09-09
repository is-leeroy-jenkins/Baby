// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="SplashMessage.cs" company="Terry D. Eppler">
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
//   SplashMessage.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using System.Threading.Tasks;
    using static Animator;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantExtendsListEntry" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    public partial class SplashMessage : MetroForm
    {
        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The time
        /// </summary>
        private int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The allow focus
        /// </summary>
        private bool _allowFocus;

        /// <summary>
        /// The without activation
        /// </summary>
        private bool _withoutActivation;

        /// <summary>
        /// The lines
        /// </summary>
        private IList<string> _lines;

        /// <summary>
        /// Gets or sets a value indicating whether [allow focus].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow focus]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowFocus
        {
            get
            {
                return _allowFocus;
            }
            private set
            {
                _allowFocus = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [shown without activation].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [shown without activation]; otherwise, <c>false</c>.
        /// </value>
        public bool ShownWithoutActivation
        {
            get
            {
                return _withoutActivation;
            }
            private set
            {
                _withoutActivation = value;
            }
        }

        /// <summary>
        /// Gets or sets the lines.
        /// </summary>
        /// <value>
        /// The lines.
        /// </value>
        public IList<string> Lines
        {
            get
            {
                return _lines;
            }
            private set
            {
                _lines = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is busy; otherwise,
        /// <c> false </c>
        /// </value>
        public bool IsBusy
        {
            get
            {
                return _busy;
            }
            private set
            {
                _busy = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.SplashMessage" /> class.
        /// </summary>
        public SplashMessage( )
        {
            InitializeComponent( );
            RegisterCallbacks( );

            // Form Properties
            Size = new Size( 735, 371 );
            MinimumSize = new Size( 735, 371 );
            MaximumSize = new Size( 735, 371 );
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ShowIcon = false;
            ShowMouseOver = false;
            ShowInTaskbar = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            SizeGripStyle = SizeGripStyle.Hide;
            Padding = new Padding( 1 );
            Title.ForeColor = Color.White;
            BorderColor = Color.FromArgb( 106, 189, 252 );
            BackColor = Color.FromArgb( 1, 35, 54 );
            CaptionBarColor = Color.FromArgb( 1, 35, 54 );
            Message.BackColor = Color.FromArgb( 1, 35, 54 );
            Message.ForeColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );

            // Wire Events
            MouseClick += OnClick;
            FormClosing += OnFormClosing;
            Activated += OnActivated;
            Load += OnLoad;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.SplashMessage" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animation">The animation.</param>
        /// <param name="direction">The direction.</param>
        public SplashMessage( string message, int duration = 5,
            AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            _time = 0;
            _seconds = duration;
            Message.Text = message;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.SplashMessage" /> class.
        /// </summary>
        /// <param name="lines">The lines.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animation">The animation.</param>
        /// <param name="direction">The direction.</param>
        public SplashMessage( IEnumerable<string> lines, int duration = 5,
            AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            _lines = lines.ToList( );
            _time = 0;
            _seconds = duration;
        }

        /// <summary>
        /// Initializes the title.
        /// </summary>
        private protected void InitializeTitle( )
        {
            try
            {
                Title.ForeColor = Color.White;
                Title.TextAlign = ContentAlignment.TopLeft;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the panel.
        /// </summary>
        private protected void InitializePanel( )
        {
            try
            {
                BackPanel.BorderColor = Color.FromArgb( 1, 35, 54 );
                BackPanel.Margin = new Padding( 1 );
                BackPanel.Padding = new Padding( 1 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private protected void InitializeLabels( )
        {
            try
            {
                Message.BackColor = Color.FromArgb( 1, 35, 54 );
                Message.Font = new Font( "Roboto", 10 );
                Message.ForeColor = Color.White;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Registers the callbacks.
        /// </summary>
        private protected void RegisterCallbacks( )
        {
            try
            {
                PictureBox.MouseClick += OnClick;
                Title.MouseClick += OnClick;
                Message.MouseClick += OnClick;
                CloseButton.Click += OnCloseButtonClick;
                BackPanel.MouseClick += OnClick;
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                InitializeLabels( );
                InitializePanel( );
                InitializeTitle( );
                FadeInAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Raises the Close event.
        /// </summary>
        public void OnCloseButtonClick( object sender, EventArgs e )
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
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void OnClick( object sender, MouseEventArgs e )
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
        /// Called when [form closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFormClosing( object sender, EventArgs e )
        {
            try
            {
                Opacity = 1;
                FadeOutAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [activated].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnActivated( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                FadeInAsync( this );
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
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}