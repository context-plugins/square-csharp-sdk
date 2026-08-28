<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `Api/Orders.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BatchRetrieveOrders

- **Signature**: `BatchRetrieveOrders(BatchRetrieveOrdersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchRetrieveOrdersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveOrdersRequest` | `Models/BatchRetrieveOrdersRequest.cs` |
| `BatchRetrieveOrdersResponse` | `Models/BatchRetrieveOrdersResponse.cs` |

### CalculateOrder

- **Signature**: `CalculateOrder(CalculateOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CalculateOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CalculateOrderRequest` | `Models/CalculateOrderRequest.cs` |
| `CalculateOrderResponse` | `Models/CalculateOrderResponse.cs` |

### CloneOrder

- **Signature**: `CloneOrder(CloneOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CloneOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CloneOrderRequest` | `Models/CloneOrderRequest.cs` |
| `CloneOrderResponse` | `Models/CloneOrderResponse.cs` |

### CreateOrder

- **Signature**: `CreateOrder(CreateOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateOrderRequest` | `Models/CreateOrderRequest.cs` |
| `CreateOrderResponse` | `Models/CreateOrderResponse.cs` |

### PayOrder

- **Signature**: `PayOrder(string orderId, PayOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PayOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PayOrderRequest` | `Models/PayOrderRequest.cs` |
| `PayOrderResponse` | `Models/PayOrderResponse.cs` |

### RetrieveOrder

- **Signature**: `RetrieveOrder(string orderId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveOrderResponse` | `Models/RetrieveOrderResponse.cs` |

### SearchOrders

- **Signature**: `SearchOrders(SearchOrdersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchOrdersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchOrdersRequest` | `Models/SearchOrdersRequest.cs` |
| `SearchOrdersResponse` | `Models/SearchOrdersResponse.cs` |

### UpdateOrder

- **Signature**: `UpdateOrder(string orderId, UpdateOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateOrderResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateOrderRequest` | `Models/UpdateOrderRequest.cs` |
| `UpdateOrderResponse` | `Models/UpdateOrderResponse.cs` |

