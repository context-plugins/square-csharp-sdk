<!-- Generated file — do not edit; regenerated with the SDK. -->

# OAuth — operations

Accessor: `client.OAuth` · Source: `Api/OAuth.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ObtainToken

- **Signature**: `ObtainToken(ObtainTokenRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ObtainTokenResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ObtainTokenRequest` | `Models/ObtainTokenRequest.cs` |
| `ObtainTokenResponse` | `Models/ObtainTokenResponse.cs` |

### RetrieveTokenStatus

- **Signature**: `RetrieveTokenStatus(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveTokenStatusResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTokenStatusResponse` | `Models/RetrieveTokenStatusResponse.cs` |

### RevokeToken

- **Signature**: `RevokeToken(RevokeTokenRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RevokeTokenResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RevokeTokenRequest` | `Models/RevokeTokenRequest.cs` |
| `RevokeTokenResponse` | `Models/RevokeTokenResponse.cs` |

