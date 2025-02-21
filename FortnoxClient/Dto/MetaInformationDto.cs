using System.Text.Json.Serialization;

namespace FortnoxClient.Dto
{
    public class MetaInformationDto
    {
        public MetaInformationDto(int totalResources, int totalPages, int currentPage)
        {
            TotalResources = totalResources;
            TotalPages = totalPages;
            CurrentPage = currentPage;
        }

        [JsonPropertyName("@TotalResources")]
        public int TotalResources { get; }
        
        [JsonPropertyName("@TotalPages")]
        public int TotalPages { get; }
        
        [JsonPropertyName("@CurrentPage")]
        public int CurrentPage { get; }
    }
}