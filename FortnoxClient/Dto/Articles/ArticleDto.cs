using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Articles
{
    public class ArticleDto
    {
        public ArticleDto(
            string url,
            string articleNumber,
            bool? bulky,
            int? constructionAccount,
            int? depth,
            string description,
            double? disposableQuantity,
            string ean,
            int? euAccount,
            int? euVatAccount,
            int? exportAccount,
            int? height,
            bool? housework,
            HouseworkTypesDto? houseworkType,
            bool? active,
            string manufacturer,
            string manufacturerArticleNumber,
            string note,
            int? purchaseAccount,
            double? purchasePrice,
            double? quantityInStock,
            double? reservedQuantity,
            int? salesAccount,
            bool? stockGoods,
            string stockPlace,
            double? stockValue,
            double? stockWarning,
            string supplierName,
            string supplierNumber,
            ArticleTypesDto? types,
            string unit,
            double? vat,
            bool? webshopArticle,
            int? weight,
            int? width,
            bool? expired,
            double? salesPrice,
            string costCalculationMethod,
            int? stockAccount,
            int? stockChangeAccount,
            double? directCost,
            double? freightCost,
            double? otherCost,
            string defaultStockPoint,
            string defaultStockLocation)
        {
            Url = url;
            ArticleNumber = articleNumber;
            Bulky = bulky;
            ConstructionAccount = constructionAccount;
            Depth = depth;
            Description = description;
            DisposableQuantity = disposableQuantity;
            Ean = ean;
            EuAccount = euAccount;
            EuVatAccount = euVatAccount;
            ExportAccount = exportAccount;
            Height = height;
            Housework = housework;
            HouseworkType = houseworkType;
            Active = active;
            Manufacturer = manufacturer;
            ManufacturerArticleNumber = manufacturerArticleNumber;
            Note = note;
            PurchaseAccount = purchaseAccount;
            PurchasePrice = purchasePrice;
            QuantityInStock = quantityInStock;
            ReservedQuantity = reservedQuantity;
            SalesAccount = salesAccount;
            StockGoods = stockGoods;
            StockPlace = stockPlace;
            StockValue = stockValue;
            StockWarning = stockWarning;
            SupplierName = supplierName;
            SupplierNumber = supplierNumber;
            Types = types;
            Unit = unit;
            Vat = vat;
            WebshopArticle = webshopArticle;
            Weight = weight;
            Width = width;
            Expired = expired;
            SalesPrice = salesPrice;
            CostCalculationMethod = costCalculationMethod;
            StockAccount = stockAccount;
            StockChangeAccount = stockChangeAccount;
            DirectCost = directCost;
            FreightCost = freightCost;
            OtherCost = otherCost;
            DefaultStockPoint = defaultStockPoint;
            DefaultStockLocation = defaultStockLocation;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("ArticleNumber")]
        public string ArticleNumber { get; } // string[0..50] characters

        [JsonPropertyName("Bulky")]
        public bool? Bulky { get; }

        [JsonPropertyName("ConstructionAccount")]
        public int? ConstructionAccount { get; } // integer <int32> [ 1000 .. 99999 ]

        [JsonPropertyName("Depth")]
        public int? Depth { get; } // integer <int32> [ 0 .. 999999999 ]

        [JsonPropertyName("Description")]
        public string Description { get; } // string[1..200] characters
        
        [JsonPropertyName("DisposableQuantity")]
        public double? DisposableQuantity { get; }
        
        [JsonPropertyName("EAN")]
        public string Ean { get; } // string[0..30] characters
        
        [JsonPropertyName("EUAccount")]
        public int? EuAccount { get; } // integer <int32> [ 1000 .. 99999 ]
        
        [JsonPropertyName("EUVATAccount")]
        public int? EuVatAccount { get; } // integer <int32> [ 1000 .. 99999 ]
        
        [JsonPropertyName("ExportAccount")]
        public int? ExportAccount { get; } // integer <int32> [ 1000 .. 99999 ]
        
        [JsonPropertyName("Height")]
        public int? Height { get; } // integer <int32> [ 0 .. 999999999 ]
        
        [JsonPropertyName("Housework")]
        public bool? Housework { get; }
        
        [JsonPropertyName("HouseworkType")]
        public HouseworkTypesDto? HouseworkType { get; } // Enum: "CONSTRUCTION" "ELECTRICITY" "GLASSMETALWORK" "GROUNDDRAINAGEWORK" "MASONRY" "PAINTINGWALLPAPERING" "HVAC" "CLEANING" "TEXTILECLOTHING" "COOKING" "SNOWPLOWING" "GARDENING" "BABYSITTING" "OTHERCARE" "TUTORING" "OTHERCOSTS"
        
        [JsonPropertyName("Active")]
        public bool? Active { get; }
        
        [JsonPropertyName("Manufacturer")]
        public string Manufacturer { get; } // string[0..50] characters
        
        [JsonPropertyName("ManufacturerArticleNumber")]
        public string ManufacturerArticleNumber { get; } // string[0..50] characters
        
        [JsonPropertyName("Note")]
        public string Note { get; } // string[0..10000] characters
        
        [JsonPropertyName("PurchaseAccount")]
        public int? PurchaseAccount { get; } // integer <int32> [ 1000 .. 99999 ]
        
        [JsonPropertyName("PurchasePrice")]
        public double? PurchasePrice { get; }
        
        [JsonPropertyName("QuantityInStock")]
        public double? QuantityInStock { get; }
        
        [JsonPropertyName("ReservedQuantity")]
        public double? ReservedQuantity { get; }
        
        [JsonPropertyName("SalesAccount")]
        public int? SalesAccount { get; } // integer <int32> [ 1000 .. 99999 ]
        
        [JsonPropertyName("StockGoods")]
        public bool? StockGoods { get; }
        
        [JsonPropertyName("StockPlace")]
        public string StockPlace { get; } // string[0..100] characters
        
        [JsonPropertyName("StockValue")]
        public double? StockValue { get; }
        
        [JsonPropertyName("StockWarning")]
        public double? StockWarning { get; }
        
        [JsonPropertyName("SupplierName")]
        public string SupplierName { get; }
        
        [JsonPropertyName("SupplierNumber")]
        public string SupplierNumber { get; }

        [JsonPropertyName("Type")]
        public ArticleTypesDto? Types { get; } // Enum: "STOCK" "SERVICE"
        
        [JsonPropertyName("Unit")]
        public string Unit { get; }

        [JsonPropertyName("VAT")]
        public double? Vat { get; }
        
        [JsonPropertyName("WebshopArticle")]
        public bool? WebshopArticle { get; }
        
        [JsonPropertyName("Weight")]
        public int? Weight { get; } // integer <int32> [ 0 .. 999999999 ]
        
        [JsonPropertyName("Width")]
        public int? Width { get; } // integer <int32> [ 0 .. 999999999 ]
        
        [JsonPropertyName("Expired")]
        public bool? Expired { get; }
        
        [JsonPropertyName("SalesPrice")]
        public double? SalesPrice { get; }
        
        [JsonPropertyName("CostCalculationMethod")]
        public string CostCalculationMethod { get; }
        
        [JsonPropertyName("StockAccount")]
        public int? StockAccount { get; }
        
        [JsonPropertyName("StockChangeAccount")]
        public int? StockChangeAccount { get; }
        
        [JsonPropertyName("DirectCost")]
        public double? DirectCost { get; }
        
        [JsonPropertyName("FreightCost")]
        public double? FreightCost { get; }
        
        [JsonPropertyName("OtherCost")]
        public double? OtherCost { get; }
        
        [JsonPropertyName("DefaultStockPoint")]
        public string DefaultStockPoint { get; }
        
        [JsonPropertyName("DefaultStockLocation")]
        public string DefaultStockLocation { get; }
    }
}