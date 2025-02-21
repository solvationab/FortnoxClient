using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Invoices
{
    public enum InvoiceFilterDto
    {
        [EnumMember(Value = "cancelled")]
        Cancelled,

        [EnumMember(Value = "fullypaid")]
        Fullypaid,

        [EnumMember(Value = "unpaid")]
        Unpaid,

        [EnumMember(Value = "unpaidoverdue")]
        Unpaidoverdue,

        [EnumMember(Value = "unbooked")]
        Unbooked
    }
}