namespace Baby
{
    using Syncfusion.Windows.Forms;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using static Animator;

    partial class Notification : MetroForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( Notification ) );
            PictureBox = new ImageBox( );
            Timer = new Timer( components );
            Title = new Label( );
            Message = new Label( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            SuspendLayout( );
            // 
            // PictureBox
            // 
            PictureBox.BackColor = Color.Transparent;
            PictureBox.Image = (Image)resources.GetObject( "PictureBox.Image" );
            PictureBox.Location = new Point( 2, 2 );
            PictureBox.Margin = new Padding( 1 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new Padding( 1 );
            PictureBox.Size = new Size( 20, 20 );
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 2;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new Font( "Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new Point( 60, 4 );
            Title.Margin = new Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new Padding( 1 );
            Title.Size = new Size( 292, 23 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 3;
            Title.Text = "label1";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Baby";
            Title.ToolTip = null;
            // 
            // Message
            // 
            Message.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            Message.FlatStyle = FlatStyle.Flat;
            Message.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Location = new Point( 60, 43 );
            Message.Margin = new Padding( 3 );
            Message.Name = "Message";
            Message.Padding = new Padding( 1 );
            Message.Size = new Size( 339, 99 );
            Message.Style = MetroSet_UI.Enums.Style.Custom;
            Message.StyleManager = null;
            Message.TabIndex = 4;
            Message.Text = "label2";
            Message.TextAlign = ContentAlignment.MiddleLeft;
            Message.ThemeAuthor = "Terry D. Eppler";
            Message.ThemeName = "Baby";
            Message.ToolTip = null;
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb( 1, 35, 54 );
            BorderColor = Color.FromArgb( 106, 189, 252 );
            CaptionBarColor = Color.FromArgb( 1, 35, 54 );
            CaptionBarHeight = 3;
            CaptionButtonColor = Color.FromArgb( 1, 35, 54 );
            CaptionButtonHoverColor = Color.FromArgb( 1, 35, 54 );
            CaptionFont = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            CaptionForeColor = Color.FromArgb( 1, 35, 54 );
            ClientSize = new Size( 448, 177 );
            ControlBox = false;
            Controls.Add( Message );
            Controls.Add( Title );
            Controls.Add( PictureBox );
            Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject( "$this.Icon" );
            MaximumSize = new Size( 460, 189 );
            MetroColor = Color.FromArgb( 1, 35, 54 );
            MinimizeBox = false;
            MinimumSize = new Size( 460, 189 );
            Name = "Notification";
            Padding = new Padding( 1 );
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public ImageBox PictureBox;
        public System.Windows.Forms.Timer Timer;
        public Label Message;
        public Label Title;
    }
}