using System.Net;
using System.Security.Authentication;
using Refit;
using TW.SteamWebApi.HttpClients;
using TW.SteamWebApi.Models;
using TW.SteamWebApi.Models.SteamUser;

namespace TW.SteamWebApi.Services;

public class SteamUserService : ISteamUserService
{
    private readonly ISteamWebApiSettings _settings;
    private readonly ISteamUserClient _client;

    public SteamUserService(ISteamWebApiSettings settings, ISteamUserClient client)
    {
        _settings = settings;
        _client = client;
    }

    public async Task<ResolveVanityUrlResponse?> GetVanityUrl(string vanity)
    {
        var response = await _client.GetResolveVanityUrl(_settings.ApiKey, vanity);
        
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

    public async Task<PlayerBansResponse?> GetPlayerBans(string[] steamids)
    {
        string ids = string.Join(",", steamids);
        var response = await _client.GetPlayerBans(_settings.ApiKey, ids);
        
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

    public async Task<UserGroupsResponse?> GetUserGroups(string steamid)
    {
        var response = await _client.GetUserGroupList(_settings.ApiKey, steamid);
        
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