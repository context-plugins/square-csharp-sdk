<!-- Generated file — do not edit; regenerated with the SDK. -->

# Catalog — operations

Accessor: `client.Catalog` · Source: `Api/Catalog.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BatchDeleteCatalogObjects

- **Signature**: `BatchDeleteCatalogObjects(BatchDeleteCatalogObjectsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchDeleteCatalogObjectsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchDeleteCatalogObjectsRequest` | `Models/BatchDeleteCatalogObjectsRequest.cs` |
| `BatchDeleteCatalogObjectsResponse` | `Models/BatchDeleteCatalogObjectsResponse.cs` |

### BatchRetrieveCatalogObjects

- **Signature**: `BatchRetrieveCatalogObjects(BatchRetrieveCatalogObjectsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchRetrieveCatalogObjectsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveCatalogObjectsRequest` | `Models/BatchRetrieveCatalogObjectsRequest.cs` |
| `BatchRetrieveCatalogObjectsResponse` | `Models/BatchRetrieveCatalogObjectsResponse.cs` |

### BatchUpsertCatalogObjects

- **Signature**: `BatchUpsertCatalogObjects(BatchUpsertCatalogObjectsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BatchUpsertCatalogObjectsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchUpsertCatalogObjectsRequest` | `Models/BatchUpsertCatalogObjectsRequest.cs` |
| `BatchUpsertCatalogObjectsResponse` | `Models/BatchUpsertCatalogObjectsResponse.cs` |

### CatalogInfo

- **Signature**: `CatalogInfo(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CatalogInfoResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CatalogInfoResponse` | `Models/CatalogInfoResponse.cs` |

### CreateCatalogImage

- **Signature**: `CreateCatalogImage(CreateCatalogImageRequest? request, BinaryContent? imageFile, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `request` — nullable, no default → **must pass explicitly**
  - `imageFile` — nullable, no default → **must pass explicitly**
- **Returns**: `CreateCatalogImageResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCatalogImageRequest` | `Models/CreateCatalogImageRequest.cs` |
| `CreateCatalogImageResponse` | `Models/CreateCatalogImageResponse.cs` |

### DeleteCatalogObject

- **Signature**: `DeleteCatalogObject(string objectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteCatalogObjectResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCatalogObjectResponse` | `Models/DeleteCatalogObjectResponse.cs` |

### ListCatalog

- **Signature**: `ListCatalog(string? cursor, string? types, long? catalogVersion, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `types` — nullable, no default → **must pass explicitly**
  - `catalogVersion` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `types` ← `types`, `catalog_version` ← `catalogVersion`
- **Returns**: `ListCatalogResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCatalogResponse` | `Models/ListCatalogResponse.cs` |

### RetrieveCatalogObject

- **Signature**: `RetrieveCatalogObject(string objectId, long? catalogVersion, bool? includeRelatedObjects = false, bool? includeCategoryPathToRoot = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `catalogVersion` — nullable, no default → **must pass explicitly**
  - defaults: `includeRelatedObjects` = `false`, `includeCategoryPathToRoot` = `false`
- **Query params (wire ← C#)**: `include_related_objects` ← `includeRelatedObjects`, `catalog_version` ← `catalogVersion`, `include_category_path_to_root` ← `includeCategoryPathToRoot`
- **Returns**: `RetrieveCatalogObjectResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCatalogObjectResponse` | `Models/RetrieveCatalogObjectResponse.cs` |

### SearchCatalogItems

- **Signature**: `SearchCatalogItems(SearchCatalogItemsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchCatalogItemsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchCatalogItemsRequest` | `Models/SearchCatalogItemsRequest.cs` |
| `SearchCatalogItemsResponse` | `Models/SearchCatalogItemsResponse.cs` |

### SearchCatalogObjects

- **Signature**: `SearchCatalogObjects(SearchCatalogObjectsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchCatalogObjectsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchCatalogObjectsRequest` | `Models/SearchCatalogObjectsRequest.cs` |
| `SearchCatalogObjectsResponse` | `Models/SearchCatalogObjectsResponse.cs` |

### UpdateCatalogImage

- **Signature**: `UpdateCatalogImage(string imageId, UpdateCatalogImageRequest? request, BinaryContent? imageFile, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `request` — nullable, no default → **must pass explicitly**
  - `imageFile` — nullable, no default → **must pass explicitly**
- **Returns**: `UpdateCatalogImageResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCatalogImageRequest` | `Models/UpdateCatalogImageRequest.cs` |
| `UpdateCatalogImageResponse` | `Models/UpdateCatalogImageResponse.cs` |

### UpdateItemModifierLists

- **Signature**: `UpdateItemModifierLists(UpdateItemModifierListsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateItemModifierListsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateItemModifierListsRequest` | `Models/UpdateItemModifierListsRequest.cs` |
| `UpdateItemModifierListsResponse` | `Models/UpdateItemModifierListsResponse.cs` |

### UpdateItemTaxes

- **Signature**: `UpdateItemTaxes(UpdateItemTaxesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateItemTaxesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateItemTaxesRequest` | `Models/UpdateItemTaxesRequest.cs` |
| `UpdateItemTaxesResponse` | `Models/UpdateItemTaxesResponse.cs` |

### UpsertCatalogObject

- **Signature**: `UpsertCatalogObject(UpsertCatalogObjectRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpsertCatalogObjectResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertCatalogObjectRequest` | `Models/UpsertCatalogObjectRequest.cs` |
| `UpsertCatalogObjectResponse` | `Models/UpsertCatalogObjectResponse.cs` |

