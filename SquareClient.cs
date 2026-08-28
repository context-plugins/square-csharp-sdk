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
    public SquareClient(HttpClient httpClient, SquareClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
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
        var rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        var auth = new AuthSchemes(options, server, rawClient, urlFactory);
        ApplePay = new ApplePay(rawClient, server, auth);
        BankAccounts = new BankAccounts(rawClient, server, auth);
        BookingCustomAttributes = new BookingCustomAttributes(rawClient, server, auth);
        Bookings = new Bookings(rawClient, server, auth);
        Cards = new Cards(rawClient, server, auth);
        CashDrawers = new CashDrawers(rawClient, server, auth);
        Catalog = new Catalog(rawClient, server, auth);
        Channels = new Channels(rawClient, server, auth);
        CheckoutApi = new CheckoutApi(rawClient, server, auth);
        CustomerCustomAttributes = new CustomerCustomAttributes(rawClient, server, auth);
        CustomerGroups = new CustomerGroups(rawClient, server, auth);
        CustomerSegments = new CustomerSegments(rawClient, server, auth);
        Customers = new Customers(rawClient, server, auth);
        Devices = new Devices(rawClient, server, auth);
        Disputes = new Disputes(rawClient, server, auth);
        Employees = new Employees(rawClient, server, auth);
        Events = new Events(rawClient, server, auth);
        GiftCardActivities = new GiftCardActivities(rawClient, server, auth);
        GiftCards = new GiftCards(rawClient, server, auth);
        Inventory = new Inventory(rawClient, server, auth);
        Invoices = new Invoices(rawClient, server, auth);
        Labor = new Labor(rawClient, server, auth);
        LocationCustomAttributes = new LocationCustomAttributes(rawClient, server, auth);
        Locations = new Locations(rawClient, server, auth);
        Loyalty = new Loyalty(rawClient, server, auth);
        MerchantCustomAttributes = new MerchantCustomAttributes(rawClient, server, auth);
        Merchants = new Merchants(rawClient, server, auth);
        OAuth = new OAuth(rawClient, server, auth);
        OrderCustomAttributes = new OrderCustomAttributes(rawClient, server, auth);
        Orders = new Orders(rawClient, server, auth);
        Payments = new Payments(rawClient, server, auth);
        Payouts = new Payouts(rawClient, server, auth);
        Refunds = new Refunds(rawClient, server, auth);
        Sites = new Sites(rawClient, server, auth);
        Snippets = new Snippets(rawClient, server, auth);
        Subscriptions = new Subscriptions(rawClient, server, auth);
        Team = new Team(rawClient, server, auth);
        Terminal = new Terminal(rawClient, server, auth);
        Transactions = new Transactions(rawClient, server, auth);
        TransferOrderApi = new TransferOrderApi(rawClient, server, auth);
        V1Transactions = new V1Transactions(rawClient, server, auth);
        Vendors = new Vendors(rawClient, server, auth);
        WebhookSubscriptions = new WebhookSubscriptions(rawClient, server, auth);
    }

    public ApplePay ApplePay { get; }

    public BankAccounts BankAccounts { get; }

    public BookingCustomAttributes BookingCustomAttributes { get; }

    public Bookings Bookings { get; }

    public Cards Cards { get; }

    public CashDrawers CashDrawers { get; }

    public Catalog Catalog { get; }

    public Channels Channels { get; }

    public CheckoutApi CheckoutApi { get; }

    public CustomerCustomAttributes CustomerCustomAttributes { get; }

    public CustomerGroups CustomerGroups { get; }

    public CustomerSegments CustomerSegments { get; }

    public Customers Customers { get; }

    public Devices Devices { get; }

    public Disputes Disputes { get; }

    public Employees Employees { get; }

    public Events Events { get; }

    public GiftCardActivities GiftCardActivities { get; }

    public GiftCards GiftCards { get; }

    public Inventory Inventory { get; }

    public Invoices Invoices { get; }

    public Labor Labor { get; }

    public LocationCustomAttributes LocationCustomAttributes { get; }

    public Locations Locations { get; }

    public Loyalty Loyalty { get; }

    public MerchantCustomAttributes MerchantCustomAttributes { get; }

    public Merchants Merchants { get; }

    public OAuth OAuth { get; }

    public OrderCustomAttributes OrderCustomAttributes { get; }

    public Orders Orders { get; }

    public Payments Payments { get; }

    public Payouts Payouts { get; }

    public Refunds Refunds { get; }

    public Sites Sites { get; }

    public Snippets Snippets { get; }

    public Subscriptions Subscriptions { get; }

    public Team Team { get; }

    public Terminal Terminal { get; }

    public Transactions Transactions { get; }

    public TransferOrderApi TransferOrderApi { get; }

    public V1Transactions V1Transactions { get; }

    public Vendors Vendors { get; }

    public WebhookSubscriptions WebhookSubscriptions { get; }
}
