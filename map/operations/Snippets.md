<!-- Generated file — do not edit; regenerated with the SDK. -->

# Snippets — operations

Accessor: `client.Snippets` · Source: `src/Square/Api/Snippets.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteSnippet

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteSnippet(DeleteSnippetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SiteId`
- **Returns**: `DeleteSnippetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSnippetRequest` | `src/Square/Requests/Snippets/DeleteSnippetRequest.cs` |
| `DeleteSnippetResponse` | `src/Square/Models/DeleteSnippetResponse.cs` |

### RetrieveSnippet

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveSnippet(RetrieveSnippetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SiteId`
- **Returns**: `RetrieveSnippetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveSnippetRequest` | `src/Square/Requests/Snippets/RetrieveSnippetRequest.cs` |
| `RetrieveSnippetResponse` | `src/Square/Models/RetrieveSnippetResponse.cs` |

### UpsertSnippet

- **Auth**: `options.Oauth2`
- **Signature**: `UpsertSnippet(UpsertSnippetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SiteId`, `Body`
- **Returns**: `UpsertSnippetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertSnippetOperationRequest` | `src/Square/Requests/Snippets/UpsertSnippetOperationRequest.cs` |
| `UpsertSnippetRequest` | `src/Square/Models/UpsertSnippetRequest.cs` |
| `UpsertSnippetResponse` | `src/Square/Models/UpsertSnippetResponse.cs` |

