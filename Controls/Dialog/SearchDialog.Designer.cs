
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
            KeyWordTextBox.BorderColor = System.Drawing.Color.FromArgb( 90, 90, 90 );
            KeyWordTextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
            KeyWordTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
            KeyWordTextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 136, 136, 136 );
            KeyWordTextBox.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            KeyWordTextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            KeyWordTextBox.HoverText = null;
            KeyWordTextBox.IsDerivedStyle = true;
            KeyWordTextBox.Lines = null;
            KeyWordTextBox.Location = new System.Drawing.Point( 45, 10 );
            KeyWordTextBox.MaxLength = 32767;
            KeyWordTextBox.Name = "KeyWordTextBox";
            KeyWordTextBox.Padding = new Padding( 1 );
            KeyWordTextBox.ReadOnly = false;
            KeyWordTextBox.Size = new System.Drawing.Size( 637, 33 );
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
            LookupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            LookupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            LookupButton.FlatStyle = FlatStyle.Flat;
            LookupButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            LookupButton.Image = Properties.Resources.SearchPanelLookUpButton;
            LookupButton.Location = new System.Drawing.Point( 688, 3 );
            LookupButton.Name = "LookupButton";
            LookupButton.Size = new System.Drawing.Size( 36, 40 );
            LookupButton.TabIndex = 9;
            LookupButton.UseVisualStyleBackColor = false;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            RefreshButton.Image = Properties.Resources.SearchRefreshButton;
            RefreshButton.Location = new System.Drawing.Point( 3, 3 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new System.Drawing.Size( 36, 40 );
            RefreshButton.TabIndex = 1;
            RefreshButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CloseButton.Image = Properties.Resources.SearchCancelButton;
            CloseButton.Location = new System.Drawing.Point( 730, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new System.Drawing.Size( 36, 40 );
            CloseButton.TabIndex = 3;
            CloseButton.UseVisualStyleBackColor = false;
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
            ClientSize = new System.Drawing.Size( 771, 51 );
            Controls.Add( LookupButton );
            Controls.Add( RefreshButton );
            Controls.Add( KeyWordTextBox );
            Controls.Add( CloseButton );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightSteelBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 783, 62 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 783, 62 );
            Name = "SearchDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
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
    }

}
