namespace Baby
{
    public partial class GuidanceDialog
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( GuidanceDialog ) );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ListBox = new ListBox( );
            ClearButton = new Button( );
            SelectButton = new Button( );
            CloseButton = new Button( );
            Picture = new ImageBox( );
            HeaderLabel = new Label( );
            BrowseButton = new Button( );
            OpenFileDialog = new System.Windows.Forms.OpenFileDialog( );
            ToolTip = new ToolTip( );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize) Picture  ).BeginInit( );
            HeaderTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // ListBox
            // 
            ListBox.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            ListBox.BindingSource = BindingSource;
            ListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
            ListBox.DataFilter = null;
            ListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ListBox.HoveredItemColor = System.Drawing.Color.White;
            ListBox.HoverText = null;
            ListBox.IsDerivedStyle = true;
            ListBox.ItemHeight = 28;
            ListBox.Location = new System.Drawing.Point( 65, 51 );
            ListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ListBox.MultiSelect = true;
            ListBox.Name = "ListBox";
            ListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ListBox.SelectedIndex = -1;
            ListBox.SelectedItem = null;
            ListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ListBox.SelectedItemColor = System.Drawing.Color.White;
            ListBox.SelectedText = null;
            ListBox.SelectedValue = null;
            ListBox.ShowBorder = false;
            ListBox.ShowScrollBar = false;
            ListBox.Size = new System.Drawing.Size( 367, 270 );
            ListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ListBox.StyleManager = null;
            ListBox.TabIndex = 0;
            ListBox.ThemeAuthor = "Terry D. Eppler";
            ListBox.ThemeName = "Baby";
            ListBox.ToolTip = null;
            // 
            // ClearButton
            // 
            ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ClearButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ClearButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            ClearButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ClearButton.HoverText = null;
            ClearButton.HoverTextColor = System.Drawing.Color.White;
            ClearButton.IsDerivedStyle = true;
            ClearButton.Location = new System.Drawing.Point( 3, 379 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.Transparent;
            ClearButton.NormalColor = System.Drawing.Color.Transparent;
            ClearButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 78, 26 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "Baby";
            ClearButton.ToolTip = null;
            // 
            // SelectButton
            // 
            SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SelectButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            SelectButton.HoverText = null;
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 263, 379 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.Transparent;
            SelectButton.NormalColor = System.Drawing.Color.Transparent;
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 78, 26 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 2;
            SelectButton.Text = "Select";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Baby";
            SelectButton.ToolTip = null;
            // 
            // CloseButton
            // 
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 401, 379 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.Transparent;
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 78, 26 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Baby";
            CloseButton.ToolTip = null;
            // 
            // Picture
            // 
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.Image = Properties.Resources.EpaSkew;
            Picture.Location = new System.Drawing.Point( 3, 3 );
            Picture.Name = "Picture";
            Picture.Padding = new System.Windows.Forms.Padding( 1 );
            Picture.Size = new System.Drawing.Size( 34, 22 );
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 4;
            Picture.TabStop = false;
            Picture.ToolTip = null;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            HeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            HeaderLabel.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            HeaderLabel.HoverText = null;
            HeaderLabel.IsDerivedStyle = true;
            HeaderLabel.Location = new System.Drawing.Point( 59, 3 );
            HeaderLabel.Margin = new System.Windows.Forms.Padding( 3 );
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Padding = new System.Windows.Forms.Padding( 1 );
            HeaderLabel.Size = new System.Drawing.Size( 429, 26 );
            HeaderLabel.Style = MetroSet_UI.Enums.Style.Custom;
            HeaderLabel.StyleManager = null;
            HeaderLabel.TabIndex = 5;
            HeaderLabel.Text = "Guidance";
            HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            HeaderLabel.ThemeAuthor = "Terry D. Eppler";
            HeaderLabel.ThemeName = "Baby";
            HeaderLabel.ToolTip = null;
            // 
            // BrowseButton
            // 
            BrowseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BrowseButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BrowseButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            BrowseButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            BrowseButton.HoverText = null;
            BrowseButton.HoverTextColor = System.Drawing.Color.White;
            BrowseButton.IsDerivedStyle = true;
            BrowseButton.Location = new System.Drawing.Point( 129, 379 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.NormalColor = System.Drawing.Color.Transparent;
            BrowseButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BrowseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BrowseButton.PressTextColor = System.Drawing.Color.White;
            BrowseButton.Size = new System.Drawing.Size( 78, 26 );
            BrowseButton.Style = MetroSet_UI.Enums.Style.Custom;
            BrowseButton.StyleManager = null;
            BrowseButton.TabIndex = 6;
            BrowseButton.Text = "FromBrowser";
            BrowseButton.ThemeAuthor = "Terry D. Eppler";
            BrowseButton.ThemeName = "Baby";
            BrowseButton.ToolTip = null;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.Title = "SaveAs for Document";
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
            ToolTip.ThemeName = "Baby";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 3;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 76.78571F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 23.2142849F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 434F ) );
            HeaderTable.Controls.Add( Picture, 0, 0 );
            HeaderTable.Controls.Add( HeaderLabel, 2, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 491, 32 );
            HeaderTable.TabIndex = 8;
            // 
            // GuidanceDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 491, 417 );
            ControlBox = false;
            Controls.Add( BrowseButton );
            Controls.Add( HeaderTable );
            Controls.Add( ClearButton );
            Controls.Add( SelectButton );
            Controls.Add( ListBox );
            Controls.Add( CloseButton );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 503, 429 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 503, 429 );
            Name = "GuidanceDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize) Picture  ).EndInit( );
            HeaderTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        public System.Windows.Forms.BindingSource BindingSource;
        public ToolTip ToolTip;
        public Label HeaderLabel;
        public ListBox ListBox;
        public Button ClearButton;
        public Button SelectButton;
        public Button CloseButton;
        public Button BrowseButton;
        public System.Windows.Forms.OpenFileDialog OpenFileDialog;
        public ImageBox Picture;
        public System.Windows.Forms.TableLayoutPanel HeaderTable;
    }
}
