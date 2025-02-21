using System.Runtime.Serialization;

namespace FortnoxClient.Dto
{
    public enum DiscountTypesDto
    {
        [EnumMember(Value = "AMOUNT")]
        Amount,

        [EnumMember(Value = "PERCENT")]
        Percent
    }
}