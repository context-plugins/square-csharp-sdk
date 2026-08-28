<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payments — operations

Accessor: `client.Payments` · Source: `Api/Payments.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelPayment

- **Signature**: `CancelPayment(string paymentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelPaymentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelPaymentResponse` | `Models/CancelPaymentResponse.cs` |

### CancelPaymentByIdempotencyKey

- **Signature**: `CancelPaymentByIdempotencyKey(CancelPaymentByIdempotencyKeyRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelPaymentByIdempotencyKeyResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelPaymentByIdempotencyKeyRequest` | `Models/CancelPaymentByIdempotencyKeyRequest.cs` |
| `CancelPaymentByIdempotencyKeyResponse` | `Models/CancelPaymentByIdempotencyKeyResponse.cs` |

### CompletePayment

- **Signature**: `CompletePayment(string paymentId, CompletePaymentRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CompletePaymentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CompletePaymentRequest` | `Models/CompletePaymentRequest.cs` |
| `CompletePaymentResponse` | `Models/CompletePaymentResponse.cs` |

### CreatePayment

- **Signature**: `CreatePayment(CreatePaymentRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreatePaymentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreatePaymentRequest` | `Models/CreatePaymentRequest.cs` |
| `CreatePaymentResponse` | `Models/CreatePaymentResponse.cs` |

### GetPayment

- **Signature**: `GetPayment(string paymentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetPaymentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPaymentResponse` | `Models/GetPaymentResponse.cs` |

### ListPayments

- **Signature**: `ListPayments(string? beginTime, string? endTime, string? sortOrder, string? cursor, string? locationId, long? total, string? last4, string? cardBrand, int? limit, string? offlineBeginTime, string? offlineEndTime, string? updatedAtBeginTime, string? updatedAtEndTime, ListPaymentsRequestSortField? sortField, bool? isOfflinePayment = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 14 params (`beginTime` … `sortField`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `isOfflinePayment` = `false`
- **Query params (wire ← C#)**: `begin_time` ← `beginTime`, `end_time` ← `endTime`, `sort_order` ← `sortOrder`, `cursor` ← `cursor`, `location_id` ← `locationId`, `total` ← `total`, `last_4` ← `last4`, `card_brand` ← `cardBrand`, `limit` ← `limit`, `is_offline_payment` ← `isOfflinePayment`, `offline_begin_time` ← `offlineBeginTime`, `offline_end_time` ← `offlineEndTime`, `updated_at_begin_time` ← `updatedAtBeginTime`, `updated_at_end_time` ← `updatedAtEndTime`, `sort_field` ← `sortField`
- **Returns**: `ListPaymentsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPaymentsRequestSortField` | `Models/Enums/ListPaymentsRequestSortField.cs` |
| `ListPaymentsResponse` | `Models/ListPaymentsResponse.cs` |

### UpdatePayment

- **Signature**: `UpdatePayment(string paymentId, UpdatePaymentRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdatePaymentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdatePaymentRequest` | `Models/UpdatePaymentRequest.cs` |
| `UpdatePaymentResponse` | `Models/UpdatePaymentResponse.cs` |

