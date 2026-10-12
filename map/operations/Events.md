<!-- Generated file — do not edit; regenerated with the SDK. -->

# Events — operations

Accessor: `client.Events` · Source: `src/Square/Api/Events.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DisableEvents

- **Auth**: `options.Oauth2`
- **Signature**: `DisableEvents(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DisableEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DisableEventsResponse` | `src/Square/Models/DisableEventsResponse.cs` |

### EnableEvents

- **Auth**: `options.Oauth2`
- **Signature**: `EnableEvents(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `EnableEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnableEventsResponse` | `src/Square/Models/EnableEventsResponse.cs` |

### ListEventTypes

- **Auth**: `options.Oauth2`
- **Signature**: `ListEventTypes(ListEventTypesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `api_version` ← `ApiVersion`
- **Returns**: `ListEventTypesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEventTypesRequest` | `src/Square/Requests/Events/ListEventTypesRequest.cs` |
| `ListEventTypesResponse` | `src/Square/Models/ListEventTypesResponse.cs` |

### SearchEvents

- **Auth**: `options.Oauth2`
- **Signature**: `SearchEvents(SearchEventsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchEventsOperationRequest` | `src/Square/Requests/Events/SearchEventsOperationRequest.cs` |
| `SearchEventsRequest` | `src/Square/Models/SearchEventsRequest.cs` |
| `SearchEventsResponse` | `src/Square/Models/SearchEventsResponse.cs` |

