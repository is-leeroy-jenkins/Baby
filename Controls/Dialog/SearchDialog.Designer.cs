
namespace Baby
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    partial class SearchDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            var resources = new ComponentResourceManager( typeof( SearchDialog ) );
            ToolTip = new ToolTip( );
            LookupButton = new System.Windows.Forms.Button( );
            RefreshButton = new System.Windows.Forms.Button( );
            CloseButton = new System.Windows.Forms.Button( );
            ButtonTable = new TableLayoutPanel( );
            ControlTable = new TableLayoutPanel( );
            KeyWordLabel = new Label( );
            DomainLabel = new Label( );
            TextBox = new TextBox( );
            ComboBox = new ComboBox( );
            ButtonTable.SuspendLayout( );
            ControlTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb( 5, 5, 5 );
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
            ToolTip.TipIcon = ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // LookupButton
            // 
            LookupButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            LookupButton.DialogResult = DialogResult.OK;
            LookupButton.Dock = DockStyle.Fill;
            LookupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            LookupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 18, 79, 17 );
            LookupButton.FlatStyle = FlatStyle.Flat;
            LookupButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            LookupButton.Image = Properties.Resources.WebLookUpButton;
            LookupButton.Location = new System.Drawing.Point( 1, 1 );
            LookupButton.Margin = new Padding( 1 );
            LookupButton.Name = "LookupButton";
            LookupButton.Padding = new Padding( 5 );
            LookupButton.Size = new System.Drawing.Size( 39, 29 );
            LookupButton.TabIndex = 9;
            LookupButton.Tag = "Begin Search";
            LookupButton.UseVisualStyleBackColor = false;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            RefreshButton.DialogResult = DialogResult.Ignore;
            RefreshButton.Dock = DockStyle.Fill;
            RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            RefreshButton.Image = Properties.Resources.SearchRefreshButton;
            RefreshButton.Location = new System.Drawing.Point( 42, 1 );
            RefreshButton.Margin = new Padding( 1 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new Padding( 5 );
            RefreshButton.Size = new System.Drawing.Size( 35, 29 );
            RefreshButton.TabIndex = 1;
            RefreshButton.Tag = "Clear Search";
            RefreshButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CloseButton.DialogResult = DialogResult.Cancel;
            CloseButton.Dock = DockStyle.Fill;
            CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CloseButton.Image = Properties.Resources.SearchCancelButton;
            CloseButton.Location = new System.Drawing.Point( 79, 1 );
            CloseButton.Margin = new Padding( 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new Padding( 5 );
            CloseButton.Size = new System.Drawing.Size( 46, 29 );
            CloseButton.TabIndex = 3;
            CloseButton.Tag = "Cancel Search";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 3;
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 52.63158F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 47.36842F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 47F ) );
            ButtonTable.Controls.Add( LookupButton, 0, 0 );
            ButtonTable.Controls.Add( RefreshButton, 1, 0 );
            ButtonTable.Controls.Add( CloseButton, 2, 0 );
            ButtonTable.Dock = DockStyle.Fill;
            ButtonTable.Location = new System.Drawing.Point( 3, 3 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            ButtonTable.Size = new System.Drawing.Size( 126, 31 );
            ButtonTable.TabIndex = 11;
            // 
            // ControlTable
            // 
            ControlTable.ColumnCount = 1;
            ControlTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            ControlTable.Controls.Add( ButtonTable, 0, 0 );
            ControlTable.Location = new System.Drawing.Point( 433, 0 );
            ControlTable.Margin = new Padding( 1 );
            ControlTable.Name = "ControlTable";
            ControlTable.RowCount = 1;
            ControlTable.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            ControlTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            ControlTable.Size = new System.Drawing.Size( 132, 37 );
            ControlTable.TabIndex = 12;
            // 
            // KeyWordLabel
            // 
            KeyWordLabel.FlatStyle = FlatStyle.Flat;
            KeyWordLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            KeyWordLabel.HoverText = null;
            KeyWordLabel.IsDerivedStyle = true;
            KeyWordLabel.Location = new System.Drawing.Point( 12, 11 );
            KeyWordLabel.Margin = new Padding( 3 );
            KeyWordLabel.Name = "KeyWordLabel";
            KeyWordLabel.Padding = new Padding( 1 );
            KeyWordLabel.Size = new System.Drawing.Size( 254, 23 );
            KeyWordLabel.Style = MetroSet_UI.Enums.Style.Custom;
            KeyWordLabel.StyleManager = null;
            KeyWordLabel.TabIndex = 14;
            KeyWordLabel.Text = "Key Words:";
            KeyWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            KeyWordLabel.ThemeAuthor = "Terry D. Eppler";
            KeyWordLabel.ThemeName = "Baby";
            KeyWordLabel.ToolTip = null;
            // 
            // DomainLabel
            // 
            DomainLabel.FlatStyle = FlatStyle.Flat;
            DomainLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DomainLabel.HoverText = null;
            DomainLabel.IsDerivedStyle = true;
            DomainLabel.Location = new System.Drawing.Point( 281, 11 );
            DomainLabel.Margin = new Padding( 3 );
            DomainLabel.Name = "DomainLabel";
            DomainLabel.Padding = new Padding( 1 );
            DomainLabel.Size = new System.Drawing.Size( 128, 23 );
            DomainLabel.Style = MetroSet_UI.Enums.Style.Custom;
            DomainLabel.StyleManager = null;
            DomainLabel.TabIndex = 15;
            DomainLabel.Text = "Domain:";
            DomainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DomainLabel.ThemeAuthor = "Terry D. Eppler";
            DomainLabel.ThemeName = "Baby";
            DomainLabel.ToolTip = null;
            // 
            // TextBox
            // 
            TextBox.AutoCompleteCustomSource = null;
            TextBox.AutoCompleteMode = AutoCompleteMode.None;
            TextBox.AutoCompleteSource = AutoCompleteSource.None;
            TextBox.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
            TextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
            TextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 136, 136, 136 );
            TextBox.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TextBox.HoverText = null;
            TextBox.Image = null;
            TextBox.IsDerivedStyle = true;
            TextBox.Lines = null;
            TextBox.Location = new System.Drawing.Point( 12, 40 );
            TextBox.MaxLength = 32767;
            TextBox.Multiline = false;
            TextBox.Name = "TextBox";
            TextBox.ReadOnly = false;
            TextBox.SelectionLength = 0;
            TextBox.Size = new System.Drawing.Size( 397, 27 );
            TextBox.Style = MetroSet_UI.Enums.Style.Custom;
            TextBox.StyleManager = null;
            TextBox.TabIndex = 16;
            TextBox.Text = "Key Words";
            TextBox.TextAlign = HorizontalAlignment.Center;
            TextBox.ThemeAuthor = "Terry D. Eppler";
            TextBox.ThemeName = "Baby";
            TextBox.ToolTip = ToolTip;
            TextBox.UseSystemPasswordChar = false;
            TextBox.WatermarkText = "";
            // 
            // ComboBox
            // 
            ComboBox.AllowDrop = true;
            ComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ComboBox.BackColor = System.Drawing.Color.Transparent;
            ComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 75, 75, 75 );
            ComboBox.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ComboBox.CausesValidation = false;
            ComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            ComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            ComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox.FlatStyle = FlatStyle.Flat;
            ComboBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ComboBox.FormattingEnabled = true;
            ComboBox.HoverText = null;
            ComboBox.IsDerivedStyle = true;
            ComboBox.ItemHeight = 24;
            ComboBox.Items.AddRange( new object[ ] { "Google", "EPA ", "DATA  ", "GPO ", "USGI ", "CRS ", "LOC ", "OMB ", "UST ", "NASA ", "NOAA ", "DOI ", "NPS ", "GSA ", "NARA ", "DOC", "HHS", "NRC", "DOE", "NSF", "USDA", "CSB", "IRS", "FDA", "CDC", "ACE", "DHS", "DOD", "USNO", "NWS" } );
            ComboBox.Location = new System.Drawing.Point( 432, 40 );
            ComboBox.Name = "ComboBox";
            ComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            ComboBox.Size = new System.Drawing.Size( 129, 30 );
            ComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            ComboBox.StyleManager = null;
            ComboBox.TabIndex = 17;
            ComboBox.ThemeAuthor = "Terry D. Eppler";
            ComboBox.ThemeName = "Budget Execution";
            ComboBox.ToolTip = null;
            // 
            // SearchDialog
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 569, 79 );
            Controls.Add( ComboBox );
            Controls.Add( TextBox );
            Controls.Add( DomainLabel );
            Controls.Add( KeyWordLabel );
            Controls.Add( ControlTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 581, 90 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 581, 90 );
            Name = "SearchDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.Manual;
            ButtonTable.ResumeLayout( false );
            ControlTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public ToolTip ToolTip;
        public Label Label;
        public BindingSource BindingSource;
        public System.Windows.Forms.Button LookupButton;
        public System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public TableLayoutPanel ButtonTable;
        public TableLayoutPanel ControlTable;
        public Label KeyWordLabel;
        public Label DomainLabel;
        public TextBox TextBox;
        public ComboBox ComboBox;
    }

}
