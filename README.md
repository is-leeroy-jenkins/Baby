#### _
## ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Resources/Assets/DemoImages/Baby.png)

## An open source web browser written in C# and released under the MIT license.

## ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/baby.png)  Features

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

## ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/tools.png)  Hotkeys

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


## ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/system_requirements.png)  System requirements

- You need [VC++ 2019 Runtime](https://aka.ms/vs/17/release/vc_redist.x64.exe) 32-bit and 64-bit versions

- You will need .NET 6.

- You need to install the version of VC++ Runtime that CEFSharp needs. Since we are using CefSharp 106, according to [this](https://github.com/cefsharp/CefSharp/#release-branches) we need the above versions


## Getting started

- See the [Compilation Guide](Docs/Compilation.md) for steps to get started.


## ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/documentation.png)  Documentation

- [User Guide](Docs/Users.md)
- [Compilation Guide](Docs/Compilation.md)
- [Configuration Guide](Docs/Configuration.md)
- [Distribution Guide](Docs/Distribution.md)


## ![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/csharp.png)  Code

- Baby uses CefSharp 106 and is built on NET 6
- Baby supports AnyCPU as well as x86/x64 specific builds
- `WebBrowser.cs` - main web browser UI and related functionality
- `Callbacks` - various handlers that we have registered with CefSharp that enable deeper integration between us and CefSharp
- `Serializers` - fast JSON serializer/deserializer
- `bin` - Binaries are included in the `bin` folder due to the complex CefSharp setup required. Don't empty this folder.
- `bin/storage` - HTML and JS required for downloads manager and custom error pages



## Baby Overview

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/Overview.gif)

## Screenshots

### Apple.com

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/1.png)

### WebAssembly & WebGL

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/5.png)

### YouTube

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/6.png)

### Google Maps

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/2.png)

### Search Bar

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/search.png)

### Downloads Tab

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/3.png)

### Developer Tools

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/4.png)

### Custom Error Pages

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/error1.png)

![](https://github.com/is-leeroy-jenkins/Baby/blob/main/Properties/error2.png)


