using System.Text.Json.Serialization;

namespace FortnoxClient.Dto
{
    public class ErrorInformationDto
    {
        public ErrorInformationDto(
            long error,
            string message,
            long code)
        {
            Error = error;
            Message = message;
            Code = code;
        }

        [JsonPropertyName("error")]
        public long Error { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("code")]
        public long Code { get; }
    }
}