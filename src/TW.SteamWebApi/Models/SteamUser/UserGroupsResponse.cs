using System.Text.Json.Serialization;

namespace TW.SteamWebApi.Models.SteamUser;
public class UserGroupsResponse
{
    [JsonPropertyName("response")]
    public SteamResponse Response { get; set; }
    
    public class Group
    {
        [JsonPropertyName("gid")]
        public string Gid { get; set; }
    }

    public class SteamResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("groups")]
        public List<Group> Groups { get; set; }
    }
}