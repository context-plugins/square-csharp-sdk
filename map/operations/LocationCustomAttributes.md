<!-- Generated file — do not edit; regenerated with the SDK. -->

# LocationCustomAttributes — operations

Accessor: `client.LocationCustomAttributes` · Source: `Api/LocationCustomAttributes.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkDeleteLocationCustomAttributes

- **Signature**: `BulkDeleteLocationCustomAttributes(BulkDeleteLocationCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkDeleteLocationCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteLocationCustomAttributesRequest` | `Models/BulkDeleteLocationCustomAttributesRequest.cs` |
| `BulkDeleteLocationCustomAttributesResponse` | `Models/BulkDeleteLocationCustomAttributesResponse.cs` |

### BulkUpsertLocationCustomAttributes

- **Signature**: `BulkUpsertLocationCustomAttributes(BulkUpsertLocationCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkUpsertLocationCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertLocationCustomAttributesRequest` | `Models/BulkUpsertLocationCustomAttributesRequest.cs` |
| `BulkUpsertLocationCustomAttributesResponse` | `Models/BulkUpsertLocationCustomAttributesResponse.cs` |

### CreateLocationCustomAttributeDefinition

- **Signature**: `CreateLocationCustomAttributeDefinition(CreateLocationCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateLocationCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLocationCustomAttributeDefinitionRequest` | `Models/CreateLocationCustomAttributeDefinitionRequest.cs` |
| `CreateLocationCustomAttributeDefinitionResponse` | `Models/CreateLocationCustomAttributeDefinitionResponse.cs` |

### DeleteLocationCustomAttribute

- **Signature**: `DeleteLocationCustomAttribute(string locationId, string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteLocationCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteLocationCustomAttributeResponse` | `Models/DeleteLocationCustomAttributeResponse.cs` |

### DeleteLocationCustomAttributeDefinition

- **Signature**: `DeleteLocationCustomAttributeDefinition(string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteLocationCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteLocationCustomAttributeDefinitionResponse` | `Models/DeleteLocationCustomAttributeDefinitionResponse.cs` |

### ListLocationCustomAttributeDefinitions

- **Signature**: `ListLocationCustomAttributeDefinitions(VisibilityFilter? visibilityFilter, int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `visibilityFilter` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `visibility_filter` ← `visibilityFilter`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListLocationCustomAttributeDefinitionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VisibilityFilter` | `Models/Enums/VisibilityFilter.cs` |
| `ListLocationCustomAttributeDefinitionsResponse` | `Models/ListLocationCustomAttributeDefinitionsResponse.cs` |

### ListLocationCustomAttributes

- **Signature**: `ListLocationCustomAttributes(string locationId, VisibilityFilter? visibilityFilter, int? limit, string? cursor, bool? withDefinitions = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `visibilityFilter` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinitions` = `false`
- **Query params (wire ← C#)**: `visibility_filter` ← `visibilityFilter`, `limit` ← `limit`, `cursor` ← `cursor`, `with_definitions` ← `withDefinitions`
- **Returns**: `ListLocationCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VisibilityFilter` | `Models/Enums/VisibilityFilter.cs` |
| `ListLocationCustomAttributesResponse` | `Models/ListLocationCustomAttributesResponse.cs` |

### RetrieveLocationCustomAttribute

- **Signature**: `RetrieveLocationCustomAttribute(string locationId, string key, int? version, bool? withDefinition = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinition` = `false`
- **Query params (wire ← C#)**: `with_definition` ← `withDefinition`, `version` ← `version`
- **Returns**: `RetrieveLocationCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationCustomAttributeResponse` | `Models/RetrieveLocationCustomAttributeResponse.cs` |

### RetrieveLocationCustomAttributeDefinition

- **Signature**: `RetrieveLocationCustomAttributeDefinition(string key, int? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `RetrieveLocationCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationCustomAttributeDefinitionResponse` | `Models/RetrieveLocationCustomAttributeDefinitionResponse.cs` |

### UpdateLocationCustomAttributeDefinition

- **Signature**: `UpdateLocationCustomAttributeDefinition(string key, UpdateLocationCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateLocationCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateLocationCustomAttributeDefinitionRequest` | `Models/UpdateLocationCustomAttributeDefinitionRequest.cs` |
| `UpdateLocationCustomAttributeDefinitionResponse` | `Models/UpdateLocationCustomAttributeDefinitionResponse.cs` |

### UpsertLocationCustomAttribute

- **Signature**: `UpsertLocationCustomAttribute(string locationId, string key, UpsertLocationCustomAttributeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpsertLocationCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertLocationCustomAttributeRequest` | `Models/UpsertLocationCustomAttributeRequest.cs` |
| `UpsertLocationCustomAttributeResponse` | `Models/UpsertLocationCustomAttributeResponse.cs` |

