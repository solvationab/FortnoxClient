using System.Text.Json.Serialization;

#pragma warning disable CA1056

namespace FortnoxClient.Dto.Customers
{
    public class CustomerDto
    {
        public CustomerDto(
            string url,
            string address1,
            string address2,
            string city,
            string country,
            string comments,
            string currency,
            string costCenter,
            string countryCode,
            bool? active,
            string customerNumber,
            CustomerDefaultDeliveryTypesDto defaultDefaultDeliveryTypes,
            CustomerDefaultTemplatesDto defaultTemplates,
            string deliveryAddress1,
            string deliveryAddress2,
            string deliveryCity,
            string deliveryCountry,
            string deliveryCountryCode,
            string deliveryFax,
            string deliveryName,
            string deliveryPhone1,
            string deliveryPhone2,
            string deliveryZipCode,
            string email,
            string emailInvoice,
            string emailInvoiceBcc,
            string emailInvoiceCc,
            string emailOffer,
            string emailOfferBcc,
            string emailOfferCc,
            string emailOrder,
            string emailOrderBcc,
            string emailOrderCc,
            string externalReference,
            string fax,
            string gln,
            string glnDelivery,
            string invoiceAdministrationFee,
            double invoiceDiscount,
            string invoiceFreight,
            string invoiceRemark,
            string name,
            string organisationNumber,
            string ourReference,
            string phone1,
            string phone2,
            string priceList,
            string project,
            string salesAccount,
            bool? showPriceVatIncluded,
            string termsOfDelivery,
            string termsOfPayment,
            CustomerTypeDto? type,
            string vatNumber,
            VatTypesDto? vatType,
            string visitingAddress,
            string visitingCity,
            string visitingCountry,
            string visitingCountryCode,
            string visitingZipCode,
            string wayOfDelivery,
            string www,
            string yourReference,
            string zipCode)
        {
            Url = url;
            Address1 = address1;
            Address2 = address2;
            City = city;
            Country = country;
            Comments = comments;
            Currency = currency;
            CostCenter = costCenter;
            CountryCode = countryCode;
            Active = active;
            CustomerNumber = customerNumber;
            DefaultDefaultDeliveryTypes = defaultDefaultDeliveryTypes;
            DefaultTemplates = defaultTemplates;
            DeliveryAddress1 = deliveryAddress1;
            DeliveryAddress2 = deliveryAddress2;
            DeliveryCity = deliveryCity;
            DeliveryCountry = deliveryCountry;
            DeliveryCountryCode = deliveryCountryCode;
            DeliveryFax = deliveryFax;
            DeliveryName = deliveryName;
            DeliveryPhone1 = deliveryPhone1;
            DeliveryPhone2 = deliveryPhone2;
            DeliveryZipCode = deliveryZipCode;
            Email = email;
            EmailInvoice = emailInvoice;
            EmailInvoiceBcc = emailInvoiceBcc;
            EmailInvoiceCc = emailInvoiceCc;
            EmailOffer = emailOffer;
            EmailOfferBcc = emailOfferBcc;
            EmailOfferCc = emailOfferCc;
            EmailOrder = emailOrder;
            EmailOrderBcc = emailOrderBcc;
            EmailOrderCc = emailOrderCc;
            ExternalReference = externalReference;
            Fax = fax;
            Gln = gln;
            GlnDelivery = glnDelivery;
            InvoiceAdministrationFee = invoiceAdministrationFee;
            InvoiceDiscount = invoiceDiscount;
            InvoiceFreight = invoiceFreight;
            InvoiceRemark = invoiceRemark;
            Name = name;
            OrganisationNumber = organisationNumber;
            OurReference = ourReference;
            Phone1 = phone1;
            Phone2 = phone2;
            PriceList = priceList;
            Project = project;
            SalesAccount = salesAccount;
            ShowPriceVatIncluded = showPriceVatIncluded;
            TermsOfDelivery = termsOfDelivery;
            TermsOfPayment = termsOfPayment;
            Type = type;
            VatNumber = vatNumber;
            VatType = vatType;
            VisitingAddress = visitingAddress;
            VisitingCity = visitingCity;
            VisitingCountry = visitingCountry;
            VisitingCountryCode = visitingCountryCode;
            VisitingZipCode = visitingZipCode;
            WayOfDelivery = wayOfDelivery;
            Www = www;
            YourReference = yourReference;
            ZipCode = zipCode;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }

        [JsonPropertyName("Address1")]
        public string Address1 { get; } // [1..1024] characters

        [JsonPropertyName("Address2")]
        public string Address2 { get; } // [0..1024] characters

        [JsonPropertyName("City")]
        public string City { get; } // [0..1024] characters

        [JsonPropertyName("Country")]
        public string Country { get; } 

        [JsonPropertyName("Comments")]
        public string Comments { get; } // [0..1024] characters

        [JsonPropertyName("Currency")]
        public string Currency { get; } // 3 characters

        [JsonPropertyName("CostCenter")]
        public string CostCenter { get; } 

        [JsonPropertyName("CountryCode")]
        public string CountryCode { get; } // 2 characters

        [JsonPropertyName("Active")]
        public bool? Active { get; } 

        [JsonPropertyName("CustomerNumber")]
        public string CustomerNumber { get; } // [0..1024] characters

        [JsonPropertyName("DefaultDeliveryTypes")]
        public CustomerDefaultDeliveryTypesDto DefaultDefaultDeliveryTypes { get; }

