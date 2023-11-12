// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-24-2023
// ******************************************************************************************
// <copyright file="JSON.cs" company="Terry D. Eppler">
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
//   JSON.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using IO;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using System.Diagnostics.CodeAnalysis;
    using static IO.Reflection;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "InternalOrPrivateMemberNotDocumented" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UseDeconstruction" ) ]
    [ SuppressMessage( "ReSharper", "UseNegatedPatternMatching" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class Json
    {
        /// <summary>
        /// The parameters
        /// </summary>
        private JsonParameters _params;

        /// <summary>
        /// The property cache
        /// </summary>
        private readonly SafeDictionary<string, SafeDictionary<string, PropInfo>> _propertycache =
            new SafeDictionary<string, SafeDictionary<string, PropInfo>>( );

        /// <summary>
        /// You can set these paramters globally for all calls
        /// </summary>
        public JsonParameters Parameters = new JsonParameters( );

        /// <summary>
        /// The using globals
        /// </summary>
        private bool _usingglobals;

        /// <summary>
        /// The instance
        /// </summary>
        public static readonly Json Instance = new Json( );

        /// <summary>
        /// Prevents a default instance of the <see cref="Json"/> class from being created.
        /// </summary>
        private Json( )
        {
        }

        // FIX : extensions off should not output $types 
        /// <summary>
        /// Converts to json.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public string ToJson( object obj )
        {
            _params = Parameters;
            Reflection.Instance.ShowReadOnlyProperties = _params.ShowReadOnlyProperties;
            return ToJson( obj, Parameters );
        }

        /// <summary>
        /// Converts to json.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string ToJson( object obj, JsonParameters param )
        {
            _params = param;
            Reflection.Instance.ShowReadOnlyProperties = _params.ShowReadOnlyProperties;

            // FEATURE : enable extensions when you can deserialize anon types
            if( _params.EnableAnonymousTypes )
            {
                _params.UseExtensions = false;
                _params.UsingGlobalTypes = false;
            }

            return new JsonSerializer( param ).ConvertToJson( obj );
        }

        /// <summary>
        /// Parses the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        public object Parse( string json )
        {
            _params = Parameters;
            Reflection.Instance.ShowReadOnlyProperties = _params.ShowReadOnlyProperties;
            return new JsonParser( json, Parameters.IgnoreCaseOnDeserialize ).Decode( );
        }

        /// <summary>
        /// Converts to object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        public T ToObject<T>( string json )
        {
            return (T)ToObject( json, typeof( T ) );
        }

        /// <summary>
        /// Converts to object.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        public object ToObject( string json )
        {
            return ToObject( json, null );
        }

        /// <summary>
        /// Converts to object.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public object ToObject( string json, Type type )
        {
            _params = Parameters;
            Reflection.Instance.ShowReadOnlyProperties = _params.ShowReadOnlyProperties;
            var _ht =
                new JsonParser( json, Parameters.IgnoreCaseOnDeserialize ).Decode( ) as
                    Dictionary<string, object>;

            if( _ht == null )
            {
                return null;
            }

            return ParseDictionary( _ht, null, type, null );
        }

        /// <summary>
        /// Beautifies the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public string Beautify( string input )
        {
            return Formatter.PrettyPrint( input );
        }

        /// <summary>
        /// Fills the object.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        public object FillObject( object input, string json )
        {
            _params = Parameters;
            Reflection.Instance.ShowReadOnlyProperties = _params.ShowReadOnlyProperties;
            var _ht =
                new JsonParser( json, Parameters.IgnoreCaseOnDeserialize ).Decode( ) as
                    Dictionary<string, object>;

            if( _ht == null )
            {
                return null;
            }

            return ParseDictionary( _ht, null, input.GetType( ), input );
        }

        /// <summary>
        /// Deeps the copy.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public object DeepCopy( object obj )
        {
            return ToObject( ToJson( obj ) );
        }

        /// <summary>
        /// Deeps the copy.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public T DeepCopy<T>( T obj )
        {
            return ToObject<T>( ToJson( obj ) );
        }

        /// <summary>
        /// Get properties of the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="typename">The typename.</param>
        /// <returns></returns>
        private SafeDictionary<string, PropInfo> Getproperties( Type type, string typename )
        {
            if( _propertycache.TryGetValue( typename, out var _sd ) )
            {
                return _sd;
            }
            else
            {
                _sd = new SafeDictionary<string, PropInfo>( );
                var _pr = type.GetProperties( BindingFlags.Public | BindingFlags.Instance );
                foreach( var _p in _pr )
                {
                    var _d = CreateMyProp( _p.PropertyType, _p.Name );
                    _d.CanWrite = _p.CanWrite;
                    _d.SetterCallback = CreateSetMethod( type, _p );
                    _d.GetterCallback = CreateGetMethod( type, _p );
                    _sd.Add( _p.Name, _d );
                }

                var _fi = type.GetFields( BindingFlags.Public | BindingFlags.Instance );
                foreach( var _f in _fi )
                {
                    var _d = CreateMyProp( _f.FieldType, _f.Name );
                    _d.SetterCallback = CreateSetField( type, _f );
                    _d.GetterCallback = CreateGetField( type, _f );
                    _sd.Add( _f.Name, _d );
                }

                _propertycache.Add( typename, _sd );
                return _sd;
            }
        }

        /// <summary>
        /// Creates my property.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private PropInfo CreateMyProp( Type t, string name )
        {
            var _d = new PropInfo
            {
                Filled = true,
                CanWrite = true,
                Pt = t,
                Name = name,
                IsDictionary = t.Name.Contains( "Dictionary" )
            };

            if( _d.IsDictionary )
            {
                _d.GenericTypes = t.GetGenericArguments( );
            }

            _d.IsValueType = t.IsValueType;
            _d.IsGenericType = t.IsGenericType;
            _d.IsArray = t.IsArray;
            if( _d.IsArray )
            {
                _d.Bt = t.GetElementType( );
            }

            if( _d.IsGenericType )
            {
                _d.Bt = t.GetGenericArguments( )[ 0 ];
            }

            _d.IsByteArray = t == typeof( byte[ ] );
            _d.IsGuid = ( t == typeof( Guid ) ) || ( t == typeof( Guid? ) );
            _d.IsHashtable = t == typeof( Hashtable );
            _d.IsDataSet = t == typeof( DataSet );
            _d.IsDataTable = t == typeof( DataTable );
            _d.ChangeType = GetChangeType( t );
            _d.IsEnum = t.IsEnum;
            _d.IsDateTime = ( t == typeof( DateTime ) ) || ( t == typeof( DateTime? ) );
            _d.IsInt = ( t == typeof( int ) ) || ( t == typeof( int? ) );
            _d.IsLong = ( t == typeof( long ) ) || ( t == typeof( long? ) );
            _d.IsString = t == typeof( string );
            _d.IsBool = ( t == typeof( bool ) ) || ( t == typeof( bool? ) );
            _d.IsClass = t.IsClass;
            if( _d.IsDictionary
               && ( _d.GenericTypes.Length > 0 )
               && ( _d.GenericTypes[ 0 ] == typeof( string ) ) )
            {
                _d.IsStringDictionary = true;
            }

            return _d;
        }

        /// <summary>
        /// Changes the type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="conversionType">Type of the conversion.</param>
        /// <returns></returns>
        private object ChangeType( object value, Type conversionType )
        {
            if( conversionType == typeof( int ) )
            {
                return (int)CreateLong( (string)value );
            }
            else if( conversionType == typeof( long ) )
            {
                return CreateLong( (string)value );
            }
            else if( conversionType == typeof( string ) )
            {
                return (string)value;
            }
            else if( conversionType == typeof( Guid ) )
            {
                return CreateGuid( (string)value );
            }
            else if( conversionType.IsEnum )
            {
                return CreateEnum( conversionType, (string)value );
            }

            return Convert.ChangeType( value, conversionType, CultureInfo.InvariantCulture );
        }

        /// <summary>
        /// Parses the dictionary.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="globaltypes">The globaltypes.</param>
        /// <param name="type">The type.</param>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /// <exception cref="Exception">Cannot determine type</exception>
        private object ParseDictionary( Dictionary<string, object> d,
            Dictionary<string, object> globaltypes, Type type, object input )
        {
            object _tn = "";
            if( d.TryGetValue( "$types", out _tn ) )
            {
                _usingglobals = true;
                globaltypes = new Dictionary<string, object>( );
                foreach( var _kv in (Dictionary<string, object>)_tn )
                {
                    globaltypes.Add( (string)_kv.Value, _kv.Key );
                }
            }

            var _found = d.TryGetValue( "$type", out _tn );
            if( ( _found == false )
               && ( type == typeof( Object ) ) )
            {
                return CreateDataset( d, globaltypes );
            }

            if( _found )
            {
                if( _usingglobals )
                {
                    object _tname = "";
                    if( globaltypes.TryGetValue( (string)_tn, out _tname ) )
                    {
                        _tn = _tname;
                    }
                }

                type = Reflection.Instance.GetTypeFromCache( (string)_tn );
            }

            if( type == null )
            {
                throw new Exception( "Cannot determine type" );
            }

            var _typename = type.FullName;
            var _o = input;
            if( _o == null )
            {
                _o = Reflection.Instance.FastCreateInstance( type );
            }

            var _props = Getproperties( type, _typename );
            foreach( var _n in d.Keys )
            {
                var _name = _n;
                if( _params.IgnoreCaseOnDeserialize )
                {
                    _name = _name.ToLower( );
                }

                if( _name == "$map" )
                {
                    ProcessMap( _o, _props, (Dictionary<string, object>)d[ _name ] );
                    continue;
                }

                PropInfo _pi;
                if( _props.TryGetValue( _name, out _pi ) == false )
                {
                    continue;
                }

                if( _pi.Filled )
                {
                    var _v = d[ _name ];
                    if( _v != null )
                    {
                        object _oset = null;
                        if( _pi.IsInt )
                        {
                            _oset = (int)CreateLong( (string)_v );
                        }
                        else if( _pi.IsLong )
                        {
                            _oset = CreateLong( (string)_v );
                        }
                        else if( _pi.IsString )
                        {
                            _oset = (string)_v;
                        }
                        else if( _pi.IsBool )
                        {
                            _oset = (bool)_v;
                        }
                        else if( _pi.IsGenericType
                                && ( _pi.IsValueType == false )
                                && ( _pi.IsDictionary == false ) )
                        {
                            _oset = CreateGenericList( (ArrayList)_v, _pi.Pt, _pi.Bt, globaltypes );
                        }
                        else if( _pi.IsByteArray )
                        {
                            _oset = Convert.FromBase64String( (string)_v );
                        }
                        else if( _pi.IsArray
                                && ( _pi.IsValueType == false ) )
                        {
                            _oset = CreateArray( (ArrayList)_v, _pi.Pt, _pi.Bt, globaltypes );
                        }
                        else if( _pi.IsGuid )
                        {
                            _oset = CreateGuid( (string)_v );
                        }
                        else if( _pi.IsDataSet )
                        {
                            _oset = CreateDataset( (Dictionary<string, object>)_v, globaltypes );
                        }
                        else if( _pi.IsDataTable )
                        {
                            _oset = CreateDataTable( (Dictionary<string, object>)_v, globaltypes );
                        }
                        else if( _pi.IsStringDictionary )
                        {
                            _oset = CreateStringKeyDictionary( (Dictionary<string, object>)_v,
                                _pi.Pt, _pi.GenericTypes, globaltypes );
                        }
                        else if( _pi.IsDictionary
                                || _pi.IsHashtable )
                        {
                            _oset = CreateDictionary( (ArrayList)_v, _pi.Pt, _pi.GenericTypes,
                                globaltypes );
                        }
                        else if( _pi.IsEnum )
                        {
                            _oset = CreateEnum( _pi.Pt, (string)_v );
                        }
                        else if( _pi.IsDateTime )
                        {
                            _oset = CreateDateTime( (string)_v );
                        }
                        else if( _pi.IsClass
                                && _v is Dictionary<string, object> )
                        {
                            _oset = ParseDictionary( (Dictionary<string, object>)_v, globaltypes,
                                _pi.Pt, null );
                        }
                        else if( _pi.IsValueType )
                        {
                            _oset = ChangeType( _v, _pi.ChangeType );
                        }
                        else if( _v is ArrayList )
                        {
                            _oset = CreateArray( (ArrayList)_v, _pi.Pt, typeof( object ),
                                globaltypes );
                        }
                        else
                        {
                            _oset = _v;
                        }

                        if( _pi.CanWrite )
                        {
                            _o = _pi.SetterCallback( _o, _oset );
                        }
                    }
                }
            }

            return _o;
        }

        /// <summary>
        /// Processes the map.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="props">The props.</param>
        /// <param name="dic">The dic.</param>
        private void ProcessMap( object obj, SafeDictionary<string, PropInfo> props,
            Dictionary<string, object> dic )
        {
            foreach( var _kv in dic )
            {
                var _p = props[ _kv.Key ];
                var _o = _p.GetterCallback( obj );
                var _t = Type.GetType( (string)_kv.Value );
                if( _t == typeof( Guid ) )
                {
                    _p.SetterCallback( obj, CreateGuid( (string)_o ) );
                }
            }
        }

        /// <summary>
        /// Creates the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        private long CreateLong( string s )
        {
            long _num = 0;
            var _neg = false;
            foreach( var _cc in s )
            {
                if( _cc == '-' )
                {
                    _neg = true;
                }
                else if( _cc == '+' )
                {
                    _neg = false;
                }
                else
                {
                    _num *= 10;
                    _num += _cc - '0';
                }
            }

            return _neg
                ? -_num
                : _num;
        }

        /// <summary>
        /// Creates the enum.
        /// </summary>
        /// <param name="pt">The pt.</param>
        /// <param name="v">The v.</param>
        /// <returns></returns>
        private object CreateEnum( Type pt, string v )
        {
            // TODO : optimize create enum
            return Enum.Parse( pt, v );
        }

        /// <summary>
        /// Creates the unique identifier.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        private Guid CreateGuid( string s )
        {
            if( s.Length > 30 )
            {
                return new Guid( s );
            }
            else
            {
                return new Guid( Convert.FromBase64String( s ) );
            }
        }

        /// <summary>
        /// Creates the date time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private DateTime CreateDateTime( string value )
        {
            var _utc = false;

            //                   0123456789012345678
            // datetime format = yyyy-MM-dd HH:mm:ss
            var _year = (int)CreateLong( value.Substring( 0, 4 ) );
            var _month = (int)CreateLong( value.Substring( 5, 2 ) );
            var _day = (int)CreateLong( value.Substring( 8, 2 ) );
            var _hour = (int)CreateLong( value.Substring( 11, 2 ) );
            var _min = (int)CreateLong( value.Substring( 14, 2 ) );
            var _sec = (int)CreateLong( value.Substring( 17, 2 ) );
            if( value.EndsWith( "Z" ) )
            {
                _utc = true;
            }

            if( ( _params.UseUtcDateTime == false )
               && ( _utc == false ) )
            {
                return new DateTime( _year, _month, _day, _hour, _min,
                    _sec );
            }
            else
            {
                return new DateTime( _year, _month, _day, _hour, _min,
                    _sec, DateTimeKind.Utc ).ToLocalTime( );
            }
        }

        /// <summary>
        /// Creates the array.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="pt">The pt.</param>
        /// <param name="bt">The bt.</param>
        /// <param name="globalTypes">The global types.</param>
        /// <returns></returns>
        private object CreateArray( ArrayList data, Type pt, Type bt,
            Dictionary<string, object> globalTypes )
        {
            var _col = new ArrayList( );

            // create an array of objects
            foreach( var _ob in data )
            {
                if( _ob is IDictionary )
                {
                    _col.Add( ParseDictionary( (Dictionary<string, object>)_ob, globalTypes, bt,
                        null ) );
                }
                else
                {
                    _col.Add( ChangeType( _ob, bt ) );
                }
            }

            return _col.ToArray( bt );
        }

        /// <summary>
        /// Creates the generic list.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="pt">The pt.</param>
        /// <param name="bt">The bt.</param>
        /// <param name="globalTypes">The global types.</param>
        /// <returns></returns>
        private object CreateGenericList( ArrayList data, Type pt, Type bt,
            Dictionary<string, object> globalTypes )
        {
            var _col = (IList)Reflection.Instance.FastCreateInstance( pt );

            // create an array of objects
            foreach( var _ob in data )
            {
                if( _ob is IDictionary )
                {
                    _col.Add( ParseDictionary( (Dictionary<string, object>)_ob, globalTypes, bt,
                        null ) );
                }
                else if( _ob is ArrayList )
                {
                    _col.Add( ( (ArrayList)_ob ).ToArray( ) );
                }
                else
                {
                    _col.Add( ChangeType( _ob, bt ) );
                }
            }

            return _col;
        }

        /// <summary>
        /// Creates the string key dictionary.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="pt">The pt.</param>
        /// <param name="types">The types.</param>
        /// <param name="globalTypes">The global types.</param>
        /// <returns></returns>
        private object CreateStringKeyDictionary( Dictionary<string, object> reader, Type pt,
            Type[ ] types, Dictionary<string, object> globalTypes )
        {
            var _col = (IDictionary)Reflection.Instance.FastCreateInstance( pt );
            Type _t2 = null;
            if( types != null )
            {
                var _t1 = types[ 0 ];
                _t2 = types[ 1 ];
            }

            foreach( var _values in reader )
            {
                var _key = _values.Key;//ChangeType(values.Key, t1);
                object _val = null;
                if( _values.Value is Dictionary<string, object> )
                {
                    _val = ParseDictionary( (Dictionary<string, object>)_values.Value, globalTypes,
                        _t2, null );
                }
                else
                {
                    _val = ChangeType( _values.Value, _t2 );
                }

                _col.Add( _key, _val );
            }

            return _col;
        }

        /// <summary>
        /// Creates the dictionary.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="pt">The pt.</param>
        /// <param name="types">The types.</param>
        /// <param name="globalTypes">The global types.</param>
        /// <returns></returns>
        private object CreateDictionary( ArrayList reader, Type pt, Type[ ] types,
            Dictionary<string, object> globalTypes )
        {
            var _col = (IDictionary)Reflection.Instance.FastCreateInstance( pt );
            Type _t1 = null;
            Type _t2 = null;
            if( types != null )
            {
                _t1 = types[ 0 ];
                _t2 = types[ 1 ];
            }

            foreach( Dictionary<string, object> _values in reader )
            {
                var _key = _values[ "k" ];
                var _val = _values[ "v" ];
                if( _key is Dictionary<string, object> )
                {
                    _key = ParseDictionary( (Dictionary<string, object>)_key, globalTypes, _t1,
                        null );
                }
                else
                {
                    _key = ChangeType( _key, _t1 );
                }

                if( _val is Dictionary<string, object> )
                {
                    _val = ParseDictionary( (Dictionary<string, object>)_val, globalTypes, _t2,
                        null );
                }
                else
                {
                    _val = ChangeType( _val, _t2 );
                }

                _col.Add( _key, _val );
            }

            return _col;
        }

        /// <summary>
        /// Gets the type of the change.
        /// </summary>
        /// <param name="conversionType">Type of the conversion.</param>
        /// <returns></returns>
        private Type GetChangeType( Type conversionType )
        {
            if( conversionType.IsGenericType
               && conversionType.GetGenericTypeDefinition( ).Equals( typeof( Nullable<> ) ) )
            {
                return conversionType.GetGenericArguments( )[ 0 ];
            }

            return conversionType;
        }

        /// <summary>
        /// Creates the dataset.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="globalTypes">The global types.</param>
        /// <returns></returns>
        private DataSet CreateDataset( Dictionary<string, object> reader,
            Dictionary<string, object> globalTypes )
        {
            var _ds = new DataSet( );
            _ds.EnforceConstraints = false;
            _ds.BeginInit( );

            // read dataset schema here
            ReadSchema( reader, _ds, globalTypes );
            foreach( var _pair in reader )
            {
                if( ( _pair.Key == "$type" )
                   || ( _pair.Key == "$schema" ) )
                {
                    continue;
                }

                var _rows = (ArrayList)_pair.Value;
                if( _rows == null )
                {
                    continue;
                }

                var _dt = _ds.Tables[ _pair.Key ];
                ReadDataTable( _rows, _dt );
            }

            _ds.EndInit( );
            return _ds;
        }

        /// <summary>
        /// Reads the schema.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="ds">The ds.</param>
        /// <param name="globalTypes">The global types.</param>
        private void ReadSchema( Dictionary<string, object> reader, DataSet ds,
            Dictionary<string, object> globalTypes )
        {
            var _schema = reader[ "$schema" ];
            if( _schema is string )
            {
                TextReader _tr = new StringReader( (string)_schema );
                ds.ReadXmlSchema( _tr );
            }
            else
            {
                var _ms = (DataSchema)ParseDictionary( (Dictionary<string, object>)_schema,
                    globalTypes, typeof( DataSchema ), null );

                ds.DataSetName = _ms.Name;
                for( var _i = 0; _i < _ms.Info.Count; _i += 3 )
                {
                    if( ds.Tables.Contains( _ms.Info[ _i ] ) == false )
                    {
                        ds.Tables.Add( _ms.Info[ _i ] );
                    }

                    ds.Tables[ _ms.Info[ _i ] ]
                        .Columns.Add( _ms.Info[ _i + 1 ], Type.GetType( _ms.Info[ _i + 2 ] ) );
                }
            }
        }

        /// <summary>
        /// Reads the data table.
        /// </summary>
        /// <param name="rows">The rows.</param>
        /// <param name="dt">The dt.</param>
        private void ReadDataTable( ArrayList rows, DataTable dt )
        {
            dt.BeginInit( );
            dt.BeginLoadData( );
            var _guidcols = new List<int>( );
            var _datecol = new List<int>( );
            foreach( DataColumn _c in dt.Columns )
            {
                if( ( _c.DataType == typeof( Guid ) )
                   || ( _c.DataType == typeof( Guid? ) ) )
                {
                    _guidcols.Add( _c.Ordinal );
                }

                if( _params.UseUtcDateTime
                   && ( ( _c.DataType == typeof( DateTime ) )
                       || ( _c.DataType == typeof( DateTime? ) ) ) )
                {
                    _datecol.Add( _c.Ordinal );
                }
            }

            foreach( ArrayList _row in rows )
            {
                var _v = new object[ _row.Count ];
                _row.CopyTo( _v, 0 );
                foreach( var _i in _guidcols )
                {
                    var _s = (string)_v[ _i ];
                    if( ( _s != null )
                       && ( _s.Length < 36 ) )
                    {
                        _v[ _i ] = new Guid( Convert.FromBase64String( _s ) );
                    }
                }

                if( _params.UseUtcDateTime )
                {
                    foreach( var _i in _datecol )
                    {
                        var _s = (string)_v[ _i ];
                        if( _s != null )
                        {
                            _v[ _i ] = CreateDateTime( _s );
                        }
                    }
                }

                dt.Rows.Add( _v );
            }

            dt.EndLoadData( );
            dt.EndInit( );
        }

        /// <summary>
        /// Creates the data table.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="globalTypes">The global types.</param>
        /// <returns></returns>
        private DataTable CreateDataTable( Dictionary<string, object> reader,
            Dictionary<string, object> globalTypes )
        {
            var _dt = new DataTable( );

            // read dataset schema here
            var _schema = reader[ "$schema" ];
            if( _schema is string )
            {
                TextReader _tr = new StringReader( (string)_schema );
                _dt.ReadXmlSchema( _tr );
            }
            else
            {
                var _ms = (DataSchema)ParseDictionary( (Dictionary<string, object>)_schema,
                    globalTypes, typeof( DataSchema ), null );

                _dt.TableName = _ms.Info[ 0 ];
                for( var _i = 0; _i < _ms.Info.Count; _i += 3 )
                {
                    _dt.Columns.Add( _ms.Info[ _i + 1 ], Type.GetType( _ms.Info[ _i + 2 ] ) );
                }
            }

            foreach( var _pair in reader )
            {
                if( ( _pair.Key == "$type" )
                   || ( _pair.Key == "$schema" ) )
                {
                    continue;
                }

                var _rows = (ArrayList)_pair.Value;
                if( _rows == null )
                {
                    continue;
                }

                if( !_dt.TableName.Equals( _pair.Key,
                       StringComparison.InvariantCultureIgnoreCase ) )
                {
                    continue;
                }

                ReadDataTable( _rows, _dt );
            }

            return _dt;
        }
    }
}