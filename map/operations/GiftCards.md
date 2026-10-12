<!-- Generated file — do not edit; regenerated with the SDK. -->

# GiftCards — operations

Accessor: `client.GiftCards` · Source: `src/Square/Api/GiftCards.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateGiftCard

- **Auth**: `options.Oauth2`
- **Signature**: `CreateGiftCard(CreateGiftCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateGiftCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateGiftCardOperationRequest` | `src/Square/Requests/GiftCards/CreateGiftCardOperationRequest.cs` |
| `CreateGiftCardRequest` | `src/Square/Models/CreateGiftCardRequest.cs` |
| `CreateGiftCardResponse` | `src/Square/Models/CreateGiftCardResponse.cs` |

### LinkCustomerToGiftCard

- **Auth**: `options.Oauth2`
- **Signature**: `LinkCustomerToGiftCard(LinkCustomerToGiftCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GiftCardId`, `Body`
- **Returns**: `LinkCustomerToGiftCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkCustomerToGiftCardOperationRequest` | `src/Square/Requests/GiftCards/LinkCustomerToGiftCardOperationRequest.cs` |
| `LinkCustomerToGiftCardRequest` | `src/Square/Models/LinkCustomerToGiftCardRequest.cs` |
| `LinkCustomerToGiftCardResponse` | `src/Square/Models/LinkCustomerToGiftCardResponse.cs` |

### ListGiftCards

- **Auth**: `options.Oauth2`
- **Signature**: `ListGiftCards(ListGiftCardsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `type` ← `Type`, `state` ← `State`, `limit` ← `Limit`, `cursor` ← `Cursor`, `customer_id` ← `CustomerId`
- **Returns**: `ListGiftCardsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListGiftCardsRequest` | `src/Square/Requests/GiftCards/ListGiftCardsRequest.cs` |
| `ListGiftCardsResponse` | `src/Square/Models/ListGiftCardsResponse.cs` |

### RetrieveGiftCard

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveGiftCard(RetrieveGiftCardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RetrieveGiftCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveGiftCardRequest` | `src/Square/Requests/GiftCards/RetrieveGiftCardRequest.cs` |
| `RetrieveGiftCardResponse` | `src/Square/Models/RetrieveGiftCardResponse.cs` |

### RetrieveGiftCardFromGan

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveGiftCardFromGan(RetrieveGiftCardFromGanOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RetrieveGiftCardFromGanResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveGiftCardFromGanOperationRequest` | `src/Square/Requests/GiftCards/RetrieveGiftCardFromGanOperationRequest.cs` |
| `RetrieveGiftCardFromGanRequest` | `src/Square/Models/RetrieveGiftCardFromGanRequest.cs` |
| `RetrieveGiftCardFromGanResponse` | `src/Square/Models/RetrieveGiftCardFromGanResponse.cs` |

### RetrieveGiftCardFromNonce

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveGiftCardFromNonce(RetrieveGiftCardFromNonceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RetrieveGiftCardFromNonceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveGiftCardFromNonceOperationRequest` | `src/Square/Requests/GiftCards/RetrieveGiftCardFromNonceOperationRequest.cs` |
| `RetrieveGiftCardFromNonceRequest` | `src/Square/Models/RetrieveGiftCardFromNonceRequest.cs` |
| `RetrieveGiftCardFromNonceResponse` | `src/Square/Models/RetrieveGiftCardFromNonceResponse.cs` |

### UnlinkCustomerFromGiftCard

- **Auth**: `options.Oauth2`
- **Signature**: `UnlinkCustomerFromGiftCard(UnlinkCustomerFromGiftCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GiftCardId`, `Body`
- **Returns**: `UnlinkCustomerFromGiftCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UnlinkCustomerFromGiftCardOperationRequest` | `src/Square/Requests/GiftCards/UnlinkCustomerFromGiftCardOperationRequest.cs` |
| `UnlinkCustomerFromGiftCardRequest` | `src/Square/Models/UnlinkCustomerFromGiftCardRequest.cs` |
| `UnlinkCustomerFromGiftCardResponse` | `src/Square/Models/UnlinkCustomerFromGiftCardResponse.cs` |

