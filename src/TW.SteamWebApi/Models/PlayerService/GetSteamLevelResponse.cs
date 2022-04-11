using System.Text.Json.Serialization;

namespace TW.SteamWebApi.Models.PlayerService;

public class GetSteamLevelResponse
{
    [JsonPropertyName("response")]
    public SteamResponse Response { get; set; }
    
    public class SteamResponse
    {
        [JsonPropertyName("player_level")]
        public int PlayerLevel { get; set; }
    }
}
