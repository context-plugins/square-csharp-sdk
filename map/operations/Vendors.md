<!-- Generated file — do not edit; regenerated with the SDK. -->

# Vendors — operations

Accessor: `client.Vendors` · Source: `src/Square/Api/Vendors.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkCreateVendors

- **Auth**: `options.Oauth2`
- **Signature**: `BulkCreateVendors(BulkCreateVendorsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkCreateVendorsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkCreateVendorsOperationRequest` | `src/Square/Requests/Vendors/BulkCreateVendorsOperationRequest.cs` |
| `BulkCreateVendorsRequest` | `src/Square/Models/BulkCreateVendorsRequest.cs` |
| `BulkCreateVendorsResponse` | `src/Square/Models/BulkCreateVendorsResponse.cs` |

### BulkRetrieveVendors

- **Auth**: `options.Oauth2`
- **Signature**: `BulkRetrieveVendors(BulkRetrieveVendorsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkRetrieveVendorsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveVendorsOperationRequest` | `src/Square/Requests/Vendors/BulkRetrieveVendorsOperationRequest.cs` |
| `BulkRetrieveVendorsRequest` | `src/Square/Models/BulkRetrieveVendorsRequest.cs` |
| `BulkRetrieveVendorsResponse` | `src/Square/Models/BulkRetrieveVendorsResponse.cs` |

### BulkUpdateVendors

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpdateVendors(BulkUpdateVendorsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpdateVendorsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpdateVendorsOperationRequest` | `src/Square/Requests/Vendors/BulkUpdateVendorsOperationRequest.cs` |
| `BulkUpdateVendorsRequest` | `src/Square/Models/BulkUpdateVendorsRequest.cs` |
| `BulkUpdateVendorsResponse` | `src/Square/Models/BulkUpdateVendorsResponse.cs` |

### CreateVendor

- **Auth**: `options.Oauth2`
- **Signature**: `CreateVendor(CreateVendorOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateVendorResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateVendorOperationRequest` | `src/Square/Requests/Vendors/CreateVendorOperationRequest.cs` |
| `CreateVendorRequest` | `src/Square/Models/CreateVendorRequest.cs` |
| `CreateVendorResponse` | `src/Square/Models/CreateVendorResponse.cs` |

### RetrieveVendor

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveVendor(RetrieveVendorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`
- **Returns**: `RetrieveVendorResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveVendorRequest` | `src/Square/Requests/Vendors/RetrieveVendorRequest.cs` |
| `RetrieveVendorResponse` | `src/Square/Models/RetrieveVendorResponse.cs` |

### SearchVendors

- **Auth**: `options.Oauth2`
- **Signature**: `SearchVendors(SearchVendorsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchVendorsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchVendorsOperationRequest` | `src/Square/Requests/Vendors/SearchVendorsOperationRequest.cs` |
| `SearchVendorsRequest` | `src/Square/Models/SearchVendorsRequest.cs` |
| `SearchVendorsResponse` | `src/Square/Models/SearchVendorsResponse.cs` |

### UpdateVendor

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateVendor(UpdateVendorOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`, `Body`
- **Returns**: `UpdateVendorResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateVendorOperationRequest` | `src/Square/Requests/Vendors/UpdateVendorOperationRequest.cs` |
| `UpdateVendorRequest` | `src/Square/Models/UpdateVendorRequest.cs` |
| `UpdateVendorResponse` | `src/Square/Models/UpdateVendorResponse.cs` |

