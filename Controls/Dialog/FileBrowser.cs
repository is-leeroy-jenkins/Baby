// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="FileBrowser.cs" company="Terry D. Eppler">
//     Baby is a light-weight, full-featured, web-browser built with .NET 6 and is written
//     in C#.  The baby browser is designed for budget execution and data analysis.
//     A tool for EPA analysts and a component that can be used for general browsing.
// 
//     Copyright ©  2020 Terry D. Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   FileBrowser.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using static System.Environment;
    using static System.IO.Directory;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "RedundantExtendsListEntry" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public partial class FileBrowser : BasicDialog
    {
        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        public string FileExtension
        {
            get
            {
                return _fileExtension;
            }
            private protected set
            {
                _fileExtension = value;
            }
        }

        /// <summary>
        /// Gets or sets the file paths.
        /// </summary>
        /// <value>
        /// The file paths.
        /// </value>
        public IList<string> FilePaths
        {
            get
            {
                return _filePaths;
            }
            private protected set
            {
                _filePaths = value;
            }
        }

        /// <summary>
        /// Gets or sets the radio buttons.
        /// </summary>
        /// <value>
        /// The radio buttons.
        /// </value>
        public IList<RadioButton> RadioButtons
        {
            get
            {
                return _radioButtons;
            }
            private protected set
            {
                _radioButtons = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected path.
        /// </summary>
        /// <value>
        /// The selected path.
        /// </value>
        public string SelectedPath
        {
            get
            {
                return _selectedPath;
            }
            private protected set
            {
                _selectedPath = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected file.
        /// </summary>
        /// <value>
        /// The selected file.
        /// </value>
        public string SelectedFile
        {
            get
            {
                return _selectedFile;
            }
            private protected set
            {
                _selectedFile = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is busy; otherwise,
        /// <c> false </c>
        /// </value>
        public bool IsBusy
        {
            get
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        return _busy;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        return _busy;
                    }
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Baby.FileBrowser" /> class.
        /// </summary>
        public FileBrowser( )
            : base( )
        {
            InitializeComponent( );
            RegisterCallbacks( );

            // Form Properties
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 700, 460 );
            MaximumSize = new Size( 700, 460 );
            MinimumSize = new Size( 700, 460 );
            Header.ForeColor = Color.FromArgb( 106, 189, 252 );
            Header.TextAlign = ContentAlignment.TopLeft;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            RadioButtons = GetRadioButtons( );
            Picture.Image = GetExtensionImage( );
            FileList.BackColor = Color.FromArgb( 40, 40, 40 );
            CaptionBarHeight = 5;
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // Browser Properties
            _fileExtension = "xlsx";
            _extension = EXT.XLSX;
            _searchPaths = GetInitialDirPaths( );
            _filePaths = GetListViewPaths( );
            _radioButtons = GetRadioButtons( );

            // Event Wiring
            Load += OnLoad;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Baby.FileBrowser" /> class.
        /// </summary>
        /// <param name="extension">The extension.</param>
        public FileBrowser( EXT extension )
            : this( )
        {
            _extension = extension;
            _fileExtension = _extension.ToString( ).ToLower( );
            _searchPaths = GetInitialDirPaths( );
            _filePaths = GetListViewPaths( );
            _radioButtons = GetRadioButtons( );
        }

        /// <summary>
        /// Registers the callbacks.
        /// </summary>
        private protected void RegisterCallbacks( )
        {
            try
            {
                CloseButton.Click += OnCloseButtonClicked;
                FileList.SelectedValueChanged += OnPathSelected;
                BrowseButton.Click += OnBrowseButtonClicked;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the RadioButton events.
        /// </summary>
        private protected void RegisterRadioButtonEvents( )
        {
            try
            {
                foreach( var _radioButton in _radioButtons )
                {
                    _radioButton.Click += OnRadioButtonSelected;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        private protected virtual IList<RadioButton> GetRadioButtons( )
        {
            try
            {
                var _list = new List<RadioButton>
                {
                    PdfRadioButton,
                    AccessRadioButton,
                    SQLiteRadioButton,
                    SqlCeRadioButton,
                    SqlServerRadioButton,
                    ExcelRadioButton,
                    CsvRadioButton,
                    TextRadioButton,
                    PowerPointRadioButton,
                    WordRadioButton,
                    ExecutableRadioButton,
                    LibraryRadioButton
                };

                return _list?.Any( ) == true
                    ? _list
                    : default( IList<RadioButton> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<RadioButton> );
            }
        }

        /// <summary>
        /// Gets the ListView paths.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetListViewPaths( )
        {
            if( _searchPaths?.Any( ) == true )
            {
                try
                {
                    var _list = new List<string>( );
                    foreach( var _filePath in _searchPaths )
                    {
                        var _first = Directory.GetFiles( _filePath )
                            ?.Where( f => f.EndsWith( _fileExtension ) )
                            ?.Select( f => Path.GetFullPath( f ) )?.ToList( );

                        _list.AddRange( _first );
                        var _dirs = Directory.GetDirectories( _filePath );
                        foreach( var _dir in _dirs )
                        {
                            if( !_dir.Contains( "My " ) )
                            {
                                var _second = Directory.GetFiles( _dir )
                                    ?.Where( s => s.EndsWith( _fileExtension ) )
                                    ?.Select( s => Path.GetFullPath( s ) )?.ToList( );

                                if( _second?.Any( ) == true )
                                {
                                    _list.AddRange( _second );
                                }

                                var _subDir = Directory.GetDirectories( _dir );
                                for( var _i = 0; _i < _subDir.Length; _i++ )
                                {
                                    var _value = _subDir[ _i ];
                                    if( !string.IsNullOrEmpty( _value ) )
                                    {
                                        var _last = Directory.GetFiles( _value )
                                            ?.Where( l => l.EndsWith( _fileExtension ) )
                                            ?.Select( l => Path.GetFullPath( l ) )?.ToList( );

                                        if( _last?.Any( ) == true )
                                        {
                                            _list.AddRange( _last );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( IList<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }

        /// <summary>
        /// Gets the initial dir paths.
        /// </summary>
        /// <returns></returns>
        private protected virtual IList<string> GetInitialDirPaths( )
        {
            try
            {
                var _current = CurrentDirectory;
                var _list = new List<string>
                {
                    Environment.GetFolderPath( SpecialFolder.DesktopDirectory ),
                    Environment.GetFolderPath( SpecialFolder.Personal ),
                    Environment.GetFolderPath( SpecialFolder.Recent ),
                    @"C:\Users\terry\source\repos\Budget\Resource\Documents",
                    _current
                };

                return _list?.Any( ) == true
                    ? _list
                    : default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Populates the ListBox.
        /// </summary>
        private protected virtual void PopulateListBox( )
        {
            if( _filePaths?.Any( ) == true )
            {
                try
                {
                    FileList.Items.Clear( );
                    foreach( var _item in _filePaths )
                    {
                        FileList.Items.Add( _item );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Populates the ListBox.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        public virtual void PopulateListBox( IEnumerable<string> filePaths )
        {
            try
            {
                if( filePaths?.Any( ) == true )
                {
                    FileList.Items.Clear( );
                    var _paths = filePaths.ToArray( );
                    for( var _i = 0; _i < _paths.Length; _i++ )
                    {
                        var _item = _paths[ _i ];
                        if( !string.IsNullOrEmpty( _item ) )
                        {
                            FileList?.Items.Add( _item );
                        }
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            if( _filePaths?.Any( ) == true )
            {
                try
                {
                    PopulateListBox( );
                    FoundLabel.Text = "Found : " + _filePaths?.Count;
                    Header.Text = $"{_extension} File Browser";
                    ClearRadioButtons( );
                    RegisterRadioButtonEvents( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [RadioButton selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name = "e" > </param>
        private protected void OnRadioButtonSelected( object sender, EventArgs e )
        {
            if( sender is RadioButton _radioButton
                && !string.IsNullOrEmpty( _radioButton.Tag?.ToString( ) ) )
            {
                try
                {
                    _fileExtension = _radioButton?.Result;
                    var _ext = _radioButton.Tag?.ToString( )?.Trim( ".".ToCharArray( ) )
                        ?.ToUpper( );

                    Header.Text = $"{_ext} File Browser";
                    MessageLabel.Text = string.Empty;
                    FoundLabel.Text = string.Empty;
                    var _paths = GetListViewPaths( );
                    PopulateListBox( _paths );
                    Picture.Image = GetExtensionImage( );
                    FoundLabel.Text = "Found: " + _paths?.ToList( )?.Count ?? "0";
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [path selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private protected void OnPathSelected( object sender )
        {
            if( sender is ListBox _listBox
                && !string.IsNullOrEmpty( _listBox.SelectedItem?.ToString( ) ) )
            {
                try
                {
                    _selectedPath = _listBox.SelectedItem?.ToString( );
                    MessageLabel.Text = _selectedPath;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [find button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private protected void OnBrowseButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button )
            {
                try
                {
                    FileDialog = new OpenFileDialog( );
                    FileDialog.DefaultExt = _fileExtension;
                    FileDialog.CheckFileExists = true;
                    FileDialog.CheckPathExists = true;
                    FileDialog.Multiselect = false;
                    var _ext = _fileExtension.ToLower( );
                    FileDialog.Filter = $@"File Extension | *{_ext}";
                    FileDialog.Title = $@"Search Directories for *{_ext} files...";
                    FileDialog.InitialDirectory =
                        Environment.GetFolderPath( SpecialFolder.DesktopDirectory );

                    FileDialog.ShowDialog( );
                    var _selection = FileDialog.FileName;
                    if( !string.IsNullOrEmpty( _selection ) )
                    {
                        _selectedPath = _selection;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private protected void OnCloseButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button )
            {
                try
                {
                    DialogResult = DialogResult.Cancel;
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
    }
}