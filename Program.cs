// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-26-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-28-2023
// ******************************************************************************************
// <copyright file="Program.cs" company="Terry D. Eppler">
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
//   Program.cs
// </summary>
// ******************************************************************************************

namespace BudgetBrowser
{
    using System;
    using System.Windows.Forms;
    using Syncfusion.Licensing;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "ArrangeTypeModifiers" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [ STAThread ]
        private static void Main( )
        {
            SyncfusionLicenseProvider.RegisterLicense(
                "MjIyNzQwMEAzMjMxMmUzMTJlMzMzNWJ6Ylo1L05Bcm1yT0wyenJGMWhFM21xdUJlUERvMUdOUmE3MnBJUjJFbzQ9;MjIyNzQwMUAzMjMxMmUzMTJlMzMzNUZUcGV5Y29yQkkvS0lNVWl1RTBSTTArYmFJQ3Z0NHZMK1FYYm0zOFo1OGM9" );

            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new WebBrowser( ) );
        }
    }
}