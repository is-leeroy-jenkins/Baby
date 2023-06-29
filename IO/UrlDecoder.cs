
using System;

namespace BudgetBrowser.IO
{
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class UrlDecoder
    {
        /// <summary>
        /// The buffer size
        /// </summary>
        private int _bufferSize;

        /// <summary>
        /// The byte buffer
        /// </summary>
        private byte[ ] _byteBuffer;

        /// <summary>
        /// The character buffer
        /// </summary>
        private char[ ] _charBuffer;

        /// <summary>
        /// The encoding
        /// </summary>
        private Encoding _encoding;

        /// <summary>
        /// The number bytes
        /// </summary>
        private int _numBytes;

        /// <summary>
        /// The number chars
        /// </summary>
        private int _numChars;

        /// <summary>
        /// Gets or sets a value indicating whether [for file paths].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [for file paths]; otherwise, <c>false</c>.
        /// </value>
        public bool ForFilePaths { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlDecoder"/> class.
        /// </summary>
        /// <param name="bufferSize">Size of the buffer.</param>
        /// <param name="encoding">The encoding.</param>
        public UrlDecoder( int bufferSize, Encoding encoding )
        {
            _bufferSize = bufferSize;
            _encoding = encoding;
            _charBuffer = new char[ bufferSize ];
        }

        /// <summary>
        /// Flushes the bytes.
        /// </summary>
        /// <param name="checkChar">if set to <c>true</c> [check character].</param>
        public void FlushBytes( bool checkChar = false )
        {
            if( _numBytes > 0 )
            {
                if( checkChar && ForFilePaths )
                {
                    var _newChars = _encoding.GetChars( _byteBuffer, 0, _numBytes );
                    _numBytes = 0;
                    foreach( var _ch in _newChars )
                    {
                        AddChar( _ch );
                    }
                }
                else
                {
                    _numChars += _encoding.GetChars( _byteBuffer, 0, _numBytes, _charBuffer,
                        _numChars );

                    _numBytes = 0;
                }
            }
        }

        /// <summary>
        /// Adds the byte.
        /// </summary>
        /// <param name="b">The b.</param>
        public void AddByte( byte b )
        {
            if( _byteBuffer == null )
            {
                _byteBuffer = new byte[ _bufferSize ];
            }

            _byteBuffer[ _numBytes++ ] = b;
        }

        /// <summary>
        /// Adds the character.
        /// </summary>
        /// <param name="ch">The ch.</param>
        /// <param name="checkChar">if set to <c>true</c> [check character].</param>
        public void AddChar( char ch, bool checkChar = false )
        {
            if( _numBytes > 0 )
            {
                FlushBytes( );
            }

            if( checkChar && ForFilePaths )
            {
                if( !ch.SupportedInFilePath( ) )
                {
                    AddChar( '_' );
                    AddString( "0x" + ( (int)ch ).ToString( "X" ) );
                    AddChar( '_' );
                    return;
                }
            }

            _charBuffer[ _numChars++ ] = ch;
        }

        /// <summary>
        /// Adds the string.
        /// </summary>
        /// <param name="str">The string.</param>
        public void AddString( string str )
        {
            if( _numBytes > 0 )
            {
                FlushBytes( );
            }

            foreach( var _ch in str )
            {
                _charBuffer[ _numChars++ ] = _ch;
            }
        }

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <returns></returns>
        public string GetString( )
        {
            if( _numBytes > 0 )
            {
                FlushBytes( );
            }

            return _numChars > 0
                ? new string( _charBuffer, 0, _numChars )
                : string.Empty;
        }
    }
}
