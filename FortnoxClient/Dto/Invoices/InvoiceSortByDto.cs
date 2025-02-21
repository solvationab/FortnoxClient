using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Invoices
{
    public enum InvoiceSortByDto
    {
        [EnumMember(Value = "customername")]
        CustomerName,

        [EnumMember(Value = "customernumber")]
        CustomerNumber,

        [EnumMember(Value = "documentnumber")]
        DocumentNumber,

        [EnumMember(Value = "invoicedate")]
        InvoiceDate,

        [EnumMember(Value = "ocr")]
        Ocr,

        [EnumMember(Value = "total")]
        Total
    }
}