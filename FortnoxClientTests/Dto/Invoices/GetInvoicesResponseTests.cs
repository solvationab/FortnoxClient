using System.Text.Json;
using FluentAssertions;
using FortnoxClient.Dto.Invoices;
using FortnoxClient.Extensions;

namespace FortnoxClientTests.Dto.Invoices
{
    [TestClass]
    public class GetInvoicesResponseTests
    {
        [DataTestMethod]
        [DataRow("GetInvoicesResponse1.json")]
        public void Deserialize(string filename)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dto", "Invoices", filename);

            var json = File.ReadAllText(filePath);

            var obj = JsonSerializer.Deserialize<GetInvoicesResponse>(json, ServiceCollectionExtensions.GetJsonSerializerOptions());

            obj.Should().NotBeNull();
        }
    }
}