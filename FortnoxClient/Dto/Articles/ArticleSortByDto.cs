using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Articles
{
    public enum ArticleSortByDto
    {
        [EnumMember(Value = "articlenumber")]
        ArticleNumber,

        [EnumMember(Value = "quantityinstock")]
        QuantityInStock,

        [EnumMember(Value = "reservedquantity")]
        ReservedQuantity,

        [EnumMember(Value = "stockvalue")]
        StockValue
    }
}