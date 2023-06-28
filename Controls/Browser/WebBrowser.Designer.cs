namespace BudgetBrowser
{
	public partial class WebBrowser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
			this.menuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuCloseTab = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCloseOtherTabs = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnRefresh = new System.Windows.Forms.Button();
			this.BtnStop = new System.Windows.Forms.Button();
			this.BtnForward = new System.Windows.Forms.Button();
			this.BtnBack = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.BtnDownloads = new System.Windows.Forms.Button();
			this.TxtURL = new System.Windows.Forms.TextBox();
			this.PanelToolbar = new System.Windows.Forms.Panel();
			this.TabPages = new BrowserTabStrip();
			this.tabStrip1 = new BrowserTabStripItem();
			this.tabStripAdd = new BrowserTabStripItem();
			this.PanelStatus = new System.Windows.Forms.Panel();
			this.PanelSearch = new System.Windows.Forms.Panel();
			this.BtnNextSearch = new System.Windows.Forms.Button();
			this.BtnPrevSearch = new System.Windows.Forms.Button();
			this.BtnCloseSearch = new System.Windows.Forms.Button();
			this.TxtSearch = new System.Windows.Forms.TextBox();
			this.BtnHome = new System.Windows.Forms.Button();
			this.menuStripTab.SuspendLayout();
			this.PanelToolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TabPages)).BeginInit();
			this.TabPages.SuspendLayout();
			this.PanelSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripTab
			// 
			this.menuStripTab.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuCloseTab,
			this.menuCloseOtherTabs});
			this.menuStripTab.Name = "menuStripTab";
			this.menuStripTab.Size = new System.Drawing.Size(198, 52);
			// 
			// menuCloseTab
			// 
			this.menuCloseTab.Name = "menuCloseTab";
			this.menuCloseTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
			this.menuCloseTab.Size = new System.Drawing.Size(197, 24);
			this.menuCloseTab.Text = "Close tab";
			this.menuCloseTab.Click += new System.EventHandler(this.OnMenuCloseClicked);
			// 
			// menuCloseOtherTabs
			// 
			this.menuCloseOtherTabs.Name = "menuCloseOtherTabs";
			this.menuCloseOtherTabs.Size = new System.Drawing.Size(197, 24);
			this.menuCloseOtherTabs.Text = "Close other tabs";
			this.menuCloseOtherTabs.Click += new System.EventHandler(this.OnCloseOtherTabsClicked);
			// 
			// BtnRefresh
			// 
			this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRefresh.ForeColor = System.Drawing.Color.White;
			this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
			this.BtnRefresh.Location = new System.Drawing.Point(878, 0);
			this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new System.Drawing.Size(25, 30);
			this.BtnRefresh.TabIndex = 3;
			this.BtnRefresh.UseVisualStyleBackColor = true;
			this.BtnRefresh.Click += new System.EventHandler(this.OnRefreshButtonClicked);
			// 
			// BtnStop
			// 
			this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStop.ForeColor = System.Drawing.Color.White;
			this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
			this.BtnStop.Location = new System.Drawing.Point(878, -2);
			this.BtnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(25, 30);
			this.BtnStop.TabIndex = 2;
			this.BtnStop.UseVisualStyleBackColor = true;
			this.BtnStop.Click += new System.EventHandler(this.OnStopButtonClicked);
			// 
			// BtnForward
			// 
			this.BtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnForward.ForeColor = System.Drawing.Color.White;
			this.BtnForward.Image = ((System.Drawing.Image)(resources.GetObject("BtnForward.Image")));
			this.BtnForward.Location = new System.Drawing.Point(29, 0);
			this.BtnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnForward.Name = "BtnForward";
			this.BtnForward.Size = new System.Drawing.Size(25, 30);
			this.BtnForward.TabIndex = 1;
			this.BtnForward.UseVisualStyleBackColor = true;
			this.BtnForward.Click += new System.EventHandler(this.OnForwardButtonClick);
			// 
			// BtnBack
			// 
			this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBack.ForeColor = System.Drawing.Color.White;
			this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
			this.BtnBack.Location = new System.Drawing.Point(2, 0);
			this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnBack.Name = "BtnBack";
			this.BtnBack.Size = new System.Drawing.Size(25, 30);
			this.BtnBack.TabIndex = 0;
			this.BtnBack.UseVisualStyleBackColor = true;
			this.BtnBack.Click += new System.EventHandler(this.OnBackButtonClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.OnTimerTick);
			// 
			// BtnDownloads
			// 
			this.BtnDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnDownloads.ForeColor = System.Drawing.Color.White;
			this.BtnDownloads.Image = ((System.Drawing.Image)(resources.GetObject("BtnDownloads.Image")));
			this.BtnDownloads.Location = new System.Drawing.Point(906, 0);
			this.BtnDownloads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnDownloads.Name = "BtnDownloads";
			this.BtnDownloads.Size = new System.Drawing.Size(25, 30);
			this.BtnDownloads.TabIndex = 4;
			this.BtnDownloads.Tag = "Downloads";
			this.BtnDownloads.UseVisualStyleBackColor = true;
			this.BtnDownloads.Click += new System.EventHandler(this.OnDownloadsButtonClicked);
			// 
			// TxtURL
			// 
			this.TxtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TxtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TxtURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtURL.Location = new System.Drawing.Point(60, 5);
			this.TxtURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TxtURL.Name = "TxtURL";
			this.TxtURL.Size = new System.Drawing.Size(812, 27);
			this.TxtURL.TabIndex = 5;
			this.TxtURL.Click += new System.EventHandler(this.OnUrlTextBoxClicked);
			this.TxtURL.TextChanged += new System.EventHandler(this.OnUrlTextBoxTextChanged);
			this.TxtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnUrlTextBoxKeyDown);
			// 
			// PanelToolbar
			// 
			this.PanelToolbar.BackColor = System.Drawing.Color.White;
			this.PanelToolbar.Controls.Add(this.BtnHome);
			this.PanelToolbar.Controls.Add(this.TxtURL);
			this.PanelToolbar.Controls.Add(this.BtnDownloads);
			this.PanelToolbar.Controls.Add(this.BtnForward);
			this.PanelToolbar.Controls.Add(this.BtnBack);
			this.PanelToolbar.Controls.Add(this.BtnRefresh);
			this.PanelToolbar.Controls.Add(this.BtnStop);
			this.PanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelToolbar.Location = new System.Drawing.Point(0, 0);
			this.PanelToolbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PanelToolbar.Name = "PanelToolbar";
			this.PanelToolbar.Size = new System.Drawing.Size(934, 30);
			this.PanelToolbar.TabIndex = 6;
			// 
			// TabPages
			// 
			this.TabPages.ContextMenuStrip = this.menuStripTab;
			this.TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPages.Items.AddRange(new BrowserTabStripItem[] {
			this.tabStrip1,
			this.tabStripAdd});
			this.TabPages.Location = new System.Drawing.Point(0, 30);
			this.TabPages.Name = "TabPages";
			this.TabPages.SelectedItem = this.tabStrip1;
			this.TabPages.Size = new System.Drawing.Size(934, 621);
			this.TabPages.TabIndex = 4;
			this.TabPages.Text = "faTabStrip1";
			this.TabPages.TabStripItemSelectionChanged += new TabStripItemChangedHandler(this.OnTabsChanged);
			this.TabPages.TabStripItemClosed += new System.EventHandler(this.OnTabClosed);
			this.TabPages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTabPagesClicked);
			// 
			// tabStrip1
			// 
			this.tabStrip1.IsDrawn = true;
			this.tabStrip1.Name = "tabStrip1";
			this.tabStrip1.IsSelected = true;
			this.tabStrip1.Size = new System.Drawing.Size(932, 591);
			this.tabStrip1.TabIndex = 0;
			this.tabStrip1.Title = "Loading...";
			// 
			// tabStripAdd
			// 
			this.tabStripAdd.CanClose = false;
			this.tabStripAdd.IsDrawn = true;
			this.tabStripAdd.Name = "tabStripAdd";
			this.tabStripAdd.Size = new System.Drawing.Size(931, 601);
			this.tabStripAdd.TabIndex = 1;
			this.tabStripAdd.Title = "+";
			// 
			// PanelStatus
			// 
			this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PanelStatus.Location = new System.Drawing.Point(0, 651);
			this.PanelStatus.Name = "PanelStatus";
			this.PanelStatus.Size = new System.Drawing.Size(934, 20);
			this.PanelStatus.TabIndex = 8;
			// 
			// PanelSearch
			// 
			this.PanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelSearch.BackColor = System.Drawing.Color.White;
			this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelSearch.Controls.Add(this.BtnNextSearch);
			this.PanelSearch.Controls.Add(this.BtnPrevSearch);
			this.PanelSearch.Controls.Add(this.BtnCloseSearch);
			this.PanelSearch.Controls.Add(this.TxtSearch);
			this.PanelSearch.Location = new System.Drawing.Point(625, 41);
			this.PanelSearch.Name = "PanelSearch";
			this.PanelSearch.Size = new System.Drawing.Size(307, 40);
			this.PanelSearch.TabIndex = 9;
			this.PanelSearch.Visible = false;
			// 
			// BtnNextSearch
			// 
			this.BtnNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnNextSearch.ForeColor = System.Drawing.Color.White;
			this.BtnNextSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnNextSearch.Image")));
			this.BtnNextSearch.Location = new System.Drawing.Point(239, 4);
			this.BtnNextSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnNextSearch.Name = "BtnNextSearch";
			this.BtnNextSearch.Size = new System.Drawing.Size(25, 30);
			this.BtnNextSearch.TabIndex = 9;
			this.BtnNextSearch.Tag = "Find next (Enter)";
			this.BtnNextSearch.UseVisualStyleBackColor = true;
			this.BtnNextSearch.Click += new System.EventHandler(this.OnNextSearchButtonClick);
			// 
			// BtnPrevSearch
			// 
			this.BtnPrevSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPrevSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPrevSearch.ForeColor = System.Drawing.Color.White;
			this.BtnPrevSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevSearch.Image")));
			this.BtnPrevSearch.Location = new System.Drawing.Point(206, 4);
			this.BtnPrevSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnPrevSearch.Name = "BtnPrevSearch";
			this.BtnPrevSearch.Size = new System.Drawing.Size(25, 30);
			this.BtnPrevSearch.TabIndex = 8;
			this.BtnPrevSearch.Tag = "Find previous (Shift+Enter)";
			this.BtnPrevSearch.UseVisualStyleBackColor = true;
			this.BtnPrevSearch.Click += new System.EventHandler(this.OnPreviousSearchButtonClick);
			// 
			// BtnCloseSearch
			// 
			this.BtnCloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCloseSearch.ForeColor = System.Drawing.Color.White;
			this.BtnCloseSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSearch.Image")));
			this.BtnCloseSearch.Location = new System.Drawing.Point(272, 4);
			this.BtnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnCloseSearch.Name = "BtnCloseSearch";
			this.BtnCloseSearch.Size = new System.Drawing.Size(25, 30);
			this.BtnCloseSearch.TabIndex = 7;
			this.BtnCloseSearch.Tag = "Close (Esc)";
			this.BtnCloseSearch.UseVisualStyleBackColor = true;
			this.BtnCloseSearch.Click += new System.EventHandler(this.OnCloseSearchButtonClick);
			// 
			// TxtSearch
			// 
			this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSearch.Location = new System.Drawing.Point(10, 6);
			this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TxtSearch.Name = "TxtSearch";
			this.TxtSearch.Size = new System.Drawing.Size(181, 31);
			this.TxtSearch.TabIndex = 6;
			this.TxtSearch.TextChanged += new System.EventHandler(this.OnSearchTextChanged);
			this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchKeyDown);
			// 
			// BtnHome
			// 
			this.BtnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnHome.ForeColor = System.Drawing.Color.White;
			this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
			this.BtnHome.Location = new System.Drawing.Point(847, 0);
			this.BtnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnHome.Name = "BtnHome";
			this.BtnHome.Size = new System.Drawing.Size(25, 30);
			this.BtnHome.TabIndex = 6;
			this.BtnHome.Tag = "Home";
			this.BtnHome.UseVisualStyleBackColor = true;
			this.BtnHome.Click += new System.EventHandler(this.OnHomeButtonClick);
			// 
			// WebBrowser
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(934, 671);
			this.Controls.Add(this.PanelSearch);
			this.Controls.Add(this.TabPages);
			this.Controls.Add(this.PanelToolbar);
			this.Controls.Add(this.PanelStatus);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Title";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
			this.Load += new System.EventHandler(this.OnLoad);
			this.menuStripTab.ResumeLayout(false);
			this.PanelToolbar.ResumeLayout(false);
			this.PanelToolbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TabPages)).EndInit();
			this.TabPages.ResumeLayout(false);
			this.PanelSearch.ResumeLayout(false);
			this.PanelSearch.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BrowserTabStrip TabPages;
		private BrowserTabStripItem tabStrip1;
		private BrowserTabStripItem tabStripAdd;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ContextMenuStrip menuStripTab;
		private System.Windows.Forms.ToolStripMenuItem menuCloseTab;
		private System.Windows.Forms.ToolStripMenuItem menuCloseOtherTabs;
		private System.Windows.Forms.Button BtnForward;
		private System.Windows.Forms.Button BtnBack;
		private System.Windows.Forms.Button BtnStop;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.Button BtnDownloads;
		private System.Windows.Forms.TextBox TxtURL;
		private System.Windows.Forms.Panel PanelToolbar;
		private System.Windows.Forms.Panel PanelStatus;
		private System.Windows.Forms.Panel PanelSearch;
		private System.Windows.Forms.TextBox TxtSearch;
		private System.Windows.Forms.Button BtnCloseSearch;
		private System.Windows.Forms.Button BtnPrevSearch;
		private System.Windows.Forms.Button BtnNextSearch;
		private System.Windows.Forms.Button BtnHome;
	}
}

