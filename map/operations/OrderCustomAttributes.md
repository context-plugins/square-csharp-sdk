<!-- Generated file — do not edit; regenerated with the SDK. -->

# OrderCustomAttributes — operations

Accessor: `client.OrderCustomAttributes` · Source: `src/Square/Api/OrderCustomAttributes.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkDeleteOrderCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkDeleteOrderCustomAttributes(BulkDeleteOrderCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkDeleteOrderCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteOrderCustomAttributesOperationRequest` | `src/Square/Requests/OrderCustomAttributes/BulkDeleteOrderCustomAttributesOperationRequest.cs` |
| `BulkDeleteOrderCustomAttributesRequest` | `src/Square/Models/BulkDeleteOrderCustomAttributesRequest.cs` |
| `BulkDeleteOrderCustomAttributesResponse` | `src/Square/Models/BulkDeleteOrderCustomAttributesResponse.cs` |

### BulkUpsertOrderCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpsertOrderCustomAttributes(BulkUpsertOrderCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpsertOrderCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertOrderCustomAttributesOperationRequest` | `src/Square/Requests/OrderCustomAttributes/BulkUpsertOrderCustomAttributesOperationRequest.cs` |
| `BulkUpsertOrderCustomAttributesRequest` | `src/Square/Models/BulkUpsertOrderCustomAttributesRequest.cs` |
| `BulkUpsertOrderCustomAttributesResponse` | `src/Square/Models/BulkUpsertOrderCustomAttributesResponse.cs` |

### CreateOrderCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `CreateOrderCustomAttributeDefinition(CreateOrderCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateOrderCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateOrderCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/OrderCustomAttributes/CreateOrderCustomAttributeDefinitionOperationRequest.cs` |
| `CreateOrderCustomAttributeDefinitionRequest` | `src/Square/Models/CreateOrderCustomAttributeDefinitionRequest.cs` |
| `CreateOrderCustomAttributeDefinitionResponse` | `src/Square/Models/CreateOrderCustomAttributeDefinitionResponse.cs` |

### DeleteOrderCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteOrderCustomAttribute(DeleteOrderCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `CustomAttributeKey`
- **Returns**: `DeleteOrderCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteOrderCustomAttributeRequest` | `src/Square/Requests/OrderCustomAttributes/DeleteOrderCustomAttributeRequest.cs` |
| `DeleteOrderCustomAttributeResponse` | `src/Square/Models/DeleteOrderCustomAttributeResponse.cs` |

### DeleteOrderCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteOrderCustomAttributeDefinition(DeleteOrderCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Returns**: `DeleteOrderCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteOrderCustomAttributeDefinitionRequest` | `src/Square/Requests/OrderCustomAttributes/DeleteOrderCustomAttributeDefinitionRequest.cs` |
| `DeleteOrderCustomAttributeDefinitionResponse` | `src/Square/Models/DeleteOrderCustomAttributeDefinitionResponse.cs` |

### ListOrderCustomAttributeDefinitions

- **Auth**: `options.Oauth2`
- **Signature**: `ListOrderCustomAttributeDefinitions(ListOrderCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `visibility_filter` ← `VisibilityFilter`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListOrderCustomAttributeDefinitionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListOrderCustomAttributeDefinitionsRequest` | `src/Square/Requests/OrderCustomAttributes/ListOrderCustomAttributeDefinitionsRequest.cs` |
| `VisibilityFilter` | `src/Square/Models/Enums/VisibilityFilter.cs` |
| `ListOrderCustomAttributeDefinitionsResponse` | `src/Square/Models/ListOrderCustomAttributeDefinitionsResponse.cs` |

### ListOrderCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `ListOrderCustomAttributes(ListOrderCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Query params (wire ← C#)**: `visibility_filter` ← `VisibilityFilter`, `cursor` ← `Cursor`, `limit` ← `Limit`, `with_definitions` ← `WithDefinitions`
- **Returns**: `ListOrderCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListOrderCustomAttributesRequest` | `src/Square/Requests/OrderCustomAttributes/ListOrderCustomAttributesRequest.cs` |
| `VisibilityFilter` | `src/Square/Models/Enums/VisibilityFilter.cs` |
| `ListOrderCustomAttributesResponse` | `src/Square/Models/ListOrderCustomAttributesResponse.cs` |

### RetrieveOrderCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveOrderCustomAttribute(RetrieveOrderCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `CustomAttributeKey`
- **Query params (wire ← C#)**: `version` ← `Version`, `with_definition` ← `WithDefinition`
- **Returns**: `RetrieveOrderCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveOrderCustomAttributeRequest` | `src/Square/Requests/OrderCustomAttributes/RetrieveOrderCustomAttributeRequest.cs` |
| `RetrieveOrderCustomAttributeResponse` | `src/Square/Models/RetrieveOrderCustomAttributeResponse.cs` |

### RetrieveOrderCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveOrderCustomAttributeDefinition(RetrieveOrderCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `RetrieveOrderCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveOrderCustomAttributeDefinitionRequest` | `src/Square/Requests/OrderCustomAttributes/RetrieveOrderCustomAttributeDefinitionRequest.cs` |
| `RetrieveOrderCustomAttributeDefinitionResponse` | `src/Square/Models/RetrieveOrderCustomAttributeDefinitionResponse.cs` |

### UpdateOrderCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateOrderCustomAttributeDefinition(UpdateOrderCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`, `Body`
- **Returns**: `UpdateOrderCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateOrderCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/OrderCustomAttributes/UpdateOrderCustomAttributeDefinitionOperationRequest.cs` |
| `UpdateOrderCustomAttributeDefinitionRequest` | `src/Square/Models/UpdateOrderCustomAttributeDefinitionRequest.cs` |
| `UpdateOrderCustomAttributeDefinitionResponse` | `src/Square/Models/UpdateOrderCustomAttributeDefinitionResponse.cs` |

### UpsertOrderCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `UpsertOrderCustomAttribute(UpsertOrderCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `CustomAttributeKey`, `Body`
- **Returns**: `UpsertOrderCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertOrderCustomAttributeOperationRequest` | `src/Square/Requests/OrderCustomAttributes/UpsertOrderCustomAttributeOperationRequest.cs` |
| `UpsertOrderCustomAttributeRequest` | `src/Square/Models/UpsertOrderCustomAttributeRequest.cs` |
| `UpsertOrderCustomAttributeResponse` | `src/Square/Models/UpsertOrderCustomAttributeResponse.cs` |

