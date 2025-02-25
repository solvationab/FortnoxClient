using FluentAssertions;
using FortnoxClient.Dto.Articles;
using FortnoxClient.Extensions;
using System.Text.Json;

namespace FortnoxClientTests.Dto.Articles
{
    [TestClass]
    public class GetArticlesResponseTests
    {
        [DataTestMethod]
        [DataRow("GetArticlesResponse.json")]
        public void Deserialize(string filename)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dto", "Articles", filename);

            var json = File.ReadAllText(filePath);

            var obj = JsonSerializer.Deserialize<GetArticlesResponse>(json, ServiceCollectionExtensions.GetJsonSerializerOptions());

            obj.Should().NotBeNull();
            obj.Articles.Should().NotBeNull();
            //obj.Articles[0].ArticleNumber.Should().Be("AnkVägen 5");
        }
    }
}