<!-- Generated file — do not edit; regenerated with the SDK. -->

# BankAccounts — operations

Accessor: `client.BankAccounts` · Source: `src/Square/Api/BankAccounts.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateBankAccount

- **Auth**: `options.Oauth2`
- **Signature**: `CreateBankAccount(CreateBankAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateBankAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBankAccountOperationRequest` | `src/Square/Requests/BankAccounts/CreateBankAccountOperationRequest.cs` |
| `CreateBankAccountRequest` | `src/Square/Models/CreateBankAccountRequest.cs` |
| `CreateBankAccountResponse` | `src/Square/Models/CreateBankAccountResponse.cs` |

### DisableBankAccount

- **Auth**: `options.Oauth2`
- **Signature**: `DisableBankAccount(DisableBankAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BankAccountId`
- **Returns**: `DisableBankAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DisableBankAccountRequest` | `src/Square/Requests/BankAccounts/DisableBankAccountRequest.cs` |
| `DisableBankAccountResponse` | `src/Square/Models/DisableBankAccountResponse.cs` |

### GetBankAccount

- **Auth**: `options.Oauth2`
- **Signature**: `GetBankAccount(GetBankAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BankAccountId`
- **Returns**: `GetBankAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBankAccountRequest` | `src/Square/Requests/BankAccounts/GetBankAccountRequest.cs` |
| `GetBankAccountResponse` | `src/Square/Models/GetBankAccountResponse.cs` |

### GetBankAccountByV1Id

- **Auth**: `options.Oauth2`
- **Signature**: `GetBankAccountByV1Id(GetBankAccountByV1IdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `V1BankAccountId`
- **Returns**: `GetBankAccountByV1IdResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBankAccountByV1IdRequest` | `src/Square/Requests/BankAccounts/GetBankAccountByV1IdRequest.cs` |
| `GetBankAccountByV1IdResponse` | `src/Square/Models/GetBankAccountByV1IdResponse.cs` |

### ListBankAccounts

- **Auth**: `options.Oauth2`
- **Signature**: `ListBankAccounts(ListBankAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `limit` ← `Limit`, `location_id` ← `LocationId`, `customer_id` ← `CustomerId`
- **Returns**: `ListBankAccountsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBankAccountsRequest` | `src/Square/Requests/BankAccounts/ListBankAccountsRequest.cs` |
| `ListBankAccountsResponse` | `src/Square/Models/ListBankAccountsResponse.cs` |

