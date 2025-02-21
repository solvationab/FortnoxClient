using System;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public class OrderListItemDto
    {
        public OrderListItemDto(
            string url,
            bool? cancelled,
            string currency,
            string customerName,
            string customerNumber,
            DateTime? deliveryDate,
            string documentNumber,
            string externalInvoiceReference1,
            string externalInvoiceReference2,
            DateTime? orderDate,
            string orderType,
            string project,
            bool? sent,
            double? total)
        {
            Url = url;
            Cancelled = cancelled;
            Currency = currency;
            CustomerName = customerName;
            CustomerNumber = customerNumber;
            DeliveryDate = deliveryDate;
            DocumentNumber = documentNumber;
            ExternalInvoiceReference1 = externalInvoiceReference1;
            ExternalInvoiceReference2 = externalInvoiceReference2;
            OrderDate = orderDate;
            OrderType = orderType;
            Project = project;
            Sent = sent;
            Total = total;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("Cancelled")]
        public bool? Cancelled { get; }

        [JsonPropertyName("Currency")] // string[0..3] characters
        public string Currency { get; }

        [JsonPropertyName("CustomerName")]
        public string CustomerName { get; }

        [JsonPropertyName("CustomerNumber")] // required
        public string CustomerNumber { get; }

        [JsonPropertyName("DeliveryDate")]
        public DateTime? DeliveryDate { get; }

        [JsonPropertyName("DocumentNumber")]
        public string DocumentNumber { get; }

        [JsonPropertyName("ExternalInvoiceReference1")]
        public string ExternalInvoiceReference1 { get; }

        [JsonPropertyName("ExternalInvoiceReference2")]
        public string ExternalInvoiceReference2 { get; }

        [JsonPropertyName("OrderDate")]
        public DateTime? OrderDate { get; }

        [JsonPropertyName("OrderType")]
        public string OrderType { get; }

        [JsonPropertyName("Project")]
        public string Project { get; }

        [JsonPropertyName("Sent")]
        public bool? Sent { get; }

        [JsonPropertyName("Total")]
        public double? Total { get; }
    }
}