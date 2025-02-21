using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public class CreateOrderResponse
    {
        public CreateOrderResponse(OrderDto order)
        {
            Order = order;
        }

        [JsonPropertyName("Order")]
        public OrderDto Order { get; }
    }
}