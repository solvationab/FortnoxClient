using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.CompanyInformation
{
    public class CompanyInformationResponse
    {
        public CompanyInformationResponse(CompanyInformationDto companyInformation)
        {
            CompanyInformation = companyInformation;
        }

        [JsonPropertyName("CompanyInformation")]
        public CompanyInformationDto CompanyInformation { get; }
    }
}