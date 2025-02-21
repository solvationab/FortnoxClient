using System;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Prices
{
    public class PriceDto
    {
        public PriceDto(
            string url,
            string articleNumber,
            DateTime? date,
            double? fromQuantity,
            decimal? percent,
            decimal? price,
            string priceList)
        {
            Url = url;
            ArticleNumber = articleNumber;
            Date = date;
            FromQuantity = fromQuantity;
            Percent = percent;
            Price = price;
            PriceList = priceList;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("ArticleNumber")] 
        public string ArticleNumber { get; }

        [JsonPropertyName("Date")]
        public DateTime? Date { get; }

        [JsonPropertyName("FromQuantity")]
        public double? FromQuantity { get; }

        [JsonPropertyName("Percent")]
        public decimal? Percent { get; }

        [JsonPropertyName("Price")]
        public decimal? Price { get; }

        [JsonPropertyName("PriceList")]
        public string PriceList { get; }
    }
}