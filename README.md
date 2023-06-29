![BudgetBrowser](Resources/Images/logo3.png)

BudgetBrowser is an open source C# web browser!. Slightly faster than Google Chrome when rendering web pages due to lightweight CEF renderer. We compared every available .NET browsing engine and finally settled on the high-performance [CefSharp](https://github.com/cefsharp/CefSharp/). Released under the permissive MIT license.

## Features

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

## Hotkeys

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


## System requirements

- You need [VC++ 2019 Runtime](https://aka.ms/vs/17/release/vc_redist.x64.exe) 32-bit and 64-bit versions

- You will need .NET 6.

- You need to install the version of VC++ Runtime that CEFSharp needs. Since we are using CefSharp 106, according to [this](https://github.com/cefsharp/CefSharp/#release-branches) we need the above versions


## Getting started

- See the [Compilation Guide](Docs/Compilation.md) for steps to get started.


## Documentation

- [User Guide](Docs/Users.md)
- [Compilation Guide](Docs/Compilation.md)
- [Configuration Guide](Docs/Configuration.md)
- [Distribution Guide](Docs/Distribution.md)


## Code

- BudgetBrowser uses CefSharp 106 and is built on NET 6
- BudgetBrowser supports AnyCPU as well as x86/x64 specific builds
- `WebBrowser.cs` - main web browser UI and related functionality
- `Handlers` - various handlers that we have registered with CefSharp that enable deeper integration between us and CefSharp
- `Serializers` - fast JSON serializer/deserializer
- `bin` - Binaries are included in the `bin` folder due to the complex CefSharp setup required. Don't empty this folder.
- `bin/storage` - HTML and JS required for downloads manager and custom error pages

## Credits

## Screenshots

### Apple.com

![](Resources/Images/1.png)

### WebAssembly & WebGL

![](Resources/Images/5.png)

### YouTube

![](Resources/Images/6.png)

### Google Maps

![](Resources/Images/2.png)

### Search Bar

![](Resources/Images/search.png)

### Downloads Tab

![](Resources/Images/3.png)

### Developer Tools

![](Resources/Images/4.png)

### Custom Error Pages

![](Resources/Images/error1.png)

![](Resources/Images/error2.png)

