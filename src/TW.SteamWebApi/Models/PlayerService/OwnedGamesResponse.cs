using System.Text.Json.Serialization;

namespace TW.SteamWebApi.Models.PlayerService;

public class OwnedGamesResponse
{
    [JsonPropertyName("response")]
    public SteamResponse? Response { get; set; }
    
    public class Game
    {
        [JsonPropertyName("appid")]
        public int Appid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("playtime_forever")]
        public int PlaytimeForever { get; set; }

        [JsonPropertyName("img_icon_url")]
        public string ImgIconUrl { get; set; }

        [JsonPropertyName("playtime_windows_forever")]
        public int PlaytimeWindowsForever { get; set; }

        [JsonPropertyName("playtime_mac_forever")]
        public int PlaytimeMacForever { get; set; }

        [JsonPropertyName("playtime_linux_forever")]
        public int PlaytimeLinuxForever { get; set; }

        [JsonPropertyName("has_community_visible_stats")]
        public bool? HasCommunityVisibleStats { get; set; }
    }

    public class SteamResponse
    {
        [JsonPropertyName("game_count")]
        public int GameCount { get; set; }

        [JsonPropertyName("games")]
        public List<Game> Games { get; set; }
    }
}