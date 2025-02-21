using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public class GetOrderResponse
    {
        public GetOrderResponse(OrderDto order)
        {
            Order = order;
        }

        [JsonPropertyName("Order")]
        public OrderDto Order { get; }
    }
}