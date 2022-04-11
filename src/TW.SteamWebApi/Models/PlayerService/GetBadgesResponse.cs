using System.Text.Json.Serialization;

namespace TW.SteamWebApi.Models.PlayerService;

public class GetBadgesResponse
{
    [JsonPropertyName("response")]
    public SteamResponse Response { get; set; }
    
    public class Badge
    {
        [JsonPropertyName("badgeid")]
        public int Badgeid { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("completion_time")]
        public int CompletionTime { get; set; }

        [JsonPropertyName("xp")]
        public int Xp { get; set; }

        [JsonPropertyName("scarcity")]
        public int Scarcity { get; set; }

        [JsonPropertyName("appid")]
        public int? Appid { get; set; }

        [JsonPropertyName("communityitemid")]
        public string Communityitemid { get; set; }

        [JsonPropertyName("border_color")]
        public int? BorderColor { get; set; }
    }

    public class SteamResponse
    {
        [JsonPropertyName("badges")]
        public List<Badge> Badges { get; set; }

        [JsonPropertyName("player_xp")]
        public int PlayerXp { get; set; }

        [JsonPropertyName("player_level")]
        public int PlayerLevel { get; set; }

        [JsonPropertyName("player_xp_needed_to_level_up")]
        public int PlayerXpNeededToLevelUp { get; set; }

        [JsonPropertyName("player_xp_needed_current_level")]
        public int PlayerXpNeededCurrentLevel { get; set; }
    }
}

