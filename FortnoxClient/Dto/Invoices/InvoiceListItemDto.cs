using System;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Invoices
{
    public class InvoiceListItemDto
    {
        [JsonPropertyName("@url")]
        public string Url { get; } 

        [JsonPropertyName("Balance")]
        public double Balance { get; }

        [JsonPropertyName("Booked")]
        public bool Booked { get; }

        [JsonPropertyName("Cancelled")]
        public bool Cancelled { get; }

        [JsonPropertyName("CostCenter")]
        public string CostCenter { get; }

        [JsonPropertyName("Currency")]
        public string Currency { get; }

        [JsonPropertyName("CurrencyRate")]
        public double CurrencyRate { get; }

        [JsonPropertyName("CurrencyUnit")]
        public double CurrencyUnit { get; }

        [JsonPropertyName("CustomerName")]
        public string CustomerName { get; }

        [JsonPropertyName("CustomerNumber")]
        public string CustomerNumber { get; }

        [JsonPropertyName("DocumentNumber")]
        public string DocumentNumber { get; }

        [JsonPropertyName("DueDate")]
        public DateTime DueDate { get; }

        [JsonPropertyName("ExternalInvoiceReference1")]
        public string ExternalInvoiceReference1 { get; }

        [JsonPropertyName("ExternalInvoiceReference2")]
        public string ExternalInvoiceReference2 { get; }

        [JsonPropertyName("FinalPayDate")]
        public DateTime? FinalPayDate { get; }

        [JsonPropertyName("InvoiceDate")]
        public DateTime InvoiceDate { get; }

        [JsonPropertyName("InvoiceType")]
        public InvoiceTypesDto InvoiceType { get; }

        [JsonPropertyName("NoxFinans")]
        public bool NoxFinans { get; }

        [JsonPropertyName("OCR")]
        public string OCR { get; }

        [JsonPropertyName("Project")]
        public string Project { get; }

        [JsonPropertyName("Sent")]
        public bool Sent { get; }

        [JsonPropertyName("TermsOfPayment")]
        public string TermsOfPayment { get; }

        [JsonPropertyName("Total")]
        public double Total { get; }

        [JsonPropertyName("VoucherNumber")]
        public int? VoucherNumber { get; }

        [JsonPropertyName("VoucherSeries")]
        public string VoucherSeries { get; }

        [JsonPropertyName("VoucherYear")]
        public int? VoucherYear { get; }

        [JsonPropertyName("WayOfDelivery")]
        public string WayOfDelivery { get; }
    }
}