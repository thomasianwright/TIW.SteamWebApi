using Microsoft.Extensions.DependencyInjection;
using Refit;
using TW.SteamWebApi.HttpClients;
using TW.SteamWebApi.Models;
using TW.SteamWebApi.Services;

namespace TW.SteamWebApi.Core;

public static class AddSteamWebApiExt
{
    public static void AddSteamWebApi(this IServiceCollection sp, ISteamWebApiSettings settings)
    {
        sp.AddSingleton<ISteamWebApiSettings>(_ => settings);

        sp.AddRefitClient<IPlayerClient>()
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://api.steampowered.com/IPlayerService");
            });

        sp.AddRefitClient<ISteamUserClient>()
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://api.steampowered.com/ISteamUser");
            });

        sp.AddSingleton<IPlayerService, PlayerService>();
    }
}