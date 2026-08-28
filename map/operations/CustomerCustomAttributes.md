<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerCustomAttributes — operations

Accessor: `client.CustomerCustomAttributes` · Source: `Api/CustomerCustomAttributes.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkUpsertCustomerCustomAttributes

- **Signature**: `BulkUpsertCustomerCustomAttributes(BulkUpsertCustomerCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkUpsertCustomerCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertCustomerCustomAttributesRequest` | `Models/BulkUpsertCustomerCustomAttributesRequest.cs` |
| `BulkUpsertCustomerCustomAttributesResponse` | `Models/BulkUpsertCustomerCustomAttributesResponse.cs` |

### CreateCustomerCustomAttributeDefinition

- **Signature**: `CreateCustomerCustomAttributeDefinition(CreateCustomerCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateCustomerCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerCustomAttributeDefinitionRequest` | `Models/CreateCustomerCustomAttributeDefinitionRequest.cs` |
| `CreateCustomerCustomAttributeDefinitionResponse` | `Models/CreateCustomerCustomAttributeDefinitionResponse.cs` |

### DeleteCustomerCustomAttribute

- **Signature**: `DeleteCustomerCustomAttribute(string customerId, string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteCustomerCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerCustomAttributeResponse` | `Models/DeleteCustomerCustomAttributeResponse.cs` |

### DeleteCustomerCustomAttributeDefinition

- **Signature**: `DeleteCustomerCustomAttributeDefinition(string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteCustomerCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerCustomAttributeDefinitionResponse` | `Models/DeleteCustomerCustomAttributeDefinitionResponse.cs` |

### ListCustomerCustomAttributeDefinitions

- **Signature**: `ListCustomerCustomAttributeDefinitions(int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListCustomerCustomAttributeDefinitionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerCustomAttributeDefinitionsResponse` | `Models/ListCustomerCustomAttributeDefinitionsResponse.cs` |

### ListCustomerCustomAttributes

- **Signature**: `ListCustomerCustomAttributes(string customerId, int? limit, string? cursor, bool? withDefinitions = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinitions` = `false`
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`, `with_definitions` ← `withDefinitions`
- **Returns**: `ListCustomerCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerCustomAttributesResponse` | `Models/ListCustomerCustomAttributesResponse.cs` |

### RetrieveCustomerCustomAttribute

- **Signature**: `RetrieveCustomerCustomAttribute(string customerId, string key, int? version, bool? withDefinition = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinition` = `false`
- **Query params (wire ← C#)**: `with_definition` ← `withDefinition`, `version` ← `version`
- **Returns**: `RetrieveCustomerCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerCustomAttributeResponse` | `Models/RetrieveCustomerCustomAttributeResponse.cs` |

### RetrieveCustomerCustomAttributeDefinition

- **Signature**: `RetrieveCustomerCustomAttributeDefinition(string key, int? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `RetrieveCustomerCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerCustomAttributeDefinitionResponse` | `Models/RetrieveCustomerCustomAttributeDefinitionResponse.cs` |

### UpdateCustomerCustomAttributeDefinition

- **Signature**: `UpdateCustomerCustomAttributeDefinition(string key, UpdateCustomerCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateCustomerCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCustomerCustomAttributeDefinitionRequest` | `Models/UpdateCustomerCustomAttributeDefinitionRequest.cs` |
| `UpdateCustomerCustomAttributeDefinitionResponse` | `Models/UpdateCustomerCustomAttributeDefinitionResponse.cs` |

### UpsertCustomerCustomAttribute

- **Signature**: `UpsertCustomerCustomAttribute(string customerId, string key, UpsertCustomerCustomAttributeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpsertCustomerCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertCustomerCustomAttributeRequest` | `Models/UpsertCustomerCustomAttributeRequest.cs` |
| `UpsertCustomerCustomAttributeResponse` | `Models/UpsertCustomerCustomAttributeResponse.cs` |

