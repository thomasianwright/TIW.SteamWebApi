using Refit;
using TW.SteamWebApi.Models.SteamUser;

namespace TW.SteamWebApi.HttpClients;

public interface ISteamUserClient
{
    [Get("/ResolveVanityURL/v1/?key={key}&vanityurl={vanity}&url_type={type}")]
    public Task<IApiResponse<ResolveVanityUrlResponse?>> GetResolveVanityUrl(string key, string vanity, int type = 1);

    [Get("/GetUserGroupList/v1/?key={key}&steamid={steamid}")]
    public Task<IApiResponse<UserGroupsResponse?>> GetUserGroupList(string key, string steamid);

    [Get("/GetPlayerBans/v1/?key={key}&steamids={steamids}")]
    public Task<IApiResponse<PlayerBansResponse>> GetPlayerBans(string key, string steamids);
}