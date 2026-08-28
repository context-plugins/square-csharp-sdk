<!-- Generated file — do not edit; regenerated with the SDK. -->

# OrderCustomAttributes — operations

Accessor: `client.OrderCustomAttributes` · Source: `Api/OrderCustomAttributes.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkDeleteOrderCustomAttributes

- **Signature**: `BulkDeleteOrderCustomAttributes(BulkDeleteOrderCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkDeleteOrderCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteOrderCustomAttributesRequest` | `Models/BulkDeleteOrderCustomAttributesRequest.cs` |
| `BulkDeleteOrderCustomAttributesResponse` | `Models/BulkDeleteOrderCustomAttributesResponse.cs` |

### BulkUpsertOrderCustomAttributes

- **Signature**: `BulkUpsertOrderCustomAttributes(BulkUpsertOrderCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkUpsertOrderCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertOrderCustomAttributesRequest` | `Models/BulkUpsertOrderCustomAttributesRequest.cs` |
| `BulkUpsertOrderCustomAttributesResponse` | `Models/BulkUpsertOrderCustomAttributesResponse.cs` |

### CreateOrderCustomAttributeDefinition

- **Signature**: `CreateOrderCustomAttributeDefinition(CreateOrderCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateOrderCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateOrderCustomAttributeDefinitionRequest` | `Models/CreateOrderCustomAttributeDefinitionRequest.cs` |
| `CreateOrderCustomAttributeDefinitionResponse` | `Models/CreateOrderCustomAttributeDefinitionResponse.cs` |

### DeleteOrderCustomAttribute

- **Signature**: `DeleteOrderCustomAttribute(string orderId, string customAttributeKey, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteOrderCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteOrderCustomAttributeResponse` | `Models/DeleteOrderCustomAttributeResponse.cs` |

### DeleteOrderCustomAttributeDefinition

- **Signature**: `DeleteOrderCustomAttributeDefinition(string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteOrderCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteOrderCustomAttributeDefinitionResponse` | `Models/DeleteOrderCustomAttributeDefinitionResponse.cs` |

### ListOrderCustomAttributeDefinitions

- **Signature**: `ListOrderCustomAttributeDefinitions(VisibilityFilter? visibilityFilter, string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `visibilityFilter` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `visibility_filter` ← `visibilityFilter`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListOrderCustomAttributeDefinitionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VisibilityFilter` | `Models/Enums/VisibilityFilter.cs` |
| `ListOrderCustomAttributeDefinitionsResponse` | `Models/ListOrderCustomAttributeDefinitionsResponse.cs` |

### ListOrderCustomAttributes

- **Signature**: `ListOrderCustomAttributes(string orderId, VisibilityFilter? visibilityFilter, string? cursor, int? limit, bool? withDefinitions = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `visibilityFilter` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinitions` = `false`
- **Query params (wire ← C#)**: `visibility_filter` ← `visibilityFilter`, `cursor` ← `cursor`, `limit` ← `limit`, `with_definitions` ← `withDefinitions`
- **Returns**: `ListOrderCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VisibilityFilter` | `Models/Enums/VisibilityFilter.cs` |
| `ListOrderCustomAttributesResponse` | `Models/ListOrderCustomAttributesResponse.cs` |

### RetrieveOrderCustomAttribute

- **Signature**: `RetrieveOrderCustomAttribute(string orderId, string customAttributeKey, int? version, bool? withDefinition = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinition` = `false`
- **Query params (wire ← C#)**: `version` ← `version`, `with_definition` ← `withDefinition`
- **Returns**: `RetrieveOrderCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveOrderCustomAttributeResponse` | `Models/RetrieveOrderCustomAttributeResponse.cs` |

### RetrieveOrderCustomAttributeDefinition

- **Signature**: `RetrieveOrderCustomAttributeDefinition(string key, int? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `RetrieveOrderCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveOrderCustomAttributeDefinitionResponse` | `Models/RetrieveOrderCustomAttributeDefinitionResponse.cs` |

### UpdateOrderCustomAttributeDefinition

- **Signature**: `UpdateOrderCustomAttributeDefinition(string key, UpdateOrderCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateOrderCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateOrderCustomAttributeDefinitionRequest` | `Models/UpdateOrderCustomAttributeDefinitionRequest.cs` |
| `UpdateOrderCustomAttributeDefinitionResponse` | `Models/UpdateOrderCustomAttributeDefinitionResponse.cs` |

### UpsertOrderCustomAttribute

- **Signature**: `UpsertOrderCustomAttribute(string orderId, string customAttributeKey, UpsertOrderCustomAttributeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpsertOrderCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertOrderCustomAttributeRequest` | `Models/UpsertOrderCustomAttributeRequest.cs` |
| `UpsertOrderCustomAttributeResponse` | `Models/UpsertOrderCustomAttributeResponse.cs` |

