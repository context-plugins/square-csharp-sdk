<!-- Generated file — do not edit; regenerated with the SDK. -->

# CheckoutApi — operations

Accessor: `client.CheckoutApi` · Source: `src/Square/Api/CheckoutApi.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCheckout

- **Auth**: `options.Oauth2`
- **Signature**: `CreateCheckout(CreateCheckoutOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `Body`
- **Returns**: `CreateCheckoutResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCheckoutOperationRequest` | `src/Square/Requests/CheckoutApi/CreateCheckoutOperationRequest.cs` |
| `CreateCheckoutRequest` | `src/Square/Models/CreateCheckoutRequest.cs` |
| `CreateCheckoutResponse` | `src/Square/Models/CreateCheckoutResponse.cs` |

### CreatePaymentLink

- **Auth**: `options.Oauth2`
- **Signature**: `CreatePaymentLink(CreatePaymentLinkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreatePaymentLinkResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreatePaymentLinkOperationRequest` | `src/Square/Requests/CheckoutApi/CreatePaymentLinkOperationRequest.cs` |
| `CreatePaymentLinkRequest` | `src/Square/Models/CreatePaymentLinkRequest.cs` |
| `CreatePaymentLinkResponse` | `src/Square/Models/CreatePaymentLinkResponse.cs` |

### DeletePaymentLink

- **Auth**: `options.Oauth2`
- **Signature**: `DeletePaymentLink(DeletePaymentLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DeletePaymentLinkResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeletePaymentLinkRequest` | `src/Square/Requests/CheckoutApi/DeletePaymentLinkRequest.cs` |
| `DeletePaymentLinkResponse` | `src/Square/Models/DeletePaymentLinkResponse.cs` |

### ListPaymentLinks

- **Auth**: `options.Oauth2`
- **Signature**: `ListPaymentLinks(ListPaymentLinksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListPaymentLinksResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPaymentLinksRequest` | `src/Square/Requests/CheckoutApi/ListPaymentLinksRequest.cs` |
| `ListPaymentLinksResponse` | `src/Square/Models/ListPaymentLinksResponse.cs` |

### RetrieveLocationSettings

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLocationSettings(RetrieveLocationSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Returns**: `RetrieveLocationSettingsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationSettingsRequest` | `src/Square/Requests/CheckoutApi/RetrieveLocationSettingsRequest.cs` |
| `RetrieveLocationSettingsResponse` | `src/Square/Models/RetrieveLocationSettingsResponse.cs` |

### RetrieveMerchantSettings

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveMerchantSettings(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RetrieveMerchantSettingsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveMerchantSettingsResponse` | `src/Square/Models/RetrieveMerchantSettingsResponse.cs` |

### RetrievePaymentLink

- **Auth**: `options.Oauth2`
- **Signature**: `RetrievePaymentLink(RetrievePaymentLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RetrievePaymentLinkResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrievePaymentLinkRequest` | `src/Square/Requests/CheckoutApi/RetrievePaymentLinkRequest.cs` |
| `RetrievePaymentLinkResponse` | `src/Square/Models/RetrievePaymentLinkResponse.cs` |

### UpdateLocationSettings

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateLocationSettings(UpdateLocationSettingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `Body`
- **Returns**: `UpdateLocationSettingsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateLocationSettingsOperationRequest` | `src/Square/Requests/CheckoutApi/UpdateLocationSettingsOperationRequest.cs` |
| `UpdateLocationSettingsRequest` | `src/Square/Models/UpdateLocationSettingsRequest.cs` |
| `UpdateLocationSettingsResponse` | `src/Square/Models/UpdateLocationSettingsResponse.cs` |

### UpdateMerchantSettings

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateMerchantSettings(UpdateMerchantSettingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UpdateMerchantSettingsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateMerchantSettingsOperationRequest` | `src/Square/Requests/CheckoutApi/UpdateMerchantSettingsOperationRequest.cs` |
| `UpdateMerchantSettingsRequest` | `src/Square/Models/UpdateMerchantSettingsRequest.cs` |
| `UpdateMerchantSettingsResponse` | `src/Square/Models/UpdateMerchantSettingsResponse.cs` |

### UpdatePaymentLink

- **Auth**: `options.Oauth2`
- **Signature**: `UpdatePaymentLink(UpdatePaymentLinkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `UpdatePaymentLinkResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdatePaymentLinkOperationRequest` | `src/Square/Requests/CheckoutApi/UpdatePaymentLinkOperationRequest.cs` |
| `UpdatePaymentLinkRequest` | `src/Square/Models/UpdatePaymentLinkRequest.cs` |
| `UpdatePaymentLinkResponse` | `src/Square/Models/UpdatePaymentLinkResponse.cs` |

