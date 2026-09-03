<!-- Generated file — do not edit; regenerated with the SDK. -->

# Refunds — operations

Accessor: `client.Refunds` · Source: `Api/Refunds.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPaymentRefund

- **Auth**: `options.Oauth2`
- **Signature**: `GetPaymentRefund(string refundId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetPaymentRefundResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPaymentRefundResponse` | `Models/GetPaymentRefundResponse.cs` |

### ListPaymentRefunds

- **Auth**: `options.Oauth2`
- **Signature**: `ListPaymentRefunds(string? beginTime, string? endTime, string? sortOrder, string? cursor, string? locationId, string? status, string? sourceType, int? limit, string? updatedAtBeginTime, string? updatedAtEndTime, ListPaymentRefundsRequestSortField? sortField, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 11 params (`beginTime` … `sortField`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `begin_time` ← `beginTime`, `end_time` ← `endTime`, `sort_order` ← `sortOrder`, `cursor` ← `cursor`, `location_id` ← `locationId`, `status` ← `status`, `source_type` ← `sourceType`, `limit` ← `limit`, `updated_at_begin_time` ← `updatedAtBeginTime`, `updated_at_end_time` ← `updatedAtEndTime`, `sort_field` ← `sortField`
- **Returns**: `ListPaymentRefundsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPaymentRefundsRequestSortField` | `Models/Enums/ListPaymentRefundsRequestSortField.cs` |
| `ListPaymentRefundsResponse` | `Models/ListPaymentRefundsResponse.cs` |

### RefundPayment

- **Auth**: `options.Oauth2`
- **Signature**: `RefundPayment(RefundPaymentRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RefundPaymentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RefundPaymentRequest` | `Models/RefundPaymentRequest.cs` |
| `RefundPaymentResponse` | `Models/RefundPaymentResponse.cs` |

