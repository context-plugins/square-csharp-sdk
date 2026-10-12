<!-- Generated file — do not edit; regenerated with the SDK. -->

# GiftCardActivities — operations

Accessor: `client.GiftCardActivities` · Source: `src/Square/Api/GiftCardActivities.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateGiftCardActivity

- **Auth**: `options.Oauth2`
- **Signature**: `CreateGiftCardActivity(CreateGiftCardActivityOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateGiftCardActivityResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateGiftCardActivityOperationRequest` | `src/Square/Requests/GiftCardActivities/CreateGiftCardActivityOperationRequest.cs` |
| `CreateGiftCardActivityRequest` | `src/Square/Models/CreateGiftCardActivityRequest.cs` |
| `CreateGiftCardActivityResponse` | `src/Square/Models/CreateGiftCardActivityResponse.cs` |

### ListGiftCardActivities

- **Auth**: `options.Oauth2`
- **Signature**: `ListGiftCardActivities(ListGiftCardActivitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `gift_card_id` ← `GiftCardId`, `type` ← `Type`, `location_id` ← `LocationId`, `begin_time` ← `BeginTime`, `end_time` ← `EndTime`, `limit` ← `Limit`, `cursor` ← `Cursor`, `sort_order` ← `SortOrder`
- **Returns**: `ListGiftCardActivitiesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListGiftCardActivitiesRequest` | `src/Square/Requests/GiftCardActivities/ListGiftCardActivitiesRequest.cs` |
| `ListGiftCardActivitiesResponse` | `src/Square/Models/ListGiftCardActivitiesResponse.cs` |

