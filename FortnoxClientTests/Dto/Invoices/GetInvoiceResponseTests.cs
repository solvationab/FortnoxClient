using System.Text.Json;
using FluentAssertions;
using FortnoxClient.Dto.Invoices;
using FortnoxClient.Extensions;

namespace FortnoxClientTests.Dto.Invoices
{
    [TestClass]
    public class GetInvoiceResponseTests
    {
        [DataTestMethod]
        [DataRow("GetInvoiceResponse1.json")]
        [DataRow("GetInvoiceResponse2.json")]
        [DataRow("GetInvoiceResponse3.json")]
        public void Deserialize(string filename)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dto", "Invoices", filename);

            var json = File.ReadAllText(filePath);

            var obj = JsonSerializer.Deserialize<GetInvoiceResponse>(json, ServiceCollectionExtensions.GetJsonSerializerOptions());

            obj.Should().NotBeNull();
        }
    }
}
