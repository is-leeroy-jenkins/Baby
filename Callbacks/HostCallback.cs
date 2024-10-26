﻿// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="HostCallback.cs" company="Terry D. Eppler">
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
//   HostCallback.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;

    /// <summary>
    /// functions in this class are accessible
    /// by JS using the code `host.X()`
    /// </summary>
    [ SuppressMessage( "ReSharper", "InconsistentlySynchronizedField" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class HostCallback
    {
        /// <summary>
        /// The browser
        /// </summary>
        private readonly WebBrowser _webBrowser;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HostCallback"/> class.
        /// </summary>
        /// <param name="webBrowser">The webBrowser.</param>
        public HostCallback( Window webBrowser )
        {
            _webBrowser = webBrowser as WebBrowser;
        }

        /// <summary>
        /// Adds the new browser tab.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="focusNewTab">
        /// if set to <c>true</c> [focus new tab].
        /// </param>
        public void AddNewBrowserTab( string url, bool focusNewTab = true )
        {
            _webBrowser.AddNewBrowserTab( url, focusNewTab );
        }

        /// <summary>
        /// Cancels the download.
        /// </summary>
        /// <param name="downloadId">
        /// The download identifier.
        /// </param>
        /// <returns>
        /// </returns>
        public bool CancelDownload( int downloadId )
        {
            lock( _webBrowser.CancelRequests )
            {
                if( !_webBrowser.CancelRequests.Contains( downloadId ) )
                {
                    _webBrowser.CancelRequests.Add( downloadId );
                }
            }

            return true;
        }

        /// <summary>
        /// Refreshes the active tab.
        /// </summary>
        public void RefreshActiveTab( )
        {
            _webBrowser.RefreshActiveTab( );
        }
    }
}