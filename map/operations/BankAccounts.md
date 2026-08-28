<!-- Generated file — do not edit; regenerated with the SDK. -->

# BankAccounts — operations

Accessor: `client.BankAccounts` · Source: `Api/BankAccounts.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateBankAccount

- **Signature**: `CreateBankAccount(CreateBankAccountRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateBankAccountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBankAccountRequest` | `Models/CreateBankAccountRequest.cs` |
| `CreateBankAccountResponse` | `Models/CreateBankAccountResponse.cs` |

### DisableBankAccount

- **Signature**: `DisableBankAccount(string bankAccountId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DisableBankAccountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DisableBankAccountResponse` | `Models/DisableBankAccountResponse.cs` |

### GetBankAccount

- **Signature**: `GetBankAccount(string bankAccountId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetBankAccountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBankAccountResponse` | `Models/GetBankAccountResponse.cs` |

### GetBankAccountByV1Id

- **Signature**: `GetBankAccountByV1Id(string v1BankAccountId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetBankAccountByV1IdResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBankAccountByV1IdResponse` | `Models/GetBankAccountByV1IdResponse.cs` |

### ListBankAccounts

- **Signature**: `ListBankAccounts(string? cursor, int? limit, string? locationId, string? customerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`cursor` … `customerId`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`, `location_id` ← `locationId`, `customer_id` ← `customerId`
- **Returns**: `ListBankAccountsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBankAccountsResponse` | `Models/ListBankAccountsResponse.cs` |

