using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Invoices
{
    public enum InvoiceTypesDto
    {
        [EnumMember(Value = "INVOICE")]
        Invoice,
        
        [EnumMember(Value = "AGREEMENTINVOICE")]
        AgreementInvoice,
        
        [EnumMember(Value = "INTRESTINVOICE")]
        IntrestInvoice,
        
        [EnumMember(Value = "SUMMARYINVOICE")]
        SummaryInvoice,
        
        [EnumMember(Value = "CASHINVOICE")]
        CashInvoice
    }
}