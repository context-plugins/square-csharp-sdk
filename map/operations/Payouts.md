<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payouts — operations

Accessor: `client.Payouts` · Source: `src/Square/Api/Payouts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPayout

- **Auth**: `options.Oauth2`
- **Signature**: `GetPayout(GetPayoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PayoutId`
- **Returns**: `GetPayoutResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPayoutRequest` | `src/Square/Requests/Payouts/GetPayoutRequest.cs` |
| `GetPayoutResponse` | `src/Square/Models/GetPayoutResponse.cs` |

### ListPayoutEntries

- **Auth**: `options.Oauth2`
- **Signature**: `ListPayoutEntries(ListPayoutEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PayoutId`
- **Query params (wire ← C#)**: `sort_order` ← `SortOrder`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListPayoutEntriesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPayoutEntriesRequest` | `src/Square/Requests/Payouts/ListPayoutEntriesRequest.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListPayoutEntriesResponse` | `src/Square/Models/ListPayoutEntriesResponse.cs` |

### ListPayouts

- **Auth**: `options.Oauth2`
- **Signature**: `ListPayouts(ListPayoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `status` ← `Status`, `begin_time` ← `BeginTime`, `end_time` ← `EndTime`, `sort_order` ← `SortOrder`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListPayoutsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPayoutsRequest` | `src/Square/Requests/Payouts/ListPayoutsRequest.cs` |
| `PayoutStatus` | `src/Square/Models/Enums/PayoutStatus.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListPayoutsResponse` | `src/Square/Models/ListPayoutsResponse.cs` |

