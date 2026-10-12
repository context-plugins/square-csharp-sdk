<!-- Generated file — do not edit; regenerated with the SDK. -->

# CashDrawers — operations

Accessor: `client.CashDrawers` · Source: `src/Square/Api/CashDrawers.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListCashDrawerShiftEvents

- **Auth**: `options.Oauth2`
- **Signature**: `ListCashDrawerShiftEvents(ListCashDrawerShiftEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ShiftId`, `LocationId`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListCashDrawerShiftEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCashDrawerShiftEventsRequest` | `src/Square/Requests/CashDrawers/ListCashDrawerShiftEventsRequest.cs` |
| `ListCashDrawerShiftEventsResponse` | `src/Square/Models/ListCashDrawerShiftEventsResponse.cs` |

### ListCashDrawerShifts

- **Auth**: `options.Oauth2`
- **Signature**: `ListCashDrawerShifts(ListCashDrawerShiftsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `sort_order` ← `SortOrder`, `begin_time` ← `BeginTime`, `end_time` ← `EndTime`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListCashDrawerShiftsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCashDrawerShiftsRequest` | `src/Square/Requests/CashDrawers/ListCashDrawerShiftsRequest.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListCashDrawerShiftsResponse` | `src/Square/Models/ListCashDrawerShiftsResponse.cs` |

### RetrieveCashDrawerShift

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveCashDrawerShift(RetrieveCashDrawerShiftRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ShiftId`, `LocationId`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`
- **Returns**: `RetrieveCashDrawerShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCashDrawerShiftRequest` | `src/Square/Requests/CashDrawers/RetrieveCashDrawerShiftRequest.cs` |
| `RetrieveCashDrawerShiftResponse` | `src/Square/Models/RetrieveCashDrawerShiftResponse.cs` |

