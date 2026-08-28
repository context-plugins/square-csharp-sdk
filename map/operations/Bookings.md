<!-- Generated file — do not edit; regenerated with the SDK. -->

# Bookings — operations

Accessor: `client.Bookings` · Source: `Api/Bookings.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkRetrieveBookings

- **Signature**: `BulkRetrieveBookings(BulkRetrieveBookingsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkRetrieveBookingsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveBookingsRequest` | `Models/BulkRetrieveBookingsRequest.cs` |
| `BulkRetrieveBookingsResponse` | `Models/BulkRetrieveBookingsResponse.cs` |

### BulkRetrieveTeamMemberBookingProfiles

- **Signature**: `BulkRetrieveTeamMemberBookingProfiles(BulkRetrieveTeamMemberBookingProfilesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkRetrieveTeamMemberBookingProfilesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveTeamMemberBookingProfilesRequest` | `Models/BulkRetrieveTeamMemberBookingProfilesRequest.cs` |
| `BulkRetrieveTeamMemberBookingProfilesResponse` | `Models/BulkRetrieveTeamMemberBookingProfilesResponse.cs` |

### CancelBooking

- **Signature**: `CancelBooking(string bookingId, CancelBookingRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelBookingResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelBookingRequest` | `Models/CancelBookingRequest.cs` |
| `CancelBookingResponse` | `Models/CancelBookingResponse.cs` |

### CreateBooking

- **Signature**: `CreateBooking(CreateBookingRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateBookingResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBookingRequest` | `Models/CreateBookingRequest.cs` |
| `CreateBookingResponse` | `Models/CreateBookingResponse.cs` |

### ListBookings

- **Signature**: `ListBookings(int? limit, string? cursor, string? customerId, string? teamMemberId, string? locationId, string? startAtMin, string? startAtMax, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`limit` … `startAtMax`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`, `customer_id` ← `customerId`, `team_member_id` ← `teamMemberId`, `location_id` ← `locationId`, `start_at_min` ← `startAtMin`, `start_at_max` ← `startAtMax`
- **Returns**: `ListBookingsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBookingsResponse` | `Models/ListBookingsResponse.cs` |

### ListLocationBookingProfiles

- **Signature**: `ListLocationBookingProfiles(int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListLocationBookingProfilesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLocationBookingProfilesResponse` | `Models/ListLocationBookingProfilesResponse.cs` |

### ListTeamMemberBookingProfiles

- **Signature**: `ListTeamMemberBookingProfiles(int? limit, string? cursor, string? locationId, bool? bookableOnly = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `locationId` — nullable, no default → **must pass explicitly**
  - defaults: `bookableOnly` = `false`
- **Query params (wire ← C#)**: `bookable_only` ← `bookableOnly`, `limit` ← `limit`, `cursor` ← `cursor`, `location_id` ← `locationId`
- **Returns**: `ListTeamMemberBookingProfilesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTeamMemberBookingProfilesResponse` | `Models/ListTeamMemberBookingProfilesResponse.cs` |

### RetrieveBooking

- **Signature**: `RetrieveBooking(string bookingId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveBookingResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveBookingResponse` | `Models/RetrieveBookingResponse.cs` |

### RetrieveBusinessBookingProfile

- **Signature**: `RetrieveBusinessBookingProfile(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveBusinessBookingProfileResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveBusinessBookingProfileResponse` | `Models/RetrieveBusinessBookingProfileResponse.cs` |

### RetrieveLocationBookingProfile

- **Signature**: `RetrieveLocationBookingProfile(string locationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveLocationBookingProfileResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationBookingProfileResponse` | `Models/RetrieveLocationBookingProfileResponse.cs` |

### RetrieveTeamMemberBookingProfile

- **Signature**: `RetrieveTeamMemberBookingProfile(string teamMemberId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveTeamMemberBookingProfileResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTeamMemberBookingProfileResponse` | `Models/RetrieveTeamMemberBookingProfileResponse.cs` |

### SearchAvailability

- **Signature**: `SearchAvailability(SearchAvailabilityRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchAvailabilityResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchAvailabilityRequest` | `Models/SearchAvailabilityRequest.cs` |
| `SearchAvailabilityResponse` | `Models/SearchAvailabilityResponse.cs` |

### UpdateBooking

- **Signature**: `UpdateBooking(string bookingId, UpdateBookingRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateBookingResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateBookingRequest` | `Models/UpdateBookingRequest.cs` |
| `UpdateBookingResponse` | `Models/UpdateBookingResponse.cs` |

