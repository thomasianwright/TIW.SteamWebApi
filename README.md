# TIW.SteamWebApi
A steam api wrapping for .NET Core

# Setup
This wrapper is used with DI inmind. 

```csharp
services.AddSteamWebApi(new SteamWebApiSettings
   {
       ApiKey = "<STEAMAPIKEY>"
   });
```
