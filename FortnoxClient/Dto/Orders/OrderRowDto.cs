using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public class OrderRowDto
    {
        public OrderRowDto(
            int? accountNumber,
            string articleNumber,
            string contributionPercent,
            string contributionValue,
            decimal? cost,
            string costCenter,
            string deliveredQuantity,
            string description,
            double? discount,
            DiscountTypesDto? discountType,
            bool? houseWork,
            int? houseWorkHoursToReport,
            HouseWorkTypesDto? houseWorkType,
            string orderedQuantity,
            decimal? price,
            string project,
            string reservedQuantity,
            int? rowId,
            string stockPointCode,
            string stockPointId,
            decimal? total,
            string unit,
            decimal? vat)
        {
            AccountNumber = accountNumber;
            ArticleNumber = articleNumber;
            ContributionPercent = contributionPercent;
            ContributionValue = contributionValue;
            Cost = cost;
            CostCenter = costCenter;
            DeliveredQuantity = deliveredQuantity;
            Description = description;
            Discount = discount;
            DiscountType = discountType;
            HouseWork = houseWork;
            HouseWorkHoursToReport = houseWorkHoursToReport;
            HouseWorkType = houseWorkType;
            OrderedQuantity = orderedQuantity;
            Price = price;
            Project = project;
            ReservedQuantity = reservedQuantity;
            RowId = rowId;
            StockPointCode = stockPointCode;
            StockPointId = stockPointId;
            Total = total;
            Unit = unit;
            Vat = vat;
        }

        [JsonPropertyName("AccountNumber")]
        public int? AccountNumber { get; }

        [JsonPropertyName("ArticleNumber")]
        public string ArticleNumber { get; }

        [JsonPropertyName("ContributionPercent")]
        public string ContributionPercent { get; }

        [JsonPropertyName("ContributionValue")]
        public string ContributionValue { get; }

        [JsonPropertyName("Cost")]
        public decimal? Cost { get; }

        [JsonPropertyName("CostCenter")]
        public string CostCenter { get; }

        [JsonPropertyName("DeliveredQuantity")]
        public string DeliveredQuantity { get; }

        [JsonPropertyName("Description")]
        public string Description { get; }

        [JsonPropertyName("Discount")]
        public double? Discount { get; }

        [JsonPropertyName("DiscountType")]
        public DiscountTypesDto? DiscountType { get; }

        [JsonPropertyName("HouseWork")]
        public bool? HouseWork { get; }

        [JsonPropertyName("HouseWorkHoursToReport")]
        public int? HouseWorkHoursToReport { get; }

        [JsonPropertyName("HouseWorkType")] 
        public HouseWorkTypesDto? HouseWorkType { get; }

        [JsonPropertyName("OrderedQuantity")]
        public string OrderedQuantity { get; }

        [JsonPropertyName("Price")]
        public decimal? Price { get; }

        [JsonPropertyName("Project")]
        public string Project { get; }

        [JsonPropertyName("ReservedQuantity")]
        public string ReservedQuantity { get; }

        [JsonPropertyName("RowId")]
        public int? RowId { get; }

        [JsonPropertyName("StockPointCode")]
        public string StockPointCode { get; }

        [JsonPropertyName("StockPointId")]
        public string StockPointId { get; }

        [JsonPropertyName("Total")]
        public decimal? Total { get; }

        [JsonPropertyName("Unit")]
        public string Unit { get; }

        [JsonPropertyName("VAT")]
        public decimal? Vat { get; }
    }
}