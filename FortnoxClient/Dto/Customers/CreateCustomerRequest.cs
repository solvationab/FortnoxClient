using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public class CreateCustomerRequest
    {
        public CreateCustomerRequest(CustomerDto customer)
        {
            Customer = customer;
        }

        [JsonPropertyName("Customer")]
        public CustomerDto Customer { get; }
    }
}