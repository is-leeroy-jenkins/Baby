
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
            KeyWordTextBox = new RichTextBox( );
            LookupButton = new System.Windows.Forms.Button( );
            RefreshButton = new System.Windows.Forms.Button( );
            CloseButton = new System.Windows.Forms.Button( );
            ComboBox = new MetroSet_UI.Controls.MetroSetComboBox( );
            ButtonTable = new TableLayoutPanel( );
            ControlTable = new TableLayoutPanel( );
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
            // KeyWordTextBox
            // 
            KeyWordTextBox.AutoWordSelection = false;
            KeyWordTextBox.BorderColor = System.Drawing.Color.FromArgb( 110, 110, 110 );
            KeyWordTextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            KeyWordTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            KeyWordTextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            KeyWordTextBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            KeyWordTextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            KeyWordTextBox.HoverText = null;
            KeyWordTextBox.IsDerivedStyle = true;
            KeyWordTextBox.Lines = null;
            KeyWordTextBox.Location = new System.Drawing.Point( 2, 3 );
            KeyWordTextBox.MaxLength = 32767;
            KeyWordTextBox.Name = "KeyWordTextBox";
            KeyWordTextBox.Padding = new Padding( 1 );
            KeyWordTextBox.ReadOnly = false;
            KeyWordTextBox.Size = new System.Drawing.Size( 487, 67 );
            KeyWordTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            KeyWordTextBox.StyleManager = null;
            KeyWordTextBox.TabIndex = 0;
            KeyWordTextBox.ThemeAuthor = "Terry D. Eppler";
            KeyWordTextBox.ThemeName = "Baby";
            KeyWordTextBox.ToolTip = ToolTip;
            KeyWordTextBox.WordWrap = true;
            // 
            // LookupButton
            // 
            LookupButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            LookupButton.Dock = DockStyle.Fill;
            LookupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            LookupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            LookupButton.FlatStyle = FlatStyle.Flat;
            LookupButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            LookupButton.Image = Properties.Resources.SearchPanelLookUpButton;
            LookupButton.Location = new System.Drawing.Point( 1, 1 );
            LookupButton.Margin = new Padding( 1 );
            LookupButton.Name = "LookupButton";
            LookupButton.Padding = new Padding( 5 );
            LookupButton.Size = new System.Drawing.Size( 48, 32 );
            LookupButton.TabIndex = 9;
            LookupButton.UseVisualStyleBackColor = false;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            RefreshButton.Dock = DockStyle.Fill;
            RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            RefreshButton.Image = Properties.Resources.SearchRefreshButton;
            RefreshButton.Location = new System.Drawing.Point( 51, 1 );
            RefreshButton.Margin = new Padding( 1 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new Padding( 5 );
            RefreshButton.Size = new System.Drawing.Size( 43, 32 );
            RefreshButton.TabIndex = 1;
            RefreshButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CloseButton.Dock = DockStyle.Fill;
            CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CloseButton.Image = Properties.Resources.SearchCancelButton;
            CloseButton.Location = new System.Drawing.Point( 96, 1 );
            CloseButton.Margin = new Padding( 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new Padding( 5 );
            CloseButton.Size = new System.Drawing.Size( 46, 32 );
            CloseButton.TabIndex = 3;
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // ComboBox
            // 
            ComboBox.AllowDrop = true;
            ComboBox.ArrowColor = System.Drawing.Color.FromArgb( 110, 110, 110 );
            ComboBox.BackColor = System.Drawing.Color.Transparent;
            ComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 34, 34, 34 );
            ComboBox.BorderColor = System.Drawing.Color.FromArgb( 110, 110, 110 );
            ComboBox.CausesValidation = false;
            ComboBox.DisabledBackColor = System.Drawing.Color.FromArgb( 80, 80, 80 );
            ComboBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 109, 109, 109 );
            ComboBox.DisabledForeColor = System.Drawing.Color.FromArgb( 109, 109, 109 );
            ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox.FlatStyle = FlatStyle.Flat;
            ComboBox.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ComboBox.FormattingEnabled = true;
            ComboBox.IsDerivedStyle = true;
            ComboBox.ItemHeight = 20;
            ComboBox.Items.AddRange( new object[ ] { "Google", "EPA", "CRS", "LOC", "GPO", "GovInfo", "OMB", "Treasury", "NASA", "NOAA" } );
            ComboBox.Location = new System.Drawing.Point( 505, 44 );
            ComboBox.Name = "ComboBox";
            ComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 65, 177, 225 );
            ComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            ComboBox.Size = new System.Drawing.Size( 143, 26 );
            ComboBox.Style = MetroSet_UI.Enums.Style.Dark;
            ComboBox.StyleManager = null;
            ComboBox.TabIndex = 10;
            ComboBox.ThemeAuthor = "Narwin";
            ComboBox.ThemeName = "MetroDark";
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
            ButtonTable.Size = new System.Drawing.Size( 143, 34 );
            ButtonTable.TabIndex = 11;
            // 
            // ControlTable
            // 
            ControlTable.ColumnCount = 1;
            ControlTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            ControlTable.Controls.Add( ButtonTable, 0, 0 );
            ControlTable.Location = new System.Drawing.Point( 505, 0 );
            ControlTable.Margin = new Padding( 1 );
            ControlTable.Name = "ControlTable";
            ControlTable.RowCount = 1;
            ControlTable.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            ControlTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            ControlTable.Size = new System.Drawing.Size( 149, 40 );
            ControlTable.TabIndex = 12;
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
            Controls.Add( ControlTable );
            Controls.Add( ComboBox );
            Controls.Add( KeyWordTextBox );
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
        public System.Windows.Forms.Button LookupButton;
        public System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.Button RefreshButton;
        public RichTextBox KeyWordTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public TableLayoutPanel ButtonTable;
        public TableLayoutPanel ControlTable;
        public MetroSet_UI.Controls.MetroSetComboBox ComboBox;
    }

}
