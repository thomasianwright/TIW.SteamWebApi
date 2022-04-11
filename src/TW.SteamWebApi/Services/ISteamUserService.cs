using TW.SteamWebApi.Models.SteamUser;

namespace TW.SteamWebApi.Services;

public interface ISteamUserService
{
    Task<ResolveVanityUrlResponse?> GetVanityUrl(string vanity);
    Task<PlayerBansResponse?> GetPlayerBans(string[] steamids);
    Task<UserGroupsResponse?> GetUserGroups(string steamid);
}