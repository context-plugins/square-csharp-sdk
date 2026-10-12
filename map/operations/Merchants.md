<!-- Generated file — do not edit; regenerated with the SDK. -->

# Merchants — operations

Accessor: `client.Merchants` · Source: `src/Square/Api/Merchants.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListMerchants

- **Auth**: `options.Oauth2`
- **Signature**: `ListMerchants(ListMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`
- **Returns**: `ListMerchantsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMerchantsRequest` | `src/Square/Requests/Merchants/ListMerchantsRequest.cs` |
| `ListMerchantsResponse` | `src/Square/Models/ListMerchantsResponse.cs` |

### RetrieveMerchant

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveMerchant(RetrieveMerchantRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `RetrieveMerchantResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveMerchantRequest` | `src/Square/Requests/Merchants/RetrieveMerchantRequest.cs` |
| `RetrieveMerchantResponse` | `src/Square/Models/RetrieveMerchantResponse.cs` |

