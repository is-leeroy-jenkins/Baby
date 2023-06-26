// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-02-2023
// ******************************************************************************************
// <copyright file="WebTip.cs" company="Terry D. Eppler">
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
//   WebTip.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using MetroSet_UI.Components;
    using MetroSet_UI.Enums;
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Components.MetroSetSetToolTip" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class ToolTip : MetroSetSetToolTip
    {
        /// <summary>
        /// Gets or sets the tip icon.
        /// </summary>
        /// <value>
        /// The tip icon.
        /// </value>
        public virtual ToolTipIcon TipIcon { get; set; } = ToolTipIcon.Info;

        /// <summary>
        /// Gets or sets the tip title.
        /// </summary>
        /// <value>
        /// The tip title.
        /// </value>
        public virtual string TipTitle { get; set; }

        /// <summary>
        /// Gets or sets the tip text.
        /// </summary>
        /// <value>
        /// The tip text.
        /// </value>
        public virtual string TipText { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolTip"/> class.
        /// </summary>
        public ToolTip( )
        {
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Browser";
            BackColor = Color.FromArgb( 5, 5, 5 );
            BorderColor = SystemColors.Highlight;
            ForeColor = Color.White;
            UseAnimation = true;
            UseFading = true;
            AutomaticDelay = 500;
            InitialDelay = 500;
            AutoPopDelay = 5000;
            ReshowDelay = 100;
            TipIcon = ToolTipIcon.Info;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        /// <param name="title">The title.</param>
        public ToolTip( Control control, string text, string title = "" )
            : this( )
        {
            TipTitle = title;
            TipText = text;
            SetText( control, TipText );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetBrowser.ToolTip" /> class.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="text">The text.</param>
        /// <param name="title">The title.</param>
        public ToolTip( Component component, string text, string title = "" )
            : this( )
        {
            TipTitle = title;
            TipText = text;
            SetText( component, text );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="toolItem">The tool item.</param>
        public ToolTip( ToolStripItem toolItem )
            : this( )
        {
            SetText( toolItem );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public ToolTip( Control control )
            : this( )
        {
            SetText( control );
        }

        /// <summary>
        /// Sets the animation.
        /// </summary>
        /// <param name="animate">if set to <c>true</c> [animate].</param>
        public virtual void SetAnimation( bool animate )
        {
            try
            {
                UseAnimation = animate;
                UseFading = animate;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the automatic delay.
        /// </summary>
        /// <param name="delay">The delay.</param>
        public virtual void SetAutomaticDelay( int delay = 500 )
        {
            if( delay > 0 )
            {
                try
                {
                    AutomaticDelay = delay;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Resets the duration.
        /// </summary>
        /// <param name="time">The time.</param>
        public virtual void ResetDuration( int time = 5000 )
        {
            if( time > 0 )
            {
                try
                {
                    AutoPopDelay = time;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the initial delay.
        /// </summary>
        /// <param name="delay">The delay.</param>
        public virtual void SetInitialDelay( int delay = 500 )
        {
            if( delay > 0 )
            {
                try
                {
                    InitialDelay = delay;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Resets the delay.
        /// </summary>
        /// <param name="reshow">The reshow.</param>
        public virtual void ResetDelay( int reshow = 100 )
        {
            if( reshow > 0 )
            {
                try
                {
                    ReshowDelay = reshow;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Res the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public virtual void ReTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="control">The control.</param>
        public virtual void SetText( Control control )
        {
            if( !string.IsNullOrEmpty( control?.Tag?.ToString( ) ) )
            {
                try
                {
                    RemoveAll( );
                    var _caption = control.Tag.ToString( );
                    SetToolTip( control, _caption );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="caption">The caption.</param>
        public virtual void SetText( Control control, string caption )
        {
            if( ( control != null )
               && !string.IsNullOrEmpty( caption ) )
            {
                try
                {
                    RemoveAll( );
                    SetToolTip( control, caption );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="item">The item.</param>
        public virtual void SetText( ToolStripItem item )
        {
            if( ( item.GetCurrentParent( ) != null )
               && ( item != null ) )
            {
                try
                {
                    Control _parent = item.GetCurrentParent( );
                    var _caption = item?.Tag?.ToString( );

                    if( !string.IsNullOrEmpty( _caption ) )
                    {
                        RemoveAll( );
                        SetText( _parent, _caption );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="component">The component.</param>
        public virtual void SetText( Component component )
        {
            if( component is Control _control )
            {
                try
                {
                    if( !string.IsNullOrEmpty( _control?.Tag?.ToString( ) ) )
                    {
                        var _caption = _control.Tag.ToString( );
                        RemoveAll( );
                        SetToolTip( _control, _caption );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="caption">The caption.</param>
        public virtual void SetText( Component component, string caption )
        {
            if( ( component != null )
               && !string.IsNullOrEmpty( caption ) )
            {
                try
                {
                    if( component is Control _control )
                    {
                        RemoveAll( );
                        SetToolTip( _control, caption );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Clears the text.
        /// </summary>
        public virtual void ClearText( )
        {
            try
            {
                TipText = string.Empty;
                TipTitle = string.Empty;
                RemoveAll( );
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