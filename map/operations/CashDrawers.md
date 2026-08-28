<!-- Generated file — do not edit; regenerated with the SDK. -->

# CashDrawers — operations

Accessor: `client.CashDrawers` · Source: `Api/CashDrawers.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListCashDrawerShiftEvents

- **Signature**: `ListCashDrawerShiftEvents(string shiftId, string locationId, int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `location_id` ← `locationId`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListCashDrawerShiftEventsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCashDrawerShiftEventsResponse` | `Models/ListCashDrawerShiftEventsResponse.cs` |

### ListCashDrawerShifts

- **Signature**: `ListCashDrawerShifts(string locationId, SortOrder? sortOrder, string? beginTime, string? endTime, int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`sortOrder` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `location_id` ← `locationId`, `sort_order` ← `sortOrder`, `begin_time` ← `beginTime`, `end_time` ← `endTime`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListCashDrawerShiftsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `ListCashDrawerShiftsResponse` | `Models/ListCashDrawerShiftsResponse.cs` |

### RetrieveCashDrawerShift

- **Signature**: `RetrieveCashDrawerShift(string shiftId, string locationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `location_id` ← `locationId`
- **Returns**: `RetrieveCashDrawerShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCashDrawerShiftResponse` | `Models/RetrieveCashDrawerShiftResponse.cs` |

