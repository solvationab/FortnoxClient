using System.Text.Json.Serialization;

#pragma warning disable CA1056

namespace FortnoxClient.Dto.Customers
{
    public class CustomerListItemDto
    {
        public CustomerListItemDto(
            string url,
            string address1,
            string address2,
            string city,
            string customerNumber,
            string email,
            string name,
            string organisationNumber,
            string phone,
            string zipCode)
        {
            Url = url;
            Address1 = address1;
            Address2 = address2;
            City = city;
            CustomerNumber = customerNumber;
            Email = email;
            Name = name;
            OrganisationNumber = organisationNumber;
            Phone = phone;
            ZipCode = zipCode;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("Address1")]
        public string Address1 { get; } // [0..1024] characters

        [JsonPropertyName("Address2")]
        public string Address2 { get; } // [0..1024] characters

        [JsonPropertyName("City")]
        public string City { get; } // [0..1024] characters

        [JsonPropertyName("CustomerNumber")]
        public string CustomerNumber { get; } // [0..1024] characters

        [JsonPropertyName("Email")]
        public string Email { get; } // [0..1024] characters

        [JsonPropertyName("Name")]
        public string Name { get; } // required [1..1024] characters

        [JsonPropertyName("OrganisationNumber")]
        public string OrganisationNumber { get; } // [0..30] characters

        [JsonPropertyName("Phone")]
        public string Phone { get; } // [0..1024] characters

        [JsonPropertyName("ZipCode")]
        public string ZipCode { get; } // [0..10] characters
    }
}