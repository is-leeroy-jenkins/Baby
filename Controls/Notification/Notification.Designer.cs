namespace BudgetBrowser
{
    using System.Windows.Forms;

    partial class Notification
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
            NotifyIcon = new PictureBox( );
            Timer = new Timer( components );
            Message = new Label( );
            Title = new Label( );
            ( (System.ComponentModel.ISupportInitialize) NotifyIcon  ).BeginInit( );
            SuspendLayout( );
            // 
            // NotifyIcon
            // 
            NotifyIcon.BackColor = System.Drawing.Color.Transparent;
            NotifyIcon.Image = Properties.Resources.Budget_Browser;
            NotifyIcon.Location = new System.Drawing.Point( 4, 4 );
            NotifyIcon.Name = "NotifyIcon";
            NotifyIcon.Size = new System.Drawing.Size( 24, 37 );
            NotifyIcon.SizeMode = PictureBoxSizeMode.Zoom;
            NotifyIcon.TabIndex = 2;
            NotifyIcon.TabStop = false;
            // 
            // Message
            // 
            Message.FlatStyle = FlatStyle.Flat;
            Message.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Location = new System.Drawing.Point( 49, 48 );
            Message.Margin = new Padding( 3 );
            Message.Name = "Message";
            Message.Padding = new Padding( 1 );
            Message.Size = new System.Drawing.Size( 310, 103 );
            Message.Style = MetroSet_UI.Enums.Style.Custom;
            Message.StyleManager = null;
            Message.TabIndex = 4;
            Message.Text = "label1";
            Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Message.ThemeAuthor = "Terry D. Eppler";
            Message.ThemeName = "Budget Browser";
            Message.ToolTip = null;
            // 
            // Title
            // 
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 49, 4 );
            Title.Margin = new Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new Padding( 1 );
            Title.Size = new System.Drawing.Size( 211, 25 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 5;
            Title.Text = "label1";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Browser";
            Title.ToolTip = null;
            // 
            // Notification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            BorderColor = System.Drawing.SystemColors.MenuHighlight;
            CaptionBarColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            CaptionBarHeight = 3;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            CaptionFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            ClientSize = new System.Drawing.Size( 401, 189 );
            ControlBox = false;
            Controls.Add( Title );
            Controls.Add( Message );
            Controls.Add( NotifyIcon );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new System.Drawing.Size( 460, 189 );
            MetroColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            Name = "Notification";
            Padding = new Padding( 1 );
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Notification";
            TopMost = true;
            ( (System.ComponentModel.ISupportInitialize) NotifyIcon  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public PictureBox NotifyIcon;
        public Timer Timer;
        public Label Message;
        public Label Title;
    }
}