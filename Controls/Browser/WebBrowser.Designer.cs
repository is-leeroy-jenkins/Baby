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
			this.MenuTabStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CloseTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseOthersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RefreshSearchButton = new System.Windows.Forms.Button();
			this.StopSearchButton = new System.Windows.Forms.Button();
			this.NextSearchButton = new System.Windows.Forms.Button();
			this.PreviousSearchButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SearchDownloadButton = new System.Windows.Forms.Button();
			this.PrimaryTextBox = new System.Windows.Forms.TextBox();
			this.PanelToolbar = new System.Windows.Forms.Panel();
			this.TabPages = new BrowserTabStrip();
			this.TabItem = new BrowserTabStripItem();
			this.AddItemTab = new BrowserTabStripItem();
			this.StatusPanel = new System.Windows.Forms.Panel();
			this.SearchPanel = new System.Windows.Forms.Panel();
			this.NextButton = new System.Windows.Forms.Button();
			this.PreviousButton = new System.Windows.Forms.Button();
			this.CloseSearchButton = new System.Windows.Forms.Button();
			this.SearchPanelTextBox = new System.Windows.Forms.TextBox();
			this.HomeButton = new System.Windows.Forms.Button();
			this.MenuTabStrip.SuspendLayout();
			this.PanelToolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TabPages)).BeginInit();
			this.TabPages.SuspendLayout();
			this.SearchPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripTab
			// 
			this.MenuTabStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuTabStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CloseTabMenuItem,
			this.CloseOthersMenuItem});
			this.MenuTabStrip.Name = "MenuTabStrip";
			this.MenuTabStrip.Size = new System.Drawing.Size(198, 52);
			// 
			// menuCloseTab
			// 
			this.CloseTabMenuItem.Name = "CloseTabMenuItem";
			this.CloseTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
			this.CloseTabMenuItem.Size = new System.Drawing.Size(197, 24);
			this.CloseTabMenuItem.Text = "Close tab";
			this.CloseTabMenuItem.Click += new System.EventHandler(this.OnMenuCloseClicked);
			// 
			// menuCloseOtherTabs
			// 
			this.CloseOthersMenuItem.Name = "CloseOthersMenuItem";
			this.CloseOthersMenuItem.Size = new System.Drawing.Size(197, 24);
			this.CloseOthersMenuItem.Text = "Close other tabs";
			this.CloseOthersMenuItem.Click += new System.EventHandler(this.OnCloseOtherTabsClicked);
			// 
			// BtnRefresh
			// 
			this.RefreshSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RefreshSearchButton.ForeColor = System.Drawing.Color.White;
			this.RefreshSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
			this.RefreshSearchButton.Location = new System.Drawing.Point(878, 0);
			this.RefreshSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RefreshSearchButton.Name = "RefreshSearchButton";
			this.RefreshSearchButton.Size = new System.Drawing.Size(25, 30);
			this.RefreshSearchButton.TabIndex = 3;
			this.RefreshSearchButton.UseVisualStyleBackColor = true;
			this.RefreshSearchButton.Click += new System.EventHandler(this.OnRefreshButtonClicked);
			// 
			// BtnStop
			// 
			this.StopSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StopSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StopSearchButton.ForeColor = System.Drawing.Color.White;
			this.StopSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
			this.StopSearchButton.Location = new System.Drawing.Point(878, -2);
			this.StopSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.StopSearchButton.Name = "StopSearchButton";
			this.StopSearchButton.Size = new System.Drawing.Size(25, 30);
			this.StopSearchButton.TabIndex = 2;
			this.StopSearchButton.UseVisualStyleBackColor = true;
			this.StopSearchButton.Click += new System.EventHandler(this.OnStopButtonClicked);
			// 
			// BtnForward
			// 
			this.NextSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NextSearchButton.ForeColor = System.Drawing.Color.White;
			this.NextSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnForward.Image")));
			this.NextSearchButton.Location = new System.Drawing.Point(29, 0);
			this.NextSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NextSearchButton.Name = "NextSearchButton";
			this.NextSearchButton.Size = new System.Drawing.Size(25, 30);
			this.NextSearchButton.TabIndex = 1;
			this.NextSearchButton.UseVisualStyleBackColor = true;
			this.NextSearchButton.Click += new System.EventHandler(this.OnForwardButtonClick);
			// 
			// BtnBack
			// 
			this.PreviousSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PreviousSearchButton.ForeColor = System.Drawing.Color.White;
			this.PreviousSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
			this.PreviousSearchButton.Location = new System.Drawing.Point(2, 0);
			this.PreviousSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PreviousSearchButton.Name = "PreviousSearchButton";
			this.PreviousSearchButton.Size = new System.Drawing.Size(25, 30);
			this.PreviousSearchButton.TabIndex = 0;
			this.PreviousSearchButton.UseVisualStyleBackColor = true;
			this.PreviousSearchButton.Click += new System.EventHandler(this.OnBackButtonClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.OnTimerTick);
			// 
			// BtnDownloads
			// 
			this.SearchDownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SearchDownloadButton.ForeColor = System.Drawing.Color.White;
			this.SearchDownloadButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnDownloads.Image")));
			this.SearchDownloadButton.Location = new System.Drawing.Point(906, 0);
			this.SearchDownloadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SearchDownloadButton.Name = "SearchDownloadButton";
			this.SearchDownloadButton.Size = new System.Drawing.Size(25, 30);
			this.SearchDownloadButton.TabIndex = 4;
			this.SearchDownloadButton.Tag = "Downloads";
			this.SearchDownloadButton.UseVisualStyleBackColor = true;
			this.SearchDownloadButton.Click += new System.EventHandler(this.OnDownloadsButtonClicked);
			// 
			// TxtURL
			// 
			this.PrimaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.PrimaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PrimaryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrimaryTextBox.Location = new System.Drawing.Point(60, 5);
			this.PrimaryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PrimaryTextBox.Name = "PrimaryTextBox";
			this.PrimaryTextBox.Size = new System.Drawing.Size(812, 27);
			this.PrimaryTextBox.TabIndex = 5;
			this.PrimaryTextBox.Click += new System.EventHandler(this.OnUrlTextBoxClicked);
			this.PrimaryTextBox.TextChanged += new System.EventHandler(this.OnUrlTextBoxTextChanged);
			this.PrimaryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnUrlTextBoxKeyDown);
			// 
			// PanelToolbar
			// 
			this.PanelToolbar.BackColor = System.Drawing.Color.White;
			this.PanelToolbar.Controls.Add(this.HomeButton);
			this.PanelToolbar.Controls.Add(this.PrimaryTextBox);
			this.PanelToolbar.Controls.Add(this.SearchDownloadButton);
			this.PanelToolbar.Controls.Add(this.NextSearchButton);
			this.PanelToolbar.Controls.Add(this.PreviousSearchButton);
			this.PanelToolbar.Controls.Add(this.RefreshSearchButton);
			this.PanelToolbar.Controls.Add(this.StopSearchButton);
			this.PanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelToolbar.Location = new System.Drawing.Point(0, 0);
			this.PanelToolbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PanelToolbar.Name = "PanelToolbar";
			this.PanelToolbar.Size = new System.Drawing.Size(934, 30);
			this.PanelToolbar.TabIndex = 6;
			// 
			// TabPages
			// 
			this.TabPages.ContextMenuStrip = this.MenuTabStrip;
			this.TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPages.Items.AddRange(new BrowserTabStripItem[] {
			this.TabItem,
			this.AddItemTab});
			this.TabPages.Location = new System.Drawing.Point(0, 30);
			this.TabPages.Name = "TabPages";
			this.TabPages.SelectedItem = this.TabItem;
			this.TabPages.Size = new System.Drawing.Size(934, 621);
			this.TabPages.TabIndex = 4;
			this.TabPages.Text = "faTabStrip1";
			this.TabPages.TabStripItemSelectionChanged += new TabItemChange(this.OnTabsChanged);
			this.TabPages.TabStripItemClosed += new System.EventHandler(this.OnTabClosed);
			this.TabPages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTabPagesClicked);
			// 
			// tabStrip1
			// 
			this.TabItem.IsDrawn = true;
			this.TabItem.Name = "TabItem";
			this.TabItem.IsSelected = true;
			this.TabItem.Size = new System.Drawing.Size(932, 591);
			this.TabItem.TabIndex = 0;
			this.TabItem.Title = "Loading...";
			// 
			// tabStripAdd
			// 
			this.AddItemTab.CanClose = false;
			this.AddItemTab.IsDrawn = true;
			this.AddItemTab.Name = "AddItemTab";
			this.AddItemTab.Size = new System.Drawing.Size(931, 601);
			this.AddItemTab.TabIndex = 1;
			this.AddItemTab.Title = "+";
			// 
			// PanelStatus
			// 
			this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.StatusPanel.Location = new System.Drawing.Point(0, 651);
			this.StatusPanel.Name = "StatusPanel";
			this.StatusPanel.Size = new System.Drawing.Size(934, 20);
			this.StatusPanel.TabIndex = 8;
			// 
			// PanelSearch
			// 
			this.SearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchPanel.BackColor = System.Drawing.Color.White;
			this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SearchPanel.Controls.Add(this.NextButton);
			this.SearchPanel.Controls.Add(this.PreviousButton);
			this.SearchPanel.Controls.Add(this.CloseSearchButton);
			this.SearchPanel.Controls.Add(this.SearchPanelTextBox);
			this.SearchPanel.Location = new System.Drawing.Point(625, 41);
			this.SearchPanel.Name = "SearchPanel";
			this.SearchPanel.Size = new System.Drawing.Size(307, 40);
			this.SearchPanel.TabIndex = 9;
			this.SearchPanel.Visible = false;
			// 
			// BtnNextSearch
			// 
			this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NextButton.ForeColor = System.Drawing.Color.White;
			this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnNextSearch.Image")));
			this.NextButton.Location = new System.Drawing.Point(239, 4);
			this.NextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(25, 30);
			this.NextButton.TabIndex = 9;
			this.NextButton.Tag = "Find next (Enter)";
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.OnNextSearchButtonClick);
			// 
			// BtnPrevSearch
			// 
			this.PreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PreviousButton.ForeColor = System.Drawing.Color.White;
			this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevSearch.Image")));
			this.PreviousButton.Location = new System.Drawing.Point(206, 4);
			this.PreviousButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PreviousButton.Name = "PreviousButton";
			this.PreviousButton.Size = new System.Drawing.Size(25, 30);
			this.PreviousButton.TabIndex = 8;
			this.PreviousButton.Tag = "Find previous (Shift+Enter)";
			this.PreviousButton.UseVisualStyleBackColor = true;
			this.PreviousButton.Click += new System.EventHandler(this.OnPreviousSearchButtonClick);
			// 
			// BtnCloseSearch
			// 
			this.CloseSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseSearchButton.ForeColor = System.Drawing.Color.White;
			this.CloseSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSearch.Image")));
			this.CloseSearchButton.Location = new System.Drawing.Point(272, 4);
			this.CloseSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CloseSearchButton.Name = "CloseSearchButton";
			this.CloseSearchButton.Size = new System.Drawing.Size(25, 30);
			this.CloseSearchButton.TabIndex = 7;
			this.CloseSearchButton.Tag = "Close (Esc)";
			this.CloseSearchButton.UseVisualStyleBackColor = true;
			this.CloseSearchButton.Click += new System.EventHandler(this.OnCloseSearchButtonClick);
			// 
			// TxtSearch
			// 
			this.SearchPanelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.SearchPanelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SearchPanelTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchPanelTextBox.Location = new System.Drawing.Point(10, 6);
			this.SearchPanelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SearchPanelTextBox.Name = "SearchPanelTextBox";
			this.SearchPanelTextBox.Size = new System.Drawing.Size(181, 31);
			this.SearchPanelTextBox.TabIndex = 6;
			this.SearchPanelTextBox.TextChanged += new System.EventHandler(this.OnSearchTextChanged);
			this.SearchPanelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchKeyDown);
			// 
			// BtnHome
			// 
			this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.HomeButton.ForeColor = System.Drawing.Color.White;
			this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
			this.HomeButton.Location = new System.Drawing.Point(847, 0);
			this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.HomeButton.Name = "HomeButton";
			this.HomeButton.Size = new System.Drawing.Size(25, 30);
			this.HomeButton.TabIndex = 6;
			this.HomeButton.Tag = "Home";
			this.HomeButton.UseVisualStyleBackColor = true;
			this.HomeButton.Click += new System.EventHandler(this.OnHomeButtonClick);
			// 
			// WebBrowser
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(934, 671);
			this.Controls.Add(this.SearchPanel);
			this.Controls.Add(this.TabPages);
			this.Controls.Add(this.PanelToolbar);
			this.Controls.Add(this.StatusPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Title";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
			this.Load += new System.EventHandler(this.OnLoad);
			this.MenuTabStrip.ResumeLayout(false);
			this.PanelToolbar.ResumeLayout(false);
			this.PanelToolbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TabPages)).EndInit();
			this.TabPages.ResumeLayout(false);
			this.SearchPanel.ResumeLayout(false);
			this.SearchPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public BrowserTabStrip TabPages;
		public BrowserTabStripItem TabItem;
		public BrowserTabStripItem AddItemTab;
		public System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.ContextMenuStrip MenuTabStrip;
		public System.Windows.Forms.ToolStripMenuItem CloseTabMenuItem;
		public System.Windows.Forms.ToolStripMenuItem CloseOthersMenuItem;
		public System.Windows.Forms.Button NextSearchButton;
		public System.Windows.Forms.Button PreviousSearchButton;
		public System.Windows.Forms.Button StopSearchButton;
		public System.Windows.Forms.Button RefreshSearchButton;
		public System.Windows.Forms.Button SearchDownloadButton;
		public System.Windows.Forms.TextBox PrimaryTextBox;
		public System.Windows.Forms.Panel PanelToolbar;
		public System.Windows.Forms.Panel StatusPanel;
		public System.Windows.Forms.Panel SearchPanel;
		public System.Windows.Forms.TextBox SearchPanelTextBox;
		public System.Windows.Forms.Button CloseSearchButton;
		public System.Windows.Forms.Button PreviousButton;
		public System.Windows.Forms.Button NextButton;
		public System.Windows.Forms.Button HomeButton;
	}
}

