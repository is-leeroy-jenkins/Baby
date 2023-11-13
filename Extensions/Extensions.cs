// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-04-2023
// ******************************************************************************************
// <copyright file="Extensions.cs" company="Terry D. Eppler">
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
//   Extensions.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public static class Extensions
    {
        /// <summary>
        /// Converts to log string.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static string ToLogString( this Exception ex, string message )
        {
            try
            {
                var _builder = new StringBuilder( );
                if( !string.IsNullOrEmpty( message ) )
                {
                    _builder.Append( message );
                    _builder.Append( Environment.NewLine );
                }

                if( ex != null )
                {
                    var _exception = ex;
                    _builder.Append( "Exception:" );
                    _builder.Append( Environment.NewLine );
                    while( _exception != null )
                    {
                        _builder.Append( _exception.Message );
                        _builder.Append( Environment.NewLine );
                        _exception = _exception.InnerException;
                    }

                    if( ex.Data != null )
                    {
                        foreach( var _i in ex.Data )
                        {
                            _builder.Append( "Data :" );
                            _builder.Append( _i );
                            _builder.Append( Environment.NewLine );
                        }
                    }

                    if( ex.StackTrace != null )
                    {
                        _builder.Append( "Stack Trace:" );
                        _builder.Append( Environment.NewLine );
                        _builder.Append( ex.StackTrace );
                        _builder.Append( Environment.NewLine );
                    }

                    if( ex.Source != null )
                    {
                        _builder.Append( "Error Source:" );
                        _builder.Append( Environment.NewLine );
                        _builder.Append( ex.Source );
                        _builder.Append( Environment.NewLine );
                    }

                    if( ex.TargetSite != null )
                    {
                        _builder.Append( "Target Site:" );
                        _builder.Append( Environment.NewLine );
                        _builder.Append( ex.TargetSite );
                        _builder.Append( Environment.NewLine );
                    }

                    var _baseException = ex.GetBaseException( );
                    if( _baseException != null )
                    {
                        _builder.Append( "Base Exception:" );
                        _builder.Append( Environment.NewLine );
                        _builder.Append( ex.GetBaseException( ) );
                    }
                }

                return _builder.ToString( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> The SplitPascal </summary>
        /// <returns>
        /// The
        /// <see cref="string"/>
        /// </returns>
        /// <param name="text"> The text. </param>
        /// <returns> </returns>
        public static string SplitPascal( this string text )
        {
            try
            {
                if( !string.IsNullOrEmpty( text )
                   && ( text.Length > 4 ) )
                {
                    var _pascal = Regex.Replace( text, "([A-Z])", " $1", RegexOptions.Compiled )
                        ?.Trim( );

                    if( _pascal.StartsWith( "Rpio " ) )
                    {
                        return _pascal?.Replace( "Rpio ", "RPIO " );
                    }
                    else if( _pascal.StartsWith( "Npm " ) )
                    {
                        return _pascal?.Replace( "Npm ", "NPM " );
                    }
                    else if( _pascal.StartsWith( "Boc " ) )
                    {
                        return _pascal?.Replace( "Boc ", "BOC " );
                    }
                    else if( _pascal.StartsWith( "Foc " ) )
                    {
                        return _pascal?.Replace( "Foc ", "FOC " );
                    }
                    else if( _pascal.StartsWith( "Org " ) )
                    {
                        return _pascal?.Replace( "Org ", "ORG " );
                    }
                    else if( _pascal.StartsWith( "Omb " ) )
                    {
                        return _pascal?.Replace( "Omb ", "OMB " );
                    }
                    else if( _pascal.StartsWith( "Prc " ) )
                    {
                        return _pascal?.Replace( "Prc ", "PRC " );
                    }
                    else if( _pascal.StartsWith( "Ah " ) )
                    {
                        return _pascal?.Replace( "Ah ", "AH " );
                    }
                    else if( _pascal.StartsWith( "Rc " ) )
                    {
                        return _pascal?.Replace( "Rc ", "RC " );
                    }
                    else if( _pascal.EndsWith( " Id" ) )
                    {
                        return _pascal?.Replace( " Id", " ID" );
                    }
                    else
                    {
                        return _pascal;
                    }
                }

                return text;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}