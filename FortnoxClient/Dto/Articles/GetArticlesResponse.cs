using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Articles
{
    public class GetArticlesResponse : ListResponseBase
    {
        public GetArticlesResponse(MetaInformationDto metaInformation, IReadOnlyList<ArticleListItem> articles) : base(metaInformation)
        {
            Articles = articles;
        }

        [JsonPropertyName("Articles")]
        public IReadOnlyList<ArticleListItem> Articles { get; }
    }
}