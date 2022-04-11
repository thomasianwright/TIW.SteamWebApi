using Refit;
using TW.SteamWebApi.Models.PlayerService;

namespace TW.SteamWebApi.HttpClients;

public interface IPlayerClient
{
    [Get("/GetRecentlyPlayedGames/v1/?key={key}&steamid={steamid}&count={count}")]
    public Task<IApiResponse<RecentlyPlayedGamesResponse?>> GetRecentlyPlayedGames([AliasAs("key")] string key,
        [AliasAs("steamid")] string steamid, [AliasAs("count")] int count = 0);

    [Get(
        "/GetOwnedGames/v1/?key={key}&steamid={steamid}&include_appinfo={includeAppInfo}&include_played_free_games={includeFreeGames}&appids_filter={appIdFilter}")]
    public Task<IApiResponse<OwnedGamesResponse?>> GetOwnedGames([AliasAs("key")] string key,
        [AliasAs("steamid")] string steamid,
        [AliasAs("includeFreeGames")] bool includeFreeGames = true,
        [AliasAs("includeAppInfo")] bool includeAppInfo = true, [AliasAs("appIdFilter")] int appIdFilter = 0);

    [Get("/GetSteamLevel/v1/?key={key}&steamid={steamid}")]
    public Task<IApiResponse<GetSteamLevelResponse?>> GetSteamLevel([AliasAs("key")] string key,
        [AliasAs("steamid")] string steamid);

    [Get("/GetBadges/v1/?key={key}&steamid={steamid}")]
    public Task<IApiResponse<GetBadgesResponse?>> GetBadges([AliasAs("key")] string key,
        [AliasAs("steamid")] string steamid);

    // TODO: Add get badge progress
}