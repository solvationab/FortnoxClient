using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public class CreateOrderRequest
    {
        public CreateOrderRequest(OrderDto order)
        {
            Order = order;
        }

        [JsonPropertyName("Order")]
        public OrderDto Order { get; }
    }
}
