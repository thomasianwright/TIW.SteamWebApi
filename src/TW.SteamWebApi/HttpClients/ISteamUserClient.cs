using Refit;

namespace TW.SteamWebApi.HttpClients;

public interface ISteamUserClient
{
    [Get("/ResolveVanityURL/v1/?key={key}&vanityurl={vanity}&url_type={type}")]
    public Task<IApiResponse> GetResolveVanityUrl(string key, string vanity, int type = 1);

    [Get("/GetUserGroupList/v1/?key={key}&steamid={steamid}")]
    public Task<IApiResponse> GetUserGroupList(string key, ulong steamid);
}