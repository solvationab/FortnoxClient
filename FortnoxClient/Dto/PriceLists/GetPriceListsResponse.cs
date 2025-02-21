using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.PriceLists
{
    public class GetPriceListsResponse : ListResponseBase
    {
        public GetPriceListsResponse(
            MetaInformationDto metaInformation, 
            IReadOnlyList<PriceListDto> priceLists
            ) : base(metaInformation)
        {
            if (priceLists == null) 
                throw new ArgumentNullException(nameof(priceLists));

            PriceLists = priceLists;
        }

        [JsonPropertyName("PriceLists")]
        public IReadOnlyList<PriceListDto> PriceLists { get; }
    }
}
