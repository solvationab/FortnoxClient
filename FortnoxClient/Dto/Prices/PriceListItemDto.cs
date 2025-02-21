using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Prices
{
    public class PriceListItemDto
    {
        public PriceListItemDto(
            string url,
            string articleNumber,
            double? fromQuantity,
            string priceList,
            decimal? price)
        {
            Url = url;
            ArticleNumber = articleNumber;
            FromQuantity = fromQuantity;
            PriceList = priceList;
            Price = price;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("ArticleNumber")]
        public string ArticleNumber { get; }

        [JsonPropertyName("FromQuantity")]
        public double? FromQuantity { get; }

        [JsonPropertyName("PriceList")]
        public string PriceList { get; }

        [JsonPropertyName("Price")]
        public decimal? Price { get; }
    }
}