using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Invoices
{
    public class GetInvoiceResponse
    {
        public GetInvoiceResponse(InvoiceDto invoice)
        {
            if (invoice == null) 
                throw new ArgumentNullException(nameof(invoice));

            Invoice = invoice;
        }

        [JsonPropertyName("Invoice")]
        public InvoiceDto Invoice { get; }
    }

    public class InvoiceDto
    {
        public InvoiceDto(
            string url,
            string urlTaxReductionList,
            AccountingMethodsDto accountingMethod,
            string address1,
            string address2,
            double administrationFee,
            double administrationFeeVat,
            double balance,
            double? basisTaxReduction,
            bool booked,
            bool cancelled,
            string city,
            string comments,
            int contractReference,
            string contributionPercent,
            string contributionValue,
            string costCenter,
            string country,
            string credit,
            string creditInvoiceReference,
            string currency,
            double currencyRate,
            int currencyUnit,
            string customerName,
            string customerNumber,
            string deliveryAddress1,
            string deliveryAddress2,
            string deliveryCity,
            string deliveryCountry,
            DateTime? deliveryDate,
            string deliveryName,
            string deliveryZipCode,
            string documentNumber,
            DateTime dueDate2,
            EdiInformationDto ediInformation,
            bool euQuarterlyReport,
            EmailInformationDto emailInformation,
            string externalInvoiceReference1,
            string externalInvoiceReference2,
            DateTime? finalPayDate,
            double freight,
            double freightVat,
            double gross,
            bool houseWork,
            DateTime invoiceDate,
            DateTime? invoicePeriodEnd,
            string invoicePeriodReference,
            DateTime? invoicePeriodStart,
            InvoiceRowDto[] invoiceRows,
            InvoiceTypesDto invoiceType,
            InvoiceLabelDto[] labels,
            LanguageDto language,
            DateTime? lastRemindDate,
            double net,
            bool notCompleted,
            bool noxFinans,
            string ocr,
            string offerReference,
            string orderReference,
            string organisationNumber,
            string ourReference,
            DateTime outboundDate,
            PaymentWaysDto paymentWay,
            string phone1,
            string phone2,
            string priceList,
            string printTemplate,
            string project,
            string remarks,
            int reminders,
            double roundOff,
            bool sent,
            int? taxReduction,
            TaxReductionTypesDto taxReductionType,
            string termsOfDelivery,
            string termsOfPayment,
            int? timeBasisReference,
            double total,
            double totalToPay,
            double totalVat,
            bool vatIncluded,
            int? voucherNumber,
            string voucherSeries,
            int? voucherYear,
            bool warehouseReady,
            string wayOfDelivery,
            string yourOrderNumber,
            string yourReference,
            string zipCode
            )
        {
            if (city != null && city.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(city));

            if (comments != null && comments.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(comments));

            if (string.IsNullOrWhiteSpace(customerNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(customerNumber));

            if (deliveryAddress1 != null && deliveryAddress1.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(deliveryAddress1));

            if (deliveryAddress2 != null && deliveryAddress2.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(deliveryAddress2));

            if (deliveryCity != null && deliveryCity.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(deliveryCity));

            if (deliveryName != null && deliveryName.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(deliveryName));

            if (deliveryZipCode != null && deliveryZipCode.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(deliveryZipCode));

            if (externalInvoiceReference1 != null && externalInvoiceReference1.Length > 80)
                throw new ArgumentException("Value cannot be longer than 80 characters.", nameof(externalInvoiceReference1));

            if (externalInvoiceReference2 != null && externalInvoiceReference2.Length > 80)
                throw new ArgumentException("Value cannot be longer than 80 characters.", nameof(externalInvoiceReference2));

            if (ourReference != null && ourReference.Length > 50)
                throw new ArgumentException("Value cannot be longer than 50 characters.", nameof(ourReference));

            if (phone1 != null && phone1.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(phone1));

            if (phone2 != null && phone2.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(phone2));

            if (remarks != null && remarks.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(remarks));

            if (yourOrderNumber != null && yourOrderNumber.Length > 75)
                throw new ArgumentException("Value cannot be longer than 75 characters.", nameof(yourOrderNumber));

            if (yourReference != null && yourReference.Length > 50)
                throw new ArgumentException("Value cannot be longer than 50 characters.", nameof(yourReference));

            if (zipCode != null && zipCode.Length > 1024)
                throw new ArgumentException("Value cannot be longer than 1024 characters.", nameof(zipCode));

            Url = url;
            UrlTaxReductionList = urlTaxReductionList;
            AccountingMethod = accountingMethod;
            Address1 = address1;
            Address2 = address2;
            AdministrationFee = administrationFee;
            AdministrationFeeVat = administrationFeeVat;
            Balance = balance;
            BasisTaxReduction = basisTaxReduction;
            Booked = booked;
            Cancelled = cancelled;
            City = city;
            Comments = comments;
            ContractReference = contractReference;
            ContributionPercent = contributionPercent;
            ContributionValue = contributionValue;
            CostCenter = costCenter;
            Country = country;
            Credit = credit;
            CreditInvoiceReference = creditInvoiceReference;
            Currency = currency;
            CurrencyRate = currencyRate;
            CurrencyUnit = currencyUnit;
            CustomerName = customerName;
            CustomerNumber = customerNumber;
            DeliveryAddress1 = deliveryAddress1;
            DeliveryAddress2 = deliveryAddress2;
            DeliveryCity = deliveryCity;
            DeliveryCountry = deliveryCountry;
            DeliveryDate = deliveryDate;
            DeliveryName = deliveryName;
            DeliveryZipCode = deliveryZipCode;
            DocumentNumber = documentNumber;
            DueDate2 = dueDate2;
            EdiInformation = ediInformation;
            EuQuarterlyReport = euQuarterlyReport;
            EmailInformation = emailInformation;
            ExternalInvoiceReference1 = externalInvoiceReference1;
            ExternalInvoiceReference2 = externalInvoiceReference2;
            FinalPayDate = finalPayDate;
            Freight = freight;
            FreightVat = freightVat;
            Gross = gross;
            HouseWork = houseWork;
            InvoiceDate = invoiceDate;
            InvoicePeriodEnd = invoicePeriodEnd;
            InvoicePeriodReference = invoicePeriodReference;
            InvoicePeriodStart = invoicePeriodStart;
            InvoiceRows = invoiceRows;
            InvoiceType = invoiceType;
            Labels = labels;
            Language = language;
            LastRemindDate = lastRemindDate;
            Net = net;
            NotCompleted = notCompleted;
            NoxFinans = noxFinans;
            OCR = ocr;
            OfferReference = offerReference;
            OrderReference = orderReference;
            OrganisationNumber = organisationNumber;
            OurReference = ourReference;
            OutboundDate = outboundDate;
            PaymentWay = paymentWay;
            Phone1 = phone1;
            Phone2 = phone2;
            PriceList = priceList;
            PrintTemplate = printTemplate;
            Project = project;
            Remarks = remarks;
            Reminders = reminders;
            RoundOff = roundOff;
            Sent = sent;
            TaxReduction = taxReduction;
            TaxReductionType = taxReductionType;
            TermsOfDelivery = termsOfDelivery;
            TermsOfPayment = termsOfPayment;
            TimeBasisReference = timeBasisReference;
            Total = total;
            TotalToPay = totalToPay;
            TotalVAT = totalVat;
            VATIncluded = vatIncluded;
            VoucherNumber = voucherNumber;
            VoucherSeries = voucherSeries;
            VoucherYear = voucherYear;
            WarehouseReady = warehouseReady;
            WayOfDelivery = wayOfDelivery;
            YourOrderNumber = yourOrderNumber;
            YourReference = yourReference;
            ZipCode = zipCode;
        }

        [JsonPropertyName("@url")]
        public string Url { get; }
        
        [JsonPropertyName("@urlTaxReductionList")]
        public string UrlTaxReductionList { get; }
        
        [JsonPropertyName("AccountingMethod")]
        public AccountingMethodsDto AccountingMethod { get; }
        
        [JsonPropertyName("Address1")]
        public string Address1 { get; }
        
        [JsonPropertyName("Address2")]
        public string Address2 { get; }
        
        [JsonPropertyName("AdministrationFee")]
        public double AdministrationFee { get; }
        
        [JsonPropertyName("AdministrationFeeVAT")]
        public double AdministrationFeeVat { get; }
        
        [JsonPropertyName("Balance")]
        public double Balance { get; }
        
        [JsonPropertyName("BasisTaxReduction")]
        public double? BasisTaxReduction { get; }
        
        [JsonPropertyName("Booked")]
        public bool Booked { get; }
        
        [JsonPropertyName("Cancelled")]
        public bool Cancelled { get; }
        
        [JsonPropertyName("City")]
        public string City { get; }
        
        [JsonPropertyName("Comments")]
        public string Comments { get; }
        
        [JsonPropertyName("ContractReference")]
        public int ContractReference { get; }
        
        [JsonPropertyName("ContributionPercent")]
        public string ContributionPercent { get; }
        
        [JsonPropertyName("ContributionValue")]
        public string ContributionValue { get; }
        
        [JsonPropertyName("CostCenter")]
        public string CostCenter { get; }
        
        [JsonPropertyName("Country")]
        public string Country { get; }
        
        [JsonPropertyName("Credit")]
        public string Credit { get; }
        
        [JsonPropertyName("CreditInvoiceReference")]
        public string CreditInvoiceReference { get; }
        
        [JsonPropertyName("Currency")]
        public string Currency { get; }
        
        [JsonPropertyName("CurrencyRate")]
        public double CurrencyRate { get; }
        
        [JsonPropertyName("CurrencyUnit")]
        public int CurrencyUnit { get; }
        
        [JsonPropertyName("CustomerName")]
        public string CustomerName { get; }
        
        [JsonPropertyName("CustomerNumber")]
        public string CustomerNumber { get; }
        
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
        
        [JsonPropertyName("DueDate2")]
        public DateTime DueDate2 { get; }
        
        [JsonPropertyName("EDIInformation")]
        public EdiInformationDto EdiInformation { get; }
        
        [JsonPropertyName("EUQuarterlyReport")]
        public bool EuQuarterlyReport { get; }
        
        [JsonPropertyName("EmailInformation")]
        public EmailInformationDto EmailInformation { get; }
        
        [JsonPropertyName("ExternalInvoiceReference1")]
        public string ExternalInvoiceReference1 { get; }
        
        [JsonPropertyName("ExternalInvoiceReference2")]
        public string ExternalInvoiceReference2 { get; }
        
        [JsonPropertyName("FinalPayDate")]
        public DateTime? FinalPayDate { get; }
        
        [JsonPropertyName("Freight")]
        public double Freight { get; }
        
        [JsonPropertyName("FreightVAT")]
        public double FreightVat { get; }
        
        [JsonPropertyName("Gross")]
        public double Gross { get; }
        
        [JsonPropertyName("HouseWork")]
        public bool HouseWork { get; }
        
        [JsonPropertyName("InvoiceDate")]
        public DateTime InvoiceDate { get; }
        
        [JsonPropertyName("InvoicePeriodEnd")]
        public DateTime? InvoicePeriodEnd { get; }
        
        [JsonPropertyName("InvoicePeriodReference")]
        public string InvoicePeriodReference { get; }
        
        [JsonPropertyName("InvoicePeriodStart")]
        public DateTime? InvoicePeriodStart { get; }
        
        [JsonPropertyName("InvoiceRows")]
        public InvoiceRowDto[] InvoiceRows { get; }
        
        [JsonPropertyName("InvoiceType")]
        public InvoiceTypesDto InvoiceType { get; }
        
        [JsonPropertyName("Labels")]
        public InvoiceLabelDto[] Labels { get; }
        
        [JsonPropertyName("Language")]
        public LanguageDto Language { get; }
        
        [JsonPropertyName("LastRemindDate")]
        public DateTime? LastRemindDate { get; }
        
        [JsonPropertyName("Net")]
        public double Net { get; }
        
        [JsonPropertyName("NotCompleted")]
        public bool NotCompleted { get; }
        
        [JsonPropertyName("NoxFinans")]
        public bool NoxFinans { get; }
        
        [JsonPropertyName("OCR")]
        public string OCR { get; }
        
        [JsonPropertyName("OfferReference")]
        public string OfferReference { get; }
        
        [JsonPropertyName("OrderReference")]
        public string OrderReference { get; }
        
        [JsonPropertyName("OrganisationNumber")]
        public string OrganisationNumber { get; }
        
        [JsonPropertyName("OurReference")]
        public string OurReference { get; }
        
        [JsonPropertyName("OutboundDate")]
        public DateTime OutboundDate { get; }
        
        [JsonPropertyName("PaymentWay")]
        public PaymentWaysDto PaymentWay { get; }
        
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
        
        [JsonPropertyName("Remarks")]
        public string Remarks { get; }
        
        [JsonPropertyName("Reminders")]
        public int Reminders { get; }

        [JsonPropertyName("RoundOff")]
        public double RoundOff { get; }
        
        [JsonPropertyName("Sent")]
        public bool Sent { get; }

        [JsonPropertyName("TaxReduction")]
        public int? TaxReduction { get; }
        
        [JsonPropertyName("TaxReductionType")]
        public TaxReductionTypesDto TaxReductionType { get; }
        
        [JsonPropertyName("TermsOfDelivery")]
        public string TermsOfDelivery { get; }
        
        [JsonPropertyName("TermsOfPayment")]
        public string TermsOfPayment { get; }
        
        [JsonPropertyName("TimeBasisReference")]
        public int? TimeBasisReference { get; }
        
        [JsonPropertyName("Total")]
        public double Total { get; }
        
        [JsonPropertyName("TotalToPay")]
        public double TotalToPay { get; }
        
        [JsonPropertyName("TotalVAT")]
        public double TotalVAT { get; }
        
        [JsonPropertyName("VATIncluded")]
        public bool VATIncluded { get; }
        
        [JsonPropertyName("VoucherNumber")]
        public int? VoucherNumber { get; }
        
        [JsonPropertyName("VoucherSeries")]
        public string VoucherSeries { get; }
        
        [JsonPropertyName("VoucherYear")]
        public int? VoucherYear { get; }
        
        [JsonPropertyName("WarehouseReady")]
        public bool WarehouseReady { get; }
        
        [JsonPropertyName("WayOfDelivery")]
        public string WayOfDelivery { get; }
        
        [JsonPropertyName("YourOrderNumber")]
        public string YourOrderNumber { get; }
        
        [JsonPropertyName("YourReference")]
        public string YourReference { get; }
        
        [JsonPropertyName("ZipCode")]
        public string ZipCode { get; }
    }

    public class EdiInformationDto
    {
        public EdiInformationDto(
            string ediGlobalLocationNumber,
            string ediGlobalLocationNumberDelivery,
            string ediInvoiceExtra1,
            string ediInvoiceExtra2,
            string ediOurElectronicReference,
            string ediStatus,
            string ediYourElectronicReference
            )
        {
            EdiGlobalLocationNumber = ediGlobalLocationNumber;
            EdiGlobalLocationNumberDelivery = ediGlobalLocationNumberDelivery;
            EdiInvoiceExtra1 = ediInvoiceExtra1;
            EdiInvoiceExtra2 = ediInvoiceExtra2;
            EdiOurElectronicReference = ediOurElectronicReference;
            EdiStatus = ediStatus;
            EdiYourElectronicReference = ediYourElectronicReference;
        }

        [JsonPropertyName("EDIGlobalLocationNumber")]
        public string EdiGlobalLocationNumber { get; }
        
        [JsonPropertyName("EDIGlobalLocationNumberDelivery")]
        public string EdiGlobalLocationNumberDelivery { get; }
        
        [JsonPropertyName("EDIInvoiceExtra1")]
        public string EdiInvoiceExtra1 { get; }
        
        [JsonPropertyName("EDIInvoiceExtra2")]
        public string EdiInvoiceExtra2 { get; }
        
        [JsonPropertyName("EDIOurElectronicReference")]
        public string EdiOurElectronicReference { get; }
        
        [JsonPropertyName("EDIStatus")]
        public string EdiStatus { get; }
        
        [JsonPropertyName("EDIYourElectronicReference")]
        public string EdiYourElectronicReference { get; }
    }

    public class InvoiceLabelDto
    {
        public InvoiceLabelDto(int id)
        {
            Id = id;
        }

        [JsonPropertyName("Id")]
        public int Id { get; }
    }

    public class InvoiceRowDto
    {
        public InvoiceRowDto(
            int accountNumber,
            string articleNumber,
            string contributionPercent,
            string contributionValue,
            string costCenter,
            string deliveredQuantity,
            string description,
            double discount,
            DiscountTypesDto discountType,
            bool houseWork,
            int? houseWorkHoursToReport,
            HouseWorkTypesDto? houseWorkType,
            double price,
            double priceExcludingVat,
            string project,
            int rowId,
            string stockPointCode,
            double total,
            double totalExcludingVat,
            string unit,
            int vat,
            string vatCode
            )
        {
            AccountNumber = accountNumber;
            ArticleNumber = articleNumber;
            ContributionPercent = contributionPercent;
            ContributionValue = contributionValue;
            CostCenter = costCenter;
            DeliveredQuantity = deliveredQuantity;
            Description = description;
            Discount = discount;
            DiscountType = discountType;
            HouseWork = houseWork;
            HouseWorkHoursToReport = houseWorkHoursToReport;
            HouseWorkType = houseWorkType;
            Price = price;
            PriceExcludingVat = priceExcludingVat;
            Project = project;
            RowId = rowId;
            StockPointCode = stockPointCode;
            Total = total;
            TotalExcludingVat = totalExcludingVat;
            Unit = unit;
            Vat = vat;
            VatCode = vatCode;
        }

        [JsonPropertyName("AccountNumber")]
        public int AccountNumber { get; }
        
        [JsonPropertyName("ArticleNumber")]
        public string ArticleNumber { get; }
        
        [JsonPropertyName("ContributionPercent")]
        public string ContributionPercent { get; }

        [JsonPropertyName("ContributionValue")]
        public string ContributionValue { get; }
        
        [JsonPropertyName("CostCenter")]
        public string CostCenter { get; }
        
        [JsonPropertyName("DeliveredQuantity")]
        public string DeliveredQuantity { get; }
        
        [JsonPropertyName("Description")]
        public string Description { get; }
        
        [JsonPropertyName("Discount")]
        public double Discount { get; }
        
        [JsonPropertyName("DiscountType")]
        public DiscountTypesDto DiscountType { get; }
        
        [JsonPropertyName("HouseWork")]
        public bool HouseWork { get; }
        
        [JsonPropertyName("HouseWorkHoursToReport")]
        public int? HouseWorkHoursToReport { get; }
        
        [JsonPropertyName("HouseWorkType")]
        public HouseWorkTypesDto? HouseWorkType { get; }
        
        [JsonPropertyName("Price")]
        public double Price { get; }
        
        [JsonPropertyName("PriceExcludingVAT")]
        public double PriceExcludingVat { get; }
        
        [JsonPropertyName("Project")]
        public string Project { get; }
        
        [JsonPropertyName("RowId")]
        public int RowId { get; }
        
        [JsonPropertyName("StockPointCode")]
        public string StockPointCode { get; }
        
        [JsonPropertyName("Total")]
        public double Total { get; }
        
        [JsonPropertyName("TotalExcludingVAT")]
        public double TotalExcludingVat { get; }
        
        [JsonPropertyName("Unit")]
        public string Unit { get; }
        
        [JsonPropertyName("VAT")]
        public int Vat { get; }
        
        [JsonPropertyName("VATCode")]
        public string VatCode { get; }
    }

    public enum PaymentWaysDto
    {
        [EnumMember(Value = "CASH")]
        Cash,

        [EnumMember(Value = "CARD")]
        Card,

        [EnumMember(Value = "AG")]
        AG,

        [EnumMember(Value = "")]
        None
    }

    public enum LanguageDto
    {
        [EnumMember(Value = "SV")]
        Swedish,

        [EnumMember(Value = "EN")]
        English
    }

    public enum AccountingMethodsDto
    {
        [EnumMember(Value = "ACCRUAL")]
        Accrual,

        [EnumMember(Value = "CASH")]
        Cash
    }
}