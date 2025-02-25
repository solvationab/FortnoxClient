using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Articles
{
    public class ArticleListItem
    {
        public ArticleListItem(
            string url,
            string articleNumber,
            string description,
            decimal? disposableQuantity,
            string ean,
            bool? housework,
            decimal? purchasePrice,
            decimal? salesPrice,
            decimal? quantityInStock,
            decimal? reservedQuantity,
            string stockPlace,
            decimal? stockValue,
            string unit,
            string vat,
            bool? webshopArticle)
        {
            Url = url;
            ArticleNumber = articleNumber;
            Description = description;
            DisposableQuantity = disposableQuantity;
            Ean = ean;
            Housework = housework;
            PurchasePrice = purchasePrice;
            SalesPrice = salesPrice;
            QuantityInStock = quantityInStock;
            ReservedQuantity = reservedQuantity;
            StockPlace = stockPlace;
            StockValue = stockValue;
            Unit = unit;
            Vat = vat;
            WebshopArticle = webshopArticle;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("ArticleNumber")]
        public string ArticleNumber { get; } // string[0..50] characters

        [JsonPropertyName("Description")]
        public string Description { get; } // string[1..200] characters

        [JsonPropertyName("DisposableQuantity")]
        public decimal? DisposableQuantity { get; }

        [JsonPropertyName("EAN")]
        public string Ean { get; } // string[0..30] characters

        [JsonPropertyName("Housework")]
        public bool? Housework { get; }

        [JsonPropertyName("PurchasePrice")]
        public decimal? PurchasePrice { get; }

        [JsonPropertyName("SalesPrice")]
        public decimal? SalesPrice { get; }

        [JsonPropertyName("QuantityInStock")]
        public decimal? QuantityInStock { get; }

        [JsonPropertyName("ReservedQuantity")]
        public decimal? ReservedQuantity { get; }

        [JsonPropertyName("StockPlace")]
        public string StockPlace { get; } // string[0..100] characters

        [JsonPropertyName("StockValue")]
        public decimal? StockValue { get; }

        [JsonPropertyName("Unit")]
        public string Unit { get; }

        [JsonPropertyName("VAT")]
        public string Vat { get; }

        [JsonPropertyName("WebshopArticle")]
        public bool? WebshopArticle { get; }
    }
}