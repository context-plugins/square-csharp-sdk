using System.Net.Http;
using Square.Api;
using Square.Core;
using Square.Core.Logging;
using Square.Core.Models;

namespace Square;

/// <summary>
/// Use Square APIs to manage and run business including payment, customer, product, inventory, and employee management.
/// </summary>
public sealed class SquareClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public SquareClient(HttpClient httpClient, SquareClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "SquareClient/2.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "2.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "SquareClient");
        _rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        _auth = new AuthSchemes(options, _server, _rawClient, urlFactory);
    }

    public ApplePay ApplePay => field ??= new ApplePay(_rawClient, _server, _auth);

    public BankAccounts BankAccounts => field ??= new BankAccounts(_rawClient, _server, _auth);

    public BookingCustomAttributes BookingCustomAttributes =>
        field ??= new BookingCustomAttributes(_rawClient, _server, _auth);

    public Bookings Bookings => field ??= new Bookings(_rawClient, _server, _auth);

    public Cards Cards => field ??= new Cards(_rawClient, _server, _auth);

    public CashDrawers CashDrawers => field ??= new CashDrawers(_rawClient, _server, _auth);

    public Catalog Catalog => field ??= new Catalog(_rawClient, _server, _auth);

    public Channels Channels => field ??= new Channels(_rawClient, _server, _auth);

    public CheckoutApi CheckoutApi => field ??= new CheckoutApi(_rawClient, _server, _auth);

    public CustomerCustomAttributes CustomerCustomAttributes =>
        field ??= new CustomerCustomAttributes(_rawClient, _server, _auth);

    public CustomerGroups CustomerGroups => field ??= new CustomerGroups(_rawClient, _server, _auth);

    public CustomerSegments CustomerSegments => field ??= new CustomerSegments(_rawClient, _server, _auth);

    public Customers Customers => field ??= new Customers(_rawClient, _server, _auth);

    public Devices Devices => field ??= new Devices(_rawClient, _server, _auth);

    public Disputes Disputes => field ??= new Disputes(_rawClient, _server, _auth);

    public Employees Employees => field ??= new Employees(_rawClient, _server, _auth);

    public Events Events => field ??= new Events(_rawClient, _server, _auth);

    public GiftCardActivities GiftCardActivities =>
        field ??= new GiftCardActivities(_rawClient, _server, _auth);

    public GiftCards GiftCards => field ??= new GiftCards(_rawClient, _server, _auth);

    public Inventory Inventory => field ??= new Inventory(_rawClient, _server, _auth);

    public Invoices Invoices => field ??= new Invoices(_rawClient, _server, _auth);

    public Labor Labor => field ??= new Labor(_rawClient, _server, _auth);

    public LocationCustomAttributes LocationCustomAttributes =>
        field ??= new LocationCustomAttributes(_rawClient, _server, _auth);

    public Locations Locations => field ??= new Locations(_rawClient, _server, _auth);

    public Loyalty Loyalty => field ??= new Loyalty(_rawClient, _server, _auth);

    public MerchantCustomAttributes MerchantCustomAttributes =>
        field ??= new MerchantCustomAttributes(_rawClient, _server, _auth);

    public Merchants Merchants => field ??= new Merchants(_rawClient, _server, _auth);

    public OAuth OAuth => field ??= new OAuth(_rawClient, _server, _auth);

    public OrderCustomAttributes OrderCustomAttributes =>
        field ??= new OrderCustomAttributes(_rawClient, _server, _auth);

    public Orders Orders => field ??= new Orders(_rawClient, _server, _auth);

    public Payments Payments => field ??= new Payments(_rawClient, _server, _auth);

    public Payouts Payouts => field ??= new Payouts(_rawClient, _server, _auth);

    public Refunds Refunds => field ??= new Refunds(_rawClient, _server, _auth);

    public Sites Sites => field ??= new Sites(_rawClient, _server, _auth);

    public Snippets Snippets => field ??= new Snippets(_rawClient, _server, _auth);

    public Subscriptions Subscriptions => field ??= new Subscriptions(_rawClient, _server, _auth);

    public Team Team => field ??= new Team(_rawClient, _server, _auth);

    public Terminal Terminal => field ??= new Terminal(_rawClient, _server, _auth);

    public Transactions Transactions => field ??= new Transactions(_rawClient, _server, _auth);

    public TransferOrderApi TransferOrderApi => field ??= new TransferOrderApi(_rawClient, _server, _auth);

    public V1Transactions V1Transactions => field ??= new V1Transactions(_rawClient, _server, _auth);

    public Vendors Vendors => field ??= new Vendors(_rawClient, _server, _auth);

    public WebhookSubscriptions WebhookSubscriptions =>
        field ??= new WebhookSubscriptions(_rawClient, _server, _auth);
}
