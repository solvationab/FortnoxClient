using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Articles
{
    public class GetArticleResponse
    {
        public GetArticleResponse(ArticleDto article)
        {
            Article = article;
        }

        [JsonPropertyName("Article")]
        public ArticleDto Article { get; }
    }
}
