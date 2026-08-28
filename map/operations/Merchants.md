<!-- Generated file — do not edit; regenerated with the SDK. -->

# Merchants — operations

Accessor: `client.Merchants` · Source: `Api/Merchants.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListMerchants

- **Signature**: `ListMerchants(int? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`
- **Returns**: `ListMerchantsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMerchantsResponse` | `Models/ListMerchantsResponse.cs` |

### RetrieveMerchant

- **Signature**: `RetrieveMerchant(string merchantId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveMerchantResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveMerchantResponse` | `Models/RetrieveMerchantResponse.cs` |

