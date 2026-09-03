<!-- Generated file — do not edit; regenerated with the SDK. -->

# Inventory — operations

Accessor: `client.Inventory` · Source: `Api/Inventory.cs` · 19 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BatchChangeInventory

- **Auth**: `options.Oauth2`
- **Signature**: `BatchChangeInventory(BatchChangeInventoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchChangeInventoryResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchChangeInventoryRequest` | `Models/BatchChangeInventoryRequest.cs` |
| `BatchChangeInventoryResponse` | `Models/BatchChangeInventoryResponse.cs` |

### BatchRetrieveInventoryChanges

- **Auth**: `options.Oauth2`
- **Signature**: `BatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchRetrieveInventoryChangesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveInventoryChangesRequest` | `Models/BatchRetrieveInventoryChangesRequest.cs` |
| `BatchRetrieveInventoryChangesResponse` | `Models/BatchRetrieveInventoryChangesResponse.cs` |

### BatchRetrieveInventoryCounts

- **Auth**: `options.Oauth2`
- **Signature**: `BatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchRetrieveInventoryCountsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveInventoryCountsRequest` | `Models/BatchRetrieveInventoryCountsRequest.cs` |
| `BatchRetrieveInventoryCountsResponse` | `Models/BatchRetrieveInventoryCountsResponse.cs` |

### CreateInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `CreateInventoryAdjustmentReason(CreateInventoryAdjustmentReasonRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateInventoryAdjustmentReasonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInventoryAdjustmentReasonRequest` | `Models/CreateInventoryAdjustmentReasonRequest.cs` |
| `CreateInventoryAdjustmentReasonResponse` | `Models/CreateInventoryAdjustmentReasonResponse.cs` |

### DeleteInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteInventoryAdjustmentReason(DeleteInventoryAdjustmentReasonRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteInventoryAdjustmentReasonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteInventoryAdjustmentReasonRequest` | `Models/DeleteInventoryAdjustmentReasonRequest.cs` |
| `DeleteInventoryAdjustmentReasonResponse` | `Models/DeleteInventoryAdjustmentReasonResponse.cs` |

### DeprecatedBatchChangeInventory

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedBatchChangeInventory(BatchChangeInventoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchChangeInventoryResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchChangeInventoryRequest` | `Models/BatchChangeInventoryRequest.cs` |
| `BatchChangeInventoryResponse` | `Models/BatchChangeInventoryResponse.cs` |

### DeprecatedBatchRetrieveInventoryChanges

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedBatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchRetrieveInventoryChangesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveInventoryChangesRequest` | `Models/BatchRetrieveInventoryChangesRequest.cs` |
| `BatchRetrieveInventoryChangesResponse` | `Models/BatchRetrieveInventoryChangesResponse.cs` |

### DeprecatedBatchRetrieveInventoryCounts

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedBatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchRetrieveInventoryCountsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveInventoryCountsRequest` | `Models/BatchRetrieveInventoryCountsRequest.cs` |
| `BatchRetrieveInventoryCountsResponse` | `Models/BatchRetrieveInventoryCountsResponse.cs` |

### DeprecatedRetrieveInventoryAdjustment

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedRetrieveInventoryAdjustment(string adjustmentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveInventoryAdjustmentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryAdjustmentResponse` | `Models/RetrieveInventoryAdjustmentResponse.cs` |

### DeprecatedRetrieveInventoryPhysicalCount

- **Auth**: `options.Oauth2`
- **Signature**: `DeprecatedRetrieveInventoryPhysicalCount(string physicalCountId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveInventoryPhysicalCountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryPhysicalCountResponse` | `Models/RetrieveInventoryPhysicalCountResponse.cs` |

### ListInventoryAdjustmentReasons

- **Auth**: `options.Oauth2`
- **Signature**: `ListInventoryAdjustmentReasons(bool? includeDeleted = false, bool? includeSystemCodes = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `includeDeleted` = `false`, `includeSystemCodes` = `false`
- **Query params (wire ← C#)**: `include_deleted` ← `includeDeleted`, `include_system_codes` ← `includeSystemCodes`
- **Returns**: `ListInventoryAdjustmentReasonsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListInventoryAdjustmentReasonsResponse` | `Models/ListInventoryAdjustmentReasonsResponse.cs` |

### RestoreInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `RestoreInventoryAdjustmentReason(RestoreInventoryAdjustmentReasonRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RestoreInventoryAdjustmentReasonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RestoreInventoryAdjustmentReasonRequest` | `Models/RestoreInventoryAdjustmentReasonRequest.cs` |
| `RestoreInventoryAdjustmentReasonResponse` | `Models/RestoreInventoryAdjustmentReasonResponse.cs` |

### RetrieveInventoryAdjustment

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryAdjustment(string adjustmentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveInventoryAdjustmentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryAdjustmentResponse` | `Models/RetrieveInventoryAdjustmentResponse.cs` |

### RetrieveInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryAdjustmentReason(RetrieveInventoryAdjustmentReasonRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveInventoryAdjustmentReasonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryAdjustmentReasonRequest` | `Models/RetrieveInventoryAdjustmentReasonRequest.cs` |
| `RetrieveInventoryAdjustmentReasonResponse` | `Models/RetrieveInventoryAdjustmentReasonResponse.cs` |

### RetrieveInventoryChanges

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryChanges(string catalogObjectId, string? locationIds, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `locationIds` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `location_ids` ← `locationIds`, `cursor` ← `cursor`
- **Returns**: `RetrieveInventoryChangesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryChangesResponse` | `Models/RetrieveInventoryChangesResponse.cs` |

### RetrieveInventoryCount

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryCount(string catalogObjectId, string? locationIds, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `locationIds` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `location_ids` ← `locationIds`, `cursor` ← `cursor`
- **Returns**: `RetrieveInventoryCountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryCountResponse` | `Models/RetrieveInventoryCountResponse.cs` |

### RetrieveInventoryPhysicalCount

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveInventoryPhysicalCount(string physicalCountId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveInventoryPhysicalCountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryPhysicalCountResponse` | `Models/RetrieveInventoryPhysicalCountResponse.cs` |

### UpdateInventoryAdjustment

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateInventoryAdjustment(UpdateInventoryAdjustmentRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateInventoryAdjustmentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateInventoryAdjustmentRequest` | `Models/UpdateInventoryAdjustmentRequest.cs` |
| `UpdateInventoryAdjustmentResponse` | `Models/UpdateInventoryAdjustmentResponse.cs` |

### UpdateInventoryAdjustmentReason

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateInventoryAdjustmentReason(UpdateInventoryAdjustmentReasonRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateInventoryAdjustmentReasonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateInventoryAdjustmentReasonRequest` | `Models/UpdateInventoryAdjustmentReasonRequest.cs` |
| `UpdateInventoryAdjustmentReasonResponse` | `Models/UpdateInventoryAdjustmentReasonResponse.cs` |

