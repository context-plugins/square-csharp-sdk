<!-- Generated file — do not edit; regenerated with the SDK. -->

# Inventory — operations

Accessor: `client.Inventory` · Source: `src/Square/Api/Inventory.cs` · 19 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BatchChangeInventory

- **Auth**: `options.Oauth2`
- **Signature**: `BatchChangeInventory(BatchChangeInventoryOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchChangeInventoryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchChangeInventoryOperationRequest` | `src/Square/Requests/Inventory/BatchChangeInventoryOperationRequest.cs` |
| `BatchChangeInventoryRequest` | `src/Square/Models/BatchChangeInventoryRequest.cs` |
| `BatchChangeInventoryResponse` | `src/Square/Models/BatchChangeInventoryResponse.cs` |

### BatchRetrieveInventoryChanges

- **Auth**: `options.Oauth2`
- **Signature**: `BatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveInventoryChangesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveInventoryChangesOperationRequest` | `src/Square/Requests/Inventory/BatchRetrieveInventoryChangesOperationRequest.cs` |
| `BatchRetrieveInventoryChangesRequest` | `src/Square/Models/BatchRetrieveInventoryChangesRequest.cs` |
| `BatchRetrieveInventoryChangesResponse` | `src/Square/Models/BatchRetrieveInventoryChangesResponse.cs` |

### BatchRetrieveInventoryCounts

- **Auth**: `options.Oauth2`
- **Signature**: `BatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveInventoryCountsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveInventoryCountsOperationRequest` | `src/Square/Requests/Inventory/BatchRetrieveInventoryCountsOperationRequest.cs` |
| `BatchRetrieveInventoryCountsRequest` | `src/Square/Models/BatchRetrieveInventoryCountsRequest.cs` |
| `BatchRetrieveInventoryCountsResponse` | `src/Square/Models/BatchRetrieveInventoryCountsResponse.cs` |

### CreateInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `CreateInventoryAdjustmentReason(CreateInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateInventoryAdjustmentReasonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInventoryAdjustmentReasonOperationRequest` | `src/Square/Requests/Inventory/CreateInventoryAdjustmentReasonOperationRequest.cs` |
| `CreateInventoryAdjustmentReasonRequest` | `src/Square/Models/CreateInventoryAdjustmentReasonRequest.cs` |
| `CreateInventoryAdjustmentReasonResponse` | `src/Square/Models/CreateInventoryAdjustmentReasonResponse.cs` |

### DeleteInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteInventoryAdjustmentReason(DeleteInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeleteInventoryAdjustmentReasonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteInventoryAdjustmentReasonOperationRequest` | `src/Square/Requests/Inventory/DeleteInventoryAdjustmentReasonOperationRequest.cs` |
| `DeleteInventoryAdjustmentReasonRequest` | `src/Square/Models/DeleteInventoryAdjustmentReasonRequest.cs` |
| `DeleteInventoryAdjustmentReasonResponse` | `src/Square/Models/DeleteInventoryAdjustmentReasonResponse.cs` |

