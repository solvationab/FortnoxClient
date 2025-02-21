using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Me
{
    public class MeResponse
    {
        public MeResponse(MeInformationDto meInformation)
        {
            MeInformation = meInformation;
        }

        [JsonPropertyName("Me")]
        public MeInformationDto MeInformation { get; }
    }
}