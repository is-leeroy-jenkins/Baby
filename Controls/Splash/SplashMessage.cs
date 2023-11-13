// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="WebSplashMessage.cs" company="Terry D. Eppler">
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
//   WebSplashMessage.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Tools;
    using Image = System.Drawing.Image;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Tools.SplashPanel" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class SplashMessage : SplashPanel
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public IEnumerable<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.SplashMessage" /> class.
        /// </summary>
        /// <remarks>
        /// The default value for the
        /// <see cref="P:Syncfusion.Windows.Forms.Tools.SplashPanel.TimerInterval" /> is set to
        /// 5000 milliseconds.
        /// The splash panel has animation turned and by default will appear in the
        /// middle of the screen.
        /// </remarks>
        public SplashMessage( )
        {
            BackColor = Color.FromArgb( 0, 73, 112 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            Size = new Size( 300, 150 );
            BorderStyle = Border3DStyle.Flat;
            BorderType = SplashBorderType.Border3D;
            BackgroundColor = new BrushInfo( GradientStyle.PathEllipse, 
                Color.FromArgb( 0, 73, 112 ), Color.FromArgb( 0, 73, 112 ) );
            
            ShowAnimation = true;
            ShowAsTopMost = true;
            AnimationSpeed = 20;
            AnimationSteps = 3;
            AnimationDirection = AnimationDirection.Default;
            DesktopAlignment = SplashAlignment.Center;
            DiscreetLocation = new Point( 0, 0 );
            SuspendAutoCloseWhenMouseOver = false;
            TabIndex = 0;
            TimerInterval = 5000;
            CloseOnClick = true;
            MarqueePosition = MarqueePosition.BottomRight;
            MarqueeDirection = SplashPanelMarqueeDirection.RightToLeft;
            SlideStyle = SlideStyle.FadeIn;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.SplashMessage" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public SplashMessage( string message )
            : this( )
        {
            Text = message;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.SplashMessage" /> class.
        /// </summary>
        /// <param name="toolTip">The tool tip.</param>
        public SplashMessage( ToolTip toolTip )
            : this( )
        {
            Text = toolTip?.TipText;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.SplashMessage" /> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="message">The message.</param>
        public SplashMessage( Control control, string message )
            : this( )
        {
            Parent = control;
            Text = message;
        }

        /// <summary>
        /// Shows the message.
        /// </summary>
        public void ShowMessage( )
        {
            if( !string.IsNullOrEmpty( Text ) )
            {
                try
                {
                    ShowSplash( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Res the size.
        /// </summary>
        /// <param name="size">The size.</param>
        public void ReSize( Size size )
        {
            try
            {
                Size = size;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Res the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void ReSize( int width = 300, int height = 150 )
        {
            try
            {
                Size = new Size( width, height );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText( string text )
        {
            try
            {
                Text = text;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBackColor( Color color )
        {
            try
            {
                BackColor = color;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Resets the icon.
        /// </summary>
        /// <param name="path">The path.</param>
        public void SetIcon( string path )
        {
            if( !string.IsNullOrEmpty( path )
               && File.Exists( path ) )
            {
                try
                {
                    var _stream = File.Open( path, FileMode.Open );
                    FormIcon = new Icon( _stream );
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
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}