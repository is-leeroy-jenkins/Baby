

namespace BudgetBrowser
{
	using CefSharp.WinForms;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// POCO created for holding data per tab
	/// </summary>
	public class BrowserTab 
	{

		public bool IsOpen;

		public string OrigURL;
		public string CurURL;
		public string Title;

		public string ReferringUrl;

		public DateTime DateCreated;

		public BrowserTabStripItem Tab;
		public ChromiumWebBrowser Browser;

	}
}
