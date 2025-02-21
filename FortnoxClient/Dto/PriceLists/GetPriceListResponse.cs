using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.PriceLists
{
    public class GetPriceListResponse
    {
        public GetPriceListResponse(PriceListDto priceList)
        {
            PriceList = priceList;
        }

        [JsonPropertyName("PriceList")]
        public PriceListDto PriceList { get; }
    }
}