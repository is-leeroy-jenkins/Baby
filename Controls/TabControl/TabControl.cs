
namespace BudgetBrowser
{
    using Syncfusion.Windows.Forms.Tools;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class TabControl : TabControlAdv
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TabControl"/> class.
        /// </summary>
        /// <example>
        /// The following example creates a TabControlAdv with one TabPageAdv object.
        /// The constructor instantiates tabControl1.
        /// Use the Syncfusion.Windows.Forms.Tools namespace for this example.
        /// <code lang="C#">
        /// public Form1()
        /// {
        /// this.tabPage1 = new TabPageAdv();
        /// // Invokes the TabControlAdv() constructor to create the tabControl1 object.
        /// this.tabControl1 = new TabControlAdv();
        /// this.tabControl1.Controls.Add(tabPage1);
        /// this.Controls.Add(tabControl1);
        /// }
        /// </code><code lang="VB">
        /// Public Sub New()
        /// Me.tabPage1 = New TabPageAdv()
        /// ' Invokes the TabControlAdv() constructor to create the tabControl1 object.
        /// Me.tabControl1 = New TabControlAdv()
        /// Me.tabControl1.Controls.Add(tabPage1)
        /// Me.Controls.Add(tabControl1)
        /// End Sub 'New
        /// </code></example>
        public TabControl( )
        {
            TabStyle = typeof( TabRendererMetro );
            BackColor = Color.FromArgb( 20, 20, 20 );
            Size = new Size( 350, 500 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            BorderStyle = BorderStyle.None;
            CloseButtonBackColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonForeColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonHoverForeColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonPressedForeColor = Color.FromArgb( 20, 20, 20 );
            SeparatorColor = Color.FromArgb( 20, 20, 20 );
            ShowSeparator = false;
            ItemSize = new Size( 100, 30 );
            TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            CanOverrideStyle = true;
            CanApplyTheme = true;
            ActiveTabColor = Color.FromArgb( 20, 20, 20 );
            ActiveTabFont = new Font( "Roboto", 8 );
            ActiveTabForeColor = Color.DarkGray;
            InActiveTabForeColor = Color.FromArgb( 20, 20, 20 );
            InactiveCloseButtonForeColor = Color.FromArgb( 20, 20, 20 );
            InactiveTabColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderFillColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveFont = new Font( "Roboto", 8 );
            ThemeStyle.TabStyle.ActiveForeColor = Color.DarkGray;
            ThemeStyle.TabStyle.SeparatorColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveBackColor = Color.FromArgb( 20, 20, 20 );
        }
    }
}
