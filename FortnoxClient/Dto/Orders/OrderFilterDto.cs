using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public enum OrderFilterDto 
    {
        [EnumMember(Value = "cancelled")]
        Cancelled,
        
        [EnumMember(Value = "expired")]
        Expired,
        
        [EnumMember(Value = "invoicecreated")]
        InvoiceCreated,
        
        [EnumMember(Value = "invoicenotcreated")]
        InvoiceNotCreated
    }
}