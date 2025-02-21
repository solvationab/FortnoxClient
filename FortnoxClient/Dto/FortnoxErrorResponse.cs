using System.Text.Json.Serialization;

namespace FortnoxClient.Dto
{
    public class FortnoxErrorResponse
    {
        public FortnoxErrorResponse(ErrorInformationDto errorInformation)
        {
            ErrorInformation = errorInformation;
        }

        [JsonPropertyName("ErrorInformation")]
        public ErrorInformationDto ErrorInformation { get; }
    }
}