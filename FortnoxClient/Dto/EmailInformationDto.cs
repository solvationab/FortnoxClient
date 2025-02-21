using System.Text.Json.Serialization;

namespace FortnoxClient.Dto
{
    public class EmailInformationDto
    {
        public EmailInformationDto(
            string emailAddressFrom,
            string emailAddressTo,
            string emailAddressCc,
            string emailAddressBcc,
            string emailSubject,
            string emailBody)
        {
            EmailAddressFrom = emailAddressFrom;
            EmailAddressTo = emailAddressTo;
            EmailAddressCc = emailAddressCc;
            EmailAddressBcc = emailAddressBcc;
            EmailSubject = emailSubject;
            EmailBody = emailBody;
        }

        [JsonPropertyName("EmailAddressFrom")]
        public string EmailAddressFrom { get; }

        [JsonPropertyName("EmailAddressTo")]
        public string EmailAddressTo { get; }

        [JsonPropertyName("EmailAddressCC")]
        public string EmailAddressCc { get; }

        [JsonPropertyName("EmailAddressBCC")]
        public string EmailAddressBcc { get; }

        [JsonPropertyName("EmailSubject")]
        public string EmailSubject { get; }

        [JsonPropertyName("EmailBody")]
        public string EmailBody { get; }
    }
}