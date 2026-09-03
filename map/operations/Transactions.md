<!-- Generated file — do not edit; regenerated with the SDK. -->

# Transactions — operations

Accessor: `client.Transactions` · Source: `Api/Transactions.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CaptureTransaction

- **Auth**: `options.Oauth2`
- **Signature**: `CaptureTransaction(string locationId, string transactionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CaptureTransactionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CaptureTransactionResponse` | `Models/CaptureTransactionResponse.cs` |

### ListTransactions

- **Auth**: `options.Oauth2`
- **Signature**: `ListTransactions(string locationId, string? beginTime, string? endTime, SortOrder? sortOrder, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`beginTime` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `begin_time` ← `beginTime`, `end_time` ← `endTime`, `sort_order` ← `sortOrder`, `cursor` ← `cursor`
- **Returns**: `ListTransactionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `ListTransactionsResponse` | `Models/ListTransactionsResponse.cs` |

### RetrieveTransaction

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveTransaction(string locationId, string transactionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveTransactionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTransactionResponse` | `Models/RetrieveTransactionResponse.cs` |

### VoidTransaction

- **Auth**: `options.Oauth2`
- **Signature**: `VoidTransaction(string locationId, string transactionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `VoidTransactionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VoidTransactionResponse` | `Models/VoidTransactionResponse.cs` |

