<!-- Generated file — do not edit; regenerated with the SDK. -->

# Terminal — operations

Accessor: `client.Terminal` · Source: `src/Square/Api/Terminal.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelTerminalAction

- **Auth**: `options.Oauth2`
- **Signature**: `CancelTerminalAction(CancelTerminalActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ActionId`
- **Returns**: `CancelTerminalActionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalActionRequest` | `src/Square/Requests/Terminal/CancelTerminalActionRequest.cs` |
| `CancelTerminalActionResponse` | `src/Square/Models/CancelTerminalActionResponse.cs` |

### CancelTerminalCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `CancelTerminalCheckout(CancelTerminalCheckoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CheckoutId`
- **Returns**: `CancelTerminalCheckoutResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalCheckoutRequest` | `src/Square/Requests/Terminal/CancelTerminalCheckoutRequest.cs` |
| `CancelTerminalCheckoutResponse` | `src/Square/Models/CancelTerminalCheckoutResponse.cs` |

### CancelTerminalRefund

- **Auth**: `options.Oauth2`
- **Signature**: `CancelTerminalRefund(CancelTerminalRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalRefundId`
- **Returns**: `CancelTerminalRefundResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTerminalRefundRequest` | `src/Square/Requests/Terminal/CancelTerminalRefundRequest.cs` |
| `CancelTerminalRefundResponse` | `src/Square/Models/CancelTerminalRefundResponse.cs` |

### CreateTerminalAction

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTerminalAction(CreateTerminalActionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateTerminalActionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalActionOperationRequest` | `src/Square/Requests/Terminal/CreateTerminalActionOperationRequest.cs` |
| `CreateTerminalActionRequest` | `src/Square/Models/CreateTerminalActionRequest.cs` |
| `CreateTerminalActionResponse` | `src/Square/Models/CreateTerminalActionResponse.cs` |

### CreateTerminalCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTerminalCheckout(CreateTerminalCheckoutOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateTerminalCheckoutResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalCheckoutOperationRequest` | `src/Square/Requests/Terminal/CreateTerminalCheckoutOperationRequest.cs` |
| `CreateTerminalCheckoutRequest` | `src/Square/Models/CreateTerminalCheckoutRequest.cs` |
| `CreateTerminalCheckoutResponse` | `src/Square/Models/CreateTerminalCheckoutResponse.cs` |

### CreateTerminalRefund

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTerminalRefund(CreateTerminalRefundOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateTerminalRefundResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTerminalRefundOperationRequest` | `src/Square/Requests/Terminal/CreateTerminalRefundOperationRequest.cs` |
| `CreateTerminalRefundRequest` | `src/Square/Models/CreateTerminalRefundRequest.cs` |
| `CreateTerminalRefundResponse` | `src/Square/Models/CreateTerminalRefundResponse.cs` |

### DismissTerminalAction

- **Auth**: `options.Oauth2`
- **Signature**: `DismissTerminalAction(DismissTerminalActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ActionId`
- **Returns**: `DismissTerminalActionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalActionRequest` | `src/Square/Requests/Terminal/DismissTerminalActionRequest.cs` |
| `DismissTerminalActionResponse` | `src/Square/Models/DismissTerminalActionResponse.cs` |

### DismissTerminalCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `DismissTerminalCheckout(DismissTerminalCheckoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CheckoutId`
- **Returns**: `DismissTerminalCheckoutResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalCheckoutRequest` | `src/Square/Requests/Terminal/DismissTerminalCheckoutRequest.cs` |
| `DismissTerminalCheckoutResponse` | `src/Square/Models/DismissTerminalCheckoutResponse.cs` |

### DismissTerminalRefund

- **Auth**: `options.Oauth2`
- **Signature**: `DismissTerminalRefund(DismissTerminalRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalRefundId`
- **Returns**: `DismissTerminalRefundResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DismissTerminalRefundRequest` | `src/Square/Requests/Terminal/DismissTerminalRefundRequest.cs` |
| `DismissTerminalRefundResponse` | `src/Square/Models/DismissTerminalRefundResponse.cs` |

### GetTerminalAction

- **Auth**: `options.Oauth2`
- **Signature**: `GetTerminalAction(GetTerminalActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ActionId`
- **Returns**: `GetTerminalActionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalActionRequest` | `src/Square/Requests/Terminal/GetTerminalActionRequest.cs` |
| `GetTerminalActionResponse` | `src/Square/Models/GetTerminalActionResponse.cs` |

### GetTerminalCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `GetTerminalCheckout(GetTerminalCheckoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CheckoutId`
- **Returns**: `GetTerminalCheckoutResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalCheckoutRequest` | `src/Square/Requests/Terminal/GetTerminalCheckoutRequest.cs` |
| `GetTerminalCheckoutResponse` | `src/Square/Models/GetTerminalCheckoutResponse.cs` |

### GetTerminalRefund

- **Auth**: `options.Oauth2`
- **Signature**: `GetTerminalRefund(GetTerminalRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalRefundId`
- **Returns**: `GetTerminalRefundResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTerminalRefundRequest` | `src/Square/Requests/Terminal/GetTerminalRefundRequest.cs` |
| `GetTerminalRefundResponse` | `src/Square/Models/GetTerminalRefundResponse.cs` |

### SearchTerminalActions

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTerminalActions(SearchTerminalActionsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchTerminalActionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalActionsOperationRequest` | `src/Square/Requests/Terminal/SearchTerminalActionsOperationRequest.cs` |
| `SearchTerminalActionsRequest` | `src/Square/Models/SearchTerminalActionsRequest.cs` |
| `SearchTerminalActionsResponse` | `src/Square/Models/SearchTerminalActionsResponse.cs` |

### SearchTerminalCheckouts

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTerminalCheckouts(SearchTerminalCheckoutsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchTerminalCheckoutsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalCheckoutsOperationRequest` | `src/Square/Requests/Terminal/SearchTerminalCheckoutsOperationRequest.cs` |
| `SearchTerminalCheckoutsRequest` | `src/Square/Models/SearchTerminalCheckoutsRequest.cs` |
| `SearchTerminalCheckoutsResponse` | `src/Square/Models/SearchTerminalCheckoutsResponse.cs` |

### SearchTerminalRefunds

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTerminalRefunds(SearchTerminalRefundsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchTerminalRefundsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTerminalRefundsOperationRequest` | `src/Square/Requests/Terminal/SearchTerminalRefundsOperationRequest.cs` |
| `SearchTerminalRefundsRequest` | `src/Square/Models/SearchTerminalRefundsRequest.cs` |
| `SearchTerminalRefundsResponse` | `src/Square/Models/SearchTerminalRefundsResponse.cs` |

