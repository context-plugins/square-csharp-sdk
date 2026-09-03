<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransferOrderApi — operations

Accessor: `client.TransferOrderApi` · Source: `Api/TransferOrderApi.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CancelTransferOrder(string transferOrderId, CancelTransferOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelTransferOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTransferOrderRequest` | `Models/CancelTransferOrderRequest.cs` |
| `CancelTransferOrderResponse` | `Models/CancelTransferOrderResponse.cs` |

### CreateTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTransferOrder(CreateTransferOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTransferOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTransferOrderRequest` | `Models/CreateTransferOrderRequest.cs` |
| `CreateTransferOrderResponse` | `Models/CreateTransferOrderResponse.cs` |

### DeleteTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteTransferOrder(string transferOrderId, long? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `DeleteTransferOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteTransferOrderResponse` | `Models/DeleteTransferOrderResponse.cs` |

### ReceiveTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `ReceiveTransferOrder(string transferOrderId, ReceiveTransferOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ReceiveTransferOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReceiveTransferOrderRequest` | `Models/ReceiveTransferOrderRequest.cs` |
| `ReceiveTransferOrderResponse` | `Models/ReceiveTransferOrderResponse.cs` |

### RetrieveTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveTransferOrder(string transferOrderId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveTransferOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTransferOrderResponse` | `Models/RetrieveTransferOrderResponse.cs` |

### SearchTransferOrders

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTransferOrders(SearchTransferOrdersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTransferOrdersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTransferOrdersRequest` | `Models/SearchTransferOrdersRequest.cs` |
| `SearchTransferOrdersResponse` | `Models/SearchTransferOrdersResponse.cs` |

### StartTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `StartTransferOrder(string transferOrderId, StartTransferOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `StartTransferOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StartTransferOrderRequest` | `Models/StartTransferOrderRequest.cs` |
| `StartTransferOrderResponse` | `Models/StartTransferOrderResponse.cs` |

### UpdateTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateTransferOrder(string transferOrderId, UpdateTransferOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateTransferOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTransferOrderRequest` | `Models/UpdateTransferOrderRequest.cs` |
| `UpdateTransferOrderResponse` | `Models/UpdateTransferOrderResponse.cs` |

