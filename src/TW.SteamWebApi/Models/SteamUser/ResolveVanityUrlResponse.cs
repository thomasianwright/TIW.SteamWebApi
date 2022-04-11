using System.Text.Json.Serialization;

namespace TW.SteamWebApi.Models.SteamUser;

public class ResolveVanityUrlResponse
{
    [JsonPropertyName("response")]
    public SteamResponse Response { get; set; }
    
    public class SteamResponse
    {
        [JsonPropertyName("steamid")]
        public string Steamid { get; set; }

        [JsonPropertyName("success")]
        public int Success { get; set; }
    }
}
