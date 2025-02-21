using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public enum DeliveryStatesDto
    {
        [EnumMember(Value = "registration")]
        Registration,

        [EnumMember(Value = "reservation")]
        Reservation,

        [EnumMember(Value = "delivery")]
        Delivery
    }
}