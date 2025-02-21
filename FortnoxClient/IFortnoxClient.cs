using System;
using System.Threading.Tasks;
using FortnoxClient.Dto.Articles;
using FortnoxClient.Dto.CompanyInformation;
using FortnoxClient.Dto.Customers;
using FortnoxClient.Dto.Invoices;
using FortnoxClient.Dto.Me;
using FortnoxClient.Dto.Orders;
using FortnoxClient.Dto.PriceLists;
using FortnoxClient.Dto.Prices;
using Refit;

namespace FortnoxClient
{
    public interface IFortnoxClient
    {
        #region Company Information
        [Get("/3/companyinformation")]
        Task<CompanyInformationResponse> GetCompanyInformation();

        [Get("/3/companyinformation")]
        Task<CompanyInformationResponse> GetCompanyInformation([Authorize] string token);
        #endregion

        #region Me
        [Get("/3/me")]
        Task<MeResponse> GetMe();

        [Get("/3/me")]
        Task<MeResponse> GetMe([Authorize] string token);
        #endregion

        #region Customers
        [Get("/3/customers")]
        Task<GetCustomerListResponse> GetCustomerList([AliasAs("filter")] CustomerFilterDto? filter = null);

        [Get("/3/customers/{customerNumber}")]
        Task<GetCustomerResponse> GetCustomer(string customerNumber);

        [Post("/3/customers")]
        Task<CreateCustomerResponse> CreateCustomer([Body] CreateCustomerRequest request);
        #endregion

        #region Articles
        [Get("/3/articles/{articleNumber}")]
        Task<GetArticleResponse> GetArticle(string articleNumber);

        [Get("/3/articles")]
        Task<GetArticlesResponse> GetArticles(
            [AliasAs("page")] int? page = null,
            [AliasAs("filter")] ArticleFilterDto? filter = null,
            [AliasAs("articlenumber")] string articlenumber = null,
            [AliasAs("description")] string description = null,
            [AliasAs("ean")] string ean = null,
            [AliasAs("suppliernumber")] string suppliernumber = null,
            [AliasAs("manufacturer")] string manufacturer = null,
            [AliasAs("manufacturerarticlenumber")] string manufacturerarticlenumber = null,
            [AliasAs("webshop")] string webshop = null,
            [AliasAs("lastmodified")] string lastmodified = null,
            [AliasAs("sortby")] ArticleSortByDto? sortby = null
        );
        #endregion

        #region Prices
        [Get("/3/prices/{priceList}/{articleNumber}/{fromQuantity}")]
        Task<GetPriceResponse> GetPrice(string priceList, string articleNumber, double fromQuantity);

        [Get("/3/prices/sublist/{priceList}/{articleNumber}")]
        Task<GetPricesResponse> GetPrices(string priceList, string articleNumber);

        [Get("/3/prices/{priceList}/{articleNumber}")]
        Task<GetPriceResponse> GetPrice(string priceList, string articleNumber);
        #endregion

        #region PriceLists
        [Get("/3/pricelists")]
        Task<GetPriceListsResponse> GetPriceLists();

        [Get("/3/pricelists/{code}")]
        Task<GetPriceListResponse> GetPriceList(string code);
        #endregion

        #region Orders
        [Get("/3/orders/")]
        Task<GetOrdersResponse> GetOrders([AliasAs("filter")] OrderFilterDto? filter = null);

        [Post("/3/orders/")]
        Task<CreateOrderResponse> CreateOrder([Body] CreateOrderRequest request);

        [Get("/3/orders/{documentNumber}")]
        Task<GetOrderResponse> GetOrder(string documentNumber);
        #endregion

        #region Invoices
        [Get("/3/invoices/")]
        Task<GetInvoicesResponse> GetInvoices(
            [AliasAs("page")] int? page = null,
            [AliasAs("filter")] InvoiceFilterDto? filter = null,
            [AliasAs("costcenter")] string costCenter = null,
            [AliasAs("customername")] string customerName = null,
            [AliasAs("customernumber")] string customerNumber = null,
            [AliasAs("label")] string label = null,
            [AliasAs("documentnumber")] string documentNumber = null,
            [AliasAs("fromdate")] DateTime? fromDate = null,
            [AliasAs("todate")] DateTime? toDate = null,
            [AliasAs("fromfinalpaydate")] DateTime? fromFinalPayDate = null,
            [AliasAs("tofinalpaydate")] DateTime? toFinalPayDate = null,
            [AliasAs("lastmodified")] DateTime? lastModified = null,
            [AliasAs("notcompleted")] string notCompleted = null,
            [AliasAs("ocr")] string ocr = null,
            [AliasAs("ourreference")] string ourReference = null,
            [AliasAs("project")] string project = null,
            [AliasAs("sent")] string sent = null,
            [AliasAs("externalinvoicereference1")] string externalInvoiceReference1 = null,
            [AliasAs("externalinvoicereference2")] string externalInvoiceReference2 = null,
            [AliasAs("yourreference")] string yourReference = null,
            [AliasAs("invoicetype")] string invoiceType = null,
            [AliasAs("articlenumber")] string articleNumber = null,
            [AliasAs("articledescription")] string articleDescription = null,
            [AliasAs("currency")] string currency = null,
            [AliasAs("accountnumberfrom")] string accountNumberFrom = null,
            [AliasAs("accountnumberto")] string accountNumberTo = null,
            [AliasAs("yourordernumber")] string yourOrderNumber = null,
            [AliasAs("credit")] string credit = null,
            [AliasAs("sortby")] InvoiceSortByDto? sortBy = null
        );

        [Post("/3/invoices/")]
        Task<CreateInvoiceResponse> CreateInvoice([Body] CreateInvoiceRequest request);

        [Get("/3/invoices/{documentNumber}")]
        Task<GetInvoiceResponse> GetInvoice(string documentNumber);
        #endregion
    }
}