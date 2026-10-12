<!-- Generated file — do not edit; regenerated with the SDK. -->

# Customers — operations

Accessor: `client.Customers` · Source: `src/Square/Api/Customers.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddGroupToCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `AddGroupToCustomer(AddGroupToCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`, `GroupId`
- **Returns**: `AddGroupToCustomerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddGroupToCustomerRequest` | `src/Square/Requests/Customers/AddGroupToCustomerRequest.cs` |
| `AddGroupToCustomerResponse` | `src/Square/Models/AddGroupToCustomerResponse.cs` |

### BulkCreateCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkCreateCustomers(BulkCreateCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkCreateCustomersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkCreateCustomersOperationRequest` | `src/Square/Requests/Customers/BulkCreateCustomersOperationRequest.cs` |
| `BulkCreateCustomersRequest` | `src/Square/Models/BulkCreateCustomersRequest.cs` |
| `BulkCreateCustomersResponse` | `src/Square/Models/BulkCreateCustomersResponse.cs` |

### BulkDeleteCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkDeleteCustomers(BulkDeleteCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkDeleteCustomersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkDeleteCustomersOperationRequest` | `src/Square/Requests/Customers/BulkDeleteCustomersOperationRequest.cs` |
| `BulkDeleteCustomersRequest` | `src/Square/Models/BulkDeleteCustomersRequest.cs` |
| `BulkDeleteCustomersResponse` | `src/Square/Models/BulkDeleteCustomersResponse.cs` |

### BulkRetrieveCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkRetrieveCustomers(BulkRetrieveCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkRetrieveCustomersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveCustomersOperationRequest` | `src/Square/Requests/Customers/BulkRetrieveCustomersOperationRequest.cs` |
| `BulkRetrieveCustomersRequest` | `src/Square/Models/BulkRetrieveCustomersRequest.cs` |
| `BulkRetrieveCustomersResponse` | `src/Square/Models/BulkRetrieveCustomersResponse.cs` |

### BulkUpdateCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpdateCustomers(BulkUpdateCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpdateCustomersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpdateCustomersOperationRequest` | `src/Square/Requests/Customers/BulkUpdateCustomersOperationRequest.cs` |
| `BulkUpdateCustomersRequest` | `src/Square/Models/BulkUpdateCustomersRequest.cs` |
| `BulkUpdateCustomersResponse` | `src/Square/Models/BulkUpdateCustomersResponse.cs` |

### CreateCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCustomer(CreateCustomerOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateCustomerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerOperationRequest` | `src/Square/Requests/Customers/CreateCustomerOperationRequest.cs` |
| `CreateCustomerRequest` | `src/Square/Models/CreateCustomerRequest.cs` |
| `CreateCustomerResponse` | `src/Square/Models/CreateCustomerResponse.cs` |

### CreateCustomerCard

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCustomerCard(CreateCustomerCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`, `Body`
- **Returns**: `CreateCustomerCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCustomerCardOperationRequest` | `src/Square/Requests/Customers/CreateCustomerCardOperationRequest.cs` |
| `CreateCustomerCardRequest` | `src/Square/Models/CreateCustomerCardRequest.cs` |
| `CreateCustomerCardResponse` | `src/Square/Models/CreateCustomerCardResponse.cs` |

### DeleteCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteCustomer(DeleteCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `DeleteCustomerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerRequest` | `src/Square/Requests/Customers/DeleteCustomerRequest.cs` |
| `DeleteCustomerResponse` | `src/Square/Models/DeleteCustomerResponse.cs` |

### DeleteCustomerCard

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteCustomerCard(DeleteCustomerCardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`, `CardId`
- **Returns**: `DeleteCustomerCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerCardRequest` | `src/Square/Requests/Customers/DeleteCustomerCardRequest.cs` |
| `DeleteCustomerCardResponse` | `src/Square/Models/DeleteCustomerCardResponse.cs` |

### ListCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `ListCustomers(ListCustomersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `limit` ← `Limit`, `sort_field` ← `SortField`, `sort_order` ← `SortOrder`, `count` ← `Count`
- **Returns**: `ListCustomersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomersRequest` | `src/Square/Requests/Customers/ListCustomersRequest.cs` |
| `CustomerSortField` | `src/Square/Models/Enums/CustomerSortField.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListCustomersResponse` | `src/Square/Models/ListCustomersResponse.cs` |

### RemoveGroupFromCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `RemoveGroupFromCustomer(RemoveGroupFromCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`, `GroupId`
- **Returns**: `RemoveGroupFromCustomerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveGroupFromCustomerRequest` | `src/Square/Requests/Customers/RemoveGroupFromCustomerRequest.cs` |
| `RemoveGroupFromCustomerResponse` | `src/Square/Models/RemoveGroupFromCustomerResponse.cs` |

### RetrieveCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveCustomer(RetrieveCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Returns**: `RetrieveCustomerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerRequest` | `src/Square/Requests/Customers/RetrieveCustomerRequest.cs` |
| `RetrieveCustomerResponse` | `src/Square/Models/RetrieveCustomerResponse.cs` |

### SearchCustomers

- **Auth**: `options.Oauth2`
- **Signature**: `SearchCustomers(SearchCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchCustomersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchCustomersOperationRequest` | `src/Square/Requests/Customers/SearchCustomersOperationRequest.cs` |
| `SearchCustomersRequest` | `src/Square/Models/SearchCustomersRequest.cs` |
| `SearchCustomersResponse` | `src/Square/Models/SearchCustomersResponse.cs` |

### UpdateCustomer

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateCustomer(UpdateCustomerOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`, `Body`
- **Returns**: `UpdateCustomerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCustomerOperationRequest` | `src/Square/Requests/Customers/UpdateCustomerOperationRequest.cs` |
| `UpdateCustomerRequest` | `src/Square/Models/UpdateCustomerRequest.cs` |
| `UpdateCustomerResponse` | `src/Square/Models/UpdateCustomerResponse.cs` |

