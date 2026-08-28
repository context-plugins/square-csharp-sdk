<!-- Generated file — do not edit; regenerated with the SDK. -->

# Customers — operations

Accessor: `client.Customers` · Source: `Api/Customers.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddGroupToCustomer

- **Signature**: `AddGroupToCustomer(string customerId, string groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AddGroupToCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddGroupToCustomerResponse` | `Models/AddGroupToCustomerResponse.cs` |

### BulkCreateCustomers

- **Signature**: `BulkCreateCustomers(BulkCreateCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkCreateCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkCreateCustomersRequest` | `Models/BulkCreateCustomersRequest.cs` |
| `BulkCreateCustomersResponse` | `Models/BulkCreateCustomersResponse.cs` |

### BulkDeleteCustomers

- **Signature**: `BulkDeleteCustomers(BulkDeleteCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkDeleteCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteCustomersRequest` | `Models/BulkDeleteCustomersRequest.cs` |
| `BulkDeleteCustomersResponse` | `Models/BulkDeleteCustomersResponse.cs` |

### BulkRetrieveCustomers

- **Signature**: `BulkRetrieveCustomers(BulkRetrieveCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkRetrieveCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveCustomersRequest` | `Models/BulkRetrieveCustomersRequest.cs` |
| `BulkRetrieveCustomersResponse` | `Models/BulkRetrieveCustomersResponse.cs` |

### BulkUpdateCustomers

- **Signature**: `BulkUpdateCustomers(BulkUpdateCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkUpdateCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpdateCustomersRequest` | `Models/BulkUpdateCustomersRequest.cs` |
| `BulkUpdateCustomersResponse` | `Models/BulkUpdateCustomersResponse.cs` |

### CreateCustomer

- **Signature**: `CreateCustomer(CreateCustomerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerRequest` | `Models/CreateCustomerRequest.cs` |
| `CreateCustomerResponse` | `Models/CreateCustomerResponse.cs` |

### CreateCustomerCard

- **Signature**: `CreateCustomerCard(string customerId, CreateCustomerCardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateCustomerCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerCardRequest` | `Models/CreateCustomerCardRequest.cs` |
| `CreateCustomerCardResponse` | `Models/CreateCustomerCardResponse.cs` |

### DeleteCustomer

- **Signature**: `DeleteCustomer(string customerId, long? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `DeleteCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerResponse` | `Models/DeleteCustomerResponse.cs` |

### DeleteCustomerCard

- **Signature**: `DeleteCustomerCard(string customerId, string cardId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteCustomerCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerCardResponse` | `Models/DeleteCustomerCardResponse.cs` |

### ListCustomers

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

- **Signature**: `RemoveGroupFromCustomer(string customerId, string groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RemoveGroupFromCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveGroupFromCustomerResponse` | `Models/RemoveGroupFromCustomerResponse.cs` |

### RetrieveCustomer

- **Signature**: `RetrieveCustomer(string customerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerResponse` | `Models/RetrieveCustomerResponse.cs` |

### SearchCustomers

- **Signature**: `SearchCustomers(SearchCustomersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchCustomersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchCustomersRequest` | `Models/SearchCustomersRequest.cs` |
| `SearchCustomersResponse` | `Models/SearchCustomersResponse.cs` |

### UpdateCustomer

- **Signature**: `UpdateCustomer(string customerId, UpdateCustomerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateCustomerResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCustomerRequest` | `Models/UpdateCustomerRequest.cs` |
| `UpdateCustomerResponse` | `Models/UpdateCustomerResponse.cs` |

