using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public class GetCustomerListResponse : ListResponseBase
    {
        public GetCustomerListResponse(
            MetaInformationDto metaInformation,
            IEnumerable<CustomerListItemDto> customers) : base(metaInformation)
        {
            Customers = customers;
        }

        [JsonPropertyName("Customers")]
        public IEnumerable<CustomerListItemDto> Customers { get; }
    }
}