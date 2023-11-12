// ******************************************************************************************
//     Assembly:                Budget Browser
//     Author:                  Terry D. Eppler
//     Created:                 06-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-24-2023
// ******************************************************************************************
// <copyright file="PropInfo.cs" company="Terry D. Eppler">
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
//   PropInfo.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public struct PropInfo
    {
        /// <summary>
        /// The bt
        /// </summary>
        public Type Bt;

        /// <summary>
        /// The can write
        /// </summary>
        public bool CanWrite;

        /// <summary>
        /// The change type
        /// </summary>
        public Type ChangeType;

        /// <summary>
        /// The filled
        /// </summary>
        public bool Filled;

        /// <summary>
        /// The generic types
        /// </summary>
        public Type[ ] GenericTypes;

        /// <summary>
        /// The getter
        /// </summary>
        public GetterCallback GetterCallback;

        /// <summary>
        /// The is array
        /// </summary>
        public bool IsArray;

        /// <summary>
        /// The is bool
        /// </summary>
        public bool IsBool;

        /// <summary>
        /// The is byte array
        /// </summary>
        public bool IsByteArray;

        /// <summary>
        /// The is class
        /// </summary>
        public bool IsClass;

        /// <summary>
        /// The is data set
        /// </summary>
        public bool IsDataSet;

        /// <summary>
        /// The is data table
        /// </summary>
        public bool IsDataTable;

        /// <summary>
        /// The is date time
        /// </summary>
        public bool IsDateTime;

        /// <summary>
        /// The is dictionary
        /// </summary>
        public bool IsDictionary;

        /// <summary>
        /// The is enum
        /// </summary>
        public bool IsEnum;

        /// <summary>
        /// The is generic type
        /// </summary>
        public bool IsGenericType;

        /// <summary>
        /// The is unique identifier
        /// </summary>
        public bool IsGuid;

        /// <summary>
        /// The is hashtable
        /// </summary>
        public bool IsHashtable;

        /// <summary>
        /// The is int
        /// </summary>
        public bool IsInt;

        /// <summary>
        /// The is long
        /// </summary>
        public bool IsLong;

        /// <summary>
        /// The is string
        /// </summary>
        public bool IsString;

        /// <summary>
        /// The is string dictionary
        /// </summary>
        public bool IsStringDictionary;

        /// <summary>
        /// The is value type
        /// </summary>
        public bool IsValueType;

        /// <summary>
        /// The name
        /// </summary>
        public string Name;

        /// <summary>
        /// The pt
        /// </summary>
        public Type Pt;

        /// <summary>
        /// The setter
        /// </summary>
        public BabySetter Setter;
    }
}