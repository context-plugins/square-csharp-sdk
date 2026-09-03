<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payouts — operations

Accessor: `client.Payouts` · Source: `Api/Payouts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPayout

- **Auth**: `options.Oauth2`
- **Signature**: `GetPayout(string payoutId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetPayoutResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPayoutResponse` | `Models/GetPayoutResponse.cs` |

### ListPayoutEntries

- **Auth**: `options.Oauth2`
- **Signature**: `ListPayoutEntries(string payoutId, SortOrder? sortOrder, string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `sortOrder` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `sort_order` ← `sortOrder`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListPayoutEntriesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `ListPayoutEntriesResponse` | `Models/ListPayoutEntriesResponse.cs` |

### ListPayouts

- **Auth**: `options.Oauth2`
- **Signature**: `ListPayouts(string? locationId, PayoutStatus? status, string? beginTime, string? endTime, SortOrder? sortOrder, string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`locationId` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `location_id` ← `locationId`, `status` ← `status`, `begin_time` ← `beginTime`, `end_time` ← `endTime`, `sort_order` ← `sortOrder`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListPayoutsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PayoutStatus` | `Models/Enums/PayoutStatus.cs` |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `ListPayoutsResponse` | `Models/ListPayoutsResponse.cs` |

