// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-29-2023
// ******************************************************************************************
// <copyright file="WebUtils.cs" company="Terry D. Eppler">
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
//   WebUtils.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using CefSharp;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "ReplaceSubstringWithRangeIndexer" ) ]
    [ SuppressMessage( "ReSharper", "ExpressionIsAlwaysNull" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public static class WebUtils
    {
        /// <summary>
        /// Determines whether the specified tb is focused.
        /// </summary>
        /// <param name="textBox">The tb.</param>
        /// <returns>
        ///   <c>true</c> if the specified tb is focused; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsFocused( System.Windows.Forms.TextBox textBox )
        {
            return textBox.Focused;
        }

        /// <summary>
        /// Determines whether the specified tb is focused.
        /// </summary>
        /// <param name="textBox">The tb.</param>
        /// <returns>
        ///   <c>true</c> if the specified tb is focused; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsFocused( TextBox textBox )
        {
            return textBox.Focused;
        }

        /// <summary>
        /// Adds the hot key.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="function">The function.</param>
        /// <param name="key">The key.</param>
        /// <param name="ctrl">if set to <c>true</c> [control].</param>
        /// <param name="shift">if set to <c>true</c> [shift].</param>
        /// <param name="alt">if set to <c>true</c> [alt].</param>
        public static void AddHotKey( Form form, Action function, Keys key, bool ctrl = false,
            bool shift = false, bool alt = false )
        {
            form.KeyPreview = true;
            form.KeyDown += delegate( object sender, KeyEventArgs e )
            {
                if( e.IsHotKey( key, ctrl, shift, alt ) )
                {
                    function( );
                }
            };
        }

        /// <summary>
        /// Determines whether [is fully selected] [the specified tb].
        /// </summary>
        /// <param name="textBox">The tb.</param>
        /// <returns>
        /// <c>true</c> if [is fully selected]
        /// [the specified tb]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsFullySelected( System.Windows.Forms.TextBox textBox )
        {
            return textBox.SelectionLength == textBox.Text.Length;
        }

        /// <summary>
        /// Determines whether [is fully selected] [the specified tb].
        /// </summary>
        /// <param name="textBox">The tb.</param>
        /// <returns>
        /// <c>true</c> if [is fully selected]
        /// [the specified tb]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsFullySelected( TextBox textBox )
        {
            return textBox.SelectionLength == textBox.Text.Length;
        }

        /// <summary>
        /// Determines whether the specified tb has selection.
        /// </summary>
        /// <param name="textBox">The tb.</param>
        /// <returns>
        ///   <c>true</c> if the specified tb has selection; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasSelection( System.Windows.Forms.TextBox textBox )
        {
            return textBox.SelectionLength > 0;
        }

        /// <summary>
        /// Determines whether the specified tb has selection.
        /// </summary>
        /// <param name="textBox">The tb.</param>
        /// <returns>
        ///   <c>true</c> if the specified tb has selection; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasSelection( TextBox textBox )
        {
            return textBox.SelectionLength > 0;
        }

        /// <summary>
        /// Checks if file path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static bool CheckIfFilePath( this string path )
        {
            if( path.Length >= 3 )
            {
                if( path[ 1 ] == ':' )
                {
                    if( path[ 2 ] == '\\' )
                    {
                        if( Char.IsLetter( path[ 0 ] ) )
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if file path2.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static bool CheckIfFilePath2( this string path )
        {
            if( path.Length >= 3 )
            {
                if( path[ 1 ] == ':' )
                {
                    if( path[ 2 ] == '/' )
                    {
                        if( Char.IsLetter( path[ 0 ] ) )
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the after.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="find">The find.</param>
        /// <param name="startAt">The start at.</param>
        /// <param name="returnAll">if set to <c>true</c> [return all].</param>
        /// <param name="forward">if set to <c>true</c> [forward].</param>
        /// <returns></returns>
        public static string GetAfter( this string text, string find, int startAt = 0,
            bool returnAll = false, bool forward = true )
        {
            if( text == null )
            {
                return returnAll
                    ? text
                    : "";
            }

            var _idx = !forward
                ? text.LastIndexOf( find, text.Length - startAt, StringComparison.Ordinal )
                : text.IndexOf( find, startAt, StringComparison.Ordinal );

            if( _idx == -1 )
            {
                return returnAll
                    ? text
                    : "";
            }

            _idx += find.Length;
            return text.Substring( _idx );
        }

        /// <summary>
        /// Gets the after last.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="find">The find.</param>
        /// <param name="returnAll">if set to <c>true</c> [return all].</param>
        /// <returns></returns>
        public static string GetAfterLast( this string text, string find, bool returnAll = false )
        {
            var _index = text.LastIndexOf( find, StringComparison.Ordinal );
            if( _index == -1 )
            {
                return returnAll
                    ? text
                    : "";
            }

            _index += find.Length;
            return text.Substring( _index );
        }

        /// <summary>
        /// Supporteds the in file path.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public static bool SupportedInFilePath( this char c )
        {
            return !( ( c == '?' )
                || ( c == '\'' )
                || ( c == '\"' )
                || ( c == '/' )
                || ( c == '\\' )
                || ( c == ';' )
                || ( c == ':' )
                || ( c == '&' )
                || ( c == '*' )
                || ( c == '<' )
                || ( c == '>' )
                || ( c == '|' )
                || ( c == '{' )
                || ( c == '}' )
                || ( c == '[' )
                || ( c == ']' )
                || ( c == '(' )
                || ( c == ')' ) );
        }

        /// <summary>
        /// Changes the path slash.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="slash">The slash.</param>
        /// <returns></returns>
        public static string ChangePathSlash( this string filePath, string slash )
        {
            return slash switch
            {
                "\\" when filePath.Contains( '/' ) => filePath.Replace( "/", "\\" ),
                "/" when filePath.Contains( '\\' ) => filePath.Replace( "\\", "/" ),
                var _ => filePath
            };
        }

        /// <summary>
        /// Files the URL to path.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string FileUrlToPath( this string url )
        {
            return url.RemovePrefix( "file:///" ).ChangePathSlash( @"\" ).DecodeUrlForFilePath( );
        }

        /// <summary>
        /// Files the not exists.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static bool FileNotExists( this string path )
        {
            return !File.Exists( path );
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns></returns>
        public static string ConvertToString( this object o )
        {
            return o as string;
        }

        /// <summary>
        /// Checks if valid.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="trimAndCheck">if set to <c>true</c> [trim and check].</param>
        /// <returns></returns>
        public static bool CheckIfValid( this string text, bool trimAndCheck = false )
        {
            return !string.IsNullOrEmpty( text );
        }

        /// <summary>
        /// Invokes the on parent.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="method">The method.</param>
        public static void InvokeOnParent( this Control control, MethodInvoker method )
        {
            var _parent = control.Parent ?? control;
            if( _parent.IsHandleCreated )
            {
                _parent.Invoke( method );
            }
        }

        /// <summary>
        /// Determines whether [is hot key] [the specified key].
        /// </summary>
        /// <param name="eventData">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        /// <param name="key">The key.</param>
        /// <param name="ctrl">if set to <c>true</c> [control].</param>
        /// <param name="shift">if set to <c>true</c> [shift].</param>
        /// <param name="alt">if set to <c>true</c> [alt].</param>
        /// <returns>
        ///   <c>true</c> if [is hot key] [the specified key]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsHotKey( this KeyEventArgs eventData, Keys key, bool ctrl = false,
            bool shift = false, bool alt = false )
        {
            return ( eventData.KeyCode == key )
                && ( eventData.Control == ctrl )
                && ( eventData.Shift == shift )
                && ( eventData.Alt == alt );
        }

        /// <summary>
        /// Converts to cefstate.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <returns></returns>
        public static CefState ToCefState( this bool value )
        {
            return value
                ? CefState.Enabled
                : CefState.Disabled;
        }

        /// <summary>
        /// Determines whether [is bitMask on] [the specified bitMask].
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="bitMask">The bitMask.</param>
        /// <returns>
        ///   <c>true</c> if [is bitMask on] [the specified bitMask]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBitMaskOn( this int num, int bitMask )
        {
            return ( num & bitMask ) != 0;
        }

        /// <summary>
        /// Beginses the with.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="beginsWith">The begins with.</param>
        /// <param name="caseSensitive">if set to <c>true</c> [case sensitive].</param>
        /// <returns></returns>
        public static bool BeginsWith( this string str, string beginsWith,
            bool caseSensitive = true )
        {
            if( beginsWith.Length > str.Length )
            {
                return false;
            }

            if( beginsWith.Length == str.Length )
            {
                return String.Equals( beginsWith, str, caseSensitive
                    ? StringComparison.Ordinal
                    : StringComparison.OrdinalIgnoreCase );
            }

            return str.LastIndexOf( beginsWith, beginsWith.Length - 1, caseSensitive
                    ? StringComparison.Ordinal
                    : StringComparison.OrdinalIgnoreCase )
                == 0;
        }

        /// <summary>
        /// Removes the prefix.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="prefix">The prefix.</param>
        /// <param name="caseSensitive">if set to <c>true</c> [case sensitive].</param>
        /// <returns></returns>
        public static string RemovePrefix( this string str, string prefix,
            bool caseSensitive = true )
        {
            return ( str.Length >= prefix.Length ) && str.BeginsWith( prefix, caseSensitive )
                ? str.Substring( prefix.Length )
                : str;
        }
    }
}