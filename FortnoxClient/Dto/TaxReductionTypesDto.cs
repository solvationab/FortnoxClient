using System.Runtime.Serialization;

namespace FortnoxClient.Dto
{
    public enum TaxReductionTypesDto
    {
        [EnumMember(Value = "none")]
        None,

        [EnumMember(Value = "rot")]
        Rot,

        [EnumMember(Value = "rut")]
        Rut,

        [EnumMember(Value = "green")]
        Green
    }
}