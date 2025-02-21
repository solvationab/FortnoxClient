using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Customers
{
    public enum VatTypesDto
    {
        [EnumMember(Value = "SEVAT")]
        SeVat,

        [EnumMember(Value = "SEREVERSEDVAT")]
        SeReversedVat,

        [EnumMember(Value = "EUREVERSEDVAT")]
        EuReversedVat,

        [EnumMember(Value = "EUVAT")]
        EuVat,

        [EnumMember(Value = "EXPORT")]
        Export
    }
}