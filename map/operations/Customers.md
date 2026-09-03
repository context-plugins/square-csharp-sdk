<!-- Generated file — do not edit; regenerated with the SDK. -->

# Customers — operations

Accessor: `client.Customers` · Source: `Api/Customers.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddGroupToCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `AddGroupToCustomer(string customerId, string groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AddGroupToCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddGroupToCustomerResponse` | `Models/AddGroupToCustomerResponse.cs` |

### BulkCreateCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkCreateCustomers(BulkCreateCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkCreateCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkCreateCustomersRequest` | `Models/BulkCreateCustomersRequest.cs` |
| `BulkCreateCustomersResponse` | `Models/BulkCreateCustomersResponse.cs` |

### BulkDeleteCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkDeleteCustomers(BulkDeleteCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkDeleteCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteCustomersRequest` | `Models/BulkDeleteCustomersRequest.cs` |
| `BulkDeleteCustomersResponse` | `Models/BulkDeleteCustomersResponse.cs` |

### BulkRetrieveCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkRetrieveCustomers(BulkRetrieveCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkRetrieveCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveCustomersRequest` | `Models/BulkRetrieveCustomersRequest.cs` |
| `BulkRetrieveCustomersResponse` | `Models/BulkRetrieveCustomersResponse.cs` |

### BulkUpdateCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpdateCustomers(BulkUpdateCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkUpdateCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpdateCustomersRequest` | `Models/BulkUpdateCustomersRequest.cs` |
| `BulkUpdateCustomersResponse` | `Models/BulkUpdateCustomersResponse.cs` |

### CreateCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCustomer(CreateCustomerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerRequest` | `Models/CreateCustomerRequest.cs` |
| `CreateCustomerResponse` | `Models/CreateCustomerResponse.cs` |

### CreateCustomerCard

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCustomerCard(string customerId, CreateCustomerCardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateCustomerCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerCardRequest` | `Models/CreateCustomerCardRequest.cs` |
| `CreateCustomerCardResponse` | `Models/CreateCustomerCardResponse.cs` |

### DeleteCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteCustomer(string customerId, long? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `DeleteCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerResponse` | `Models/DeleteCustomerResponse.cs` |

### DeleteCustomerCard

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteCustomerCard(string customerId, string cardId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteCustomerCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerCardResponse` | `Models/DeleteCustomerCardResponse.cs` |

### ListCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `ListCustomers(string? cursor, int? limit, CustomerSortField? sortField, SortOrder? sortOrder, bool? count = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`cursor` … `sortOrder`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `count` = `false`
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`, `sort_field` ← `sortField`, `sort_order` ← `sortOrder`, `count` ← `count`
- **Returns**: `ListCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CustomerSortField` | `Models/Enums/CustomerSortField.cs` |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `ListCustomersResponse` | `Models/ListCustomersResponse.cs` |

### RemoveGroupFromCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `RemoveGroupFromCustomer(string customerId, string groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RemoveGroupFromCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveGroupFromCustomerResponse` | `Models/RemoveGroupFromCustomerResponse.cs` |

### RetrieveCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveCustomer(string customerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerResponse` | `Models/RetrieveCustomerResponse.cs` |

### SearchCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `SearchCustomers(SearchCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchCustomersRequest` | `Models/SearchCustomersRequest.cs` |
| `SearchCustomersResponse` | `Models/SearchCustomersResponse.cs` |

### UpdateCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateCustomer(string customerId, UpdateCustomerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCustomerRequest` | `Models/UpdateCustomerRequest.cs` |
| `UpdateCustomerResponse` | `Models/UpdateCustomerResponse.cs` |

