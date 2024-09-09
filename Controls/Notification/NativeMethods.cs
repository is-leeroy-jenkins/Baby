﻿// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="NativeMethods.cs" company="Terry D. Eppler">
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
//   NativeMethods.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary> </summary>
    internal static class NativeMethods
    {
        /// <summary> Gets the handle of the window that currently has focus. </summary>
        /// <returns> The handle of the window that currently has focus. </returns>
        [ DllImport( "user32" ) ]
        internal static extern IntPtr GetForegroundWindow( );

        /// <summary> Activates the specified window. </summary>
        /// <param name="hWnd"> The handle of the window to be focused. </param>
        /// <returns> True if the window was focused; False otherwise. </returns>
        [ DllImport( "user32" ) ]
        internal static extern bool SetForegroundWindow( IntPtr hWnd );

        /// <summary> Windows API function to animate a window. </summary>
        [ DllImport( "user32" ) ]
        internal static extern bool AnimateWindow( IntPtr hWnd, int dwTime, int dwFlags );

        [ DllImport( "Gdi32.dll", EntryPoint = "CreateRoundRectRgn" ) ]
        internal static extern IntPtr CreateRoundRectRgn( int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse,
            int nHeightEllipse );
    }
}