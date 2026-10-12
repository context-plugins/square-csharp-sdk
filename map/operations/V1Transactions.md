<!-- Generated file — do not edit; regenerated with the SDK. -->

# V1Transactions — operations

Accessor: `client.V1Transactions` · Source: `src/Square/Api/V1Transactions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### V1ListOrders

- **Auth**: `options.Oauth2`
- **Signature**: `V1ListOrders(V1ListOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Query params (wire ← C#)**: `order` ← `Order`, `limit` ← `Limit`, `batch_token` ← `BatchToken`
- **Returns**: `IReadOnlyList<V1Order>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `V1ListOrdersRequest` | `src/Square/Requests/V1Transactions/V1ListOrdersRequest.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `V1Order` | `src/Square/Models/V1Order.cs` |

### V1RetrieveOrder

- **Auth**: `options.Oauth2`
- **Signature**: `V1RetrieveOrder(V1RetrieveOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `OrderId`
- **Returns**: `V1Order`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `V1RetrieveOrderRequest` | `src/Square/Requests/V1Transactions/V1RetrieveOrderRequest.cs` |
| `V1Order` | `src/Square/Models/V1Order.cs` |

### V1UpdateOrder

- **Auth**: `options.Oauth2`
- **Signature**: `V1UpdateOrder(V1UpdateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `OrderId`, `Body`
- **Returns**: `V1Order`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `V1UpdateOrderOperationRequest` | `src/Square/Requests/V1Transactions/V1UpdateOrderOperationRequest.cs` |
| `V1UpdateOrderRequest` | `src/Square/Models/V1UpdateOrderRequest.cs` |
| `V1Order` | `src/Square/Models/V1Order.cs` |

