<!-- Generated file — do not edit; regenerated with the SDK. -->

# Events — operations

Accessor: `client.Events` · Source: `Api/Events.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DisableEvents

- **Auth**: `options.Oauth2`
- **Signature**: `DisableEvents(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DisableEventsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DisableEventsResponse` | `Models/DisableEventsResponse.cs` |

### EnableEvents

- **Auth**: `options.Oauth2`
- **Signature**: `EnableEvents(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EnableEventsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnableEventsResponse` | `Models/EnableEventsResponse.cs` |

### ListEventTypes

- **Auth**: `options.Oauth2`
- **Signature**: `ListEventTypes(string? apiVersion, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `apiVersion` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `api_version` ← `apiVersion`
- **Returns**: `ListEventTypesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEventTypesResponse` | `Models/ListEventTypesResponse.cs` |

### SearchEvents

- **Auth**: `options.Oauth2`
- **Signature**: `SearchEvents(SearchEventsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchEventsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchEventsRequest` | `Models/SearchEventsRequest.cs` |
| `SearchEventsResponse` | `Models/SearchEventsResponse.cs` |

