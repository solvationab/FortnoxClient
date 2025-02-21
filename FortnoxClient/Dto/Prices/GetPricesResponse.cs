using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Prices
{
    public class GetPricesResponse : ListResponseBase
    {
        public GetPricesResponse(
            MetaInformationDto metaInformation, 
            IReadOnlyList<PriceListItemDto> prices
            ) : base(metaInformation)
        {
            if (prices == null) 
                throw new ArgumentNullException(nameof(prices));

            Prices = prices;
        }

        [JsonPropertyName("Prices")]
        public IReadOnlyList<PriceListItemDto> Prices { get; }
    }
}