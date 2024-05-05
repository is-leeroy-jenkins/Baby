
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
            DialogLookupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            DialogLookupButton.FlatStyle = FlatStyle.Flat;
            DialogLookupButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DialogLookupButton.Image = Properties.Resources.SearchPanelLookUpButton;
            DialogLookupButton.Location = new System.Drawing.Point( 1, 1 );
            DialogLookupButton.Margin = new Padding( 1 );
            DialogLookupButton.Name = "DialogLookupButton";
            DialogLookupButton.Padding = new Padding( 5 );
            DialogLookupButton.Size = new System.Drawing.Size( 39, 32 );
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
            DialogRefreshButton.Size = new System.Drawing.Size( 35, 32 );
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
            DialogCloseButton.Size = new System.Drawing.Size( 46, 32 );
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
            DialogDomainComboBox.Items.AddRange( new object[ ] { "Google", "EPA", "CRS", "LOC", "GPO", "GovInfo", "OMB", "Treasury", "NASA", "NOAA" } );
            DialogDomainComboBox.Location = new System.Drawing.Point( 522, 44 );
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
            ButtonTable.Size = new System.Drawing.Size( 126, 34 );
            ButtonTable.TabIndex = 11;
            // 
            // ControlTable
            // 
            ControlTable.ColumnCount = 1;
            ControlTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            ControlTable.Controls.Add( ButtonTable, 0, 0 );
            ControlTable.Location = new System.Drawing.Point( 522, 0 );
            ControlTable.Margin = new Padding( 1 );
            ControlTable.Name = "ControlTable";
            ControlTable.RowCount = 1;
            ControlTable.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            ControlTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            ControlTable.Size = new System.Drawing.Size( 132, 40 );
            ControlTable.TabIndex = 12;
            // 
            // DialogKeyWordTextBox
            // 
            DialogKeyWordTextBox.BackColor = System.Drawing.Color.FromArgb( 34, 34, 34 );
            DialogKeyWordTextBox.BorderStyle = BorderStyle.None;
            DialogKeyWordTextBox.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DialogKeyWordTextBox.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DialogKeyWordTextBox.Location = new System.Drawing.Point( 5, 4 );
            DialogKeyWordTextBox.Name = "DialogKeyWordTextBox";
            DialogKeyWordTextBox.Size = new System.Drawing.Size( 496, 66 );
            DialogKeyWordTextBox.TabIndex = 13;
            DialogKeyWordTextBox.Text = "";
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
            ClientSize = new System.Drawing.Size( 655, 73 );
            Controls.Add( DialogKeyWordTextBox );
            Controls.Add( ControlTable );
            Controls.Add( DialogDomainComboBox );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 667, 84 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 667, 84 );
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
    }

}
