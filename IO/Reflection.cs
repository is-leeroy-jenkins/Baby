// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-24-2023
// ******************************************************************************************
// <copyright file="Reflection.cs" company="Terry D. Eppler">
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
//   Reflection.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser.IO
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Xml.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "InlineOutVariableDeclaration" ) ]
    public class Reflection
    {
        /// <summary>
        /// The constructs cache
        /// </summary>
        private readonly SafeDictionary<Type, CreateObject> _constrcache =
            new SafeDictionary<Type, CreateObject>( );

        /// <summary>
        /// The gets cache
        /// </summary>
        private readonly SafeDictionary<Type, List<Getters>> _getterscache =
            new SafeDictionary<Type, List<Getters>>( );

        /// <summary>
        /// The type name
        /// </summary>
        private readonly SafeDictionary<Type, string> _typeName = new SafeDictionary<Type, string>( );

        /// <summary>
        /// The type cache
        /// </summary>
        private readonly SafeDictionary<string, Type> _typeCache =
            new SafeDictionary<string, Type>( );

        /// <summary>
        /// The show read only properties
        /// </summary>
        public bool ShowReadOnlyProperties;

        /// <summary>
        /// The instance
        /// </summary>
        public static readonly Reflection Instance = new Reflection( );
        
        /// <summary>
        /// Prevents a default instance of the
        /// <see cref="Reflection"/> class from being created.
        /// </summary>
        public Reflection( )
        {
        }

        /// <summary>
        /// Gets the name of the type assembly.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <returns></returns>
        public string GetTypeAssemblyName( Type t )
        {
            var _val = "";
            if( _typeName.TryGetValue( t, out _val ) )
            {
                return _val;
            }
            else
            {
                var _s = t.AssemblyQualifiedName;
                _typeName.Add( t, _s );
                return _s;
            }
        }

        /// <summary>
        /// Gets the type from cache.
        /// </summary>
        /// <param name="typename">The typename.</param>
        /// <returns></returns>
        public Type GetTypeFromCache( string typename )
        {
            if( _typeCache.TryGetValue( typename, out var _val ) )
            {
                return _val;
            }
            else
            {
                var _t = Type.GetType( typename );
                _typeCache.Add( typename, _t );
                return _t;
            }
        }

        /// <summary>
        /// Fasts the create instance.
        /// </summary>
        /// <param name="objtype">The object type.</param>
        /// <returns></returns>
        /// <exception cref="ErrorDialog.Exception"></exception>
        public object FastCreateInstance( Type objtype )
        {
            try
            {
                CreateObject _c = null;
                if( _constrcache.TryGetValue( objtype, out _c ) )
                {
                    return _c( );
                }
                else
                {
                    var _dynMethod = new DynamicMethod( "_",
                        MethodAttributes.Public | MethodAttributes.Static,
                        CallingConventions.Standard, typeof( object ), null, objtype, false );

                    var _ilGen = _dynMethod.GetILGenerator( );
                    if( objtype.IsClass )
                    {
                        _ilGen.Emit( OpCodes.Newobj, objtype.GetConstructor( Type.EmptyTypes ) );
                        _ilGen.Emit( OpCodes.Ret );
                        _c = (CreateObject)_dynMethod.CreateDelegate( typeof( CreateObject ) );
                        _constrcache.Add( objtype, _c );
                    }
                    else// structs
                    {
                        var _lv = _ilGen.DeclareLocal( objtype );
                        _ilGen.Emit( OpCodes.Ldloca_S, _lv );
                        _ilGen.Emit( OpCodes.Initobj, objtype );
                        _ilGen.Emit( OpCodes.Ldloc_0 );
                        _ilGen.Emit( OpCodes.Box, objtype );
                        _ilGen.Emit( OpCodes.Ret );
                        _c = (CreateObject)_dynMethod.CreateDelegate( typeof( CreateObject ) );
                        _constrcache.Add( objtype, _c );
                    }

                    return _c( );
                }
            }
            catch( Exception _exc )
            {
                var _message = $"Failed to create instance for type '{0}' from Assemebly '{1}'";
                throw new Exception( string.Format( _message, objtype.FullName, 
                    objtype.AssemblyQualifiedName ), _exc );
            }
        }

        /// <summary>
        /// Creates the set field.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="fieldInfo">The field information.</param>
        /// <returns></returns>
        public static BabySetter CreateSetField( Type type, FieldInfo fieldInfo )
        {
            var _arguments = new Type[ 2 ];
            _arguments[ 0 ] = _arguments[ 1 ] = typeof( object );
            var _dynamicSet = new DynamicMethod( "_", typeof( object ), _arguments, type, true );
            var _il = _dynamicSet.GetILGenerator( );
            if( !type.IsClass )// structs
            {
                var _lv = _il.DeclareLocal( type );
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Unbox_Any, type );
                _il.Emit( OpCodes.Stloc_0 );
                _il.Emit( OpCodes.Ldloca_S, _lv );
                _il.Emit( OpCodes.Ldarg_1 );
                if( fieldInfo.FieldType.IsClass )
                {
                    _il.Emit( OpCodes.Castclass, fieldInfo.FieldType );
                }
                else
                {
                    _il.Emit( OpCodes.Unbox_Any, fieldInfo.FieldType );
                }

                _il.Emit( OpCodes.Stfld, fieldInfo );
                _il.Emit( OpCodes.Ldloc_0 );
                _il.Emit( OpCodes.Box, type );
                _il.Emit( OpCodes.Ret );
            }
            else
            {
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Ldarg_1 );
                if( fieldInfo.FieldType.IsValueType )
                {
                    _il.Emit( OpCodes.Unbox_Any, fieldInfo.FieldType );
                }

                _il.Emit( OpCodes.Stfld, fieldInfo );
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Ret );
            }

            return (BabySetter)_dynamicSet.CreateDelegate( typeof( BabySetter ) );
        }

        /// <summary>
        /// Creates the set method.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="propertyInfo">The property information.</param>
        /// <returns></returns>
        public static BabySetter CreateSetMethod( Type type, PropertyInfo propertyInfo )
        {
            var _setMethod = propertyInfo.GetSetMethod( );
            if( _setMethod == null )
            {
                return null;
            }

            var _arguments = new Type[ 2 ];
            _arguments[ 0 ] = _arguments[ 1 ] = typeof( object );
            var _setter = new DynamicMethod( "_", typeof( object ), _arguments, type );
            var _il = _setter.GetILGenerator( );
            if( !type.IsClass )// structs
            {
                var _lv = _il.DeclareLocal( type );
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Unbox_Any, type );
                _il.Emit( OpCodes.Stloc_0 );
                _il.Emit( OpCodes.Ldloca_S, _lv );
                _il.Emit( OpCodes.Ldarg_1 );
                if( propertyInfo.PropertyType.IsClass )
                {
                    _il.Emit( OpCodes.Castclass, propertyInfo.PropertyType );
                }
                else
                {
                    _il.Emit( OpCodes.Unbox_Any, propertyInfo.PropertyType );
                }

                _il.EmitCall( OpCodes.Call, _setMethod, null );
                _il.Emit( OpCodes.Ldloc_0 );
                _il.Emit( OpCodes.Box, type );
            }
            else
            {
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Castclass, propertyInfo.DeclaringType );
                _il.Emit( OpCodes.Ldarg_1 );
                if( propertyInfo.PropertyType.IsClass )
                {
                    _il.Emit( OpCodes.Castclass, propertyInfo.PropertyType );
                }
                else
                {
                    _il.Emit( OpCodes.Unbox_Any, propertyInfo.PropertyType );
                }

                _il.EmitCall( OpCodes.Callvirt, _setMethod, null );
                _il.Emit( OpCodes.Ldarg_0 );
            }

            _il.Emit( OpCodes.Ret );
            return (BabySetter)_setter.CreateDelegate( typeof( BabySetter ) );
        }

        /// <summary>
        /// Creates the get field.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="fieldInfo">The field information.</param>
        /// <returns></returns>
        public static BabyGetter CreateGetField( Type type, FieldInfo fieldInfo )
        {
            var _dynamicGet = new DynamicMethod( "_", typeof( object ), new[ ]
            {
                typeof( object )
            }, type, true );

            var _il = _dynamicGet.GetILGenerator( );
            if( !type.IsClass )// structs
            {
                var _lv = _il.DeclareLocal( type );
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Unbox_Any, type );
                _il.Emit( OpCodes.Stloc_0 );
                _il.Emit( OpCodes.Ldloca_S, _lv );
                _il.Emit( OpCodes.Ldfld, fieldInfo );
                if( fieldInfo.FieldType.IsValueType )
                {
                    _il.Emit( OpCodes.Box, fieldInfo.FieldType );
                }
            }
            else
            {
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Ldfld, fieldInfo );
                if( fieldInfo.FieldType.IsValueType )
                {
                    _il.Emit( OpCodes.Box, fieldInfo.FieldType );
                }
            }

            _il.Emit( OpCodes.Ret );
            return (BabyGetter)_dynamicGet.CreateDelegate( typeof( BabyGetter ) );
        }

        /// <summary>
        /// Creates the get method.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="propertyInfo">The property information.</param>
        /// <returns></returns>
        public static BabyGetter CreateGetMethod( Type type, PropertyInfo propertyInfo )
        {
            var _getMethod = propertyInfo.GetGetMethod( );
            if( _getMethod == null )
            {
                return null;
            }

            var _arguments = new Type[ 1 ];
            _arguments[ 0 ] = typeof( object );
            var _getter = new DynamicMethod( "_", typeof( object ), _arguments, type );
            var _il = _getter.GetILGenerator( );
            if( !type.IsClass )// structs
            {
                var _lv = _il.DeclareLocal( type );
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Unbox_Any, type );
                _il.Emit( OpCodes.Stloc_0 );
                _il.Emit( OpCodes.Ldloca_S, _lv );
                _il.EmitCall( OpCodes.Call, _getMethod, null );
                if( propertyInfo.PropertyType.IsValueType )
                {
                    _il.Emit( OpCodes.Box, propertyInfo.PropertyType );
                }
            }
            else
            {
                _il.Emit( OpCodes.Ldarg_0 );
                _il.Emit( OpCodes.Castclass, propertyInfo.DeclaringType );
                _il.EmitCall( OpCodes.Callvirt, _getMethod, null );
                if( propertyInfo.PropertyType.IsValueType )
                {
                    _il.Emit( OpCodes.Box, propertyInfo.PropertyType );
                }
            }

            _il.Emit( OpCodes.Ret );
            return (BabyGetter)_getter.CreateDelegate( typeof( BabyGetter ) );
        }

        /// <summary>
        /// Gets the getters.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public List<Getters> GetGetters( Type type )
        {
            List<Getters> _val = null;
            if( _getterscache.TryGetValue( type, out _val ) )
            {
                return _val;
            }

            var _props = type.GetProperties( BindingFlags.Public | BindingFlags.Instance );
            var _getters = new List<Getters>( );
            foreach( var _p in _props )
            {
                if( !_p.CanWrite
                   && ( ShowReadOnlyProperties == false ) )
                {
                    continue;
                }

                var _att = _p.GetCustomAttributes( typeof( XmlIgnoreAttribute ), false );
                if( ( _att != null )
                   && ( _att.Length > 0 ) )
                {
                    continue;
                }

                var _g = CreateGetMethod( type, _p );
                if( _g != null )
                {
                    var _gg = new Getters
                    {
                        Name = _p.Name,
                        Getter = _g,
                        PropertyType = _p.PropertyType
                    };

                    _getters.Add( _gg );
                }
            }

            var _fi = type.GetFields( BindingFlags.Instance | BindingFlags.Public );
            foreach( var _f in _fi )
            {
                var _att = _f.GetCustomAttributes( typeof( XmlIgnoreAttribute ), false );
                if( ( _att != null )
                   && ( _att.Length > 0 ) )
                {
                    continue;
                }

                var _g = CreateGetField( type, _f );
                if( _g != null )
                {
                    var _gg = new Getters
                    {
                        Name = _f.Name,
                        Getter = _g,
                        PropertyType = _f.FieldType
                    };

                    _getters.Add( _gg );
                }
            }

            _getterscache.Add( type, _getters );
            return _getters;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private delegate object CreateObject( );
    }
}