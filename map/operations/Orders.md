<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `src/Square/Api/Orders.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BatchRetrieveOrders

- **Auth**: `options.Oauth2`
- **Signature**: `BatchRetrieveOrders(BatchRetrieveOrdersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveOrdersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveOrdersOperationRequest` | `src/Square/Requests/Orders/BatchRetrieveOrdersOperationRequest.cs` |
| `BatchRetrieveOrdersRequest` | `src/Square/Models/BatchRetrieveOrdersRequest.cs` |
| `BatchRetrieveOrdersResponse` | `src/Square/Models/BatchRetrieveOrdersResponse.cs` |

### CalculateOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CalculateOrder(CalculateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CalculateOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CalculateOrderOperationRequest` | `src/Square/Requests/Orders/CalculateOrderOperationRequest.cs` |
| `CalculateOrderRequest` | `src/Square/Models/CalculateOrderRequest.cs` |
| `CalculateOrderResponse` | `src/Square/Models/CalculateOrderResponse.cs` |

### CloneOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CloneOrder(CloneOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CloneOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CloneOrderOperationRequest` | `src/Square/Requests/Orders/CloneOrderOperationRequest.cs` |
| `CloneOrderRequest` | `src/Square/Models/CloneOrderRequest.cs` |
| `CloneOrderResponse` | `src/Square/Models/CloneOrderResponse.cs` |

### CreateOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CreateOrder(CreateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateOrderOperationRequest` | `src/Square/Requests/Orders/CreateOrderOperationRequest.cs` |
| `CreateOrderRequest` | `src/Square/Models/CreateOrderRequest.cs` |
| `CreateOrderResponse` | `src/Square/Models/CreateOrderResponse.cs` |

### PayOrder

- **Auth**: `options.Oauth2`
- **Signature**: `PayOrder(PayOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `Body`
- **Returns**: `PayOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PayOrderOperationRequest` | `src/Square/Requests/Orders/PayOrderOperationRequest.cs` |
| `PayOrderRequest` | `src/Square/Models/PayOrderRequest.cs` |
| `PayOrderResponse` | `src/Square/Models/PayOrderResponse.cs` |

### RetrieveOrder

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveOrder(RetrieveOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Returns**: `RetrieveOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveOrderRequest` | `src/Square/Requests/Orders/RetrieveOrderRequest.cs` |
| `RetrieveOrderResponse` | `src/Square/Models/RetrieveOrderResponse.cs` |

### SearchOrders

- **Auth**: `options.Oauth2`
- **Signature**: `SearchOrders(SearchOrdersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchOrdersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchOrdersOperationRequest` | `src/Square/Requests/Orders/SearchOrdersOperationRequest.cs` |
| `SearchOrdersRequest` | `src/Square/Models/SearchOrdersRequest.cs` |
| `SearchOrdersResponse` | `src/Square/Models/SearchOrdersResponse.cs` |

### UpdateOrder

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateOrder(UpdateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `Body`
- **Returns**: `UpdateOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateOrderOperationRequest` | `src/Square/Requests/Orders/UpdateOrderOperationRequest.cs` |
| `UpdateOrderRequest` | `src/Square/Models/UpdateOrderRequest.cs` |
| `UpdateOrderResponse` | `src/Square/Models/UpdateOrderResponse.cs` |

