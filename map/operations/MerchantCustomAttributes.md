<!-- Generated file — do not edit; regenerated with the SDK. -->

# MerchantCustomAttributes — operations

Accessor: `client.MerchantCustomAttributes` · Source: `src/Square/Api/MerchantCustomAttributes.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkDeleteMerchantCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkDeleteMerchantCustomAttributes(BulkDeleteMerchantCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkDeleteMerchantCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteMerchantCustomAttributesOperationRequest` | `src/Square/Requests/MerchantCustomAttributes/BulkDeleteMerchantCustomAttributesOperationRequest.cs` |
| `BulkDeleteMerchantCustomAttributesRequest` | `src/Square/Models/BulkDeleteMerchantCustomAttributesRequest.cs` |
| `BulkDeleteMerchantCustomAttributesResponse` | `src/Square/Models/BulkDeleteMerchantCustomAttributesResponse.cs` |

### BulkUpsertMerchantCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpsertMerchantCustomAttributes(BulkUpsertMerchantCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpsertMerchantCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertMerchantCustomAttributesOperationRequest` | `src/Square/Requests/MerchantCustomAttributes/BulkUpsertMerchantCustomAttributesOperationRequest.cs` |
| `BulkUpsertMerchantCustomAttributesRequest` | `src/Square/Models/BulkUpsertMerchantCustomAttributesRequest.cs` |
| `BulkUpsertMerchantCustomAttributesResponse` | `src/Square/Models/BulkUpsertMerchantCustomAttributesResponse.cs` |

### CreateMerchantCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `CreateMerchantCustomAttributeDefinition(CreateMerchantCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateMerchantCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateMerchantCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/MerchantCustomAttributes/CreateMerchantCustomAttributeDefinitionOperationRequest.cs` |
| `CreateMerchantCustomAttributeDefinitionRequest` | `src/Square/Models/CreateMerchantCustomAttributeDefinitionRequest.cs` |
| `CreateMerchantCustomAttributeDefinitionResponse` | `src/Square/Models/CreateMerchantCustomAttributeDefinitionResponse.cs` |

### DeleteMerchantCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteMerchantCustomAttribute(DeleteMerchantCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Key`
- **Returns**: `DeleteMerchantCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteMerchantCustomAttributeRequest` | `src/Square/Requests/MerchantCustomAttributes/DeleteMerchantCustomAttributeRequest.cs` |
| `DeleteMerchantCustomAttributeResponse` | `src/Square/Models/DeleteMerchantCustomAttributeResponse.cs` |

### DeleteMerchantCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteMerchantCustomAttributeDefinition(DeleteMerchantCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Returns**: `DeleteMerchantCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteMerchantCustomAttributeDefinitionRequest` | `src/Square/Requests/MerchantCustomAttributes/DeleteMerchantCustomAttributeDefinitionRequest.cs` |
| `DeleteMerchantCustomAttributeDefinitionResponse` | `src/Square/Models/DeleteMerchantCustomAttributeDefinitionResponse.cs` |

### ListMerchantCustomAttributeDefinitions

- **Auth**: `options.Oauth2`
- **Signature**: `ListMerchantCustomAttributeDefinitions(ListMerchantCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `visibility_filter` ← `VisibilityFilter`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListMerchantCustomAttributeDefinitionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMerchantCustomAttributeDefinitionsRequest` | `src/Square/Requests/MerchantCustomAttributes/ListMerchantCustomAttributeDefinitionsRequest.cs` |
| `VisibilityFilter` | `src/Square/Models/Enums/VisibilityFilter.cs` |
| `ListMerchantCustomAttributeDefinitionsResponse` | `src/Square/Models/ListMerchantCustomAttributeDefinitionsResponse.cs` |

### ListMerchantCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `ListMerchantCustomAttributes(ListMerchantCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `visibility_filter` ← `VisibilityFilter`, `limit` ← `Limit`, `cursor` ← `Cursor`, `with_definitions` ← `WithDefinitions`
- **Returns**: `ListMerchantCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMerchantCustomAttributesRequest` | `src/Square/Requests/MerchantCustomAttributes/ListMerchantCustomAttributesRequest.cs` |
| `VisibilityFilter` | `src/Square/Models/Enums/VisibilityFilter.cs` |
| `ListMerchantCustomAttributesResponse` | `src/Square/Models/ListMerchantCustomAttributesResponse.cs` |

### RetrieveMerchantCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveMerchantCustomAttribute(RetrieveMerchantCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Key`
- **Query params (wire ← C#)**: `with_definition` ← `WithDefinition`, `version` ← `Version`
- **Returns**: `RetrieveMerchantCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveMerchantCustomAttributeRequest` | `src/Square/Requests/MerchantCustomAttributes/RetrieveMerchantCustomAttributeRequest.cs` |
| `RetrieveMerchantCustomAttributeResponse` | `src/Square/Models/RetrieveMerchantCustomAttributeResponse.cs` |

### RetrieveMerchantCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveMerchantCustomAttributeDefinition(RetrieveMerchantCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `RetrieveMerchantCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveMerchantCustomAttributeDefinitionRequest` | `src/Square/Requests/MerchantCustomAttributes/RetrieveMerchantCustomAttributeDefinitionRequest.cs` |
| `RetrieveMerchantCustomAttributeDefinitionResponse` | `src/Square/Models/RetrieveMerchantCustomAttributeDefinitionResponse.cs` |

### UpdateMerchantCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateMerchantCustomAttributeDefinition(UpdateMerchantCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`, `Body`
- **Returns**: `UpdateMerchantCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateMerchantCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/MerchantCustomAttributes/UpdateMerchantCustomAttributeDefinitionOperationRequest.cs` |
| `UpdateMerchantCustomAttributeDefinitionRequest` | `src/Square/Models/UpdateMerchantCustomAttributeDefinitionRequest.cs` |
| `UpdateMerchantCustomAttributeDefinitionResponse` | `src/Square/Models/UpdateMerchantCustomAttributeDefinitionResponse.cs` |

### UpsertMerchantCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `UpsertMerchantCustomAttribute(UpsertMerchantCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Key`, `Body`
- **Returns**: `UpsertMerchantCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertMerchantCustomAttributeOperationRequest` | `src/Square/Requests/MerchantCustomAttributes/UpsertMerchantCustomAttributeOperationRequest.cs` |
| `UpsertMerchantCustomAttributeRequest` | `src/Square/Models/UpsertMerchantCustomAttributeRequest.cs` |
| `UpsertMerchantCustomAttributeResponse` | `src/Square/Models/UpsertMerchantCustomAttributeResponse.cs` |

