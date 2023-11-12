// ******************************************************************************************
//     Assembly:                BabyBrowser
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="ThrowIf.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the 
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  $CURRENT_YEAR$  Terry Eppler
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
//   ThrowIf.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public static class ThrowIf
    {
        /// <summary>
        /// Determines whether the specified string
        /// argument is null or empty.
        /// </summary>
        /// <param name="argument">
        /// The string argument.
        /// </param>
        /// <param name = "paramName" >
        /// The name of the string argument.
        /// </param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void NullOrEmpty( string argument, string paramName )
        {
            if( string.IsNullOrEmpty( argument ) )
            {
                var _message = @$"The string '{paramName}' is null or empty!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// Nulls the specified argument.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void Null( object argument, string paramName )
        {
            if( argument == null )
            {
                var _message = @$"The object '{paramName}' is null!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// Nulls the specified argument.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void NoItems( IDictionary<string, object> argument, string paramName )
        {
            if( argument.Any( ) != true )
            {
                var _message = @$"The dictionary '{paramName}' is null or empty!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// Nulls the specified argument.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void NullOrEmpty( Color argument, string paramName )
        {
            if( argument.IsEmpty )
            {
                var _message = @$"The color '{paramName}' is empty or uninitialized!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// NoElements throws exception if 'argument' has no elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argument">The argument.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void NoElements<T>( IEnumerable<T> argument, string paramName )
        {
            if( argument.Any( ) != true )
            {
                var _message = @$"The enumerable '{paramName}' is empty!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// Noes the data.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void NoData( IListSource argument, string paramName )
        {
            if( argument == null )
            {
                var _message = @$"The data source '{paramName}' is null!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// Nulls the specified argument.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void NotFile( string argument, string paramName )
        {
            if( !File.Exists( argument ) )
            {
                var _message = @$"The file '{paramName}' does not exist!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// Determines whether the specified argument is negative.
        /// </summary>
        /// <param name="argument">
        /// The argument.
        /// </param>
        /// <param name = "paramName" >
        /// The argument's name.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// </exception>
        public static void Negative( int argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"The value '{paramName}' is negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Determines whether the specified argument is negative.
        /// </summary>
        /// <param name="argument">
        /// The argument.
        /// </param>
        /// <param name = "paramName" >
        /// The argument's name.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// </exception>
        public static void Negative( double argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"The value '{paramName}' is negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Throws out of range exception if argument is less than zero
        /// </summary>
        /// <param name="argument">
        /// The argument.</param>
        /// <param name="paramName">
        /// Name of the parameter.
        /// </param>
        /// <returns>
        /// Throws Out of Range Exception
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void NegativeOrZero( int argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"The value '{paramName}' is zero or negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Throws out of range exception if argument is less than zero
        /// </summary>
        /// <param name="argument">
        /// The argument.</param>
        /// <param name="paramName">
        /// Name of the parameter.
        /// </param>
        /// <returns>
        /// Throws Out of Range Exception
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">paramName, _message</exception>
        public static void NegativeOrZero( double argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"Value '{paramName}' is zero or negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }
    }
}
