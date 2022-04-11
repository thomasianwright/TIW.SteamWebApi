using System.ComponentModel.DataAnnotations;

namespace TW.SteamWebApi.Models;

public class SteamWebApiSettings : ISteamWebApiSettings
{
    [Required]
    public string ApiKey { get; set; }
}