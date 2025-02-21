using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public class CustomerDefaultTemplatesDto
    {
        public CustomerDefaultTemplatesDto(
            string cashInvoice,
            string invoice,
            string offer,
            string order)
        {
            CashInvoice = cashInvoice;
            Invoice = invoice;
            Offer = offer;
            Order = order;
        }

        [JsonPropertyName("CashInvoice")]
        public string CashInvoice { get; }

        [JsonPropertyName("Invoice")]
        public string Invoice { get; }

        [JsonPropertyName("Offer")]
        public string Offer { get; }

        [JsonPropertyName("Order")]
        public string Order { get; }
    }
}