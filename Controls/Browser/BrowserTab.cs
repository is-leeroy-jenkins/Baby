// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-26-2023
// ******************************************************************************************
// <copyright file="BrowserTab.cs" company="Terry D. Eppler">
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
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   BrowserTab.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using CefSharp.WinForms;
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// POCO created for holding data per tab
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MissingBlankLines" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public class BrowserTab 
    {
        // ReSharper disable once MemberCanBeInternal
        public bool IsOpen;
        public string OriginalUrl;
        public string CurrentUrl;
        public string Title;
        public string ReferringUrl;
        public DateTime DateCreated;
        public BrowserTabStripItem Tab;
        public ChromiumWebBrowser Browser;
    }
}
