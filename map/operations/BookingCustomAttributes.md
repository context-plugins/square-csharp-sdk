<!-- Generated file — do not edit; regenerated with the SDK. -->

# BookingCustomAttributes — operations

Accessor: `client.BookingCustomAttributes` · Source: `Api/BookingCustomAttributes.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkDeleteBookingCustomAttributes

- **Signature**: `BulkDeleteBookingCustomAttributes(BulkDeleteBookingCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkDeleteBookingCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteBookingCustomAttributesRequest` | `Models/BulkDeleteBookingCustomAttributesRequest.cs` |
| `BulkDeleteBookingCustomAttributesResponse` | `Models/BulkDeleteBookingCustomAttributesResponse.cs` |

### BulkUpsertBookingCustomAttributes

- **Signature**: `BulkUpsertBookingCustomAttributes(BulkUpsertBookingCustomAttributesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkUpsertBookingCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertBookingCustomAttributesRequest` | `Models/BulkUpsertBookingCustomAttributesRequest.cs` |
| `BulkUpsertBookingCustomAttributesResponse` | `Models/BulkUpsertBookingCustomAttributesResponse.cs` |

### CreateBookingCustomAttributeDefinition

- **Signature**: `CreateBookingCustomAttributeDefinition(CreateBookingCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateBookingCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBookingCustomAttributeDefinitionRequest` | `Models/CreateBookingCustomAttributeDefinitionRequest.cs` |
| `CreateBookingCustomAttributeDefinitionResponse` | `Models/CreateBookingCustomAttributeDefinitionResponse.cs` |

### DeleteBookingCustomAttribute

- **Signature**: `DeleteBookingCustomAttribute(string bookingId, string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteBookingCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteBookingCustomAttributeResponse` | `Models/DeleteBookingCustomAttributeResponse.cs` |

### DeleteBookingCustomAttributeDefinition

- **Signature**: `DeleteBookingCustomAttributeDefinition(string key, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteBookingCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteBookingCustomAttributeDefinitionResponse` | `Models/DeleteBookingCustomAttributeDefinitionResponse.cs` |

### ListBookingCustomAttributeDefinitions

- **Signature**: `ListBookingCustomAttributeDefinitions(int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListBookingCustomAttributeDefinitionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBookingCustomAttributeDefinitionsResponse` | `Models/ListBookingCustomAttributeDefinitionsResponse.cs` |

### ListBookingCustomAttributes

- **Signature**: `ListBookingCustomAttributes(string bookingId, int? limit, string? cursor, bool? withDefinitions = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinitions` = `false`
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`, `with_definitions` ← `withDefinitions`
- **Returns**: `ListBookingCustomAttributesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBookingCustomAttributesResponse` | `Models/ListBookingCustomAttributesResponse.cs` |

### RetrieveBookingCustomAttribute

- **Signature**: `RetrieveBookingCustomAttribute(string bookingId, string key, int? version, bool? withDefinition = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
  - defaults: `withDefinition` = `false`
- **Query params (wire ← C#)**: `with_definition` ← `withDefinition`, `version` ← `version`
- **Returns**: `RetrieveBookingCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveBookingCustomAttributeResponse` | `Models/RetrieveBookingCustomAttributeResponse.cs` |

### RetrieveBookingCustomAttributeDefinition

- **Signature**: `RetrieveBookingCustomAttributeDefinition(string key, int? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `RetrieveBookingCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveBookingCustomAttributeDefinitionResponse` | `Models/RetrieveBookingCustomAttributeDefinitionResponse.cs` |

### UpdateBookingCustomAttributeDefinition

- **Signature**: `UpdateBookingCustomAttributeDefinition(string key, UpdateBookingCustomAttributeDefinitionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateBookingCustomAttributeDefinitionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateBookingCustomAttributeDefinitionRequest` | `Models/UpdateBookingCustomAttributeDefinitionRequest.cs` |
| `UpdateBookingCustomAttributeDefinitionResponse` | `Models/UpdateBookingCustomAttributeDefinitionResponse.cs` |

### UpsertBookingCustomAttribute

- **Signature**: `UpsertBookingCustomAttribute(string bookingId, string key, UpsertBookingCustomAttributeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpsertBookingCustomAttributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertBookingCustomAttributeRequest` | `Models/UpsertBookingCustomAttributeRequest.cs` |
| `UpsertBookingCustomAttributeResponse` | `Models/UpsertBookingCustomAttributeResponse.cs` |

