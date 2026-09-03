<!-- Generated file — do not edit; regenerated with the SDK. -->

# V1Transactions — operations

Accessor: `client.V1Transactions` · Source: `Api/V1Transactions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### V1ListOrders

- **Auth**: `options.Oauth2`
- **Signature**: `V1ListOrders(string locationId, SortOrder? order, int? limit, string? batchToken, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `order` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `batchToken` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `order` ← `order`, `limit` ← `limit`, `batch_token` ← `batchToken`
- **Returns**: `IReadOnlyList<V1Order>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `V1Order` | `Models/V1Order.cs` |

### V1RetrieveOrder

- **Auth**: `options.Oauth2`
- **Signature**: `V1RetrieveOrder(string locationId, string orderId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1Order`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `V1Order` | `Models/V1Order.cs` |

### V1UpdateOrder

- **Auth**: `options.Oauth2`
- **Signature**: `V1UpdateOrder(string locationId, string orderId, V1UpdateOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1Order`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `V1UpdateOrderRequest` | `Models/V1UpdateOrderRequest.cs` |
| `V1Order` | `Models/V1Order.cs` |

