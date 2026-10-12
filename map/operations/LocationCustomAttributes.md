<!-- Generated file — do not edit; regenerated with the SDK. -->

# LocationCustomAttributes — operations

Accessor: `client.LocationCustomAttributes` · Source: `src/Square/Api/LocationCustomAttributes.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkDeleteLocationCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkDeleteLocationCustomAttributes(BulkDeleteLocationCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkDeleteLocationCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteLocationCustomAttributesOperationRequest` | `src/Square/Requests/LocationCustomAttributes/BulkDeleteLocationCustomAttributesOperationRequest.cs` |
| `BulkDeleteLocationCustomAttributesRequest` | `src/Square/Models/BulkDeleteLocationCustomAttributesRequest.cs` |
| `BulkDeleteLocationCustomAttributesResponse` | `src/Square/Models/BulkDeleteLocationCustomAttributesResponse.cs` |

### BulkUpsertLocationCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpsertLocationCustomAttributes(BulkUpsertLocationCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpsertLocationCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertLocationCustomAttributesOperationRequest` | `src/Square/Requests/LocationCustomAttributes/BulkUpsertLocationCustomAttributesOperationRequest.cs` |
| `BulkUpsertLocationCustomAttributesRequest` | `src/Square/Models/BulkUpsertLocationCustomAttributesRequest.cs` |
| `BulkUpsertLocationCustomAttributesResponse` | `src/Square/Models/BulkUpsertLocationCustomAttributesResponse.cs` |

### CreateLocationCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLocationCustomAttributeDefinition(CreateLocationCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateLocationCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLocationCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/LocationCustomAttributes/CreateLocationCustomAttributeDefinitionOperationRequest.cs` |
| `CreateLocationCustomAttributeDefinitionRequest` | `src/Square/Models/CreateLocationCustomAttributeDefinitionRequest.cs` |
| `CreateLocationCustomAttributeDefinitionResponse` | `src/Square/Models/CreateLocationCustomAttributeDefinitionResponse.cs` |

### DeleteLocationCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteLocationCustomAttribute(DeleteLocationCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `Key`
- **Returns**: `DeleteLocationCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteLocationCustomAttributeRequest` | `src/Square/Requests/LocationCustomAttributes/DeleteLocationCustomAttributeRequest.cs` |
| `DeleteLocationCustomAttributeResponse` | `src/Square/Models/DeleteLocationCustomAttributeResponse.cs` |

### DeleteLocationCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteLocationCustomAttributeDefinition(DeleteLocationCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Returns**: `DeleteLocationCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteLocationCustomAttributeDefinitionRequest` | `src/Square/Requests/LocationCustomAttributes/DeleteLocationCustomAttributeDefinitionRequest.cs` |
| `DeleteLocationCustomAttributeDefinitionResponse` | `src/Square/Models/DeleteLocationCustomAttributeDefinitionResponse.cs` |

### ListLocationCustomAttributeDefinitions

- **Auth**: `options.Oauth2`
- **Signature**: `ListLocationCustomAttributeDefinitions(ListLocationCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `visibility_filter` ← `VisibilityFilter`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListLocationCustomAttributeDefinitionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLocationCustomAttributeDefinitionsRequest` | `src/Square/Requests/LocationCustomAttributes/ListLocationCustomAttributeDefinitionsRequest.cs` |
| `VisibilityFilter` | `src/Square/Models/Enums/VisibilityFilter.cs` |
| `ListLocationCustomAttributeDefinitionsResponse` | `src/Square/Models/ListLocationCustomAttributeDefinitionsResponse.cs` |

### ListLocationCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `ListLocationCustomAttributes(ListLocationCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Query params (wire ← C#)**: `visibility_filter` ← `VisibilityFilter`, `limit` ← `Limit`, `cursor` ← `Cursor`, `with_definitions` ← `WithDefinitions`
- **Returns**: `ListLocationCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLocationCustomAttributesRequest` | `src/Square/Requests/LocationCustomAttributes/ListLocationCustomAttributesRequest.cs` |
| `VisibilityFilter` | `src/Square/Models/Enums/VisibilityFilter.cs` |
| `ListLocationCustomAttributesResponse` | `src/Square/Models/ListLocationCustomAttributesResponse.cs` |

### RetrieveLocationCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLocationCustomAttribute(RetrieveLocationCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `Key`
- **Query params (wire ← C#)**: `with_definition` ← `WithDefinition`, `version` ← `Version`
- **Returns**: `RetrieveLocationCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationCustomAttributeRequest` | `src/Square/Requests/LocationCustomAttributes/RetrieveLocationCustomAttributeRequest.cs` |
| `RetrieveLocationCustomAttributeResponse` | `src/Square/Models/RetrieveLocationCustomAttributeResponse.cs` |

### RetrieveLocationCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLocationCustomAttributeDefinition(RetrieveLocationCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `RetrieveLocationCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationCustomAttributeDefinitionRequest` | `src/Square/Requests/LocationCustomAttributes/RetrieveLocationCustomAttributeDefinitionRequest.cs` |
| `RetrieveLocationCustomAttributeDefinitionResponse` | `src/Square/Models/RetrieveLocationCustomAttributeDefinitionResponse.cs` |

### UpdateLocationCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateLocationCustomAttributeDefinition(UpdateLocationCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`, `Body`
- **Returns**: `UpdateLocationCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateLocationCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/LocationCustomAttributes/UpdateLocationCustomAttributeDefinitionOperationRequest.cs` |
| `UpdateLocationCustomAttributeDefinitionRequest` | `src/Square/Models/UpdateLocationCustomAttributeDefinitionRequest.cs` |
| `UpdateLocationCustomAttributeDefinitionResponse` | `src/Square/Models/UpdateLocationCustomAttributeDefinitionResponse.cs` |

### UpsertLocationCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `UpsertLocationCustomAttribute(UpsertLocationCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `Key`, `Body`
- **Returns**: `UpsertLocationCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertLocationCustomAttributeOperationRequest` | `src/Square/Requests/LocationCustomAttributes/UpsertLocationCustomAttributeOperationRequest.cs` |
| `UpsertLocationCustomAttributeRequest` | `src/Square/Models/UpsertLocationCustomAttributeRequest.cs` |
| `UpsertLocationCustomAttributeResponse` | `src/Square/Models/UpsertLocationCustomAttributeResponse.cs` |

