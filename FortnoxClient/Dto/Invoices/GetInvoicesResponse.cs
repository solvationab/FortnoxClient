using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Invoices
{
    public class GetInvoicesResponse : ListResponseBase
    {
        public GetInvoicesResponse(
            IReadOnlyCollection<InvoiceListItemDto> invoices, 
            MetaInformationDto metaInformation
            ) : base(metaInformation)
        {
            Invoices = invoices;
        }

        [JsonPropertyName("Invoices")]
        public IReadOnlyCollection<InvoiceListItemDto> Invoices { get; } 
    }
}
