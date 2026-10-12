<!-- Generated file — do not edit; regenerated with the SDK. -->

# Refunds — operations

Accessor: `client.Refunds` · Source: `src/Square/Api/Refunds.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPaymentRefund

- **Auth**: `options.Oauth2`
- **Signature**: `GetPaymentRefund(GetPaymentRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RefundId`
- **Returns**: `GetPaymentRefundResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPaymentRefundRequest` | `src/Square/Requests/Refunds/GetPaymentRefundRequest.cs` |
| `GetPaymentRefundResponse` | `src/Square/Models/GetPaymentRefundResponse.cs` |

### ListPaymentRefunds

- **Auth**: `options.Oauth2`
- **Signature**: `ListPaymentRefunds(ListPaymentRefundsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `begin_time` ← `BeginTime`, `end_time` ← `EndTime`, `sort_order` ← `SortOrder`, `cursor` ← `Cursor`, `location_id` ← `LocationId`, `status` ← `Status`, `source_type` ← `SourceType`, `limit` ← `Limit`, `updated_at_begin_time` ← `UpdatedAtBeginTime`, `updated_at_end_time` ← `UpdatedAtEndTime`, `sort_field` ← `SortField`
- **Returns**: `ListPaymentRefundsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPaymentRefundsRequest` | `src/Square/Requests/Refunds/ListPaymentRefundsRequest.cs` |
| `ListPaymentRefundsRequestSortField` | `src/Square/Models/Enums/ListPaymentRefundsRequestSortField.cs` |
| `ListPaymentRefundsResponse` | `src/Square/Models/ListPaymentRefundsResponse.cs` |

### RefundPayment

- **Auth**: `options.Oauth2`
- **Signature**: `RefundPayment(RefundPaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RefundPaymentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RefundPaymentOperationRequest` | `src/Square/Requests/Refunds/RefundPaymentOperationRequest.cs` |
| `RefundPaymentRequest` | `src/Square/Models/RefundPaymentRequest.cs` |
| `RefundPaymentResponse` | `src/Square/Models/RefundPaymentResponse.cs` |

