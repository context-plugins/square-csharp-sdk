<!-- Generated file — do not edit; regenerated with the SDK. -->

# Locations — operations

Accessor: `client.Locations` · Source: `Api/Locations.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateLocation

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLocation(CreateLocationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateLocationResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLocationRequest` | `Models/CreateLocationRequest.cs` |
| `CreateLocationResponse` | `Models/CreateLocationResponse.cs` |

### ListLocations

- **Auth**: `options.Oauth2`
- **Signature**: `ListLocations(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListLocationsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLocationsResponse` | `Models/ListLocationsResponse.cs` |

### RetrieveLocation

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLocation(string locationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveLocationResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationResponse` | `Models/RetrieveLocationResponse.cs` |

### UpdateLocation

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateLocation(string locationId, UpdateLocationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateLocationResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateLocationRequest` | `Models/UpdateLocationRequest.cs` |
| `UpdateLocationResponse` | `Models/UpdateLocationResponse.cs` |

