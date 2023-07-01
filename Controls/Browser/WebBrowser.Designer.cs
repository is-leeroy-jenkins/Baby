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
            UrlTextBox = new System.Windows.Forms.TextBox( );
            UrlPanel = new System.Windows.Forms.Panel( );
            HomeButton = new System.Windows.Forms.Button( );
            TabPages = new BrowserTabStrip( );
            TabItem = new BrowserTabStripItem( );
            AddItemTab = new BrowserTabStripItem( );
            StatusPanel = new System.Windows.Forms.Panel( );
            SearchPanel = new System.Windows.Forms.Panel( );
            LastButton = new System.Windows.Forms.Button( );
            FirstButton = new System.Windows.Forms.Button( );
            CloseSearchButton = new System.Windows.Forms.Button( );
            SearchPanelTextBox = new System.Windows.Forms.TextBox( );
            BottomTable = new System.Windows.Forms.TableLayoutPanel( );
            ToolStrip = new ToolStrip( );
            BarLabel = new System.Windows.Forms.ToolStripLabel( );
            Separator1 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            ToolTip = new ToolTip( );
            Separator2 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            Separator3 = new ToolSeparator( );
            SearchEngineComboBox = new ToolStripComboBox( );
            Separator4 = new ToolSeparator( );
            GoButton = new ToolStripButton( );
            Separator13 = new ToolSeparator( );
            KeyWordTextBox = new ToolStripTextBox( );
            Separator5 = new ToolSeparator( );
            CancelButton = new ToolStripButton( );
            Separator7 = new ToolSeparator( );
            GoogleButton = new ToolStripButton( );
            Separator9 = new ToolSeparator( );
            DownloadButton = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            Spacer = new ToolStripLabel( );
            Separator10 = new ToolSeparator( );
            HomePageButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            CloseButton = new ToolStripButton( );
            Separator12 = new ToolSeparator( );
            Separator6 = new ToolSeparator( );
            TopTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new ImageBox( );
            Title = new Label( );
            MenuTabStrip.SuspendLayout( );
            UrlPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).BeginInit( );
            TabPages.SuspendLayout( );
            SearchPanel.SuspendLayout( );
            BottomTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            TopTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
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
            // UrlTextBox
            // 
            UrlTextBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            UrlTextBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            UrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            UrlTextBox.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            UrlTextBox.ForeColor = System.Drawing.Color.LightGray;
            UrlTextBox.Location = new System.Drawing.Point( 60, 5 );
            UrlTextBox.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            UrlTextBox.Name = "UrlTextBox";
            UrlTextBox.Size = new System.Drawing.Size( 1185, 20 );
            UrlTextBox.TabIndex = 5;
            UrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            UrlTextBox.Click += OnUrlTextBoxClicked;
            UrlTextBox.TextChanged += OnUrlTextBoxTextChanged;
            UrlTextBox.KeyDown += OnUrlTextBoxKeyDown;
            // 
            // UrlPanel
            // 
            UrlPanel.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            UrlPanel.Controls.Add( HomeButton );
            UrlPanel.Controls.Add( SearchDownloadButton );
            UrlPanel.Controls.Add( NextSearchButton );
            UrlPanel.Controls.Add( PreviousSearchButton );
            UrlPanel.Controls.Add( RefreshSearchButton );
            UrlPanel.Controls.Add( StopSearchButton );
            UrlPanel.Controls.Add( UrlTextBox );
            UrlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            UrlPanel.Location = new System.Drawing.Point( 0, 24 );
            UrlPanel.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            UrlPanel.Name = "UrlPanel";
            UrlPanel.Size = new System.Drawing.Size( 1338, 30 );
            UrlPanel.TabIndex = 6;
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
            TabPages.Location = new System.Drawing.Point( 0, 54 );
            TabPages.Name = "TabPages";
            TabPages.Padding = new System.Windows.Forms.Padding( 1, 29, 1, 1 );
            TabPages.SelectedItem = TabItem;
            TabPages.Size = new System.Drawing.Size( 1338, 652 );
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
            TabItem.Size = new System.Drawing.Size( 1336, 622 );
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
            StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            StatusPanel.Location = new System.Drawing.Point( 3, 3 );
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new System.Drawing.Size( 229, 27 );
            StatusPanel.TabIndex = 8;
            // 
            // SearchPanel
            // 
            SearchPanel.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            SearchPanel.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SearchPanel.Controls.Add( LastButton );
            SearchPanel.Controls.Add( FirstButton );
            SearchPanel.Controls.Add( CloseSearchButton );
            SearchPanel.Controls.Add( SearchPanelTextBox );
            SearchPanel.Location = new System.Drawing.Point( 1030, 5 );
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new System.Drawing.Size( 307, 40 );
            SearchPanel.TabIndex = 9;
            SearchPanel.Visible = false;
            // 
            // LastButton
            // 
            LastButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            LastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LastButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            LastButton.Image = Properties.Resources.SearchNextButton;
            LastButton.Location = new System.Drawing.Point( 239, 4 );
            LastButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            LastButton.Name = "LastButton";
            LastButton.Size = new System.Drawing.Size( 25, 30 );
            LastButton.TabIndex = 9;
            LastButton.Tag = "Find next (Enter)";
            LastButton.UseVisualStyleBackColor = true;
            LastButton.Click += OnNextSearchButtonClick;
            // 
            // FirstButton
            // 
            FirstButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            FirstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FirstButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstButton.Image = Properties.Resources.SearchPreviousButton;
            FirstButton.Location = new System.Drawing.Point( 206, 4 );
            FirstButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new System.Drawing.Size( 25, 30 );
            FirstButton.TabIndex = 8;
            FirstButton.Tag = "Find previous (Shift+Enter)";
            FirstButton.UseVisualStyleBackColor = true;
            FirstButton.Click += OnPreviousSearchButtonClick;
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
            // BottomTable
            // 
            BottomTable.ColumnCount = 2;
            BottomTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 17.5635281F ) );
            BottomTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 82.43647F ) );
            BottomTable.Controls.Add( StatusPanel, 0, 0 );
            BottomTable.Controls.Add( ToolStrip, 1, 0 );
            BottomTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            BottomTable.Location = new System.Drawing.Point( 0, 706 );
            BottomTable.Name = "BottomTable";
            BottomTable.RowCount = 1;
            BottomTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            BottomTable.Size = new System.Drawing.Size( 1338, 33 );
            BottomTable.TabIndex = 0;
            // 
            // ToolStrip
            // 
            ToolStrip.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            ToolStrip.CanOverrideStyle = true;
            ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStrip.FirstButton = null;
            ToolStrip.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { BarLabel, Separator1, PreviousButton, Separator2, NextButton, Separator3, SearchEngineComboBox, Separator4, GoButton, Separator13, KeyWordTextBox, Separator5, CancelButton, Separator7, GoogleButton, Separator9, DownloadButton, Separator8, Spacer, Separator10, HomePageButton, Separator11, CloseButton, Separator12 } );
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 236, 1 );
            ToolStrip.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NavigationLabel = null;
            ToolStrip.NextButton = null;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            ToolStrip.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStrip.PreviousButton = null;
            ToolStrip.RefreshButton = null;
            ToolStrip.SearchEngineComboBox = null;
            ToolStrip.SearchEngineLabel = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = false;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new System.Drawing.Size( 1101, 31 );
            ToolStrip.TabIndex = 9;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(   28  ,   28  ,   28   );
            ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            ToolStrip.ToolBarTextBox = null;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            ToolStrip.WebsiteComboBox = null;
            ToolStrip.WebsiteLabel = null;
            // 
            // BarLabel
            // 
            BarLabel.Name = "BarLabel";
            BarLabel.Size = new System.Drawing.Size( 94, 26 );
            BarLabel.Text = "Browser Toolbar";
            // 
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 27 );
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.Transparent;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousButton.HoverText = "Previous Result";
            PreviousButton.Image = Properties.Resources.Previous;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 3 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 23 );
            PreviousButton.Text = "toolStripButton1";
            PreviousButton.ToolTip = ToolTip;
            PreviousButton.ToolType = ToolType.PreviousButton;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb(   5  ,   5  ,   5   );
            ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            ToolTip.ForeColor = System.Drawing.Color.White;
            ToolTip.InitialDelay = 500;
            ToolTip.IsDerivedStyle = true;
            ToolTip.Name = null;
            ToolTip.OwnerDraw = true;
            ToolTip.ReshowDelay = 100;
            ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            ToolTip.StyleManager = null;
            ToolTip.ThemeAuthor = "Terry D. Eppler";
            ToolTip.ThemeName = "Budget Browser";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 27 );
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.Transparent;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = "Next Result";
            NextButton.Image = Properties.Resources.NextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 3 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 23 );
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 27 );
            // 
            // SearchEngineComboBox
            // 
            SearchEngineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SearchEngineComboBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SearchEngineComboBox.ForeColor = System.Drawing.Color.FromArgb(   218  ,   218  ,   218   );
            SearchEngineComboBox.HoverText = "Search Engines";
            SearchEngineComboBox.Items.AddRange( new object[ ] { "Google", "Bing", "DuckDuckGo" } );
            SearchEngineComboBox.MaxLength = 32767;
            SearchEngineComboBox.MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SearchEngineComboBox.Name = "SearchEngineComboBox";
            SearchEngineComboBox.Size = new System.Drawing.Size( 150, 29 );
            SearchEngineComboBox.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            SearchEngineComboBox.ToolTip = ToolTip;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 27 );
            // 
            // GoButton
            // 
            GoButton.AutoToolTip = false;
            GoButton.BackColor = System.Drawing.Color.Transparent;
            GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            GoButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            GoButton.ForeColor = System.Drawing.Color.LightGray;
            GoButton.HoverText = "Start Search";
            GoButton.Image = Properties.Resources.GoButton;
            GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            GoButton.Margin = new System.Windows.Forms.Padding( 3 );
            GoButton.Name = "GoButton";
            GoButton.Padding = new System.Windows.Forms.Padding( 1 );
            GoButton.Size = new System.Drawing.Size( 23, 23 );
            GoButton.ToolTip = ToolTip;
            GoButton.ToolType = ToolType.FirstButton;
            // 
            // Separator13
            // 
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 27 );
            // 
            // KeyWordTextBox
            // 
            KeyWordTextBox.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            KeyWordTextBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            KeyWordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            KeyWordTextBox.HoverText = "";
            KeyWordTextBox.Margin = new System.Windows.Forms.Padding( 1 );
            KeyWordTextBox.Name = "KeyWordTextBox";
            KeyWordTextBox.Padding = new System.Windows.Forms.Padding( 1 );
            KeyWordTextBox.Size = new System.Drawing.Size( 340, 27 );
            KeyWordTextBox.Tag = "";
            KeyWordTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            KeyWordTextBox.ToolTip = ToolTip;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 27 );
            // 
            // CancelButton
            // 
            CancelButton.AutoToolTip = false;
            CancelButton.BackColor = System.Drawing.Color.Transparent;
            CancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CancelButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CancelButton.ForeColor = System.Drawing.Color.LightGray;
            CancelButton.HoverText = "Cancel Search";
            CancelButton.Image = Properties.Resources.CancelButton;
            CancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CancelButton.Margin = new System.Windows.Forms.Padding( 3 );
            CancelButton.Name = "CancelButton";
            CancelButton.Padding = new System.Windows.Forms.Padding( 1 );
            CancelButton.Size = new System.Drawing.Size( 23, 23 );
            CancelButton.Text = "toolStripButton1";
            CancelButton.ToolTip = ToolTip;
            CancelButton.ToolType = ToolType.FirstButton;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 27 );
            // 
            // GoogleButton
            // 
            GoogleButton.AutoToolTip = false;
            GoogleButton.BackColor = System.Drawing.Color.Transparent;
            GoogleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            GoogleButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            GoogleButton.ForeColor = System.Drawing.Color.LightGray;
            GoogleButton.HoverText = "Google";
            GoogleButton.Image = Properties.Resources.GoogleButton;
            GoogleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            GoogleButton.Margin = new System.Windows.Forms.Padding( 3 );
            GoogleButton.Name = "GoogleButton";
            GoogleButton.Padding = new System.Windows.Forms.Padding( 1 );
            GoogleButton.Size = new System.Drawing.Size( 23, 23 );
            GoogleButton.Text = "toolStripButton1";
            GoogleButton.ToolTip = ToolTip;
            GoogleButton.ToolType = ToolType.GoogleButton;
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 27 );
            // 
            // DownloadButton
            // 
            DownloadButton.AutoToolTip = false;
            DownloadButton.BackColor = System.Drawing.Color.Transparent;
            DownloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DownloadButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DownloadButton.ForeColor = System.Drawing.Color.LightGray;
            DownloadButton.HoverText = "View Downloads";
            DownloadButton.Image = Properties.Resources.DownloadButton;
            DownloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            DownloadButton.Margin = new System.Windows.Forms.Padding( 3 );
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Padding = new System.Windows.Forms.Padding( 1 );
            DownloadButton.Size = new System.Drawing.Size( 23, 23 );
            DownloadButton.Text = "toolStripButton1";
            DownloadButton.ToolTip = ToolTip;
            DownloadButton.ToolType = ToolType.DownloadButton;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Spacer
            // 
            Spacer.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            Spacer.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Spacer.ForeColor = System.Drawing.Color.Transparent;
            Spacer.HoverText = null;
            Spacer.Margin = new System.Windows.Forms.Padding( 1 );
            Spacer.Name = "Spacer";
            Spacer.Padding = new System.Windows.Forms.Padding( 1 );
            Spacer.Size = new System.Drawing.Size( 121, 27 );
            Spacer.Tag = "";
            Spacer.Text = "This is a spacing label";
            Spacer.ToolTip = null;
            // 
            // Separator10
            // 
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 27 );
            // 
            // HomePageButton
            // 
            HomePageButton.AutoToolTip = false;
            HomePageButton.BackColor = System.Drawing.Color.Transparent;
            HomePageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            HomePageButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            HomePageButton.ForeColor = System.Drawing.Color.LightGray;
            HomePageButton.HoverText = "Home Page";
            HomePageButton.Image = Properties.Resources.HomeButton;
            HomePageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            HomePageButton.Margin = new System.Windows.Forms.Padding( 3 );
            HomePageButton.Name = "HomePageButton";
            HomePageButton.Padding = new System.Windows.Forms.Padding( 1 );
            HomePageButton.Size = new System.Drawing.Size( 23, 23 );
            HomePageButton.ToolTip = null;
            HomePageButton.ToolType = ToolType.HomeButton;
            // 
            // Separator11
            // 
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 27 );
            // 
            // CloseButton
            // 
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.LightGray;
            CloseButton.HoverText = "Close Browser";
            CloseButton.Image = Properties.Resources.CloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 23 );
            CloseButton.Text = "toolStripButton2";
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.CloseButton;
            // 
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 27 );
            // 
            // TopTable
            // 
            TopTable.ColumnCount = 2;
            TopTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 3.66614676F ) );
            TopTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 96.3338547F ) );
            TopTable.Controls.Add( PictureBox, 0, 0 );
            TopTable.Controls.Add( Title, 1, 0 );
            TopTable.Dock = System.Windows.Forms.DockStyle.Top;
            TopTable.Location = new System.Drawing.Point( 0, 0 );
            TopTable.Name = "TopTable";
            TopTable.RowCount = 1;
            TopTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            TopTable.Size = new System.Drawing.Size( 1338, 24 );
            TopTable.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.Image = Properties.Resources.EpaSkew;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 39, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 52, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1283, 18 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Title";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Browser";
            Title.ToolTip = ToolTip;
            // 
            // WebBrowser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
            CaptionButtonHoverColor = System.Drawing.Color.Maroon;
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 1338, 739 );
            Controls.Add( TabPages );
            Controls.Add( BottomTable );
            Controls.Add( UrlPanel );
            Controls.Add( TopTable );
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
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ShowMouseOver = true;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Title";
            FormClosing += OnClosing;
            Load += OnLoad;
            MenuTabStrip.ResumeLayout( false );
            UrlPanel.ResumeLayout( false );
            UrlPanel.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).EndInit( );
            TabPages.ResumeLayout( false );
            SearchPanel.ResumeLayout( false );
            SearchPanel.PerformLayout( );
            BottomTable.ResumeLayout( false );
            BottomTable.PerformLayout( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            TopTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
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
        public System.Windows.Forms.TextBox UrlTextBox;
        public System.Windows.Forms.Panel UrlPanel;
        public System.Windows.Forms.Panel StatusPanel;
        public System.Windows.Forms.Panel SearchPanel;
        public System.Windows.Forms.TextBox SearchPanelTextBox;
        public System.Windows.Forms.Button CloseSearchButton;
        public System.Windows.Forms.Button FirstButton;
        public System.Windows.Forms.Button LastButton;
        public System.Windows.Forms.Button HomeButton;
        public System.Windows.Forms.TableLayoutPanel BottomTable;
        public ToolStrip ToolStrip;
        public System.Windows.Forms.ToolStripLabel BarLabel;
        public ToolSeparator Separator1;
        public ToolStripComboBox SearchEngineComboBox;
        public ToolTip ToolTip;
        public ToolSeparator Separator2;
        public ToolStripButton PreviousButton;
        public ToolSeparator Separator3;
        public ToolStripButton NextButton;
        public ToolSeparator Separator4;
        public ToolStripTextBox KeyWordTextBox;
        public ToolSeparator Separator5;
        public ToolStripButton CancelButton;
        public ToolSeparator Separator7;
        public ToolStripButton GoogleButton;
        public ToolSeparator Separator9;
        public ToolStripButton DownloadButton;
        public ToolSeparator Separator8;
        public ToolStripLabel Spacer;
        public ToolSeparator Separator10;
        public ToolStripButton HomePageButton;
        public ToolSeparator Separator11;
        public ToolStripButton CloseButton;
        public ToolSeparator Separator12;
        public ToolSeparator Separator6;
        public ImageBox PictureBox;
        public ToolStripButton GoButton;
        public ToolSeparator Separator13;
        private Label Title;
        public System.Windows.Forms.TableLayoutPanel TopTable;
    }
}

