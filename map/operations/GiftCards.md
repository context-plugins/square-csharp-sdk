<!-- Generated file — do not edit; regenerated with the SDK. -->

# GiftCards — operations

Accessor: `client.GiftCards` · Source: `Api/GiftCards.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateGiftCard

- **Signature**: `CreateGiftCard(CreateGiftCardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateGiftCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateGiftCardRequest` | `Models/CreateGiftCardRequest.cs` |
| `CreateGiftCardResponse` | `Models/CreateGiftCardResponse.cs` |

### LinkCustomerToGiftCard

- **Signature**: `LinkCustomerToGiftCard(string giftCardId, LinkCustomerToGiftCardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LinkCustomerToGiftCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkCustomerToGiftCardRequest` | `Models/LinkCustomerToGiftCardRequest.cs` |
| `LinkCustomerToGiftCardResponse` | `Models/LinkCustomerToGiftCardResponse.cs` |

### ListGiftCards

- **Signature**: `ListGiftCards(string? type, string? state, int? limit, string? cursor, string? customerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`type` … `customerId`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `type` ← `type`, `state` ← `state`, `limit` ← `limit`, `cursor` ← `cursor`, `customer_id` ← `customerId`
- **Returns**: `ListGiftCardsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListGiftCardsResponse` | `Models/ListGiftCardsResponse.cs` |

### RetrieveGiftCard

- **Signature**: `RetrieveGiftCard(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveGiftCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveGiftCardResponse` | `Models/RetrieveGiftCardResponse.cs` |

### RetrieveGiftCardFromGan

- **Signature**: `RetrieveGiftCardFromGan(RetrieveGiftCardFromGanRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveGiftCardFromGanResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveGiftCardFromGanRequest` | `Models/RetrieveGiftCardFromGanRequest.cs` |
| `RetrieveGiftCardFromGanResponse` | `Models/RetrieveGiftCardFromGanResponse.cs` |

### RetrieveGiftCardFromNonce

- **Signature**: `RetrieveGiftCardFromNonce(RetrieveGiftCardFromNonceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveGiftCardFromNonceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveGiftCardFromNonceRequest` | `Models/RetrieveGiftCardFromNonceRequest.cs` |
| `RetrieveGiftCardFromNonceResponse` | `Models/RetrieveGiftCardFromNonceResponse.cs` |

### UnlinkCustomerFromGiftCard

- **Signature**: `UnlinkCustomerFromGiftCard(string giftCardId, UnlinkCustomerFromGiftCardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UnlinkCustomerFromGiftCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UnlinkCustomerFromGiftCardRequest` | `Models/UnlinkCustomerFromGiftCardRequest.cs` |
| `UnlinkCustomerFromGiftCardResponse` | `Models/UnlinkCustomerFromGiftCardResponse.cs` |

