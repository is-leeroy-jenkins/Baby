
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
            CloseButton = new Button( );
            Picture = new PictureBox( );
            Header = new Label( );
            BackPanel = new Layout( );
            KeyWordTextBox = new TextBox( );
            TitleTable = new TableLayoutPanel( );
            ClearButton = new Button( );
            OkayButton = new Button( );
            CancelButton = new Button( );
            ButtonTable = new TableLayoutPanel( );
            ( (ISupportInitialize)Picture ).BeginInit( );
            BackPanel.SuspendLayout( );
            TitleTable.SuspendLayout( );
            ButtonTable.SuspendLayout( );
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
            // CloseButton
            // 
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Dock = DockStyle.Fill;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 544, 1 );
            CloseButton.Margin = new Padding( 0 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.Transparent;
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.Padding = new Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 131, 36 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 10;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Baby";
            CloseButton.ToolTip = ToolTip;
            // 
            // Picture
            // 
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.Image = (System.Drawing.Image)resources.GetObject( "Picture.Image" );
            Picture.Location = new System.Drawing.Point( 3, 3 );
            Picture.Name = "Picture";
            Picture.Padding = new Padding( 1 );
            Picture.Size = new System.Drawing.Size( 20, 18 );
            Picture.SizeMode = PictureBoxSizeMode.Zoom;
            Picture.TabIndex = 13;
            Picture.TabStop = false;
            // 
            // Header
            // 
            Header.Dock = DockStyle.Fill;
            Header.FlatStyle = FlatStyle.Flat;
            Header.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Header.HoverText = null;
            Header.IsDerivedStyle = true;
            Header.Location = new System.Drawing.Point( 43, 3 );
            Header.Margin = new Padding( 3 );
            Header.Name = "Header";
            Header.Padding = new Padding( 1 );
            Header.Size = new System.Drawing.Size( 642, 22 );
            Header.Style = MetroSet_UI.Enums.Style.Custom;
            Header.StyleManager = null;
            Header.TabIndex = 14;
            Header.Text = "Web Search";
            Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Header.ThemeAuthor = "Terry D. Eppler";
            Header.ThemeName = "Baby";
            Header.ToolTip = null;
            // 
            // BackPanel
            // 
            BackPanel.BackColor = System.Drawing.Color.Transparent;
            BackPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BackPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            BackPanel.BorderThickness = 1;
            BackPanel.Children = null;
            BackPanel.Controls.Add( KeyWordTextBox );
            BackPanel.DataFilter = null;
            BackPanel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BackPanel.ForeColor = System.Drawing.Color.Transparent;
            BackPanel.HoverText = null;
            BackPanel.IsDerivedStyle = true;
            BackPanel.Location = new System.Drawing.Point( 12, 44 );
            BackPanel.Name = "BackPanel";
            BackPanel.Padding = new Padding( 1 );
            BackPanel.Size = new System.Drawing.Size( 664, 61 );
            BackPanel.Style = MetroSet_UI.Enums.Style.Custom;
            BackPanel.StyleManager = null;
            BackPanel.TabIndex = 15;
            BackPanel.ThemeAuthor = "Terry D. Eppler";
            BackPanel.ThemeName = "Baby";
            BackPanel.ToolTip = null;
            // 
            // KeyWordTextBox
            // 
            KeyWordTextBox.AutoCompleteCustomSource = null;
            KeyWordTextBox.AutoCompleteMode = AutoCompleteMode.None;
            KeyWordTextBox.AutoCompleteSource = AutoCompleteSource.None;
            KeyWordTextBox.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            KeyWordTextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
            KeyWordTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
            KeyWordTextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 136, 136, 136 );
            KeyWordTextBox.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            KeyWordTextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            KeyWordTextBox.HoverText = null;
            KeyWordTextBox.Image = null;
            KeyWordTextBox.IsDerivedStyle = true;
            KeyWordTextBox.Lines = null;
            KeyWordTextBox.Location = new System.Drawing.Point( 31, 18 );
            KeyWordTextBox.MaxLength = 32767;
            KeyWordTextBox.Multiline = false;
            KeyWordTextBox.Name = "KeyWordTextBox";
            KeyWordTextBox.ReadOnly = false;
            KeyWordTextBox.SelectionLength = 0;
            KeyWordTextBox.Size = new System.Drawing.Size( 608, 26 );
            KeyWordTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            KeyWordTextBox.StyleManager = null;
            KeyWordTextBox.TabIndex = 1;
            KeyWordTextBox.TextAlign = HorizontalAlignment.Center;
            KeyWordTextBox.ThemeAuthor = "Terry D. Eppler";
            KeyWordTextBox.ThemeName = "Baby";
            KeyWordTextBox.ToolTip = null;
            KeyWordTextBox.UseSystemPasswordChar = false;
            KeyWordTextBox.WatermarkText = "";
            // 
            // TitleTable
            // 
            TitleTable.ColumnCount = 2;
            TitleTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.900621F ) );
            TitleTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 94.09938F ) );
            TitleTable.Controls.Add( Picture, 0, 0 );
            TitleTable.Controls.Add( Header, 1, 0 );
            TitleTable.Dock = DockStyle.Top;
            TitleTable.Location = new System.Drawing.Point( 0, 0 );
            TitleTable.Name = "TitleTable";
            TitleTable.RowCount = 1;
            TitleTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            TitleTable.Size = new System.Drawing.Size( 688, 28 );
            TitleTable.TabIndex = 16;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ClearButton.Dock = DockStyle.Fill;
            ClearButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ClearButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ClearButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            ClearButton.HoverText = "Clear Text";
            ClearButton.HoverTextColor = System.Drawing.Color.White;
            ClearButton.IsDerivedStyle = true;
            ClearButton.Location = new System.Drawing.Point( 29, 1 );
            ClearButton.Margin = new Padding( 0 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.Transparent;
            ClearButton.NormalColor = System.Drawing.Color.Transparent;
            ClearButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.Padding = new Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 110, 36 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 17;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "Baby";
            ClearButton.ToolTip = ToolTip;
            // 
            // OkayButton
            // 
            OkayButton.BackColor = System.Drawing.Color.Transparent;
            OkayButton.DisabledBackColor = System.Drawing.Color.Transparent;
            OkayButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            OkayButton.DisabledForeColor = System.Drawing.Color.Transparent;
            OkayButton.Dock = DockStyle.Fill;
            OkayButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            OkayButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            OkayButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            OkayButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            OkayButton.HoverText = "Begin SaveAs";
            OkayButton.HoverTextColor = System.Drawing.Color.White;
            OkayButton.IsDerivedStyle = true;
            OkayButton.Location = new System.Drawing.Point( 372, 1 );
            OkayButton.Margin = new Padding( 0 );
            OkayButton.Name = "OkayButton";
            OkayButton.NormalBorderColor = System.Drawing.Color.Transparent;
            OkayButton.NormalColor = System.Drawing.Color.Transparent;
            OkayButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            OkayButton.Padding = new Padding( 1 );
            OkayButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            OkayButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            OkayButton.PressTextColor = System.Drawing.Color.White;
            OkayButton.Size = new System.Drawing.Size( 117, 36 );
            OkayButton.Style = MetroSet_UI.Enums.Style.Custom;
            OkayButton.StyleManager = null;
            OkayButton.TabIndex = 18;
            OkayButton.Text = "Okay";
            OkayButton.ThemeAuthor = "Terry D. Eppler";
            OkayButton.ThemeName = "Baby";
            OkayButton.ToolTip = ToolTip;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = System.Drawing.Color.Transparent;
            CancelButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CancelButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CancelButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CancelButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CancelButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CancelButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CancelButton.HoverText = "Cancel SaveAs";
            CancelButton.HoverTextColor = System.Drawing.Color.White;
            CancelButton.IsDerivedStyle = true;
            CancelButton.Location = new System.Drawing.Point( 187, 1 );
            CancelButton.Margin = new Padding( 0 );
            CancelButton.Name = "CancelButton";
            CancelButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CancelButton.NormalColor = System.Drawing.Color.Transparent;
            CancelButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CancelButton.Padding = new Padding( 1 );
            CancelButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CancelButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CancelButton.PressTextColor = System.Drawing.Color.White;
            CancelButton.Size = new System.Drawing.Size( 132, 36 );
            CancelButton.Style = MetroSet_UI.Enums.Style.Custom;
            CancelButton.StyleManager = null;
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Cancel";
            CancelButton.ThemeAuthor = "Terry D. Eppler";
            CancelButton.ThemeName = "Baby";
            CancelButton.ToolTip = ToolTip;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 9;
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 20.4641342F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 79.5358658F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 48F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 132F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 53F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 117F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 55F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 131F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 11F ) );
            ButtonTable.Controls.Add( CancelButton, 3, 0 );
            ButtonTable.Controls.Add( ClearButton, 1, 0 );
            ButtonTable.Controls.Add( OkayButton, 5, 0 );
            ButtonTable.Controls.Add( CloseButton, 7, 0 );
            ButtonTable.Dock = DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 0, 111 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.Padding = new Padding( 1 );
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            ButtonTable.Size = new System.Drawing.Size( 688, 38 );
            ButtonTable.TabIndex = 20;
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
            CaptionForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClientSize = new System.Drawing.Size( 688, 149 );
            Controls.Add( ButtonTable );
            Controls.Add( TitleTable );
            Controls.Add( BackPanel );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightSteelBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 700, 160 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 700, 160 );
            Name = "SearchDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            ( (ISupportInitialize)Picture ).EndInit( );
            BackPanel.ResumeLayout( false );
            TitleTable.ResumeLayout( false );
            ButtonTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public ToolTip ToolTip;
        public Button CloseButton;
        public Label Label;
        public PictureBox Picture;
        public Label Header;
        public BindingSource BindingSource;
        public TableLayoutPanel TitleTable;
        public Layout BackPanel;
        public Button ClearButton;
        public Button OkayButton;
        public Button CancelButton;
        public TableLayoutPanel ButtonTable;
        public TextBox KeyWordTextBox;
    }

}
