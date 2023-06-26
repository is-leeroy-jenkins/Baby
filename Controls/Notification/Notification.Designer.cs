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
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.NotifyIcon = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer();
            this.Message = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.NotifyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BackColor = System.Drawing.Color.Transparent;
            this.NotifyIcon.Image = ((System.Drawing.Image)(resources.GetObject("NotifyIcon.Image")));
            this.NotifyIcon.Location = new System.Drawing.Point(4, 4);
            this.NotifyIcon.Name = "NotifyIcon";
            this.NotifyIcon.Size = new System.Drawing.Size(24, 37);
            this.NotifyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotifyIcon.TabIndex = 2;
            this.NotifyIcon.TabStop = false;
            // 
            // Title
            // 
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.HoverText = null;
            this.Title.IsDerivedStyle = true;
            this.Title.Location = new System.Drawing.Point(49, 4);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(1);
            this.Title.Size = new System.Drawing.Size(211, 25);
            this.Title.Style = MetroSet_UI.Enums.Style.Custom;
            this.Title.StyleManager = null;
            this.Title.TabIndex = 3;
            this.Title.Text = "label1";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.ThemeAuthor = "Terry D. Eppler";
            this.Title.ThemeName = "BudgetExecution";
            this.Title.ToolTip = null;
            // 
            // Message
            // 
            this.Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Message.HoverText = null;
            this.Message.IsDerivedStyle = true;
            this.Message.Location = new System.Drawing.Point(49, 48);
            this.Message.Margin = new System.Windows.Forms.Padding(3);
            this.Message.Name = "Message";
            this.Message.Padding = new System.Windows.Forms.Padding(1);
            this.Message.Size = new System.Drawing.Size(310, 103);
            this.Message.Style = MetroSet_UI.Enums.Style.Custom;
            this.Message.StyleManager = null;
            this.Message.TabIndex = 4;
            this.Message.Text = "label1";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Message.ThemeAuthor = "Terry D. Eppler";
            this.Message.ThemeName = "BudgetExecution";
            this.Message.ToolTip = null;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionBarHeight = 3;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(401, 189);
            this.ControlBox = false;
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NotifyIcon);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(460, 189);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Name = "WebNotification";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Notification";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.NotifyIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox NotifyIcon;
        public System.Windows.Forms.Timer Timer;
        public Label Title;
        public Label Message;
    }
}