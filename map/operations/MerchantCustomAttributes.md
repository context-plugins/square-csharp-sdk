<!-- Generated file — do not edit; regenerated with the SDK. -->

# MerchantCustomAttributes — operations

Accessor: `client.MerchantCustomAttributes` · Source: `Api/MerchantCustomAttributes.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkDeleteMerchantCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkDeleteMerchantCustomAttributes(BulkDeleteMerchantCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkDeleteMerchantCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteMerchantCustomAttributesRequest` | `Models/BulkDeleteMerchantCustomAttributesRequest.cs` |
| `BulkDeleteMerchantCustomAttributesResponse` | `Models/BulkDeleteMerchantCustomAttributesResponse.cs` |

### BulkUpsertMerchantCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpsertMerchantCustomAttributes(BulkUpsertMerchantCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkUpsertMerchantCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertMerchantCustomAttributesRequest` | `Models/BulkUpsertMerchantCustomAttributesRequest.cs` |
| `BulkUpsertMerchantCustomAttributesResponse` | `Models/BulkUpsertMerchantCustomAttributesResponse.cs` |

### CreateMerchantCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `CreateMerchantCustomAttributeDefinition(CreateMerchantCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateMerchantCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateMerchantCustomAttributeDefinitionRequest` | `Models/CreateMerchantCustomAttributeDefinitionRequest.cs` |
| `CreateMerchantCustomAttributeDefinitionResponse` | `Models/CreateMerchantCustomAttributeDefinitionResponse.cs` |

### DeleteMerchantCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteMerchantCustomAttribute(string merchantId, string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteMerchantCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteMerchantCustomAttributeResponse` | `Models/DeleteMerchantCustomAttributeResponse.cs` |

### DeleteMerchantCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteMerchantCustomAttributeDefinition(string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteMerchantCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteMerchantCustomAttributeDefinitionResponse` | `Models/DeleteMerchantCustomAttributeDefinitionResponse.cs` |

### ListMerchantCustomAttributeDefinitions

- **Auth**: `options.Oauth2`
- **Signature**: `ListMerchantCustomAttributeDefinitions(VisibilityFilter? visibilityFilter, int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `visibilityFilter` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `visibility_filter` ← `visibilityFilter`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListMerchantCustomAttributeDefinitionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VisibilityFilter` | `Models/Enums/VisibilityFilter.cs` |
| `ListMerchantCustomAttributeDefinitionsResponse` | `Models/ListMerchantCustomAttributeDefinitionsResponse.cs` |

### ListMerchantCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `ListMerchantCustomAttributes(string merchantId, VisibilityFilter? visibilityFilter, int? limit, string? cursor, bool? withDefinitions = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `visibilityFilter` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinitions` = `false`
- **Query params (wire ← C#)**: `visibility_filter` ← `visibilityFilter`, `limit` ← `limit`, `cursor` ← `cursor`, `with_definitions` ← `withDefinitions`
- **Returns**: `ListMerchantCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VisibilityFilter` | `Models/Enums/VisibilityFilter.cs` |
| `ListMerchantCustomAttributesResponse` | `Models/ListMerchantCustomAttributesResponse.cs` |

### RetrieveMerchantCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveMerchantCustomAttribute(string merchantId, string key, int? version, bool? withDefinition = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinition` = `false`
- **Query params (wire ← C#)**: `with_definition` ← `withDefinition`, `version` ← `version`
- **Returns**: `RetrieveMerchantCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveMerchantCustomAttributeResponse` | `Models/RetrieveMerchantCustomAttributeResponse.cs` |

### RetrieveMerchantCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveMerchantCustomAttributeDefinition(string key, int? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `RetrieveMerchantCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveMerchantCustomAttributeDefinitionResponse` | `Models/RetrieveMerchantCustomAttributeDefinitionResponse.cs` |

### UpdateMerchantCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateMerchantCustomAttributeDefinition(string key, UpdateMerchantCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateMerchantCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateMerchantCustomAttributeDefinitionRequest` | `Models/UpdateMerchantCustomAttributeDefinitionRequest.cs` |
| `UpdateMerchantCustomAttributeDefinitionResponse` | `Models/UpdateMerchantCustomAttributeDefinitionResponse.cs` |

### UpsertMerchantCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `UpsertMerchantCustomAttribute(string merchantId, string key, UpsertMerchantCustomAttributeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpsertMerchantCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertMerchantCustomAttributeRequest` | `Models/UpsertMerchantCustomAttributeRequest.cs` |
| `UpsertMerchantCustomAttributeResponse` | `Models/UpsertMerchantCustomAttributeResponse.cs` |

