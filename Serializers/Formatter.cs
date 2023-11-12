// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-24-2023
// ******************************************************************************************
// <copyright file="Formatter.cs" company="Terry D. Eppler">
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
//   Formatter.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    public static class Formatter
    {
        /// <summary>
        /// The indent
        /// </summary>
        public static string Indent = "    ";

        /// <summary>
        /// Appends the indent.
        /// </summary>
        /// <param name="sb">The sb.</param>
        /// <param name="count">The count.</param>
        public static void AppendIndent( StringBuilder sb, int count )
        {
            for( ; count > 0; --count )
            {
                sb.Append( Indent );
            }
        }

        /// <summary>
        /// Determines whether the specified sb is escaped.
        /// </summary>
        /// <param name="sb">The sb.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///   <c>true</c> if the specified sb is escaped; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEscaped( StringBuilder sb, int index )
        {
            var _escaped = false;
            while( ( index > 0 )
                  && ( sb[ --index ] == '\\' ) )
            {
                _escaped = !_escaped;
            }

            return _escaped;
        }

        /// <summary>
        /// Pretties the print.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string PrettyPrint( string input )
        {
            var _output = new StringBuilder( input.Length * 2 );
            char? _quote = null;
            var _depth = 0;
            for( var _i = 0; _i < input.Length; ++_i )
            {
                var _ch = input[ _i ];
                switch( _ch )
                {
                    case '{':
                    case '[':
                    {
                        _output.Append( _ch );
                        if( !_quote.HasValue )
                        {
                            _output.AppendLine( );
                            AppendIndent( _output, ++_depth );
                        }

                        break;
                    }
                    case '}':
                    case ']':
                    {
                        if( _quote.HasValue )
                        {
                            _output.Append( _ch );
                        }
                        else
                        {
                            _output.AppendLine( );
                            AppendIndent( _output, --_depth );
                            _output.Append( _ch );
                        }

                        break;
                    }
                    case '"':
                    case '\'':
                    {
                        _output.Append( _ch );
                        if( _quote.HasValue )
                        {
                            if( !IsEscaped( _output, _i ) )
                            {
                                _quote = null;
                            }
                        }
                        else
                        {
                            _quote = _ch;
                        }

                        break;
                    }
                    case ',':
                    {
                        _output.Append( _ch );
                        if( !_quote.HasValue )
                        {
                            _output.AppendLine( );
                            AppendIndent( _output, _depth );
                        }

                        break;
                    }
                    case ':':
                    {
                        if( _quote.HasValue )
                        {
                            _output.Append( _ch );
                        }
                        else
                        {
                            _output.Append( " : " );
                        }

                        break;
                    }
                    default:
                    {
                        if( _quote.HasValue
                           || !char.IsWhiteSpace( _ch ) )
                        {
                            _output.Append( _ch );
                        }

                        break;
                    }
                }
            }

            return _output.ToString( );
        }
    }
}