<!-- Generated file — do not edit; regenerated with the SDK. -->

# BookingCustomAttributes — operations

Accessor: `client.BookingCustomAttributes` · Source: `src/Square/Api/BookingCustomAttributes.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkDeleteBookingCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkDeleteBookingCustomAttributes(BulkDeleteBookingCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkDeleteBookingCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteBookingCustomAttributesOperationRequest` | `src/Square/Requests/BookingCustomAttributes/BulkDeleteBookingCustomAttributesOperationRequest.cs` |
| `BulkDeleteBookingCustomAttributesRequest` | `src/Square/Models/BulkDeleteBookingCustomAttributesRequest.cs` |
| `BulkDeleteBookingCustomAttributesResponse` | `src/Square/Models/BulkDeleteBookingCustomAttributesResponse.cs` |

### BulkUpsertBookingCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpsertBookingCustomAttributes(BulkUpsertBookingCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpsertBookingCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertBookingCustomAttributesOperationRequest` | `src/Square/Requests/BookingCustomAttributes/BulkUpsertBookingCustomAttributesOperationRequest.cs` |
| `BulkUpsertBookingCustomAttributesRequest` | `src/Square/Models/BulkUpsertBookingCustomAttributesRequest.cs` |
| `BulkUpsertBookingCustomAttributesResponse` | `src/Square/Models/BulkUpsertBookingCustomAttributesResponse.cs` |

### CreateBookingCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `CreateBookingCustomAttributeDefinition(CreateBookingCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateBookingCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBookingCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/BookingCustomAttributes/CreateBookingCustomAttributeDefinitionOperationRequest.cs` |
| `CreateBookingCustomAttributeDefinitionRequest` | `src/Square/Models/CreateBookingCustomAttributeDefinitionRequest.cs` |
| `CreateBookingCustomAttributeDefinitionResponse` | `src/Square/Models/CreateBookingCustomAttributeDefinitionResponse.cs` |

### DeleteBookingCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteBookingCustomAttribute(DeleteBookingCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BookingId`, `Key`
- **Returns**: `DeleteBookingCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteBookingCustomAttributeRequest` | `src/Square/Requests/BookingCustomAttributes/DeleteBookingCustomAttributeRequest.cs` |
| `DeleteBookingCustomAttributeResponse` | `src/Square/Models/DeleteBookingCustomAttributeResponse.cs` |

### DeleteBookingCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteBookingCustomAttributeDefinition(DeleteBookingCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Returns**: `DeleteBookingCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteBookingCustomAttributeDefinitionRequest` | `src/Square/Requests/BookingCustomAttributes/DeleteBookingCustomAttributeDefinitionRequest.cs` |
| `DeleteBookingCustomAttributeDefinitionResponse` | `src/Square/Models/DeleteBookingCustomAttributeDefinitionResponse.cs` |

### ListBookingCustomAttributeDefinitions

- **Auth**: `options.Oauth2`
- **Signature**: `ListBookingCustomAttributeDefinitions(ListBookingCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListBookingCustomAttributeDefinitionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBookingCustomAttributeDefinitionsRequest` | `src/Square/Requests/BookingCustomAttributes/ListBookingCustomAttributeDefinitionsRequest.cs` |
| `ListBookingCustomAttributeDefinitionsResponse` | `src/Square/Models/ListBookingCustomAttributeDefinitionsResponse.cs` |

### ListBookingCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `ListBookingCustomAttributes(ListBookingCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BookingId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`, `with_definitions` ← `WithDefinitions`
- **Returns**: `ListBookingCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBookingCustomAttributesRequest` | `src/Square/Requests/BookingCustomAttributes/ListBookingCustomAttributesRequest.cs` |
| `ListBookingCustomAttributesResponse` | `src/Square/Models/ListBookingCustomAttributesResponse.cs` |

### RetrieveBookingCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveBookingCustomAttribute(RetrieveBookingCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BookingId`, `Key`
- **Query params (wire ← C#)**: `with_definition` ← `WithDefinition`, `version` ← `Version`
- **Returns**: `RetrieveBookingCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveBookingCustomAttributeRequest` | `src/Square/Requests/BookingCustomAttributes/RetrieveBookingCustomAttributeRequest.cs` |
| `RetrieveBookingCustomAttributeResponse` | `src/Square/Models/RetrieveBookingCustomAttributeResponse.cs` |

### RetrieveBookingCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveBookingCustomAttributeDefinition(RetrieveBookingCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `RetrieveBookingCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveBookingCustomAttributeDefinitionRequest` | `src/Square/Requests/BookingCustomAttributes/RetrieveBookingCustomAttributeDefinitionRequest.cs` |
| `RetrieveBookingCustomAttributeDefinitionResponse` | `src/Square/Models/RetrieveBookingCustomAttributeDefinitionResponse.cs` |

### UpdateBookingCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateBookingCustomAttributeDefinition(UpdateBookingCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`, `Body`
- **Returns**: `UpdateBookingCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateBookingCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/BookingCustomAttributes/UpdateBookingCustomAttributeDefinitionOperationRequest.cs` |
| `UpdateBookingCustomAttributeDefinitionRequest` | `src/Square/Models/UpdateBookingCustomAttributeDefinitionRequest.cs` |
| `UpdateBookingCustomAttributeDefinitionResponse` | `src/Square/Models/UpdateBookingCustomAttributeDefinitionResponse.cs` |

### UpsertBookingCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `UpsertBookingCustomAttribute(UpsertBookingCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BookingId`, `Key`, `Body`
- **Returns**: `UpsertBookingCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertBookingCustomAttributeOperationRequest` | `src/Square/Requests/BookingCustomAttributes/UpsertBookingCustomAttributeOperationRequest.cs` |
| `UpsertBookingCustomAttributeRequest` | `src/Square/Models/UpsertBookingCustomAttributeRequest.cs` |
| `UpsertBookingCustomAttributeResponse` | `src/Square/Models/UpsertBookingCustomAttributeResponse.cs` |

