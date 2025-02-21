using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public class CreateCustomerResponse
    {
        public CreateCustomerResponse(CustomerDto customer)
        {
            Customer = customer;
        }

        [JsonPropertyName("Customer")]
        public CustomerDto Customer { get; }
    }
}