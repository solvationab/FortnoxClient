using FluentAssertions;
using FortnoxClient.Dto.CompanyInformation;
using FortnoxClient.Extensions;
using System.Text.Json;

namespace FortnoxClientTests.Dto.CompanyInformation
{
    [TestClass]
    public class CompanyInformationResponseTests
    {
        [DataTestMethod]
        [DataRow("CompanyInformationResponse.json")]
        public void Deserialize(string filename)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dto", "CompanyInformation", filename);

            var json = File.ReadAllText(filePath);

            var obj = JsonSerializer.Deserialize<CompanyInformationResponse>(json, ServiceCollectionExtensions.GetJsonSerializerOptions());

            obj.Should().NotBeNull();
            obj.CompanyInformation.Should().NotBeNull();
            obj.CompanyInformation.Address.Should().Be("AnkVägen 5");
            obj.CompanyInformation.City.Should().Be("Uppsala");
            obj.CompanyInformation.CompanyName.Should().Be("Margarinbolaget AB");
            obj.CompanyInformation.CountryCode.Should().Be("SE");
            obj.CompanyInformation.DatabaseNumber.Should().Be(434847);
            obj.CompanyInformation.OrganizationNumber.Should().Be("556026-9986");
            obj.CompanyInformation.VisitAddress.Should().Be("Kvackgatan 7");
            obj.CompanyInformation.VisitCity.Should().Be("Oslo");
            obj.CompanyInformation.VisitCountryCode.Should().Be("NO");
            obj.CompanyInformation.VisitZipCode.Should().Be("75450");
            obj.CompanyInformation.ZipCode.Should().Be("75451");
        }
    }
}