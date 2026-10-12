<!-- Generated file — do not edit; regenerated with the SDK. -->

# OAuth — operations

Accessor: `client.OAuth` · Source: `src/Square/Api/OAuth.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ObtainToken

- **Signature**: `ObtainToken(ObtainTokenOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ObtainTokenResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ObtainTokenOperationRequest` | `src/Square/Requests/OAuth/ObtainTokenOperationRequest.cs` |
| `ObtainTokenRequest` | `src/Square/Models/ObtainTokenRequest.cs` |
| `ObtainTokenResponse` | `src/Square/Models/ObtainTokenResponse.cs` |

### RetrieveTokenStatus

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveTokenStatus(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RetrieveTokenStatusResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTokenStatusResponse` | `src/Square/Models/RetrieveTokenStatusResponse.cs` |

### RevokeToken

- **Signature**: `RevokeToken(RevokeTokenOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RevokeTokenResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RevokeTokenOperationRequest` | `src/Square/Requests/OAuth/RevokeTokenOperationRequest.cs` |
| `RevokeTokenRequest` | `src/Square/Models/RevokeTokenRequest.cs` |
| `RevokeTokenResponse` | `src/Square/Models/RevokeTokenResponse.cs` |

