
namespace Baby
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;


    partial class FileBrowser : MetroForm
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
            components = new Container( );
            var resources = new ComponentResourceManager( typeof( FileBrowser ) );
            TextBoxLayout = new TableLayoutPanel( );
            CheckBoxLayout = new TableLayoutPanel( );
            LibraryRadioButton = new RadioButton( );
            PowerPointRadioButton = new RadioButton( );
            ExecutableRadioButton = new RadioButton( );
            TextRadioButton = new RadioButton( );
            SqlCeRadioButton = new RadioButton( );
            ExcelRadioButton = new RadioButton( );
            CsvRadioButton = new RadioButton( );
            AccessRadioButton = new RadioButton( );
            SQLiteRadioButton = new RadioButton( );
            SqlServerRadioButton = new RadioButton( );
            WordRadioButton = new RadioButton( );
            PdfRadioButton = new RadioButton( );
            FileList = new ListBox( );
            ToolTip = new ToolTip( );
            FoundLabel = new Label( );
            FileDialog = new OpenFileDialog( );
            TopTablePanel = new TableLayoutPanel( );
            Picture = new ImageBox( );
            Header = new Label( );
            BindingSource = new BindingSource( components );
            MessageLabel = new Label( );
            SelectButton = new Button( );
            CloseButton = new Button( );
            FindButton = new Button( );
            TextBoxLayout.SuspendLayout( );
            CheckBoxLayout.SuspendLayout( );
            TopTablePanel.SuspendLayout( );
            ( (ISupportInitialize) Picture  ).BeginInit( );
            ( (ISupportInitialize) BindingSource  ).BeginInit( );
            SuspendLayout( );
            // 
            // TextBoxLayout
            // 
            TextBoxLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TextBoxLayout.BackColor = System.Drawing.Color.Transparent;
            TextBoxLayout.ColumnCount = 3;
            TextBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 12.55012F ) );
            TextBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 70.99126F ) );
            TextBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 16.4723F ) );
            TextBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 20F ) );
            TextBoxLayout.Controls.Add( CheckBoxLayout, 2, 0 );
            TextBoxLayout.Controls.Add( FileList, 1, 0 );
            TextBoxLayout.Controls.Add( FoundLabel, 0, 0 );
            TextBoxLayout.Dock = DockStyle.Top;
            TextBoxLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TextBoxLayout.Location = new System.Drawing.Point( 0, 64 );
            TextBoxLayout.Margin = new Padding( 5 );
            TextBoxLayout.Name = "TextBoxLayout";
            TextBoxLayout.Padding = new Padding( 1 );
            TextBoxLayout.RowCount = 1;
            TextBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            TextBoxLayout.Size = new System.Drawing.Size( 688, 291 );
            TextBoxLayout.TabIndex = 5;
            // 
            // CheckBoxLayout
            // 
            CheckBoxLayout.BackColor = System.Drawing.Color.Transparent;
            CheckBoxLayout.ColumnCount = 1;
            CheckBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            CheckBoxLayout.Controls.Add( LibraryRadioButton, 0, 11 );
            CheckBoxLayout.Controls.Add( PowerPointRadioButton, 0, 8 );
            CheckBoxLayout.Controls.Add( ExecutableRadioButton, 0, 10 );
            CheckBoxLayout.Controls.Add( TextRadioButton, 0, 7 );
            CheckBoxLayout.Controls.Add( SqlCeRadioButton, 0, 9 );
            CheckBoxLayout.Controls.Add( ExcelRadioButton, 0, 6 );
            CheckBoxLayout.Controls.Add( CsvRadioButton, 0, 5 );
            CheckBoxLayout.Controls.Add( AccessRadioButton, 0, 4 );
            CheckBoxLayout.Controls.Add( SQLiteRadioButton, 0, 3 );
            CheckBoxLayout.Controls.Add( SqlServerRadioButton, 0, 2 );
            CheckBoxLayout.Controls.Add( WordRadioButton, 0, 1 );
            CheckBoxLayout.Controls.Add( PdfRadioButton, 0, 0 );
            CheckBoxLayout.Dock = DockStyle.Fill;
            CheckBoxLayout.Location = new System.Drawing.Point( 576, 4 );
            CheckBoxLayout.Name = "CheckBoxLayout";
            CheckBoxLayout.RowCount = 12;
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333765F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333267F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333765F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333765F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.332569F ) );
            CheckBoxLayout.Size = new System.Drawing.Size( 108, 283 );
            CheckBoxLayout.TabIndex = 2;
            // 
            // LibraryRadioButton
            // 
            LibraryRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            LibraryRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            LibraryRadioButton.Checked = false;
            LibraryRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            LibraryRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            LibraryRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            LibraryRadioButton.Dock = DockStyle.Fill;
            LibraryRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LibraryRadioButton.Group = 0;
            LibraryRadioButton.HoverText = "Library Files";
            LibraryRadioButton.IsDerivedStyle = true;
            LibraryRadioButton.Location = new System.Drawing.Point( 3, 256 );
            LibraryRadioButton.Name = "LibraryRadioButton";
            LibraryRadioButton.Result = null;
            LibraryRadioButton.Size = new System.Drawing.Size( 102, 17 );
            LibraryRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            LibraryRadioButton.StyleManager = null;
            LibraryRadioButton.TabIndex = 15;
            LibraryRadioButton.Tag = ".dll";
            LibraryRadioButton.Text = "  DLL Files";
            LibraryRadioButton.ThemeAuthor = "Terry D. Eppler";
            LibraryRadioButton.ThemeName = "Budget Execution";
            LibraryRadioButton.ToolTip = null;
            // 
            // PowerPointRadioButton
            // 
            PowerPointRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PowerPointRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            PowerPointRadioButton.Checked = false;
            PowerPointRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            PowerPointRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            PowerPointRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            PowerPointRadioButton.Dock = DockStyle.Fill;
            PowerPointRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PowerPointRadioButton.Group = 0;
            PowerPointRadioButton.HoverText = "Power Point Files";
            PowerPointRadioButton.IsDerivedStyle = true;
            PowerPointRadioButton.Location = new System.Drawing.Point( 3, 187 );
            PowerPointRadioButton.Name = "PowerPointRadioButton";
            PowerPointRadioButton.Result = null;
            PowerPointRadioButton.Size = new System.Drawing.Size( 102, 17 );
            PowerPointRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            PowerPointRadioButton.StyleManager = null;
            PowerPointRadioButton.TabIndex = 21;
            PowerPointRadioButton.Tag = ".pptx";
            PowerPointRadioButton.Text = "  Power Point";
            PowerPointRadioButton.ThemeAuthor = "Terry D. Eppler";
            PowerPointRadioButton.ThemeName = "Budget Execution";
            PowerPointRadioButton.ToolTip = null;
            // 
            // ExecutableRadioButton
            // 
            ExecutableRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ExecutableRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ExecutableRadioButton.Checked = false;
            ExecutableRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            ExecutableRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            ExecutableRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            ExecutableRadioButton.Dock = DockStyle.Fill;
            ExecutableRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ExecutableRadioButton.Group = 0;
            ExecutableRadioButton.HoverText = "Executable Files";
            ExecutableRadioButton.IsDerivedStyle = true;
            ExecutableRadioButton.Location = new System.Drawing.Point( 3, 233 );
            ExecutableRadioButton.Name = "ExecutableRadioButton";
            ExecutableRadioButton.Result = null;
            ExecutableRadioButton.Size = new System.Drawing.Size( 102, 17 );
            ExecutableRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            ExecutableRadioButton.StyleManager = null;
            ExecutableRadioButton.TabIndex = 14;
            ExecutableRadioButton.Tag = ".exe";
            ExecutableRadioButton.Text = "  EXE Files";
            ExecutableRadioButton.ThemeAuthor = "Terry D. Eppler";
            ExecutableRadioButton.ThemeName = "Budget Execution";
            ExecutableRadioButton.ToolTip = null;
            // 
            // TextRadioButton
            // 
            TextRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TextRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            TextRadioButton.Checked = false;
            TextRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            TextRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            TextRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            TextRadioButton.Dock = DockStyle.Fill;
            TextRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TextRadioButton.Group = 0;
            TextRadioButton.HoverText = "Text Files";
            TextRadioButton.IsDerivedStyle = true;
            TextRadioButton.Location = new System.Drawing.Point( 3, 164 );
            TextRadioButton.Name = "TextRadioButton";
            TextRadioButton.Result = null;
            TextRadioButton.Size = new System.Drawing.Size( 102, 17 );
            TextRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            TextRadioButton.StyleManager = null;
            TextRadioButton.TabIndex = 20;
            TextRadioButton.Tag = ".txt";
            TextRadioButton.Text = "  Text Files";
            TextRadioButton.ThemeAuthor = "Terry D. Eppler";
            TextRadioButton.ThemeName = "Budget Execution";
            TextRadioButton.ToolTip = null;
            // 
            // SqlCeRadioButton
            // 
            SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SqlCeRadioButton.Checked = false;
            SqlCeRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            SqlCeRadioButton.Dock = DockStyle.Fill;
            SqlCeRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SqlCeRadioButton.Group = 0;
            SqlCeRadioButton.HoverText = "SQL Compact Files";
            SqlCeRadioButton.IsDerivedStyle = true;
            SqlCeRadioButton.Location = new System.Drawing.Point( 3, 210 );
            SqlCeRadioButton.Name = "SqlCeRadioButton";
            SqlCeRadioButton.Result = null;
            SqlCeRadioButton.Size = new System.Drawing.Size( 102, 17 );
            SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlCeRadioButton.StyleManager = null;
            SqlCeRadioButton.TabIndex = 13;
            SqlCeRadioButton.Tag = ".sdf";
            SqlCeRadioButton.Text = "  SQL Compact";
            SqlCeRadioButton.ThemeAuthor = "Terry D. Eppler";
            SqlCeRadioButton.ThemeName = "Budget Execution";
            SqlCeRadioButton.ToolTip = null;
            // 
            // ExcelRadioButton
            // 
            ExcelRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ExcelRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ExcelRadioButton.Checked = false;
            ExcelRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            ExcelRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            ExcelRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            ExcelRadioButton.Dock = DockStyle.Fill;
            ExcelRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ExcelRadioButton.Group = 0;
            ExcelRadioButton.HoverText = "Excel Workbooks";
            ExcelRadioButton.IsDerivedStyle = true;
            ExcelRadioButton.Location = new System.Drawing.Point( 3, 141 );
            ExcelRadioButton.Name = "ExcelRadioButton";
            ExcelRadioButton.Result = null;
            ExcelRadioButton.Size = new System.Drawing.Size( 102, 17 );
            ExcelRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            ExcelRadioButton.StyleManager = null;
            ExcelRadioButton.TabIndex = 19;
            ExcelRadioButton.Tag = ".xlsx";
            ExcelRadioButton.Text = "  Excel Files";
            ExcelRadioButton.ThemeAuthor = "Terry D. Eppler";
            ExcelRadioButton.ThemeName = "Budget Execution";
            ExcelRadioButton.ToolTip = null;
            // 
            // CsvRadioButton
            // 
            CsvRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CsvRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CsvRadioButton.Checked = false;
            CsvRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            CsvRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            CsvRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            CsvRadioButton.Dock = DockStyle.Fill;
            CsvRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CsvRadioButton.Group = 0;
            CsvRadioButton.HoverText = "CSV Files";
            CsvRadioButton.IsDerivedStyle = true;
            CsvRadioButton.Location = new System.Drawing.Point( 3, 118 );
            CsvRadioButton.Name = "CsvRadioButton";
            CsvRadioButton.Result = null;
            CsvRadioButton.Size = new System.Drawing.Size( 102, 17 );
            CsvRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            CsvRadioButton.StyleManager = null;
            CsvRadioButton.TabIndex = 18;
            CsvRadioButton.Tag = ".csv";
            CsvRadioButton.Text = "  CSV Files";
            CsvRadioButton.ThemeAuthor = "Terry D. Eppler";
            CsvRadioButton.ThemeName = "Budget Execution";
            CsvRadioButton.ToolTip = null;
            // 
            // AccessRadioButton
            // 
            AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            AccessRadioButton.Checked = false;
            AccessRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            AccessRadioButton.Dock = DockStyle.Fill;
            AccessRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            AccessRadioButton.Group = 0;
            AccessRadioButton.HoverText = "Access DB Files";
            AccessRadioButton.IsDerivedStyle = true;
            AccessRadioButton.Location = new System.Drawing.Point( 3, 95 );
            AccessRadioButton.Name = "AccessRadioButton";
            AccessRadioButton.Result = null;
            AccessRadioButton.Size = new System.Drawing.Size( 102, 17 );
            AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            AccessRadioButton.StyleManager = null;
            AccessRadioButton.TabIndex = 17;
            AccessRadioButton.Tag = ".accdb";
            AccessRadioButton.Text = "  MS Access";
            AccessRadioButton.ThemeAuthor = "Terry D. Eppler";
            AccessRadioButton.ThemeName = "Budget Execution";
            AccessRadioButton.ToolTip = null;
            // 
            // SQLiteRadioButton
            // 
            SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SQLiteRadioButton.Checked = false;
            SQLiteRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            SQLiteRadioButton.Dock = DockStyle.Fill;
            SQLiteRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SQLiteRadioButton.Group = 0;
            SQLiteRadioButton.HoverText = "SQLite DB Files";
            SQLiteRadioButton.IsDerivedStyle = true;
            SQLiteRadioButton.Location = new System.Drawing.Point( 3, 72 );
            SQLiteRadioButton.Name = "SQLiteRadioButton";
            SQLiteRadioButton.Result = null;
            SQLiteRadioButton.Size = new System.Drawing.Size( 102, 17 );
            SQLiteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SQLiteRadioButton.StyleManager = null;
            SQLiteRadioButton.TabIndex = 16;
            SQLiteRadioButton.Tag = ".db";
            SQLiteRadioButton.Text = "  SQLite";
            SQLiteRadioButton.ThemeAuthor = "Terry D. Eppler";
            SQLiteRadioButton.ThemeName = "Budget Execution";
            SQLiteRadioButton.ToolTip = null;
            // 
            // SqlServerRadioButton
            // 
            SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SqlServerRadioButton.Checked = false;
            SqlServerRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            SqlServerRadioButton.Dock = DockStyle.Fill;
            SqlServerRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SqlServerRadioButton.Group = 0;
            SqlServerRadioButton.HoverText = "SQL Server DB Files";
            SqlServerRadioButton.IsDerivedStyle = true;
            SqlServerRadioButton.Location = new System.Drawing.Point( 3, 49 );
            SqlServerRadioButton.Name = "SqlServerRadioButton";
            SqlServerRadioButton.Result = null;
            SqlServerRadioButton.Size = new System.Drawing.Size( 102, 17 );
            SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlServerRadioButton.StyleManager = null;
            SqlServerRadioButton.TabIndex = 15;
            SqlServerRadioButton.Tag = ".mdf";
            SqlServerRadioButton.Text = "  SQL Server";
            SqlServerRadioButton.ThemeAuthor = "Terry D. Eppler";
            SqlServerRadioButton.ThemeName = "Budget Execution";
            SqlServerRadioButton.ToolTip = null;
            // 
            // WordRadioButton
            // 
            WordRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            WordRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            WordRadioButton.Checked = false;
            WordRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            WordRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            WordRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            WordRadioButton.Dock = DockStyle.Fill;
            WordRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            WordRadioButton.Group = 0;
            WordRadioButton.HoverText = "Word Documents";
            WordRadioButton.IsDerivedStyle = true;
            WordRadioButton.Location = new System.Drawing.Point( 3, 26 );
            WordRadioButton.Name = "WordRadioButton";
            WordRadioButton.Result = null;
            WordRadioButton.Size = new System.Drawing.Size( 102, 17 );
            WordRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            WordRadioButton.StyleManager = null;
            WordRadioButton.TabIndex = 14;
            WordRadioButton.Tag = ".docx";
            WordRadioButton.Text = "  Word";
            WordRadioButton.ThemeAuthor = "Terry D. Eppler";
            WordRadioButton.ThemeName = "Budget Execution";
            WordRadioButton.ToolTip = null;
            // 
            // PdfRadioButton
            // 
            PdfRadioButton.BackgroundColor = System.Drawing.Color.Transparent;
            PdfRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            PdfRadioButton.Checked = false;
            PdfRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   192  ,   0   );
            PdfRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            PdfRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
            PdfRadioButton.Dock = DockStyle.Fill;
            PdfRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PdfRadioButton.Group = 0;
            PdfRadioButton.HoverText = "PDF Documents";
            PdfRadioButton.IsDerivedStyle = true;
            PdfRadioButton.Location = new System.Drawing.Point( 3, 3 );
            PdfRadioButton.Name = "PdfRadioButton";
            PdfRadioButton.Result = null;
            PdfRadioButton.Size = new System.Drawing.Size( 102, 17 );
            PdfRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            PdfRadioButton.StyleManager = null;
            PdfRadioButton.TabIndex = 13;
            PdfRadioButton.Tag = ".pdf";
            PdfRadioButton.Text = "  PDF";
            PdfRadioButton.ThemeAuthor = "Terry D. Eppler";
            PdfRadioButton.ThemeName = "Budget Execution";
            PdfRadioButton.ToolTip = null;
            // 
            // FileList
            // 
            FileList.BackColor = System.Drawing.Color.FromArgb(   35  ,   35  ,   35   );
            FileList.BindingSource = null;
            FileList.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
            FileList.DataFilter = null;
            FileList.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FileList.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FileList.Dock = DockStyle.Fill;
            FileList.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FileList.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            FileList.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            FileList.HoverText = null;
            FileList.IsDerivedStyle = true;
            FileList.ItemHeight = 30;
            FileList.Location = new System.Drawing.Point( 88, 2 );
            FileList.Margin = new Padding( 1 );
            FileList.MultiSelect = false;
            FileList.Name = "FileList";
            FileList.Padding = new Padding( 1 );
            FileList.SelectedIndex = -1;
            FileList.SelectedItem = null;
            FileList.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FileList.SelectedItemColor = System.Drawing.Color.White;
            FileList.SelectedText = null;
            FileList.SelectedValue = null;
            FileList.ShowBorder = false;
            FileList.ShowScrollBar = false;
            FileList.Size = new System.Drawing.Size( 484, 287 );
            FileList.Style = MetroSet_UI.Enums.Style.Custom;
            FileList.StyleManager = null;
            FileList.TabIndex = 3;
            FileList.ThemeAuthor = "Terry D. Eppler";
            FileList.ThemeName = "BudgetExecution";
            FileList.ToolTip = ToolTip;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb(   5  ,   5  ,   5   );
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
            ToolTip.ThemeName = "Budget Execution";
            ToolTip.TipIcon = ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // FoundLabel
            // 
            FoundLabel.FlatStyle = FlatStyle.Flat;
            FoundLabel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FoundLabel.HoverText = null;
            FoundLabel.IsDerivedStyle = true;
            FoundLabel.Location = new System.Drawing.Point( 4, 4 );
            FoundLabel.Margin = new Padding( 3 );
            FoundLabel.Name = "FoundLabel";
            FoundLabel.Padding = new Padding( 1 );
            FoundLabel.Size = new System.Drawing.Size( 80, 23 );
            FoundLabel.Style = MetroSet_UI.Enums.Style.Custom;
            FoundLabel.StyleManager = null;
            FoundLabel.TabIndex = 4;
            FoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            FoundLabel.ThemeAuthor = "Terry D. Eppler";
            FoundLabel.ThemeName = "BudgetExecution";
            FoundLabel.ToolTip = null;
            // 
            // FileDialog
            // 
            FileDialog.Filter = "Document FIles | *.PDF | *.DOCX | *.DOC ";
            // 
            // TopTablePanel
            // 
            TopTablePanel.BackColor = System.Drawing.Color.Transparent;
            TopTablePanel.ColumnCount = 2;
            TopTablePanel.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.668605F ) );
            TopTablePanel.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 94.3314F ) );
            TopTablePanel.Controls.Add( Picture, 0, 0 );
            TopTablePanel.Controls.Add( Header, 1, 0 );
            TopTablePanel.Dock = DockStyle.Top;
            TopTablePanel.Location = new System.Drawing.Point( 0, 0 );
            TopTablePanel.Name = "TopTablePanel";
            TopTablePanel.RowCount = 1;
            TopTablePanel.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            TopTablePanel.Size = new System.Drawing.Size( 688, 64 );
            TopTablePanel.TabIndex = 9;
            // 
            // Picture
            // 
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.Dock = DockStyle.Top;
            Picture.Location = new System.Drawing.Point( 3, 3 );
            Picture.Name = "Picture";
            Picture.Padding = new Padding( 1 );
            Picture.Size = new System.Drawing.Size( 33, 31 );
            Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture.TabIndex = 1;
            Picture.TabStop = false;
            Picture.ToolTip = ToolTip;
            // 
            // Header
            // 
            Header.Dock = DockStyle.Top;
            Header.FlatStyle = FlatStyle.Flat;
            Header.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            Header.HoverText = null;
            Header.IsDerivedStyle = true;
            Header.Location = new System.Drawing.Point( 42, 3 );
            Header.Margin = new Padding( 3 );
            Header.Name = "Header";
            Header.Padding = new Padding( 1 );
            Header.Size = new System.Drawing.Size( 643, 31 );
            Header.Style = MetroSet_UI.Enums.Style.Custom;
            Header.StyleManager = null;
            Header.TabIndex = 0;
            Header.Text = "File SaveAs";
            Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Header.ThemeAuthor = "Terry D. Eppler";
            Header.ThemeName = "BudgetExecution";
            Header.ToolTip = null;
            // 
            // MessageLabel
            // 
            MessageLabel.FlatStyle = FlatStyle.Flat;
            MessageLabel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MessageLabel.HoverText = null;
            MessageLabel.IsDerivedStyle = true;
            MessageLabel.Location = new System.Drawing.Point( 90, 363 );
            MessageLabel.Margin = new Padding( 3 );
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Padding = new Padding( 1 );
            MessageLabel.Size = new System.Drawing.Size( 488, 23 );
            MessageLabel.Style = MetroSet_UI.Enums.Style.Custom;
            MessageLabel.StyleManager = null;
            MessageLabel.TabIndex = 12;
            MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MessageLabel.ThemeAuthor = "Terry D. Eppler";
            MessageLabel.ThemeName = "BudgetExecution";
            MessageLabel.ToolTip = null;
            // 
            // SelectButton
            // 
            SelectButton.BackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SelectButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            SelectButton.HoverText = "Select File";
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 307, 417 );
            SelectButton.Margin = new Padding( 0 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.Transparent;
            SelectButton.NormalColor = System.Drawing.Color.Transparent;
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.Padding = new Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 78, 26 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 11;
            SelectButton.Text = "Select";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "BudgetExecution";
            SelectButton.ToolTip = null;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            CloseButton.HoverText = "Close Window";
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 601, 417 );
            CloseButton.Margin = new Padding( 0 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.Transparent;
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.Padding = new Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 78, 26 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 10;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "BudgetExecution";
            CloseButton.ToolTip = null;
            // 
            // FindButton
            // 
            FindButton.BackColor = System.Drawing.Color.Transparent;
            FindButton.DisabledBackColor = System.Drawing.Color.Transparent;
            FindButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            FindButton.DisabledForeColor = System.Drawing.Color.Transparent;
            FindButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FindButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FindButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FindButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            FindButton.HoverText = "Select File";
            FindButton.HoverTextColor = System.Drawing.Color.White;
            FindButton.IsDerivedStyle = true;
            FindButton.Location = new System.Drawing.Point( 9, 417 );
            FindButton.Margin = new Padding( 0 );
            FindButton.Name = "FindButton";
            FindButton.NormalBorderColor = System.Drawing.Color.Transparent;
            FindButton.NormalColor = System.Drawing.Color.Transparent;
            FindButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FindButton.Padding = new Padding( 1 );
            FindButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FindButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FindButton.PressTextColor = System.Drawing.Color.White;
            FindButton.Size = new System.Drawing.Size( 78, 26 );
            FindButton.Style = MetroSet_UI.Enums.Style.Custom;
            FindButton.StyleManager = null;
            FindButton.TabIndex = 13;
            FindButton.Text = "Find";
            FindButton.ThemeAuthor = "Terry D. Eppler";
            FindButton.ThemeName = "Budget Execution";
            FindButton.ToolTip = null;
            // 
            // FileBrowser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BorderThickness = 2;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
            CaptionButtonHoverColor = System.Drawing.Color.Red;
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ClientSize = new System.Drawing.Size( 688, 448 );
            ControlBox = false;
            Controls.Add( FindButton );
            Controls.Add( MessageLabel );
            Controls.Add( SelectButton );
            Controls.Add( CloseButton );
            Controls.Add( TextBoxLayout );
            Controls.Add( TopTablePanel );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 700, 460 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 700, 460 );
            Name = "FileBrowser";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            TextBoxLayout.ResumeLayout( false );
            CheckBoxLayout.ResumeLayout( false );
            TopTablePanel.ResumeLayout( false );
            TopTablePanel.PerformLayout( );
            ( (ISupportInitialize) Picture  ).EndInit( );
            ( (ISupportInitialize) BindingSource  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public TableLayoutPanel TextBoxLayout;
        public TableLayoutPanel CheckBoxLayout;
        public OpenFileDialog FileDialog;
        public ToolTip ToolTip;
        public TableLayoutPanel TopTablePanel;
        public Label Header;
        public Button CloseButton;
        public Button SelectButton;
        public BindingSource BindingSource;
        public ImageBox Picture;
        public ListBox FileList;
        public Label FoundLabel;
        public Label MessageLabel;
        public RadioButton LibraryRadioButton;
        public RadioButton PowerPointRadioButton;
        public RadioButton ExecutableRadioButton;
        public RadioButton TextRadioButton;
        public RadioButton SqlCeRadioButton;
        public RadioButton ExcelRadioButton;
        public RadioButton CsvRadioButton;
        public RadioButton AccessRadioButton;
        public RadioButton SQLiteRadioButton;
        public RadioButton SqlServerRadioButton;
        public RadioButton WordRadioButton;
        public RadioButton PdfRadioButton;
        public Button FindButton;
    }

}