### DeprecatedBatchChangeInventory

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedBatchChangeInventory(DeprecatedBatchChangeInventoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchChangeInventoryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedBatchChangeInventoryRequest` | `src/Square/Requests/Inventory/DeprecatedBatchChangeInventoryRequest.cs` |
| `BatchChangeInventoryRequest` | `src/Square/Models/BatchChangeInventoryRequest.cs` |
| `BatchChangeInventoryResponse` | `src/Square/Models/BatchChangeInventoryResponse.cs` |

### DeprecatedBatchRetrieveInventoryChanges

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedBatchRetrieveInventoryChanges(DeprecatedBatchRetrieveInventoryChangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveInventoryChangesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedBatchRetrieveInventoryChangesRequest` | `src/Square/Requests/Inventory/DeprecatedBatchRetrieveInventoryChangesRequest.cs` |
| `BatchRetrieveInventoryChangesRequest` | `src/Square/Models/BatchRetrieveInventoryChangesRequest.cs` |
| `BatchRetrieveInventoryChangesResponse` | `src/Square/Models/BatchRetrieveInventoryChangesResponse.cs` |

### DeprecatedBatchRetrieveInventoryCounts

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedBatchRetrieveInventoryCounts(DeprecatedBatchRetrieveInventoryCountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveInventoryCountsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedBatchRetrieveInventoryCountsRequest` | `src/Square/Requests/Inventory/DeprecatedBatchRetrieveInventoryCountsRequest.cs` |
| `BatchRetrieveInventoryCountsRequest` | `src/Square/Models/BatchRetrieveInventoryCountsRequest.cs` |
| `BatchRetrieveInventoryCountsResponse` | `src/Square/Models/BatchRetrieveInventoryCountsResponse.cs` |

### DeprecatedRetrieveInventoryAdjustment

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedRetrieveInventoryAdjustment(DeprecatedRetrieveInventoryAdjustmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AdjustmentId`
- **Returns**: `RetrieveInventoryAdjustmentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedRetrieveInventoryAdjustmentRequest` | `src/Square/Requests/Inventory/DeprecatedRetrieveInventoryAdjustmentRequest.cs` |
| `RetrieveInventoryAdjustmentResponse` | `src/Square/Models/RetrieveInventoryAdjustmentResponse.cs` |

### DeprecatedRetrieveInventoryPhysicalCount

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedRetrieveInventoryPhysicalCount(DeprecatedRetrieveInventoryPhysicalCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PhysicalCountId`
- **Returns**: `RetrieveInventoryPhysicalCountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedRetrieveInventoryPhysicalCountRequest` | `src/Square/Requests/Inventory/DeprecatedRetrieveInventoryPhysicalCountRequest.cs` |
| `RetrieveInventoryPhysicalCountResponse` | `src/Square/Models/RetrieveInventoryPhysicalCountResponse.cs` |

### ListInventoryAdjustmentReasons

- **Auth**: `options.Oauth2`
- **Signature**: `ListInventoryAdjustmentReasons(ListInventoryAdjustmentReasonsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_deleted` ← `IncludeDeleted`, `include_system_codes` ← `IncludeSystemCodes`
- **Returns**: `ListInventoryAdjustmentReasonsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListInventoryAdjustmentReasonsRequest` | `src/Square/Requests/Inventory/ListInventoryAdjustmentReasonsRequest.cs` |
| `ListInventoryAdjustmentReasonsResponse` | `src/Square/Models/ListInventoryAdjustmentReasonsResponse.cs` |

### RestoreInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `RestoreInventoryAdjustmentReason(RestoreInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RestoreInventoryAdjustmentReasonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RestoreInventoryAdjustmentReasonOperationRequest` | `src/Square/Requests/Inventory/RestoreInventoryAdjustmentReasonOperationRequest.cs` |
| `RestoreInventoryAdjustmentReasonRequest` | `src/Square/Models/RestoreInventoryAdjustmentReasonRequest.cs` |
| `RestoreInventoryAdjustmentReasonResponse` | `src/Square/Models/RestoreInventoryAdjustmentReasonResponse.cs` |

### RetrieveInventoryAdjustment

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryAdjustment(RetrieveInventoryAdjustmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AdjustmentId`
- **Returns**: `RetrieveInventoryAdjustmentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryAdjustmentRequest` | `src/Square/Requests/Inventory/RetrieveInventoryAdjustmentRequest.cs` |
| `RetrieveInventoryAdjustmentResponse` | `src/Square/Models/RetrieveInventoryAdjustmentResponse.cs` |

### RetrieveInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryAdjustmentReason(RetrieveInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RetrieveInventoryAdjustmentReasonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryAdjustmentReasonOperationRequest` | `src/Square/Requests/Inventory/RetrieveInventoryAdjustmentReasonOperationRequest.cs` |
| `RetrieveInventoryAdjustmentReasonRequest` | `src/Square/Models/RetrieveInventoryAdjustmentReasonRequest.cs` |
| `RetrieveInventoryAdjustmentReasonResponse` | `src/Square/Models/RetrieveInventoryAdjustmentReasonResponse.cs` |

### RetrieveInventoryChanges

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryChanges(RetrieveInventoryChangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CatalogObjectId`
- **Query params (wire ← C#)**: `location_ids` ← `LocationIds`, `cursor` ← `Cursor`
- **Returns**: `RetrieveInventoryChangesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryChangesRequest` | `src/Square/Requests/Inventory/RetrieveInventoryChangesRequest.cs` |
| `RetrieveInventoryChangesResponse` | `src/Square/Models/RetrieveInventoryChangesResponse.cs` |

### RetrieveInventoryCount

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryCount(RetrieveInventoryCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CatalogObjectId`
- **Query params (wire ← C#)**: `location_ids` ← `LocationIds`, `cursor` ← `Cursor`
- **Returns**: `RetrieveInventoryCountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryCountRequest` | `src/Square/Requests/Inventory/RetrieveInventoryCountRequest.cs` |
| `RetrieveInventoryCountResponse` | `src/Square/Models/RetrieveInventoryCountResponse.cs` |

### RetrieveInventoryPhysicalCount

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryPhysicalCount(RetrieveInventoryPhysicalCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PhysicalCountId`
- **Returns**: `RetrieveInventoryPhysicalCountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryPhysicalCountRequest` | `src/Square/Requests/Inventory/RetrieveInventoryPhysicalCountRequest.cs` |
| `RetrieveInventoryPhysicalCountResponse` | `src/Square/Models/RetrieveInventoryPhysicalCountResponse.cs` |

### UpdateInventoryAdjustment

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateInventoryAdjustment(UpdateInventoryAdjustmentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UpdateInventoryAdjustmentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateInventoryAdjustmentOperationRequest` | `src/Square/Requests/Inventory/UpdateInventoryAdjustmentOperationRequest.cs` |
| `UpdateInventoryAdjustmentRequest` | `src/Square/Models/UpdateInventoryAdjustmentRequest.cs` |
| `UpdateInventoryAdjustmentResponse` | `src/Square/Models/UpdateInventoryAdjustmentResponse.cs` |

### UpdateInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateInventoryAdjustmentReason(UpdateInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UpdateInventoryAdjustmentReasonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateInventoryAdjustmentReasonOperationRequest` | `src/Square/Requests/Inventory/UpdateInventoryAdjustmentReasonOperationRequest.cs` |
| `UpdateInventoryAdjustmentReasonRequest` | `src/Square/Models/UpdateInventoryAdjustmentReasonRequest.cs` |
| `UpdateInventoryAdjustmentReasonResponse` | `src/Square/Models/UpdateInventoryAdjustmentReasonResponse.cs` |

