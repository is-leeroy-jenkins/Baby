
namespace Baby
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    partial class MessageDialog
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
            components = new Container( );
            var resources = new ComponentResourceManager( typeof( MessageDialog ) );
            BindingSource = new BindingSource( components );
            ToolTip = new ToolTip( );
            CloseButton = new Button( );
            Label = new Label( );
            Picture = new PictureBox( );
            Header = new Label( );
            BackPanel = new Layout( );
            TextBox = new RichTextBox( );
            TitleTable = new TableLayoutPanel( );
            SelectButton = new Button( );
            CancelButton = new Button( );
            ( (ISupportInitialize)BindingSource ).BeginInit( );
            ( (ISupportInitialize)Picture ).BeginInit( );
            BackPanel.SuspendLayout( );
            TitleTable.SuspendLayout( );
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
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 580, 354 );
            CloseButton.Margin = new Padding( 0 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.Transparent;
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.Padding = new Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 78, 26 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 10;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Baby";
            CloseButton.ToolTip = ToolTip;
            // 
            // Label
            // 
            Label.Anchor =   AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            Label.FlatStyle = FlatStyle.Flat;
            Label.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Label.HoverText = null;
            Label.IsDerivedStyle = true;
            Label.Location = new System.Drawing.Point( 70, 48 );
            Label.Margin = new Padding( 3 );
            Label.Name = "Label";
            Label.Padding = new Padding( 1 );
            Label.Size = new System.Drawing.Size( 542, 23 );
            Label.Style = MetroSet_UI.Enums.Style.Custom;
            Label.StyleManager = null;
            Label.TabIndex = 12;
            Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Label.ThemeAuthor = "Terry D. Eppler";
            Label.ThemeName = "Baby";
            Label.ToolTip = null;
            // 
            // Picture
            // 
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.Image = Properties.Resources.BabyBrowser;
            Picture.Location = new System.Drawing.Point( 3, 3 );
            Picture.Name = "Picture";
            Picture.Padding = new Padding( 1 );
            Picture.Size = new System.Drawing.Size( 20, 18 );
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 13;
            Picture.TabStop = false;
            // 
            // Header
            // 
            Header.FlatStyle = FlatStyle.Flat;
            Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Header.HoverText = null;
            Header.IsDerivedStyle = true;
            Header.Location = new System.Drawing.Point( 43, 3 );
            Header.Margin = new Padding( 3 );
            Header.Name = "Header";
            Header.Padding = new Padding( 1 );
            Header.Size = new System.Drawing.Size( 586, 22 );
            Header.Style = MetroSet_UI.Enums.Style.Custom;
            Header.StyleManager = null;
            Header.TabIndex = 14;
            Header.Text = "Baby Message";
            Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            BackPanel.Controls.Add( TextBox );
            BackPanel.DataFilter = null;
            BackPanel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BackPanel.ForeColor = System.Drawing.Color.Transparent;
            BackPanel.HoverText = null;
            BackPanel.IsDerivedStyle = true;
            BackPanel.Location = new System.Drawing.Point( 43, 60 );
            BackPanel.Name = "BackPanel";
            BackPanel.Padding = new Padding( 1 );
            BackPanel.Size = new System.Drawing.Size( 615, 246 );
            BackPanel.Style = MetroSet_UI.Enums.Style.Custom;
            BackPanel.StyleManager = null;
            BackPanel.TabIndex = 15;
            BackPanel.ThemeAuthor = "Terry D. Eppler";
            BackPanel.ThemeName = "Baby";
            BackPanel.ToolTip = null;
            // 
            // TextBox
            // 
            TextBox.AutoWordSelection = false;
            TextBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            TextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TextBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TextBox.HoverText = null;
            TextBox.IsDerivedStyle = true;
            TextBox.Lines = null;
            TextBox.Location = new System.Drawing.Point( 33, 38 );
            TextBox.MaxLength = 32767;
            TextBox.Name = "TextBox";
            TextBox.Padding = new Padding( 1 );
            TextBox.ReadOnly = false;
            TextBox.Size = new System.Drawing.Size( 553, 168 );
            TextBox.Style = MetroSet_UI.Enums.Style.Custom;
            TextBox.StyleManager = null;
            TextBox.TabIndex = 0;
            TextBox.Text = " ";
            TextBox.ThemeAuthor = "Terry D. Eppler";
            TextBox.ThemeName = "Baby";
            TextBox.ToolTip = ToolTip;
            TextBox.WordWrap = true;
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
            // SelectButton
            // 
            SelectButton.BackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SelectButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            SelectButton.HoverText = null;
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 308, 354 );
            SelectButton.Margin = new Padding( 0 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.Transparent;
            SelectButton.NormalColor = System.Drawing.Color.Transparent;
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.Padding = new Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 78, 26 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 17;
            SelectButton.Text = "Ok";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Baby";
            SelectButton.ToolTip = ToolTip;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = System.Drawing.Color.Transparent;
            CancelButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CancelButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CancelButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CancelButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CancelButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CancelButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CancelButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CancelButton.HoverText = null;
            CancelButton.HoverTextColor = System.Drawing.Color.White;
            CancelButton.IsDerivedStyle = true;
            CancelButton.Location = new System.Drawing.Point( 43, 354 );
            CancelButton.Margin = new Padding( 0 );
            CancelButton.Name = "CancelButton";
            CancelButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CancelButton.NormalColor = System.Drawing.Color.Transparent;
            CancelButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CancelButton.Padding = new Padding( 1 );
            CancelButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CancelButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CancelButton.PressTextColor = System.Drawing.Color.White;
            CancelButton.Size = new System.Drawing.Size( 78, 26 );
            CancelButton.Style = MetroSet_UI.Enums.Style.Custom;
            CancelButton.StyleManager = null;
            CancelButton.TabIndex = 18;
            CancelButton.Text = "Cancel";
            CancelButton.ThemeAuthor = "Terry D. Eppler";
            CancelButton.ThemeName = "Baby";
            CancelButton.ToolTip = ToolTip;
            // 
            // MessageDialog
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
            ClientSize = new System.Drawing.Size( 688, 389 );
            Controls.Add( CancelButton );
            Controls.Add( SelectButton );
            Controls.Add( TitleTable );
            Controls.Add( BackPanel );
            Controls.Add( Label );
            Controls.Add( CloseButton );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightSteelBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 700, 400 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 700, 400 );
            Name = "MessageDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            ( (ISupportInitialize)BindingSource ).EndInit( );
            ( (ISupportInitialize)Picture ).EndInit( );
            BackPanel.ResumeLayout( false );
            TitleTable.ResumeLayout( false );
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
        public RichTextBox TextBox;
        public Button SelectButton;
        public Button CancelButton;
    }

}
