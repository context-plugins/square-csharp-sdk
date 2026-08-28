<!-- Generated file — do not edit; regenerated with the SDK. -->

# Cards — operations

Accessor: `client.Cards` · Source: `Api/Cards.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCard

- **Signature**: `CreateCard(CreateCardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCardRequest` | `Models/CreateCardRequest.cs` |
| `CreateCardResponse` | `Models/CreateCardResponse.cs` |

### DisableCard

- **Signature**: `DisableCard(string cardId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DisableCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DisableCardResponse` | `Models/DisableCardResponse.cs` |

### ListCards

- **Signature**: `ListCards(string? cursor, string? customerId, string? referenceId, SortOrder? sortOrder, bool? includeDisabled = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`cursor` … `sortOrder`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `includeDisabled` = `false`
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `customer_id` ← `customerId`, `include_disabled` ← `includeDisabled`, `reference_id` ← `referenceId`, `sort_order` ← `sortOrder`
- **Returns**: `ListCardsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `ListCardsResponse` | `Models/ListCardsResponse.cs` |

### RetrieveCard

- **Signature**: `RetrieveCard(string cardId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveCardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCardResponse` | `Models/RetrieveCardResponse.cs` |

