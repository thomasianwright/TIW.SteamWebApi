![Nuget](https://img.shields.io/nuget/dt/TIW.SteamWebApi)
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

Use the services provided.

ISteamUserService

IPlayerService

## Docs
The naming is inline with valves documenation on the api
