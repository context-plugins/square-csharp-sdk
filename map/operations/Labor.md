<!-- Generated file — do not edit; regenerated with the SDK. -->

# Labor — operations

Accessor: `client.Labor` · Source: `Api/Labor.cs` · 27 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkPublishScheduledShifts

- **Auth**: `options.Oauth2`
- **Signature**: `BulkPublishScheduledShifts(BulkPublishScheduledShiftsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkPublishScheduledShiftsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkPublishScheduledShiftsRequest` | `Models/BulkPublishScheduledShiftsRequest.cs` |
| `BulkPublishScheduledShiftsResponse` | `Models/BulkPublishScheduledShiftsResponse.cs` |

### CreateBreakType

- **Auth**: `options.Oauth2`
- **Signature**: `CreateBreakType(CreateBreakTypeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateBreakTypeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBreakTypeRequest` | `Models/CreateBreakTypeRequest.cs` |
| `CreateBreakTypeResponse` | `Models/CreateBreakTypeResponse.cs` |

### CreateScheduledShift

- **Auth**: `options.Oauth2`
- **Signature**: `CreateScheduledShift(CreateScheduledShiftRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateScheduledShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateScheduledShiftRequest` | `Models/CreateScheduledShiftRequest.cs` |
| `CreateScheduledShiftResponse` | `Models/CreateScheduledShiftResponse.cs` |

### CreateShift

- **Auth**: `options.Oauth2`
- **Signature**: `CreateShift(CreateShiftRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateShiftRequest` | `Models/CreateShiftRequest.cs` |
| `CreateShiftResponse` | `Models/CreateShiftResponse.cs` |

### CreateTimecard

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTimecard(CreateTimecardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTimecardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTimecardRequest` | `Models/CreateTimecardRequest.cs` |
| `CreateTimecardResponse` | `Models/CreateTimecardResponse.cs` |

### DeleteBreakType

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteBreakType(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteBreakTypeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteBreakTypeResponse` | `Models/DeleteBreakTypeResponse.cs` |

### DeleteShift

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteShift(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteShiftResponse` | `Models/DeleteShiftResponse.cs` |

### DeleteTimecard

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteTimecard(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteTimecardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteTimecardResponse` | `Models/DeleteTimecardResponse.cs` |

### GetBreakType

- **Auth**: `options.Oauth2`
- **Signature**: `GetBreakType(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetBreakTypeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBreakTypeResponse` | `Models/GetBreakTypeResponse.cs` |

### GetEmployeeWage

- **Auth**: `options.Oauth2`
- **Signature**: `GetEmployeeWage(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetEmployeeWageResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetEmployeeWageResponse` | `Models/GetEmployeeWageResponse.cs` |

### GetShift

- **Auth**: `options.Oauth2`
- **Signature**: `GetShift(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetShiftResponse` | `Models/GetShiftResponse.cs` |

### GetTeamMemberWage

- **Auth**: `options.Oauth2`
- **Signature**: `GetTeamMemberWage(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetTeamMemberWageResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTeamMemberWageResponse` | `Models/GetTeamMemberWageResponse.cs` |

### ListBreakTypes

- **Auth**: `options.Oauth2`
- **Signature**: `ListBreakTypes(string? locationId, int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `locationId` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `location_id` ← `locationId`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListBreakTypesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBreakTypesResponse` | `Models/ListBreakTypesResponse.cs` |

### ListEmployeeWages

- **Auth**: `options.Oauth2`
- **Signature**: `ListEmployeeWages(string? employeeId, int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `employeeId` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `employee_id` ← `employeeId`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListEmployeeWagesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEmployeeWagesResponse` | `Models/ListEmployeeWagesResponse.cs` |

### ListTeamMemberWages

- **Auth**: `options.Oauth2`
- **Signature**: `ListTeamMemberWages(string? teamMemberId, int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamMemberId` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `team_member_id` ← `teamMemberId`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListTeamMemberWagesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTeamMemberWagesResponse` | `Models/ListTeamMemberWagesResponse.cs` |

### ListWorkweekConfigs

- **Auth**: `options.Oauth2`
- **Signature**: `ListWorkweekConfigs(int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListWorkweekConfigsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListWorkweekConfigsResponse` | `Models/ListWorkweekConfigsResponse.cs` |

### PublishScheduledShift

- **Auth**: `options.Oauth2`
- **Signature**: `PublishScheduledShift(string id, PublishScheduledShiftRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PublishScheduledShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublishScheduledShiftRequest` | `Models/PublishScheduledShiftRequest.cs` |
| `PublishScheduledShiftResponse` | `Models/PublishScheduledShiftResponse.cs` |

### RetrieveScheduledShift

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveScheduledShift(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveScheduledShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveScheduledShiftResponse` | `Models/RetrieveScheduledShiftResponse.cs` |

### RetrieveTimecard

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveTimecard(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveTimecardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTimecardResponse` | `Models/RetrieveTimecardResponse.cs` |

### SearchScheduledShifts

- **Auth**: `options.Oauth2`
- **Signature**: `SearchScheduledShifts(SearchScheduledShiftsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchScheduledShiftsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchScheduledShiftsRequest` | `Models/SearchScheduledShiftsRequest.cs` |
| `SearchScheduledShiftsResponse` | `Models/SearchScheduledShiftsResponse.cs` |

### SearchShifts

- **Auth**: `options.Oauth2`
- **Signature**: `SearchShifts(SearchShiftsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchShiftsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchShiftsRequest` | `Models/SearchShiftsRequest.cs` |
| `SearchShiftsResponse` | `Models/SearchShiftsResponse.cs` |

### SearchTimecards

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTimecards(SearchTimecardsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTimecardsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTimecardsRequest` | `Models/SearchTimecardsRequest.cs` |
| `SearchTimecardsResponse` | `Models/SearchTimecardsResponse.cs` |

### UpdateBreakType

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateBreakType(string id, UpdateBreakTypeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateBreakTypeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateBreakTypeRequest` | `Models/UpdateBreakTypeRequest.cs` |
| `UpdateBreakTypeResponse` | `Models/UpdateBreakTypeResponse.cs` |

### UpdateScheduledShift

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateScheduledShift(string id, UpdateScheduledShiftRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateScheduledShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateScheduledShiftRequest` | `Models/UpdateScheduledShiftRequest.cs` |
| `UpdateScheduledShiftResponse` | `Models/UpdateScheduledShiftResponse.cs` |

### UpdateShift

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateShift(string id, UpdateShiftRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateShiftResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateShiftRequest` | `Models/UpdateShiftRequest.cs` |
| `UpdateShiftResponse` | `Models/UpdateShiftResponse.cs` |

### UpdateTimecard

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateTimecard(string id, UpdateTimecardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateTimecardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTimecardRequest` | `Models/UpdateTimecardRequest.cs` |
| `UpdateTimecardResponse` | `Models/UpdateTimecardResponse.cs` |

### UpdateWorkweekConfig

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateWorkweekConfig(string id, UpdateWorkweekConfigRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateWorkweekConfigResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWorkweekConfigRequest` | `Models/UpdateWorkweekConfigRequest.cs` |
| `UpdateWorkweekConfigResponse` | `Models/UpdateWorkweekConfigResponse.cs` |

