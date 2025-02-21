using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Articles
{
    public enum ArticleTypesDto
    {
        [EnumMember(Value = "STOCK")]
        Stock,
     
        [EnumMember(Value = "SERVICE")]
        Service
    }
}