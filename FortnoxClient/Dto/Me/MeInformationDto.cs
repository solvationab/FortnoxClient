using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Me
{
    public class MeInformationDto
    {
        [JsonPropertyName("Email")]
        public string Email { get; }

        [JsonPropertyName("Id")]
        public string Id { get; }

        [JsonPropertyName("Locale")]
        public string Locale { get; }

        [JsonPropertyName("Name")]
        public string Name { get; }

        [JsonPropertyName("SysAdmin")]
        public bool SysAdmin { get; }
    }
}