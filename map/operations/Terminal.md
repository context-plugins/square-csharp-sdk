<!-- Generated file — do not edit; regenerated with the SDK. -->

# Terminal — operations

Accessor: `client.Terminal` · Source: `Api/Terminal.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelTerminalAction

- **Signature**: `CancelTerminalAction(string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelTerminalActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalActionResponse` | `Models/CancelTerminalActionResponse.cs` |

### CancelTerminalCheckout

- **Signature**: `CancelTerminalCheckout(string checkoutId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelTerminalCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalCheckoutResponse` | `Models/CancelTerminalCheckoutResponse.cs` |

### CancelTerminalRefund

- **Signature**: `CancelTerminalRefund(string terminalRefundId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelTerminalRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalRefundResponse` | `Models/CancelTerminalRefundResponse.cs` |

### CreateTerminalAction

- **Signature**: `CreateTerminalAction(CreateTerminalActionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTerminalActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalActionRequest` | `Models/CreateTerminalActionRequest.cs` |
| `CreateTerminalActionResponse` | `Models/CreateTerminalActionResponse.cs` |

### CreateTerminalCheckout

- **Signature**: `CreateTerminalCheckout(CreateTerminalCheckoutRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTerminalCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalCheckoutRequest` | `Models/CreateTerminalCheckoutRequest.cs` |
| `CreateTerminalCheckoutResponse` | `Models/CreateTerminalCheckoutResponse.cs` |

### CreateTerminalRefund

- **Signature**: `CreateTerminalRefund(CreateTerminalRefundRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTerminalRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalRefundRequest` | `Models/CreateTerminalRefundRequest.cs` |
| `CreateTerminalRefundResponse` | `Models/CreateTerminalRefundResponse.cs` |

### DismissTerminalAction

- **Signature**: `DismissTerminalAction(string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DismissTerminalActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalActionResponse` | `Models/DismissTerminalActionResponse.cs` |

### DismissTerminalCheckout

- **Signature**: `DismissTerminalCheckout(string checkoutId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DismissTerminalCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalCheckoutResponse` | `Models/DismissTerminalCheckoutResponse.cs` |

### DismissTerminalRefund

- **Signature**: `DismissTerminalRefund(string terminalRefundId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DismissTerminalRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalRefundResponse` | `Models/DismissTerminalRefundResponse.cs` |

### GetTerminalAction

- **Signature**: `GetTerminalAction(string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetTerminalActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalActionResponse` | `Models/GetTerminalActionResponse.cs` |

### GetTerminalCheckout

- **Signature**: `GetTerminalCheckout(string checkoutId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetTerminalCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalCheckoutResponse` | `Models/GetTerminalCheckoutResponse.cs` |

### GetTerminalRefund

- **Signature**: `GetTerminalRefund(string terminalRefundId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetTerminalRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalRefundResponse` | `Models/GetTerminalRefundResponse.cs` |

### SearchTerminalActions

- **Signature**: `SearchTerminalActions(SearchTerminalActionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTerminalActionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalActionsRequest` | `Models/SearchTerminalActionsRequest.cs` |
| `SearchTerminalActionsResponse` | `Models/SearchTerminalActionsResponse.cs` |

### SearchTerminalCheckouts

- **Signature**: `SearchTerminalCheckouts(SearchTerminalCheckoutsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTerminalCheckoutsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalCheckoutsRequest` | `Models/SearchTerminalCheckoutsRequest.cs` |
| `SearchTerminalCheckoutsResponse` | `Models/SearchTerminalCheckoutsResponse.cs` |

### SearchTerminalRefunds

- **Signature**: `SearchTerminalRefunds(SearchTerminalRefundsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTerminalRefundsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalRefundsRequest` | `Models/SearchTerminalRefundsRequest.cs` |
| `SearchTerminalRefundsResponse` | `Models/SearchTerminalRefundsResponse.cs` |

