<!-- Generated file — do not edit; regenerated with the SDK. -->

# Locations — operations

Accessor: `client.Locations` · Source: `src/Square/Api/Locations.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateLocation

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLocation(CreateLocationOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateLocationResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLocationOperationRequest` | `src/Square/Requests/Locations/CreateLocationOperationRequest.cs` |
| `CreateLocationRequest` | `src/Square/Models/CreateLocationRequest.cs` |
| `CreateLocationResponse` | `src/Square/Models/CreateLocationResponse.cs` |

### ListLocations

- **Auth**: `options.Oauth2`
- **Signature**: `ListLocations(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ListLocationsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLocationsResponse` | `src/Square/Models/ListLocationsResponse.cs` |

### RetrieveLocation

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLocation(RetrieveLocationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Returns**: `RetrieveLocationResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationRequest` | `src/Square/Requests/Locations/RetrieveLocationRequest.cs` |
| `RetrieveLocationResponse` | `src/Square/Models/RetrieveLocationResponse.cs` |

### UpdateLocation

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateLocation(UpdateLocationOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `Body`
- **Returns**: `UpdateLocationResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateLocationOperationRequest` | `src/Square/Requests/Locations/UpdateLocationOperationRequest.cs` |
| `UpdateLocationRequest` | `src/Square/Models/UpdateLocationRequest.cs` |
| `UpdateLocationResponse` | `src/Square/Models/UpdateLocationResponse.cs` |

