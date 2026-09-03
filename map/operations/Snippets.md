<!-- Generated file — do not edit; regenerated with the SDK. -->

# Snippets — operations

Accessor: `client.Snippets` · Source: `Api/Snippets.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteSnippet

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteSnippet(string siteId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteSnippetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSnippetResponse` | `Models/DeleteSnippetResponse.cs` |

### RetrieveSnippet

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveSnippet(string siteId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveSnippetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveSnippetResponse` | `Models/RetrieveSnippetResponse.cs` |

### UpsertSnippet

- **Auth**: `options.Oauth2`
- **Signature**: `UpsertSnippet(string siteId, UpsertSnippetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpsertSnippetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertSnippetRequest` | `Models/UpsertSnippetRequest.cs` |
| `UpsertSnippetResponse` | `Models/UpsertSnippetResponse.cs` |

