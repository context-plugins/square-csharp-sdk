<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerSegments — operations

Accessor: `client.CustomerSegments` · Source: `Api/CustomerSegments.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListCustomerSegments

- **Signature**: `ListCustomerSegments(string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListCustomerSegmentsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerSegmentsResponse` | `Models/ListCustomerSegmentsResponse.cs` |

### RetrieveCustomerSegment

- **Signature**: `RetrieveCustomerSegment(string segmentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveCustomerSegmentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCustomerSegmentResponse` | `Models/RetrieveCustomerSegmentResponse.cs` |

