###### Baby
### ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Resources/Assets/DemoImages/Baby.png)



___
### ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/baby.png)  Features

- HTML5, CSS3, JS, HTML5 Video, WebGL 3D, WebAssembly, etc
- Tabbed browsing
- Address bar (also opens Google)
- Back, Forward, Stop, Refresh
- Developer tools
- Search bar (also highlights all instances)
- Download manager
- Custom error pages
- Custom context menu
- Easily add vendor-specific branding, buttons or hotkeys
- View online & offline webpages
___

### ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/tools.png)  Hotkeys

Hotkeys | Function
------------ | -------------
Ctrl+T		| Add a new tab
Ctrl+N		| Add a new window
Ctrl+W		| Close active tab
F5			| Refresh active tab
F12			| Open developer tools
Ctrl+Tab	| Switch to the next tab
Ctrl+Shift+Tab	| Switch to the previous tab
Ctrl+F		| Open search bar (Enter to find next, Esc to close)

___

### ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/system_requirements.png)  System requirements

- You need [VC++ 2019 Runtime](https://aka.ms/vs/17/release/vc_redist.x64.exe) 32-bit and 64-bit versions

- You will need .NET 6.

- You need to install the version of VC++ Runtime that CEFSharp needs. Since we are using CefSharp 106, according to [this](https://github.com/cefsharp/CefSharp/#release-branches) we need the above versions


### Getting started

- See the [Compilation Guide](Resources/Github/Compilation.md) for steps to get started.


### ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/documentation.png)  Documentation

- [User Guide](Resources/Github/Users.md)
- [Compilation Guide](Resources/Github/Compilation.md)
- [Configuration Guide](Resources/Github/Configuration.md)
- [Distribution Guide](Resources/Github/Distribution.md)


### ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/csharp.png)  Code

- Baby uses CefSharp 106 and is built on NET 6
- Baby supports AnyCPU as well as x86/x64 specific builds
- [WebBrowser.xaml.cs](https://github.com/is-leeroy-jenkins/Baby/blob/main/UI/Views/WebBrowser.xaml.cs) - main web browser UI and related functionality
- [WebBrowser.xaml](https://github.com/is-leeroy-jenkins/Baby/blob/main/UI/Views/WebBrowser.xaml) - main web browser UI and related functionality
- [Callbacks](https://github.com/is-leeroy-jenkins/Baby/tree/main/Callbacks) - various handlers that we have registered with CefSharp.
- [Delegates]() - fast JSON serializer/deserializer
- [Enumerations](https://github.com/is-leeroy-jenkins/Baby/tree/main/Enumerations) - Enumerations used by Baby.
- [Events](https://github.com/is-leeroy-jenkins/Baby/tree/main/Events) - events for the interface. 
- [Exceptions](https://github.com/is-leeroy-jenkins/Baby/tree/main/Exceptions) - custom exception classes.
- [Serializers](https://github.com/is-leeroy-jenkins/Baby/tree/main/Serializers) - custom serialization classes.
- [Views](https://github.com/is-leeroy-jenkins/Baby/tree/main/UI/Views) - windows used in the application.
- [Themes](https://github.com/is-leeroy-jenkins/Baby/tree/main/UI/Themes) - themes used on the application controls.
- [Controls](https://github.com/is-leeroy-jenkins/Baby/tree/main/UI/Controls) - classes for the Baby user interface.
- [WebPages](https://github.com/is-leeroy-jenkins/Baby/tree/main/UI/WebPages) - optional custom web page templates
- `bin` - Binaries are included in the `bin` folder due to the complex CefSharp setup required. Don't empty this folder.
- `bin/storage` - HTML and JS required for downloads manager and custom error pages

___

### Baby Overview


![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/Overview.gif)


### Apple.com

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/1.png)


### WebAssembly & WebGL

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/5.png)


### YouTube

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/6.png)


## Google Maps

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/2.png)


### Search Bar

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/search.png)


### Downloads Tab

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/3.png)


### Developer Tools

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/4.png)

___

### ![](https://github.com/is-leeroy-jenkins/Bubba/blob/master/Resources/Assets/GitHubImages/chrome.png) CefSharp Requirements

#### The binaries directory must contain these required dependencies:

- libcef.dll (Chromium Embedded Framework Core library)
- icudtl.dat (Unicode Support data)
- chrome_elf.dll(Crash reporting library)
- snapshot_blob.bin, v8_context_snapshot.bin (V8 snapshot data)
- locales\en-US.pak, chrome_100_percent.pak, chrome_200_percent.pak, resources.pak, 
- d3dcompiler_47.dll 
- libEGL.dll 
- libGLESv2.dll

#### Whilst these are technically listed as optional, the browser is unlikely to function without these files.

- CefSharp.Core.dll, CefSharp.dll 
- CefSharp.Core.Runtime.dll
- CefSharp.BrowserSubprocess.exe 
- CefSharp.BrowserSubProcess.Core.dll

#### These are required CefSharp binaries that are the common core logic binaries of CefSharp (only 1 required).

- CefSharp.WinForms.dll
- CefSharp.Wpf.dll
- CefSharp.OffScreen.dll

#### By default `CEF` has it's own log file, `Debug.log` which is located in your executing folder. e.g. `bin`




### 🙏 Acknowledgements

Bubba uses the following projects and libraries. Please consider supporting them as well (e.g., by starring their repositories):

|                                 Library                                       |             Description                                                |
| ----------------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| [CefSharp.WPF.Core](https://github.com/cefsharp)                              | .NET (WPF/Windows Forms) bindings for the Chromium Embedded Framework  |
| [Epplus](https://github.com/EPPlusSoftware/EPPlus)                  		    | EPPlus-Excel spreadsheets for .NET      								 |
| [Google.Api.CustomSearchAPI.v1](https://developers.google.com/custom-search)  | Google APIs Client Library for working with Customsearch v1            |
| [LinqStatistics](https://www.nuget.org/packages/LinqStatistics)                     | Linq extensions to calculate basic statistics.                                                 |
| [System.Data.SqlServerCe](https://www.nuget.org/packages/System.Data.SqlServerCe_unofficial)                  | Unofficial package of System.Data.SqlServerCe.dll if you need it as dependency.      |
| [Microsoft.Office.Interop.Outlook 15.0.4797.1004](https://www.nuget.org/packages/Microsoft.Office.Interop.Outlook)                        | This an assembly you can use for Outlook 2013/2016/2019 COM interop, generated and signed by Microsoft. This is entirely unsupported and there is no license since it is a repackaging of Office assemblies.                                       |
| [ModernWpfUI 0.9.6](https://www.nuget.org/packages/ModernWpfUI/0.9.7-preview.2)                     | Modern styles and controls for your WPF applications.         |
| [Newtonsoft.Json 13.0.3](https://www.nuget.org/packages/Newtonsoft.Json)                                          | Json.NET is a popular high-performance JSON framework for .NET                  |
| [RestoreWindowPlace 2.1.0](https://www.nuget.org/packages/RestoreWindowPlace)                                             | Save and restore the place of the WPF window                                           |
| [SkiaSharp 2.88.9](https://github.com/mono/SkiaSharp)   | SkiaSharp is a cross-platform 2D graphics API for .NET platforms based on Google's Skia Graphics Library.                           |
| [Syncfusion.Licensing 24.1.41](https://www.nuget.org/packages/Syncfusion.Licensing)                           | Syncfusion licensing is a .NET library for validating the registered Syncfusion license in an application at runtime.         |
| [System.Data.OleDb 9.0.0](https://www.nuget.org/packages/System.Data.OleDb)  | This package implements a data provider for OLE DB data sources.                            |
| [System.Data.SqlClient 4.9.0](https://www.nuget.org/packages/System.Data.SqlClient) | The legacy .NET Data Provider for SQL Server.                       |
| [MahApps.Metro](https://mahapps.com/)                                         | UI toolkit for WPF applications                                        |
| [System.Data.SQLite.Core](https://www.nuget.org/packages/System.Data.SQLite.Core)                        | The official SQLite database engine for both x86 and x64 along with the ADO.NET provider. |
| [System.Speech 9.0.0](https://www.nuget.org/packages/System.Speech)          | Provides APIs for speech recognition and synthesis built on the Microsoft Speech API in Windows.                               |
| [ToastNotifications.Messages.Net6 1.0.4](https://github.com/rafallopatka/ToastNotifications)          | Toast notifications for WPF allows you to create and display rich notifications in WPF applications.                              |                           |
| [Syncfusion.SfSkinManager.WPF 24.1.41](https://www.nuget.org/packages/Syncfusion.SfSkinManager.WPF)          | The Syncfusion WPF Skin Manageris a .NET UI library that contains the SfSkinManager class, which helps apply the built-in themes to the Syncfusion UI controls for WPF.                               |
| [Syncfusion.Shared.Base 24.1.41](https://www.nuget.org/packages/Syncfusion.Shared.Base)          | Syncfusion WinForms Shared Components                               |
| [Syncfusion.Shared.WPF 24.1.41](https://www.nuget.org/packages/Syncfusion.Shared.WPF)          | Syncfusion WPF components                               |
| [Syncfusion.Themes.FluentDark.WPF 24.1.41](https://www.nuget.org/packages/Syncfusion.Themes.FluentDark.WPF)          | The Syncfusion WPF Fluent Dark Theme for WPF contains the style resources to change the look and feel of a WPF application to be similar to the modern Windows UI style introduced in Windows 8 apps.                               |
| [Syncfusion.Tools.WPF 24.1.41](https://www.nuget.org/packages/Syncfusion.Tools.WPF)          | This package contains WPF AutoComplete, WPF DockingManager, WPF Navigation Pane, WPF Hierarchy Navigator, WPF Range Slider, WPF Ribbon, WPF TabControl, WPF Wizard, and WPF Badge components for WPF application.                               |
| [Syncfusion.UI.WPF.NET 24.1.41](https://www.nuget.org/packages/Syncfusion.UI.WPF.NET)          | Syncfusion WPF Controls is a library of 100+ WPF UI components and file formats to build modern WPF applications. 


___

### ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Resources/Assets/GitHubImages/signature.png)  Code Signing 

Baby uses free code signing provided by [SignPath.io](https://signpath.io/) and a free code signing certificate
from [SignPath Foundation](https://signpath.org/).

The binaries and installer are built on [AppVeyor](https://ci.appveyor.com/project/is-leeroy-jenkins/networkmanager) directly from the [GitHub repository](https://github.com/is-leeroy-jenkins/Baby/blob/main/appveyor.yml).
Build artifacts are automatically sent to [SignPath.io](https://signpath.io/) via webhook, where they are signed after manual approval by the maintainer.
The signed binaries are then uploaded to the [GitHub releases](https://github.com/is-leeroy-jenkins/Baby/releases) page.


### ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Resources/Assets/GitHubImages/web.png) Privacy Policy

This program will not transfer any information to other networked systems unless specifically requested by the user or the person installing or operating it.

Baby has integrated the following services for additional functions, which can be enabled or disabled at the first start (in the welcome dialog) or at any time in the settings:

- [api.github.com](https://docs.github.com/en/site-policy/privacy-policies/github-general-privacy-statement) (Check for program updates)
- [ipify.org](https://www.ipify.org/) (Retrieve the public IP address used by the client)
- [ip-api.com](https://ip-api.com/docs/legal) (Retrieve network information such as geo location, ISP, DNS resolver used, etc. used by the client)

___

### 📝 License

Baby is published under the [MIT General Public License v3](https://github.com/is-leeroy-jenkins/Baby/blob/main/LICENSE).

The licenses of the libraries used can be found [here](https://github.com/is-leeroy-jenkins/Baby/tree/main/Resources/Licenses).
