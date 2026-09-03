<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerGroups — operations

Accessor: `client.CustomerGroups` · Source: `Api/CustomerGroups.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCustomerGroup

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCustomerGroup(CreateCustomerGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateCustomerGroupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerGroupRequest` | `Models/CreateCustomerGroupRequest.cs` |
| `CreateCustomerGroupResponse` | `Models/CreateCustomerGroupResponse.cs` |

### DeleteCustomerGroup

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteCustomerGroup(string groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteCustomerGroupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerGroupResponse` | `Models/DeleteCustomerGroupResponse.cs` |

### ListCustomerGroups

- **Auth**: `options.Oauth2`
- **Signature**: `ListCustomerGroups(string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListCustomerGroupsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerGroupsResponse` | `Models/ListCustomerGroupsResponse.cs` |

### RetrieveCustomerGroup

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveCustomerGroup(string groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveCustomerGroupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerGroupResponse` | `Models/RetrieveCustomerGroupResponse.cs` |

### UpdateCustomerGroup

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateCustomerGroup(string groupId, UpdateCustomerGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateCustomerGroupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCustomerGroupRequest` | `Models/UpdateCustomerGroupRequest.cs` |
| `UpdateCustomerGroupResponse` | `Models/UpdateCustomerGroupResponse.cs` |

