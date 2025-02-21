using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public class OrderLabelDto
    {
        public OrderLabelDto(int? id)
        {
            Id = id;
        }

        [JsonPropertyName("Id")]
        public int? Id { get; }
    }
}