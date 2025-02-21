using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Prices
{
    public class GetPriceResponse
    {
        public GetPriceResponse(PriceDto price)
        {
            Price = price;
        }

        [JsonPropertyName("Price")]
        public PriceDto Price { get; }
    }
}
