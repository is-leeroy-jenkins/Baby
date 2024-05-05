// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 05-01-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-01-2024
// ******************************************************************************************
// <copyright file="WebBrowser.cs" company="Terry D. Eppler">
//    Baby is a small web browser used in a Federal Budget, Finance, and Accounting application
//    for the  US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//   WebBrowser.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Collections;
    using System.Windows.Forms;
    using System.Threading;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.IO;
    using System.Web;
    using CefSharp;
    using CefSharp.WinForms;
    using MetroSet_UI.Child;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using static System.Configuration.ConfigurationManager;
    using static System.IO.Path;
    using Action = System.Action;
    using ContentAlignment = System.Drawing.ContentAlignment;

    /// <inheritdoc />
    /// <summary>
    /// The main Baby form, supporting multiple tabs.
    /// 
    /// We used the x86 version of CefSharp, so the app works on 32-bit and 64-bit machines.
    /// If you would only like to support 64-bit machines, simply change the DLL references.
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWithPrivateSetter" ) ]
    [ SuppressMessage( "ReSharper", "RedundantDelegateCreation" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "StringLiteralTypo" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeMethodOrOperatorBody" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "WrongIndentSize" ) ]
    [ SuppressMessage( "ReSharper", "AsyncVoidMethod" ) ]
    [ SuppressMessage( "ReSharper", "MergeIntoPattern" ) ]
    public partial class WebBrowser : MetroForm
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
        private DownloadCallback _downloadCallback;

        /// <summary>
        /// The context menu handler
        /// </summary>
        private ContextMenuCallback _contextMenuCallback;

        /// <summary>
        /// The life span handler
        /// </summary>
        private LifeSpanCallback _lifeSpanCallback;

        /// <summary>
        /// The keyboard handler
        /// </summary>
        private KeyboardCallback _keyboardCallback;

        /// <summary>
        /// The request handler
        /// </summary>
        private RequestCallback _requestCallback;

        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;

        /// <summary>
        /// The browser action
        /// </summary>
        private Func<ChromiumWebBrowser> _browserCallback;

        /// <summary>
        /// The application path
        /// </summary>
        private string _path = GetDirectoryName( Application.ExecutablePath ) + @"\";

        /// <summary>
        /// The search open
        /// </summary>
        private bool _searchOpen;

        /// <summary>
        /// The last search
        /// </summary>
        private string _lastSearch = "";

        /// <summary>
        /// The search engine URL
        /// </summary>
        private string _searchEngineUrl;

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
        private bool _fullScreen;

        /// <summary>
        /// The download cancel requests
        /// </summary>
        private List<int> _cancelRequests;

        /// <summary>
        /// The downloads
        /// </summary>
        private Dictionary<int, DownloadItem> _downloadItems;

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
        public HostCallback Host;

        /// <summary>
        /// The download names
        /// </summary>
        public Dictionary<int, string> DownloadNames;

        /// <summary>
        /// Gets or sets the index of the current.
        /// </summary>
        /// <value>
        /// The index of the current.
        /// </value>
        private int CurrentIndex
        {
            get
            {
                return TabPages.Items.IndexOf( TabPages.SelectedItem );
            }
            set
            {
                TabPages.SelectedItem = TabPages.Items[ value ];
            }
        }

        /// <summary>
        /// Gets the last index.
        /// </summary>
        /// <value>
        /// The last index.
        /// </value>
        private int LastIndex
        {
            get
            {
                return TabPages.Items.Count - 2;
            }
        }

        /// <summary>
        /// Gets the cancel requests.
        /// </summary>
        /// <value>
        /// The cancel requests.
        /// </value>
        public List<int> CancelRequests
        {
            get
            {
                return _cancelRequests;
            }
        }

        /// <summary>
        /// Gets the downloads.
        /// </summary>
        /// <value>
        /// The downloads.
        /// </value>
        public Dictionary<int, DownloadItem> DownloadItems
        {
            get
            {
                return _downloadItems;
            }
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
        /// Gets the search engine URL.
        /// </summary>
        /// <value>
        /// The search engine URL.
        /// </value>
        public string SearchEngineUrl
        {
            get
            {
                return _searchEngineUrl;
            }
        }

        /// <summary>
        /// Gets the duration of the current tab loading.
        /// </summary>
        /// <value>
        /// The duration of the current tab loading.
        /// </value>
        public int LoadingDuration
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
            get
            {
                return ( (BrowserTab)TabPages.SelectedItem?.Tag )?.Browser;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.WebBrowser" /> class.
        /// </summary>
        public WebBrowser( )
        {
            Instance = this;
            InitializeComponent( );
            InitializeDelegates( );
            InitializeBrowser( );
            RegisterCallbacks( );

            // Form Properties
            Size = new Size( 1490, 840 );
            MaximumSize = new Size( 1500, 850 );
            MinimumSize = new Size( 1480, 830 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            SizeGripStyle = SizeGripStyle.Hide;
            ShowMouseOver = true;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            SetTitleText( null );

            // Wireup Events
            Load += OnLoad;
            MouseClick += OnRightClick;
        }

        /// <summary>
        /// this is done just once,
        /// to globally initialize CefSharp/CEF
        /// </summary>
        private void InitializeBrowser( )
        {
            var _cefSettings = new CefSettings( );
            _cefSettings.RegisterScheme( new CefCustomScheme
            {
                SchemeName = AppSettings[ "Internal" ],
                SchemeHandlerFactory = new SchemaCallbackFactory( )
            } );

            _cefSettings.UserAgent = AppSettings[ "UserAgent" ];
            _cefSettings.AcceptLanguageList = AppSettings[ "AcceptLanguage" ];
            _cefSettings.IgnoreCertificateErrors = true;
            _cefSettings.CachePath = GetApplicationDirectory( "Cache" );
            if( bool.Parse( AppSettings[ "Proxy" ] ) )
            {
                CefSharpSettings.Proxy = new ProxyOptions( AppSettings[ "ProxyIP" ],
                    AppSettings[ "ProxyPort" ], AppSettings[ "ProxyUsername" ],
                    AppSettings[ "ProxyPassword" ], AppSettings[ "ProxyBypassList" ] );
            }

            Cef.Initialize( _cefSettings );
            _downloadCallback = new DownloadCallback( this );
            _lifeSpanCallback = new LifeSpanCallback( this );
            _contextMenuCallback = new ContextMenuCallback( this );
            _keyboardCallback = new KeyboardCallback( this );
            _requestCallback = new RequestCallback( this );
            InitializeDownloads( );
            Host = new HostCallback( this );
            AddNewBrowser( TabItem, AppSettings[ "HomePage" ] );
        }

        /// <summary>
        /// we must store download metadata in a list,
        /// since CefSharp does not
        /// </summary>
        private void InitializeDownloads( )
        {
            _downloadItems = new Dictionary<int, DownloadItem>( );
            DownloadNames = new Dictionary<int, string>( );
            _cancelRequests = new List<int>( );
        }

        /// <summary>
        /// Sets the tool strip properties.
        /// </summary>
        private void InitializeToolStrip( )
        {
            try
            {
                // ToolStrip Properties
                ToolStrip.ShowCaption = true;
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.Office12Mode = true;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.ImageScalingSize = new Size( 16, 16 );

                // ComboBox Properties
                ToolStripDomainComboBox.Font = new Font( "Roboto", 9, FontStyle.Regular );
                ToolStripDomainComboBox.Style = ToolStripExStyle.Office2016Black;
                ToolStripDomainComboBox.ForeColor = Color.FromArgb( 106, 189, 252 );
                ToolStripDomainComboBox.BackColor = Color.FromArgb( 30, 30, 30 );
                ToolStripDomainComboBox.Size = new Size( 150, 29 );
                ToolStripDomainComboBox.TextAlign = ContentAlignment.MiddleCenter;
                ToolStripDomainComboBox.SelectedIndex = -1;

                // TextBox Properties
                ToolStripKeyWordTextBox.ForeColor = Color.White;
                ToolStripKeyWordTextBox.Size = new Size( 210, 25 );
                ToolStripKeyWordTextBox.Font = new Font( "Roboto", 9, FontStyle.Regular );
                ToolStripKeyWordTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
                ToolStripKeyWordTextBox.BackColor = Color.FromArgb( 30, 30, 30 );

                // Progress Bar Properties
                ProgressBar.Step = 10;
                ProgressBar.Minimum = 0;
                ProgressBar.Maximum = 100;
                ProgressBar.Value = 0;
                ProgressBar.Style = ProgressBarStyle.Blocks;
                ProgressBar.Visible = false;
                ProgressSeparator.Visible = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tab control.
        /// </summary>
        private void InitializeTabControl( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the PictureBox.
        /// </summary>
        private void InitializePictureBox( )
        {
            try
            {
                PictureBox.Size = new Size( 20, 18 );
                PictureBox.Padding = new Padding( 1 );
                PictureBox.Margin = new Padding( 1 );
                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the status label properties.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                StatusLabel.Font = new Font( "Roboto", 8 );
                StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
                StatusLabel.ForeColor = Color.Black;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the title label properties.
        /// </summary>
        private void InitializeTitle( )
        {
            try
            {
                Title.Font = new Font( "Roboto", 10 );
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopCenter;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the delegate.
        /// </summary>
        private void InitializeDelegates( )
        {
            try
            {
                _statusUpdate += UpdateStatus;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// these hot keys work when the user
        /// is focused on the .NET form and its controls,
        /// AND when the user is focused on the browser
        /// (CefSharp portion)
        /// </summary>
        private void InitializeHotkeys( )
        {
            try
            {
                // browser hot keys
                KeyboardCallback.AddHotKey( this, CloseActiveTab, Keys.W, true );
                KeyboardCallback.AddHotKey( this, CloseActiveTab, Keys.Escape, true );
                KeyboardCallback.AddHotKey( this, AddBlankWindow, Keys.N, true );
                KeyboardCallback.AddHotKey( this, AddBlankTab, Keys.T, true );
                KeyboardCallback.AddHotKey( this, RefreshActiveTab, Keys.F5 );
                KeyboardCallback.AddHotKey( this, OpenDeveloperTools, Keys.F12 );
                KeyboardCallback.AddHotKey( this, NextTab, Keys.Tab, true );
                KeyboardCallback.AddHotKey( this, PreviousTab, Keys.Tab, true, true );
                
                // search hot keys
                KeyboardCallback.AddHotKey( this, OpenSearch, Keys.F, true );
                KeyboardCallback.AddHotKey( this, CloseSearch, Keys.Escape );
                KeyboardCallback.AddHotKey( this, StopActiveTab, Keys.Escape );
                KeyboardCallback.AddHotKey( this, ToggleFullscreen, Keys.F11 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// we activate all the tooltips stored
        /// in the Tag property of the buttons
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void InitializeTooltips( Control.ControlCollection parent )
        {
            try
            {
                foreach( Control _control in parent )
                {
                    if( _control is Button _button )
                    {
                        if( _button.Tag != null )
                        {
                            System.Windows.Forms.ToolTip _tip = new ToolTip( );
                            _tip.ReshowDelay = _tip.InitialDelay = 200;
                            _tip.ShowAlways = true;
                            _tip.SetToolTip( _button, _button.Tag.ToString( ) );
                        }
                    }
                    
                    if( _control is Panel _panel )
                    {
                        InitializeTooltips( _panel.Controls );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                // Control Event Wiring
                PreviousButton.Click += OnBackButtonClick;
                NextButton.Click += OnForwardButtonClick;
                ToolStripHomeButton.Click += OnHomeButtonClick;
                ToolStripCloseButton.Click += OnCloseButtonClick;
                ToolStripRefreshButton.Click += OnRefreshButtonClick;
                ToolStripDownloadButton.Click += OnDownloadsButtonClick;
                ToolStripCancelButton.Click += OnStopButtonClick;
                DeveloperToolsButton.Click += OnDeveloperToolsButtonClick;
                ToolStripDomainComboBox.SelectedIndexChanged += OnSelectedDomainChanged;
                ToolStripLookupButton.Click += OnGoButtonClick;
                ToolStripEdgeButton.Click += OnEdgeButtonClick;
                ToolStripChromeButton.Click += OnChromeButtonClick;
                ToolStripFireFoxButton.Click += OnFireFoxButtonClick;
                Timer.Tick += OnTimerTick;
                TabPages.MouseClick += OnRightClick;
                MenuButton.MouseClick += OnSearchButtonClick;
                TabPages.TabStripItemClosing += OnTabClosing;
                Title.MouseClick += OnRightClick;
                UrlTextBox.MouseClick += OnRightClick;
                TabItem.MouseClick += OnRightClick;
                ContextMenu.MouseLeave += OnContextMenuMouseLeave;
                ToolStripSharepointButton.Click += OnSharepointButtonClicked;
                foreach( ToolStripItem _item in ContextMenu.Items )
                {
                    _item.MouseDown += OnContextMenuItemClick;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the in asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeInAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity < 1.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity += 0.05;
                }

                form.Opacity = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeOutAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity > 0.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity -= 0.05;
                }

                form.Opacity = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the tab title.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <param name="text">The text.</param>
        private void SetTabText( ChromiumWebBrowser browser, string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                text = text.Trim( );
                if( IsBlank( text ) )
                {
                    text = "New Tab";
                }
                
                browser.Tag = text;
                if( text.Length > 20 )
                {
                    var _title = text.Substring( 0, 20 ) + "...";
                    var _tab = (BrowserTabStripItem)browser.Parent;
                    _tab.Title = _title;
                }
                else
                {
                    var _tab = (BrowserTabStripItem)browser.Parent;
                    _tab.Title = text;
                }
                
                // if current tab
                if( browser == CurrentBrowser )
                {
                    SetTitleText( text );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the form title.
        /// </summary>
        /// <param name="title">Name of the tab.</param>
        private void SetTitleText( string title )
        {
            InvokeIf( delegate
            {
                if( title.CheckIfValid( ) )
                {
                    Title.Text = AppSettings[ "Branding" ] + " - " + title;
                    _currentTitle = title;
                }
                else
                {
                    Title.Text = AppSettings[ "Branding" ];
                    _currentTitle = "New Tab";
                }
            } );
        }

        /// <summary>
        /// Called by LoadURL to set the form URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void SetUrl( string url )
        {
            _originalUrl = url;
            _finalUrl = CleanUrl( url );
            UrlTextBox.Text = _originalUrl;
            CurrentTab.CurrentUrl = _originalUrl;
            CloseSearch( );
        }

        /// <summary>
        /// this is done every time a new tab is opened
        /// </summary>
        /// <param name="browser">
        /// The browser.
        /// </param>
        private void ConfigureBrowser( ChromiumWebBrowser browser )
        {
            try
            {
                ThrowIf.Null( browser, nameof( browser ) );
                var _config = new BrowserSettings( );
                _config.WebGl = bool.Parse( AppSettings[ "WebGL" ] ).ToCefState( );
                browser.BrowserSettings = _config;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        private void SendNotification( )
        {
            try
            {
                var _message = "THIS IS NOT YET IMPLEMENTED!";
                var _notify = new Notification( _message );
                _notify.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Finds the text on page.
        /// </summary>
        /// <param name="next">if set to
        /// <c>true</c> [next].
        /// </param>
        private void FindTextOnPage( bool next = true )
        {
            var _first = _lastSearch != SearchPanelTextBox.Text;
            _lastSearch = SearchPanelTextBox.Text;
            if( _lastSearch.CheckIfValid( ) )
            {
                CurrentBrowser.GetBrowser( )
                    ?.Find( _lastSearch, true, false, !_first );
            }
            else
            {
                CurrentBrowser.GetBrowser( )
                    ?.StopFinding( true );
            }

            SearchPanelTextBox.Focus( );
        }

        /// <summary>
        /// Gets the controls.
        /// </summary>
        /// <returns>
        /// </returns>
        private protected IEnumerable<Control> GetControls( )
        {
            var _list = new List<Control>( );
            var _queue = new Queue( );
            try
            {
                _queue.Enqueue( Controls );
                while( _queue.Count > 0 )
                {
                    var _collection = (Control.ControlCollection)_queue.Dequeue( );
                    foreach( Control _control in _collection )
                    {
                        _list.Add( _control );
                        _queue.Enqueue( _control.Controls );
                    }
                }

                return _list?.Any( ) == true
                    ? _list.ToArray( )
                    : default( Control[ ] );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Control[ ] );
            }
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
        /// Gets all tabs.
        /// </summary>
        /// <returns></returns>
        public List<BrowserTab> GetTabs( )
        {
            var _tabs = new List<BrowserTab>( );
            foreach( BrowserTabStripItem _tabPage in TabPages?.Items )
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
            foreach( BrowserTabStripItem _item in TabPages.Items )
            {
                var _tab = (BrowserTab)_item.Tag;
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
            try
            {
                ThrowIf.NullOrEmpty( name, nameof( name ) );
                var _winXpDir = @"C:\Documents and Settings\All Users\Application Data\";
                return Directory.Exists( _winXpDir )
                    ? _winXpDir + AppSettings[ "Branding" ] + @"\" + name + @"\"
                    : @"C:\ProgramData\" + AppSettings[ "Branding" ] + @"\" + name + @"\";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the resource stream.
        /// </summary>
        /// <param name="fileName">The fileName.</param>
        /// <param name="nameSpace">if set to
        /// <c>true</c> [with nameSpace].</param>
        /// <returns>
        /// </returns>
        public Stream GetResourceStream( string fileName, bool nameSpace = true )
        {
            try
            {
                ThrowIf.NullOrEmpty( fileName, nameof( fileName ) );
                var _prefix = "Properties.Resources.";
                return Assembly.GetManifestResourceStream( fileName );
            }
            catch( Exception )
            {
                //ignore exception
            }

            return null;
        }

        /// <summary>
        /// Gets the browser asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="focused">if set to <c>true</c> [focused].</param>
        /// <returns></returns>
        private Task<ChromiumWebBrowser> GetBrowserAsync( string url, bool focused )
        {
            var _tcs = new TaskCompletionSource<ChromiumWebBrowser>( );
            try
            {
                ThrowIf.NullOrEmpty( url, nameof( url ) );
                var _browser = AddNewBrowserTab( url, focused );
                _tcs.SetResult( _browser );
                return _tcs.Task;
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<ChromiumWebBrowser> );
            }
        }

        /// <summary>
        /// Updates the status label.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _dateTime = DateTime.Now;
                var _dateString = _dateTime.ToLongDateString( );
                var _timeString = _dateTime.ToLongTimeString( );
                StatusLabel.Text = _dateString + "  " + _timeString;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the status label.
        /// </summary>
        /// <param name="dateTime">
        /// The date time.
        /// </param>
        private void UpdateStatus( DateTime dateTime )
        {
            try
            {
                var _dateString = dateTime.ToLongDateString( );
                var _timeString = dateTime.ToLongTimeString( );
                StatusLabel.Text = _dateString + "  " + _timeString;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Closes the other tabs.
        /// </summary>
        private void CloseOtherTabs( )
        {
            try
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
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Loads the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void LoadUrl( string url )
        {
            var _newUrl = url;
            var _urlLower = url.Trim( ).ToLower( );
            SetTabText( CurrentBrowser, "Loading..." );
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
                       || _urlLower.StartsWith( AppSettings[ "Internal" ] ) ) )
                {
                    if( ( _outUri == null )
                       || ( _outUri.Scheme != Uri.UriSchemeFile ) )
                    {
                        _newUrl = "https://" + url;
                    }
                }

                if( _urlLower.StartsWith( AppSettings[ "Internal" ] + ":" )
                   || ( Uri.TryCreate( _newUrl, UriKind.Absolute, out _outUri )
                       && ( ( ( ( _outUri.Scheme == Uri.UriSchemeHttp )
                               || ( _outUri.Scheme == Uri.UriSchemeHttps ) )
                               && _newUrl.Contains( "." ) )
                           || ( _outUri.Scheme == Uri.UriSchemeFile ) ) ) )
                {
                }
                else
                {
                    _newUrl = AppSettings[ "Google" ] + HttpUtility.UrlEncode( url );
                }
            }

            CurrentBrowser.Load( _newUrl );
            SetUrl( _newUrl );
            EnableBackButton( true );
            EnableForwardButton( false );
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
        /// <param name="canGoBack">if set to
        /// <c>true</c> [can go back].
        /// </param>
        private void EnableBackButton( bool canGoBack )
        {
            InvokeIf( ( ) => PreviousButton.Enabled = canGoBack );
        }

        /// <summary>
        /// Enables the forward button.
        /// </summary>
        /// <param name="canGoForward">
        /// if set to <c>true</c> [can go forward].
        /// </param>
        private void EnableForwardButton( bool canGoForward )
        {
            InvokeIf( ( ) => NextButton.Enabled = canGoForward );
        }

        /// <summary>
        /// Called by SetURL to clean up the URL
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private string CleanUrl( string url )
        {
            try
            {
                ThrowIf.NullOrEmpty( url, nameof( url ) );
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
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        public void InvokeIf( Action action )
        {
            try
            {
                ThrowIf.Null( action, nameof( action ) );
                if( InvokeRequired )
                {
                    BeginInvoke( action );
                }
                else
                {
                    action.Invoke( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Determines whether the specified URL is blank.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// <c>true</c>
        /// if the specified URL is blank;
        /// otherwise,
        /// <c>false</c>.
        /// </returns>
        private bool IsBlank( string url )
        {
            try
            {
                ThrowIf.NullOrEmpty( url, nameof( url ) );
                return ( url == "" ) || ( url == "about:blank" );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// Determines whether [is blank or system] [the specified URL].
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        ///   <c>true</c> if [is blank or system] [the specified URL];
        ///   otherwise,
        ///   <c>false</c>.
        /// </returns>
        private bool IsBlankOrSystem( string url )
        {
            try
            {
                ThrowIf.NullOrEmpty( url, nameof( url ) );
                return ( url == "" ) || url.BeginsWith( "about:" ) || url.BeginsWith( "chrome:" )
                    || url.BeginsWith( AppSettings[ "Internal" ] + ":" );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// Determines whether [is on first tab].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is on first tab]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsFirstTab( )
        {
            return TabPages.SelectedItem == TabPages.Items[ 0 ];
        }

        /// <summary>
        /// Determines whether [is on last tab].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is on last tab]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsLastTab( )
        {
            return TabPages.SelectedItem == TabPages.Items[ ^2 ];
        }

        /// <summary>
        /// Stops the active tab.
        /// </summary>
        private void StopActiveTab( )
        {
            CurrentBrowser.Stop( );
        }

        /// <summary>
        /// Nexts the tab.
        /// </summary>
        private void NextTab( )
        {
            if( IsLastTab( ) )
            {
                CurrentIndex = 0;
            }
            else
            {
                CurrentIndex++;
            }
        }

        /// <summary>
        /// Previous tab.
        /// </summary>
        private void PreviousTab( )
        {
            if( IsFirstTab( ) )
            {
                CurrentIndex = LastIndex;
            }
            else
            {
                CurrentIndex--;
            }
        }

        /// <summary>
        /// Adds the blank window.
        /// </summary>
        public void AddBlankWindow( )
        {
            // open a new instance of the browser
            var _info = new ProcessStartInfo( Application.ExecutablePath, "" )
            {
                LoadUserProfile = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };

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
                UrlTextBox.Focus( );
            } );
        }

        /// <summary>
        /// Adds the new browser tab.
        /// </summary>
        /// <param name="url">
        /// The URL.
        /// </param>
        /// <param name="focusNewTab">if set to
        /// <c>true</c> [focus new tab].
        /// </param>
        /// <param name="referringUrl">
        /// The referring URL.
        /// </param>
        /// <returns></returns>
        public ChromiumWebBrowser AddNewBrowserTab( string url, bool focusNewTab = true,
            string referringUrl = null )
        {
            return Invoke( delegate
            {
                // check if already exists
                foreach( BrowserTabStripItem _item in TabPages.Items )
                {
                    var _tab2 = (BrowserTab)_item.Tag;
                    if( ( _tab2 != null )
                       && ( _tab2.CurrentUrl == url ) )
                    {
                        TabPages.SelectedItem = _item;
                        return _tab2.Browser;
                    }
                }

                var _tab = new BrowserTabStripItem( );
                _tab.Title = "New Tab";
                TabPages.Items.Insert( TabPages.Items.Count - 1, _tab );
                _newTabItem = _tab;
                var _newTab = AddNewBrowser( _newTabItem, url );
                _newTab.ReferringUrl = referringUrl;
                if( focusNewTab )
                {
                    Timer.Enabled = true;
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
                url = AppSettings[ "NewTab" ];
            }

            var _browser = new ChromiumWebBrowser( url );
            ConfigureBrowser( _browser );
            _browser.Dock = DockStyle.Fill;
            tabStrip.Controls.Add( _browser );
            _browser.BringToFront( );
            _browser.StatusMessage += OnStatusUpdated;
            _browser.LoadingStateChanged += OnLoadingStateChanged;
            _browser.TitleChanged += OnTitleChanged;
            _browser.LoadError += OnLoadError;
            _browser.AddressChanged += OnUrlChanged;
            _browser.DownloadHandler = _downloadCallback;
            _browser.MenuHandler = _contextMenuCallback;
            _browser.LifeSpanHandler = _lifeSpanCallback;
            _browser.KeyboardHandler = _keyboardCallback;
            _browser.RequestHandler = _requestCallback;
            var _tab = new BrowserTab
            {
                IsOpen = true,
                Browser = _browser,
                Tab = tabStrip,
                OriginalUrl = url,
                CurrentUrl = url,
                Title = url,
                DateCreated = DateTime.Now
            };

            tabStrip.Tag = _tab;
            if( url.StartsWith( AppSettings[ "Internal" ] + ":" ) )
            {
                _browser.JavascriptObjectRepository.Register( "host", Host,
                    BindingOptions.DefaultBinder );
            }

            return _tab;
        }

        /// <summary>
        /// Executes the multi search.
        /// </summary>
        private void SearchGovernmentDomains( string keyWords )
        {
            if( !string.IsNullOrEmpty( keyWords ) )
            {
                try
                {
                    var _google = AppSettings[ "Google" ] + keyWords;
                    CurrentBrowser.LoadUrl( _google );
                    var _epa = AppSettings[ "EPA" ] + keyWords;
                    AddNewBrowserTab( _epa, false );
                    var _data = AppSettings[ "DATA" ] + keyWords;
                    AddNewBrowserTab( _data, false );
                    var _crs = AppSettings[ "CRS" ] + keyWords;
                    AddNewBrowserTab( _crs, false );
                    var _loc = AppSettings[ "LOC" ] + keyWords;
                    AddNewBrowserTab( _loc, false );
                    var _gpo = AppSettings[ "GPO" ] + keyWords;
                    AddNewBrowserTab( _gpo, false );
                    var _usgi = AppSettings[ "USGI" ] + keyWords;
                    AddNewBrowserTab( _usgi, false );
                    var _omb = AppSettings[ "OMB" ] + keyWords;
                    AddNewBrowserTab( _omb, false );
                    var _ust = AppSettings[ "UST" ] + keyWords;
                    AddNewBrowserTab( _ust, false );
                    var _nara = AppSettings[ "NARA" ] + keyWords;
                    AddNewBrowserTab( _nara, false );
                    var _nasa = AppSettings[ "NASA" ] + keyWords;
                    AddNewBrowserTab( _nasa, false );
                    var _noaa = AppSettings[ "NOAA" ] + keyWords;
                    AddNewBrowserTab( _noaa, false );
                    var _doi = AppSettings[ "DOI" ] + keyWords;
                    AddNewBrowserTab( _doi, false );
                    var _nps = AppSettings[ "NPS" ] + keyWords;
                    AddNewBrowserTab( _nps, false );
                    var _gsa = AppSettings[ "GSA" ] + keyWords;
                    AddNewBrowserTab( _gsa, false );
                    var _doc = AppSettings[ "DOC" ] + keyWords;
                    AddNewBrowserTab( _doc, false );
                    var _hhs = AppSettings[ "HHS" ] + keyWords;
                    AddNewBrowserTab( _hhs, false );
                    var _nrc = AppSettings[ "NRC" ] + keyWords;
                    AddNewBrowserTab( _nrc, false );
                    var _doe = AppSettings[ "DOE" ] + keyWords;
                    AddNewBrowserTab( _doe, false );
                    var _nsf = AppSettings[ "NSF" ] + keyWords;
                    AddNewBrowserTab( _nsf, false );
                    var _usda = AppSettings[ "USDA" ] + keyWords;
                    AddNewBrowserTab( _usda, false );
                    var _csb = AppSettings[ "CSB" ] + keyWords;
                    AddNewBrowserTab( _csb, false );
                    var _irs = AppSettings[ "IRS" ] + keyWords;
                    AddNewBrowserTab( _irs, false );
                    var _fda = AppSettings[ "FDA" ] + keyWords;
                    AddNewBrowserTab( _fda, false );
                    var _cdc = AppSettings[ "CDC" ] + keyWords;
                    AddNewBrowserTab( _cdc, false );
                    var _ace = AppSettings[ "ACE" ] + keyWords;
                    AddNewBrowserTab( _ace, false );
                    var _dhs = AppSettings[ "DHS" ] + keyWords;
                    AddNewBrowserTab( _dhs, false );
                    var _dod = AppSettings[ "DOD" ] + keyWords;
                    AddNewBrowserTab( _dod, false );
                    var _usno = AppSettings[ "USNO" ] + keyWords;
                    AddNewBrowserTab( _usno, false );
                    var _nws = AppSettings[ "NWS" ] + keyWords;
                    AddNewBrowserTab( _nws, false );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Updates the download item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void UpdateDownloadItem( DownloadItem item )
        {
            lock( _downloadItems )
            {
                // SuggestedFileName comes full only
                // in the first attempt so keep it somewhere
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

                _downloadItems[ item.Id ] = item;

                //UpdateSnipProgress();
            }
        }

        /// <summary>
        /// DownloadItems the in progress.
        /// </summary>
        /// <returns></returns>
        public bool DownloadsInProgress( )
        {
            foreach( var _item in _downloadItems.Values )
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
                var _index = TabPages.Items.IndexOf( TabPages.SelectedItem );
                TabPages.RemoveTab( TabPages.SelectedItem );
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
                   == AppSettings[ "Downloads" ] ) )
            {
                TabPages.SelectedItem = _downloadStrip;
            }
            else
            {
                var _brw = AddNewBrowserTab( AppSettings[ "Downloads" ] );
                _downloadStrip = (BrowserTabStripItem)_brw.Parent;
            }
        }

        /// <summary>
        /// Opens the chrome browser.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private void OpenChromeBrowser( string args )
        {
            try
            {
                var _url = AppSettings[ "Google" ] + args;
                var _info = new ProcessStartInfo
                {
                    FileName = AppSettings[ "Chrome" ],
                    LoadUserProfile = true,
                    UseShellExecute = true
                };

                _info.ArgumentList.Add( _url );
                Process.Start( _info );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the chrome browser.
        /// </summary>
        private void OpenChromeBrowser( )
        {
            try
            {
                var _url = AppSettings[ "HomePage" ];
                var _info = new ProcessStartInfo
                {
                    FileName = AppSettings[ "Chrome" ],
                    LoadUserProfile = true,
                    UseShellExecute = true
                };

                _info.ArgumentList.Add( _url );
                Process.Start( _info );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the edge browser.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private void OpenEdgeBrowser( string args )
        {
            try
            {
                var _url = AppSettings[ "Google" ] + args;
                var _info = new ProcessStartInfo
                {
                    FileName = AppSettings[ "Edge" ],
                    LoadUserProfile = true,
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Normal
                };

                _info.ArgumentList.Add( _url );
                Process.Start( _info );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the edge browser.
        /// </summary>
        private void OpenEdgeBrowser( )
        {
            try
            {
                var _url = AppSettings[ "HomePage" ];
                var _info = new ProcessStartInfo
                {
                    FileName = AppSettings[ "Edge" ],
                    LoadUserProfile = true,
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Normal
                };

                _info.ArgumentList.Add( _url );
                Process.Start( _info );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the fire fox browser.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private void OpenFireFoxBrowser( string args )
        {
            try
            {
                var _url = AppSettings[ "Google" ] + args;
                var _info = new ProcessStartInfo
                {
                    FileName = AppSettings[ "FireFox" ],
                    LoadUserProfile = true,
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Normal
                };

                _info.ArgumentList.Add( _url );
                Process.Start( _info );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the fire fox browser.
        /// </summary>
        private void OpenFireFoxBrowser( )
        {
            try
            {
                var _url = AppSettings[ "HomePage" ];
                var _info = new ProcessStartInfo
                {
                    FileName = AppSettings[ "FireFox" ],
                    LoadUserProfile = true,
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Normal
                };

                _info.ArgumentList.Add( _url );
                Process.Start( _info );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the search.
        /// </summary>
        private void OpenSearch( )
        {
            if( !_searchOpen )
            {
                _searchOpen = true;
                InvokeIf( delegate
                {
                    SearchPanel.Visible = true;
                    SearchPanelTextBox.Text = _lastSearch;
                    SearchPanelTextBox.Focus( );
                    SearchPanelTextBox.SelectAll( );
                } );
            }
            else
            {
                InvokeIf( delegate
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
            if( _searchOpen )
            {
                _searchOpen = false;
                InvokeIf( delegate
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
            if( !_fullScreen )
            {
                _oldWindowState = WindowState;
                _oldBorderStyle = FormBorderStyle;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                _fullScreen = true;
            }
            else
            {
                FormBorderStyle = _oldBorderStyle;
                WindowState = _oldWindowState;
                _fullScreen = false;
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
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        private void SendMessage( string message )
        {
            try
            {
                ThrowIf.NullOrEmpty( message, nameof( message ) );
                var _splashMessage = new SplashMessage( message );
                _splashMessage.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializePictureBox( );
                InitializeToolStrip( );
                InitializeHotkeys( );
                InitializeLabels( );
                InitializeTitle( );
                InitializeTooltips( Controls );
                _searchEngineUrl = AppSettings[ "Google" ];
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [URL changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="AddressChangedEventArgs"/>
        /// instance containing the event data.</param>
        private void OnUrlChanged( object sender, AddressChangedEventArgs e )
        {
            InvokeIf( ( ) =>
            {
                // if current tab
                if( sender == CurrentBrowser )
                {
                    if( !WebUtils.IsFocused( UrlTextBox ) )
                    {
                        SetUrl( e.Address );
                    }

                    EnableBackButton( CurrentBrowser.CanGoBack );
                    EnableForwardButton( CurrentBrowser.CanGoForward );
                    SetTabText( (ChromiumWebBrowser)sender, "Loading..." );
                    Separator10.Visible = false;
                    ToolStripRefreshButton.Visible = false;
                    Separator6.Visible = true;
                    ToolStripCancelButton.Visible = true;
                    CurrentTab.DateCreated = DateTime.Now;
                }
            } );
        }

        /// <summary>
        /// Called when [load error].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="LoadErrorEventArgs"/>
        /// instance containing the event data.</param>
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
            InvokeIf( ( ) =>
            {
                var _browser = (ChromiumWebBrowser)sender;
                SetTabText( _browser, e.Title );
            } );
        }

        /// <summary>
        /// Called when [develop tools button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnDeveloperToolsButtonClick( object sender, EventArgs e )
        {
            OpenDeveloperTools( );
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
                    SetTitleText( "Loading..." );
                }
                else
                {
                    // after loaded / stopped
                    InvokeIf( ( ) =>
                    {
                        Separator10.Visible = true;
                        ToolStripRefreshButton.Visible = true;
                        Separator6.Visible = false;
                        ToolStripCancelButton.Visible = false;
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
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
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
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Raises the <see cref="E:TabClosing" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabClosingEventArgs"/>
        /// instance containing the event data.</param>
        private void OnTabClosing( TabClosingEventArgs e )
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
        /// <param name="e">The <see cref="TabItemChangedEventArgs"/>
        /// instance containing the event data.</param>
        private void OnTabsChanged( TabItemChangedEventArgs e )
        {
            ChromiumWebBrowser _browser = null;
            try
            {
                _browser = (ChromiumWebBrowser)e.Item.Controls[ 0 ];
            }
            catch( Exception )
            {
                // ignore 
            }

            if( e.ChangeType == ChangeType.SelectionChanged )
            {
                if( TabPages.SelectedItem == AddItemTab )
                {
                    AddBlankTab( );
                }
                else
                {
                    _browser = CurrentBrowser;
                    SetUrl( _browser.Address );
                    SetTitleText( _browser.Tag.ConvertToString( ) ?? "New Tab" );
                    EnableBackButton( _browser.CanGoBack );
                    EnableForwardButton( _browser.CanGoForward );
                }
            }

            if( e.ChangeType == ChangeType.Removed )
            {
                if( e.Item == _downloadStrip )
                {
                    _downloadStrip = null;
                }

                _browser?.Dispose( );
            }

            if( e.ChangeType == ChangeType.Changed )
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
        /// Called when [search engine selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSelectedDomainChanged( object sender, EventArgs e )
        {
            try
            {
                var _index = ToolStripDomainComboBox.SelectedIndex;
                _searchEngineUrl = _index switch
                {
                    0 => AppSettings[ "Google" ],
                    1 => AppSettings[ "EPA" ],
                    2 => AppSettings[ "DATA" ],
                    3 => AppSettings[ "GPO" ],
                    4 => AppSettings[ "USGI" ],
                    5 => AppSettings[ "CRS" ],
                    6 => AppSettings[ "LOC" ],
                    7 => AppSettings[ "OMB" ],
                    8 => AppSettings[ "UST" ],
                    9 => AppSettings[ "NASA" ],
                    10 => AppSettings[ "NOAA" ],
                    11 => AppSettings[ "DOI" ],
                    12 => AppSettings[ "NPS" ],
                    13 => AppSettings[ "GSA" ],
                    14 => AppSettings[ "NARA" ],
                    15 => AppSettings[ "DOC" ],
                    16 => AppSettings[ "HHS" ],
                    17 => AppSettings[ "NRC" ],
                    18 => AppSettings[ "DOE" ],
                    19 => AppSettings[ "NSF" ],
                    20 => AppSettings[ "USDA" ],
                    21 => AppSettings[ "CSB" ],
                    22 => AppSettings[ "IRS" ],
                    23 => AppSettings[ "FDA" ],
                    24 => AppSettings[ "CDC" ],
                    25 => AppSettings[ "ACE" ],
                    26 => AppSettings[ "DHS" ],
                    27 => AppSettings[ "DOD" ],
                    28 => AppSettings[ "USNO" ],
                    29 => AppSettings[ "NWS" ],
                    _ => AppSettings[ "Google" ]
                };
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
            BeginInvoke( _statusUpdate );
        }

        /// <summary>
        /// Called when [menu close clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMenuCloseClick( object sender, EventArgs e )
        {
            CloseActiveTab( );
        }

        /// <summary>
        /// Called when [close other tabs clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseOtherTabsClick( object sender, EventArgs e )
        {
            CloseOtherTabs( );
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
        private void OnDownloadsButtonClick( object sender, EventArgs e )
        {
            AddNewBrowserTab( AppSettings[ "Downloads" ] );
        }

        /// <summary>
        /// Called when [refresh button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRefreshButtonClick( object sender, EventArgs e )
        {
            RefreshActiveTab( );
        }

        /// <summary>
        /// Called when [stop button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnStopButtonClick( object sender, EventArgs e )
        {
            StopActiveTab( );
        }

        /// <summary>
        /// Called when [menu lable mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSearchButtonClick( object sender, MouseEventArgs e )
        {
            try
            {
                var _search = new SearchDialog( );
                _search.Owner = this;
                _search.Location = new Point( e.X + 600, e.Y + 150 );
                _search.FormClosing += OnSearchDialogClosing;
                _search.DialogKeyWordTextBox.Focus( );
                _search.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [URL text box text changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSearchDialogClosing( object sender, EventArgs e )
        {
            if( sender is SearchDialog _dialog )
            {
                try
                {
                    switch( _dialog.DialogResult )
                    {
                        case DialogResult.OK:
                        {
                            var _search = _dialog.Results;
                            CurrentBrowser.Load( _search );
                            break;
                        }
                        case DialogResult.Cancel:
                        {
                            break;
                        }
                        default:
                        {
                            break;
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
                finally
                {
                    _dialog.DialogKeyWordTextBox.Text = string.Empty;
                    _dialog.DialogDomainComboBox.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Called when [source button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSourceButtonClick( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [URL text box key down].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/>
        /// instance containing the event data.</param>
        private void OnUrlTextBoxKeyDown( object sender, KeyEventArgs e )
        {
            if( e.IsHotKey( Keys.Enter )
               || e.IsHotKey( Keys.Enter, true ) )
            {
                LoadUrl( UrlTextBox.Text );
                e.Handled = true;
                e.SuppressKeyPress = true;
                Focus( );
            }

            if( e.IsHotKey( Keys.C, true )
               && WebUtils.IsFullySelected( UrlTextBox ) )
            {
                Clipboard.SetText( CurrentBrowser.Address, TextDataFormat.UnicodeText );
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
        private void OnUrlTextBoxClick( object sender, EventArgs e )
        {
            if( !WebUtils.HasSelection( UrlTextBox ) )
            {
                UrlTextBox.SelectAll( );
            }
        }

        /// <summary>
        /// Called when [tab pages clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnTabPagesClick( object sender, MouseEventArgs e )
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
                if( MessageBox.Show( "DownloadItems are in progress. Cancel those and exit?",
                       "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                   != DialogResult.Yes )
                {
                    e.Cancel = true;
                    return;
                }
            }

            try
            {
                foreach( TabPage _tab in TabPages.Items )
                {
                    var _browser = (ChromiumWebBrowser)_tab.Controls[ 0 ];
                    _browser.Dispose( );
                }
            }
            catch( Exception )
            {
                // ignore exception
            }
        }

        /// <summary>
        /// Called when [close search button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSearchPanelClearButtonClick( object sender, EventArgs e )
        {
            CloseSearch( );
        }

        /// <summary>
        /// Called when [previous search button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSearchPanelPreviousButtonClick( object sender, EventArgs e )
        {
            FindTextOnPage( false );
        }

        /// <summary>
        /// Called when [next search button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSearchPanelNextButtonClick( object sender, EventArgs e )
        {
            FindTextOnPage( true );
        }

        /// <summary>
        /// Called when [search text changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSearchPanelTextChanged( object sender, EventArgs e )
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
            CurrentBrowser.Load( AppSettings[ "HomePage" ] );
        }

        /// <summary>
        /// Called when [go button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnGoButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _keywords = ToolStripKeyWordTextBox.Text;
                if( !string.IsNullOrEmpty( _keywords )
                   && ( ToolStripDomainComboBox.SelectedIndex == -1 ) )
                {
                    SearchGovernmentDomains( _keywords );
                }
                else if( !string.IsNullOrEmpty( _keywords )
                        && ( ToolStripDomainComboBox.SelectedIndex > -1 ) )
                {
                    var _search = SearchEngineUrl + _keywords;
                    CurrentBrowser.Load( _search );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
            finally
            {
                ToolStripKeyWordTextBox.Text = string.Empty;
                ToolStripDomainComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            try
            {
                Application.Exit( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [fire fox button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFireFoxButtonClick( object sender, EventArgs e )
        {
            ToolStripKeyWordTextBox.SelectAll( );
            var _args = ToolStripKeyWordTextBox.Text;
            if( !string.IsNullOrEmpty( _args ) )
            {
                OpenFireFoxBrowser( _args );
                ToolStripKeyWordTextBox.Clear( );
                ToolStripDomainComboBox.SelectedIndex = -1;
            }
            else
            {
                OpenFireFoxBrowser( );
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnEdgeButtonClick( object sender, EventArgs e )
        {
            ToolStripKeyWordTextBox.SelectAll( );
            var _args = ToolStripKeyWordTextBox.Text;
            if( !string.IsNullOrEmpty( _args ) )
            {
                OpenEdgeBrowser( _args );
                ToolStripKeyWordTextBox.Clear( );
                ToolStripDomainComboBox.SelectedIndex = -1;
            }
            else
            {
                OpenEdgeBrowser( );
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnChromeButtonClick( object sender, EventArgs e )
        {
            ToolStripKeyWordTextBox.SelectAll( );
            var _args = ToolStripKeyWordTextBox.Text;
            if( !string.IsNullOrEmpty( _args ) )
            {
                OpenChromeBrowser( _args );
                ToolStripKeyWordTextBox.Clear( );
                ToolStripDomainComboBox.SelectedIndex = -1;
            }
            else
            {
                OpenChromeBrowser( );
            }
        }

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    ContextMenu.Show( this, e.Location );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [context menu item click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnContextMenuItemClick( object sender, MouseEventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem _item )
            {
                try
                {
                    var _type = _item.Tag?.ToString( );
                    var _option = (MenuItem)Enum.Parse( typeof( MenuItem ), _type );
                    switch( _option )
                    {
                        case MenuItem.Close:
                        {
                            CloseActiveTab( );
                            break;
                        }
                        case MenuItem.Other:
                        {
                            CloseOtherTabs( );
                            break;
                        }
                        case MenuItem.Refresh:
                        {
                            RefreshActiveTab( );
                            break;
                        }
                        case MenuItem.SaveAs:
                        {
                            var _fileDialog = new SaveFileDialog( );
                            _fileDialog.ShowDialog( Instance );
                            break;
                        }
                        case MenuItem.Print:
                        {
                            var _printDialog = new PrintDialog( );
                            _printDialog.ShowDialog( Instance );
                            break;
                        }
                        case MenuItem.Developer:
                        {
                            OpenDeveloperTools( );
                            break;
                        }
                        case MenuItem.Source:
                        {
                            SendNotification( );
                            break;
                        }
                        case MenuItem.Chrome:
                        {
                            OpenChromeBrowser( );
                            break;
                        }
                        case MenuItem.Edge:
                        {
                            OpenEdgeBrowser( );
                            break;
                        }
                        case MenuItem.Firefox:
                        {
                            OpenFireFoxBrowser( );
                            break;
                        }
                        case MenuItem.Calculator:
                        {
                            WinMinion.LaunchCalculator( );
                            break;
                        }
                        case MenuItem.ControlPanel:
                        {
                            WinMinion.LaunchControlPanel( );
                            break;
                        }
                        case MenuItem.TaskManager:
                        {
                            WinMinion.LaunchTaskManager( );
                            break;
                        }
                        case MenuItem.OneDrive:
                        {
                            WinMinion.LaunchOneDrive( );
                            break;
                        }
                        case MenuItem.Exit:
                        {
                            Application.Exit( );
                            break;
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
                finally
                {
                    ContextMenu.Hide( );
                }
            }
        }

        /// <summary>
        /// Called when [context menu mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnContextMenuMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( sender is ContextMenu _menu )
                {
                    _menu.Hide( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [refresh button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSharepointButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _message = "THIS HAS NOT BEEN IMPLEMENTED";
                SendMessage( _message );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [form closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFormClosing( object sender, EventArgs e )
        {
            try
            {
                Timer?.Dispose( );
                Opacity = 1;
                FadeOutAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnActivated( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                FadeInAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}