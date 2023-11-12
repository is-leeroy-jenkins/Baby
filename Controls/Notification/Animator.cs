// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Animator.cs" company="Terry D. Eppler">
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
//   Animator.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public sealed class Animator
    {
        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        /// <value>
        /// The method.
        /// </value>
        public AnimationMethod Method { get; set; }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public AnimationDirection Direction { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the form.
        /// </summary>
        /// <value>
        /// The form.
        /// </value>
        public Form Form { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animator"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public Animator( Form form )
        {
            Form = form;
            Form.Load += Form_Load;
            Form.VisibleChanged += Form_VisibleChanged;
            Form.Closing += Form_Closing;
            Duration = _DEFAULT_DURATION;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.Animator" /> class.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="method">The method.</param>
        /// <param name="duration">The duration.</param>
        public Animator( Form form, AnimationMethod method, int duration )
            : this( form )
        {
            Method = method;
            Duration = duration;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.Animator" /> class.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="method">The method.</param>
        /// <param name="direction">The direction.</param>
        /// <param name="duration">The duration.</param>
        public Animator( Form form, AnimationMethod method, AnimationDirection direction, int duration )
            : this( form, method, duration )
        {
            Direction = direction;
        }

        /// <summary>
        /// The aw hide
        /// </summary>
        private const int _AW_HIDE = 0x10000;

        /// <summary>
        /// The aw activate
        /// </summary>
        private const int _AW_ACTIVATE = 0x20000;

        /// <summary>
        /// The default duration
        /// </summary>
        private const int _DEFAULT_DURATION = 250;

        /// <summary>
        /// Handles the Load event of the Form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form_Load( object sender, EventArgs e )
        {
            if( ( Form.MdiParent == null )
               || ( Method != AnimationMethod.Fade ) )
            {
                NativeMethods.AnimateWindow( Form.Handle, Duration, _AW_ACTIVATE | (int)Method | (int)Direction );
            }
        }

        /// <summary>
        /// Handles the VisibleChanged event of the Form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form_VisibleChanged( object sender, EventArgs e )
        {
            if( Form.MdiParent == null )
            {
                var _flags = (int)Method | (int)Direction;
                if( Form.Visible )
                {
                    _flags |= _AW_ACTIVATE;
                }
                else
                {
                    _flags |= _AW_HIDE;
                }

                NativeMethods.AnimateWindow( Form.Handle, Duration, _flags );
            }
        }

        /// <summary>
        /// Handles the Closing event of the Form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void Form_Closing( object sender, CancelEventArgs e )
        {
            if( !e.Cancel )
            {
                if( ( Form.MdiParent == null )
                   || ( Method != AnimationMethod.Fade ) )
                {
                    NativeMethods.AnimateWindow( Form.Handle, Duration, _AW_HIDE | (int)Method | (int)Direction );
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public enum AnimationMethod
        {
            /// <summary>
            /// The roll
            /// </summary>
            Roll = 0x0,

            /// <summary>
            /// The center
            /// </summary>
            Center = 0x10,

            /// <summary>
            /// The slide
            /// </summary>
            Slide = 0x40000,

            /// <summary>
            /// The fade
            /// </summary>
            Fade = 0x80000
        }

        /// <summary>
        /// 
        /// </summary>
        [ Flags ]
        public enum AnimationDirection
        {
            /// <summary>
            /// The right
            /// </summary>
            Right = 0x1,

            /// <summary>
            /// The left
            /// </summary>
            Left = 0x2,

            /// <summary>
            /// Down
            /// </summary>
            Down = 0x4,

            /// <summary>
            /// Up
            /// </summary>
            Up = 0x8
        }
    }
}