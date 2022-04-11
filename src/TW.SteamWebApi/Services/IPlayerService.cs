using TW.SteamWebApi.Models.PlayerService;

namespace TW.SteamWebApi.Services;

public interface IPlayerService
{
    Task<RecentlyPlayedGamesResponse?> GetRecentlyPlayedGames(string steamid, int count);

    Task<OwnedGamesResponse?> GetOwnedGames(string steamid,
        bool includeFreeGames = true,
        bool includeAppInfo = true, int appIdFilter = 0);

    Task<GetSteamLevelResponse?> GetSteamLevel(string steamid);
    Task<GetBadgesResponse?> GetBadges(string key, string steamid);
}