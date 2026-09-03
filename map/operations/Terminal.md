<!-- Generated file — do not edit; regenerated with the SDK. -->

# Terminal — operations

Accessor: `client.Terminal` · Source: `Api/Terminal.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelTerminalAction

- **Auth**: `options.Oauth2`
- **Signature**: `CancelTerminalAction(string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelTerminalActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalActionResponse` | `Models/CancelTerminalActionResponse.cs` |

### CancelTerminalCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `CancelTerminalCheckout(string checkoutId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelTerminalCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalCheckoutResponse` | `Models/CancelTerminalCheckoutResponse.cs` |

### CancelTerminalRefund

- **Auth**: `options.Oauth2`
- **Signature**: `CancelTerminalRefund(string terminalRefundId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelTerminalRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalRefundResponse` | `Models/CancelTerminalRefundResponse.cs` |

### CreateTerminalAction

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTerminalAction(CreateTerminalActionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTerminalActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalActionRequest` | `Models/CreateTerminalActionRequest.cs` |
| `CreateTerminalActionResponse` | `Models/CreateTerminalActionResponse.cs` |

### CreateTerminalCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTerminalCheckout(CreateTerminalCheckoutRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTerminalCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalCheckoutRequest` | `Models/CreateTerminalCheckoutRequest.cs` |
| `CreateTerminalCheckoutResponse` | `Models/CreateTerminalCheckoutResponse.cs` |

### CreateTerminalRefund

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTerminalRefund(CreateTerminalRefundRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTerminalRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalRefundRequest` | `Models/CreateTerminalRefundRequest.cs` |
| `CreateTerminalRefundResponse` | `Models/CreateTerminalRefundResponse.cs` |

### DismissTerminalAction

- **Auth**: `options.Oauth2`
- **Signature**: `DismissTerminalAction(string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DismissTerminalActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalActionResponse` | `Models/DismissTerminalActionResponse.cs` |

### DismissTerminalCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `DismissTerminalCheckout(string checkoutId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DismissTerminalCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalCheckoutResponse` | `Models/DismissTerminalCheckoutResponse.cs` |

### DismissTerminalRefund

- **Auth**: `options.Oauth2`
- **Signature**: `DismissTerminalRefund(string terminalRefundId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DismissTerminalRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalRefundResponse` | `Models/DismissTerminalRefundResponse.cs` |

### GetTerminalAction

- **Auth**: `options.Oauth2`
- **Signature**: `GetTerminalAction(string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetTerminalActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalActionResponse` | `Models/GetTerminalActionResponse.cs` |

### GetTerminalCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `GetTerminalCheckout(string checkoutId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetTerminalCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalCheckoutResponse` | `Models/GetTerminalCheckoutResponse.cs` |

### GetTerminalRefund

- **Auth**: `options.Oauth2`
- **Signature**: `GetTerminalRefund(string terminalRefundId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetTerminalRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalRefundResponse` | `Models/GetTerminalRefundResponse.cs` |

### SearchTerminalActions

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTerminalActions(SearchTerminalActionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTerminalActionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalActionsRequest` | `Models/SearchTerminalActionsRequest.cs` |
| `SearchTerminalActionsResponse` | `Models/SearchTerminalActionsResponse.cs` |

### SearchTerminalCheckouts

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTerminalCheckouts(SearchTerminalCheckoutsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTerminalCheckoutsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalCheckoutsRequest` | `Models/SearchTerminalCheckoutsRequest.cs` |
| `SearchTerminalCheckoutsResponse` | `Models/SearchTerminalCheckoutsResponse.cs` |

### SearchTerminalRefunds

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTerminalRefunds(SearchTerminalRefundsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTerminalRefundsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalRefundsRequest` | `Models/SearchTerminalRefundsRequest.cs` |
| `SearchTerminalRefundsResponse` | `Models/SearchTerminalRefundsResponse.cs` |

