using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.CompanyInformation
{
    public class CompanyInformationDto
    {
        public CompanyInformationDto(
            string address,
            string city,
            string countryCode,
            int databaseNumber,
            string companyName,
            string organizationNumber,
            string visitAddress,
            string visitCity,
            string visitCountryCode,
            string visitZipCode,
            string zipCode)
        {
            Address = address;
            City = city;
            CountryCode = countryCode;
            DatabaseNumber = databaseNumber;
            CompanyName = companyName;
            OrganizationNumber = organizationNumber;
            VisitAddress = visitAddress;
            VisitCity = visitCity;
            VisitCountryCode = visitCountryCode;
            VisitZipCode = visitZipCode;
            ZipCode = zipCode;
        }

        [JsonPropertyName("Address")]
        public string Address { get; }

        [JsonPropertyName("City")]
        public string City { get; }
        
        [JsonPropertyName("CountryCode")]
        public string CountryCode { get; }

        [JsonPropertyName("DatabaseNumber")]
        public int DatabaseNumber { get; }
        
        [JsonPropertyName("CompanyName")]
        public string CompanyName { get; }
        
        [JsonPropertyName("OrganizationNumber")]
        public string OrganizationNumber { get; }
        
        [JsonPropertyName("VisitAddress")]
        public string VisitAddress { get; }
        
        [JsonPropertyName("VisitCity")]
        public string VisitCity { get; }
        
        [JsonPropertyName("VisitCountryCode")]
        public string VisitCountryCode { get; }
        
        [JsonPropertyName("VisitZipCode")]
        public string VisitZipCode { get; }
        
        [JsonPropertyName("ZipCode")]
        public string ZipCode { get; }
    }
}