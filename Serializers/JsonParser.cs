// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-24-2023
// ******************************************************************************************
// <copyright file="JsonParser.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   JsonParser.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    /// <summary>
    /// This class encodes and decodes JSON strings.
    /// Spec. details, see http://www.json.org/
    /// JSON uses Arrays and Objects. These correspond here
    /// to the data types ArrayList and Hashtable.
    /// All numbers are parsed to doubles.
    /// </summary>
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class JsonParser
    {
        /// <summary>
        /// The ignore case
        /// </summary>
        private readonly bool _ignorecase;

        /// <summary>
        /// The index
        /// </summary>
        private int _index;

        /// <summary>
        /// The json
        /// </summary>
        private readonly char[ ] _json;

        /// <summary>
        /// The look ahead token
        /// </summary>
        private Token _lookAheadToken = Token.None;

        /// <summary>
        /// The s
        /// </summary>
        private readonly StringBuilder _s = new StringBuilder( );

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonParser"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <param name="ignorecase">if set to <c>true</c> [ignore case].</param>
        public JsonParser( string json, bool ignorecase )
        {
            _json = json.ToCharArray( );
            _ignorecase = ignorecase;
        }

        /// <summary>
        /// Decodes this instance.
        /// </summary>
        /// <returns></returns>
        public object Decode( )
        {
            return ParseValue( );
        }

        /// <summary>
        /// Parses the object.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ErrorDialog.Exception">
        /// Expected colon at index " + _index
        /// </exception>
        private Dictionary<string, object> ParseObject( )
        {
            var _table = new Dictionary<string, object>( );
            ConsumeToken( );// {
            while( true )
            {
                switch( LookAhead( ) )
                {
                    case Token.Comma:
                    {
                        ConsumeToken( );
                        break;
                    }
                    case Token.CurlyClose:
                    {
                        ConsumeToken( );
                        return _table;
                    }
                    default:
                    {
                        // name
                        var _name = ParseString( );
                        if( _ignorecase )
                        {
                            _name = _name.ToLower( );
                        }

                        // :
                        if( NextToken( ) != Token.Colon )
                        {
                            throw new Exception( "Expected colon at index " + _index );
                        }

                        // value
                        var _value = ParseValue( );
                        _table[ _name ] = _value;
                    }

                        break;
                }
            }
        }

        /// <summary>
        /// Parses the array.
        /// </summary>
        /// <returns></returns>
        private ArrayList ParseArray( )
        {
            var _array = new ArrayList( );
            ConsumeToken( );// [
            while( true )
            {
                switch( LookAhead( ) )
                {
                    case Token.Comma:
                    {
                        ConsumeToken( );
                        break;
                    }
                    case Token.SquaredClose:
                    {
                        ConsumeToken( );
                        return _array;
                    }
                    default:
                    {
                        _array.Add( ParseValue( ) );
                    }

                        break;
                }
            }
        }

        /// <summary>
        /// Parses the value.
        /// </summary>
        /// <returns></returns>
        private object ParseValue( )
        {
            switch( LookAhead( ) )
            {
                case Token.Number:
                {
                    return ParseNumber( );
                }
                case Token.String:
                {
                    return ParseString( );
                }
                case Token.CurlyOpen:
                {
                    return ParseObject( );
                }
                case Token.SquaredOpen:
                {
                    return ParseArray( );
                }
                case Token.True:
                {
                    ConsumeToken( );
                    return true;
                }
                case Token.False:
                {
                    ConsumeToken( );
                    return false;
                }
                case Token.Null:
                {
                    ConsumeToken( );
                    return null;
                }
            }

            throw new Exception( "Unrecognized token at index" + _index );
        }

        /// <summary>
        /// Parses the string.
        /// </summary>
        /// <returns></returns>
        private string ParseString( )
        {
            ConsumeToken( );// "
            _s.Length = 0;
            var _runIndex = -1;
            while( _index < _json.Length )
            {
                var _c = _json[ _index++ ];
                if( _c == '"' )
                {
                    if( _runIndex != -1 )
                    {
                        if( _s.Length == 0 )
                        {
                            return new string( _json, _runIndex, _index - _runIndex - 1 );
                        }

                        _s.Append( _json, _runIndex, _index - _runIndex - 1 );
                    }

                    return _s.ToString( );
                }

                if( _c != '\\' )
                {
                    if( _runIndex == -1 )
                    {
                        _runIndex = _index - 1;
                    }

                    continue;
                }

                if( _index == _json.Length )
                {
                    break;
                }

                if( _runIndex != -1 )
                {
                    _s.Append( _json, _runIndex, _index - _runIndex - 1 );
                    _runIndex = -1;
                }

                switch( _json[ _index++ ] )
                {
                    case '"':
                    {
                        _s.Append( '"' );
                        break;
                    }
                    case '\\':
                    {
                        _s.Append( '\\' );
                        break;
                    }
                    case '/':
                    {
                        _s.Append( '/' );
                        break;
                    }
                    case 'b':
                    {
                        _s.Append( '\b' );
                        break;
                    }
                    case 'f':
                    {
                        _s.Append( '\f' );
                        break;
                    }
                    case 'n':
                    {
                        _s.Append( '\n' );
                        break;
                    }
                    case 'r':
                    {
                        _s.Append( '\r' );
                        break;
                    }
                    case 't':
                    {
                        _s.Append( '\t' );
                        break;
                    }
                    case 'u':
                    {
                        var _remainingLength = _json.Length - _index;
                        if( _remainingLength < 4 )
                        {
                            break;
                        }

                        // parse the 32 bit hex into an integer codepoint
                        var _codePoint = ParseUnicode( _json[ _index ], _json[ _index + 1 ],
                            _json[ _index + 2 ], _json[ _index + 3 ] );

                        _s.Append( (char)_codePoint );

                        // skip 4 chars
                        _index += 4;
                    }

                        break;
                }
            }

            throw new Exception( "Unexpectedly reached end of string" );
        }

        /// <summary>
        /// Parses the single character.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="multiplier">The multiplier.</param>
        /// <returns></returns>
        private uint ParseSingleChar( char c1, uint multiplier )
        {
            uint _p1 = 0;
            if( ( c1 >= '0' )
               && ( c1 <= '9' ) )
            {
                _p1 = (uint)( c1 - '0' ) * multiplier;
            }
            else if( ( c1 >= 'A' )
                    && ( c1 <= 'F' ) )
            {
                _p1 = (uint)( c1 - 'A' + 10 ) * multiplier;
            }
            else if( ( c1 >= 'a' )
                    && ( c1 <= 'f' ) )
            {
                _p1 = (uint)( c1 - 'a' + 10 ) * multiplier;
            }

            return _p1;
        }

        /// <summary>
        /// Parses the unicode.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="c3">The c3.</param>
        /// <param name="c4">The c4.</param>
        /// <returns></returns>
        private uint ParseUnicode( char c1, char c2, char c3, char c4 )
        {
            var _p1 = ParseSingleChar( c1, 0x1000 );
            var _p2 = ParseSingleChar( c2, 0x100 );
            var _p3 = ParseSingleChar( c3, 0x10 );
            var _p4 = ParseSingleChar( c4, 1 );
            return _p1 + _p2 + _p3 + _p4;
        }

        /// <summary>
        /// Parses the number.
        /// </summary>
        /// <returns></returns>
        private string ParseNumber( )
        {
            ConsumeToken( );

            // Need to start back one place because the first digit is also a token and would have been consumed
            var _startIndex = _index - 1;
            do
            {
                var _c = _json[ _index ];
                if( ( ( _c >= '0' ) && ( _c <= '9' ) )
                   || ( _c == '.' )
                   || ( _c == '-' )
                   || ( _c == '+' )
                   || ( _c == 'e' )
                   || ( _c == 'E' ) )
                {
                    if( ++_index == _json.Length )
                    {
                        throw new Exception( "Unexpected end of string whilst parsing number" );
                    }

                    continue;
                }

                break;
            }
            while( true );

            return new string( _json, _startIndex, _index - _startIndex );
        }

        /// <summary>
        /// Looks the ahead.
        /// </summary>
        /// <returns></returns>
        private Token LookAhead( )
        {
            if( _lookAheadToken != Token.None )
            {
                return _lookAheadToken;
            }

            return _lookAheadToken = NextTokenCore( );
        }

        /// <summary>
        /// Consumes the token.
        /// </summary>
        private void ConsumeToken( )
        {
            _lookAheadToken = Token.None;
        }

        /// <summary>
        /// Nexts the token.
        /// </summary>
        /// <returns></returns>
        private Token NextToken( )
        {
            var _result = _lookAheadToken != Token.None
                ? _lookAheadToken
                : NextTokenCore( );

            _lookAheadToken = Token.None;
            return _result;
        }

        /// <summary>
        /// Nexts the token core.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ErrorDialog.Exception">
        /// Reached end of string unexpectedly
        /// or
        /// Could not find token at index " + --_index
        /// </exception>
        private Token NextTokenCore( )
        {
            char _c;

            // Skip past whitespace
            do
            {
                _c = _json[ _index ];
                if( _c > ' ' )
                {
                    break;
                }

                if( ( _c != ' ' )
                   && ( _c != '\t' )
                   && ( _c != '\n' )
                   && ( _c != '\r' ) )
                {
                    break;
                }
            }
            while( ++_index < _json.Length );

            if( _index == _json.Length )
            {
                throw new Exception( "Reached end of string unexpectedly" );
            }

            _c = _json[ _index ];
            _index++;

            //if (c >= '0' && c <= '9')
            //    return Token.Number;
            switch( _c )
            {
                case '{':
                {
                    return Token.CurlyOpen;
                }
                case '}':
                {
                    return Token.CurlyClose;
                }
                case '[':
                {
                    return Token.SquaredOpen;
                }
                case ']':
                {
                    return Token.SquaredClose;
                }
                case ',':
                {
                    return Token.Comma;
                }
                case '"':
                {
                    return Token.String;
                }
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '-':
                case '+':
                case '.':
                {
                    return Token.Number;
                }
                case ':':
                {
                    return Token.Colon;
                }
                case 'f':
                {
                    if( ( _json.Length - _index >= 4 )
                       && ( _json[ _index + 0 ] == 'a' )
                       && ( _json[ _index + 1 ] == 'l' )
                       && ( _json[ _index + 2 ] == 's' )
                       && ( _json[ _index + 3 ] == 'e' ) )
                    {
                        _index += 4;
                        return Token.False;
                    }

                    break;
                }
                case 't':
                {
                    if( ( _json.Length - _index >= 3 )
                       && ( _json[ _index + 0 ] == 'r' )
                       && ( _json[ _index + 1 ] == 'u' )
                       && ( _json[ _index + 2 ] == 'e' ) )
                    {
                        _index += 3;
                        return Token.True;
                    }

                    break;
                }
                case 'n':
                {
                    if( ( _json.Length - _index >= 3 )
                       && ( _json[ _index + 0 ] == 'u' )
                       && ( _json[ _index + 1 ] == 'l' )
                       && ( _json[ _index + 2 ] == 'l' ) )
                    {
                        _index += 3;
                        return Token.Null;
                    }

                    break;
                }
            }

            throw new Exception( "Could not find token at index " + --_index );
        }
    }
}