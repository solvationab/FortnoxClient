using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public class CustomerDefaultDeliveryTypesDto
    {
        public CustomerDefaultDeliveryTypesDto(
            CustomerDeliveryTypesDto invoice,
            CustomerDeliveryTypesDto order,
            CustomerDeliveryTypesDto offer)
        {
            Invoice = invoice;
            Order = order;
            Offer = offer;
        }

        [JsonPropertyName("Invoice")]
        public CustomerDeliveryTypesDto Invoice { get; } 

        [JsonPropertyName("Order")]
        public CustomerDeliveryTypesDto Order { get; } 

        [JsonPropertyName("Offer")]
        public CustomerDeliveryTypesDto Offer { get; } 
    }
}