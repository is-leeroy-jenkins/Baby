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
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components = new System.ComponentModel.Container( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( WebBrowser ) );
            MenuTabStrip = new System.Windows.Forms.ContextMenuStrip( components );
            CloseTabMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            CloseOthersMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            RefreshSearchButton = new System.Windows.Forms.Button( );
            StopSearchButton = new System.Windows.Forms.Button( );
            NextSearchButton = new System.Windows.Forms.Button( );
            PreviousSearchButton = new System.Windows.Forms.Button( );
            Timer = new System.Windows.Forms.Timer( components );
            SearchDownloadButton = new System.Windows.Forms.Button( );
            PrimaryTextBox = new System.Windows.Forms.TextBox( );
            PanelToolbar = new System.Windows.Forms.Panel( );
            HomeButton = new System.Windows.Forms.Button( );
            TabPages = new BrowserTabStrip( );
            TabItem = new BrowserTabStripItem( );
            AddItemTab = new BrowserTabStripItem( );
            StatusPanel = new System.Windows.Forms.Panel( );
            SearchPanel = new System.Windows.Forms.Panel( );
            NextButton = new System.Windows.Forms.Button( );
            PreviousButton = new System.Windows.Forms.Button( );
            CloseSearchButton = new System.Windows.Forms.Button( );
            SearchPanelTextBox = new System.Windows.Forms.TextBox( );
            MenuTabStrip.SuspendLayout( );
            PanelToolbar.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).BeginInit( );
            TabPages.SuspendLayout( );
            SearchPanel.SuspendLayout( );
            SuspendLayout( );
            // 
            // MenuTabStrip
            // 
            MenuTabStrip.ImageScalingSize = new System.Drawing.Size( 20, 20 );
            MenuTabStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { CloseTabMenuItem, CloseOthersMenuItem } );
            MenuTabStrip.Name = "MenuTabStrip";
            MenuTabStrip.Size = new System.Drawing.Size( 170, 48 );
            // 
            // CloseTabMenuItem
            // 
            CloseTabMenuItem.Name = "CloseTabMenuItem";
            CloseTabMenuItem.ShortcutKeys =   System.Windows.Forms.Keys.Control  |  System.Windows.Forms.Keys.F4  ;
            CloseTabMenuItem.Size = new System.Drawing.Size( 169, 22 );
            CloseTabMenuItem.Text = "Close tab";
            CloseTabMenuItem.Click += OnMenuCloseClicked;
            // 
            // CloseOthersMenuItem
            // 
            CloseOthersMenuItem.Name = "CloseOthersMenuItem";
            CloseOthersMenuItem.Size = new System.Drawing.Size( 169, 22 );
            CloseOthersMenuItem.Text = "Close other tabs";
            CloseOthersMenuItem.Click += OnCloseOtherTabsClicked;
            // 
            // RefreshSearchButton
            // 
            RefreshSearchButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            RefreshSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RefreshSearchButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            RefreshSearchButton.Image = Properties.Resources.SearchRefreshButton;
            RefreshSearchButton.Location = new System.Drawing.Point( 1282, 0 );
            RefreshSearchButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            RefreshSearchButton.Name = "RefreshSearchButton";
            RefreshSearchButton.Size = new System.Drawing.Size( 25, 30 );
            RefreshSearchButton.TabIndex = 3;
            RefreshSearchButton.UseVisualStyleBackColor = true;
            RefreshSearchButton.Click += OnRefreshButtonClicked;
            // 
            // StopSearchButton
            // 
            StopSearchButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            StopSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StopSearchButton.ForeColor = System.Drawing.Color.White;
            StopSearchButton.Location = new System.Drawing.Point( 1282, -2 );
            StopSearchButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            StopSearchButton.Name = "StopSearchButton";
            StopSearchButton.Size = new System.Drawing.Size( 25, 30 );
            StopSearchButton.TabIndex = 2;
            StopSearchButton.UseVisualStyleBackColor = true;
            StopSearchButton.Click += OnStopButtonClicked;
            // 
            // NextSearchButton
            // 
            NextSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NextSearchButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            NextSearchButton.Image = Properties.Resources.SearchNextButton;
            NextSearchButton.Location = new System.Drawing.Point( 29, 0 );
            NextSearchButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            NextSearchButton.Name = "NextSearchButton";
            NextSearchButton.Size = new System.Drawing.Size( 25, 30 );
            NextSearchButton.TabIndex = 1;
            NextSearchButton.UseVisualStyleBackColor = true;
            NextSearchButton.Click += OnForwardButtonClick;
            // 
            // PreviousSearchButton
            // 
            PreviousSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PreviousSearchButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PreviousSearchButton.Image = Properties.Resources.SearchPreviousButton;
            PreviousSearchButton.Location = new System.Drawing.Point( 2, 0 );
            PreviousSearchButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            PreviousSearchButton.Name = "PreviousSearchButton";
            PreviousSearchButton.Size = new System.Drawing.Size( 25, 30 );
            PreviousSearchButton.TabIndex = 0;
            PreviousSearchButton.UseVisualStyleBackColor = true;
            PreviousSearchButton.Click += OnBackButtonClick;
            // 
            // Timer
            // 
            Timer.Interval = 50;
            Timer.Tick += OnTimerTick;
            // 
            // SearchDownloadButton
            // 
            SearchDownloadButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            SearchDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchDownloadButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SearchDownloadButton.Image = Properties.Resources.SearchDownloadButton;
            SearchDownloadButton.Location = new System.Drawing.Point( 1310, 0 );
            SearchDownloadButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            SearchDownloadButton.Name = "SearchDownloadButton";
            SearchDownloadButton.Size = new System.Drawing.Size( 25, 30 );
            SearchDownloadButton.TabIndex = 4;
            SearchDownloadButton.Tag = "Downloads";
            SearchDownloadButton.UseVisualStyleBackColor = true;
            SearchDownloadButton.Click += OnDownloadsButtonClicked;
            // 
            // PrimaryTextBox
            // 
            PrimaryTextBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            PrimaryTextBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            PrimaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PrimaryTextBox.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PrimaryTextBox.ForeColor = System.Drawing.Color.LightGray;
            PrimaryTextBox.Location = new System.Drawing.Point( 60, 5 );
            PrimaryTextBox.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            PrimaryTextBox.Name = "PrimaryTextBox";
            PrimaryTextBox.Size = new System.Drawing.Size( 1185, 20 );
            PrimaryTextBox.TabIndex = 5;
            PrimaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            PrimaryTextBox.Click += OnUrlTextBoxClicked;
            PrimaryTextBox.TextChanged += OnUrlTextBoxTextChanged;
            PrimaryTextBox.KeyDown += OnUrlTextBoxKeyDown;
            // 
            // PanelToolbar
            // 
            PanelToolbar.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PanelToolbar.Controls.Add( HomeButton );
            PanelToolbar.Controls.Add( PrimaryTextBox );
            PanelToolbar.Controls.Add( SearchDownloadButton );
            PanelToolbar.Controls.Add( NextSearchButton );
            PanelToolbar.Controls.Add( PreviousSearchButton );
            PanelToolbar.Controls.Add( RefreshSearchButton );
            PanelToolbar.Controls.Add( StopSearchButton );
            PanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            PanelToolbar.Location = new System.Drawing.Point( 0, 0 );
            PanelToolbar.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            PanelToolbar.Name = "PanelToolbar";
            PanelToolbar.Size = new System.Drawing.Size( 1338, 30 );
            PanelToolbar.TabIndex = 6;
            // 
            // HomeButton
            // 
            HomeButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            HomeButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            HomeButton.Image = Properties.Resources.SearchHomeButton;
            HomeButton.Location = new System.Drawing.Point( 1251, 0 );
            HomeButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new System.Drawing.Size( 25, 30 );
            HomeButton.TabIndex = 6;
            HomeButton.Tag = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += OnHomeButtonClick;
            // 
            // TabPages
            // 
            TabPages.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabPages.ContextMenuStrip = MenuTabStrip;
            TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            TabPages.Font = new System.Drawing.Font( "Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabPages.Items.AddRange( new BrowserTabStripItem[ ] { TabItem, AddItemTab } );
            TabPages.Location = new System.Drawing.Point( 0, 30 );
            TabPages.Name = "TabPages";
            TabPages.Padding = new System.Windows.Forms.Padding( 1, 29, 1, 1 );
            TabPages.SelectedItem = TabItem;
            TabPages.Size = new System.Drawing.Size( 1338, 663 );
            TabPages.TabIndex = 4;
            TabPages.Text = "faTabStrip1";
            TabPages.TabStripItemSelectionChanged += OnTabsChanged;
            TabPages.TabStripItemClosed += OnTabClosed;
            TabPages.MouseClick += OnTabPagesClicked;
            // 
            // TabItem
            // 
            TabItem.BackColor = System.Drawing.Color.Transparent;
            TabItem.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabItem.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            TabItem.BorderThickness = 1;
            TabItem.Children = null;
            TabItem.DataFilter = null;
            TabItem.Dock = System.Windows.Forms.DockStyle.Fill;
            TabItem.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabItem.ForeColor = System.Drawing.Color.Transparent;
            TabItem.HoverText = null;
            TabItem.IsDerivedStyle = true;
            TabItem.IsDrawn = true;
            TabItem.IsSelected = true;
            TabItem.Location = new System.Drawing.Point( 1, 29 );
            TabItem.Name = "TabItem";
            TabItem.Padding = new System.Windows.Forms.Padding( 1 );
            TabItem.Size = new System.Drawing.Size( 1336, 633 );
            TabItem.StripRectangle = (System.Drawing.RectangleF) resources.GetObject( "TabItem.StripRectangle" ) ;
            TabItem.Style = MetroSet_UI.Enums.Style.Custom;
            TabItem.StyleManager = null;
            TabItem.TabIndex = 0;
            TabItem.ThemeAuthor = "Terry D. Eppler";
            TabItem.ThemeName = "Budget Browser";
            TabItem.Title = "Loading...";
            TabItem.ToolTip = null;
            // 
            // AddItemTab
            // 
            AddItemTab.BackColor = System.Drawing.Color.Transparent;
            AddItemTab.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            AddItemTab.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            AddItemTab.BorderThickness = 1;
            AddItemTab.CanClose = false;
            AddItemTab.Children = null;
            AddItemTab.DataFilter = null;
            AddItemTab.Dock = System.Windows.Forms.DockStyle.Fill;
            AddItemTab.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            AddItemTab.ForeColor = System.Drawing.Color.Transparent;
            AddItemTab.HoverText = null;
            AddItemTab.IsDerivedStyle = true;
            AddItemTab.IsDrawn = true;
            AddItemTab.Location = new System.Drawing.Point( 1, 1 );
            AddItemTab.Name = "AddItemTab";
            AddItemTab.Padding = new System.Windows.Forms.Padding( 1 );
            AddItemTab.Size = new System.Drawing.Size( 931, 601 );
            AddItemTab.StripRectangle = (System.Drawing.RectangleF) resources.GetObject( "AddItemTab.StripRectangle" ) ;
            AddItemTab.Style = MetroSet_UI.Enums.Style.Custom;
            AddItemTab.StyleManager = null;
            AddItemTab.TabIndex = 1;
            AddItemTab.ThemeAuthor = "Terry D. Eppler";
            AddItemTab.ThemeName = "Budget Browser";
            AddItemTab.Title = "+";
            AddItemTab.ToolTip = null;
            // 
            // StatusPanel
            // 
            StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            StatusPanel.Location = new System.Drawing.Point( 0, 693 );
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new System.Drawing.Size( 1338, 20 );
            StatusPanel.TabIndex = 8;
            // 
            // SearchPanel
            // 
            SearchPanel.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            SearchPanel.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SearchPanel.Controls.Add( NextButton );
            SearchPanel.Controls.Add( PreviousButton );
            SearchPanel.Controls.Add( CloseSearchButton );
            SearchPanel.Controls.Add( SearchPanelTextBox );
            SearchPanel.Location = new System.Drawing.Point( 1029, 41 );
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new System.Drawing.Size( 307, 40 );
            SearchPanel.TabIndex = 9;
            SearchPanel.Visible = false;
            // 
            // NextButton
            // 
            NextButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NextButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            NextButton.Image = Properties.Resources.SearchNextButton;
            NextButton.Location = new System.Drawing.Point( 239, 4 );
            NextButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size( 25, 30 );
            NextButton.TabIndex = 9;
            NextButton.Tag = "Find next (Enter)";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += OnNextSearchButtonClick;
            // 
            // PreviousButton
            // 
            PreviousButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PreviousButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PreviousButton.Image = Properties.Resources.SearchPreviousButton;
            PreviousButton.Location = new System.Drawing.Point( 206, 4 );
            PreviousButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new System.Drawing.Size( 25, 30 );
            PreviousButton.TabIndex = 8;
            PreviousButton.Tag = "Find previous (Shift+Enter)";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += OnPreviousSearchButtonClick;
            // 
            // CloseSearchButton
            // 
            CloseSearchButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            CloseSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CloseSearchButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CloseSearchButton.Image = Properties.Resources.SearchCancelButton;
            CloseSearchButton.Location = new System.Drawing.Point( 272, 4 );
            CloseSearchButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            CloseSearchButton.Name = "CloseSearchButton";
            CloseSearchButton.Size = new System.Drawing.Size( 25, 30 );
            CloseSearchButton.TabIndex = 7;
            CloseSearchButton.Tag = "Close (Esc)";
            CloseSearchButton.UseVisualStyleBackColor = true;
            CloseSearchButton.Click += OnCloseSearchButtonClick;
            // 
            // SearchPanelTextBox
            // 
            SearchPanelTextBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            SearchPanelTextBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            SearchPanelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            SearchPanelTextBox.Font = new System.Drawing.Font( "Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SearchPanelTextBox.ForeColor = System.Drawing.Color.LightGray;
            SearchPanelTextBox.Location = new System.Drawing.Point( 10, 6 );
            SearchPanelTextBox.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            SearchPanelTextBox.Name = "SearchPanelTextBox";
            SearchPanelTextBox.Size = new System.Drawing.Size( 181, 25 );
            SearchPanelTextBox.TabIndex = 6;
            SearchPanelTextBox.TextChanged += OnSearchTextChanged;
            SearchPanelTextBox.KeyDown += OnSearchKeyDown;
            // 
            // WebBrowser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
            CaptionButtonHoverColor = System.Drawing.Color.Maroon;
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 1338, 713 );
            Controls.Add( SearchPanel );
            Controls.Add( TabPages );
            Controls.Add( PanelToolbar );
            Controls.Add( StatusPanel );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "WebBrowser";
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ShowMouseOver = true;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Title";
            FormClosing += OnClosing;
            Load += OnLoad;
            MenuTabStrip.ResumeLayout( false );
            PanelToolbar.ResumeLayout( false );
            PanelToolbar.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).EndInit( );
            TabPages.ResumeLayout( false );
            SearchPanel.ResumeLayout( false );
            SearchPanel.PerformLayout( );
            ResumeLayout( false );
        }

        #endregion

        public BrowserTabStrip TabPages;
        public BrowserTabStripItem TabItem;
        public BrowserTabStripItem AddItemTab;
        public System.Windows.Forms.Timer Timer;
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

