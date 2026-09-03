<!-- Generated file — do not edit; regenerated with the SDK. -->

# CheckoutApi — operations

Accessor: `client.CheckoutApi` · Source: `Api/CheckoutApi.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCheckout(string locationId, CreateCheckoutRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateCheckoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCheckoutRequest` | `Models/CreateCheckoutRequest.cs` |
| `CreateCheckoutResponse` | `Models/CreateCheckoutResponse.cs` |

### CreatePaymentLink

- **Auth**: `options.Oauth2`
- **Signature**: `CreatePaymentLink(CreatePaymentLinkRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreatePaymentLinkResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreatePaymentLinkRequest` | `Models/CreatePaymentLinkRequest.cs` |
| `CreatePaymentLinkResponse` | `Models/CreatePaymentLinkResponse.cs` |

### DeletePaymentLink

- **Auth**: `options.Oauth2`
- **Signature**: `DeletePaymentLink(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeletePaymentLinkResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeletePaymentLinkResponse` | `Models/DeletePaymentLinkResponse.cs` |

### ListPaymentLinks

- **Auth**: `options.Oauth2`
- **Signature**: `ListPaymentLinks(string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListPaymentLinksResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPaymentLinksResponse` | `Models/ListPaymentLinksResponse.cs` |

### RetrieveLocationSettings

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLocationSettings(string locationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveLocationSettingsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationSettingsResponse` | `Models/RetrieveLocationSettingsResponse.cs` |

### RetrieveMerchantSettings

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveMerchantSettings(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveMerchantSettingsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveMerchantSettingsResponse` | `Models/RetrieveMerchantSettingsResponse.cs` |

### RetrievePaymentLink

- **Auth**: `options.Oauth2`
- **Signature**: `RetrievePaymentLink(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrievePaymentLinkResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrievePaymentLinkResponse` | `Models/RetrievePaymentLinkResponse.cs` |

### UpdateLocationSettings

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateLocationSettings(string locationId, UpdateLocationSettingsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateLocationSettingsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateLocationSettingsRequest` | `Models/UpdateLocationSettingsRequest.cs` |
| `UpdateLocationSettingsResponse` | `Models/UpdateLocationSettingsResponse.cs` |

### UpdateMerchantSettings

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateMerchantSettings(UpdateMerchantSettingsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateMerchantSettingsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateMerchantSettingsRequest` | `Models/UpdateMerchantSettingsRequest.cs` |
| `UpdateMerchantSettingsResponse` | `Models/UpdateMerchantSettingsResponse.cs` |

### UpdatePaymentLink

- **Auth**: `options.Oauth2`
- **Signature**: `UpdatePaymentLink(string id, UpdatePaymentLinkRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdatePaymentLinkResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdatePaymentLinkRequest` | `Models/UpdatePaymentLinkRequest.cs` |
| `UpdatePaymentLinkResponse` | `Models/UpdatePaymentLinkResponse.cs` |

