<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payments — operations

Accessor: `client.Payments` · Source: `src/Square/Api/Payments.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelPayment

- **Auth**: `options.Oauth2`
- **Signature**: `CancelPayment(CancelPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentId`
- **Returns**: `CancelPaymentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelPaymentRequest` | `src/Square/Requests/Payments/CancelPaymentRequest.cs` |
| `CancelPaymentResponse` | `src/Square/Models/CancelPaymentResponse.cs` |

### CancelPaymentByIdempotencyKey

- **Auth**: `options.Oauth2`
- **Signature**: `CancelPaymentByIdempotencyKey(CancelPaymentByIdempotencyKeyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CancelPaymentByIdempotencyKeyResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelPaymentByIdempotencyKeyOperationRequest` | `src/Square/Requests/Payments/CancelPaymentByIdempotencyKeyOperationRequest.cs` |
| `CancelPaymentByIdempotencyKeyRequest` | `src/Square/Models/CancelPaymentByIdempotencyKeyRequest.cs` |
| `CancelPaymentByIdempotencyKeyResponse` | `src/Square/Models/CancelPaymentByIdempotencyKeyResponse.cs` |

### CompletePayment

- **Auth**: `options.Oauth2`
- **Signature**: `CompletePayment(CompletePaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentId`, `Body`
- **Returns**: `CompletePaymentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CompletePaymentOperationRequest` | `src/Square/Requests/Payments/CompletePaymentOperationRequest.cs` |
| `CompletePaymentRequest` | `src/Square/Models/CompletePaymentRequest.cs` |
| `CompletePaymentResponse` | `src/Square/Models/CompletePaymentResponse.cs` |

### CreatePayment

- **Auth**: `options.Oauth2`
- **Signature**: `CreatePayment(CreatePaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreatePaymentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreatePaymentOperationRequest` | `src/Square/Requests/Payments/CreatePaymentOperationRequest.cs` |
| `CreatePaymentRequest` | `src/Square/Models/CreatePaymentRequest.cs` |
| `CreatePaymentResponse` | `src/Square/Models/CreatePaymentResponse.cs` |

### GetPayment

- **Auth**: `options.Oauth2`
- **Signature**: `GetPayment(GetPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentId`
- **Returns**: `GetPaymentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPaymentRequest` | `src/Square/Requests/Payments/GetPaymentRequest.cs` |
| `GetPaymentResponse` | `src/Square/Models/GetPaymentResponse.cs` |

### ListPayments

- **Auth**: `options.Oauth2`
- **Signature**: `ListPayments(ListPaymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `begin_time` ← `BeginTime`, `end_time` ← `EndTime`, `sort_order` ← `SortOrder`, `cursor` ← `Cursor`, `location_id` ← `LocationId`, `total` ← `Total`, `last_4` ← `Last4`, `card_brand` ← `CardBrand`, `limit` ← `Limit`, `is_offline_payment` ← `IsOfflinePayment`, `offline_begin_time` ← `OfflineBeginTime`, `offline_end_time` ← `OfflineEndTime`, `updated_at_begin_time` ← `UpdatedAtBeginTime`, `updated_at_end_time` ← `UpdatedAtEndTime`, `sort_field` ← `SortField`
- **Returns**: `ListPaymentsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPaymentsRequest` | `src/Square/Requests/Payments/ListPaymentsRequest.cs` |
| `ListPaymentsRequestSortField` | `src/Square/Models/Enums/ListPaymentsRequestSortField.cs` |
| `ListPaymentsResponse` | `src/Square/Models/ListPaymentsResponse.cs` |

### UpdatePayment

- **Auth**: `options.Oauth2`
- **Signature**: `UpdatePayment(UpdatePaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentId`, `Body`
- **Returns**: `UpdatePaymentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdatePaymentOperationRequest` | `src/Square/Requests/Payments/UpdatePaymentOperationRequest.cs` |
| `UpdatePaymentRequest` | `src/Square/Models/UpdatePaymentRequest.cs` |
| `UpdatePaymentResponse` | `src/Square/Models/UpdatePaymentResponse.cs` |