        [JsonPropertyName("DefaultTemplates")]
        public CustomerDefaultTemplatesDto DefaultTemplates { get; }

        [JsonPropertyName("DeliveryAddress1")]
        public string DeliveryAddress1 { get; } // [0..1024] characters

        [JsonPropertyName("DeliveryAddress2")]
        public string DeliveryAddress2 { get; } // [0..1024] characters

        [JsonPropertyName("DeliveryCity")]
        public string DeliveryCity { get; } // [0..1024] characters

        [JsonPropertyName("DeliveryCountry")]
        public string DeliveryCountry { get; } // [0..1024] characters

        [JsonPropertyName("DeliveryCountryCode")]
        public string DeliveryCountryCode { get; } // 2 characters

        [JsonPropertyName("DeliveryFax")]
        public string DeliveryFax { get; } // [0..1024] characters

        [JsonPropertyName("DeliveryName")]
        public string DeliveryName { get; } // [0..1024] characters

        [JsonPropertyName("DeliveryPhone1")]
        public string DeliveryPhone1 { get; } // [0..1024] characters

        [JsonPropertyName("DeliveryPhone2")]
        public string DeliveryPhone2 { get; } // [0..1024] characters

        [JsonPropertyName("DeliveryZipCode")]
        public string DeliveryZipCode { get; } // [0..10] characters

        [JsonPropertyName("Email")]
        public string Email { get; } // [0..1024] characters

        [JsonPropertyName("EmailInvoice")]
        public string EmailInvoice { get; } // [0..1024] characters

        [JsonPropertyName("EmailInvoiceBCC")]
        public string EmailInvoiceBcc { get; } // [0..1024] characters

        [JsonPropertyName("EmailInvoiceCC")]
        public string EmailInvoiceCc { get; } // [0..1024] characters

        [JsonPropertyName("EmailOffer")]
        public string EmailOffer { get; } // [0..1024] characters

        [JsonPropertyName("EmailOfferBCC")]
        public string EmailOfferBcc { get; } // [0..1024] characters

        [JsonPropertyName("EmailOfferCC")]
        public string EmailOfferCc { get; } // [0..1024] characters

        [JsonPropertyName("EmailOrder")]
        public string EmailOrder { get; } // [0..1024] characters

        [JsonPropertyName("EmailOrderBCC")]
        public string EmailOrderBcc { get; } // [0..1024] characters

        [JsonPropertyName("EmailOrderCC")]
        public string EmailOrderCc { get; } // [0..1024] characters

        [JsonPropertyName("ExternalReference")]
        public string ExternalReference { get; } // [0..1024] characters

        [JsonPropertyName("Fax")]
        public string Fax { get; } // [0..1024] characters

        [JsonPropertyName("GLN")]
        public string Gln { get; } // 13 characters

        [JsonPropertyName("GLNDelivery")]
        public string GlnDelivery { get; } // 13 characters

        [JsonPropertyName("InvoiceAdministrationFee")]
        public string InvoiceAdministrationFee { get; }

        [JsonPropertyName("InvoiceDiscount")]
        public double InvoiceDiscount { get; }

        [JsonPropertyName("InvoiceFreight")]
        public string InvoiceFreight { get; }

        [JsonPropertyName("InvoiceRemark")]
        public string InvoiceRemark { get; } // [0..1024] characters

        [JsonPropertyName("Name")]
        public string Name { get; } // required [1..1024] characters

        [JsonPropertyName("OrganisationNumber")]
        public string OrganisationNumber { get; }

        [JsonPropertyName("OurReference")]
        public string OurReference { get; } // [0..50] characters

        [JsonPropertyName("Phone1")]
        public string Phone1 { get; } // [0..1024] characters

        [JsonPropertyName("Phone2")]
        public string Phone2 { get; } // [0..1024] characters

        [JsonPropertyName("PriceList")]
        public string PriceList { get; }

        [JsonPropertyName("Project")]
        public string Project { get; }

        [JsonPropertyName("SalesAccount")]
        public string SalesAccount { get; } // 4 characters

        [JsonPropertyName("ShowPriceVATIncluded")]
        public bool? ShowPriceVatIncluded { get; }

        [JsonPropertyName("TermsOfDelivery")]
        public string TermsOfDelivery { get; }

        [JsonPropertyName("TermsOfPayment")]
        public string TermsOfPayment { get; }

        [JsonPropertyName("Type")]
        public CustomerTypeDto? Type { get; }

        [JsonPropertyName("VATNumber")]
        public string VatNumber { get; }

        [JsonPropertyName("VATType")]
        public VatTypesDto? VatType { get; } 

        [JsonPropertyName("VisitingAddress")]
        public string VisitingAddress { get; } // [0..128] characters

        [JsonPropertyName("VisitingCity")]
        public string VisitingCity { get; } // [0..128] characters

        [JsonPropertyName("VisitingCountry")]
        public string VisitingCountry { get; } // [0..128] characters

        [JsonPropertyName("VisitingCountryCode")]
        public string VisitingCountryCode { get; } // 2 characters

        [JsonPropertyName("VisitingZipCode")]
        public string VisitingZipCode { get; } // [0..10] characters

        [JsonPropertyName("WayOfDelivery")]
        public string WayOfDelivery { get; }

        [JsonPropertyName("WWW")]
        public string Www { get; } // [0..128] characters

        [JsonPropertyName("YourReference")]
        public string YourReference { get; } // [0..50] characters

        [JsonPropertyName("ZipCode")]
        public string ZipCode { get; } // [0..10] characters
    }
}
