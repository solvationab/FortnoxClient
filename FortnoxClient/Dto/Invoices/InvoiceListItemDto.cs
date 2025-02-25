using System;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Invoices
{
    public class InvoiceListItemDto
    {
        public InvoiceListItemDto(
            string url,
            double balance,
            bool booked,
            bool cancelled,
            string costCenter,
            string currency,
            double currencyRate,
            double currencyUnit,
            string customerName,
            string customerNumber,
            string documentNumber,
            DateTime dueDate,
            string externalInvoiceReference1,
            string externalInvoiceReference2,
            DateTime? finalPayDate,
            DateTime invoiceDate,
            InvoiceTypesDto invoiceType,
            bool noxFinans,
            string ocr,
            string project,
            bool sent,
            string termsOfPayment,
            double total,
            int? voucherNumber,
            string voucherSeries,
            int? voucherYear,
            string wayOfDelivery
            )
        {
            Url = url;
            Balance = balance;
            Booked = booked;
            Cancelled = cancelled;
            CostCenter = costCenter;
            Currency = currency;
            CurrencyRate = currencyRate;
            CurrencyUnit = currencyUnit;
            CustomerName = customerName;
            CustomerNumber = customerNumber;
            DocumentNumber = documentNumber;
            DueDate = dueDate;
            ExternalInvoiceReference1 = externalInvoiceReference1;
            ExternalInvoiceReference2 = externalInvoiceReference2;
            FinalPayDate = finalPayDate;
            InvoiceDate = invoiceDate;
            InvoiceType = invoiceType;
            NoxFinans = noxFinans;
            OCR = ocr;
            Project = project;
            Sent = sent;
            TermsOfPayment = termsOfPayment;
            Total = total;
            VoucherNumber = voucherNumber;
            VoucherSeries = voucherSeries;
            VoucherYear = voucherYear;
            WayOfDelivery = wayOfDelivery;
        }

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