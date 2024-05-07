namespace Baby
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;

    /// <summary>
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetComboBox"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class ComboBox : MetroSetComboBox
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
        /// Initializes a new instance of the
        /// <see cref="ComboBox"/>
        /// class.
        /// </summary>
        public ComboBox( )
        {
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            ArrowColor = Color.FromArgb( 0, 120, 212 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            FlatStyle = FlatStyle.Flat;
            DropDownStyle = ComboBoxStyle.DropDownList;
            ItemHeight = 24;
            Font = new Font( "Roboto", 9 );
            BackColor = Color.FromArgb( 75, 75, 75 );
            BorderColor = Color.FromArgb( 0, 120, 212 );

            // Selected Item Configuration
            SelectedItemBackColor = Color.FromArgb( 0, 120, 212 );
            SelectedItemForeColor = Color.White;

            // Disabled Color Configuration
            DisabledBorderColor = Color.Transparent;
            DisabledBackColor = Color.Transparent;
            DisabledForeColor = Color.Transparent;
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
