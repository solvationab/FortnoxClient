using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.PriceLists
{
    public class PriceListDto
    {
        public PriceListDto(
            string url,
            string code,
            string description,
            string comments,
            bool? preSelected)
        {
            Url = url;
            Code = code;
            Description = description;
            Comments = comments;
            PreSelected = preSelected;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("Code")]
        public string Code { get; } // required string[1..100] characters

        [JsonPropertyName("Description")]
        public string Description { get; } // required string[1..50] characters
        
        [JsonPropertyName("Comments")]
        public string Comments { get; }

        [JsonPropertyName("PreSelected")]
        public bool? PreSelected { get; }
    }
}