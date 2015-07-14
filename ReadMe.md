#Splat.Serilog

Use [Serilog](http://serilog.net/) as you [Splat](https://github.com/paulcbetts/splat) logger.

# Installation
```powershell
PM> Install-Package Splat.Serilog
```
# Setup
```csharp
Splat.Serilog.Registration.Register(_Logger.ForContext<Splat.ILogger>());
```