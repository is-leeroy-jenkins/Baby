// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 10-10-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        10-10-2024
// ******************************************************************************************
// <copyright file="App.xaml.cs" company="Terry D. Eppler">
//    A light-weight, full-featured, open-source web browser
//    written in C# and released under the MIT license.
// 
//    Copyright ©  2020-2024 Terry D. Eppler
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
//   App.xaml.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Media;
    using CefSharp;
    using CefSharp.Wpf;
    using OfficeOpenXml;
    using Syncfusion.Licensing;
    using Syncfusion.SfSkinManager;
    using Syncfusion.Themes.FluentDark.WPF;
    using Syncfusion.Windows.Forms;
    using ToastNotifications;
    using ToastNotifications.Lifetime;
    using ToastNotifications.Messages;
    using ToastNotifications.Position;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Application" />
    [ SuppressMessage( "ReSharper", "RedundantExtendsListEntry" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class App : Application
    {
        /// <summary>
        /// The mutex
        /// </summary>
        private Mutex _mutex;

        /// <summary>
        /// The controls
        /// </summary>
        public static string[ ] Controls =
        {
            "ComboBoxAdv",
            "MetroComboBox",
            "MetroDatagrid",
            "SfDataGrid",
            "ToolBarAdv",
            "ToolStrip",
            "MetroCalendar",
            "CalendarEdit",
            "PivotGridControl",
            "MetroPivotGrid",
            "SfChart",
            "SfChart3D",
            "SfHeatMap",
            "SfMap",
            "MetroMap",
            "EditControl",
            "CheckListBox",
            "MetroEditor",
            "DropDownButtonAdv",
            "MetroDropDown",
            "TextBoxExt",
            "SfCircularProgressBar",
            "SfLinearProgressBar",
            "GridControl",
            "MetroGridControl",
            "TabControlExt",
            "MetroTabControl",
            "SfTextInputLayout",
            "MetroTextInput",
            "SfSpreadsheet",
            "SfSpreadsheetRibbon",
            "MenuItemAdv",
            "ButtonAdv",
            "Carousel",
            "ColorEdit",
            "SfCalculator",
            "SfMultiColumnDropDownControl"
        };

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.App" /> class.
        /// </summary>
        public App( )
        {
            // Application Settings
            InitializeCefSharp( );
            var _key = ConfigurationManager.AppSettings[ "UI" ];
            SyncfusionLicenseProvider.RegisterLicense( _key );
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ActiveWindows = new Dictionary<string, Window>( );
            RegisterTheme( );

            // Event Wiring
            Startup += OnStartup;
            Exit += OnExit;
        }

        /// <summary>
        /// Gets or sets the windows.
        /// </summary>
        /// <value>
        /// The windows.
        /// </value>
        public static IDictionary<string, Window> ActiveWindows { get; private set; }

        /// <summary>
        /// Registers the theme.
        /// </summary>
        private void RegisterTheme()
        {
            var _theme = new FluentDarkThemeSettings
            {
                PrimaryBackground = new SolidColorBrush(Color.FromRgb(20, 20, 20)),
                PrimaryColorForeground = new SolidColorBrush(Color.FromRgb(0, 120, 212)),
                PrimaryForeground = new SolidColorBrush(Color.FromRgb(222, 222, 222)),
                BodyFontSize = 12,
                HeaderFontSize = 16,
                SubHeaderFontSize = 14,
                TitleFontSize = 14,
                SubTitleFontSize = 16,
                BodyAltFontSize = 11,
                FontFamily = new FontFamily("Roboto-Regular")
            };

            SfSkinManager.RegisterThemeSettings("FluentDark", _theme);
            SfSkinManager.ApplyStylesOnApplication = true;
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        private void InvokeIf(Action action)
        {
            try
            {
                ThrowIf.Null(action, nameof(action));
                if(Dispatcher.CheckAccess())
                {
                    action?.Invoke();
                }
                else
                {
                    Dispatcher.BeginInvoke(action);
                }
            }
            catch(Exception ex)
            {
                Fail(ex);
            }
        }

        /// <summary>
        /// Invokes if.
        /// </summary>
        /// <param name="action">The action.</param>
        private void InvokeIf(Action<object> action)
        {
            try
            {
                ThrowIf.Null(action, nameof(action));
                if(Dispatcher.CheckAccess())
                {
                    action?.Invoke(null);
                }
                else
                {
                    Dispatcher.BeginInvoke(action);
                }
            }
            catch(Exception ex)
            {
                Fail(ex);
            }
        }

        /// <summary>
        /// Creates a notifier.
        /// </summary>
        /// <returns>
        /// Notifier
        /// </returns>
        private Notifier CreateNotifier()
        {
            try
            {
                var _position = new PrimaryScreenPositionProvider(Corner.BottomRight, 10, 10);
                var _lifeTime = new TimeAndCountBasedLifetimeSupervisor(TimeSpan.FromSeconds(5),
                    MaximumNotificationCount.UnlimitedNotifications());

                return new Notifier(_cfg =>
                {
                    _cfg.LifetimeSupervisor = _lifeTime;
                    _cfg.PositionProvider = _position;
                    _cfg.Dispatcher = Current.Dispatcher;
                });
            }
            catch(Exception ex)
            {
                Fail(ex);
                return default(Notifier);
            }
        }

        /// <summary>
        /// Sends the notification.
        /// </summary>
        /// <param name="message">The message.</param>
        private void SendNotification(string message)
        {
            try
            {
                ThrowIf.Null(message, nameof(message));
                var _notification = CreateNotifier();
                _notification.ShowInformation(message);
            }
            catch(Exception ex)
            {
                Fail(ex);
            }
        }

        /// <summary>
        /// Shows the splash message.
        /// </summary>
        /// <param name="message">The message.</param>
        private void SendMessage(string message)
        {
            try
            {
                ThrowIf.Null(message, nameof(message));
                var _splash = new SplashMessage(message);
                _splash.Show();
            }
            catch(Exception ex)
            {
                Fail(ex);
            }
        }

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="e">The e.</param>
        private void HandleException( Exception e )
        {
            if( e == null )
            {
                return;
            }
            else
            {
                Fail( e );
                Environment.Exit( 1 );
            }
        }

        /// <summary>
        /// this is done just once, to globally initialize CefSharp/CEF
        /// </summary>
        protected virtual void InitializeCefSharp( )
        {
            try
            {
                var _cefSettings = new CefSettings( );
                _cefSettings.RegisterScheme( new CefCustomScheme
                {
                    SchemeName = ConfigurationManager.AppSettings[ "Internal" ],
                    SchemeHandlerFactory = new SchemaCallbackFactory( )
                });

                _cefSettings.UserAgent = ConfigurationManager.AppSettings[ "UserAgent" ];
                _cefSettings.AcceptLanguageList = ConfigurationManager.AppSettings[ "AcceptLanguage" ];
                _cefSettings.IgnoreCertificateErrors = true;
                _cefSettings.CachePath = GetApplicationDirectory( "Cache" );
                if( bool.Parse( ConfigurationManager.AppSettings[ "Proxy" ] ) )
                {
                    CefSharpSettings.Proxy = new ProxyOptions( ConfigurationManager.AppSettings[ "ProxyIP" ],
                        ConfigurationManager.AppSettings[ "ProxyPort" ], 
                        ConfigurationManager.AppSettings[ "ProxyUsername" ],
                        ConfigurationManager.AppSettings[ "ProxyPassword" ], 
                        ConfigurationManager.AppSettings[ "ProxyBypassList" ] );
                }

                Cef.Initialize( _cefSettings );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the application directory.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private protected static string GetApplicationDirectory( string name )
        {
            try
            {
                ThrowIf.NullOrEmpty( name, nameof( name ) );
                var _winXpDir = @"C:\Documents and Settings\All Users\Application Data\";
                return Directory.Exists( _winXpDir )
                    ? _winXpDir + ConfigurationManager.AppSettings[ "Branding" ] + @"\" + name + @"\"
                    : @"C:\ProgramData\" + ConfigurationManager.AppSettings[ "Branding" ] + @"\" + name + @"\";
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Called when [startup].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="startArgs">The
        /// <see cref="StartupEventArgs"/>
        /// instance containing the event data.
        /// </param>
        protected virtual void OnStartup( object sender, StartupEventArgs startArgs )
        {
            DispatcherUnhandledException += ( s, args ) => HandleException( args.Exception );
            TaskScheduler.UnobservedTaskException += ( s, args ) =>
                HandleException( args.Exception?.InnerException );

            AppDomain.CurrentDomain.UnhandledException += ( s, args ) =>
                HandleException( args.ExceptionObject as Exception );
        }

        /// <summary>
        /// Raises the <see cref="sender" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.Windows.ExitEventArgs" />
        /// that contains the event data.</param>
        protected void OnExit( object sender, ExitEventArgs e )
        {
            Cef.Shutdown( );
            Environment.Exit( 0 );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex ) 
        {
            var _error = new ErrorWindow( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}