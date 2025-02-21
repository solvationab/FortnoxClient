using System.Text.Json.Serialization;

namespace FortnoxClient.Dto
{
    public abstract class ListResponseBase
    {
        protected ListResponseBase(MetaInformationDto metaInformation)
        {
            MetaInformation = metaInformation;
        }

        [JsonPropertyName("MetaInformation")]
        public MetaInformationDto MetaInformation { get; }
    }
}
