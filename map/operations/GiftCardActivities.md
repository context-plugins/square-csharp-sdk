<!-- Generated file — do not edit; regenerated with the SDK. -->

# GiftCardActivities — operations

Accessor: `client.GiftCardActivities` · Source: `Api/GiftCardActivities.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateGiftCardActivity

- **Signature**: `CreateGiftCardActivity(CreateGiftCardActivityRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateGiftCardActivityResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateGiftCardActivityRequest` | `Models/CreateGiftCardActivityRequest.cs` |
| `CreateGiftCardActivityResponse` | `Models/CreateGiftCardActivityResponse.cs` |

### ListGiftCardActivities

- **Signature**: `ListGiftCardActivities(string? giftCardId, string? type, string? locationId, string? beginTime, string? endTime, int? limit, string? cursor, string? sortOrder, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`giftCardId` … `sortOrder`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `gift_card_id` ← `giftCardId`, `type` ← `type`, `location_id` ← `locationId`, `begin_time` ← `beginTime`, `end_time` ← `endTime`, `limit` ← `limit`, `cursor` ← `cursor`, `sort_order` ← `sortOrder`
- **Returns**: `ListGiftCardActivitiesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListGiftCardActivitiesResponse` | `Models/ListGiftCardActivitiesResponse.cs` |

