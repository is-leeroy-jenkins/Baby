namespace BudgetBrowser
{
	using CefSharp;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	internal static class BrowserConfig {


		public static string Branding = "Budget Browser";
		public static string AcceptLanguage = "en-US,en;q=0.9";
		public static string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.5112.102 Safari/537.36 /CefSharp Browser" + Cef.CefSharpVersion; // UserAgent to fix issue with Google account authentication		
		public static string HomepageURL = "https://www.google.com";
		public static string NewTabURL = "about:blank";
		public static string InternalURL = "budgetbrowser";
		public static string DownloadsURL = "budgetbrowser://storage/downloads.html";
		public static string FileNotFoundURL = "budgetbrowser://storage/errors/notFound.html";
		public static string CannotConnectURL = "budgetbrowser://storage/errors/cannotConnect.html";
		public static string SearchURL = "https://www.google.com/search?q=";

		public static bool WebSecurity = true;
		public static bool CrossDomainSecurity = true;
		public static bool WebGL = true;
		public static bool ApplicationCache = true;

		public static bool Proxy = false;
		public static string ProxyIP = "123.123.123.123";
		public static int ProxyPort = 123;
		public static string ProxyUsername = "username";
		public static string ProxyPassword = "pass";
		public static string ProxyBypassList = "";

	}
}
