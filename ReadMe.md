[![Build status](https://ci.appveyor.com/api/projects/status/ber0ecdu6d4l3dr6?svg=true)](https://ci.appveyor.com/project/joelweiss/splat-serilog)
[![NuGet Badge](https://buildstats.info/nuget/Splat.Serilog?includePreReleases=true)](https://www.nuget.org/packages/Splat.Serilog/)

# Splat.Serilog

Use [Serilog](http://serilog.net/) as you [Splat](https://github.com/paulcbetts/splat) logger.

# Installation
```powershell
PM> Install-Package Splat.Serilog
```
# Setup
```csharp
Splat.Serilog.Registration.Register(_Logger.ForContext<Splat.ILogger>());
```
