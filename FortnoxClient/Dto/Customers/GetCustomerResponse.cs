namespace FortnoxClient.Dto.Customers
{
    public class GetCustomerResponse
    {
        public GetCustomerResponse(CustomerDto customer)
        {
            Customer = customer;
        }

        public CustomerDto Customer { get; }
    }
}