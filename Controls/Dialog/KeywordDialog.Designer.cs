#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace BudgetBrowser
{
    
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    public partial class KeywordDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <dict name="disposing">true if managed resources should be disposed; otherwise, false.</dict>
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
            var captionImage1 = new Syncfusion.Windows.Forms.CaptionImage( );
            var resources = new ComponentResourceManager( typeof( KeywordDialog ) );
            SearchPanel =  new Layout( );
            CloseButton =  new Button( ) ;
            SearchIcon =  new System.Windows.Forms.PictureBox( ) ;
            HeaderLabel =  new Label( ) ;
            SearchPanel.SuspendLayout( );
            ( (ISupportInitialize) SearchIcon  ).BeginInit( );
            SuspendLayout( );
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
            SearchPanel.ForeColor =  System.Drawing.Color.LightSteelBlue ;
            SearchPanel.Location =  new System.Drawing.Point( 12, 42 ) ;
            SearchPanel.Name =  "WebKeywordDialog" ;
            SearchPanel.Padding =  new Padding( 1 ) ;
            SearchPanel.Size =  new System.Drawing.Size( 214, 248 ) ;
            SearchPanel.TabIndex =  5 ;
            // 
            // CloseButton
            // 
            CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverText =  null ;
            CloseButton.HoverTextColor =  System.Drawing.Color.White ;
            CloseButton.IsDerivedStyle =  true ;
            CloseButton.Location =  new System.Drawing.Point( 153, 308 ) ;
            CloseButton.Name =  "CloseButton" ;
            CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.Padding =  new Padding( 1 ) ;
            CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressTextColor =  System.Drawing.Color.White ;
            CloseButton.Size =  new System.Drawing.Size( 72, 28 ) ;
            CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseButton.StyleManager =  null ;
            CloseButton.TabIndex =  6 ;
            CloseButton.Text =  "Close" ;
            CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
            CloseButton.ThemeName =  "Budget Browser" ;
            CloseButton.ToolTip =  null ;
            // 
            // SearchIcon
            // 
            SearchIcon.BackColor =  System.Drawing.Color.Transparent ;
            SearchIcon.Location =  new System.Drawing.Point( 0, 5 ) ;
            SearchIcon.Padding =  new Padding( 1 ) ;
            SearchIcon.Size =  new System.Drawing.Size( 22, 24 ) ;
            SearchIcon.SizeMode =  PictureBoxSizeMode.StretchImage ;
            SearchIcon.TabIndex =  7 ;
            SearchIcon.TabStop =  false ;
            // 
            // HeaderLabel
            // 
            HeaderLabel.FlatStyle =  FlatStyle.Flat ;
            HeaderLabel.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            HeaderLabel.HoverText =  null ;
            HeaderLabel.IsDerivedStyle =  true ;
            HeaderLabel.Location =  new System.Drawing.Point( 28, 5 ) ;
            HeaderLabel.Margin =  new Padding( 3 ) ;
            HeaderLabel.Name =  "HeaderLabel" ;
            HeaderLabel.Padding =  new Padding( 1 ) ;
            HeaderLabel.Size =  new System.Drawing.Size( 184, 23 ) ;
            HeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            HeaderLabel.StyleManager =  null ;
            HeaderLabel.TabIndex =  8 ;
            HeaderLabel.Text =  "Data Column Configuration" ;
            HeaderLabel.TextAlign =  System.Drawing.ContentAlignment.MiddleLeft ;
            HeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            HeaderLabel.ThemeName =  "Budget Browser" ;
            HeaderLabel.ToolTip =  null ;
            // 
            // WebKeyWordDialog
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   18  ,   18  ,   18   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            captionImage1.BackColor =  System.Drawing.Color.Transparent ;
            captionImage1.ForeColor =  System.Drawing.Color.FromArgb(   15  ,   15  ,   15   ) ;
            captionImage1.Location =  new System.Drawing.Point( 10, 5 ) ;
            captionImage1.Name =  "Image" ;
            captionImage1.Size =  new System.Drawing.Size( 16, 16 ) ;
            CaptionImages.Add( captionImage1 );
            ClientSize =  new System.Drawing.Size( 238, 339 ) ;
            Controls.Add( HeaderLabel );
            Controls.Add( SearchIcon );
            Controls.Add( CloseButton );
            Controls.Add( SearchPanel );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightSteelBlue ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximumSize =  new System.Drawing.Size( 250, 350 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimumSize =  new System.Drawing.Size( 250, 350 ) ;
            Name =  "WebKeywordDialog" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            StartPosition =  FormStartPosition.Manual ;
            Text =  "Quick Search" ;
            SearchPanel.ResumeLayout( false );
            ( (ISupportInitialize) SearchIcon  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        
        public Layout SearchPanel;
        public Button CloseButton;
        public System.Windows.Forms.PictureBox SearchIcon;
        private Label HeaderLabel;
    }

}