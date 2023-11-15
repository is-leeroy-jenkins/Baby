// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        11-15-2023
// ******************************************************************************************
// <copyright file="JsonSerializer.cs" company="Terry D. Eppler">
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
//   JsonSerializer.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "InlineOutVariableDeclaration" ) ]
    public class JsonSerializer
    {
        /// <summary>
        /// The current depth
        /// </summary>
        private int _currentDepth;

        /// <summary>
        /// The global types
        /// </summary>
        private readonly Dictionary<string, int> _globalTypes = new Dictionary<string, int>( );

        /// <summary>
        /// The maximum depth
        /// </summary>
        private readonly int _maxDepth = 10;

        /// <summary>
        /// The output
        /// </summary>
        private readonly StringBuilder _output = new StringBuilder( );

        /// <summary>
        /// The parameters
        /// </summary>
        private readonly JsonParameters _params;

        /// <summary>
        /// The types written
        /// </summary>
        private bool _typesWritten;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSerializer"/> class.
        /// </summary>
        /// <param name="param">The parameter.</param>
        public JsonSerializer( JsonParameters param )
        {
            _params = param;
        }

        /// <summary>
        /// Converts to json.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public string ConvertToJson( object obj )
        {
            WriteValue( obj );
            var _str = "";
            if( _params.UsingGlobalTypes )
            {
                var _sb = new StringBuilder( );
                _sb.Append( "\"$types\":{" );
                var _pendingSeparator = false;
                foreach( var _kv in _globalTypes )
                {
                    if( _pendingSeparator )
                    {
                        _sb.Append( ',' );
                    }

                    _pendingSeparator = true;
                    _sb.Append( "\"" );
                    _sb.Append( _kv.Key );
                    _sb.Append( "\":\"" );
                    _sb.Append( _kv.Value );
                    _sb.Append( "\"" );
                }

                _sb.Append( "}," );
                _str = _output.Replace( "$types$", _sb.ToString( ) ).ToString( );
            }
            else
            {
                _str = _output.ToString( );
            }

            return _str;
        }

        /// <summary>
        /// Writes the value.
        /// </summary>
        /// <param name="obj">The object.</param>
        private void WriteValue( object obj )
        {
            if( ( obj == null )
               || obj is DBNull )
            {
                _output.Append( "null" );
            }
            else if( obj is string
                    || obj is char )
            {
                WriteString( obj.ToString( ) );
            }
            else if( obj is Guid )
            {
                WriteGuid( (Guid)obj );
            }
            else if( obj is bool )
            {
                _output.Append( (bool)obj
                    ? "true"
                    : "false" );// conform to standard
            }
            else if( obj is int
                    || obj is long
                    || obj is double
                    || obj is decimal
                    || obj is float
                    || obj is byte
                    || obj is short
                    || obj is sbyte
                    || obj is ushort
                    || obj is uint
                    || obj is ulong )
            {
                _output.Append( ( (IConvertible)obj ).ToString( NumberFormatInfo.InvariantInfo ) );
            }
            else if( obj is DateTime )
            {
                WriteDateTime( (DateTime)obj );
            }
            else if( obj is IDictionary
                    && obj.GetType( ).IsGenericType
                    && ( obj.GetType( ).GetGenericArguments( )[ 0 ] == typeof( string ) ) )
            {
                WriteStringDictionary( (IDictionary)obj );
            }
            else if( obj is IDictionary )
            {
                WriteDictionary( (IDictionary)obj );
            }
            else if( obj is DataSet )
            {
                WriteDataset( (DataSet)obj );
            }
            else if( obj is DataTable )
            {
                WriteDataTable( (DataTable)obj );
            }
            else if( obj is byte[ ] )
            {
                WriteBytes( (byte[ ])obj );
            }
            else if( obj is Array
                    || obj is IList
                    || obj is ICollection )
            {
                WriteArray( (IEnumerable)obj );
            }
            else if( obj is Enum )
            {
                WriteEnum( (Enum)obj );
            }
            else
            {
                WriteObject( obj );
            }
        }

        /// <summary>
        /// Writes the enum.
        /// </summary>
        /// <param name="e">The e.</param>
        private void WriteEnum( Enum e )
        {
            // TODO : optimize enum write
            WriteStringFast( e.ToString( ) );
        }

        /// <summary>
        /// Writes the unique identifier.
        /// </summary>
        /// <param name="g">The g.</param>
        private void WriteGuid( Guid g )
        {
            if( _params.UseFastGuid == false )
            {
                WriteStringFast( g.ToString( ) );
            }
            else
            {
                WriteBytes( g.ToByteArray( ) );
            }
        }

        /// <summary>
        /// Writes the bytes.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        private void WriteBytes( byte[ ] bytes )
        {
            WriteStringFast( Convert.ToBase64String( bytes, 0, bytes.Length,
                Base64FormattingOptions.None ) );
        }

        /// <summary>
        /// Writes the date time.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        private void WriteDateTime( DateTime dateTime )
        {
            // datetime format standard : yyyy-MM-dd HH:mm:ss
            var _dt = dateTime;
            if( _params.UseUtcDateTime )
            {
                _dt = dateTime.ToUniversalTime( );
            }

            _output.Append( "\"" );
            _output.Append( _dt.Year.ToString( "0000", NumberFormatInfo.InvariantInfo ) );
            _output.Append( "-" );
            _output.Append( _dt.Month.ToString( "00", NumberFormatInfo.InvariantInfo ) );
            _output.Append( "-" );
            _output.Append( _dt.Day.ToString( "00", NumberFormatInfo.InvariantInfo ) );
            _output.Append( " " );
            _output.Append( _dt.Hour.ToString( "00", NumberFormatInfo.InvariantInfo ) );
            _output.Append( ":" );
            _output.Append( _dt.Minute.ToString( "00", NumberFormatInfo.InvariantInfo ) );
            _output.Append( ":" );
            _output.Append( _dt.Second.ToString( "00", NumberFormatInfo.InvariantInfo ) );
            if( _params.UseUtcDateTime )
            {
                _output.Append( "Z" );
            }

            _output.Append( "\"" );
        }

        /// <summary>
        /// Gets the schema.
        /// </summary>
        /// <param name="ds">The ds.</param>
        /// <returns></returns>
        private DataSchema GetSchema( DataTable ds )
        {
            if( ds == null )
            {
                return null;
            }

            var _m = new DataSchema
            {
                Info = new List<string>( ),
                Name = ds.TableName
            };

            foreach( DataColumn _c in ds.Columns )
            {
                _m.Info.Add( ds.TableName );
                _m.Info.Add( _c.ColumnName );
                _m.Info.Add( _c.DataType.ToString( ) );
            }

            // FEATURE : serialize relations and constraints here
            return _m;
        }

        /// <summary>
        /// Gets the schema.
        /// </summary>
        /// <param name="ds">The ds.</param>
        /// <returns></returns>
        private DataSchema GetSchema( DataSet ds )
        {
            if( ds == null )
            {
                return null;
            }

            var _m = new DataSchema
            {
                Info = new List<string>( ),
                Name = ds.DataSetName
            };

            foreach( DataTable _t in ds.Tables )
            {
                foreach( DataColumn _c in _t.Columns )
                {
                    _m.Info.Add( _t.TableName );
                    _m.Info.Add( _c.ColumnName );
                    _m.Info.Add( _c.DataType.ToString( ) );
                }
            }

            // FEATURE : serialize relations and constraints here
            return _m;
        }

        /// <summary>
        /// Gets the XML schema.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <returns></returns>
        private string GetXmlSchema( DataTable dt )
        {
            using( var _writer = new StringWriter( ) )
            {
                dt.WriteXmlSchema( _writer );
                return dt.ToString( );
            }
        }

        /// <summary>
        /// Writes the dataset.
        /// </summary>
        /// <param name="ds">The ds.</param>
        private void WriteDataset( DataSet ds )
        {
            _output.Append( '{' );
            if( _params.UseExtensions )
            {
                WritePair( "$schema", _params.UseOptimizedDatasetSchema
                    ? GetSchema( ds )
                    : ds.GetXmlSchema( ) );

                _output.Append( ',' );
            }

            var _tablesep = false;
            foreach( DataTable _table in ds.Tables )
            {
                if( _tablesep )
                {
                    _output.Append( "," );
                }

                _tablesep = true;
                WriteDataTableData( _table );
            }

            // end dataset
            _output.Append( '}' );
        }

        /// <summary>
        /// Writes the data table data.
        /// </summary>
        /// <param name="table">The table.</param>
        private void WriteDataTableData( DataTable table )
        {
            _output.Append( '\"' );
            _output.Append( table.TableName );
            _output.Append( "\":[" );
            var _cols = table.Columns;
            var _rowseparator = false;
            foreach( DataRow _row in table.Rows )
            {
                if( _rowseparator )
                {
                    _output.Append( "," );
                }

                _rowseparator = true;
                _output.Append( '[' );
                var _pendingSeperator = false;
                foreach( DataColumn _column in _cols )
                {
                    if( _pendingSeperator )
                    {
                        _output.Append( ',' );
                    }

                    WriteValue( _row[ _column ] );
                    _pendingSeperator = true;
                }

                _output.Append( ']' );
            }

            _output.Append( ']' );
        }

        /// <summary>
        /// Writes the data table.
        /// </summary>
        /// <param name="dt">The dt.</param>
        private void WriteDataTable( DataTable dt )
        {
            _output.Append( '{' );
            if( _params.UseExtensions )
            {
                WritePair( "$schema", _params.UseOptimizedDatasetSchema
                    ? GetSchema( dt )
                    : GetXmlSchema( dt ) );

                _output.Append( ',' );
            }

            WriteDataTableData( dt );

            // end datatable
            _output.Append( '}' );
        }

        /// <summary>
        /// Writes the object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="ErrorDialog.Exception">Serializer encountered maximum depth of " + _maxDepth</exception>
        private void WriteObject( object obj )
        {
            if( _params.UsingGlobalTypes == false )
            {
                _output.Append( '{' );
            }
            else
            {
                if( _typesWritten == false )
                {
                    _output.Append( "{$types$" );
                }
                else
                {
                    _output.Append( "{" );
                }
            }

            _typesWritten = true;
            _currentDepth++;
            if( _currentDepth > _maxDepth )
            {
                throw new Exception( "Serializer encountered maximum depth of " + _maxDepth );
            }

            var _map = new Dictionary<string, string>( );
            var _t = obj.GetType( );
            var _append = false;
            if( _params.UseExtensions )
            {
                if( _params.UsingGlobalTypes == false )
                {
                    WritePairFast( "$type", Reflection.Instance.GetTypeAssemblyName( _t ) );
                }
                else
                {
                    var _dt = 0;
                    var _ct = Reflection.Instance.GetTypeAssemblyName( _t );
                    if( _globalTypes.TryGetValue( _ct, out _dt ) == false )
                    {
                        _dt = _globalTypes.Count + 1;
                        _globalTypes.Add( _ct, _dt );
                    }

                    WritePairFast( "$type", _dt.ToString( ) );
                }

                _append = true;
            }

            var _g = Reflection.Instance.GetGetters( _t );
            foreach( var _p in _g )
            {
                if( _append )
                {
                    _output.Append( ',' );
                }

                var _o = _p.GetterCallback( obj );
                if( ( ( _o == null ) || _o is DBNull )
                   && ( _params.SerializeNullValues == false ) )
                {
                    _append = false;
                }
                else
                {
                    WritePair( _p.Name, _o );
                    if( ( _o != null )
                       && _params.UseExtensions )
                    {
                        var _tt = _o.GetType( );
                        if( _tt == typeof( Object ) )
                        {
                            _map.Add( _p.Name, _tt.ToString( ) );
                        }
                    }

                    _append = true;
                }
            }

            if( ( _map.Count > 0 )
               && _params.UseExtensions )
            {
                _output.Append( ",\"$map\":" );
                WriteStringDictionary( _map );
            }

            _currentDepth--;
            _output.Append( '}' );
            _currentDepth--;
        }

        /// <summary>
        /// Writes the pair fast.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        private void WritePairFast( string name, string value )
        {
            if( ( value == null )
               && ( _params.SerializeNullValues == false ) )
            {
                return;
            }

            WriteStringFast( name );
            _output.Append( ':' );
            WriteStringFast( value );
        }

        /// <summary>
        /// Writes the pair.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        private void WritePair( string name, object value )
        {
            if( ( ( value == null ) || value is DBNull )
               && ( _params.SerializeNullValues == false ) )
            {
                return;
            }

            WriteStringFast( name );
            _output.Append( ':' );
            WriteValue( value );
        }

        /// <summary>
        /// Writes the array.
        /// </summary>
        /// <param name="array">The array.</param>
        private void WriteArray( IEnumerable array )
        {
            _output.Append( '[' );
            var _pendingSeperator = false;
            foreach( var _obj in array )
            {
                if( _pendingSeperator )
                {
                    _output.Append( ',' );
                }

                WriteValue( _obj );
                _pendingSeperator = true;
            }

            _output.Append( ']' );
        }

        /// <summary>
        /// Writes the string dictionary.
        /// </summary>
        /// <param name="dic">The dic.</param>
        private void WriteStringDictionary( IDictionary dic )
        {
            _output.Append( '{' );
            var _pendingSeparator = false;
            foreach( DictionaryEntry _entry in dic )
            {
                if( _pendingSeparator )
                {
                    _output.Append( ',' );
                }

                WritePair( (string)_entry.Key, _entry.Value );
                _pendingSeparator = true;
            }

            _output.Append( '}' );
        }

        /// <summary>
        /// Writes the dictionary.
        /// </summary>
        /// <param name="dic">The dic.</param>
        private void WriteDictionary( IDictionary dic )
        {
            _output.Append( '[' );
            var _pendingSeparator = false;
            foreach( DictionaryEntry _entry in dic )
            {
                if( _pendingSeparator )
                {
                    _output.Append( ',' );
                }

                _output.Append( '{' );
                WritePair( "k", _entry.Key );
                _output.Append( "," );
                WritePair( "v", _entry.Value );
                _output.Append( '}' );
                _pendingSeparator = true;
            }

            _output.Append( ']' );
        }

        /// <summary>
        /// Writes the string fast.
        /// </summary>
        /// <param name="s">The s.</param>
        private void WriteStringFast( string s )
        {
            _output.Append( '\"' );
            _output.Append( s );
            _output.Append( '\"' );
        }

        /// <summary>
        /// Writes the string.
        /// </summary>
        /// <param name="s">The s.</param>
        private void WriteString( string s )
        {
            _output.Append( '\"' );
            var _runIndex = -1;
            for( var _index = 0; _index < s.Length; ++_index )
            {
                var _c = s[ _index ];
                if( ( _c >= ' ' )
                   && ( _c < 128 )
                   && ( _c != '\"' )
                   && ( _c != '\\' ) )
                {
                    if( _runIndex == -1 )
                    {
                        _runIndex = _index;
                    }

                    continue;
                }

                if( _runIndex != -1 )
                {
                    _output.Append( s, _runIndex, _index - _runIndex );
                    _runIndex = -1;
                }

                switch( _c )
                {
                    case '\t':
                    {
                        _output.Append( "\\t" );
                        break;
                    }
                    case '\r':
                    {
                        _output.Append( "\\r" );
                        break;
                    }
                    case '\n':
                    {
                        _output.Append( "\\n" );
                        break;
                    }
                    case '"':
                    case '\\':
                    {
                        _output.Append( '\\' );
                        _output.Append( _c );
                        break;
                    }
                    default:
                    {
                        _output.Append( "\\u" );
                        _output.Append(
                            ( (int)_c ).ToString( "X4", NumberFormatInfo.InvariantInfo ) );

                        break;
                    }
                }
            }

            if( _runIndex != -1 )
            {
                _output.Append( s, _runIndex, s.Length - _runIndex );
            }

            _output.Append( '\"' );
        }
    }
}