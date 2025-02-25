using FluentAssertions;
using FortnoxClient.Dto.Me;
using FortnoxClient.Extensions;
using System.Text.Json;

namespace FortnoxClientTests.Dto.Me
{
    [TestClass]
    public class MeResponseTests
    {
        [DataTestMethod]
        [DataRow("MeResponse.json")]
        public void Deserialize(string filename)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dto", "Me", filename);

            var json = File.ReadAllText(filePath);

            var obj = JsonSerializer.Deserialize<MeResponse>(json, ServiceCollectionExtensions.GetJsonSerializerOptions());

            obj.Should().NotBeNull();
            obj.MeInformation.Should().NotBeNull();
            obj.MeInformation.Id.Should().Be("ajksdfdkjfk435kljalksdcjglkasdfj41325j");
            obj.MeInformation.Name.Should().Be("Kalle Anka");
            obj.MeInformation.Email.Should().Be("test@ankeborg.se");
            obj.MeInformation.SysAdmin.Should().Be(false);
            obj.MeInformation.Locale.Should().Be("sv_SE");
        }
    }
}