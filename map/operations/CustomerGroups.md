<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerGroups — operations

Accessor: `client.CustomerGroups` · Source: `src/Square/Api/CustomerGroups.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCustomerGroup

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCustomerGroup(CreateCustomerGroupOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateCustomerGroupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerGroupOperationRequest` | `src/Square/Requests/CustomerGroups/CreateCustomerGroupOperationRequest.cs` |
| `CreateCustomerGroupRequest` | `src/Square/Models/CreateCustomerGroupRequest.cs` |
| `CreateCustomerGroupResponse` | `src/Square/Models/CreateCustomerGroupResponse.cs` |

### DeleteCustomerGroup

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteCustomerGroup(DeleteCustomerGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GroupId`
- **Returns**: `DeleteCustomerGroupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerGroupRequest` | `src/Square/Requests/CustomerGroups/DeleteCustomerGroupRequest.cs` |
| `DeleteCustomerGroupResponse` | `src/Square/Models/DeleteCustomerGroupResponse.cs` |

### ListCustomerGroups

- **Auth**: `options.Oauth2`
- **Signature**: `ListCustomerGroups(ListCustomerGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListCustomerGroupsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerGroupsRequest` | `src/Square/Requests/CustomerGroups/ListCustomerGroupsRequest.cs` |
| `ListCustomerGroupsResponse` | `src/Square/Models/ListCustomerGroupsResponse.cs` |

### RetrieveCustomerGroup

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveCustomerGroup(RetrieveCustomerGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GroupId`
- **Returns**: `RetrieveCustomerGroupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerGroupRequest` | `src/Square/Requests/CustomerGroups/RetrieveCustomerGroupRequest.cs` |
| `RetrieveCustomerGroupResponse` | `src/Square/Models/RetrieveCustomerGroupResponse.cs` |

### UpdateCustomerGroup

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateCustomerGroup(UpdateCustomerGroupOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GroupId`, `Body`
- **Returns**: `UpdateCustomerGroupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCustomerGroupOperationRequest` | `src/Square/Requests/CustomerGroups/UpdateCustomerGroupOperationRequest.cs` |
| `UpdateCustomerGroupRequest` | `src/Square/Models/UpdateCustomerGroupRequest.cs` |
| `UpdateCustomerGroupResponse` | `src/Square/Models/UpdateCustomerGroupResponse.cs` |

