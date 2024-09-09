﻿// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="BaseStyledPanel.cs" company="Terry D. Eppler">
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
//   BaseStyledPanel.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.ContainerControl" />
    [ ToolboxItem( false ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BaseStyledPanel : ContainerControl
    {
        /// <summary>
        /// Gets the tool strip renderer.
        /// </summary>
        /// <value>
        /// The tool strip renderer.
        /// </value>
        [ Browsable( false ) ]
        public ToolStripProfessionalRenderer ToolStripRenderer
        {
            get
            {
                return Renderer;
            }
        }

        /// <summary>
        /// Gets a value indicating whether [use themes].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use themes]; otherwise, <c>false</c>.
        /// </value>
        [ Browsable( false ) ]
        [ DefaultValue( true ) ]
        public bool UseThemes
        {
            get
            {
                if( VisualStyleRenderer.IsSupported
                    && VisualStyleInformation.IsSupportedByOS )
                {
                    return Application.RenderWithVisualStyles;
                }

                return false;
            }
        }

        /// <summary>
        /// The renderer
        /// </summary>
        private static ToolStripProfessionalRenderer Renderer;

        /// <summary>
        /// Occurs when [theme changed].
        /// </summary>
        public event EventHandler ThemeChanged;

        /// <inheritdoc />
        /// <summary>
        /// Initializes the <see cref="T:BaseStyledPanel" /> class.
        /// </summary>
        static BaseStyledPanel( )
        {
            Renderer = new ToolStripProfessionalRenderer( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BaseStyledPanel" /> class.
        /// </summary>
        public BaseStyledPanel( )
        {
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
            SetStyle( ControlStyles.UserPaint, true );
        }

        /// <summary>
        /// Updates the renderer.
        /// </summary>
        private void UpdateRenderer( )
        {
            Renderer.ColorTable.UseSystemColors = !UseThemes;
        }

        /// <inheritdoc />
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SystemColorsChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnSystemColorsChanged( EventArgs e )
        {
            try
            {
                base.OnSystemColorsChanged( e );
                UpdateRenderer( );
                Invalidate( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Raises the <see cref="E:ThemeChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnThemeChanged( EventArgs e )
        {
            ThemeChanged?.Invoke( this, e );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}