using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Articles
{
    public enum ArticleFilterDto
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "inactive")]
        Inactive
    }
}