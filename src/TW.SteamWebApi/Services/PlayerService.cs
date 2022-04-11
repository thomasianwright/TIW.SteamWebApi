using System.Net;
using System.Security.Authentication;
using Refit;
using TW.SteamWebApi.HttpClients;
using TW.SteamWebApi.Models;
using TW.SteamWebApi.Models.PlayerService;

namespace TW.SteamWebApi.Services;

public class PlayerService : IPlayerService
{
    private readonly IPlayerClient _client;
    private readonly ISteamWebApiSettings _settings;

    public PlayerService(IPlayerClient client, ISteamWebApiSettings settings)
    {
        _client = client;
        _settings = settings;
    }

    public async Task<RecentlyPlayedGamesResponse?> GetRecentlyPlayedGames(string steamid, int count)
    {
        var response = await _client.GetRecentlyPlayedGames(_settings.ApiKey, steamid, count);

        switch (response.StatusCode)
        {
            case HttpStatusCode.Unauthorized:
                throw new AuthenticationException("Authentication Error, check your key.");
            case HttpStatusCode.Forbidden:
                throw new AuthenticationException("Authentication Error, check your key.");
            case HttpStatusCode.InternalServerError:
                throw new WebException("Internal Server Error");
            case HttpStatusCode.OK:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return response.Content;
    }

    public async Task<OwnedGamesResponse?> GetOwnedGames(string steamid,
        bool includeFreeGames = true,
        bool includeAppInfo = true, int appIdFilter = 0)
    {
        var response = await _client.GetOwnedGames(_settings.ApiKey, steamid, includeFreeGames, includeAppInfo, appIdFilter);
        
        switch (response.StatusCode)
        {
            case HttpStatusCode.Unauthorized:
                throw new AuthenticationException("Authentication Error, check your key.");
            case HttpStatusCode.Forbidden:
                throw new AuthenticationException("Authentication Error, check your key.");
            case HttpStatusCode.InternalServerError:
                throw new WebException("Internal Server Error");
            case HttpStatusCode.OK:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return response.Content;
    }

    public async Task<GetSteamLevelResponse?> GetSteamLevel(string steamid)
    {
        var response = await _client.GetSteamLevel(_settings.ApiKey, steamid);
        
        switch (response.StatusCode)
        {
            case HttpStatusCode.Unauthorized:
                throw new AuthenticationException("Authentication Error, check your key.");
            case HttpStatusCode.Forbidden:
                throw new AuthenticationException("Authentication Error, check your key.");
            case HttpStatusCode.InternalServerError:
                throw new WebException("Internal Server Error");
            case HttpStatusCode.OK:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return response.Content;
    }

    public async Task<GetBadgesResponse?> GetBadges(string key, string steamid)
    {
        var response = await _client.GetBadges(_settings.ApiKey, steamid);
        
        switch (response.StatusCode)
        {
            case HttpStatusCode.Unauthorized:
                throw new AuthenticationException("Authentication Error, check your key.");
            case HttpStatusCode.Forbidden:
                throw new AuthenticationException("Authentication Error, check your key.");
            case HttpStatusCode.InternalServerError:
                throw new WebException("Internal Server Error");
            case HttpStatusCode.OK:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return response.Content;
    }
 
}