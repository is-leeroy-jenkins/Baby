
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
            DialogLookupButton = new System.Windows.Forms.Button( );
            DialogRefreshButton = new System.Windows.Forms.Button( );
            DialogCloseButton = new System.Windows.Forms.Button( );
            DialogDomainComboBox = new MetroSet_UI.Controls.MetroSetComboBox( );
            ButtonTable = new TableLayoutPanel( );
            ControlTable = new TableLayoutPanel( );
            DialogKeyWordTextBox = new System.Windows.Forms.RichTextBox( );
            KeyWordLabel = new Label( );
            DomainLabel = new Label( );
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
            // DialogLookupButton
            // 
            DialogLookupButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DialogLookupButton.DialogResult = DialogResult.OK;
            DialogLookupButton.Dock = DockStyle.Fill;
            DialogLookupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            DialogLookupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 18, 79, 17 );
            DialogLookupButton.FlatStyle = FlatStyle.Flat;
            DialogLookupButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DialogLookupButton.Image = Properties.Resources.SearchPanelLookUpButton;
            DialogLookupButton.Location = new System.Drawing.Point( 1, 1 );
            DialogLookupButton.Margin = new Padding( 1 );
            DialogLookupButton.Name = "DialogLookupButton";
            DialogLookupButton.Padding = new Padding( 5 );
            DialogLookupButton.Size = new System.Drawing.Size( 39, 29 );
            DialogLookupButton.TabIndex = 9;
            DialogLookupButton.Tag = "Begin Search";
            DialogLookupButton.UseVisualStyleBackColor = false;
            // 
            // DialogRefreshButton
            // 
            DialogRefreshButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DialogRefreshButton.DialogResult = DialogResult.Ignore;
            DialogRefreshButton.Dock = DockStyle.Fill;
            DialogRefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            DialogRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            DialogRefreshButton.FlatStyle = FlatStyle.Flat;
            DialogRefreshButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DialogRefreshButton.Image = Properties.Resources.SearchRefreshButton;
            DialogRefreshButton.Location = new System.Drawing.Point( 42, 1 );
            DialogRefreshButton.Margin = new Padding( 1 );
            DialogRefreshButton.Name = "DialogRefreshButton";
            DialogRefreshButton.Padding = new Padding( 5 );
            DialogRefreshButton.Size = new System.Drawing.Size( 35, 29 );
            DialogRefreshButton.TabIndex = 1;
            DialogRefreshButton.Tag = "Clear Search";
            DialogRefreshButton.UseVisualStyleBackColor = false;
            // 
            // DialogCloseButton
            // 
            DialogCloseButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DialogCloseButton.DialogResult = DialogResult.Cancel;
            DialogCloseButton.Dock = DockStyle.Fill;
            DialogCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            DialogCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            DialogCloseButton.FlatStyle = FlatStyle.Flat;
            DialogCloseButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DialogCloseButton.Image = Properties.Resources.SearchCancelButton;
            DialogCloseButton.Location = new System.Drawing.Point( 79, 1 );
            DialogCloseButton.Margin = new Padding( 1 );
            DialogCloseButton.Name = "DialogCloseButton";
            DialogCloseButton.Padding = new Padding( 5 );
            DialogCloseButton.Size = new System.Drawing.Size( 46, 29 );
            DialogCloseButton.TabIndex = 3;
            DialogCloseButton.Tag = "Cancel Search";
            DialogCloseButton.UseVisualStyleBackColor = false;
            // 
            // DialogDomainComboBox
            // 
            DialogDomainComboBox.AllowDrop = true;
            DialogDomainComboBox.ArrowColor = System.Drawing.Color.FromArgb( 110, 110, 110 );
            DialogDomainComboBox.BackColor = System.Drawing.Color.Transparent;
            DialogDomainComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 34, 34, 34 );
            DialogDomainComboBox.BorderColor = System.Drawing.Color.FromArgb( 110, 110, 110 );
            DialogDomainComboBox.CausesValidation = false;
            DialogDomainComboBox.DisabledBackColor = System.Drawing.Color.FromArgb( 80, 80, 80 );
            DialogDomainComboBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 109, 109, 109 );
            DialogDomainComboBox.DisabledForeColor = System.Drawing.Color.FromArgb( 109, 109, 109 );
            DialogDomainComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            DialogDomainComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DialogDomainComboBox.FlatStyle = FlatStyle.Flat;
            DialogDomainComboBox.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DialogDomainComboBox.FormattingEnabled = true;
            DialogDomainComboBox.IsDerivedStyle = true;
            DialogDomainComboBox.ItemHeight = 20;
            DialogDomainComboBox.Items.AddRange( new object[ ] { "Google", "EPA ", "DATA  ", "GPO ", "USGI ", "CRS ", "LOC ", "OMB ", "UST ", "NASA ", "NOAA ", "DOI ", "NPS ", "GSA ", "NARA ", "DOC", "HHS", "NRC", "DOE", "NSF", "USDA", "CSB", "IRS", "FDA", "CDC", "ACE", "DHS", "DOD", "USNO", "NWS" } );
            DialogDomainComboBox.Location = new System.Drawing.Point( 433, 41 );
            DialogDomainComboBox.Name = "DialogDomainComboBox";
            DialogDomainComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 65, 177, 225 );
            DialogDomainComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            DialogDomainComboBox.Size = new System.Drawing.Size( 132, 26 );
            DialogDomainComboBox.Style = MetroSet_UI.Enums.Style.Dark;
            DialogDomainComboBox.StyleManager = null;
            DialogDomainComboBox.TabIndex = 10;
            DialogDomainComboBox.ThemeAuthor = "Narwin";
            DialogDomainComboBox.ThemeName = "MetroDark";
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 3;
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 52.63158F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 47.36842F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 47F ) );
            ButtonTable.Controls.Add( DialogLookupButton, 0, 0 );
            ButtonTable.Controls.Add( DialogRefreshButton, 1, 0 );
            ButtonTable.Controls.Add( DialogCloseButton, 2, 0 );
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
            // DialogKeyWordTextBox
            // 
            DialogKeyWordTextBox.BackColor = System.Drawing.Color.FromArgb( 34, 34, 34 );
            DialogKeyWordTextBox.BorderStyle = BorderStyle.None;
            DialogKeyWordTextBox.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DialogKeyWordTextBox.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DialogKeyWordTextBox.Location = new System.Drawing.Point( 12, 41 );
            DialogKeyWordTextBox.Name = "DialogKeyWordTextBox";
            DialogKeyWordTextBox.Size = new System.Drawing.Size( 397, 26 );
            DialogKeyWordTextBox.TabIndex = 13;
            DialogKeyWordTextBox.Text = "";
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
            CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 569, 79 );
            Controls.Add( DomainLabel );
            Controls.Add( KeyWordLabel );
            Controls.Add( DialogKeyWordTextBox );
            Controls.Add( ControlTable );
            Controls.Add( DialogDomainComboBox );
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
        public System.Windows.Forms.Button DialogLookupButton;
        public System.Windows.Forms.Button DialogCloseButton;
        public System.Windows.Forms.Button DialogRefreshButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public TableLayoutPanel ButtonTable;
        public TableLayoutPanel ControlTable;
        public MetroSet_UI.Controls.MetroSetComboBox DialogDomainComboBox;
        public System.Windows.Forms.RichTextBox DialogKeyWordTextBox;
        public Label KeyWordLabel;
        public Label DomainLabel;
    }

}
