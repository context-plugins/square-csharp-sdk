<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invoices — operations

Accessor: `client.Invoices` · Source: `Api/Invoices.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `CancelInvoice(string invoiceId, CancelInvoiceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelInvoiceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelInvoiceRequest` | `Models/CancelInvoiceRequest.cs` |
| `CancelInvoiceResponse` | `Models/CancelInvoiceResponse.cs` |

### CreateInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `CreateInvoice(CreateInvoiceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateInvoiceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInvoiceRequest` | `Models/CreateInvoiceRequest.cs` |
| `CreateInvoiceResponse` | `Models/CreateInvoiceResponse.cs` |

### CreateInvoiceAttachment

- **Auth**: `options.Oauth2`
- **Signature**: `CreateInvoiceAttachment(string invoiceId, CreateInvoiceAttachmentRequest? request, BinaryContent? imageFile, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `request` — nullable, no default → **must pass explicitly**
  - `imageFile` — nullable, no default → **must pass explicitly**
- **Returns**: `CreateInvoiceAttachmentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInvoiceAttachmentRequest` | `Models/CreateInvoiceAttachmentRequest.cs` |
| `CreateInvoiceAttachmentResponse` | `Models/CreateInvoiceAttachmentResponse.cs` |

### DeleteInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteInvoice(string invoiceId, int? version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `version` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `version` ← `version`
- **Returns**: `DeleteInvoiceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteInvoiceResponse` | `Models/DeleteInvoiceResponse.cs` |

### DeleteInvoiceAttachment

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteInvoiceAttachment(string invoiceId, string attachmentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteInvoiceAttachmentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteInvoiceAttachmentResponse` | `Models/DeleteInvoiceAttachmentResponse.cs` |

### GetInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `GetInvoice(string invoiceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetInvoiceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetInvoiceResponse` | `Models/GetInvoiceResponse.cs` |

### ListInvoices

- **Auth**: `options.Oauth2`
- **Signature**: `ListInvoices(string locationId, string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `location_id` ← `locationId`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListInvoicesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListInvoicesResponse` | `Models/ListInvoicesResponse.cs` |

### PublishInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `PublishInvoice(string invoiceId, PublishInvoiceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PublishInvoiceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublishInvoiceRequest` | `Models/PublishInvoiceRequest.cs` |
| `PublishInvoiceResponse` | `Models/PublishInvoiceResponse.cs` |

### SearchInvoices

- **Auth**: `options.Oauth2`
- **Signature**: `SearchInvoices(SearchInvoicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchInvoicesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchInvoicesRequest` | `Models/SearchInvoicesRequest.cs` |
| `SearchInvoicesResponse` | `Models/SearchInvoicesResponse.cs` |

### UpdateInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateInvoice(string invoiceId, UpdateInvoiceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateInvoiceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateInvoiceRequest` | `Models/UpdateInvoiceRequest.cs` |
| `UpdateInvoiceResponse` | `Models/UpdateInvoiceResponse.cs` |

