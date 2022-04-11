using Refit;
using TW.SteamWebApi.Models.PlayerService;

namespace TW.SteamWebApi.HttpClients;

public interface IPlayerService
{
    [Get("/GetRecentlyPlayedGames/v1/?key={key}&steamid={steamid}&count={count}")]
    public Task<IApiResponse<RecentlyPlayedGames>> GetRecentlyPlayedGames(string key, ulong steamid, int count = 0);

    public Task<IApiResponse> GetOwnedGames(string key, ulong steamid, [AliasAs("include_played_free_games")] bool includeFreeGames = true,
       [AliasAs("include_appinfo")] bool includeAppInfo = true, [AliasAs("appids_filter")] int appIdFilter = 0);
    
    
}