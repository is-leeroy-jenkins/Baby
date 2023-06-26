// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="BrowserTabStripCloseButton.cs" company="Terry D. Eppler">
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
//   BrowserTabStripCloseButton.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public class BrowserTabStripCloseButton
    {
        /// <summary>
        /// The is mouse over
        /// </summary>
        public bool IsMouseOver;

        /// <summary>
        /// The is visible
        /// </summary>
        public bool IsVisible;

        /// <summary>
        /// The rect
        /// </summary>
        public Rectangle Rect = Rectangle.Empty;

        /// <summary>
        /// The redraw rect
        /// </summary>
        public Rectangle RedrawRect = Rectangle.Empty;

        /// <summary>
        /// The renderer
        /// </summary>
        public ToolStripProfessionalRenderer Renderer;

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserTabStripCloseButton"/> class.
        /// </summary>
        /// <param name="renderer">The renderer.</param>
        public BrowserTabStripCloseButton( ToolStripProfessionalRenderer renderer )
        {
            Renderer = renderer;
        }

        /// <summary>
        /// Calculates the bounds.
        /// </summary>
        /// <param name="tab">The tab.</param>
        public void CalculateBounds( BrowserTabStripItem tab )
        {
            Rect = new Rectangle( (int)tab.StripRect.Right - 20, (int)tab.StripRect.Top + 5, 15,
                15 );

            RedrawRect = new Rectangle( Rect.X - 2, Rect.Y - 2, Rect.Width + 4, Rect.Height + 4 );
        }

        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public void Draw( Graphics g )
        {
            if( IsVisible )
            {
                var _color = IsMouseOver
                    ? Color.White
                    : Color.DarkGray;

                g.FillRectangle( Brushes.White, Rect );

                if( IsMouseOver )
                {
                    g.FillEllipse( Brushes.IndianRed, Rect );
                }

                var _num = 4;
                var _pen = new Pen( _color, 1.6f );

                g.DrawLine( _pen, Rect.Left + _num, Rect.Top + _num, Rect.Right - _num,
                    Rect.Bottom - _num );

                g.DrawLine( _pen, Rect.Right - _num, Rect.Top + _num, Rect.Left + _num,
                    Rect.Bottom - _num );

                _pen.Dispose( );
            }
        }
    }
}