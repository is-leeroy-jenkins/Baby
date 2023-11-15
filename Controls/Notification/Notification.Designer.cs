namespace Baby
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
            PictureBox = new PictureBox( );
            Timer = new Timer( components );
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
            ClientSize = new System.Drawing.Size( 401, 177 );
            ControlBox = false;
            Controls.Add( PictureBox );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.FromArgb(   106  ,   189  ,   252   );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new System.Drawing.Size( 460, 189 );
            MetroColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            MinimizeBox = false;
            Name = "Notification";
            Padding = new Padding( 1 );
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public PictureBox PictureBox;
        public Timer Timer;
        public Label Message;
        public Label Title;
    }
}