<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransferOrderApi — operations

Accessor: `client.TransferOrderApi` · Source: `src/Square/Api/TransferOrderApi.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CancelTransferOrder(CancelTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferOrderId`, `Body`
- **Returns**: `CancelTransferOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelTransferOrderOperationRequest` | `src/Square/Requests/TransferOrderApi/CancelTransferOrderOperationRequest.cs` |
| `CancelTransferOrderRequest` | `src/Square/Models/CancelTransferOrderRequest.cs` |
| `CancelTransferOrderResponse` | `src/Square/Models/CancelTransferOrderResponse.cs` |

### CreateTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTransferOrder(CreateTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateTransferOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTransferOrderOperationRequest` | `src/Square/Requests/TransferOrderApi/CreateTransferOrderOperationRequest.cs` |
| `CreateTransferOrderRequest` | `src/Square/Models/CreateTransferOrderRequest.cs` |
| `CreateTransferOrderResponse` | `src/Square/Models/CreateTransferOrderResponse.cs` |

### DeleteTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteTransferOrder(DeleteTransferOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferOrderId`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `DeleteTransferOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteTransferOrderRequest` | `src/Square/Requests/TransferOrderApi/DeleteTransferOrderRequest.cs` |
| `DeleteTransferOrderResponse` | `src/Square/Models/DeleteTransferOrderResponse.cs` |

### ReceiveTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `ReceiveTransferOrder(ReceiveTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferOrderId`, `Body`
- **Returns**: `ReceiveTransferOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReceiveTransferOrderOperationRequest` | `src/Square/Requests/TransferOrderApi/ReceiveTransferOrderOperationRequest.cs` |
| `ReceiveTransferOrderRequest` | `src/Square/Models/ReceiveTransferOrderRequest.cs` |
| `ReceiveTransferOrderResponse` | `src/Square/Models/ReceiveTransferOrderResponse.cs` |

### RetrieveTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveTransferOrder(RetrieveTransferOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferOrderId`
- **Returns**: `RetrieveTransferOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTransferOrderRequest` | `src/Square/Requests/TransferOrderApi/RetrieveTransferOrderRequest.cs` |
| `RetrieveTransferOrderResponse` | `src/Square/Models/RetrieveTransferOrderResponse.cs` |

### SearchTransferOrders

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTransferOrders(SearchTransferOrdersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchTransferOrdersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTransferOrdersOperationRequest` | `src/Square/Requests/TransferOrderApi/SearchTransferOrdersOperationRequest.cs` |
| `SearchTransferOrdersRequest` | `src/Square/Models/SearchTransferOrdersRequest.cs` |
| `SearchTransferOrdersResponse` | `src/Square/Models/SearchTransferOrdersResponse.cs` |

### StartTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `StartTransferOrder(StartTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferOrderId`, `Body`
- **Returns**: `StartTransferOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StartTransferOrderOperationRequest` | `src/Square/Requests/TransferOrderApi/StartTransferOrderOperationRequest.cs` |
| `StartTransferOrderRequest` | `src/Square/Models/StartTransferOrderRequest.cs` |
| `StartTransferOrderResponse` | `src/Square/Models/StartTransferOrderResponse.cs` |

### UpdateTransferOrder

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateTransferOrder(UpdateTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferOrderId`, `Body`
- **Returns**: `UpdateTransferOrderResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTransferOrderOperationRequest` | `src/Square/Requests/TransferOrderApi/UpdateTransferOrderOperationRequest.cs` |
| `UpdateTransferOrderRequest` | `src/Square/Models/UpdateTransferOrderRequest.cs` |
| `UpdateTransferOrderResponse` | `src/Square/Models/UpdateTransferOrderResponse.cs` |

