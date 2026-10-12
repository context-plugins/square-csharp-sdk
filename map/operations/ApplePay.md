<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApplePay — operations

Accessor: `client.ApplePay` · Source: `src/Square/Api/ApplePay.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RegisterDomain

- **Auth**: `options.Oauth2`
- **Signature**: `RegisterDomain(RegisterDomainOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RegisterDomainResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RegisterDomainOperationRequest` | `src/Square/Requests/ApplePay/RegisterDomainOperationRequest.cs` |
| `RegisterDomainRequest` | `src/Square/Models/RegisterDomainRequest.cs` |
| `RegisterDomainResponse` | `src/Square/Models/RegisterDomainResponse.cs` |

