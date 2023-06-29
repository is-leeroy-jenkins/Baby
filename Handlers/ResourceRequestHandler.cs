﻿// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-29-2023
// ******************************************************************************************
// <copyright file="ResourceRequestHandler.cs" company="Terry D. Eppler">
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
//   ResourceRequestHandler.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;
    using CefSharp;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CefSharp.IResourceRequestHandler" />
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class ResourceRequestHandler : IResourceRequestHandler
    {
        /// <summary>
        /// The browser
        /// </summary>
        private readonly WebBrowser _webBrowser;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourceRequestHandler"/>
        /// class.
        /// </summary>
        /// <param name="form">The form.</param>
        public ResourceRequestHandler( Form form )
        {
            _webBrowser = form as WebBrowser;
        }

        /// <summary>
        /// Gets the cookie access filter.
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public ICookieAccessFilter GetCookieAccessFilter( IWebBrowser chromiumWebBrowser,
            IBrowser browser, IFrame frame, IRequest request )
        {
            return null;
        }

        /// <summary>
        /// Gets the resource handler.
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public IResourceHandler GetResourceHandler( IWebBrowser chromiumWebBrowser,
            IBrowser browser, IFrame frame, IRequest request )
        {
            return null;
        }

        /// <summary>
        /// Gets the resource response filter.
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        public IResponseFilter GetResourceResponseFilter( IWebBrowser chromiumWebBrowser,
            IBrowser browser, IFrame frame, IRequest request, IResponse response )
        {
            return null;
        }

        /// <summary>
        /// Called when [before resource load].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="callback">The callback.</param>
        /// <returns></returns>
        public CefReturnValue OnBeforeResourceLoad( IWebBrowser chromiumWebBrowser,
            IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback )
        {
            var _tab = _webBrowser.GetTabByBrowser( chromiumWebBrowser );
            if( _tab?.ReferringUrl != null )
            {
                request.SetReferrer( _tab.ReferringUrl, ReferrerPolicy.Default );
            }

            return CefReturnValue.Continue;
        }

        /// <summary>
        /// Called when [protocol execution].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public bool OnProtocolExecution( IWebBrowser chromiumWebBrowser, IBrowser browser,
            IFrame frame, IRequest request )
        {
            return true;
        }

        /// <summary>
        /// Called when [resource load complete].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <param name="status">The status.</param>
        /// <param name="receivedContentLength">Length of the received content.</param>
        public void OnResourceLoadComplete( IWebBrowser chromiumWebBrowser, IBrowser browser,
            IFrame frame, IRequest request, IResponse response, UrlRequestStatus status,
            long receivedContentLength )
        {
            var _code = response.StatusCode;
            if( !frame.IsValid )
            {
                return;
            }

            if( _code == 404 )
            {
                if( !request.Url.IsLocalhost( ) )
                {
                    frame.LoadUrl( "http://web.archive.org/web/*/" + request.Url );
                }
                else
                {
                    frame.LoadUrl( BrowserConfig.FileNotFoundUrl
                        + "?path="
                        + request.Url.UrlEncode( ) );
                }
            }
            else if( request.Url.IsFileOffline( ) )
            {
                var _path = request.Url.FileUrlToPath( );
                if( _path.FileNotExists( ) )
                {
                    frame.LoadUrl( BrowserConfig.FileNotFoundUrl + "?path=" + _path.UrlEncode( ) );
                }
            }
            else
            {
                if( ( _code == 444 )
                   || ( ( _code >= 500 ) && ( _code <= 599 ) ) )
                {
                    frame.LoadUrl( BrowserConfig.CannotConnectUrl );
                }
            }
        }

        /// <summary>
        /// Called when [resource redirect].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <param name="newUrl">The new URL.</param>
        public void OnResourceRedirect( IWebBrowser chromiumWebBrowser, IBrowser browser,
            IFrame frame, IRequest request, IResponse response, ref string newUrl )
        {
        }

        /// <summary>
        /// Called when [resource response].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        public bool OnResourceResponse( IWebBrowser chromiumWebBrowser, IBrowser browser,
            IFrame frame, IRequest request, IResponse response )
        {
            return false;
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs application-defined tasks associated with freeing,
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose( )
        {
        }
    }
}