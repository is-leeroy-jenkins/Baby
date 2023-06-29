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
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel( );
            ToolStrip = new ToolStrip( );
            Separator1 = new ToolSeparator( );
            Separator2 = new ToolSeparator( );
            Separator9 = new ToolSeparator( );
            Separator3 = new ToolSeparator( );
            Separator4 = new ToolSeparator( );
            Separator5 = new ToolSeparator( );
            Separator6 = new ToolSeparator( );
            Separator7 = new ToolSeparator( );
            Separator8 = new ToolSeparator( );
            ToolStripLabel = new System.Windows.Forms.ToolStripLabel( );
            ToolStripComboBox = new ToolStripComboBox( );
            PreviousToolStripButton = new ToolStripButton( );
            NextToolStripButton = new ToolStripButton( );
            ToolStripTextBox = new ToolStripTextBox( );
            CancelToolStripButton = new ToolStripButton( );
            DownloadToolStripButton = new ToolStripButton( );
            HomeToolStripButton = new ToolStripButton( );
            Separator10 = new ToolSeparator( );
            CloseToolStripButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            Spacer = new ToolStripLabel( );
            ToolTip = new ToolTip( );
            GoogleButton = new ToolStripButton( );
            Separator12 = new ToolSeparator( );
            MenuTabStrip.SuspendLayout( );
            PanelToolbar.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).BeginInit( );
            TabPages.SuspendLayout( );
            SearchPanel.SuspendLayout( );
            ToolStripTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
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
            PanelToolbar.Controls.Add( SearchDownloadButton );
            PanelToolbar.Controls.Add( NextSearchButton );
            PanelToolbar.Controls.Add( PreviousSearchButton );
            PanelToolbar.Controls.Add( RefreshSearchButton );
            PanelToolbar.Controls.Add( StopSearchButton );
            PanelToolbar.Controls.Add( PrimaryTextBox );
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
            TabPages.Size = new System.Drawing.Size( 1338, 650 );
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
            TabItem.Size = new System.Drawing.Size( 1336, 620 );
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
            // ToolStripTable
            // 
            ToolStripTable.ColumnCount = 2;
            ToolStripTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 17.5635281F ) );
            ToolStripTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 82.43647F ) );
            ToolStripTable.Controls.Add( StatusPanel, 0, 0 );
            ToolStripTable.Controls.Add( ToolStrip, 1, 0 );
            ToolStripTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStripTable.Location = new System.Drawing.Point( 0, 680 );
            ToolStripTable.Name = "ToolStripTable";
            ToolStripTable.RowCount = 1;
            ToolStripTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Size = new System.Drawing.Size( 1338, 33 );
            ToolStripTable.TabIndex = 0;
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
            ToolStrip.ForeColor = System.Drawing.Color.Black;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { ToolStripLabel, Separator1, ToolStripComboBox, Separator2, PreviousToolStripButton, Separator3, NextToolStripButton, Separator4, ToolStripTextBox, Separator5, CancelToolStripButton, Separator7, GoogleButton, Separator9, DownloadToolStripButton, Separator8, Spacer, Separator10, HomeToolStripButton, Separator11, CloseToolStripButton, Separator12 } );
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
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 27 );
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 27 );
            // 
            // ToolStripLabel
            // 
            ToolStripLabel.Name = "ToolStripLabel";
            ToolStripLabel.Size = new System.Drawing.Size( 94, 26 );
            ToolStripLabel.Text = "Browser Toolbar";
            // 
            // ToolStripComboBox
            // 
            ToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ToolStripComboBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStripComboBox.ForeColor = System.Drawing.Color.LightGray;
            ToolStripComboBox.HoverText = null;
            ToolStripComboBox.MaxLength = 32767;
            ToolStripComboBox.MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ToolStripComboBox.Name = "ToolStripComboBox";
            ToolStripComboBox.Size = new System.Drawing.Size( 220, 29 );
            ToolStripComboBox.ToolTip = ToolTip;
            // 
            // PreviousToolStripButton
            // 
            PreviousToolStripButton.AutoToolTip = false;
            PreviousToolStripButton.BackColor = System.Drawing.Color.Transparent;
            PreviousToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousToolStripButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PreviousToolStripButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousToolStripButton.HoverText = "Previous Results";
            PreviousToolStripButton.Image = Properties.Resources.PreviousButton;
            PreviousToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousToolStripButton.Margin = new System.Windows.Forms.Padding( 3 );
            PreviousToolStripButton.Name = "PreviousToolStripButton";
            PreviousToolStripButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousToolStripButton.Size = new System.Drawing.Size( 23, 23 );
            PreviousToolStripButton.Text = "toolStripButton1";
            PreviousToolStripButton.ToolTip = ToolTip;
            PreviousToolStripButton.ToolType = ToolType.PreviousButton;
            // 
            // NextToolStripButton
            // 
            NextToolStripButton.AutoToolTip = false;
            NextToolStripButton.BackColor = System.Drawing.Color.Transparent;
            NextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextToolStripButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NextToolStripButton.ForeColor = System.Drawing.Color.LightGray;
            NextToolStripButton.HoverText = "Next Results";
            NextToolStripButton.Image = Properties.Resources.NextButton;
            NextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextToolStripButton.Margin = new System.Windows.Forms.Padding( 3 );
            NextToolStripButton.Name = "NextToolStripButton";
            NextToolStripButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextToolStripButton.Size = new System.Drawing.Size( 23, 23 );
            NextToolStripButton.ToolTip = ToolTip;
            NextToolStripButton.ToolType = ToolType.NextButton;
            // 
            // ToolStripTextBox
            // 
            ToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ToolStripTextBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStripTextBox.ForeColor = System.Drawing.Color.FromArgb(   224  ,   224  ,   224   );
            ToolStripTextBox.HoverText = "";
            ToolStripTextBox.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStripTextBox.Name = "ToolStripTextBox";
            ToolStripTextBox.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStripTextBox.Size = new System.Drawing.Size( 348, 27 );
            ToolStripTextBox.Tag = "";
            ToolStripTextBox.Text = "< Enter Key Words >";
            ToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ToolStripTextBox.ToolTip = null;
            // 
            // CancelToolStripButton
            // 
            CancelToolStripButton.AutoToolTip = false;
            CancelToolStripButton.BackColor = System.Drawing.Color.Transparent;
            CancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CancelToolStripButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CancelToolStripButton.ForeColor = System.Drawing.Color.LightGray;
            CancelToolStripButton.HoverText = "Cancel Search";
            CancelToolStripButton.Image = Properties.Resources.CancelButton;
            CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CancelToolStripButton.Margin = new System.Windows.Forms.Padding( 3 );
            CancelToolStripButton.Name = "CancelToolStripButton";
            CancelToolStripButton.Padding = new System.Windows.Forms.Padding( 1 );
            CancelToolStripButton.Size = new System.Drawing.Size( 23, 23 );
            CancelToolStripButton.Text = "toolStripButton1";
            CancelToolStripButton.ToolTip = null;
            CancelToolStripButton.ToolType = ToolType.FirstButton;
            // 
            // DownloadToolStripButton
            // 
            DownloadToolStripButton.AutoToolTip = false;
            DownloadToolStripButton.BackColor = System.Drawing.Color.Transparent;
            DownloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DownloadToolStripButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DownloadToolStripButton.ForeColor = System.Drawing.Color.LightGray;
            DownloadToolStripButton.HoverText = null;
            DownloadToolStripButton.Image = Properties.Resources.DownloadButton;
            DownloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            DownloadToolStripButton.Margin = new System.Windows.Forms.Padding( 3 );
            DownloadToolStripButton.Name = "DownloadToolStripButton";
            DownloadToolStripButton.Padding = new System.Windows.Forms.Padding( 1 );
            DownloadToolStripButton.Size = new System.Drawing.Size( 23, 23 );
            DownloadToolStripButton.Text = "toolStripButton1";
            DownloadToolStripButton.ToolTip = null;
            DownloadToolStripButton.ToolType = ToolType.FirstButton;
            // 
            // HomeToolStripButton
            // 
            HomeToolStripButton.AutoToolTip = false;
            HomeToolStripButton.BackColor = System.Drawing.Color.Transparent;
            HomeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            HomeToolStripButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            HomeToolStripButton.ForeColor = System.Drawing.Color.LightGray;
            HomeToolStripButton.HoverText = "Home Page";
            HomeToolStripButton.Image = Properties.Resources.HomeButton;
            HomeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            HomeToolStripButton.Margin = new System.Windows.Forms.Padding( 3 );
            HomeToolStripButton.Name = "HomeToolStripButton";
            HomeToolStripButton.Padding = new System.Windows.Forms.Padding( 1 );
            HomeToolStripButton.Size = new System.Drawing.Size( 23, 23 );
            HomeToolStripButton.Text = "toolStripButton1";
            HomeToolStripButton.ToolTip = ToolTip;
            HomeToolStripButton.ToolType = ToolType.HomeButton;
            // 
            // Separator10
            // 
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 27 );
            // 
            // CloseToolStripButton
            // 
            CloseToolStripButton.AutoToolTip = false;
            CloseToolStripButton.BackColor = System.Drawing.Color.Transparent;
            CloseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseToolStripButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseToolStripButton.ForeColor = System.Drawing.Color.LightGray;
            CloseToolStripButton.HoverText = null;
            CloseToolStripButton.Image = Properties.Resources.CloseButton;
            CloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseToolStripButton.Margin = new System.Windows.Forms.Padding( 3 );
            CloseToolStripButton.Name = "CloseToolStripButton";
            CloseToolStripButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseToolStripButton.Size = new System.Drawing.Size( 23, 23 );
            CloseToolStripButton.Text = "toolStripButton2";
            CloseToolStripButton.ToolTip = ToolTip;
            CloseToolStripButton.ToolType = ToolType.CloseButton;
            // 
            // Separator11
            // 
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 27 );
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
            // GoogleButton
            // 
            GoogleButton.AutoToolTip = false;
            GoogleButton.BackColor = System.Drawing.Color.Transparent;
            GoogleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            GoogleButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            GoogleButton.ForeColor = System.Drawing.Color.LightGray;
            GoogleButton.HoverText = "Begin Search";
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
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 27 );
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
            Controls.Add( ToolStripTable );
            Controls.Add( PanelToolbar );
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
            ToolStripTable.ResumeLayout( false );
            ToolStripTable.PerformLayout( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
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
        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public ToolStrip ToolStrip;
        public System.Windows.Forms.ToolStripLabel ToolStripLabel;
        public ToolSeparator Separator1;
        public ToolStripComboBox ToolStripComboBox;
        public ToolTip ToolTip;
        public ToolSeparator Separator2;
        public ToolStripButton PreviousToolStripButton;
        public ToolSeparator Separator3;
        public ToolStripButton NextToolStripButton;
        public ToolSeparator Separator4;
        public ToolStripTextBox ToolStripTextBox;
        public ToolSeparator Separator5;
        public ToolStripButton CancelToolStripButton;
        public ToolSeparator Separator7;
        public ToolStripButton GoogleButton;
        public ToolSeparator Separator9;
        public ToolStripButton DownloadToolStripButton;
        public ToolSeparator Separator8;
        public ToolStripLabel Spacer;
        public ToolSeparator Separator10;
        public ToolStripButton HomeToolStripButton;
        public ToolSeparator Separator11;
        public ToolStripButton CloseToolStripButton;
        public ToolSeparator Separator12;
        public ToolSeparator Separator6;
    }
}

