namespace Baby
{
    using Syncfusion.Windows.Forms;
    public partial class SplashMessage : MetroForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( SplashMessage ) );
            Timer = new System.Windows.Forms.Timer( components );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            Title = new Label( );
            PictureBox = new ImageBox( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            CloseButton = new Button( );
            Message = new RichTextBox( );
            BackPanel = new Layout( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ButtonTable.SuspendLayout( );
            BackPanel.SuspendLayout( );
            SuspendLayout( );
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 2;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 5.394191F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 94.60581F ) );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 723, 24 );
            HeaderTable.TabIndex = 0;
            // 
            // Title
            // 
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 42, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 678, 18 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 0;
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Baby";
            Title.ToolTip = null;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.ErrorImage = null;
            PictureBox.Image = (System.Drawing.Image)resources.GetObject( "PictureBox.Image" );
            PictureBox.Location = new System.Drawing.Point( 1, 1 );
            PictureBox.Margin = new System.Windows.Forms.Padding( 1 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 20, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 5;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 43.88489F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 56.11511F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 130F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 166F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 127F ) );
            ButtonTable.Controls.Add( CloseButton, 4, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 0, 329 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ButtonTable.Size = new System.Drawing.Size( 723, 30 );
            ButtonTable.TabIndex = 1;
            // 
            // CloseButton
            // 
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 224, 224, 224 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 598, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.Transparent;
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 24 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Baby";
            CloseButton.ToolTip = null;
            // 
            // Message
            // 
            Message.AutoWordSelection = false;
            Message.BorderColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            Message.DisabledBackColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            Message.DisabledBorderColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            Message.DisabledForeColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            Message.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Message.HoverColor = System.Drawing.Color.White;
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Lines = null;
            Message.Location = new System.Drawing.Point( 73, 26 );
            Message.MaxLength = 32767;
            Message.Name = "Message";
            Message.Padding = new System.Windows.Forms.Padding( 1 );
            Message.ReadOnly = false;
            Message.Size = new System.Drawing.Size( 600, 240 );
            Message.Style = MetroSet_UI.Enums.Style.Custom;
            Message.StyleManager = null;
            Message.TabIndex = 0;
            Message.Text = "richTextBox1";
            Message.ThemeAuthor = "Terry D. Eppler";
            Message.ThemeName = "Baby";
            Message.ToolTip = null;
            Message.WordWrap = true;
            // 
            // BackPanel
            // 
            BackPanel.BackColor = System.Drawing.Color.Transparent;
            BackPanel.BackgroundColor = System.Drawing.Color.Transparent;
            BackPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            BackPanel.BorderThickness = 1;
            BackPanel.Children = null;
            BackPanel.Controls.Add( Message );
            BackPanel.DataFilter = null;
            BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            BackPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BackPanel.ForeColor = System.Drawing.Color.Transparent;
            BackPanel.HoverText = null;
            BackPanel.IsDerivedStyle = true;
            BackPanel.Location = new System.Drawing.Point( 0, 24 );
            BackPanel.Margin = new System.Windows.Forms.Padding( 1 );
            BackPanel.Name = "BackPanel";
            BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
            BackPanel.Size = new System.Drawing.Size( 723, 305 );
            BackPanel.Style = MetroSet_UI.Enums.Style.Custom;
            BackPanel.StyleManager = null;
            BackPanel.TabIndex = 2;
            BackPanel.ThemeAuthor = "Terry D. Eppler";
            BackPanel.ThemeName = "Baby";
            BackPanel.ToolTip = null;
            // 
            // SplashMessage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            BorderColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 723, 359 );
            ControlBox = false;
            Controls.Add( BackPanel );
            Controls.Add( ButtonTable );
            Controls.Add( HeaderTable );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 735, 371 );
            MetroColor = System.Drawing.Color.FromArgb( 1, 35, 54 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 735, 371 );
            Name = "SplashMessage";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ButtonTable.ResumeLayout( false );
            BackPanel.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public System.Windows.Forms.Timer Timer;
        public Layout BackPanel;
        protected System.Windows.Forms.TableLayoutPanel HeaderTable;
        public Label Title;
        public ImageBox PictureBox;
        protected System.Windows.Forms.TableLayoutPanel ButtonTable;
        private Button CloseButton;
        public RichTextBox Message;
    }
}