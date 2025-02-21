using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Orders
{
    public class OrderDto
    {
        public OrderDto(
            string url,
            string urlTaxReductionList,
            decimal? administrationFee,
            decimal? administrationFeeVat,
            string address1,
            string address2,
            decimal? basisTaxReduction,
            bool? cancelled,
            string city,
            string comments,
            double? contributionPercent,
            decimal? contributionValue,
            bool? copyRemarks,
            string country,
            string costCenter,
            string currency,
            decimal? currencyRate,
            double? currencyUnit,
            string customerName,
            string customerNumber,
            DeliveryStatesDto? deliveryState,
            string deliveryAddress1,
            string deliveryAddress2,
            string deliveryCity,
            string deliveryCountry,
            DateTime? deliveryDate,
            string deliveryName,
            string deliveryZipCode,
            string documentNumber,
            EmailInformationDto emailInformation,
            string externalInvoiceReference1,
            string externalInvoiceReference2,
            decimal? freight,
            decimal? freightVat,
            decimal? gross,
            bool? houseWork,
            string invoiceReference,
            IReadOnlyList<OrderLabelDto> labels,
            string language,
            decimal? net,
            bool? notCompleted,
            string offerReference,
            DateTime? orderDate,
            IReadOnlyList<OrderRowDto> orderRows,
            string orderType,
            string organisationNumber,
            string ourReference,
            string phone1,
            string phone2,
            string priceList,
            string printTemplate,
            string project,
            bool? warehouseReady,
            DateTime? outboundDate,
            string remarks,
            double? roundOff,
            bool? sent,
            decimal? taxReduction,
            string termsOfDelivery,
            string termsOfPayment,
            int? timeBasisReference,
            double? total,
            decimal? totalToPay,
            decimal? totalVat,
            bool? vatIncluded,
            string wayOfDelivery,
            string yourReference,
            string yourOrderNumber,
            string zipCode,
            string stockPointCode,
            string stockPointId,
            TaxReductionTypesDto? taxReductionType)
        {
            Url = url;
            UrlTaxReductionList = urlTaxReductionList;
            AdministrationFee = administrationFee;
            AdministrationFeeVat = administrationFeeVat;
            Address1 = address1;
            Address2 = address2;
            BasisTaxReduction = basisTaxReduction;
            Cancelled = cancelled;
            City = city;
            Comments = comments;
            ContributionPercent = contributionPercent;
            ContributionValue = contributionValue;
            CopyRemarks = copyRemarks;
            Country = country;
            CostCenter = costCenter;
            Currency = currency;
            CurrencyRate = currencyRate;
            CurrencyUnit = currencyUnit;
            CustomerName = customerName;
            CustomerNumber = customerNumber;
            DeliveryState = deliveryState;
            DeliveryAddress1 = deliveryAddress1;
            DeliveryAddress2 = deliveryAddress2;
            DeliveryCity = deliveryCity;
            DeliveryCountry = deliveryCountry;
            DeliveryDate = deliveryDate;
            DeliveryName = deliveryName;
            DeliveryZipCode = deliveryZipCode;
            DocumentNumber = documentNumber;
            EmailInformation = emailInformation;
            ExternalInvoiceReference1 = externalInvoiceReference1;
            ExternalInvoiceReference2 = externalInvoiceReference2;
            Freight = freight;
            FreightVat = freightVat;
            Gross = gross;
            HouseWork = houseWork;
            InvoiceReference = invoiceReference;
            Labels = labels;
            Language = language;
            Net = net;
            NotCompleted = notCompleted;
            OfferReference = offerReference;
            OrderDate = orderDate;
            OrderRows = orderRows;
            OrderType = orderType;
            OrganisationNumber = organisationNumber;
            OurReference = ourReference;
            Phone1 = phone1;
            Phone2 = phone2;
            PriceList = priceList;
            PrintTemplate = printTemplate;
            Project = project;
            WarehouseReady = warehouseReady;
            OutboundDate = outboundDate;
            Remarks = remarks;
            RoundOff = roundOff;
            Sent = sent;
            TaxReduction = taxReduction;
            TermsOfDelivery = termsOfDelivery;
            TermsOfPayment = termsOfPayment;
            TimeBasisReference = timeBasisReference;
            Total = total;
            TotalToPay = totalToPay;
            TotalVat = totalVat;
            VatIncluded = vatIncluded;
            WayOfDelivery = wayOfDelivery;
            YourReference = yourReference;
            YourOrderNumber = yourOrderNumber;
            ZipCode = zipCode;
            StockPointCode = stockPointCode;
            StockPointId = stockPointId;
            TaxReductionType = taxReductionType;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("@urlTaxReductionList")]
        public string UrlTaxReductionList { get; }

        [JsonPropertyName("AdministrationFee")]
        public decimal? AdministrationFee { get; }

        [JsonPropertyName("AdministrationFeeVAT")]
        public decimal? AdministrationFeeVat { get; }

        [JsonPropertyName("Address1")]
        public string Address1 { get; }

        [JsonPropertyName("Address2")]
        public string Address2 { get; }

        [JsonPropertyName("BasisTaxReduction")]
        public decimal? BasisTaxReduction { get; }

        [JsonPropertyName("Cancelled")]
        public bool? Cancelled { get; }

        [JsonPropertyName("City")]
        public string City { get; }

        [JsonPropertyName("Comments")]
        public string Comments { get; }

        [JsonPropertyName("ContributionPercent")]
        public double? ContributionPercent { get; }

        [JsonPropertyName("ContributionValue")]
        public decimal? ContributionValue { get; }

        [JsonPropertyName("CopyRemarks")]
        public bool? CopyRemarks { get; }

        [JsonPropertyName("Country")]
        public string Country { get; }

        [JsonPropertyName("CostCenter")]
        public string CostCenter { get; }

        [JsonPropertyName("Currency")]
        public string Currency { get; } // string[0..3] characters

        [JsonPropertyName("CurrencyRate")]
        public decimal? CurrencyRate { get; }

        [JsonPropertyName("CurrencyUnit")]
        public double? CurrencyUnit { get; }

        [JsonPropertyName("CustomerName")]
        public string CustomerName { get; }

        [JsonPropertyName("CustomerNumber")]
        public string CustomerNumber { get; } // required

        [JsonPropertyName("DeliveryState")]
        public DeliveryStatesDto? DeliveryState { get; } // string Enum: "registration" "reservation" "delivery"

        [JsonPropertyName("DeliveryAddress1")]
        public string DeliveryAddress1 { get; }

        [JsonPropertyName("DeliveryAddress2")]
        public string DeliveryAddress2 { get; }

        [JsonPropertyName("DeliveryCity")]
        public string DeliveryCity { get; }

        [JsonPropertyName("DeliveryCountry")]
        public string DeliveryCountry { get; }

        [JsonPropertyName("DeliveryDate")]
        public DateTime? DeliveryDate { get; }

        [JsonPropertyName("DeliveryName")]
        public string DeliveryName { get; }

        [JsonPropertyName("DeliveryZipCode")]
        public string DeliveryZipCode { get; }

        [JsonPropertyName("DocumentNumber")]
        public string DocumentNumber { get; }

        [JsonPropertyName("EmailInformation")]
        public EmailInformationDto EmailInformation { get; }

        [JsonPropertyName("ExternalInvoiceReference1")]
        public string ExternalInvoiceReference1 { get; }

        [JsonPropertyName("ExternalInvoiceReference2")]
        public string ExternalInvoiceReference2 { get; }

        [JsonPropertyName("Freight")]
        public decimal? Freight { get; }

        [JsonPropertyName("FreightVAT")]
        public decimal? FreightVat { get; }

        [JsonPropertyName("Gross")]
        public decimal? Gross { get; }

        [JsonPropertyName("HouseWork")]
        public bool? HouseWork { get; }

        [JsonPropertyName("InvoiceReference")]
        public string InvoiceReference { get; }

        [JsonPropertyName("Labels")]
        public IReadOnlyList<OrderLabelDto> Labels { get; }

        [JsonPropertyName("Language")]
        public string Language { get; }

        [JsonPropertyName("Net")]
        public decimal? Net { get; }

        [JsonPropertyName("NotCompleted")]
        public bool? NotCompleted { get; }

        [JsonPropertyName("OfferReference")]
        public string OfferReference { get; }

        [JsonPropertyName("OrderDate")]
        public DateTime? OrderDate { get; }

        [JsonPropertyName("OrderRows")]
        public IReadOnlyList<OrderRowDto> OrderRows { get; }

        [JsonPropertyName("OrderType")]
        public string OrderType { get; }

        [JsonPropertyName("OrganisationNumber")]
        public string OrganisationNumber { get; }

        [JsonPropertyName("OurReference")]
        public string OurReference { get; } // string[0..50] characters

        [JsonPropertyName("Phone1")]
        public string Phone1 { get; }

        [JsonPropertyName("Phone2")]
        public string Phone2 { get; }

        [JsonPropertyName("PriceList")]
        public string PriceList { get; }

        [JsonPropertyName("PrintTemplate")]
        public string PrintTemplate { get; }

        [JsonPropertyName("Project")]
        public string Project { get; }

        [JsonPropertyName("WarehouseReady")]
        public bool? WarehouseReady { get; }

        [JsonPropertyName("OutboundDate")]
        public DateTime? OutboundDate { get; }

        [JsonPropertyName("Remarks")]
        public string Remarks { get; } //string[0..1024] characters

        [JsonPropertyName("RoundOff")]
        public double? RoundOff { get; }

        [JsonPropertyName("Sent")]
        public bool? Sent { get; }

        [JsonPropertyName("TaxReduction")]
        public decimal? TaxReduction { get; }

        [JsonPropertyName("TermsOfDelivery")]
        public string TermsOfDelivery { get; }

        [JsonPropertyName("TermsOfPayment")]
        public string TermsOfPayment { get; }

        [JsonPropertyName("TimeBasisReference")]
        public int? TimeBasisReference { get; }

        [JsonPropertyName("Total")]
        public double? Total { get; }

        [JsonPropertyName("TotalToPay")]
        public decimal? TotalToPay { get; }

        [JsonPropertyName("TotalVAT")]
        public decimal? TotalVat { get; }

        [JsonPropertyName("VATIncluded")]
        public bool? VatIncluded { get; }

        [JsonPropertyName("WayOfDelivery")]
        public string WayOfDelivery { get; }

        [JsonPropertyName("YourReference")]
        public string YourReference { get; } // string[0..50] characters

        [JsonPropertyName("YourOrderNumber")]
        public string YourOrderNumber { get; }// string[0..75] characters

        [JsonPropertyName("ZipCode")]
        public string ZipCode { get; }

        [JsonPropertyName("StockPointCode")]
        public string StockPointCode { get; }

        [JsonPropertyName("StockPointId")]
        public string StockPointId { get; }

        [JsonPropertyName("TaxReductionType")]
        public TaxReductionTypesDto? TaxReductionType { get; }
    }
}