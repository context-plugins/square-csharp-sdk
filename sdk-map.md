<!-- Generated file — do not edit; regenerated with the SDK. -->

# SDK map — Square (.NET)

> A generated table of contents for this SDK. Consult this map and its sub-pages to learn signatures, error types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

|  |  |
| --- | --- |
| SDK display name | Square |
| Root namespace | `Square` |
| Target framework | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| API spec version | `2.0` |
| Generator | APIMatic |

Staleness check: the API spec version above changes when the SDK is regenerated from a new spec. If a lookup here fails to compile, trust the compiler and re-read the source file named in the row.

All `Source` paths on this map and its sub-pages are relative to the **SDK root** — the directory holding this file — never to the page that carries them; the project file is `src/Square/Square.csproj`. Open them as-is from the SDK root, from any page; if the SDK sits under a subdirectory of a larger repo, prefix that subdirectory.

---

## Getting a client

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options = new SquareClientOptions
{
    Oauth2ClientSecret = "YOUR_API_KEY",
    Oauth2 = new OAuth2AuthorizationCodeCredentials
    {
        ClientId = "YOUR_CLIENT_ID",
        RedirectUri = "YOUR_REDIRECT_URI",
        PromptForAuthorizationCode = (authUrl, ct) => Task.FromResult(""),
    },
    Environment = ServerEnvironment.Production,
};
var client = new SquareClient(httpClient, options);
```

DI alternative (`services.AddSquareClient`):

```csharp
services.AddSquareClient(options =>
{
    options.Oauth2ClientSecret = "YOUR_API_KEY";
    options.Oauth2 =
        new OAuth2AuthorizationCodeCredentials
        {
            ClientId = "YOUR_CLIENT_ID",
            RedirectUri = "YOUR_REDIRECT_URI",
            PromptForAuthorizationCode = (authUrl, ct) => Task.FromResult(""),
        };
    options.Environment = ServerEnvironment.Production;
    // TODO: configure more client options here
});
```

Every API group is a property on the client (e.g. `client.ApplePay`). Source: `src/Square/SquareClient.cs`. The only constructor is `SquareClient(HttpClient httpClient, SquareClientOptions options)`.

All `SquareClientOptions` properties (source: `src/Square/SquareClientOptions.cs`):

| Property | Type |
| --- | --- |
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Logging` | `LoggingOptions` |
| `TimeProvider` | `TimeProvider` |
| `Server` | `ServerOptions` |
| `StreamReadTimeout` | `TimeSpan?` |
| `Hooks` | `IReadOnlyList<SdkHook>` |
| `Oauth2` | `OAuth2AuthorizationCodeCredentials?` |
| `Oauth2TokenStrategy` | `IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>?` |
| `Oauth2ClientSecret` | `string?` |

`ServerEnvironment` (source: `src/Square/Servers/ServerEnvironment.cs`, namespace `Square.Servers`)
`OAuth2AuthorizationCodeCredentials` (source: `src/Square/Core/Authentication/OAuth2/AuthorizationCode/OAuth2AuthorizationCodeCredentials.cs`, namespace `Square.Core.Authentication.OAuth2.AuthorizationCode`)

`RetryOptions` members (namespace `Square.Core.Configuration` — add `using Square.Core.Configuration;`; source: `src/Square/Core/Configuration/RetryOptions.cs`; all members are `required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
| --- | --- |
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `ApiException<TError>` (`src/Square/Core/Exceptions/ApiException.cs`, namespace `Square.Core.Exceptions`) exposing `.Error` of type `TError` beside the `StatusCode`, `Headers` and `ContentType` of the response. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class (namespace `Square.Errors`) with status-specific `TryGet…(out …)` accessors (each returns `true` when that shape is present) plus the inherited `TryGetRawError(out RawError)` fallback. The operation blocks name the exact `TryGet…` methods and the HTTP status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`src/Square/Core/ErrorResponse/RawError.cs`, namespace `Square.Core.ErrorResponse`): `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?`.

⚠ Each of the three lives in its own namespace. `src/Square/Core/` holds several namespaces, so a catch block naming `ApiException<T>`, a typed `{Operation}Error` and `RawError` together needs a `using` for each.

`ApiException<TError>` is one leaf of the `SdkException` family (`src/Square/Core/Exceptions/SdkException.cs`): a request that produced no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match its declared type as `ResponseDeserializationException`, and a credential that could not be applied as `AuthSchemeException`. Every one of them names the failed call. The full table is in [README → Error Handling](README.md#error-handling).

Core error types (`src/Square/Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
| --- | --- | --- |
| `ApiError` — abstract base of typed error classes (none in this SDK) | `TryGetRawError(out RawError error): bool` | `src/Square/Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `src/Square/Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.

```csharp
try
{
    var response = await client.ApplePay.RegisterDomain(new RegisterDomainOperationRequest
    {
        Body = new RegisterDomainRequest { DomainName = "some example string" },
    });
}
catch (ApiException<RawError> ex)
{
    // Case B — raw error
    // ex.Error.StatusCode, ex.Error.ReadAsString(), ex.Error.ReadAsJson<T>()
}
```

**No-throw (`…Result`) variants: absent across this SDK** — every operation is throw-only. Of **334 operations**, **0 are Case A (typed)** and **334 are Case B (raw)**.

---

## Operations — by controller (43 groups, 334 operations)

Each links to a sub-page with one row per operation: signature, the request record's required members, query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each operation also carries a **Type sources** table — every type it names, with the file that declares it — so resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that operation's row says otherwise, so a row silent on one of these points is telling you the default here applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
| --- | --- | --- |
| **Throw-only** — no `…Result`/no-throw variant exists anywhere in this SDK | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation returns a single response, not a `Pageable` | here | pagination is offered — the block carries a **Pagination** bullet naming the posture (page-, offset-, cursor- or link-based, or the `page`-without-page-size case) |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `Default`** — base URL per Servers & auth below | here | the operation is on another group — its block carries a **Server group** bullet |
| **Inputs are one request record** — an operation that takes input takes a single request record as its first parameter; build it with an object initializer, using the property names in the record's source (its file is in the operation's **Type sources**). A member the row does not list as required is optional or already carries the spec's default | here | never — it always holds |

