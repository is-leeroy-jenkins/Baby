namespace Baby
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
            Timer = new System.Windows.Forms.Timer(components);
            TabPages = new BrowserTabStrip();
            TabItem = new BrowserTabStripItem();
            AddItemTab = new BrowserTabStripItem();
            SearchPanel = new System.Windows.Forms.Panel();
            LastButton = new System.Windows.Forms.Button();
            FirstButton = new System.Windows.Forms.Button();
            CloseSearchButton = new System.Windows.Forms.Button();
            SearchPanelTextBox = new System.Windows.Forms.TextBox();
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel();
            ToolStrip = new ToolStrip();
            StatusLabel = new ToolStripLabel();
            StatusSpacer = new ToolStripLabel();
            Separator1 = new ToolSeparator();
            ToolStripDomainComboBox = new ToolStripComboBox();
            ToolTip = new ToolTip();
            Separator2 = new ToolSeparator();
            PreviousButton = new ToolStripButton();
            Separator3 = new ToolSeparator();
            NextButton = new ToolStripButton();
            Separator4 = new ToolSeparator();
            ToolStripKeyWordTextBox = new ToolStripTextBox();
            Separator5 = new ToolSeparator();
            ToolStripLookupButton = new ToolStripButton();
            Separator6 = new ToolSeparator();
            ToolStripCancelButton = new ToolStripButton();
            Separator7 = new ToolSeparator();
            ToolStripChromeButton = new ToolStripButton();
            Separator8 = new ToolSeparator();
            ToolStripEdgeButton = new ToolStripButton();
            Separator9 = new ToolSeparator();
            ToolStripSharepointButton = new ToolStripButton();
            Separator10 = new ToolSeparator();
            ToolStripFireFoxButton = new ToolStripButton();
            Separator16 = new ToolSeparator();
            ToolStripRefreshButton = new ToolStripButton();
            Separator11 = new ToolSeparator();
            DeveloperToolsButton = new ToolStripButton();
            Separator13 = new ToolSeparator();
            ToolStripDownloadButton = new ToolStripButton();
            Separator15 = new ToolSeparator();
            DownloadSeparator = new ToolSeparator();
            ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            ToolStripCloseButton = new ToolStripButton();
            Separator14 = new ToolSeparator();
            ToolStripHomeButton = new ToolStripButton();
            ProgressSeparator = new ToolSeparator();
            Separator12 = new ToolSeparator();
            TopTable = new System.Windows.Forms.TableLayoutPanel();
            Title = new Label();
            PictureBox = new ImageBox();
            TimeLabel = new Label();
            ControlBox = new ControlBox();
            UrlTextBoxTable = new System.Windows.Forms.TableLayoutPanel();
            SearchLayout = new System.Windows.Forms.FlowLayoutPanel();
            SearchLookupButton = new System.Windows.Forms.Button();
            SearchCancelButton = new System.Windows.Forms.Button();
            SearchRefreshButton = new System.Windows.Forms.Button();
            NavigationLayout = new System.Windows.Forms.FlowLayoutPanel();
            SearchHomeButton = new System.Windows.Forms.Button();
            SearchForwardButton = new System.Windows.Forms.Button();
            SearchBackButton = new System.Windows.Forms.Button();
            UrlTextBox = new TextBox();
            UrlSearchPanel = new Layout();
            ContextMenu = new ContextMenu();
            ((System.ComponentModel.ISupportInitialize)TabPages).BeginInit();
            TabPages.SuspendLayout();
            SearchPanel.SuspendLayout();
            ToolStripTable.SuspendLayout();
            ToolStrip.SuspendLayout();
            TopTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            UrlTextBoxTable.SuspendLayout();
            SearchLayout.SuspendLayout();
            NavigationLayout.SuspendLayout();
            UrlSearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 50;
            Timer.Tick += OnTimerTick;
            // 
            // TabPages
            // 
            TabPages.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            TabPages.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TabPages.ForeColor = System.Drawing.Color.FromArgb(106, 189, 252);
            TabPages.Items.AddRange(new BrowserTabStripItem[] { TabItem, AddItemTab });
            TabPages.Location = new System.Drawing.Point(0, 76);
            TabPages.Margin = new System.Windows.Forms.Padding(1);
            TabPages.Name = "TabPages";
            TabPages.Padding = new System.Windows.Forms.Padding(1, 29, 1, 1);
            TabPages.SelectedItem = TabItem;
            TabPages.Size = new System.Drawing.Size(1488, 718);
            TabPages.TabIndex = 4;
            TabPages.Text = "faTabStrip1";
            TabPages.TabStripItemSelectionChanged += OnTabsChanged;
            TabPages.TabStripItemClosed += OnTabClosed;
            TabPages.MouseClick += OnTabPagesClick;
            // 
            // TabItem
            // 
            TabItem.BackColor = System.Drawing.Color.Transparent;
            TabItem.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            TabItem.BorderColor = System.Drawing.Color.FromArgb(65, 65, 65);
            TabItem.BorderThickness = 1;
            TabItem.Children = null;
            TabItem.DataFilter = null;
            TabItem.Dock = System.Windows.Forms.DockStyle.Fill;
            TabItem.Drawn = true;
            TabItem.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TabItem.ForeColor = System.Drawing.Color.Transparent;
            TabItem.HoverText = null;
            TabItem.IsDerivedStyle = true;
            TabItem.Location = new System.Drawing.Point(1, 29);
            TabItem.Name = "TabItem";
            TabItem.Padding = new System.Windows.Forms.Padding(1);
            TabItem.Selected = true;
            TabItem.Size = new System.Drawing.Size(1486, 688);
            TabItem.StripRectangle = (System.Drawing.RectangleF)resources.GetObject("TabItem.StripRectangle");
            TabItem.Style = MetroSet_UI.Enums.Style.Custom;
            TabItem.StyleManager = null;
            TabItem.TabIndex = 0;
            TabItem.ThemeAuthor = "Terry D. Eppler";
            TabItem.ThemeName = "Baby";
            TabItem.Title = "Loading...";
            TabItem.ToolTip = null;
            // 
            // AddItemTab
            // 
            AddItemTab.BackColor = System.Drawing.Color.Transparent;
            AddItemTab.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            AddItemTab.BorderColor = System.Drawing.Color.FromArgb(65, 65, 65);
            AddItemTab.BorderThickness = 1;
            AddItemTab.CanClose = false;
            AddItemTab.Children = null;
            AddItemTab.DataFilter = null;
            AddItemTab.Dock = System.Windows.Forms.DockStyle.Fill;
            AddItemTab.Drawn = true;
            AddItemTab.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddItemTab.ForeColor = System.Drawing.Color.Transparent;
            AddItemTab.HoverText = null;
            AddItemTab.IsDerivedStyle = true;
            AddItemTab.Location = new System.Drawing.Point(1, 1);
            AddItemTab.Name = "AddItemTab";
            AddItemTab.Padding = new System.Windows.Forms.Padding(1);
            AddItemTab.Size = new System.Drawing.Size(931, 601);
            AddItemTab.StripRectangle = (System.Drawing.RectangleF)resources.GetObject("AddItemTab.StripRectangle");
            AddItemTab.Style = MetroSet_UI.Enums.Style.Custom;
            AddItemTab.StyleManager = null;
            AddItemTab.TabIndex = 1;
            AddItemTab.ThemeAuthor = "Terry D. Eppler";
            AddItemTab.ThemeName = "Baby";
            AddItemTab.Title = "+";
            AddItemTab.ToolTip = null;
            // 
            // SearchPanel
            // 
            SearchPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            SearchPanel.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(LastButton);
            SearchPanel.Controls.Add(FirstButton);
            SearchPanel.Controls.Add(CloseSearchButton);
            SearchPanel.Controls.Add(SearchPanelTextBox);
            SearchPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SearchPanel.Location = new System.Drawing.Point(1030, 5);
            SearchPanel.Margin = new System.Windows.Forms.Padding(1);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new System.Drawing.Size(307, 40);
            SearchPanel.TabIndex = 9;
            SearchPanel.Visible = false;
            // 
            // LastButton
            // 
            LastButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LastButton.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            LastButton.Image = (System.Drawing.Image)resources.GetObject("LastButton.Image");
            LastButton.Location = new System.Drawing.Point(239, 4);
            LastButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            LastButton.Name = "LastButton";
            LastButton.Size = new System.Drawing.Size(25, 30);
            LastButton.TabIndex = 9;
            LastButton.Tag = "Find next (Enter)";
            LastButton.UseVisualStyleBackColor = true;
            LastButton.Click += OnSearchForwardButtonClick;
            // 
            // FirstButton
            // 
            FirstButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            FirstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FirstButton.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            FirstButton.Image = (System.Drawing.Image)resources.GetObject("FirstButton.Image");
            FirstButton.Location = new System.Drawing.Point(206, 4);
            FirstButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new System.Drawing.Size(25, 30);
            FirstButton.TabIndex = 8;
            FirstButton.Tag = "Find previous (Shift+Enter)";
            FirstButton.UseVisualStyleBackColor = true;
            FirstButton.Click += OnSearchPreviousButtonClick;
            // 
            // CloseSearchButton
            // 
            CloseSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CloseSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CloseSearchButton.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            CloseSearchButton.Image = (System.Drawing.Image)resources.GetObject("CloseSearchButton.Image");
            CloseSearchButton.Location = new System.Drawing.Point(272, 4);
            CloseSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CloseSearchButton.Name = "CloseSearchButton";
            CloseSearchButton.Size = new System.Drawing.Size(25, 30);
            CloseSearchButton.TabIndex = 7;
            CloseSearchButton.Tag = "Close (Esc)";
            CloseSearchButton.UseVisualStyleBackColor = true;
            CloseSearchButton.Click += OnSearchPanelClearButtonClick;
            // 
            // SearchPanelTextBox
            // 
            SearchPanelTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            SearchPanelTextBox.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            SearchPanelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            SearchPanelTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SearchPanelTextBox.ForeColor = System.Drawing.Color.LightGray;
            SearchPanelTextBox.Location = new System.Drawing.Point(10, 6);
            SearchPanelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SearchPanelTextBox.Name = "SearchPanelTextBox";
            SearchPanelTextBox.Size = new System.Drawing.Size(181, 25);
            SearchPanelTextBox.TabIndex = 6;
            SearchPanelTextBox.TextChanged += OnSearchPanelTextChanged;
            SearchPanelTextBox.KeyDown += OnSearchKeyDown;
            // 
            // ToolStripTable
            // 
            ToolStripTable.ColumnCount = 1;
            ToolStripTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            ToolStripTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            ToolStripTable.Controls.Add(ToolStrip, 0, 0);
            ToolStripTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStripTable.Location = new System.Drawing.Point(0, 794);
            ToolStripTable.Name = "ToolStripTable";
            ToolStripTable.RowCount = 1;
            ToolStripTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            ToolStripTable.Size = new System.Drawing.Size(1488, 45);
            ToolStripTable.TabIndex = 0;
            // 
            // ToolStrip
            // 
            ToolStrip.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            ToolStrip.CanOverrideStyle = true;
            ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            ToolStrip.CaptionFont = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStrip.CaptionMinHeight = 0;
            ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolStrip.FirstButton = null;
            ToolStrip.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StatusLabel, StatusSpacer, Separator1, ToolStripDomainComboBox, Separator2, PreviousButton, Separator3, NextButton, Separator4, ToolStripKeyWordTextBox, Separator5, ToolStripLookupButton, Separator6, ToolStripCancelButton, Separator7, ToolStripChromeButton, Separator8, ToolStripEdgeButton, Separator9, ToolStripSharepointButton, Separator10, ToolStripFireFoxButton, Separator16, ToolStripRefreshButton, Separator11, DeveloperToolsButton, Separator13, ToolStripDownloadButton, Separator15, DownloadSeparator, ProgressBar, ToolStripCloseButton, Separator14, ToolStripHomeButton, ProgressSeparator });
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point(1, 1);
            ToolStrip.Margin = new System.Windows.Forms.Padding(1);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NavigationLabel = null;
            ToolStrip.NextButton = null;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            ToolStrip.Padding = new System.Windows.Forms.Padding(1);
            ToolStrip.PreviousButton = null;
            ToolStrip.RefreshButton = null;
            ToolStrip.SearchEngineComboBox = null;
            ToolStrip.SearchEngineLabel = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = true;
            ToolStrip.ShowItemToolTips = true;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new System.Drawing.Size(1486, 43);
            ToolStrip.TabIndex = 9;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.FromArgb(0, 120, 212);
            ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(65, 65, 65);
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.FromArgb(0, 120, 212);
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(40, 40, 40);
            ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            ToolStrip.ThemeStyle.ItemFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStrip.ToolBarTextBox = null;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            ToolStrip.WebsiteComboBox = null;
            ToolStrip.WebsiteLabel = null;
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            StatusLabel.Font = new System.Drawing.Font("Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding(1);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding(1);
            StatusLabel.Size = new System.Drawing.Size(85, 25);
            StatusLabel.Tag = "";
            StatusLabel.Text = "          Date and Time";
            StatusLabel.ToolTip = null;
            // 
            // StatusSpacer
            // 
            StatusSpacer.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            StatusSpacer.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StatusSpacer.ForeColor = System.Drawing.Color.Black;
            StatusSpacer.HoverText = null;
            StatusSpacer.Margin = new System.Windows.Forms.Padding(1);
            StatusSpacer.Name = "StatusSpacer";
            StatusSpacer.Padding = new System.Windows.Forms.Padding(1);
            StatusSpacer.Size = new System.Drawing.Size(2, 25);
            StatusSpacer.Tag = "";
            StatusSpacer.ToolTip = null;
            // 
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding(1);
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding(1);
            Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripDomainComboBox
            // 
            ToolStripDomainComboBox.AutoToolTip = true;
            ToolStripDomainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ToolStripDomainComboBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripDomainComboBox.ForeColor = System.Drawing.Color.FromArgb(38, 38, 38);
            ToolStripDomainComboBox.HoverText = "Select Domains";
            ToolStripDomainComboBox.Items.AddRange(new object[] { "Google", "EPA ", "DATA  ", "GPO ", "USGI ", "CRS ", "LOC ", "OMB ", "UST ", "NASA ", "NOAA ", "DOI ", "NPS ", "GSA ", "NARA ", "DOC", "HHS", "NRC", "DOE", "NSF", "USDA", "CSB", "IRS", "FDA", "CDC", "ACE", "DHS", "DOD", "USNO", "NWS" });
            ToolStripDomainComboBox.MaxLength = 32767;
            ToolStripDomainComboBox.MetroColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ToolStripDomainComboBox.Name = "ToolStripDomainComboBox";
            ToolStripDomainComboBox.Size = new System.Drawing.Size(150, 27);
            ToolStripDomainComboBox.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            ToolStripDomainComboBox.ToolTip = ToolTip;
            ToolStripDomainComboBox.ToolTipText = "Select Domains";
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb(5, 5, 5);
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
            ToolTip.ThemeName = "Baby";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding(1);
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding(1);
            Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.Transparent;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousButton.HoverText = "Previous Page";
            PreviousButton.Image = (System.Drawing.Image)resources.GetObject("PreviousButton.Image");
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding(1);
            PreviousButton.Size = new System.Drawing.Size(24, 25);
            PreviousButton.Text = "toolStripButton1";
            PreviousButton.ToolTip = ToolTip;
            PreviousButton.ToolType = ToolType.PreviousButton;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding(1);
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding(1);
            Separator3.Size = new System.Drawing.Size(6, 25);
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.Transparent;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = "Next Page";
            NextButton.Image = (System.Drawing.Image)resources.GetObject("NextButton.Image");
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding(1);
            NextButton.Size = new System.Drawing.Size(24, 25);
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding(1);
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding(1);
            Separator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripKeyWordTextBox
            // 
            ToolStripKeyWordTextBox.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ToolStripKeyWordTextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripKeyWordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            ToolStripKeyWordTextBox.HoverText = "SaveAs Keywords";
            ToolStripKeyWordTextBox.Margin = new System.Windows.Forms.Padding(1);
            ToolStripKeyWordTextBox.Name = "ToolStripKeyWordTextBox";
            ToolStripKeyWordTextBox.Padding = new System.Windows.Forms.Padding(1);
            ToolStripKeyWordTextBox.Size = new System.Drawing.Size(134, 25);
            ToolStripKeyWordTextBox.Tag = "";
            ToolStripKeyWordTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ToolStripKeyWordTextBox.ToolTip = ToolTip;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding(1);
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding(1);
            Separator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLookupButton
            // 
            ToolStripLookupButton.AutoToolTip = false;
            ToolStripLookupButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripLookupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripLookupButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripLookupButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripLookupButton.HoverText = "Begin Search";
            ToolStripLookupButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripLookupButton.Image");
            ToolStripLookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripLookupButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripLookupButton.Name = "ToolStripLookupButton";
            ToolStripLookupButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripLookupButton.Size = new System.Drawing.Size(24, 25);
            ToolStripLookupButton.ToolTip = ToolTip;
            ToolStripLookupButton.ToolType = ToolType.FirstButton;
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding(1);
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding(1);
            Separator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripCancelButton
            // 
            ToolStripCancelButton.AutoToolTip = false;
            ToolStripCancelButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripCancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripCancelButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripCancelButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripCancelButton.HoverText = "Cancel Search";
            ToolStripCancelButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripCancelButton.Image");
            ToolStripCancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripCancelButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripCancelButton.Name = "ToolStripCancelButton";
            ToolStripCancelButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripCancelButton.Size = new System.Drawing.Size(24, 25);
            ToolStripCancelButton.Text = "toolStripButton1";
            ToolStripCancelButton.ToolTip = ToolTip;
            ToolStripCancelButton.ToolType = ToolType.FirstButton;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding(1);
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding(1);
            Separator7.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripChromeButton
            // 
            ToolStripChromeButton.AutoToolTip = false;
            ToolStripChromeButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripChromeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripChromeButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripChromeButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripChromeButton.HoverText = "Use Chrome";
            ToolStripChromeButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripChromeButton.Image");
            ToolStripChromeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripChromeButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripChromeButton.Name = "ToolStripChromeButton";
            ToolStripChromeButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripChromeButton.Size = new System.Drawing.Size(24, 25);
            ToolStripChromeButton.Text = "toolStripButton1";
            ToolStripChromeButton.ToolTip = ToolTip;
            ToolStripChromeButton.ToolType = ToolType.GoogleButton;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding(1);
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding(1);
            Separator8.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripEdgeButton
            // 
            ToolStripEdgeButton.AutoToolTip = false;
            ToolStripEdgeButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripEdgeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripEdgeButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripEdgeButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripEdgeButton.HoverText = "Use Edge";
            ToolStripEdgeButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripEdgeButton.Image");
            ToolStripEdgeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripEdgeButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripEdgeButton.Name = "ToolStripEdgeButton";
            ToolStripEdgeButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripEdgeButton.Size = new System.Drawing.Size(24, 25);
            ToolStripEdgeButton.Text = "toolStripButton1";
            ToolStripEdgeButton.ToolTip = ToolTip;
            ToolStripEdgeButton.ToolType = ToolType.FirstButton;
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding(1);
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding(1);
            Separator9.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSharepointButton
            // 
            ToolStripSharepointButton.AutoToolTip = false;
            ToolStripSharepointButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripSharepointButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripSharepointButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripSharepointButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripSharepointButton.HoverText = "Use Sharepoint";
            ToolStripSharepointButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripSharepointButton.Image");
            ToolStripSharepointButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripSharepointButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripSharepointButton.Name = "ToolStripSharepointButton";
            ToolStripSharepointButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripSharepointButton.Size = new System.Drawing.Size(24, 25);
            ToolStripSharepointButton.Text = "toolStripButton1";
            ToolStripSharepointButton.ToolTip = ToolTip;
            ToolStripSharepointButton.ToolType = ToolType.FirstButton;
            // 
            // Separator10
            // 
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding(1);
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding(1);
            Separator10.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripFireFoxButton
            // 
            ToolStripFireFoxButton.AutoToolTip = false;
            ToolStripFireFoxButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripFireFoxButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripFireFoxButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripFireFoxButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripFireFoxButton.HoverText = "Open Firefox";
            ToolStripFireFoxButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripFireFoxButton.Image");
            ToolStripFireFoxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripFireFoxButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripFireFoxButton.Name = "ToolStripFireFoxButton";
            ToolStripFireFoxButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripFireFoxButton.Size = new System.Drawing.Size(24, 25);
            ToolStripFireFoxButton.Text = "toolStripButton1";
            ToolStripFireFoxButton.ToolTip = ToolTip;
            ToolStripFireFoxButton.ToolType = ToolType.FirstButton;
            // 
            // Separator16
            // 
            Separator16.ForeColor = System.Drawing.Color.Black;
            Separator16.Margin = new System.Windows.Forms.Padding(1);
            Separator16.Name = "Separator16";
            Separator16.Padding = new System.Windows.Forms.Padding(1);
            Separator16.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripRefreshButton
            // 
            ToolStripRefreshButton.AutoToolTip = false;
            ToolStripRefreshButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripRefreshButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripRefreshButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripRefreshButton.HoverText = "Refresh Search";
            ToolStripRefreshButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripRefreshButton.Image");
            ToolStripRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripRefreshButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripRefreshButton.Name = "ToolStripRefreshButton";
            ToolStripRefreshButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripRefreshButton.Size = new System.Drawing.Size(24, 25);
            ToolStripRefreshButton.Text = "toolStripButton1";
            ToolStripRefreshButton.ToolTip = ToolTip;
            ToolStripRefreshButton.ToolType = ToolType.RefreshButton;
            // 
            // Separator11
            // 
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding(1);
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding(1);
            Separator11.Size = new System.Drawing.Size(6, 25);
            // 
            // DeveloperToolsButton
            // 
            DeveloperToolsButton.AutoToolTip = false;
            DeveloperToolsButton.BackColor = System.Drawing.Color.Transparent;
            DeveloperToolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DeveloperToolsButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DeveloperToolsButton.ForeColor = System.Drawing.Color.LightGray;
            DeveloperToolsButton.HoverText = "Open Developer Tools";
            DeveloperToolsButton.Image = (System.Drawing.Image)resources.GetObject("DeveloperToolsButton.Image");
            DeveloperToolsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            DeveloperToolsButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            DeveloperToolsButton.Name = "DeveloperToolsButton";
            DeveloperToolsButton.Padding = new System.Windows.Forms.Padding(1);
            DeveloperToolsButton.Size = new System.Drawing.Size(24, 25);
            DeveloperToolsButton.Text = "toolStripButton1";
            DeveloperToolsButton.ToolTip = ToolTip;
            DeveloperToolsButton.ToolType = ToolType.FirstButton;
            // 
            // Separator13
            // 
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding(1);
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding(1);
            Separator13.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripDownloadButton
            // 
            ToolStripDownloadButton.AutoToolTip = false;
            ToolStripDownloadButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripDownloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripDownloadButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripDownloadButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripDownloadButton.HoverText = "View Downloads";
            ToolStripDownloadButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripDownloadButton.Image");
            ToolStripDownloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripDownloadButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripDownloadButton.Name = "ToolStripDownloadButton";
            ToolStripDownloadButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripDownloadButton.Size = new System.Drawing.Size(24, 25);
            ToolStripDownloadButton.Text = "toolStripButton1";
            ToolStripDownloadButton.ToolTip = ToolTip;
            ToolStripDownloadButton.ToolType = ToolType.DownloadButton;
            // 
            // Separator15
            // 
            Separator15.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator15.ForeColor = System.Drawing.Color.Black;
            Separator15.Margin = new System.Windows.Forms.Padding(1);
            Separator15.Name = "Separator15";
            Separator15.Padding = new System.Windows.Forms.Padding(1);
            Separator15.Size = new System.Drawing.Size(6, 25);
            // 
            // DownloadSeparator
            // 
            DownloadSeparator.ForeColor = System.Drawing.Color.Black;
            DownloadSeparator.Margin = new System.Windows.Forms.Padding(1);
            DownloadSeparator.Name = "DownloadSeparator";
            DownloadSeparator.Padding = new System.Windows.Forms.Padding(1);
            DownloadSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ProgressBar
            // 
            ProgressBar.BackColor = System.Drawing.SystemColors.ControlDark;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new System.Drawing.Size(150, 24);
            // 
            // ToolStripCloseButton
            // 
            ToolStripCloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ToolStripCloseButton.AutoToolTip = false;
            ToolStripCloseButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripCloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripCloseButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripCloseButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripCloseButton.HoverText = "Close Browser";
            ToolStripCloseButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripCloseButton.Image");
            ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripCloseButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripCloseButton.Name = "ToolStripCloseButton";
            ToolStripCloseButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripCloseButton.Size = new System.Drawing.Size(24, 25);
            ToolStripCloseButton.Text = "toolStripButton2";
            ToolStripCloseButton.ToolTip = ToolTip;
            ToolStripCloseButton.ToolType = ToolType.CloseButton;
            // 
            // Separator14
            // 
            Separator14.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator14.ForeColor = System.Drawing.Color.Black;
            Separator14.Margin = new System.Windows.Forms.Padding(1);
            Separator14.Name = "Separator14";
            Separator14.Padding = new System.Windows.Forms.Padding(1);
            Separator14.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripHomeButton
            // 
            ToolStripHomeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ToolStripHomeButton.AutoToolTip = false;
            ToolStripHomeButton.BackColor = System.Drawing.Color.Transparent;
            ToolStripHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripHomeButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ToolStripHomeButton.ForeColor = System.Drawing.Color.LightGray;
            ToolStripHomeButton.HoverText = "Home Page";
            ToolStripHomeButton.Image = (System.Drawing.Image)resources.GetObject("ToolStripHomeButton.Image");
            ToolStripHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripHomeButton.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            ToolStripHomeButton.Name = "ToolStripHomeButton";
            ToolStripHomeButton.Padding = new System.Windows.Forms.Padding(1);
            ToolStripHomeButton.Size = new System.Drawing.Size(24, 25);
            ToolStripHomeButton.ToolTip = null;
            ToolStripHomeButton.ToolType = ToolType.HomeButton;
            // 
            // ProgressSeparator
            // 
            ProgressSeparator.ForeColor = System.Drawing.Color.Black;
            ProgressSeparator.Margin = new System.Windows.Forms.Padding(1);
            ProgressSeparator.Name = "ProgressSeparator";
            ProgressSeparator.Padding = new System.Windows.Forms.Padding(1);
            ProgressSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding(1);
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding(1);
            Separator12.Size = new System.Drawing.Size(6, 23);
            // 
            // TopTable
            // 
            TopTable.ColumnCount = 4;
            TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02842F));
            TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.97158F));
            TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            TopTable.Controls.Add(Title, 1, 0);
            TopTable.Controls.Add(PictureBox, 0, 0);
            TopTable.Controls.Add(TimeLabel, 2, 0);
            TopTable.Controls.Add(ControlBox, 3, 0);
            TopTable.Dock = System.Windows.Forms.DockStyle.Top;
            TopTable.Location = new System.Drawing.Point(0, 0);
            TopTable.Name = "TopTable";
            TopTable.RowCount = 1;
            TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            TopTable.Size = new System.Drawing.Size(1488, 34);
            TopTable.TabIndex = 0;
            // 
            // Title
            // 
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point(204, 3);
            Title.Margin = new System.Windows.Forms.Padding(3);
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding(1);
            Title.Size = new System.Drawing.Size(911, 28);
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Title";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Baby";
            Title.ToolTip = ToolTip;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.Image = (System.Drawing.Image)resources.GetObject("PictureBox.Image");
            PictureBox.Location = new System.Drawing.Point(1, 1);
            PictureBox.Margin = new System.Windows.Forms.Padding(1);
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding(1);
            PictureBox.Size = new System.Drawing.Size(22, 22);
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // TimeLabel
            // 
            TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            TimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TimeLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TimeLabel.HoverText = null;
            TimeLabel.IsDerivedStyle = true;
            TimeLabel.Location = new System.Drawing.Point(1121, 3);
            TimeLabel.Margin = new System.Windows.Forms.Padding(3);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Padding = new System.Windows.Forms.Padding(1);
            TimeLabel.Size = new System.Drawing.Size(195, 28);
            TimeLabel.Style = MetroSet_UI.Enums.Style.Custom;
            TimeLabel.StyleManager = null;
            TimeLabel.TabIndex = 2;
            TimeLabel.Text = "label2";
            TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            TimeLabel.ThemeAuthor = "Terry D. Eppler";
            TimeLabel.ThemeName = "Baby";
            TimeLabel.ToolTip = null;
            // 
            // ControlBox
            // 
            ControlBox.CloseHoverBackColor = System.Drawing.Color.Maroon;
            ControlBox.CloseHoverForeColor = System.Drawing.Color.White;
            ControlBox.CloseNormalForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ControlBox.DisabledForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            ControlBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ControlBox.ForeColor = System.Drawing.Color.FromArgb(106, 189, 252);
            ControlBox.IsDerivedStyle = true;
            ControlBox.Location = new System.Drawing.Point(1387, 1);
            ControlBox.Margin = new System.Windows.Forms.Padding(1);
            ControlBox.MaximizeBox = true;
            ControlBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(50, 93, 129);
            ControlBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            ControlBox.MaximizeNormalForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ControlBox.MinimizeBox = true;
            ControlBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(50, 93, 129);
            ControlBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            ControlBox.MinimizeNormalForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ControlBox.Name = "ControlBox";
            ControlBox.Padding = new System.Windows.Forms.Padding(1);
            ControlBox.Size = new System.Drawing.Size(100, 25);
            ControlBox.Style = MetroSet_UI.Enums.Style.Custom;
            ControlBox.StyleManager = null;
            ControlBox.TabIndex = 3;
            ControlBox.Text = "controlBox1";
            ControlBox.ThemeAuthor = "Terry D. Eppler";
            ControlBox.ThemeName = "DarkControls";
            // 
            // UrlTextBoxTable
            // 
            UrlTextBoxTable.ColumnCount = 3;
            UrlTextBoxTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.4285717F));
            UrlTextBoxTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.57143F));
            UrlTextBoxTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            UrlTextBoxTable.Controls.Add(SearchLayout, 2, 0);
            UrlTextBoxTable.Controls.Add(NavigationLayout, 0, 0);
            UrlTextBoxTable.Controls.Add(UrlTextBox, 1, 0);
            UrlTextBoxTable.Dock = System.Windows.Forms.DockStyle.Fill;
            UrlTextBoxTable.Location = new System.Drawing.Point(1, 1);
            UrlTextBoxTable.Name = "UrlTextBoxTable";
            UrlTextBoxTable.RowCount = 1;
            UrlTextBoxTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            UrlTextBoxTable.Size = new System.Drawing.Size(1486, 40);
            UrlTextBoxTable.TabIndex = 0;
            // 
            // SearchLayout
            // 
            SearchLayout.Controls.Add(SearchLookupButton);
            SearchLayout.Controls.Add(SearchCancelButton);
            SearchLayout.Controls.Add(SearchRefreshButton);
            SearchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            SearchLayout.Location = new System.Drawing.Point(1333, 3);
            SearchLayout.Name = "SearchLayout";
            SearchLayout.Size = new System.Drawing.Size(150, 34);
            SearchLayout.TabIndex = 0;
            // 
            // SearchLookupButton
            // 
            SearchLookupButton.FlatAppearance.BorderSize = 0;
            SearchLookupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            SearchLookupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 93, 129);
            SearchLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchLookupButton.Image = Properties.Resources.MenulLabel;
            SearchLookupButton.Location = new System.Drawing.Point(3, 3);
            SearchLookupButton.Name = "SearchLookupButton";
            SearchLookupButton.Padding = new System.Windows.Forms.Padding(5);
            SearchLookupButton.Size = new System.Drawing.Size(30, 28);
            SearchLookupButton.TabIndex = 0;
            SearchLookupButton.UseVisualStyleBackColor = true;
            // 
            // SearchCancelButton
            // 
            SearchCancelButton.FlatAppearance.BorderSize = 0;
            SearchCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            SearchCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            SearchCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchCancelButton.Image = Properties.Resources.WebCancelButton;
            SearchCancelButton.Location = new System.Drawing.Point(39, 3);
            SearchCancelButton.Name = "SearchCancelButton";
            SearchCancelButton.Padding = new System.Windows.Forms.Padding(5);
            SearchCancelButton.Size = new System.Drawing.Size(33, 28);
            SearchCancelButton.TabIndex = 2;
            SearchCancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchRefreshButton
            // 
            SearchRefreshButton.FlatAppearance.BorderSize = 0;
            SearchRefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            SearchRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 93, 129);
            SearchRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchRefreshButton.Image = Properties.Resources.SearchRefreshButton;
            SearchRefreshButton.Location = new System.Drawing.Point(78, 3);
            SearchRefreshButton.Name = "SearchRefreshButton";
            SearchRefreshButton.Padding = new System.Windows.Forms.Padding(5);
            SearchRefreshButton.Size = new System.Drawing.Size(32, 28);
            SearchRefreshButton.TabIndex = 2;
            SearchRefreshButton.UseVisualStyleBackColor = true;
            // 
            // NavigationLayout
            // 
            NavigationLayout.Controls.Add(SearchHomeButton);
            NavigationLayout.Controls.Add(SearchForwardButton);
            NavigationLayout.Controls.Add(SearchBackButton);
            NavigationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            NavigationLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            NavigationLayout.Location = new System.Drawing.Point(3, 3);
            NavigationLayout.Name = "NavigationLayout";
            NavigationLayout.Size = new System.Drawing.Size(146, 34);
            NavigationLayout.TabIndex = 1;
            // 
            // SearchHomeButton
            // 
            SearchHomeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            SearchHomeButton.FlatAppearance.BorderSize = 0;
            SearchHomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            SearchHomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 93, 129);
            SearchHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchHomeButton.Image = Properties.Resources.WebHomeButton;
            SearchHomeButton.Location = new System.Drawing.Point(112, 3);
            SearchHomeButton.Name = "SearchHomeButton";
            SearchHomeButton.Padding = new System.Windows.Forms.Padding(5);
            SearchHomeButton.Size = new System.Drawing.Size(31, 28);
            SearchHomeButton.TabIndex = 1;
            SearchHomeButton.UseVisualStyleBackColor = true;
            // 
            // SearchForwardButton
            // 
            SearchForwardButton.FlatAppearance.BorderSize = 0;
            SearchForwardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            SearchForwardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 93, 129);
            SearchForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchForwardButton.Image = Properties.Resources.SearchNextButton;
            SearchForwardButton.Location = new System.Drawing.Point(73, 3);
            SearchForwardButton.Name = "SearchForwardButton";
            SearchForwardButton.Padding = new System.Windows.Forms.Padding(5);
            SearchForwardButton.Size = new System.Drawing.Size(33, 28);
            SearchForwardButton.TabIndex = 2;
            SearchForwardButton.UseVisualStyleBackColor = true;
            // 
            // SearchBackButton
            // 
            SearchBackButton.FlatAppearance.BorderSize = 0;
            SearchBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            SearchBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 93, 129);
            SearchBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchBackButton.Image = Properties.Resources.SearchPreviousButton;
            SearchBackButton.Location = new System.Drawing.Point(35, 3);
            SearchBackButton.Name = "SearchBackButton";
            SearchBackButton.Padding = new System.Windows.Forms.Padding(5);
            SearchBackButton.Size = new System.Drawing.Size(32, 28);
            SearchBackButton.TabIndex = 2;
            SearchBackButton.UseVisualStyleBackColor = true;
            // 
            // UrlTextBox
            // 
            UrlTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            UrlTextBox.AutoCompleteCustomSource = null;
            UrlTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            UrlTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            UrlTextBox.BorderColor = System.Drawing.Color.FromArgb(0, 120, 212);
            UrlTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            UrlTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(20, 20, 20);
            UrlTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            UrlTextBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UrlTextBox.HoverColor = System.Drawing.Color.FromArgb(0, 120, 212);
            UrlTextBox.HoverText = null;
            UrlTextBox.Image = null;
            UrlTextBox.IsDerivedStyle = true;
            UrlTextBox.Lines = null;
            UrlTextBox.Location = new System.Drawing.Point(153, 6);
            UrlTextBox.Margin = new System.Windows.Forms.Padding(1);
            UrlTextBox.MaxLength = 32767;
            UrlTextBox.Multiline = false;
            UrlTextBox.Name = "UrlTextBox";
            UrlTextBox.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            UrlTextBox.ReadOnly = false;
            UrlTextBox.SelectionLength = 0;
            UrlTextBox.Size = new System.Drawing.Size(1176, 28);
            UrlTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            UrlTextBox.StyleManager = null;
            UrlTextBox.TabIndex = 0;
            UrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            UrlTextBox.ThemeAuthor = "Terry D. Eppler";
            UrlTextBox.ThemeName = "Baby";
            UrlTextBox.ToolTip = null;
            UrlTextBox.UseSystemPasswordChar = false;
            UrlTextBox.WatermarkText = "";
            // 
            // UrlSearchPanel
            // 
            UrlSearchPanel.BackColor = System.Drawing.Color.Transparent;
            UrlSearchPanel.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            UrlSearchPanel.BorderColor = System.Drawing.Color.Transparent;
            UrlSearchPanel.BorderThickness = 1;
            UrlSearchPanel.Children = null;
            UrlSearchPanel.Controls.Add(UrlTextBoxTable);
            UrlSearchPanel.DataFilter = null;
            UrlSearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            UrlSearchPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UrlSearchPanel.ForeColor = System.Drawing.Color.Transparent;
            UrlSearchPanel.HoverText = null;
            UrlSearchPanel.IsDerivedStyle = true;
            UrlSearchPanel.Location = new System.Drawing.Point(0, 34);
            UrlSearchPanel.Name = "UrlSearchPanel";
            UrlSearchPanel.Padding = new System.Windows.Forms.Padding(1);
            UrlSearchPanel.Size = new System.Drawing.Size(1488, 42);
            UrlSearchPanel.Style = MetroSet_UI.Enums.Style.Custom;
            UrlSearchPanel.StyleManager = null;
            UrlSearchPanel.TabIndex = 1;
            UrlSearchPanel.ThemeAuthor = "Terry D. Eppler";
            UrlSearchPanel.ThemeName = "Baby";
            UrlSearchPanel.ToolTip = null;
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ContextMenu.ForeColor = System.Drawing.Color.White;
            ContextMenu.IsDerivedStyle = true;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.Size = new System.Drawing.Size(160, 450);
            ContextMenu.Style = MetroSet_UI.Enums.Style.Custom;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "Baby";
            // 
            // WebBrowser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            BorderColor = System.Drawing.Color.FromArgb(0, 120, 212);
            CaptionBarColor = System.Drawing.Color.FromArgb(20, 20, 20);
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(20, 20, 20);
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
            CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CaptionForeColor = System.Drawing.Color.FromArgb(0, 120, 212);
            ClientSize = new System.Drawing.Size(1488, 839);
            Controls.Add(TabPages);
            Controls.Add(UrlSearchPanel);
            Controls.Add(ToolStripTable);
            Controls.Add(TopTable);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.FromArgb(106, 189, 252);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1500, 850);
            MetroColor = System.Drawing.Color.FromArgb(20, 20, 20);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1500, 850);
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
            ((System.ComponentModel.ISupportInitialize)TabPages).EndInit();
            TabPages.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ToolStripTable.ResumeLayout(false);
            ToolStripTable.PerformLayout();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            TopTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            UrlTextBoxTable.ResumeLayout(false);
            SearchLayout.ResumeLayout(false);
            NavigationLayout.ResumeLayout(false);
            UrlSearchPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public BrowserTabStrip TabPages;
        public BrowserTabStripItem TabItem;
        public BrowserTabStripItem AddItemTab;
        public System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.Panel SearchPanel;
        public System.Windows.Forms.TextBox SearchPanelTextBox;
        public System.Windows.Forms.Button CloseSearchButton;
        public System.Windows.Forms.Button FirstButton;
        public System.Windows.Forms.Button LastButton;
        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public ToolStrip ToolStrip;
        public ToolSeparator Separator1;
        public ToolStripComboBox ToolStripDomainComboBox;
        public ToolTip ToolTip;
        public ToolSeparator Separator2;
        public ToolStripButton PreviousButton;
        public ToolSeparator Separator3;
        public ToolStripButton NextButton;
        public ToolSeparator Separator4;
        public ToolStripTextBox ToolStripKeyWordTextBox;
        public ToolSeparator Separator6;
        public ToolStripButton ToolStripCancelButton;
        public ToolSeparator Separator7;
        public ToolStripButton ToolStripChromeButton;
        public ToolSeparator Separator13;
        public ToolStripButton ToolStripDownloadButton;
        public ToolSeparator Separator8;
        public ToolSeparator Separator14;
        public ToolStripButton ToolStripHomeButton;
        public ToolSeparator Separator15;
        public ToolStripButton ToolStripCloseButton;
        public ImageBox PictureBox;
        public ToolStripButton ToolStripLookupButton;
        public ToolSeparator Separator5;
        public System.Windows.Forms.TableLayoutPanel TopTable;
        public ToolStripButton ToolStripEdgeButton;
        public ToolStripButton ToolStripSharepointButton;
        public ToolStripButton ToolStripRefreshButton;
        public ToolStripButton DeveloperToolsButton;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolSeparator Separator11;
        public ToolSeparator Separator12;
        public System.Windows.Forms.TableLayoutPanel UrlTextBoxTable;
        private Layout UrlSearchPanel;
        public Label Title;
        public ToolStripButton ToolStripFireFoxButton;
        public ToolSeparator Separator16;
        public ContextMenu ContextMenu;
        public Label MenuLabel;
        private Label label1;
        public System.Windows.Forms.Button SearchLookupButton;
        public ToolStripLabel StatusLabel;
        public ToolSeparator DownloadSeparator;
        public System.Windows.Forms.ToolStripProgressBar ProgressBar;
        public ToolSeparator ProgressSeparator;
        public ToolStripLabel StatusSpacer;
        public TextBox UrlTextBox;
        public System.Windows.Forms.Button SearchHomeButton;
        public System.Windows.Forms.Button SearchForwardButton;
        public System.Windows.Forms.Button SearchBackButton;
        public Label TimeLabel;
        public System.Windows.Forms.Button SearchRefreshButton;
        public System.Windows.Forms.Button SearchCancelButton;
        public System.Windows.Forms.FlowLayoutPanel SearchLayout;
        public System.Windows.Forms.FlowLayoutPanel NavigationLayout;
        private ControlBox ControlBox;
    }
}

