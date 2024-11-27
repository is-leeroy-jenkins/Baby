// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="ThrowIf.cs" company="Terry D. Eppler">
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
//   ThrowIf.cs
// </summary>
// ******************************************************************************************

namespace Bubba
{
    using CefSharp;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using CefSharp.Wpf;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertTypeCheckPatternToNullCheck" ) ]
    public static class ThrowIf
    {
        /// <summary>
        /// Determines whether the specified string argument is null or empty.
        /// </summary>
        /// <param name="argument"> The string argument. </param>
        /// <param name="paramName"> The name of the string argument. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NullOrEmpty( string argument, string paramName )
        {
            if( string.IsNullOrEmpty( argument ) )
            {
                var _message = @$"The string '{paramName}' is null or empty!";
                throw new ArgumentNullException( _message );
            }
        }

        /// <summary> Nulls the specified argument. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void Null( object argument, string paramName )
        {
            switch( argument )
            {
                case string _args:
                {
                    if( string.IsNullOrEmpty( _args ) )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Action _action:
                {
                    if( _action == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case ChromiumWebBrowser _chromiumWebBrowser:
                {
                    if( _chromiumWebBrowser == null )
                    {
                        var _message = @$"The ChromiumWebBrowser '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case BrowserTabItem _browserTabItem:
                {
                    if( _browserTabItem == null )
                    {
                        var _message = @$"The BrowserTabStripItem '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DownloadItem _downloadItem:
                {
                    if( _downloadItem == null )
                    {
                        var _message = @$"The DownloadItem '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Form _form:
                {
                    if( _form == null )
                    {
                        var _message = @$"The Form '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Control _control:
                {
                    if( _control == null )
                    {
                        var _message = @$"The Control '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case EventArgs _eventArgs:
                {
                    if( _eventArgs == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case object _args:
                {
                    if( _args == null )
                    {
                        var _message = @$"The object '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// Empty throws exception if 'argument' is null.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.ArgumentNullException">ArgumentNullException</exception>
        public static void Empty( object argument, string paramName )
        {
            switch( argument )
            {
                case string _args:
                {
                    if( string.IsNullOrEmpty( _args ) )
                    {
                        var _message = @$"The '{paramName}' is empty!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case IListSource _listSource:
                {
                    if( _listSource == null )
                    {
                        var _message = @$"The IListSource '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }

                    break;
                }
                case IBindingList _bindingList:
                {
                    if( _bindingList == null )
                    {
                        var _message = @$"The IBindingList '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }

                    break;
                }
                case IEnumerable<string> _list:
                {
                    if( _list == null
                        || _list.Any( ) == false )
                    {
                        var _message = @$"The IEnumerable<string> '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }

                    break;
                }
                case IEnumerable<byte> _data:
                {
                    if( _data == null
                        || _data.Any( ) == false )
                    {
                        var _message = @$"The IEnumerable<string> '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }

                    break;
                }
                case IEnumerable<DataRow> _rows:
                {
                    if( _rows == null
                        || _rows.Any( ) == false )
                    {
                        var _message = @$"The IEnumerable<DataRow> '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }

                    break;
                }
                case ICollection _collection:
                {
                    if( _collection == null
                        || _collection.Count > 0 )
                    {
                        var _message = @$"The ICollection '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }

                    break;
                }
                case IDictionary<string, object> _dict:
                {
                    if( _dict == null
                        || _dict.Keys.Any( ) == false )
                    {
                        var _message = @$"The IDictionary<string, object> '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }

                    break;
                }
                case IDictionary<string, string> _nvp:
                {
                    if( _nvp == null
                        || _nvp.Keys.Any( ) == false )
                    {
                        var _message = @$"The IDictionary<string, string> '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }

                    break;
                }
                default:
                {
                    if( argument == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
            }
        }

        /// <summary> Nulls the specified argument. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NullOrEmpty( Color argument, string paramName )
        {
            if( argument.IsEmpty )
            {
                var _message = @$"The Color '{paramName}' is empty or uninitialized!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> None throws exception if 'argument' has no elements. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NoElements<T>( IEnumerable<T> argument, string paramName )
        {
            if( argument.Any( ) != true )
            {
                var _message = @$"The IEnumerable<T> '{paramName}' is empty!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> Noes the data. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NoData( IListSource argument, string paramName )
        {
            if( argument == null )
            {
                var _message = @$"The data source '{paramName}' is null!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> Nulls the specified argument. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NotFile( string argument, string paramName )
        {
            if( !File.Exists( argument ) )
            {
                var _message = @$"The file '{paramName}' does not exist!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> Throws exception if 'argument' </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NotEnum( Enum argument, string paramName )
        {
            if( argument.GetType( ) != typeof( Enum ) )
            {
                var _message = @$"Enum '{paramName}' is invalid!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> </summary>
        /// <param name="argument"> </param>
        /// <param name="paramName"> </param>
        /// <exception cref="ArgumentNullException"> </exception>
        public static void NotDateTime( DateTime argument, string paramName )
        {
            if( argument.GetType( ) != typeof( DateTime ) )
            {
                var _message = @$"DateTime '{paramName}' is invalid!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="argument"> </param>
        /// <param name="paramName"> </param>
        /// <exception cref="ArgumentNullException"> </exception>
        public static void NotDateOnly( DateOnly argument, string paramName )
        {
            if( argument.GetType( ) != typeof( DateOnly ) )
            {
                var _message = @$"DateOnly '{paramName}' is invalid!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// Determines whether the specified argument is negative.
        /// </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> The argument's name. </param>
        /// <exception cref="System.ArgumentOutOfRangeException"> </exception>
        public static void Negative( int argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"Numeric value '{paramName}' is negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Determines whether the specified argument is negative.
        /// </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> The argument's name. </param>
        /// <exception cref="System.ArgumentOutOfRangeException"> </exception>
        public static void Negative( double argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"'{paramName}' is negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Throws out of range exception if argument is less than zero
        /// </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <returns> Throws Out of Range Exception </returns>
        /// <exception cref="ArgumentOutOfRangeException"> </exception>
        public static void NegativeOrZero( int argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"'{paramName}' is zero or negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Throws out of range exception if argument is less than zero
        /// </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <returns> Throws Out of Range Exception </returns>
        /// <exception cref="ArgumentOutOfRangeException"> paramName, _message </exception>
        public static void NegativeOrZero( double argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"'{paramName}' is zero or negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }
    }
}