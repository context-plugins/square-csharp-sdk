<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerCustomAttributes — operations

Accessor: `client.CustomerCustomAttributes` · Source: `src/Square/Api/CustomerCustomAttributes.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkUpsertCustomerCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpsertCustomerCustomAttributes(BulkUpsertCustomerCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpsertCustomerCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpsertCustomerCustomAttributesOperationRequest` | `src/Square/Requests/CustomerCustomAttributes/BulkUpsertCustomerCustomAttributesOperationRequest.cs` |
| `BulkUpsertCustomerCustomAttributesRequest` | `src/Square/Models/BulkUpsertCustomerCustomAttributesRequest.cs` |
| `BulkUpsertCustomerCustomAttributesResponse` | `src/Square/Models/BulkUpsertCustomerCustomAttributesResponse.cs` |

### CreateCustomerCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCustomerCustomAttributeDefinition(CreateCustomerCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateCustomerCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/CustomerCustomAttributes/CreateCustomerCustomAttributeDefinitionOperationRequest.cs` |
| `CreateCustomerCustomAttributeDefinitionRequest` | `src/Square/Models/CreateCustomerCustomAttributeDefinitionRequest.cs` |
| `CreateCustomerCustomAttributeDefinitionResponse` | `src/Square/Models/CreateCustomerCustomAttributeDefinitionResponse.cs` |

### DeleteCustomerCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteCustomerCustomAttribute(DeleteCustomerCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`, `Key`
- **Returns**: `DeleteCustomerCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerCustomAttributeRequest` | `src/Square/Requests/CustomerCustomAttributes/DeleteCustomerCustomAttributeRequest.cs` |
| `DeleteCustomerCustomAttributeResponse` | `src/Square/Models/DeleteCustomerCustomAttributeResponse.cs` |

### DeleteCustomerCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteCustomerCustomAttributeDefinition(DeleteCustomerCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Returns**: `DeleteCustomerCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerCustomAttributeDefinitionRequest` | `src/Square/Requests/CustomerCustomAttributes/DeleteCustomerCustomAttributeDefinitionRequest.cs` |
| `DeleteCustomerCustomAttributeDefinitionResponse` | `src/Square/Models/DeleteCustomerCustomAttributeDefinitionResponse.cs` |

### ListCustomerCustomAttributeDefinitions

- **Auth**: `options.Oauth2`
- **Signature**: `ListCustomerCustomAttributeDefinitions(ListCustomerCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListCustomerCustomAttributeDefinitionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerCustomAttributeDefinitionsRequest` | `src/Square/Requests/CustomerCustomAttributes/ListCustomerCustomAttributeDefinitionsRequest.cs` |
| `ListCustomerCustomAttributeDefinitionsResponse` | `src/Square/Models/ListCustomerCustomAttributeDefinitionsResponse.cs` |

### ListCustomerCustomAttributes

- **Auth**: `options.Oauth2`
- **Signature**: `ListCustomerCustomAttributes(ListCustomerCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`, `with_definitions` ← `WithDefinitions`
- **Returns**: `ListCustomerCustomAttributesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerCustomAttributesRequest` | `src/Square/Requests/CustomerCustomAttributes/ListCustomerCustomAttributesRequest.cs` |
| `ListCustomerCustomAttributesResponse` | `src/Square/Models/ListCustomerCustomAttributesResponse.cs` |

### RetrieveCustomerCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveCustomerCustomAttribute(RetrieveCustomerCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`, `Key`
- **Query params (wire ← C#)**: `with_definition` ← `WithDefinition`, `version` ← `Version`
- **Returns**: `RetrieveCustomerCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerCustomAttributeRequest` | `src/Square/Requests/CustomerCustomAttributes/RetrieveCustomerCustomAttributeRequest.cs` |
| `RetrieveCustomerCustomAttributeResponse` | `src/Square/Models/RetrieveCustomerCustomAttributeResponse.cs` |

### RetrieveCustomerCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveCustomerCustomAttributeDefinition(RetrieveCustomerCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `RetrieveCustomerCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerCustomAttributeDefinitionRequest` | `src/Square/Requests/CustomerCustomAttributes/RetrieveCustomerCustomAttributeDefinitionRequest.cs` |
| `RetrieveCustomerCustomAttributeDefinitionResponse` | `src/Square/Models/RetrieveCustomerCustomAttributeDefinitionResponse.cs` |

### UpdateCustomerCustomAttributeDefinition

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateCustomerCustomAttributeDefinition(UpdateCustomerCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Key`, `Body`
- **Returns**: `UpdateCustomerCustomAttributeDefinitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCustomerCustomAttributeDefinitionOperationRequest` | `src/Square/Requests/CustomerCustomAttributes/UpdateCustomerCustomAttributeDefinitionOperationRequest.cs` |
| `UpdateCustomerCustomAttributeDefinitionRequest` | `src/Square/Models/UpdateCustomerCustomAttributeDefinitionRequest.cs` |
| `UpdateCustomerCustomAttributeDefinitionResponse` | `src/Square/Models/UpdateCustomerCustomAttributeDefinitionResponse.cs` |

### UpsertCustomerCustomAttribute

- **Auth**: `options.Oauth2`
- **Signature**: `UpsertCustomerCustomAttribute(UpsertCustomerCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`, `Key`, `Body`
- **Returns**: `UpsertCustomerCustomAttributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertCustomerCustomAttributeOperationRequest` | `src/Square/Requests/CustomerCustomAttributes/UpsertCustomerCustomAttributeOperationRequest.cs` |
| `UpsertCustomerCustomAttributeRequest` | `src/Square/Models/UpsertCustomerCustomAttributeRequest.cs` |
| `UpsertCustomerCustomAttributeResponse` | `src/Square/Models/UpsertCustomerCustomAttributeResponse.cs` |

