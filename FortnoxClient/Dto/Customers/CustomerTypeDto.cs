using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public enum CustomerTypeDto
    {
        [EnumMember(Value = "PRIVATE")]
        Private,

        [EnumMember(Value = "COMPANY")]
        Company
    }
}