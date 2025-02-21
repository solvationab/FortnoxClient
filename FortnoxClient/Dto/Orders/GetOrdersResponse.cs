using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public class GetOrdersResponse : ListResponseBase
    {
        public GetOrdersResponse(
            MetaInformationDto metaInformation, 
            IReadOnlyList<OrderListItemDto> orders
            ) : base(metaInformation)
        {
            Orders = orders;
        }

        [JsonPropertyName("Orders")]
        public IReadOnlyList<OrderListItemDto> Orders { get; }
    }
}
