<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invoices — operations

Accessor: `client.Invoices` · Source: `src/Square/Api/Invoices.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `CancelInvoice(CancelInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceId`, `Body`
- **Returns**: `CancelInvoiceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelInvoiceOperationRequest` | `src/Square/Requests/Invoices/CancelInvoiceOperationRequest.cs` |
| `CancelInvoiceRequest` | `src/Square/Models/CancelInvoiceRequest.cs` |
| `CancelInvoiceResponse` | `src/Square/Models/CancelInvoiceResponse.cs` |

### CreateInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `CreateInvoice(CreateInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateInvoiceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInvoiceOperationRequest` | `src/Square/Requests/Invoices/CreateInvoiceOperationRequest.cs` |
| `CreateInvoiceRequest` | `src/Square/Models/CreateInvoiceRequest.cs` |
| `CreateInvoiceResponse` | `src/Square/Models/CreateInvoiceResponse.cs` |

### CreateInvoiceAttachment

- **Auth**: `options.Oauth2`
- **Signature**: `CreateInvoiceAttachment(CreateInvoiceAttachmentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceId`
- **Returns**: `CreateInvoiceAttachmentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInvoiceAttachmentOperationRequest` | `src/Square/Requests/Invoices/CreateInvoiceAttachmentOperationRequest.cs` |
| `CreateInvoiceAttachmentRequest` | `src/Square/Models/CreateInvoiceAttachmentRequest.cs` |
| `CreateInvoiceAttachmentResponse` | `src/Square/Models/CreateInvoiceAttachmentResponse.cs` |

### DeleteInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteInvoice(DeleteInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceId`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `DeleteInvoiceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteInvoiceRequest` | `src/Square/Requests/Invoices/DeleteInvoiceRequest.cs` |
| `DeleteInvoiceResponse` | `src/Square/Models/DeleteInvoiceResponse.cs` |

### DeleteInvoiceAttachment

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteInvoiceAttachment(DeleteInvoiceAttachmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceId`, `AttachmentId`
- **Returns**: `DeleteInvoiceAttachmentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteInvoiceAttachmentRequest` | `src/Square/Requests/Invoices/DeleteInvoiceAttachmentRequest.cs` |
| `DeleteInvoiceAttachmentResponse` | `src/Square/Models/DeleteInvoiceAttachmentResponse.cs` |

### GetInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `GetInvoice(GetInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceId`
- **Returns**: `GetInvoiceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetInvoiceRequest` | `src/Square/Requests/Invoices/GetInvoiceRequest.cs` |
| `GetInvoiceResponse` | `src/Square/Models/GetInvoiceResponse.cs` |

### ListInvoices

- **Auth**: `options.Oauth2`
- **Signature**: `ListInvoices(ListInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListInvoicesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListInvoicesRequest` | `src/Square/Requests/Invoices/ListInvoicesRequest.cs` |
| `ListInvoicesResponse` | `src/Square/Models/ListInvoicesResponse.cs` |

### PublishInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `PublishInvoice(PublishInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceId`, `Body`
- **Returns**: `PublishInvoiceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublishInvoiceOperationRequest` | `src/Square/Requests/Invoices/PublishInvoiceOperationRequest.cs` |
| `PublishInvoiceRequest` | `src/Square/Models/PublishInvoiceRequest.cs` |
| `PublishInvoiceResponse` | `src/Square/Models/PublishInvoiceResponse.cs` |

### SearchInvoices

- **Auth**: `options.Oauth2`
- **Signature**: `SearchInvoices(SearchInvoicesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchInvoicesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchInvoicesOperationRequest` | `src/Square/Requests/Invoices/SearchInvoicesOperationRequest.cs` |
| `SearchInvoicesRequest` | `src/Square/Models/SearchInvoicesRequest.cs` |
| `SearchInvoicesResponse` | `src/Square/Models/SearchInvoicesResponse.cs` |

### UpdateInvoice

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateInvoice(UpdateInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceId`, `Body`
- **Returns**: `UpdateInvoiceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateInvoiceOperationRequest` | `src/Square/Requests/Invoices/UpdateInvoiceOperationRequest.cs` |
| `UpdateInvoiceRequest` | `src/Square/Models/UpdateInvoiceRequest.cs` |
| `UpdateInvoiceResponse` | `src/Square/Models/UpdateInvoiceResponse.cs` |

