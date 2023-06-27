// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-26-2023
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
    public partial class WebBrowser : Form
    {
        public static Form Instance;

        public static Assembly Assembly;

        public List<int> CancelRequests
        {
            get { return DownloadCancelRequests; }
        }

        public Dictionary<int, DownloadItem> Downloads
        {
            get { return downloads; }
        }

        public HostHandler Host;

        public BrowserTab CurTab
        {
            get
            {
                if( ( TabPages.SelectedItem != null )
                   && ( TabPages.SelectedItem.Tag != null ) )
                {
                    return (BrowserTab)TabPages.SelectedItem.Tag;
                }
                else
                {
                    return null;
                }
            }
        }

        private int CurIndex
        {
            get { return TabPages.Items.IndexOf( TabPages.SelectedItem ); }
            set { TabPages.SelectedItem = TabPages.Items[ value ]; }
        }

        private int LastIndex
        {
            get { return TabPages.Items.Count - 2; }
        }

        private BrowserTabStripItem _newTabStrip;

        private BrowserTabStripItem _downloadStrip;

        private string _currentFullUrl;

        private string _currentCleanUrl;

        private string _currentTitle;

        private DownloadHandler _downloadHandler;

        private ContextMenuHandler _contextMenuHandler;

        private LifeSpanHandler _lifeSpanHandler;

        private KeyboardHandler _keyboardHandler;

        private RequestHandler _requestHandler;

        private string _appPath = Path.GetDirectoryName( Application.ExecutablePath ) + @"\";

        private bool _searchOpen;

        private string _lastSearch = "";

        public WebBrowser( )
        {
            Instance = this;
            InitializeComponent( );
            InitBrowser( );
            SetFormTitle( null );
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            InitAppIcon( );
            InitTooltips( Controls );
            InitHotkeys( );
        }

        /// <summary>
        /// embedding the resource using the Visual Studio designer results in a blurry icon.
        /// the best way to get a non-blurry icon for Windows 7 apps.
        /// </summary>
        private void InitAppIcon( )
        {
            Assembly = Assembly.GetAssembly( typeof( WebBrowser ) );
            var _path =
                @"C:\Users\terry\source\repos\BudgetBrowser\Resources\Images\budgetbrowser.ico";

            using var _stream = File.Open( _path, FileMode.Open );
            Icon = new Icon( _stream, new Size( 64, 64 ) );
        }

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
        /// these hot keys work when the user is focused on the .NET form and its controls,
        /// AND when the user is focused on the browser (CefSharp portion)
        /// </summary>
        private void InitHotkeys( )
        {
            // browser hotkeys
            KeyboardHandler.AddHotKey( this, CloseActiveTab, Keys.W, true );
            KeyboardHandler.AddHotKey( this, CloseActiveTab, Keys.Escape, true );
            KeyboardHandler.AddHotKey( this, AddBlankWindow, Keys.N, true );
            KeyboardHandler.AddHotKey( this, AddBlankTab, Keys.T, true );
            KeyboardHandler.AddHotKey( this, RefreshActiveTab, Keys.F5 );
            KeyboardHandler.AddHotKey( this, OpenDeveloperTools, Keys.F12 );
            KeyboardHandler.AddHotKey( this, NextTab, Keys.Tab, true );
            KeyboardHandler.AddHotKey( this, PrevTab, Keys.Tab, true, true );

            // search hotkeys
            KeyboardHandler.AddHotKey( this, OpenSearch, Keys.F, true );
            KeyboardHandler.AddHotKey( this, CloseSearch, Keys.Escape );
            KeyboardHandler.AddHotKey( this, StopActiveTab, Keys.Escape );
            KeyboardHandler.AddHotKey( this, ToggleFullscreen, Keys.F11 );
        }

        /// <summary>
        /// we activate all the tooltips stored in the Tag property of the buttons
        /// </summary>
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
            _settings.CachePath = GetAppDir( "Cache" );
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
            AddNewBrowser( tabStrip1, BrowserConfig.HomepageURL );
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

        private static string GetAppDir( string name )
        {
            var _winXpDir = @"C:\Documents and Settings\All Users\Application Data\";
            if( Directory.Exists( _winXpDir ) )
            {
                return _winXpDir + BrowserConfig.Branding + @"\" + name + @"\";
            }

            return @"C:\ProgramData\" + BrowserConfig.Branding + @"\" + name + @"\";
        }

        private void LoadUrl( string url )
        {
            var _newUrl = url;
            var _urlLower = url.Trim( ).ToLower( );

            // UI
            SetTabTitle( CurBrowser, "Loading..." );

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
            CurBrowser.Load( _newUrl );

            // set URL in UI
            SetFormUrl( _newUrl );

            // always enable back btn
            EnableBackButton( true );
            EnableForwardButton( false );
        }

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

        private void SetFormUrl( string url )
        {
            _currentFullUrl = url;
            _currentCleanUrl = CleanUrl( url );
            TxtURL.Text = _currentCleanUrl;
            CurTab.CurURL = _currentFullUrl;
            CloseSearch( );
        }

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

        private bool IsBlank( string url )
        {
            return ( url == "" ) || ( url == "about:blank" );
        }

        private bool IsBlankOrSystem( string url )
        {
            return ( url == "" )
                || url.BeginsWith( "about:" )
                || url.BeginsWith( "chrome:" )
                || url.BeginsWith( BrowserConfig.InternalURL + ":" );
        }

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

        public void AddBlankTab( )
        {
            AddNewBrowserTab( "" );
            this.InvokeOnParent( delegate
            {
                TxtURL.Focus( );
            } );
        }

        public ChromiumWebBrowser AddNewBrowserTab( string url, bool focusNewTab = true,
            string refererUrl = null )
        {
            return Invoke( delegate
            {
                // check if already exists
                foreach( BrowserTabStripItem _tab in TabPages.Items )
                {
                    var _tab2 = (BrowserTab)_tab.Tag;
                    if( ( _tab2 != null )
                       && ( _tab2.CurURL == url ) )
                    {
                        TabPages.SelectedItem = _tab;
                        return _tab2.Browser;
                    }
                }

                var _tabStrip = new BrowserTabStripItem( );
                _tabStrip.Title = "New Tab";
                TabPages.Items.Insert( TabPages.Items.Count - 1, _tabStrip );
                _newTabStrip = _tabStrip;
                var _newTab = AddNewBrowser( _newTabStrip, url );
                _newTab.ReferringUrl = refererUrl;
                if( focusNewTab )
                {
                    timer1.Enabled = true;
                }

                return _newTab.Browser;
            } );
        }

        private BrowserTab AddNewBrowser( BrowserTabStripItem tabStrip, String url )
        {
            if( url == "" )
            {
                url = BrowserConfig.NewTabURL;
            }

            var _browser = new ChromiumWebBrowser( url );

            // set config
            ConfigureBrowser( _browser );

            // set layout
            _browser.Dock = DockStyle.Fill;
            tabStrip.Controls.Add( _browser );
            _browser.BringToFront( );

            // add events
            _browser.StatusMessage += Browser_StatusMessage;
            _browser.LoadingStateChanged += Browser_LoadingStateChanged;
            _browser.TitleChanged += Browser_TitleChanged;
            _browser.LoadError += Browser_LoadError;
            _browser.AddressChanged += Browser_URLChanged;
            _browser.DownloadHandler = _downloadHandler;
            _browser.MenuHandler = _contextMenuHandler;
            _browser.LifeSpanHandler = _lifeSpanHandler;
            _browser.KeyboardHandler = _keyboardHandler;
            _browser.RequestHandler = _requestHandler;

            // new tab obj
            var _tab = new BrowserTab
            {
                IsOpen = true,
                Browser = _browser,
                Tab = tabStrip,
                OrigURL = url,
                CurURL = url,
                Title = "New Tab",
                DateCreated = DateTime.Now
            };

            // save tab obj in tabstrip
            tabStrip.Tag = _tab;
            if( url.StartsWith( BrowserConfig.InternalURL + ":" ) )
            {
                _browser.JavascriptObjectRepository.Register( "host", Host,
                    BindingOptions.DefaultBinder );
            }

            return _tab;
        }

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

        public void RefreshActiveTab( )
        {
            CurBrowser.Load( CurBrowser.Address );
        }

        public void CloseActiveTab( )
        {
            if( CurTab != null/* && TabPages.Items.Count > 2*/ )
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

        private FormWindowState _oldWindowState;

        private FormBorderStyle _oldBorderStyle;

        private bool _isFullScreen;

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

        private void StopActiveTab( )
        {
            CurBrowser.Stop( );
        }

        private bool IsOnFirstTab( )
        {
            return TabPages.SelectedItem == TabPages.Items[ 0 ];
        }

        private bool IsOnLastTab( )
        {
            return TabPages.SelectedItem == TabPages.Items[ TabPages.Items.Count - 2 ];
        }

        private void NextTab( )
        {
            if( IsOnLastTab( ) )
            {
                CurIndex = 0;
            }
            else
            {
                CurIndex++;
            }
        }

        private void PrevTab( )
        {
            if( IsOnFirstTab( ) )
            {
                CurIndex = LastIndex;
            }
            else
            {
                CurIndex--;
            }
        }

        public ChromiumWebBrowser CurBrowser
        {
            get
            {
                if( ( TabPages.SelectedItem != null )
                   && ( TabPages.SelectedItem.Tag != null ) )
                {
                    return ( (BrowserTab)TabPages.SelectedItem.Tag ).Browser;
                }
                else
                {
                    return null;
                }
            }
        }

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

        public int CurTabLoadingDur
        {
            get
            {
                if( ( TabPages.SelectedItem != null )
                   && ( TabPages.SelectedItem.Tag != null ) )
                {
                    var _loadTime = (int)( DateTime.Now - CurTab.DateCreated ).TotalMilliseconds;
                    return _loadTime;
                }
                else
                {
                    return 0;
                }
            }
        }

        private void Browser_URLChanged( object sender, AddressChangedEventArgs e )
        {
            InvokeIfNeeded( ( ) =>
            {
                // if current tab
                if( sender == CurBrowser )
                {
                    if( !WebUtils.IsFocused( TxtURL ) )
                    {
                        SetFormUrl( e.Address );
                    }

                    EnableBackButton( CurBrowser.CanGoBack );
                    EnableForwardButton( CurBrowser.CanGoForward );
                    SetTabTitle( (ChromiumWebBrowser)sender, "Loading..." );
                    BtnRefresh.Visible = false;
                    BtnStop.Visible = true;
                    CurTab.DateCreated = DateTime.Now;
                }
            } );
        }

        private void Browser_LoadError( object sender, LoadErrorEventArgs e )
        {
            // ("Load Error:" + e.ErrorCode + ";" + e.ErrorText);
        }

        private void Browser_TitleChanged( object sender, TitleChangedEventArgs e )
        {
            InvokeIfNeeded( ( ) =>
            {
                var _browser = (ChromiumWebBrowser)sender;
                SetTabTitle( _browser, e.Title );
            } );
        }

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
            if( browser == CurBrowser )
            {
                SetFormTitle( text );
            }
        }

        private void Browser_LoadingStateChanged( object sender, LoadingStateChangedEventArgs e )
        {
            if( sender == CurBrowser )
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
                        BtnRefresh.Visible = true;
                        BtnStop.Visible = false;
                    } );
                }
            }
        }

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

        private void Browser_StatusMessage( object sender, StatusMessageEventArgs e )
        {
        }

        public void WaitForBrowserToInitialize( ChromiumWebBrowser browser )
        {
            while( !browser.IsBrowserInitialized )
            {
                Thread.Sleep( 100 );
            }
        }

        private void EnableBackButton( bool canGoBack )
        {
            InvokeIfNeeded( ( ) => BtnBack.Enabled = canGoBack );
        }

        private void EnableForwardButton( bool canGoForward )
        {
            InvokeIfNeeded( ( ) => BtnForward.Enabled = canGoForward );
        }

        private void OnTabClosed( object sender, EventArgs e )
        {
        }

        private void OnTabClosing( TabStripItemClosingEventArgs e )
        {
            // exit if invalid tab
            if( CurTab == null )
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
                if( TabPages.SelectedItem == tabStripAdd )
                {
                    AddBlankTab( );
                }
                else
                {
                    _browser = CurBrowser;
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

                if( _browser != null )
                {
                    _browser.Dispose( );
                }
            }

            if( e.ChangeType == BrowserTabStripItemChangeTypes.Changed )
            {
                if( _browser != null )
                {
                    if( _currentFullUrl != "about:blank" )
                    {
                        _browser.Focus( );
                    }
                }
            }
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            TabPages.SelectedItem = _newTabStrip;
            timer1.Enabled = false;
        }

        private void menuCloseTab_Click( object sender, EventArgs e )
        {
            CloseActiveTab( );
        }

        private void menuCloseOtherTabs_Click( object sender, EventArgs e )
        {
            var _listToClose = new List<BrowserTabStripItem>( );
            foreach( BrowserTabStripItem _tab in TabPages.Items )
            {
                if( ( _tab != tabStripAdd )
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

        private void bBack_Click( object sender, EventArgs e )
        {
            CurBrowser.Back( );
        }

        private void bForward_Click( object sender, EventArgs e )
        {
            CurBrowser.Forward( );
        }

        private void txtUrl_TextChanged( object sender, EventArgs e )
        {
        }

        private void bDownloads_Click( object sender, EventArgs e )
        {
            AddNewBrowserTab( BrowserConfig.DownloadsURL );
        }

        private void bRefresh_Click( object sender, EventArgs e )
        {
            RefreshActiveTab( );
        }

        private void bStop_Click( object sender, EventArgs e )
        {
            StopActiveTab( );
        }

        private void TxtURL_KeyDown( object sender, KeyEventArgs e )
        {
            // if ENTER or CTRL+ENTER pressed
            if( e.IsHotKey( Keys.Enter )
               || e.IsHotKey( Keys.Enter, true ) )
            {
                LoadUrl( TxtURL.Text );

                // im handling this
                e.Handled = true;
                e.SuppressKeyPress = true;

                // defocus from url textbox
                Focus( );
            }

            // if full URL copied
            if( e.IsHotKey( Keys.C, true )
               && WebUtils.IsFullySelected( TxtURL ) )
            {
                // copy the real URL, not the pretty one
                Clipboard.SetText( CurBrowser.Address, TextDataFormat.UnicodeText );

                // im handling this
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtUrl_Click( object sender, EventArgs e )
        {
            if( !WebUtils.HasSelection( TxtURL ) )
            {
                TxtURL.SelectAll( );
            }
        }

        private void OpenDeveloperTools( )
        {
            CurBrowser.ShowDevTools( );
        }

        private void tabPages_MouseClick( object sender, MouseEventArgs e )
        {
            /*if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                tabPages.GetTabItemByPoint(this.mouse
            }*/
        }

        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
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
        /// we must store download metadata in a list, since CefSharp does not
        /// </summary>
        private void InitDownloads( )
        {
            downloads = new Dictionary<int, DownloadItem>( );
            DownloadNames = new Dictionary<int, string>( );
            DownloadCancelRequests = new List<int>( );
        }

        public void UpdateDownloadItem( DownloadItem item )
        {
            lock( downloads )
            {
                // SuggestedFileName comes full only in the first attempt so keep it somewhere
                if( item.SuggestedFileName != "" )
                {
                    DownloadNames[ item.Id ] = item.SuggestedFileName;
                }

                // Set it back if it is empty
                if( ( item.SuggestedFileName == "" )
                   && DownloadNames.ContainsKey( item.Id ) )
                {
                    item.SuggestedFileName = DownloadNames[ item.Id ];
                }

                downloads[ item.Id ] = item;

                //UpdateSnipProgress();
            }
        }

        public string CalcDownloadPath( DownloadItem item )
        {
            return item.SuggestedFileName;
        }

        public bool DownloadsInProgress( )
        {
            foreach( var _item in downloads.Values )
            {
                if( _item.IsInProgress )
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// open a new tab with the downloads URL
        /// </summary>
        private void btnDownloads_Click( object sender, EventArgs e )
        {
            OpenDownloadsTab( );
        }

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

        private void OpenSearch( )
        {
            if( !_searchOpen )
            {
                _searchOpen = true;
                InvokeIfNeeded( delegate
                {
                    PanelSearch.Visible = true;
                    TxtSearch.Text = _lastSearch;
                    TxtSearch.Focus( );
                    TxtSearch.SelectAll( );
                } );
            }
            else
            {
                InvokeIfNeeded( delegate
                {
                    TxtSearch.Focus( );
                    TxtSearch.SelectAll( );
                } );
            }
        }

        private void CloseSearch( )
        {
            if( _searchOpen )
            {
                _searchOpen = false;
                InvokeIfNeeded( delegate
                {
                    PanelSearch.Visible = false;
                    CurBrowser.GetBrowser( ).StopFinding( true );
                } );
            }
        }

        private void BtnClearSearch_Click( object sender, EventArgs e )
        {
            CloseSearch( );
        }

        private void BtnPrevSearch_Click( object sender, EventArgs e )
        {
            FindTextOnPage( false );
        }

        private void BtnNextSearch_Click( object sender, EventArgs e )
        {
            FindTextOnPage( true );
        }

        private void FindTextOnPage( bool next = true )
        {
            var _first = _lastSearch != TxtSearch.Text;
            _lastSearch = TxtSearch.Text;
            if( _lastSearch.CheckIfValid( ) )
            {
                CurBrowser.GetBrowser( ).Find( _lastSearch, true, false, !_first );
            }
            else
            {
                CurBrowser.GetBrowser( ).StopFinding( true );
            }

            TxtSearch.Focus( );
        }

        private void TxtSearch_TextChanged( object sender, EventArgs e )
        {
            FindTextOnPage( true );
        }

        private void TxtSearch_KeyDown( object sender, KeyEventArgs e )
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

        private void BtnHome_Click( object sender, EventArgs e )
        {
            CurBrowser.Load( BrowserConfig.HomepageURL );
        }
    }
}