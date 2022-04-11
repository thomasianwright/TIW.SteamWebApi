using TW.SteamWebApi.Models.PlayerService;

namespace TW.SteamWebApi.Services;

public interface IPlayerService
{
    Task<RecentlyPlayedGamesResponse?> GetRecentlyPlayedGames(ulong steamid, int count);

    Task<OwnedGamesResponse?> GetOwnedGames(ulong steamid,
        bool includeFreeGames = true,
        bool includeAppInfo = true, int appIdFilter = 0);

    Task<GetSteamLevelResponse?> GetSteamLevel(ulong steamid);
    Task<GetBadgesResponse?> GetBadges(string key, ulong steamid);
}