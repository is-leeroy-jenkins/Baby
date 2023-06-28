// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-27-2023
// ******************************************************************************************
// <copyright file="WebBrowser.cs" company="Terry D. Eppler">
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
//   WebBrowser.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;
    using System.Windows.Forms;
    using System.Threading;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.IO;
    using System.Web;
    using CefSharp;
    using CefSharp.WinForms;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Reflection;

    /// <inheritdoc />
    /// <summary>
    /// The main BudgetBrowser form, supporting multiple tabs.
    /// We used the x86 version of CefSharp, so the app works on 32-bit and 64-bit machines.
    /// If you would only like to support 64-bit machines, simply change the DLL references.
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWithPrivateSetter" ) ]
    public partial class WebBrowser : Form
    {
        /// <summary>
        /// The new tab strip
        /// </summary>
        private BrowserTabStripItem _newTabItem;

        /// <summary>
        /// The download strip
        /// </summary>
        private BrowserTabStripItem _downloadStrip;

        /// <summary>
        /// The current full URL
        /// </summary>
        private string _originalUrl;

        /// <summary>
        /// The current clean URL
        /// </summary>
        private string _finalUrl;

        /// <summary>
        /// The current title
        /// </summary>
        private string _currentTitle;

        /// <summary>
        /// The download handler
        /// </summary>
        private DownloadHandler _downloadHandler;

        /// <summary>
        /// The context menu handler
        /// </summary>
        private ContextMenuHandler _contextMenuHandler;

        /// <summary>
        /// The life span handler
        /// </summary>
        private LifeSpanHandler _lifeSpanHandler;

        /// <summary>
        /// The keyboard handler
        /// </summary>
        private KeyboardHandler _keyboardHandler;

        /// <summary>
        /// The request handler
        /// </summary>
        private RequestHandler _requestHandler;

        /// <summary>
        /// The application path
        /// </summary>
        private string _path = Path.GetDirectoryName( Application.ExecutablePath ) + @"\";

        /// <summary>
        /// The search open
        /// </summary>
        private bool _isSearchOpen;

        /// <summary>
        /// The last search
        /// </summary>
        private string _lastSearch = "";

        /// <summary>
        /// The old window state
        /// </summary>
        private FormWindowState _oldWindowState;

        /// <summary>
        /// The old border style
        /// </summary>
        private FormBorderStyle _oldBorderStyle;

        /// <summary>
        /// The is full screen
        /// </summary>
        private bool _isFullScreen;

        /// <summary>
        /// The download cancel requests
        /// </summary>
        private List<int> _downloadCancelRequests;

        /// <summary>
        /// The downloads
        /// </summary>
        private Dictionary<int, DownloadItem> _downloads;

        /// <summary>
        /// Gets or sets the index of the current.
        /// </summary>
        /// <value>
        /// The index of the current.
        /// </value>
        private int CurrentIndex
        {
            get { return TabPages.Items.IndexOf( TabPages.SelectedItem ); }
            set { TabPages.SelectedItem = TabPages.Items[ value ]; }
        }

        /// <summary>
        /// Gets the last index.
        /// </summary>
        /// <value>
        /// The last index.
        /// </value>
        private int LastIndex
        {
            get { return TabPages.Items.Count - 2; }
        }

        /// <summary>
        /// The instance
        /// </summary>
        public static Form Instance;

        /// <summary>
        /// The assembly
        /// </summary>
        public static Assembly Assembly;

        /// <summary>
        /// The host
        /// </summary>
        public HostHandler Host;

        /// <summary>
        /// The download names
        /// </summary>
        public Dictionary<int, string> DownloadNames;

        /// <summary>
        /// Gets the cancel requests.
        /// </summary>
        /// <value>
        /// The cancel requests.
        /// </value>
        public List<int> CancelRequests
        {
            get { return _downloadCancelRequests; }
        }

        /// <summary>
        /// Gets the downloads.
        /// </summary>
        /// <value>
        /// The downloads.
        /// </value>
        public Dictionary<int, DownloadItem> Downloads
        {
            get { return _downloads; }
        }

        /// <summary>
        /// Gets the current tab.
        /// </summary>
        /// <value>
        /// The current tab.
        /// </value>
        public BrowserTab CurrentTab
        {
            get
            {
                return (BrowserTab)TabPages.SelectedItem?.Tag;
            }
        }

        /// <summary>
        /// Gets the duration of the current tab loading.
        /// </summary>
        /// <value>
        /// The duration of the current tab loading.
        /// </value>
        public int CurrentTabLoadingDuration
        {
            get
            {
                if( TabPages.SelectedItem?.Tag != null )
                {
                    var _loadTime =
                        (int)( DateTime.Now - CurrentTab.DateCreated ).TotalMilliseconds;

                    return _loadTime;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets the current browser.
        /// </summary>
        /// <value>
        /// The current browser.
        /// </value>
        public ChromiumWebBrowser CurrentBrowser
        {
            get { return ( (BrowserTab)TabPages.SelectedItem?.Tag )?.Browser; }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetBrowser.WebBrowser" /> class.
        /// </summary>
        public WebBrowser( )
        {
            Instance = this;
            InitializeComponent( );
            InitBrowser( );
            SetFormTitle( null );
        }

        /// <summary>
        /// embedding the resource using the
        /// Visual Studio designer results in a blurry icon.
        /// the best way to get a non-blurry icon for Windows 7 apps.
        /// </summary>
        private void InitAppIcon( )
        {
            Assembly = Assembly.GetAssembly( typeof( WebBrowser ) );
            var _assembly =
                @"C:\Users\terry\source\repos\BudgetBrowser\Resources\Images\budgetbrowser.ico";

            using var _stream = File.Open( _assembly, FileMode.Open );
            Icon = new Icon( _stream, new Size( 64, 64 ) );
        }

        /// <summary>
        /// these hot keys work when the user is focused on the .NET form and its controls,
        /// AND when the user is focused on the browser (CefSharp portion)
        /// </summary>
        private void InitHotkeys( )
        {
            // browser hot keys
            KeyboardHandler.AddHotKey( this, CloseActiveTab, Keys.W, true );
            KeyboardHandler.AddHotKey( this, CloseActiveTab, Keys.Escape, true );
            KeyboardHandler.AddHotKey( this, AddBlankWindow, Keys.N, true );
            KeyboardHandler.AddHotKey( this, AddBlankTab, Keys.T, true );
            KeyboardHandler.AddHotKey( this, RefreshActiveTab, Keys.F5 );
            KeyboardHandler.AddHotKey( this, OpenDeveloperTools, Keys.F12 );
            KeyboardHandler.AddHotKey( this, NextTab, Keys.Tab, true );
            KeyboardHandler.AddHotKey( this, PreviousTab, Keys.Tab, true, true );

            // search hot keys
            KeyboardHandler.AddHotKey( this, OpenSearch, Keys.F, true );
            KeyboardHandler.AddHotKey( this, CloseSearch, Keys.Escape );
            KeyboardHandler.AddHotKey( this, StopActiveTab, Keys.Escape );
            KeyboardHandler.AddHotKey( this, ToggleFullscreen, Keys.F11 );
        }

        /// <summary>
        /// we activate all the tooltips stored in the Tag property of the buttons
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void InitTooltips( Control.ControlCollection parent )
        {
            foreach( Control _ui in parent )
            {
                if( _ui is Button _btn )
                {
                    if( _btn.Tag != null )
                    {
                        System.Windows.Forms.ToolTip _tip = new ToolTip( );
                        _tip.ReshowDelay = _tip.InitialDelay = 200;
                        _tip.ShowAlways = true;
                        _tip.SetToolTip( _btn, _btn.Tag.ToString( ) );
                    }
                }

                if( _ui is Panel _panel )
                {
                    InitTooltips( _panel.Controls );
                }
            }
        }

        /// <summary>
        /// this is done just once, to globally initialize CefSharp/CEF
        /// </summary>
        private void InitBrowser( )
        {
            //CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            var _settings = new CefSettings( );
            _settings.RegisterScheme( new CefCustomScheme
            {
                SchemeName = BrowserConfig.InternalURL,
                SchemeHandlerFactory = new SchemeHandlerFactory( )
            } );

            _settings.UserAgent = BrowserConfig.UserAgent;
            _settings.AcceptLanguageList = BrowserConfig.AcceptLanguage;
            _settings.IgnoreCertificateErrors = true;
            _settings.CachePath = GetApplicationDirectory( "Cache" );
            if( BrowserConfig.Proxy )
            {
                CefSharpSettings.Proxy = new ProxyOptions( BrowserConfig.ProxyIP,
                    BrowserConfig.ProxyPort.ToString( ), BrowserConfig.ProxyUsername,
                    BrowserConfig.ProxyPassword, BrowserConfig.ProxyBypassList );
            }

            Cef.Initialize( _settings );
            _downloadHandler = new DownloadHandler( this );
            _lifeSpanHandler = new LifeSpanHandler( this );
            _contextMenuHandler = new ContextMenuHandler( this );
            _keyboardHandler = new KeyboardHandler( this );
            _requestHandler = new RequestHandler( this );
            InitDownloads( );
            Host = new HostHandler( this );
            AddNewBrowser( TabItem, BrowserConfig.HomepageURL );
        }

        /// <summary>
        /// this is done every time a new tab is opened
        /// </summary>
        /// <param name="browser">
        /// The browser.
        /// </param>
        private void ConfigureBrowser( ChromiumWebBrowser browser )
        {
            var _config = new BrowserSettings( );

            //_config.FileAccessFromFileUrls = (!CrossDomainSecurity).ToCefState();
            //_config.UniversalAccessFromFileUrls = (!CrossDomainSecurity).ToCefState();
            //_config.WebSecurity = WebSecurity.ToCefState();
            _config.WebGl = BrowserConfig.WebGL.ToCefState( );
            browser.BrowserSettings = _config;
        }

        /// <summary>
        /// Calculates the download path.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public string GetDownloadPath( DownloadItem item )
        {
            return item.SuggestedFileName;
        }

        /// <summary>
        /// Finds the text on page.
        /// </summary>
        /// <param name="next">if set to <c>true</c> [next].</param>
        private void FindTextOnPage( bool next = true )
        {
            var _first = _lastSearch != SearchPanelTextBox.Text;
            _lastSearch = SearchPanelTextBox.Text;
            if( _lastSearch.CheckIfValid( ) )
            {
                CurrentBrowser.GetBrowser( ).Find( _lastSearch, true, false, !_first );
            }
            else
            {
                CurrentBrowser.GetBrowser( ).StopFinding( true );
            }

            SearchPanelTextBox.Focus( );
        }

        /// <summary>
        /// Gets all tabs.
        /// </summary>
        /// <returns></returns>
        public List<BrowserTab> GetAllTabs( )
        {
            var _tabs = new List<BrowserTab>( );
            foreach( BrowserTabStripItem _tabPage in TabPages.Items )
            {
                if( _tabPage.Tag != null )
                {
                    _tabs.Add( (BrowserTab)_tabPage.Tag );
                }
            }

            return _tabs;
        }

        /// <summary>
        /// Gets the tab by browser.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <returns></returns>
        public BrowserTab GetTabByBrowser( IWebBrowser browser )
        {
            foreach( BrowserTabStripItem _tab2 in TabPages.Items )
            {
                var _tab = (BrowserTab)_tab2.Tag;
                if( ( _tab != null )
                   && ( _tab.Browser == browser ) )
                {
                    return _tab;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the application directory.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private static string GetApplicationDirectory( string name )
        {
            var _winXpDir = @"C:\Documents and Settings\All Users\Application Data\";
            if( Directory.Exists( _winXpDir ) )
            {
                return _winXpDir + BrowserConfig.Branding + @"\" + name + @"\";
            }

            return @"C:\ProgramData\" + BrowserConfig.Branding + @"\" + name + @"\";
        }

        /// <summary>
        /// Gets the resource stream.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="withNamespace">if set to <c>true</c> [with namespace].</param>
        /// <returns></returns>
        public Stream GetResourceStream( string filename, bool withNamespace = true )
        {
            try
            {
                return Assembly.GetManifestResourceStream( "BudgetBrowser.Resources." + filename );
            }
            catch( Exception _ex )
            {
                //ignore exception
            }

            return null;
        }

        /// <summary>
        /// Sets the tab title.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <param name="text">The text.</param>
        private void SetTabTitle( ChromiumWebBrowser browser, string text )
        {
            text = text.Trim( );
            if( IsBlank( text ) )
            {
                text = "New Tab";
            }

            // save text
            browser.Tag = text;

            // get tab of given browser
            var _tabStrip = (BrowserTabStripItem)browser.Parent;
            _tabStrip.Title = text;

            // if current tab
            if( browser == CurrentBrowser )
            {
                SetFormTitle( text );
            }
        }

        /// <summary>
        /// Sets the form title.
        /// </summary>
        /// <param name="tabName">Name of the tab.</param>
        private void SetFormTitle( string tabName )
        {
            if( tabName.CheckIfValid( ) )
            {
                Text = tabName + " - " + BrowserConfig.Branding;
                _currentTitle = tabName;
            }
            else
            {
                Text = BrowserConfig.Branding;
                _currentTitle = "New Tab";
            }
        }

        /// <summary>
        /// Sets the form URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void SetFormUrl( string url )
        {
            _originalUrl = url;
            _finalUrl = CleanUrl( url );
            PrimaryTextBox.Text = _finalUrl;
            CurrentTab.CurrentUrl = _originalUrl;
            CloseSearch( );
        }

        /// <summary>
        /// Loads the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void LoadUrl( string url )
        {
            var _newUrl = url;
            var _urlLower = url.Trim( ).ToLower( );

            // UI
            SetTabTitle( CurrentBrowser, "Loading..." );

            // load page
            if( _urlLower == "localhost" )
            {
                _newUrl = "http://localhost/";
            }
            else if( url.CheckIfFilePath( )
                    || url.CheckIfFilePath2( ) )
            {
                _newUrl = url.PathToUrl( );
            }
            else
            {
                Uri.TryCreate( url, UriKind.Absolute, out var _outUri );
                if( !( _urlLower.StartsWith( "http" )
                       || _urlLower.StartsWith( BrowserConfig.InternalURL ) ) )
                {
                    if( ( _outUri == null )
                       || ( _outUri.Scheme != Uri.UriSchemeFile ) )
                    {
                        _newUrl = "http://" + url;
                    }
                }

                if( _urlLower.StartsWith( BrowserConfig.InternalURL + ":" )
                   ||

                   // load URL if it seems valid
                   ( Uri.TryCreate( _newUrl, UriKind.Absolute, out _outUri )
                       && ( ( ( ( _outUri.Scheme == Uri.UriSchemeHttp )
                                   || ( _outUri.Scheme == Uri.UriSchemeHttps ) )
                               && _newUrl.Contains( "." ) )
                           || ( _outUri.Scheme == Uri.UriSchemeFile ) ) ) )
                {
                }
                else
                {
                    // run search if unknown URL
                    _newUrl = BrowserConfig.SearchURL + HttpUtility.UrlEncode( url );
                }
            }

            // load URL
            CurrentBrowser.Load( _newUrl );

            // set URL in UI
            SetFormUrl( _newUrl );

            // always enable back btn
            EnableBackButton( true );
            EnableForwardButton( false );
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        public void InvokeIfNeeded( Action action )
        {
            if( InvokeRequired )
            {
                BeginInvoke( action );
            }
            else
            {
                action.Invoke( );
            }
        }

        /// <summary>
        /// Waits for browser to initialize.
        /// </summary>
        /// <param name="browser">
        /// The browser.
        /// </param>
        public void WaitForBrowserToInitialize( ChromiumWebBrowser browser )
        {
            while( !browser.IsBrowserInitialized )
            {
                Thread.Sleep( 100 );
            }
        }

        /// <summary>
        /// Enables the back button.
        /// </summary>
        /// <param name="canGoBack">if set to <c>true</c> [can go back].</param>
        private void EnableBackButton( bool canGoBack )
        {
            InvokeIfNeeded( ( ) => PreviousSearchButton.Enabled = canGoBack );
        }

        /// <summary>
        /// Enables the forward button.
        /// </summary>
        /// <param name="canGoForward">if set to <c>true</c> [can go forward].</param>
        private void EnableForwardButton( bool canGoForward )
        {
            InvokeIfNeeded( ( ) => NextSearchButton.Enabled = canGoForward );
        }

        /// <summary>
        /// Cleans the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private string CleanUrl( string url )
        {
            if( url.BeginsWith( "about:" ) )
            {
                return "";
            }

            url = url.RemovePrefix( "http://" );
            url = url.RemovePrefix( "https://" );
            url = url.RemovePrefix( "file://" );
            url = url.RemovePrefix( "/" );
            return url.UrlEncode( );
        }

        /// <summary>
        /// Determines whether the specified URL is blank.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        ///   <c>true</c> if the specified URL is blank; otherwise, <c>false</c>.
        /// </returns>
        private bool IsBlank( string url )
        {
            return ( url == "" ) || ( url == "about:blank" );
        }

        /// <summary>
        /// Determines whether [is blank or system] [the specified URL].
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        ///   <c>true</c> if [is blank or system] [the specified URL]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsBlankOrSystem( string url )
        {
            return ( url == "" )
                || url.BeginsWith( "about:" )
                || url.BeginsWith( "chrome:" )
                || url.BeginsWith( BrowserConfig.InternalURL + ":" );
        }

        /// <summary>
        /// Adds the blank window.
        /// </summary>
        public void AddBlankWindow( )
        {
            // open a new instance of the browser
            var _info = new ProcessStartInfo( Application.ExecutablePath, "" );

            //info.WorkingDirectory = workingDir ?? exePath.GetPathDir(true);
            _info.LoadUserProfile = true;
            _info.UseShellExecute = false;
            _info.RedirectStandardError = true;
            _info.RedirectStandardOutput = true;
            _info.RedirectStandardInput = true;
            Process.Start( _info );
        }

        /// <summary>
        /// Adds the blank tab.
        /// </summary>
        public void AddBlankTab( )
        {
            AddNewBrowserTab( "" );
            this.InvokeOnParent( delegate
            {
                PrimaryTextBox.Focus( );
            } );
        }

        /// <summary>
        /// Adds the new browser tab.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="focusNewTab">if set to <c>true</c> [focus new tab].</param>
        /// <param name="referringUrl">The referring URL.</param>
        /// <returns></returns>
        public ChromiumWebBrowser AddNewBrowserTab( string url, bool focusNewTab = true,
            string referringUrl = null )
        {
            return Invoke( delegate
            {
                // check if already exists
                foreach( BrowserTabStripItem _tab in TabPages.Items )
                {
                    var _tab2 = (BrowserTab)_tab.Tag;
                    if( ( _tab2 != null )
                       && ( _tab2.CurrentUrl == url ) )
                    {
                        TabPages.SelectedItem = _tab;
                        return _tab2.Browser;
                    }
                }

                var _tabStrip = new BrowserTabStripItem( );
                _tabStrip.Title = "New Tab";
                TabPages.Items.Insert( TabPages.Items.Count - 1, _tabStrip );
                _newTabItem = _tabStrip;
                var _newTab = AddNewBrowser( _newTabItem, url );
                _newTab.ReferringUrl = referringUrl;
                if( focusNewTab )
                {
                    timer1.Enabled = true;
                }

                return _newTab.Browser;
            } );
        }

        /// <summary>
        /// Adds the new browser.
        /// </summary>
        /// <param name="tabStrip">The tab strip.</param>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private BrowserTab AddNewBrowser( BrowserTabStripItem tabStrip, String url )
        {
            if( url == "" )
            {
                url = BrowserConfig.NewTabURL;
            }

            var _chromiumBrowser = new ChromiumWebBrowser( url );

            // set config
            ConfigureBrowser( _chromiumBrowser );

            // set layout
            _chromiumBrowser.Dock = DockStyle.Fill;
            tabStrip.Controls.Add( _chromiumBrowser );
            _chromiumBrowser.BringToFront( );

            // add events
            _chromiumBrowser.StatusMessage += OnStatusUpdated;
            _chromiumBrowser.LoadingStateChanged += OnLoadingStateChanged;
            _chromiumBrowser.TitleChanged += OnTitleChanged;
            _chromiumBrowser.LoadError += OnLoadError;
            _chromiumBrowser.AddressChanged += OnUrlChanged;
            _chromiumBrowser.DownloadHandler = _downloadHandler;
            _chromiumBrowser.MenuHandler = _contextMenuHandler;
            _chromiumBrowser.LifeSpanHandler = _lifeSpanHandler;
            _chromiumBrowser.KeyboardHandler = _keyboardHandler;
            _chromiumBrowser.RequestHandler = _requestHandler;

            // new tab obj
            var _browserTab = new BrowserTab
            {
                IsOpen = true,
                Browser = _chromiumBrowser,
                Tab = tabStrip,
                OriginalUrl = url,
                CurrentUrl = url,
                Title = "New Tab",
                DateCreated = DateTime.Now
            };

            // save tab obj in tabstrip
            tabStrip.Tag = _browserTab;
            if( url.StartsWith( BrowserConfig.InternalURL + ":" ) )
            {
                _chromiumBrowser.JavascriptObjectRepository.Register( "host", Host,
                    BindingOptions.DefaultBinder );
            }

            return _browserTab;
        }

        /// <summary>
        /// we must store download metadata in a list,
        /// since CefSharp does not
        /// </summary>
        private void InitDownloads( )
        {
            _downloads = new Dictionary<int, DownloadItem>( );
            DownloadNames = new Dictionary<int, string>( );
            _downloadCancelRequests = new List<int>( );
        }

        /// <summary>
        /// Updates the download item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void UpdateDownloadItem( DownloadItem item )
        {
            lock( _downloads )
            {
                // SuggestedFileName comes full only in the first attempt so keep it somewhere
                if( item.SuggestedFileName != "" )
                {
                    DownloadNames[ item.Id ] = item.SuggestedFileName;
                }

                // Set it back if it is empty
                if( ( item.SuggestedFileName == "" )
                   && DownloadNames.TryGetValue( item.Id, out var _name ) )
                {
                    item.SuggestedFileName = _name;
                }

                _downloads[ item.Id ] = item;

                //UpdateSnipProgress();
            }
        }

        /// <summary>
        /// Downloadses the in progress.
        /// </summary>
        /// <returns></returns>
        public bool DownloadsInProgress( )
        {
            foreach( var _item in _downloads.Values )
            {
                if( _item.IsInProgress )
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Refreshes the active tab.
        /// </summary>
        public void RefreshActiveTab( )
        {
            CurrentBrowser.Load( CurrentBrowser.Address );
        }

        /// <summary>
        /// Closes the active tab.
        /// </summary>
        public void CloseActiveTab( )
        {
            if( CurrentTab != null/* && TabPages.Items.Count > 2*/ )
            {
                // remove tab and save its index
                var _index = TabPages.Items.IndexOf( TabPages.SelectedItem );
                TabPages.RemoveTab( TabPages.SelectedItem );

                // keep tab at same index focussed
                if( TabPages.Items.Count - 1 > _index )
                {
                    TabPages.SelectedItem = TabPages.Items[ _index ];
                }
            }
        }

        /// <summary>
        /// Opens the downloads tab.
        /// </summary>
        public void OpenDownloadsTab( )
        {
            if( ( _downloadStrip != null )
               && ( ( (ChromiumWebBrowser)_downloadStrip.Controls[ 0 ] ).Address
                   == BrowserConfig.DownloadsURL ) )
            {
                TabPages.SelectedItem = _downloadStrip;
            }
            else
            {
                var _brw = AddNewBrowserTab( BrowserConfig.DownloadsURL );
                _downloadStrip = (BrowserTabStripItem)_brw.Parent;
            }
        }

        /// <summary>
        /// Opens the search.
        /// </summary>
        private void OpenSearch( )
        {
            if( !_isSearchOpen )
            {
                _isSearchOpen = true;
                InvokeIfNeeded( delegate
                {
                    SearchPanel.Visible = true;
                    SearchPanelTextBox.Text = _lastSearch;
                    SearchPanelTextBox.Focus( );
                    SearchPanelTextBox.SelectAll( );
                } );
            }
            else
            {
                InvokeIfNeeded( delegate
                {
                    SearchPanelTextBox.Focus( );
                    SearchPanelTextBox.SelectAll( );
                } );
            }
        }

        /// <summary>
        /// Closes the search.
        /// </summary>
        private void CloseSearch( )
        {
            if( _isSearchOpen )
            {
                _isSearchOpen = false;
                InvokeIfNeeded( delegate
                {
                    SearchPanel.Visible = false;
                    CurrentBrowser.GetBrowser( ).StopFinding( true );
                } );
            }
        }

        /// <summary>
        /// Toggles the fullscreen.
        /// </summary>
        private void ToggleFullscreen( )
        {
            if( !_isFullScreen )
            {
                _oldWindowState = WindowState;
                _oldBorderStyle = FormBorderStyle;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                _isFullScreen = true;
            }
            else
            {
                FormBorderStyle = _oldBorderStyle;
                WindowState = _oldWindowState;
                _isFullScreen = false;
            }
        }

        /// <summary>
        /// Stops the active tab.
        /// </summary>
        private void StopActiveTab( )
        {
            CurrentBrowser.Stop( );
        }

        /// <summary>
        /// Determines whether [is on first tab].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is on first tab]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsOnFirstTab( )
        {
            return TabPages.SelectedItem == TabPages.Items[ 0 ];
        }

        /// <summary>
        /// Determines whether [is on last tab].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is on last tab]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsOnLastTab( )
        {
            return TabPages.SelectedItem == TabPages.Items[ TabPages.Items.Count - 2 ];
        }

        /// <summary>
        /// Nexts the tab.
        /// </summary>
        private void NextTab( )
        {
            if( IsOnLastTab( ) )
            {
                CurrentIndex = 0;
            }
            else
            {
                CurrentIndex++;
            }
        }

        /// <summary>
        /// Previouses the tab.
        /// </summary>
        private void PreviousTab( )
        {
            if( IsOnFirstTab( ) )
            {
                CurrentIndex = LastIndex;
            }
            else
            {
                CurrentIndex--;
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            InitAppIcon( );
            InitTooltips( Controls );
            InitHotkeys( );
        }

        /// <summary>
        /// Called when [URL changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="AddressChangedEventArgs"/> instance containing the event data.</param>
        private void OnUrlChanged( object sender, AddressChangedEventArgs e )
        {
            InvokeIfNeeded( ( ) =>
            {
                // if current tab
                if( sender == CurrentBrowser )
                {
                    if( !WebUtils.IsFocused( PrimaryTextBox ) )
                    {
                        SetFormUrl( e.Address );
                    }

                    EnableBackButton( CurrentBrowser.CanGoBack );
                    EnableForwardButton( CurrentBrowser.CanGoForward );
                    SetTabTitle( (ChromiumWebBrowser)sender, "Loading..." );
                    RefreshSearchButton.Visible = false;
                    StopSearchButton.Visible = true;
                    CurrentTab.DateCreated = DateTime.Now;
                }
            } );
        }

        /// <summary>
        /// Called when [load error].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="LoadErrorEventArgs"/> instance containing the event data.</param>
        private void OnLoadError( object sender, LoadErrorEventArgs e )
        {
            // ("Load Error:" + e.ErrorCode + ";" + e.ErrorText);
        }

        /// <summary>
        /// Called when [title changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="TitleChangedEventArgs"/>
        /// instance containing the event data.</param>
        private void OnTitleChanged( object sender, TitleChangedEventArgs e )
        {
            InvokeIfNeeded( ( ) =>
            {
                var _browser = (ChromiumWebBrowser)sender;
                SetTabTitle( _browser, e.Title );
            } );
        }

        /// <summary>
        /// Called when [loading state changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="LoadingStateChangedEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoadingStateChanged( object sender, LoadingStateChangedEventArgs e )
        {
            if( sender == CurrentBrowser )
            {
                EnableBackButton( e.CanGoBack );
                EnableForwardButton( e.CanGoForward );
                if( e.IsLoading )
                {
                    // set title
                    //SetTabTitle();
                }
                else
                {
                    // after loaded / stopped
                    InvokeIfNeeded( ( ) =>
                    {
                        RefreshSearchButton.Visible = true;
                        StopSearchButton.Visible = false;
                    } );
                }
            }
        }

        /// <summary>
        /// Called when [tab closed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTabClosed( object sender, EventArgs e )
        {
        }

        /// <summary>
        /// Called when [status updated].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">The <see cref="StatusMessageEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnStatusUpdated( object sender, StatusMessageEventArgs e )
        {
        }

        /// <summary>
        /// Raises the <see cref="E:TabClosing" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabStripItemClosingEventArgs"/>
        /// instance containing the event data.</param>
        private void OnTabClosing( TabStripItemClosingEventArgs e )
        {
            // exit if invalid tab
            if( CurrentTab == null )
            {
                e.Cancel = true;
                return;
            }

            // add a blank tab if the very last tab is closed!
            if( TabPages.Items.Count <= 2 )
            {
                AddBlankTab( );

                //e.Cancel = true;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:TabsChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabStripItemChangedEventArgs"/>
        /// instance containing the event data.</param>
        private void OnTabsChanged( TabStripItemChangedEventArgs e )
        {
            ChromiumWebBrowser _browser = null;
            try
            {
                _browser = (ChromiumWebBrowser)e.Item.Controls[ 0 ];
            }
            catch( Exception _ex )
            {
                // ignore 
            }

            if( e.ChangeType == BrowserTabStripItemChangeTypes.SelectionChanged )
            {
                if( TabPages.SelectedItem == AddItemTab )
                {
                    AddBlankTab( );
                }
                else
                {
                    _browser = CurrentBrowser;
                    SetFormUrl( _browser.Address );
                    SetFormTitle( _browser.Tag.ConvertToString( ) ?? "New Tab" );
                    EnableBackButton( _browser.CanGoBack );
                    EnableForwardButton( _browser.CanGoForward );
                }
            }

            if( e.ChangeType == BrowserTabStripItemChangeTypes.Removed )
            {
                if( e.Item == _downloadStrip )
                {
                    _downloadStrip = null;
                }

                _browser?.Dispose( );
            }

            if( e.ChangeType == BrowserTabStripItemChangeTypes.Changed )
            {
                if( _browser != null )
                {
                    if( _originalUrl != "about:blank" )
                    {
                        _browser.Focus( );
                    }
                }
            }
        }

        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            TabPages.SelectedItem = _newTabItem;
            timer1.Enabled = false;
        }

        /// <summary>
        /// Called when [menu close clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMenuCloseClicked( object sender, EventArgs e )
        {
            CloseActiveTab( );
        }

        /// <summary>
        /// Called when [close other tabs clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseOtherTabsClicked( object sender, EventArgs e )
        {
            var _listToClose = new List<BrowserTabStripItem>( );
            foreach( BrowserTabStripItem _tab in TabPages.Items )
            {
                if( ( _tab != AddItemTab )
                   && ( _tab != TabPages.SelectedItem ) )
                {
                    _listToClose.Add( _tab );
                }
            }

            foreach( var _tab in _listToClose )
            {
                TabPages.RemoveTab( _tab );
            }
        }

        /// <summary>
        /// Called when [back button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnBackButtonClick( object sender, EventArgs e )
        {
            CurrentBrowser.Back( );
        }

        /// <summary>
        /// Called when [forward button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnForwardButtonClick( object sender, EventArgs e )
        {
            CurrentBrowser.Forward( );
        }

        /// <summary>
        /// Called when [downloads button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnDownloadsButtonClicked( object sender, EventArgs e )
        {
            AddNewBrowserTab( BrowserConfig.DownloadsURL );
        }

        /// <summary>
        /// Called when [refresh button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRefreshButtonClicked( object sender, EventArgs e )
        {
            RefreshActiveTab( );
        }

        /// <summary>
        /// Called when [stop button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnStopButtonClicked( object sender, EventArgs e )
        {
            StopActiveTab( );
        }

        /// <summary>
        /// Called when [URL text box text changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnUrlTextBoxTextChanged( object sender, EventArgs e )
        {
        }

        /// <summary>
        /// Called when [URL text box key down].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/>
        /// instance containing the event data.</param>
        private void OnUrlTextBoxKeyDown( object sender, KeyEventArgs e )
        {
            // if ENTER or CTRL+ENTER pressed
            if( e.IsHotKey( Keys.Enter )
               || e.IsHotKey( Keys.Enter, true ) )
            {
                LoadUrl( PrimaryTextBox.Text );

                // im handling this
                e.Handled = true;
                e.SuppressKeyPress = true;

                // defocus from url text box
                Focus( );
            }

            // if full URL copied
            if( e.IsHotKey( Keys.C, true )
               && WebUtils.IsFullySelected( PrimaryTextBox ) )
            {
                // copy the real URL, not the pretty one
                Clipboard.SetText( CurrentBrowser.Address, TextDataFormat.UnicodeText );

                // im handling this
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Called when [URL text box clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnUrlTextBoxClicked( object sender, EventArgs e )
        {
            if( !WebUtils.HasSelection( PrimaryTextBox ) )
            {
                PrimaryTextBox.SelectAll( );
            }
        }

        /// <summary>
        /// Opens the developer tools.
        /// </summary>
        private void OpenDeveloperTools( )
        {
            CurrentBrowser.ShowDevTools( );
        }

        /// <summary>
        /// Called when [tab pages clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnTabPagesClicked( object sender, MouseEventArgs e )
        {
            /*if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                tabPages.GetTabItemByPoint(this.mouse
            }*/
        }

        /// <summary>
        /// Called when [closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/>
        /// instance containing the event data.</param>
        private void OnClosing( object sender, FormClosingEventArgs e )
        {
            // ask user if they are sure
            if( DownloadsInProgress( ) )
            {
                if( MessageBox.Show( "Downloads are in progress. Cancel those and exit?",
                       "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                   != DialogResult.Yes )
                {
                    e.Cancel = true;
                    return;
                }
            }

            // dispose all browsers
            try
            {
                foreach( TabPage _tab in TabPages.Items )
                {
                    var _browser = (ChromiumWebBrowser)_tab.Controls[ 0 ];
                    _browser.Dispose( );
                }
            }
            catch( Exception _ex )
            {
                // ignore exception
            }
        }

        /// <summary>
        /// open a new tab with the downloads URL
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void btnDownloads_Click( object sender, EventArgs e )
        {
            OpenDownloadsTab( );
        }

        /// <summary>
        /// Called when [close search button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseSearchButtonClick( object sender, EventArgs e )
        {
            CloseSearch( );
        }

        /// <summary>
        /// Called when [previous search button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnPreviousSearchButtonClick( object sender, EventArgs e )
        {
            FindTextOnPage( false );
        }

        /// <summary>
        /// Called when [next search button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnNextSearchButtonClick( object sender, EventArgs e )
        {
            FindTextOnPage( true );
        }

        /// <summary>
        /// Called when [search text changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSearchTextChanged( object sender, EventArgs e )
        {
            FindTextOnPage( true );
        }

        /// <summary>
        /// Called when [search key down].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/>
        /// instance containing the event data.</param>
        private void OnSearchKeyDown( object sender, KeyEventArgs e )
        {
            if( e.IsHotKey( Keys.Enter ) )
            {
                FindTextOnPage( true );
            }

            if( e.IsHotKey( Keys.Enter, true )
               || e.IsHotKey( Keys.Enter, false, true ) )
            {
                FindTextOnPage( false );
            }
        }

        /// <summary>
        /// Called when [home button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnHomeButtonClick( object sender, EventArgs e )
        {
            CurrentBrowser.Load( BrowserConfig.HomepageURL );
        }
    }
}