**The HTTP verb and route live on the operation itself**, in the source file named at the top of its operations page. This map is method-first: the C# method is the interface you call. When something wire-level needs the route — reproducing a raw request, pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass — a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields — that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
| --- | --- | --- |
| `ApplePay` | 1 | [map/operations/ApplePay.md](map/operations/ApplePay.md) |
| `BankAccounts` | 5 | [map/operations/BankAccounts.md](map/operations/BankAccounts.md) |
| `BookingCustomAttributes` | 11 | [map/operations/BookingCustomAttributes.md](map/operations/BookingCustomAttributes.md) |
| `Bookings` | 13 | [map/operations/Bookings.md](map/operations/Bookings.md) |
| `Cards` | 4 | [map/operations/Cards.md](map/operations/Cards.md) |
| `CashDrawers` | 3 | [map/operations/CashDrawers.md](map/operations/CashDrawers.md) |
| `Catalog` | 14 | [map/operations/Catalog.md](map/operations/Catalog.md) |
| `Channels` | 3 | [map/operations/Channels.md](map/operations/Channels.md) |
| `CheckoutApi` | 10 | [map/operations/CheckoutApi.md](map/operations/CheckoutApi.md) |
| `CustomerCustomAttributes` | 10 | [map/operations/CustomerCustomAttributes.md](map/operations/CustomerCustomAttributes.md) |
| `CustomerGroups` | 5 | [map/operations/CustomerGroups.md](map/operations/CustomerGroups.md) |
| `CustomerSegments` | 2 | [map/operations/CustomerSegments.md](map/operations/CustomerSegments.md) |
| `Customers` | 14 | [map/operations/Customers.md](map/operations/Customers.md) |
| `Devices` | 5 | [map/operations/Devices.md](map/operations/Devices.md) |
| `Disputes` | 9 | [map/operations/Disputes.md](map/operations/Disputes.md) |
| `Employees` | 2 | [map/operations/Employees.md](map/operations/Employees.md) |
| `Events` | 4 | [map/operations/Events.md](map/operations/Events.md) |
| `GiftCardActivities` | 2 | [map/operations/GiftCardActivities.md](map/operations/GiftCardActivities.md) |
| `GiftCards` | 7 | [map/operations/GiftCards.md](map/operations/GiftCards.md) |
| `Inventory` | 19 | [map/operations/Inventory.md](map/operations/Inventory.md) |
| `Invoices` | 10 | [map/operations/Invoices.md](map/operations/Invoices.md) |
| `Labor` | 27 | [map/operations/Labor.md](map/operations/Labor.md) |
| `LocationCustomAttributes` | 11 | [map/operations/LocationCustomAttributes.md](map/operations/LocationCustomAttributes.md) |
| `Locations` | 4 | [map/operations/Locations.md](map/operations/Locations.md) |
| `Loyalty` | 18 | [map/operations/Loyalty.md](map/operations/Loyalty.md) |
| `MerchantCustomAttributes` | 11 | [map/operations/MerchantCustomAttributes.md](map/operations/MerchantCustomAttributes.md) |
| `Merchants` | 2 | [map/operations/Merchants.md](map/operations/Merchants.md) |
| `OAuth` | 3 | [map/operations/OAuth.md](map/operations/OAuth.md) |
| `OrderCustomAttributes` | 11 | [map/operations/OrderCustomAttributes.md](map/operations/OrderCustomAttributes.md) |
| `Orders` | 8 | [map/operations/Orders.md](map/operations/Orders.md) |
| `Payments` | 7 | [map/operations/Payments.md](map/operations/Payments.md) |
| `Payouts` | 3 | [map/operations/Payouts.md](map/operations/Payouts.md) |
| `Refunds` | 3 | [map/operations/Refunds.md](map/operations/Refunds.md) |
| `Sites` | 1 | [map/operations/Sites.md](map/operations/Sites.md) |
| `Snippets` | 3 | [map/operations/Snippets.md](map/operations/Snippets.md) |
| `Subscriptions` | 12 | [map/operations/Subscriptions.md](map/operations/Subscriptions.md) |
| `Team` | 12 | [map/operations/Team.md](map/operations/Team.md) |
| `Terminal` | 15 | [map/operations/Terminal.md](map/operations/Terminal.md) |
| `Transactions` | 4 | [map/operations/Transactions.md](map/operations/Transactions.md) |
| `TransferOrderApi` | 8 | [map/operations/TransferOrderApi.md](map/operations/TransferOrderApi.md) |
| `V1Transactions` | 3 | [map/operations/V1Transactions.md](map/operations/V1Transactions.md) |
| `Vendors` | 7 | [map/operations/Vendors.md](map/operations/Vendors.md) |
| `WebhookSubscriptions` | 8 | [map/operations/WebhookSubscriptions.md](map/operations/WebhookSubscriptions.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `src/Square/Models/`, `src/Square/Errors/` and `src/Square/Requests/` declares exactly one public type, named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's **Type sources** table, or build it from the kind's directory below. Never grep for a type.

| Group | Count | Directory (file = `<TypeName>.cs`) |
| --- | --- | --- |
| Records (plain `record` data models) | 1271 | `src/Square/Models/` |
| Enums (`OpenStringEnum<T>` / `OpenIntEnum<T>`) — C# member names + wire values | 203 | `src/Square/Models/Enums/` |
| Request records (one per operation that takes input; never serialized) | 325 | `src/Square/Requests/` — a controller's records sit in a folder named after it (an operation with several tags is filed under the first tag it declares) |

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer; `T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name (`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. `OneOf`/`AnyOf` unions wrap `Optional<T>` variants — build via static factory or implicit conversion, read via `TryGet…(out …)`; `AllOf` compositions are not unions — every constituent is a `required` property, so set them all, and those constituent properties carry no `[JsonPropertyName]` and have no wire name of their own, because the generated converter flattens each constituent's own fields directly into the one parent JSON object. Enums are **not** C# enums — use the static members, whose names are PascalCase even when the wire value isn't (`CollectionMethod.Invoice`, not `.invoice`); there is no public factory, so resolve a raw value with `TryGetKnownValue` and branch with the generated `Match`, whose `otherwise` arm receives any value the SDK does not declare.

Namespaces by content type (add `using` accordingly):

| Contents | Namespace |
| --- | --- |
| Client & options (root) | `Square` |
| Operation controllers (`src/Square/Api/`) | `Square.Api` |
| Records (`src/Square/Models/`) | `Square.Models` |
| Enums (`src/Square/Models/Enums/`) | `Square.Models.Enums` |
| Request records (`src/Square/Requests/`) | `Square.Requests` — plus `.<Controller>` for a controller's records (an operation with several tags is filed under the first tag it declares) |

---

## Servers & auth

**OAuth2 (authorization code).** Set `options.Oauth2` with client id, redirect URI and a `PromptForAuthorizationCode` callback; authorization at `https://connect.squareup.com/oauth2/authorize`, tokens from `https://connect.squareup.com/oauth2/token`. `options.Oauth2TokenStrategy` overrides how tokens are acquired and cached; leave it unset for the SDK's own handling.

**API key (header `Authorization`).** Set `options.Oauth2ClientSecret = "<api_key>"`; sent as the `Authorization` request header.

Operation blocks name their credential in an **Auth** bullet; an operation whose spec declares no scheme carries no such bullet.

- `AND` — every credential listed must be set for the call to be fully authenticated.
- `OR` — the first credential you set that applies successfully is the one sent, in the order listed.

A credential you never set is skipped rather than throwing, and the request is sent anyway — so an authentication failure can mean no credential was sent rather than a bad one. Under `OR`, if every credential you did set fails to apply, `AuthSchemeException` is thrown.

**Environments.** `options.Environment` selects the target environment (`src/Square/Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
| --- | --- | --- |
| `ServerEnvironment.Production` *(default)* | `production` | — |
| `ServerEnvironment.Sandbox` | `sandbox` | — |
| `ServerEnvironment.Custom` | `custom` | — |

**1 server group.** Base-URL templates and override points (`options.Server.…`):

| Group | `Production` base URL | `Sandbox` base URL | `Custom` base URL | Override point |
| --- | --- | --- | --- | --- |
| `Default` | `https://connect.squareup.com` | `https://connect.squareupsandbox.com` | `{custom_url}` | `options.Server.Default.Production.BaseUrl` (and the other environments) |

`Default` · `Custom` template variables: `{custom_url}` defaults to `"https://connect.squareup.com"` — override `options.Server.Default.Custom.CustomUrl`.

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).

