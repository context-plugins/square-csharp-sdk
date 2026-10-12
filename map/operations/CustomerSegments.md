<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerSegments — operations

Accessor: `client.CustomerSegments` · Source: `src/Square/Api/CustomerSegments.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListCustomerSegments

- **Auth**: `options.Oauth2`
- **Signature**: `ListCustomerSegments(ListCustomerSegmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListCustomerSegmentsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerSegmentsRequest` | `src/Square/Requests/CustomerSegments/ListCustomerSegmentsRequest.cs` |
| `ListCustomerSegmentsResponse` | `src/Square/Models/ListCustomerSegmentsResponse.cs` |

### RetrieveCustomerSegment

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveCustomerSegment(RetrieveCustomerSegmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SegmentId`
- **Returns**: `RetrieveCustomerSegmentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerSegmentRequest` | `src/Square/Requests/CustomerSegments/RetrieveCustomerSegmentRequest.cs` |
| `RetrieveCustomerSegmentResponse` | `src/Square/Models/RetrieveCustomerSegmentResponse.cs` |

