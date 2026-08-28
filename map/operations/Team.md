<!-- Generated file — do not edit; regenerated with the SDK. -->

# Team — operations

Accessor: `client.Team` · Source: `Api/Team.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkCreateTeamMembers

- **Signature**: `BulkCreateTeamMembers(BulkCreateTeamMembersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkCreateTeamMembersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkCreateTeamMembersRequest` | `Models/BulkCreateTeamMembersRequest.cs` |
| `BulkCreateTeamMembersResponse` | `Models/BulkCreateTeamMembersResponse.cs` |

### BulkUpdateTeamMembers

- **Signature**: `BulkUpdateTeamMembers(BulkUpdateTeamMembersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkUpdateTeamMembersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpdateTeamMembersRequest` | `Models/BulkUpdateTeamMembersRequest.cs` |
| `BulkUpdateTeamMembersResponse` | `Models/BulkUpdateTeamMembersResponse.cs` |

### CreateJob

- **Signature**: `CreateJob(CreateJobRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateJobResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateJobRequest` | `Models/CreateJobRequest.cs` |
| `CreateJobResponse` | `Models/CreateJobResponse.cs` |

### CreateTeamMember

- **Signature**: `CreateTeamMember(CreateTeamMemberRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateTeamMemberResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTeamMemberRequest` | `Models/CreateTeamMemberRequest.cs` |
| `CreateTeamMemberResponse` | `Models/CreateTeamMemberResponse.cs` |

### ListJobs

- **Signature**: `ListJobs(string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`
- **Returns**: `ListJobsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListJobsResponse` | `Models/ListJobsResponse.cs` |

### RetrieveJob

- **Signature**: `RetrieveJob(string jobId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveJobResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveJobResponse` | `Models/RetrieveJobResponse.cs` |

### RetrieveTeamMember

- **Signature**: `RetrieveTeamMember(string teamMemberId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveTeamMemberResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTeamMemberResponse` | `Models/RetrieveTeamMemberResponse.cs` |

### RetrieveWageSetting

- **Signature**: `RetrieveWageSetting(string teamMemberId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveWageSettingResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveWageSettingResponse` | `Models/RetrieveWageSettingResponse.cs` |

### SearchTeamMembers

- **Signature**: `SearchTeamMembers(SearchTeamMembersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchTeamMembersResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTeamMembersRequest` | `Models/SearchTeamMembersRequest.cs` |
| `SearchTeamMembersResponse` | `Models/SearchTeamMembersResponse.cs` |

### UpdateJob

- **Signature**: `UpdateJob(string jobId, UpdateJobRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateJobResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateJobRequest` | `Models/UpdateJobRequest.cs` |
| `UpdateJobResponse` | `Models/UpdateJobResponse.cs` |

### UpdateTeamMember

- **Signature**: `UpdateTeamMember(string teamMemberId, UpdateTeamMemberRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateTeamMemberResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTeamMemberRequest` | `Models/UpdateTeamMemberRequest.cs` |
| `UpdateTeamMemberResponse` | `Models/UpdateTeamMemberResponse.cs` |

### UpdateWageSetting

- **Signature**: `UpdateWageSetting(string teamMemberId, UpdateWageSettingRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateWageSettingResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWageSettingRequest` | `Models/UpdateWageSettingRequest.cs` |
| `UpdateWageSettingResponse` | `Models/UpdateWageSettingResponse.cs` |

