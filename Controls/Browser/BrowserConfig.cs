namespace BudgetBrowser
{
    using System;
    using CefSharp;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public static class BrowserConfig 
    {
        /// <summary>
        /// 
        /// </summary>
        public static string Branding = "Budget Browser";

        /// <summary>
        /// 
        /// </summary>
        public static string AcceptLanguage = "en-US,en;q=0.9";
        
        /// <summary>
        ///  UserAgent to fix issue with Google account authentication
        /// </summary>
        public static string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" 
            + " AppleWebKit/537.36 (KHTML, like Gecko)" 
            + " Chrome/104.0.5112.102 Safari/537.36 /CefSharp Browser" 
            + Cef.CefSharpVersion;

        /// <summary>
        /// 
        /// </summary>
        public static string HomepageURL = "https://www.google.com";

        /// <summary>
        /// 
        /// </summary>
        public static string NewTabURL = "about:blank";

        /// <summary>
        /// 
        /// </summary>
        public static string InternalURL = "budgetbrowser";

        /// <summary>
        /// 
        /// </summary>
        public static string DownloadsURL = "budgetbrowser://storage/downloads.html";

        /// <summary>
        /// 
        /// </summary>
        public static string FileNotFoundURL = "budgetbrowser://storage/errors/notFound.html";

        /// <summary>
        /// 
        /// </summary>
        public static string CannotConnectURL = "budgetbrowser://storage/errors/cannotConnect.html";

        /// <summary>
        /// 
        /// </summary>
        public static string SearchURL = "https://www.google.com/search?q=";

        /// <summary>
        /// 
        /// </summary>
        public static bool WebSecurity = true;

        /// <summary>
        /// 
        /// </summary>
        public static bool CrossDomainSecurity = true;

        /// <summary>
        /// 
        /// </summary>
        public static bool WebGL = true;

        /// <summary>
        /// 
        /// </summary>
        public static bool ApplicationCache = true;

        /// <summary>
        /// 
        /// </summary>
        public static bool Proxy = false;

        /// <summary>
        /// 
        /// </summary>
        public static string ProxyIP = "123.123.123.123";

        /// <summary>
        /// 
        /// </summary>
        public static int ProxyPort = 123;

        /// <summary>
        /// 
        /// </summary>
        public static string ProxyUsername = "username";

        /// <summary>
        /// 
        /// </summary>
        public static string ProxyPassword = "pass";

        /// <summary>
        /// 
        /// </summary>
        public static string ProxyBypassList = "";
    }
}
