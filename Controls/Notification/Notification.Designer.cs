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
            Timer = new System.Windows.Forms.Timer( components );
            Title = new Label( );
            Message = new Label( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            SuspendLayout( );
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.Image = Properties.Resources.BabyBrowser;
            PictureBox.Location = new System.Drawing.Point( 4, 4 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 20, 20 );
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 2;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 60, 4 );
            Title.Margin = new Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new Padding( 1 );
            Title.Size = new System.Drawing.Size( 292, 23 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 3;
            Title.Text = "label1";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Baby";
            Title.ToolTip = null;
            // 
            // Message
            // 
            Message.Anchor =     AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right  ;
            Message.FlatStyle = FlatStyle.Flat;
            Message.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Location = new System.Drawing.Point( 60, 43 );
            Message.Margin = new Padding( 3 );
            Message.Name = "Message";
            Message.Padding = new Padding( 1 );
            Message.Size = new System.Drawing.Size( 339, 81 );
            Message.Style = MetroSet_UI.Enums.Style.Custom;
            Message.StyleManager = null;
            Message.TabIndex = 4;
            Message.Text = "label2";
            Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Message.ThemeAuthor = "Terry D. Eppler";
            Message.ThemeName = "Baby";
            Message.ToolTip = null;
            // 
            // Notification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            BorderColor = System.Drawing.Color.FromArgb(   106  ,   189  ,   252   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            CaptionBarHeight = 3;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            CaptionFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            ClientSize = new System.Drawing.Size( 448, 177 );
            ControlBox = false;
            Controls.Add( Message );
            Controls.Add( Title );
            Controls.Add( PictureBox );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.FromArgb(   106  ,   189  ,   252   );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximumSize = new System.Drawing.Size( 460, 189 );
            MetroColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 460, 189 );
            Name = "Notification";
            Padding = new Padding( 1 );
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public ImageBox PictureBox;
        public System.Windows.Forms.Timer Timer;
        public Label Message;
        public Label Title;
    }
}