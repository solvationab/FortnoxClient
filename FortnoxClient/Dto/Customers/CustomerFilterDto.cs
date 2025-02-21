using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public enum CustomerFilterDto
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "inactive")]
        Inactive
    }
}
