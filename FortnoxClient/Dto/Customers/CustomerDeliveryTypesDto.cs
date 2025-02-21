using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public enum CustomerDeliveryTypesDto
    {
        [EnumMember(Value = "PRINT")]
        Print,

        [EnumMember(Value = "EMAIL")]
        Email,
        
        [EnumMember(Value = "PRINTSERVICE")]
        Printservice
    }
}