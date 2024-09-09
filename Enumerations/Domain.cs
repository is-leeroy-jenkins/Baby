// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 09-09-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        09-09-2024
// ******************************************************************************************
// <copyright file="Domain.cs" company="Terry D. Eppler">
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
//   Domain.cs
// </summary>
// ******************************************************************************************

namespace Baby
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public enum Domain
    {
        /// <summary>
        /// The google
        /// </summary>
        Google,

        /// <summary>
        /// The epa
        /// </summary>
        EPA,

        /// <summary>
        /// The data.gov
        /// </summary>
        DATA,

        /// <summary>
        /// The gpo
        /// </summary>
        GPO,

        /// <summary>
        /// The gov information
        /// </summary>
        USGI,

        /// <summary>
        /// The CRS
        /// </summary>
        CRS,

        /// <summary>
        /// The loc
        /// </summary>
        LOC,

        /// <summary>
        /// The omb
        /// </summary>
        OMB,

        /// <summary>
        /// The treasury
        /// </summary>
        UST,

        /// <summary>
        /// The nasa
        /// </summary>
        NASA,

        /// <summary>
        /// The noaa
        /// </summary>
        NOAA,

        /// <summary>
        /// The doi
        /// </summary>
        DOI,

        /// <summary>
        /// The NPS
        /// </summary>
        NPS,

        /// <summary>
        /// The gsa
        /// </summary>
        GSA,

        /// <summary>
        /// The National Archives
        /// </summary>
        NARA,

        /// <summary>
        /// The document
        /// </summary>
        DOC,

        /// <summary>
        /// The HHS
        /// </summary>
        HHS,

        /// <summary>
        /// The NRC
        /// </summary>
        NRC,

        /// <summary>
        /// The doe
        /// </summary>
        DOE,

        /// <summary>
        /// The NSF
        /// </summary>
        NSF,

        /// <summary>
        /// The usda
        /// </summary>
        USDA,

        /// <summary>
        /// The CSB
        /// </summary>
        CSB,

        /// <summary>
        /// The irs
        /// </summary>
        IRS,

        /// <summary>
        /// The fda
        /// </summary>
        FDA,

        /// <summary>
        /// The CDC
        /// </summary>
        CDC,

        /// <summary>
        /// The ace
        /// </summary>
        ACE,

        /// <summary>
        /// The DHS
        /// </summary>
        DHS,

        /// <summary>
        /// The dod
        /// </summary>
        DOD,

        /// <summary>
        /// The US Naval Observatory
        /// </summary>
        USNO,

        /// <summary>
        /// The NWS
        /// </summary>
        NWS
    }
}