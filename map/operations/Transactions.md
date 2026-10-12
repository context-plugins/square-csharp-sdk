<!-- Generated file — do not edit; regenerated with the SDK. -->

# Transactions — operations

Accessor: `client.Transactions` · Source: `src/Square/Api/Transactions.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CaptureTransaction

- **Auth**: `options.Oauth2`
- **Signature**: `CaptureTransaction(CaptureTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `TransactionId`
- **Returns**: `CaptureTransactionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CaptureTransactionRequest` | `src/Square/Requests/Transactions/CaptureTransactionRequest.cs` |
| `CaptureTransactionResponse` | `src/Square/Models/CaptureTransactionResponse.cs` |

### ListTransactions

- **Auth**: `options.Oauth2`
- **Signature**: `ListTransactions(ListTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Query params (wire ← C#)**: `begin_time` ← `BeginTime`, `end_time` ← `EndTime`, `sort_order` ← `SortOrder`, `cursor` ← `Cursor`
- **Returns**: `ListTransactionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTransactionsRequest` | `src/Square/Requests/Transactions/ListTransactionsRequest.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListTransactionsResponse` | `src/Square/Models/ListTransactionsResponse.cs` |

### RetrieveTransaction

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveTransaction(RetrieveTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `TransactionId`
- **Returns**: `RetrieveTransactionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTransactionRequest` | `src/Square/Requests/Transactions/RetrieveTransactionRequest.cs` |
| `RetrieveTransactionResponse` | `src/Square/Models/RetrieveTransactionResponse.cs` |

### VoidTransaction

- **Auth**: `options.Oauth2`
- **Signature**: `VoidTransaction(VoidTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `TransactionId`
- **Returns**: `VoidTransactionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VoidTransactionRequest` | `src/Square/Requests/Transactions/VoidTransactionRequest.cs` |
| `VoidTransactionResponse` | `src/Square/Models/VoidTransactionResponse.cs` |

